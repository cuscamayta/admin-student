//-----------------------------------------------------------------------
// <copyright file="FileManager.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Truextend.AdmStudent.Commons
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;

    public class FileManager
    {
        private string _pathFile;

        public FileManager(string pathFile)
        {
            this._pathFile = pathFile;
        }


        public IEnumerable<string> ReadAllLines()
        {
            var lines = new List<string>();
            using (StreamReader reader = new StreamReader(_pathFile))
            {
                lines = reader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            return lines;
        }

        public string ReadAll()
        {
            var fileText = string.Empty;
            using (StreamReader reader = new StreamReader(_pathFile))
            {
                fileText = reader.ReadToEnd();
            }

            return fileText;
        }

        public int GetTotalLines()
        {
            var lines = ReadAllLines();
            return lines.Count();
        }

        public IEnumerable<string> FindByWord(string word)
        {
            var lines = ReadAllLines().Where(x => x.Contains(word));
            return lines;
        }

        public void RemoveLine(int numberLine)
        {
            string line = null;
            int line_number = 0;
            int line_to_delete = 12;

            using (StreamReader reader = new StreamReader("C:\\input"))
            {
                using (StreamWriter writer = new StreamWriter("C:\\output"))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        line_number++;

                        if (line_number == line_to_delete)
                            continue;

                        writer.WriteLine(line);
                    }
                }
            }
        }

        public string FindAndRemoveLine(string word)
        {
            //string line = string.Empty;
            var lineToRemove = string.Empty;
            var lines = ReadAllLines();

            using (StreamWriter writer = new StreamWriter(_pathFile))
            {
                foreach (var line in lines)
                {
                    if (line.Contains(word))
                    {
                        lineToRemove = line;
                        continue;
                    }
                    writer.WriteLine(line);
                }
            }

            return lineToRemove;
        }

        public string ReadFirstLine()
        {
            string firstLine = string.Empty;
            using (StreamReader reader = new StreamReader(_pathFile))
            {
                firstLine = reader.ReadLine();
            }
            return firstLine;
        }


        public string ReadLineIndicate(int numberLine)
        {
            string[] lines = File.ReadAllLines(_pathFile);
            string line = lines[numberLine].ToString();
            return line;
        }

        public void InsertNewLine(string value)
        {
            if (!string.IsNullOrEmpty(_pathFile))
            {
                var stringTemp = ReadAll();

                using (StreamWriter writer = new StreamWriter(_pathFile))
                {
                    if (!string.IsNullOrEmpty(stringTemp))
                    {
                        writer.Write(stringTemp);
                        writer.WriteLine();
                    }
                    writer.Write(value);
                }

            }
        }


    }
}
