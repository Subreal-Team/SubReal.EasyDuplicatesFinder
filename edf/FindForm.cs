using System;
using System.Collections;
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
            btnRemove.Enabled = enabled;
            btnDuplicates.Enabled = enabled;
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
            BlockHeadControls(true);

            try
            {
                _edfFiles = new EdfFiles(tbFolderPath.Text);

                if (_edfFiles.GetFiles())
                {
                    ToggleEnabledUserControls(true);
                    _edfFiles.ShowListFiles(listView);
                    // Выводим информацию о найденых файлах.
                    lblCountFindedFiles.Text = string.Format("Find {0} file(s)", listView.Items.Count);
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
        class ListViewColumnComparer : IComparer
        {
            public int ColumnIndex { get; set; }
            public ListViewColumnComparer(int columnIndex)
            {
                ColumnIndex = columnIndex;
            }
            public int Compare(object x, object y)
            {
                try
                {
                    return String.Compare(
                    ((ListViewItem)x).SubItems[ColumnIndex].Text,
                    ((ListViewItem)y).SubItems[ColumnIndex].Text);
                }
                catch (Exception) // если вдруг столбец пустой (или что-то пошло не так)
                {
                    return 0;
                }
            }
        }
        public class Part : IEquatable<Part>
        {
            public string PartName { get; set; }
            public int PartId { get; set; }
            public override string ToString()
            {
                return "ID: " + PartId + "   Name: " + PartName;
            }
            public override bool Equals(object obj)
            {
                if (obj == null) return false;
                Part objAsPart = obj as Part;
                if (objAsPart == null) return false;
                else return Equals(objAsPart);
            }
            public override int GetHashCode()
            {
                return PartId;
            }
            public bool Equals(Part other)
            {
                if (other == null) return false;
                return (this.PartId.Equals(other.PartId));
            }
            // Should also override == and != operators.
        }

        private void ListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.listView.ListViewItemSorter = new ListViewColumnComparer(e.Column);
        }
        private void ShowFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NotSelectedItemsInFileList)
                return;

            if (File.Exists(listView.SelectedItems[0].SubItems[0].Text))
            {
                Process.Start(new ProcessStartInfo("explorer.exe", @" /select, " + listView.SelectedItems[0].SubItems[0].Text));
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _edfFiles.ShowDuplicatesOnlyListFiles(listView);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (NotSelectedItemsInFileList)
                return;

            _edfFiles.ShowCurrentDublicatesListFiles(listViewDublicates, listView.SelectedItems[0].SubItems[3].Text);
        }

        private bool NotSelectedItemsInFileList => listViewDublicates.SelectedItems.Count == 0;

        private void DeleteOthersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NotSelectedItemsInFileList)
                return;

            _edfFiles.DeleteAllCurrentDuplicatesFiles(listView.SelectedItems[0].SubItems[3].Text, listView.SelectedItems[0].SubItems[5].Text);
            _edfFiles.ShowListFiles(listView);
        }
    }
}
