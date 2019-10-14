using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.dataNeeds
{
    public class FileHandler
    {
        string fileName;
        static string directory;
        string fullPath;

        public FileHandler(string fileName)
        {
            this.fileName = fileName;
            directory = @"C:\Users\Public\StuddyBuddy\";
            fullPath = System.IO.Path.Combine(directory, this.fileName);
            CheckPrepareDir();
        }

        public void Write(string text)
        {
            System.IO.File.WriteAllText(fullPath, text);
        }

        public string Read()
        {
            if (!System.IO.File.Exists(fullPath))
                return "";
            return System.IO.File.ReadAllText(fullPath);
        }

        private void CheckPrepareDir()
        {
            if (!System.IO.Directory.Exists(directory))
                System.IO.Directory.CreateDirectory(directory);
        }

    }
}
