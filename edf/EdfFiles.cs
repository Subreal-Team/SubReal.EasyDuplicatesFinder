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
        private static List<FileDesc> FullListFiles { get; set; }
        /// <summary>
        /// Получить список файлов из указанного пути.
        /// </summary>
        /// <param name="path">Путь поиска.</param>
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
        /// <summary>
        /// Отбор дубликатов по размеру файла и расчет для них контрольной суммы.
        /// </summary>
        public static void FindDublicatedBySize()
        {
            var groupBySize = FullListFiles
                      .GroupBy(f => new { f.Size })
                      .Select(g => new { size = g.Key.Size, count = g.Count() })
                      .Where(_ => _.count > 1)
                      .ToArray();
            // FillListFiles(listViewCandidate, groupBySize);
            // Перебор полученных файлов.
            foreach (var info in groupBySize)
            {
                //foreach (ref var item in EdfFiles.FullListFiles)
                for (int i = 0; i <FullListFiles.Count; i++)
                {
                    if (FullListFiles[i].Size.ToString() == (info.size.ToString()))
                    {
                        FullListFiles[i].MD5Summ = GetMD5HashFromFile(FullListFiles[i].Name);
                    }
                }
            }
        }

        /// <summary>
        /// Подсчет дубликатов по контрольной сумме и размеру.
        /// </summary>
        public static void CountDublicated()
        {
            var groupByMD5 = FullListFiles
                     .GroupBy(f => new { f.MD5Summ, f.Size })
                     .Select(g => new { md5 = g.Key.MD5Summ, size = g.Key.Size, count = g.Count() })
                     .Where(_ => _.count > 1)
                     .ToArray();
            foreach (var info in groupByMD5)
            {
                for (int i = 0; i < FullListFiles.Count; i++)
                {
                    // Устанавливаем количество, есть MD5 совпадают.
                    if (FullListFiles[i].MD5Summ.ToString() == (info.md5.ToString()))
                    {
                        FullListFiles[i].CountDublicates = info.count;
                    }
                }
            }
        }
        
        /// <summary>
        /// Настройка объекта ListView для показа результатов.
        /// </summary>
        /// <param name="listView"></param>
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
        /// <summary>
        /// Показ результата в ListView.
        /// </summary>
        /// <param name="listView"></param>
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
                    // Установка картинки для файла.
                    ImageIndex = 0
                };
                // Размер.
                lvi.SubItems.Add(file.Size.ToString());
                // Время создания файла.
                lvi.SubItems.Add(file.CreationTime.ToString());
                // Контрольная сумма.
                lvi.SubItems.Add(file.MD5Summ.ToString());
                // Число повторений.
                lvi.SubItems.Add(file.CountDublicates.ToString());
                // Добавляем элемент в ListView.
                listView.Items.Add(lvi);
            }
            // Включаем обновление списка.
            listView.EndUpdate();
        }
        /// <summary>
        /// Получение MD5 для файла.
        /// </summary>
        /// <param name="fileName">Имя файла.</param>
        /// <returns></returns>
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
