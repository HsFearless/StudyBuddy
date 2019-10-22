using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.dataNeeds
{
    public class FileHandler
    {
        readonly string fileName;
        static string directory;
        readonly string fullPath;

        public FileHandler(string fileName)
        {
            this.fileName = fileName;
            directory = @"C:\Users\Public\StuddyBuddy\";
            fullPath = System.IO.Path.Combine(directory, this.fileName);
            CheckPrepareDir();
        }

        public void WriteNewly(string text)
        {
            System.IO.File.WriteAllText(fullPath, text);
        }

        public void Append(string text, char inBetween = '\n')
        {
            var appender = System.IO.File.AppendText(fullPath);
            appender.Write(inBetween + text);
            appender.Close();
        }

        public string ReadAllAsOne()
        {
            if (!System.IO.File.Exists(fullPath))
                return ""; //#possible exception handling
            return System.IO.File.ReadAllText(fullPath);
        }

        public string[] ReadAll(char inBetween = '\n')
        {
            string allInOne = ReadAllAsOne();
            string[] arr = allInOne.Split('\n');
            return arr;
        }

        private void CheckPrepareDir()
        {
            if (!System.IO.Directory.Exists(directory))
                System.IO.Directory.CreateDirectory(directory);
        }

    }
}
