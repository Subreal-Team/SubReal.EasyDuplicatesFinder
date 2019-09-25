using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SubReal.EasyDublicateFinder
{
    internal class EdfFiles
    {
        public static List<FileDesc> FullListFiles { get; set; }
        public static void GetFiles(string path)
        {
            var files = new List<FileDesc>();
            foreach (var fileName in Directory.GetFiles(path, "*", SearchOption.AllDirectories))
            {
                var fileInfo = new FileInfo(fileName);
                var fileDesc = new FileDesc { Name = fileName, Size = fileInfo.Length, CreationTime = fileInfo.CreationTime, MD5Summ = "", CountDublicates = 0 };
                files.Add(fileDesc);
            }
            FullListFiles = files;
        }
        public static void FindDublicatedBySize()
        {
            var groupBySize = EdfFiles.FullListFiles
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
                        EdfFiles.FullListFiles[i].MD5Summ = GetMD5HashFromFile(FullListFiles[i].Name);
                    }
                }
            }
        }
        public static void CalculateMD5ForDublicated()
        {
            var groupByMD5 = FullListFiles
                     .GroupBy(f => new { f.MD5Summ, f.Size })//, f.Name 
                     .Select(g => new { md5 = g.Key.MD5Summ, size = g.Key.Size, count = g.Count() }) //name = g.Key.Name,
                     .Where(_ => _.count > 1)
                     .ToArray();
            foreach (var info in groupByMD5)
            {
                for (int i = 0; i < FullListFiles.Count; i++)
                {
                    if (FullListFiles[i].MD5Summ.ToString() == (info.md5.ToString()))
                    {
                        FullListFiles[i].CountDublicates = info.count;
                    }
                }
            }
        }
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
        private static string GetMD5HashFromFile(string fileName)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(fileName))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
                }
            }
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
