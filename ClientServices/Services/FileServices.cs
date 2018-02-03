using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Services
{
    internal class  FileServices : IFileService
    {
        private static FileServices servise;
        // создание файла
        private FileServices() { }

        public static FileServices GetFileServices()
        {
            if (servise == null)
                servise = new FileServices();
            return servise;
        }
        
            public void CreateFile(string text)
        {
            string path = "";
            SaveFileDialog sav = new SaveFileDialog();
            if (sav.ShowDialog() == DialogResult.OK)
                path = sav.FileName;

            using (File.Create(path))
            {

            }
            
            using(StreamWriter write = new StreamWriter(path, false, Encoding.Default))
            {
                write.WriteLine(text);
            }
        }

        // даление с диска
        public void DeleteFile()
        {
            string path = "";

            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
                path = open.FileName;
            File.Delete(path);   
        }


        //
        // еемещение файла
        public void Move()
        {
            string path = "";
            string newPath = "";

            // выбрать файл
            OpenFileDialog opn = new OpenFileDialog();
            if (opn.ShowDialog() == DialogResult.OK)
                path = opn.FileName;

            // выбрать путь перемещения
            SaveFileDialog sav = new SaveFileDialog();
            if (sav.ShowDialog() == DialogResult.OK)
                newPath = sav.FileName;

            File.Move(path, newPath);
        }

        //
        // открыть файл показать на форме содержимое
        public string OpenFile()
        {
            string text = "";
            string path = "";

            OpenFileDialog opn = new OpenFileDialog();
            if (opn.ShowDialog() == DialogResult.OK)
                path = opn.FileName;

            using (StreamReader file = new StreamReader(path, Encoding.Default))
            {
                text = file.ReadToEnd();
            }
            return text;
        }
    }
}
