﻿using System;
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
        private string[] memory = null;
        public char inBetween = '\n';
        public int memoryInd { get; private set; } = 0;
        public bool wasNewlyCreated { get; private set; } = false;

        public FileHandler(string fileName)
        {
            this.fileName = fileName;
            directory = @"C:\Users\Public\StuddyBuddy\";
            fullPath = System.IO.Path.Combine(directory, this.fileName);
            CheckPrepareDir();

            //file exists?
            if (!System.IO.File.Exists(fullPath))
            {
                try
                {
                    System.IO.File.Create(fullPath);
                }
                catch (Exception) { } // :)
                wasNewlyCreated = (System.IO.File.Exists(fullPath));
            }
        }

        public void WriteNewly(string text)
        {
            System.IO.File.WriteAllText(fullPath, text);
        }

        public void Append(string text, char inBetween = '\0')
        {
            inBetween = (inBetween == '\0') ? this.inBetween : inBetween;
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

        public string[] ReadAll(char inBetween = '\0')
        {
            inBetween = (inBetween == '\0') ? this.inBetween : inBetween;
            string allInOne = ReadAllAsOne();
            this.memory = allInOne.Split('\n');
            return memory;
        }

        public string Read()
        {
            if (memory == null)
                ReadAll();
            if (memory.Length <= memoryInd) //#index out of bounds
                return "";
            return memory[memoryInd++];
        }

        private void CheckPrepareDir()
        {
            if (!System.IO.Directory.Exists(directory))
                System.IO.Directory.CreateDirectory(directory);
        }

    }
}
