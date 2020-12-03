﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace SubReal.EasyDuplicatesFinder
{
    public class EdfFiles
    {
        private string Path { get; }

        public List<FileDesc> FullListFiles { get; }
        
        /// <summary>
        /// Количество уникальных файлов
        /// </summary>
        private int CountUnique;
        public int GetUniqueCount => CountUnique;

        /// <summary>
        /// Количество найденных файлов
        /// </summary>
        private int Count;
        public int GetTotalCount => Count;
       
        /// <summary>
        /// Количество дубликатов файлов
        /// </summary>
        private int CountDuplicates ;
        public int GetDuplicatesCount => CountDuplicates - CountUnique;

        private static bool isFullDelete;
        public bool SetFullDeleteFiles
        {
            set
            {
                isFullDelete = value;
            }
        }

        public EdfFiles(string path) : this(path, false) { }
        
        /// <summary>
        ///  Инициализация
        /// </summary>
        /// <param name="path">Путь к папке поиска</param>
        /// <param name="isfulldelete"><see langword="true"/>Безвозвратное удаление<see langword="false"/>Удаление в корзину.</param>
        public EdfFiles(string path, bool isfulldelete)
        {
            Path = path;
            FullListFiles = new List<FileDesc>();
            isFullDelete = isfulldelete;
            Count = 0;
        }

        /// <summary>
        /// Получить список файлов из указанного пути.
        /// </summary>
        public bool GetFiles()
        {
            if (!IsSourceFolderExists(Path))
            {
                return false;
            }
            Count = 0;
            foreach (var fileName in Directory.GetFiles(Path, "*", System.IO.SearchOption.AllDirectories))
            {
                var fileInfo = new FileInfo(fileName);
                var fileDesc = new FileDesc
                {
                    Name = fileName,
                    Size = fileInfo.Length,
                    CreationTime = fileInfo.CreationTime,
                    Guid = Guid.NewGuid(),
                    MD5Summ = "",
                    CountDuplicates = 0
                };

                FullListFiles.Add(fileDesc);
                Count++;
            }

            FindDuplicatedBySize();
            CountDuplicated();

            return true;
        }
        /// <summary>
        /// Отбор дубликатов по размеру файла и расчет для них контрольной суммы.
        /// </summary>
        private void FindDuplicatedBySize()
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
                foreach (var fileDesc in FullListFiles)
                {
                    if (fileDesc.Size.ToString() == (info.size.ToString()))
                    {
                        fileDesc.MD5Summ = GetMD5HashFromFile(fileDesc.Name);
                    }
                }
            }
        }

        /// <summary>
        /// Подсчет дубликатов по контрольной сумме и размеру.
        /// </summary>
        private void CountDuplicated()
        {
            var groupByMD5 = FullListFiles
                     .GroupBy(f => new { f.MD5Summ, f.Size })
                     .Select(g => new { md5 = g.Key.MD5Summ, size = g.Key.Size, count = g.Count() })
                     .Where(_ => _.count > 1)
                     .ToArray();
            this.CountUnique = 0;
            this.CountDuplicates = 0;
            foreach (var info in groupByMD5)
            {
                CountUnique++;
                for (int i = 0; i < FullListFiles.Count; i++)
                {
                    // Устанавливаем количество, есть MD5 совпадают.
                    if (FullListFiles[i].MD5Summ == info.md5)
                    {
                        FullListFiles[i].CountDuplicates = info.count;
                        CountDuplicates++;
                    }
                }
            }
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


        /// <summary>
        /// Проверка корректности указания пути поиска.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool IsSourceFolderExists(string path)
        {
            return Directory.Exists(path);
        }

        /// <summary>
        /// Удаление элемента из списка по идентификатору
        /// </summary>
        /// <param name="id"></param>
        public void DeleteItem(Guid id)
        {
            var itemToDelete = FullListFiles.Where(x => x.Guid == id).Select(x => x).First();
            EdfFiles.DeleteFile(itemToDelete.Name);
            FullListFiles.Remove(itemToDelete);
        }

        /// <summary>
        /// Удаление файла с диска.
        /// </summary>
        /// <param name="fileName">Имя файла.</param>
        public static void DeleteFile(string fileName)
        {
            if (!File.Exists(fileName)) return;
            
            if (isFullDelete)
            {
                try
                {
                    File.Delete(fileName);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                try
                {
                    FileSystem.DeleteFile(fileName, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin, UICancelOption.ThrowException);
                }
                catch (Exception)
                {
                    throw;
                }
            }

        }

        /// <summary>
        /// Удаление копий файлов в ListView.
        /// </summary>
        public void DeleteAllCurrentDuplicatesFiles(string md5Summ, string guid)
        {
            var forDeleteFiles = new List<FileDesc>();

            foreach (var fileDesc in FullListFiles)
            {
                if ((fileDesc.MD5Summ == md5Summ))
                {
                    if (fileDesc.Guid.ToString() != guid)
                    {
                        forDeleteFiles.Add(fileDesc);
                    }
                    else
                    {
                        // Обнуляем количество дублей, т.к. удалили все файлы кроме основного.
                        fileDesc.CountDuplicates = 0;
                    }
                }
            }

            foreach (var item in forDeleteFiles)
            {
                DeleteItem(item.Guid);
            }

            FindDuplicatedBySize();
            CountDuplicated();
        }
        /// <summary>
        /// Удаление отмеченных файлов
        /// </summary>
        /// <param name="listView"></param>
        public void DeleteCheckedFiles(ListView listView)
        {
            var forDeleteFiles = new List<Guid>();

            foreach (ListViewItem item in listView.Items)
            {
                if (item.Checked)
                {
                    forDeleteFiles.Add(Guid.Parse(item.SubItems[5].Text));
                }
            }

            foreach (var item in forDeleteFiles)
            {
                DeleteItem(item);
            }

            FindDuplicatedBySize();
            CountDuplicated();
        }

    }

    public class FileDesc
    {
        /// <summary>
        /// Имя файла.
        /// </summary>
        public string Name { get; set; }
        public long Size { get; set; }
        public int ControlSum { get; set; }
        public DateTime CreationTime { get; set; }
        public string MD5Summ { get; set; }
        public int CountDuplicates { get; set; }
        public Guid Guid { get; set; }
    }

}
