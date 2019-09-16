using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace create_update
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
                string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

                FillListFiles(files);
            }
            finally
            {
                BlockHeadControls(false);

                // Выводим информацию о найденых файлах.
                lblCountFindedFiles.Text = string.Format("Find {0} file(s)", listView.Items.Count);
                // Устанавливаем параметры общего выделения.
                CheckAllFiles(false);
            }
        }

        private void FillListFiles(string[] files)
        {
            // Отключаем обновление списка.
            listView.BeginUpdate();
            // Очищаем список.
            listView.Items.Clear();

            // Перебор полученных файлов.
            foreach (string file in files)
            {
                FileInfo fileInf = new FileInfo(file);
                if (fileInf.Exists)
                {
                   
                }

                ListViewItem lvi = new ListViewItem
                {
                    // установка названия файла.
                    Text = file,
                    //   lvi.SubItems.Add(file.Length.ToString());
                    // Установка картинки для файла.
                    ImageIndex = 0                
                };
                lvi.SubItems.Add(fileInf.Length.ToString());
                lvi.SubItems.Add(fileInf.CreationTime.ToString());
                lvi.SubItems.Add(fileInf.LastWriteTime.ToString());
                // Добавляем элемент в ListView.
                listView.Items.Add(lvi);
            }

            // Включаем обновление списка.
            listView.EndUpdate();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            BlockHeadControls(true);

            CheckAllFiles(chkSelectAllFiles.Checked);

            BlockHeadControls(false);
        }

        /// <summary>
        /// Установка или снятие флага отметки файлов в списке.
        /// </summary>
        /// <param name="checkAll"><see langword="true"/>Отметить все.<see langword="false"/>Снять отметку у всех.</param>
        private void CheckAllFiles(bool checkAll)
        {
            // Меняем статус checkBox в зависимости от задачи.
            chkSelectAllFiles.Text = (checkAll) ? "Снять чек со всех" : "Выбрать все";
            chkSelectAllFiles.CheckState = (checkAll) ? CheckState.Checked: CheckState.Unchecked;

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

        

    }
}
