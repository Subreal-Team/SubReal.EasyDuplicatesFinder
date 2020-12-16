using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Text.Json;
using SubReal.EasyDuplicateFinder;

namespace SubReal.EasyDuplicatesFinder
{
    public partial class FindForm : Form
    {
        private EdfFiles _edfFiles;     
        
        const string optionsFileName = "edf-settings.json";
        public class OptionsEDF
        {
            public bool DisableQuestions { get; set; } = false;
            public bool EnableFullDelete { get; set; } = false;
            public bool EnableShowTabDuplicated { get; set; } = false;
        } 

        public FindForm()
        {
            Assembly assem = typeof(FindForm).Assembly;
            InitializeComponent();

            ToggleEnabledUserControls(false);
            AssemblyName assemName = assem.GetName();
            var ver = $"версия {assemName.Version.ToString()} ";
            this.Text = $"Простой поиск дубликатов файлов {ver}";
            textBoxFolderPath.Text = Debugger.IsAttached ? @"c:\edf.test" : Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            
            ToolTip toolTipHint = new ToolTip();
            toolTipHint.ShowAlways = true;
            toolTipHint.SetToolTip(buttonSelectDirectory, "Выбрать папку для поиска");
            toolTipHint.SetToolTip(buttonStartFind, "Выполнить поиск в папке");
            toolTipHint.SetToolTip(buttonShowDuplicates, "Показать дубликаты");
            toolTipHint.SetToolTip(buttonGoToFile, "Перейти к выбранному файлу");
            toolTipHint.SetToolTip(buttonDeleteDuplicates, "Удалить дубликаты выбранного файла");
            toolTipHint.SetToolTip(buttonDeleteChekedFiles, "Удалить отмеченные файлы");
            toolTipHint.SetToolTip(checkBoxDisableMessages, "Подтверждений при удалении больше не будет. Будьте внимательны.");
            toolTipHint.SetToolTip(checkBoxEnableFullDelete, "Включает удаление файлов минуя корзину. Файлы будут удаляется не в корзину, а безвозвратно.");
            toolTipHint.SetToolTip(checkBoxGoToDuplicatesIfFind, "Если в результате поиска найдены дубликаты файлов, автоматически открывается вкладка 'Дубликаты'.");
            toolTipHint.SetToolTip(checkBoxSortOnDefault, "Включает сортировку по-умолчанию.");

            toolTipHint.SetToolTip(linkLabelToSubRealCom, "Перейти на сайт разработчиков");
            //toolTipHint.SetToolTip(linkLabelToSubRealComEDF, "Перейти к странице программы на сайте разработчика");
            //toolTipHint.SetToolTip(linkLabelGoToGitHub, "Перейти к странице программы на GitHub");

            FormatListView(listView);
            FormatListView(listViewAllDuplicates);
            FormatListView(listViewDuplicates, true);
        }

        private bool SaveOptions(string fileName)
        {
            var options = new OptionsEDF { DisableQuestions = checkBoxDisableMessages.Checked, EnableFullDelete = checkBoxEnableFullDelete.Checked, EnableShowTabDuplicated = checkBoxGoToDuplicatesIfFind.Checked};
            string json = JsonSerializer.Serialize<OptionsEDF>(options);

            File.WriteAllText(fileName, json);
            return true;
         }

        private bool LoadOptions(string fileName)
        {
            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
                var options = JsonSerializer.Deserialize<OptionsEDF>(json);
                ApplyOptions(options);
                return true;
            }
            else
            {
                var options = new OptionsEDF();
                ApplyOptions(options);
                return false;
            }
        }

        private void ApplyOptions(OptionsEDF options)
        {
            checkBoxDisableMessages.Checked = options.DisableQuestions;
            checkBoxEnableFullDelete.Checked = options.EnableFullDelete;
            checkBoxGoToDuplicatesIfFind.Checked = options.EnableShowTabDuplicated;
            checkBoxEnableFullDelete.Tag = 1;  // используется как флаг
            buttonSaveOptions.Enabled = false;        
        }

        private void ToggleEnabledUserControls(bool enabled)
        {
            buttonShowDuplicates.Enabled = enabled;
        }

        /// <summary>
        /// Показывает или скрывает панель ожидания.
        /// </summary>
        /// <param name="isBlock"><see langword="true"/> Показать панель.; <see langword="false"/> Скрыть панель.</param>
        private void BlockHeadControls(bool isBlock)
        {
            // Обрабатываем кнопки.
            buttonStartFind.Enabled = !isBlock;
            chkSelectAllFiles.Enabled = !isBlock;
            // Устанавливаем курсор.
            Cursor = isBlock ? Cursors.WaitCursor : Cursors.Default;
        }

        #region ListView Updates

        /// <summary>
        /// Настройка объекта ListView для показа результатов.
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="showCheckBoxs">true - show check-boxes, false - hide</param>
        private static void FormatListView(ListView listView, bool showCheckBoxs = false)
        {
            listView.BeginUpdate();

            listView.Columns.Clear();
            listView.Columns.Add("Имя файла", 370);  //0
            listView.Columns.Add("Размер", 90);       //1
            listView.Columns.Add("Дата создания", 115);   //2
            listView.Columns.Add("MD5", 225);           //3
            listView.Columns.Add("Дубли", 50);    //4          
            listView.Columns.Add("GUID", 220);    //5          
            listView.CheckBoxes = showCheckBoxs;
            listView.GridLines = true;
            listView.Columns[5].Width = Debugger.IsAttached ? 220 : 0;

            listView.EndUpdate();
        }

        private ListViewItem CreateListViewItem(FileDesc fileDesc)
        {
            var lvi = new ListViewItem
            {
                Text = fileDesc.Name,
                ImageIndex = 0
            };

            lvi.SubItems.Add(fileDesc.Size.ToString());
            lvi.SubItems.Add(fileDesc.CreationTime.ToString());
            lvi.SubItems.Add(fileDesc.MD5Summ);
            lvi.SubItems.Add(fileDesc.CountDuplicates.ToString());
            lvi.SubItems.Add(fileDesc.Guid.ToString());

            return lvi;
        }

        /// <summary>
        /// Показ результата в ListView.
        /// </summary>
        public void ShowListFiles(ListView listView)
        {          
            listView.BeginUpdate();
            listView.Items.Clear();

            foreach (var file in _edfFiles.FullListFiles)
            {
                var lvi = CreateListViewItem(file);
                listView.Items.Add(lvi);
            }

            listView.EndUpdate();
        }

        /// <summary>
        /// Показ дубликаты в ListView.
        /// </summary>
        public void ShowDuplicatesOnlyListFiles(ListView listView)
        {         
            listView.BeginUpdate();
            listView.Items.Clear();
            foreach (var file in _edfFiles.FullListFiles)
            {
                if (file.CountDuplicates > 0)
                {
                    var lvi = CreateListViewItem(file);
                    listView.Items.Add(lvi);
                }
            }
            labelDuplicatesCount.Text = $"Найдено дубликатов {_edfFiles.GetDuplicatesCount}" +
                $" для {_edfFiles.GetUniqueCount} файл(а,ов)";

            listView.Sorting = (listView.Sorting == SortOrder.Ascending) ? SortOrder.Descending : SortOrder.Ascending;
            listView.Sort();
            listView.ListViewItemSorter = new ListViewItemStringComparer(3, listView.Sorting);
            listView.EndUpdate();
        }

        /// <summary>
        /// Показ конкретного дубликата в ListView.
        /// </summary>
        /// <param name="listView"></param>
        public void ShowCurrentDuplicatesListFiles(ListView listView, string MD5Summ)
        {
            if (MD5Summ == string.Empty)
            {
                MessageBox.Show(
                    "Для указанного файла нет дубликатов",
                    "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            listView.BeginUpdate();
            listView.Items.Clear();
            foreach (var fileDesc in _edfFiles.FullListFiles)
            {
                if (fileDesc.MD5Summ == MD5Summ)
                {
                    var lvi = CreateListViewItem(fileDesc);
                    listView.Items.Add(lvi);
                }
            }

            listView.EndUpdate();
        }

        /// <summary>
        /// Установка или снятие флага отметки файлов в списке.
        /// </summary>
        /// <param name="checkAll"><see langword="true"/>Отметить все.<see langword="false"/>Снять отметку у всех.</param>
        private void CheckAllFiles(bool checkAll)
        {
            // Меняем статус checkBox в зависимости от задачи.
            chkSelectAllFiles.Text = (checkAll) ? "Снять чек со всех" : "Выбрать все";
            chkSelectAllFiles.CheckState = (checkAll) ? CheckState.Checked : CheckState.Unchecked;
            listView.BeginUpdate();
            // Обходим список и устанавливаем/снимаем флаг.
            foreach (ListViewItem l in listView.Items)
            {
                l.Checked = checkAll;
            }
            listView.EndUpdate();
        }

        /// <summary>
        /// Очистка всех списков.
        /// </summary>
        private void ClearAllItemsListsView()
        {
            listView.Items.Clear();
            listViewAllDuplicates.Items.Clear();
            listViewDuplicates.Items.Clear();
        }

        /// <summary>
        /// Удаление из списка всех файлов кроме основного.
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="l"></param>
        private void ThereCanBeOnlyOne(ListView listView, ListViewItem l)
        {
            listView.Items.Clear();
            listView.Items.Add(l);
        }

        /// <summary>
        /// Implements the manual sorting of items by Integer column.
        /// </summary>
        private class ListViewItemIntComparer : IComparer
        {
            private int col;
            private SortOrder order;
            public ListViewItemIntComparer()
            {
                col = 0;
                order = SortOrder.Ascending;
            }

            public ListViewItemIntComparer(int column, SortOrder order)
            {
                col = column;
                this.order = order;
            }

            public int Compare(object x, object y)
            {
                int returnVal = -1;
                try
                {
                    int firstInt =
                            int.Parse(((ListViewItem)x).SubItems[col].Text);
                    int secondInt =
                            int.Parse(((ListViewItem)y).SubItems[col].Text);

                    returnVal = (order == SortOrder.Descending) ? secondInt.CompareTo(firstInt) : firstInt.CompareTo(secondInt);
    
                }
                catch
                {
                    returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
                                               ((ListViewItem)y).SubItems[col].Text);
                }                  

                return returnVal;
            }
        }

        /// <summary>
        /// Implements the manual sorting of items by String column.
        /// </summary>
        private class ListViewItemStringComparer : IComparer
        {
            private int col;
            private SortOrder order;
            public ListViewItemStringComparer()
            {
                col = 0;
                order = SortOrder.Ascending;
            }

            public ListViewItemStringComparer(int column, SortOrder order)
            {
                col = column;
                this.order = order;
            }

            public int Compare(object x, object y)
            {
                int returnVal = -1;
                returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
                                           ((ListViewItem)y).SubItems[col].Text);

                if (order == SortOrder.Descending)
                    returnVal *= -1;

                return returnVal;
            }
        }
        /// <summary>
        /// Implements the manual sorting of items by DateTime column.
        /// </summary>
        private class ListViewItemDateTimeComparer : IComparer
        {
            private int col;
            private SortOrder order;
            public ListViewItemDateTimeComparer()
            {
                col = 0;
                order = SortOrder.Ascending;
            }

            public ListViewItemDateTimeComparer(int column, SortOrder order)
            {
                col = column;
                this.order = order;
            }

            public int Compare(object x, object y)
            {
                int returnVal;
                try
                {
                    DateTime firstDate =
                            DateTime.Parse(((ListViewItem)x).SubItems[col].Text);
                    DateTime secondDate =
                            DateTime.Parse(((ListViewItem)y).SubItems[col].Text);

                    returnVal = DateTime.Compare(firstDate, secondDate);
                }
                catch
                {
                    returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
                                               ((ListViewItem)y).SubItems[col].Text);
                }
                if (order == SortOrder.Descending)
                    returnVal *= -1;

                return returnVal;
            }
        }


        #endregion ListView Updates

        private void BtnSelectDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxFolderPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void BtnStartFind_Click(object sender, EventArgs e)
        {
            var watch = Stopwatch.StartNew();

            ClearAllItemsListsView();

            tabControl.SelectedTab = tabFilesPage;

            BlockHeadControls(true);

            try
            {
                _edfFiles = new EdfFiles(textBoxFolderPath.Text, checkBoxEnableFullDelete.Checked);

                if (_edfFiles.GetFiles())
                {
                    ToggleEnabledUserControls(true);
                    ShowListFiles(listView);
                    // Выводим информацию о найденных файлах.
                    lblCountFindedFiles.Text = $"Найдено {_edfFiles.GetTotalCount} файл(а,ов)";
                    // Устанавливаем параметры общего выделения.
                    CheckAllFiles(false);
                }
                else
                {
                    ToggleEnabledUserControls(false);
                    MessageBox.Show(
                        "Указанный путь не существует. Поиск невозможен.",
                        "Ошибка имени пути",
                        MessageBoxButtons.OK);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    exception.Message,
                    "Ошибка при обработке каталога",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                BlockHeadControls(false);
            }

            ShowDuplicatesOnlyListFiles(listViewAllDuplicates);
            if (checkBoxGoToDuplicatesIfFind.Checked && _edfFiles.GetDuplicatesCount > 0)
            {
                tabControl.SelectTab(tabDuplicatesPage);
            }
            watch.Stop();
            lblTimeWork.Text = $"Время работы: {watch.Elapsed}";
        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            var watch = Stopwatch.StartNew();
            BlockHeadControls(true);
            CheckAllFiles(chkSelectAllFiles.Checked);
            BlockHeadControls(false);
            watch.Stop();
            lblTimeWork.Text = $"Время работы: {watch.Elapsed}";
        }

        private void SetStatusButtons()
        {
            buttonDeleteDuplicates.Enabled = isContainsfiles(listViewDuplicates);
            buttonDeleteChekedFiles.Enabled = buttonDeleteDuplicates.Enabled;
            buttonDeleteDuplicates.Refresh();
        }

        private bool isContainsfiles (ListView list)
        {
            return (list.Items.Count > 0) ? true : false;
        }

        /// <summary>
        /// Получить количество отмеченных файлов.
        /// </summary>
        /// <param name="list">ListView</param>
        /// <returns></returns>
        private int CountCheckedFiles(ListView list)
        {
            int count = 0;
            foreach (ListViewItem l in list.Items)
            {
                if (l.Checked)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Получить список отмеченных файлов.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private string[] GetCheckFiles(ListView list)
        {
            var fileLists = new string[CountCheckedFiles(listView)];
            int count = 0;
            foreach (ListViewItem l in listView.Items)
            {
                if (l.Checked)
                {
                    fileLists[count] = l.Text;
                    count++;
                }
            }
            return fileLists;
        }
        /// <summary>
        /// Открытие файла ассоциированной для расширения программой.
        /// </summary>
        /// <param name="fileName">Полный путь к файлу.</param>
        /// <returns><see langword="true "/>Для успешного запуска.</returns>
        private bool OpenFileByPath(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return false;
            }
            
            try
            {
                var proc = new Process
                {
                    StartInfo =
                    {
                        FileName = fileName, 
                        UseShellExecute = true
                    }
                };

                return proc.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,
                    "Ошибка при открытии файла",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            return false;
        }

        private void ShowFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
                return;

            if (File.Exists(listView.SelectedItems[0].SubItems[0].Text))
            {
                Process.Start(new ProcessStartInfo("explorer.exe", @" /select, " + listView.SelectedItems[0].SubItems[0].Text));
            }
        }

        private void btnShowDuplicates_Click(object sender, EventArgs e)
        {
            if (listViewAllDuplicates.SelectedItems.Count == 0)
                return;

            ShowCurrentDuplicatesListFiles(listViewDuplicates, listViewAllDuplicates.SelectedItems[0].SubItems[3].Text);
            SetStatusButtons();
        }

        private void DeleteOthersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewDuplicates.SelectedItems.Count == 0)
                return;

            _edfFiles.DeleteAllCurrentDuplicatesFiles(listViewDuplicates.SelectedItems[0].SubItems[3].Text, listViewDuplicates.SelectedItems[0].SubItems[5].Text);
            ShowListFiles(listView);
            ShowDuplicatesOnlyListFiles(listViewAllDuplicates);
        }

        private void toolStripMenuItemAllDuplicates_ShowFile_Click(object sender, EventArgs e)
        {
            if (listViewAllDuplicates.SelectedItems.Count == 0)
                return;

            GoToExplorer(listViewAllDuplicates.SelectedItems[0].SubItems[0].Text);
        }

        private void toolStripMenuItemDuplicates_ShowFile_Click(object sender, EventArgs e)
        {
            if (listViewDuplicates.SelectedItems.Count == 0)
                return;

            GoToExplorer(listViewAllDuplicates.SelectedItems[0].SubItems[0].Text);
        }
        
        private static void GoToExplorer(string fileName)
        {
            if (File.Exists(fileName))
            {
                Process.Start(new ProcessStartInfo("explorer.exe",
                    @" /select, " + fileName));
            }
        }

        private void toolStripMenuItemDeleteOthers_Click(object sender, EventArgs e)
        {
            if (listViewDuplicates.SelectedItems.Count == 0)
            {
                if (!checkBoxDisableMessages.Checked)
                {
                    MessageBox.Show("Не выбран основной файл. Невозможно определить файлы для удаления.",
                                     "Ошибка",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error
                                      );
                }
                return;
            }
            if (!checkBoxDisableMessages.Checked)
            {
               var result = MessageBox.Show("Удалить дубликаты выбранного файла в корзину?",
                                "Подтверждение удаления",
                                 MessageBoxButtons.OKCancel,
                                 MessageBoxIcon.Question
                                 );
                if (result == DialogResult.Cancel) 
                    return;
            }
            _edfFiles.DeleteAllCurrentDuplicatesFiles(listViewDuplicates.SelectedItems[0].SubItems[3].Text, listViewDuplicates.SelectedItems[0].SubItems[5].Text);
            ShowListFiles(listView);
            ShowDuplicatesOnlyListFiles(listViewAllDuplicates);
            listViewDuplicates.SelectedItems[0].SubItems[4].Text = "0";
            ThereCanBeOnlyOne(listViewDuplicates, listViewDuplicates.SelectedItems[0]);
            listViewDuplicates.Items.Clear();
            SetStatusButtons();
        }

        private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListView lv = (ListView)sender;

            lv.Sorting = (lv.Sorting == SortOrder.Ascending) ? SortOrder.Descending : SortOrder.Ascending;
            lv.Sort();
            if (e.Column == lv.Columns[2].Index)
                lv.ListViewItemSorter = new ListViewItemDateTimeComparer(e.Column, lv.Sorting);
            else if (e.Column == lv.Columns[1].Index || e.Column == lv.Columns[4].Index)
                lv.ListViewItemSorter = new ListViewItemIntComparer(e.Column, lv.Sorting);
            else
                lv.ListViewItemSorter = new ListViewItemStringComparer(e.Column, lv.Sorting);
        }

        private void linkLabelToSubRealCom_Click(object sender, EventArgs e)
        {
            Process.Start("https://subreal-team.com/");
        }

        private void deleteChekedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO:  Вставить проверку наличия дублей   
            var countCheckedFiles = CountCheckedFiles(listViewDuplicates);

            if (countCheckedFiles <= 0)
            {
                if (!checkBoxDisableMessages.Checked)
                {
                    MessageBox.Show("Не выбраны файлы для удаления",
                                     "Ошибка",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error
                                      );
                }

                return;
            }

            if (countCheckedFiles == listViewDuplicates.Items.Count)
            {
                var result = MessageBox.Show("Вы уверены что хотите удалить все файлы корзину?",
                                 "Подтверждение удаления",
                                  MessageBoxButtons.OKCancel,
                                  MessageBoxIcon.Question
                                  );
                if (result == DialogResult.Cancel)
                    return;
            }

            _edfFiles.DeleteCheckedFiles(listViewDuplicates);
            ShowListFiles(listView);
            ShowDuplicatesOnlyListFiles(listViewAllDuplicates);
            listViewDuplicates.Items.Clear();
            SetStatusButtons();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            if (tabControl.SelectedTab == tabFilesPage)
            {
                if (listView.SelectedItems.Count != 0)
                {
                    GoToExplorer(listView.SelectedItems[0].SubItems[0].Text);
                }
            }
            else if (tabControl.SelectedTab == tabDuplicatesPage)
            {
                if (listViewDuplicates.SelectedItems.Count != 0)
                {
                    GoToExplorer(listViewDuplicates.SelectedItems[0].SubItems[0].Text);
                }
                else if (listViewAllDuplicates.SelectedItems.Count != 0)
                {
                    GoToExplorer(listViewAllDuplicates.SelectedItems[0].SubItems[0].Text);
                }
            }
        }

        private void openFileListView_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
                return;
            OpenFileByPath(listView.SelectedItems[0].SubItems[0].Text);
        }

        private void openFileAllDuplicates_Click(object sender, EventArgs e)
        {
            if (listViewAllDuplicates.SelectedItems.Count == 0)
                return;
            OpenFileByPath(listViewAllDuplicates.SelectedItems[0].SubItems[0].Text);
        }

        private void OpenFileDuplicates_Click(object sender, EventArgs e)
        {
            if (listViewDuplicates.SelectedItems.Count == 0)
                return;
            OpenFileByPath(listViewDuplicates.SelectedItems[0].SubItems[0].Text);
        }

        private void toolStripMenuItemDeleteAllOthers_Click(object sender, EventArgs e)
        {
            // TODO:  Вставить проверку наличия дублей   
            //
            if (listViewAllDuplicates.SelectedItems.Count == 0)
                return;
            if (!checkBoxDisableMessages.Checked)
            {
                var result = MessageBox.Show("Удалить дубликаты выбранного файла в корзину?",
                                 "Подтверждение удаления",
                                  MessageBoxButtons.OKCancel,
                                  MessageBoxIcon.Question
                                  );
                if (result == DialogResult.Cancel)
                    return;
            }

            _edfFiles.DeleteAllCurrentDuplicatesFiles(listViewAllDuplicates.SelectedItems[0].SubItems[3].Text,                                                                          listViewAllDuplicates.SelectedItems[0].SubItems[5].Text);
            ShowListFiles(listView);
            ShowDuplicatesOnlyListFiles(listViewAllDuplicates);
           // listViewDuplicates.SelectedItems[0].SubItems[4].Text = "0";
//            ThereCanBeOnlyOne(listViewAllDuplicates, listViewDuplicates.SelectedItems[0]);
            listViewDuplicates.Items.Clear();

        }

        private void checkBoxEnableFullDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(checkBoxEnableFullDelete.Tag) == 1 && checkBoxEnableFullDelete.Checked)
            {
                var result = MessageBox.Show("Вы действительно хотите удалять файлы безвозвратно?",
                                 "Внимание!",
                                  MessageBoxButtons.OKCancel,
                                  MessageBoxIcon.Warning
                                  );
                if (result == DialogResult.Cancel) 
                {
                    checkBoxEnableFullDelete.Checked = false;
                    return;
                }
                    
            }
            if (_edfFiles != null)
                _edfFiles.SetFullDeleteFiles = checkBoxEnableFullDelete.Checked;
            buttonSaveOptions.Enabled = true;
        }

        private void buttonSaveOptions_Click(object sender, EventArgs e)
        {
            SaveOptions(optionsFileName);
            buttonSaveOptions.Enabled = false;            
        }

        private void checkBoxDisableMessages_CheckedChanged(object sender, EventArgs e)
        {
            buttonSaveOptions.Enabled = true;
        }

        private void checkBoxGoToDuplicatesIfFind_CheckedChanged(object sender, EventArgs e)
        {
            buttonSaveOptions.Enabled = true;
        }

        private void FindForm_Load(object sender, EventArgs e)
        {
            LoadOptions(optionsFileName);
        }

        private void FindForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveOptions(optionsFileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }
    }
}
