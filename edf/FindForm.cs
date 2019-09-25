using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;
using static SubReal.EasyDublicateFinder.Program;

namespace SubReal.EasyDublicateFinder
{
    public partial class FindForm : Form
    {
        public FindForm()
        {
            InitializeComponent();          
        }

          /// <summary>
        /// Показывает или скрывает панель ожидания.
        /// </summary>
        /// <param name="b"><see langword="true"/> Показать панель.; <see langword="false"/> Скрыть панель.</param>
        private void BlockHeadControls(Boolean b)
        {
            // Обрабатываем кнопки.
            btnStartFind.Enabled = !b;
            chkSelectAllFiles.Enabled = !b;

            // Устанавливаем курсор.
            if (b)
            {
                Cursor = Cursors.WaitCursor;
            }
            else
            {
                Cursor = Cursors.Default;
            }
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
            var watch = System.Diagnostics.Stopwatch.StartNew();
            BlockHeadControls(true);

            try
            {
                string path = tbFolderPath.Text;

                if (!Directory.Exists(path))
                {
                    MessageBox.Show(
                        "Указанный путь не существует. Поиск невозможен.",
                        "Ошибка имени пути",
                        MessageBoxButtons.OK);

                    return;
                }

                //todo: Insert check filename 

                // Получаем все файлы.
                var files = new List<FileDesc>();

                foreach (var fileName in Directory.GetFiles(path, "*", SearchOption.AllDirectories))
                {
                    var fileInfo = new FileInfo(fileName);
                    var fileDesc = new FileDesc { Name = fileName, Size = fileInfo.Length, CreationTime = fileInfo.CreationTime, MD5Summ = "", CountDublicates = 0 };
                    files.Add(fileDesc);
                }

                EdfFiles.FullListFiles = files;


                var groupBySize = files
                      .GroupBy(f => new { f.Size })//, f.Name 
                      .Select(g => new { size = g.Key.Size, count = g.Count() }) //name = g.Key.Name,
                      .Where(_ => _.count > 1)
                      .ToArray();

                // FillListFiles(listViewCandidate, groupBySize);
                // Перебор полученных файлов.
                foreach (var info in groupBySize)
                {
                    //foreach (ref var item in EdfFiles.FullListFiles)
                    for (int i = 0; i < EdfFiles.FullListFiles.Count; i++)
                    {
                        if (EdfFiles.FullListFiles[i].Size.ToString() == (info.size.ToString()))
                        {
                            EdfFiles.FullListFiles[i].MD5Summ = GetMD5HashFromFile(EdfFiles.FullListFiles[i].Name);
                        }

                    }

                }

                var groupByMD5 = EdfFiles.FullListFiles
                     .GroupBy(f => new {f.MD5Summ, f.Size })//, f.Name 
                     .Select(g => new { md5 = g.Key.MD5Summ, size = g.Key.Size, count = g.Count() }) //name = g.Key.Name,
                     .Where(_ => _.count > 1)
                     .ToArray();

                foreach (var info in groupByMD5)
                {
                    //foreach (ref var item in EdfFiles.FullListFiles)
                    for (int i = 0; i < EdfFiles.FullListFiles.Count; i++)
                    {
                        if (EdfFiles.FullListFiles[i].MD5Summ.ToString() == (info.md5.ToString()))
                        {
                            EdfFiles.FullListFiles[i].CountDublicates = info.count;
                        }

                    }

                }

            }
            finally
            {
                EdfFiles.ShowListFiles(listView);

                BlockHeadControls(false);

                // Выводим информацию о найденых файлах.
                lblCountFindedFiles.Text = string.Format("Find {0} file(s)", listView.Items.Count);
                // Устанавливаем параметры общего выделения.
                CheckAllFiles(false);
            }

            watch.Stop();
            lblTimeWork.Text = String.Format($"Время работы: {watch.ElapsedMilliseconds}");
        }

        protected string GetMD5HashFromFile(string fileName)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(fileName))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
                }
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            BlockHeadControls(true);

            CheckAllFiles(chkSelectAllFiles.Checked);

            BlockHeadControls(false);

            watch.Stop();
            lblTimeWork.Text = String.Format($"Время работы: {watch.ElapsedMilliseconds / 1000 }");
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

        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void ListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.listView.ListViewItemSorter = new ListViewColumnComparer(e.Column);
        }

        private void ShowFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (File.Exists(listView.SelectedItems[0].SubItems[0].Text))
            {
                Process.Start(new ProcessStartInfo("explorer.exe", @" /select, " + listView.SelectedItems[0].SubItems[0].Text));
            }
        }
    }
}
