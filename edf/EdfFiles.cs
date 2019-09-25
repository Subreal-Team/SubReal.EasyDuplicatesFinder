using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubReal.EasyDublicateFinder
{
    internal class EdfFiles
    {
        public static List<FileDesc> FullListFiles { get; set; }

        private static void FormatListView(ListView listView)
        {
            listView.BeginUpdate();
            listView.Columns.Clear();
            listView.Columns.Add("Full File name", 370);  //0
            listView.Columns.Add("File size", 90);       //1
            listView.Columns.Add("Data Create", 110);   //2
            listView.Columns.Add("MD5", 220);           //3
            listView.Columns.Add("Dublicates", 120);    //4          
            listView.CheckBoxes = true;
            listView.GridLines = true;

            listView.EndUpdate();
        }
        public static void ShowListFiles(ListView listView)
        {
            FormatListView(listView);
            // Отключаем обновление списка.
            listView.BeginUpdate();
            // Очищаем список.
            listView.Items.Clear();

            // Перебор полученных файлов.
            foreach (var file in FullListFiles)
            {
                ListViewItem lvi = new ListViewItem
                {
                    // установка названия файла.
                    Text = file.Name,
                    //   lvi.SubItems.Add(file.Length.ToString());
                    // Установка картинки для файла.
                    ImageIndex = 0
                };
                lvi.SubItems.Add(file.Size.ToString());
                lvi.SubItems.Add(file.CreationTime.ToString());
                lvi.SubItems.Add(file.MD5Summ.ToString());
                lvi.SubItems.Add(file.CountDublicates.ToString());
                //lvi.SubItems.Add(fileInf.LastWriteTime.ToString());
                // Добавляем элемент в ListView.
                listView.Items.Add(lvi);
            }

            // Включаем обновление списка.
            listView.EndUpdate();
        }

    }

    internal class FileDesc
    {
        public string Name { get; set; }
        public long Size { get; set; }
        public int ControlSum { get; set; }
        public DateTime CreationTime { get; set; }
        public string MD5Summ { get; set; }
        public int CountDublicates { get; set; }
    }
}
