using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truextend.AdmStudent.Commons
{
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

        public string ReadAllLinesByWord(string word)
        {
            return string.Empty;
            //while (!string.IsNullOrEmpty(StringTemp))
            //{
            //    StringTemp = StringReader.ReadLine();
            //    if (StringTemp == null && StringTemp == "")
            //    {
            //        StringReader.Close();
            //        return ErrorWord;
            //    }
            //    else if (StringTemp != null)
            //    {
            //        if (StringTemp.Contains(word) == true)
            //        {
            //            if (StringTemp != "")
            //            {
            //                StringText += ";";
            //                StringText += StringTemp;
            //            }
            //            else
            //            {
            //                StringText += StringTemp;
            //            }
            //        }
            //    }
            //}
            //StringReader.Close();
            //return StringText;
        }

        public string RemoveLine(int numberLine)
        {
            var lines = File.ReadAllLines(_pathFile);
            string line = lines[numberLine].Remove(numberLine);
            return line;
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
