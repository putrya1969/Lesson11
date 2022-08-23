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
        internal string FileFullPath { get; set; }
        internal string[] FileContent { get; set; }
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
