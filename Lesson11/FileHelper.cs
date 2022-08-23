using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    internal class FileHelper
    {
        public string FileFullPath { get; private set; }
        public string[] FileContent { get; private set; }
        public FileHelper(string txtFile)
        {
            if (!FileExist(txtFile))
                throw new Exception("File with data not exits!");
            FileFullPath = txtFile;
            GetFileContent(FileFullPath);
        }

        private bool FileExist(string fullFileName)
        {
            return File.Exists(fullFileName);
        }

        private void GetFileContent(string fullFileName)
        {
            using (StreamReader reader = new StreamReader(fullFileName))
            {
                FileContent =  reader.ReadToEnd().Split(new char[] { '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
