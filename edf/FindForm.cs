using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SubReal.EasyDuplicateFinder
{
    public partial class FindForm : Form
    {
        private EdfFiles _edfFiles;

        public FindForm()
        {
            InitializeComponent();

            ToggleEnabledUserControls(false);
        }

        private void ToggleEnabledUserControls(bool enabled)
        {
            btnShowDuplicates.Enabled = enabled;           
        }

        /// <summary>
        /// Показывает или скрывает панель ожидания.
        /// </summary>
        /// <param name="isBlock"><see langword="true"/> Показать панель.; <see langword="false"/> Скрыть панель.</param>
        private void BlockHeadControls(bool isBlock)
        {
            // Обрабатываем кнопки.
            btnStartFind.Enabled = !isBlock;
            chkSelectAllFiles.Enabled = !isBlock;
            // Устанавливаем курсор.
            Cursor = isBlock ? Cursors.WaitCursor : Cursors.Default;
        }

        #region ListView Updates

        /// <summary>
        /// Настройка объекта ListView для показа результатов.
        /// </summary>
        /// <param name="listView"></param>
        private static void FormatListView(ListView listView)
        {
            listView.BeginUpdate();
            listView.Columns.Clear();
            listView.Columns.Add("Имя файла", 370);  //0
            listView.Columns.Add("Размер", 90);       //1
            listView.Columns.Add("Дата создания", 110);   //2
            listView.Columns.Add("MD5", 220);           //3
            listView.Columns.Add("Дубли", 50);    //4          
            listView.Columns.Add("GUID", 220);    //5          
            listView.CheckBoxes = true;
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
            FormatListView(listView);

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
            FormatListView(listView);

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
            labelDuplicatesCount.Text = $"Найдено дубликатов {listView.Items.Count - _edfFiles.CountUnique}" +
                $" для {_edfFiles.CountUnique} файл(а,ов)";

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

            FormatListView(listView);

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

        #endregion ListView Updates

        private void BtnSelectDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbFolderPath.Text = folderBrowserDialog1.SelectedPath;
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
                _edfFiles = new EdfFiles(tbFolderPath.Text);

                if (_edfFiles.GetFiles())
                {
                    ToggleEnabledUserControls(true);
                    ShowListFiles(listView);
                    // Выводим информацию о найденных файлах.
                    lblCountFindedFiles.Text = $"Найдено {listView.Items.Count} файл(а,ов)";
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
        /// <summary>
        /// Получение количества отмеченных файлов.
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
        /// Получаем список отмеченных файлов.
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

            if (File.Exists(listViewAllDuplicates.SelectedItems[0].SubItems[0].Text))
            {
                Process.Start(new ProcessStartInfo("explorer.exe", @" /select, " + listViewAllDuplicates.SelectedItems[0].SubItems[0].Text));
            }
        }

        private void toolStripMenuItemDuplicates_ShowFile_Click(object sender, EventArgs e)
        {
            if (listViewDuplicates.SelectedItems.Count == 0)
                return;

            if (File.Exists(listViewAllDuplicates.SelectedItems[0].SubItems[0].Text))
            {
                Process.Start(new ProcessStartInfo("explorer.exe", @" /select, " + listViewDuplicates.SelectedItems[0].SubItems[0].Text));
            }
        }

        private void toolStripMenuItemDeleteOthers_Click(object sender, EventArgs e)
        {
            if (listViewDuplicates.SelectedItems.Count == 0)
                return;

            _edfFiles.DeleteAllCurrentDuplicatesFiles(listViewDuplicates.SelectedItems[0].SubItems[3].Text, listViewDuplicates.SelectedItems[0].SubItems[5].Text);            
            ShowListFiles(listView);
            ShowDuplicatesOnlyListFiles(listViewAllDuplicates);
            listViewDuplicates.SelectedItems[0].SubItems[4].Text = "0";
            ThereCanBeOnlyOne(listViewDuplicates, listViewDuplicates.SelectedItems[0]);
        }
    }
}
