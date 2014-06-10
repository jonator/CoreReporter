using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Database
{
    class Read
    {
        int ignoredLines;
        List<Core> coreArray;
        private string[] lines;

        public Read(string fileName)
        {
            ignoredLines = 0;
            coreArray = new List<Core>();
            lines = System.IO.File.ReadAllLines(fileName);
        }



        public void parseLines(string[] lineArr)//pulls apart each line parse
        {
            foreach (string line in lineArr)
            {
                try
                {
                    coreArray.Add(ParseCore(line));
                }
                catch(Exception e)
                {
                    ignoredLines++;
                }
            }
        }
        private Core ParseCore(string line)
        {
            

            int indexOfFirstSpace;
            int indexOfLastSpace;

            indexOfFirstSpace = line.IndexOf(" ");
            indexOfLastSpace = line.LastIndexOf(" ");
            
            return makeDataFromStringAndCore(indexOfFirstSpace, indexOfLastSpace, line);
        }

        public int setIgnoredLines()
        {
            return ignoredLines;
        }

        private bool checkParse(int firstSpace, int secondSpace, string line)
        {
            int length1 = secondSpace - firstSpace;
            int success;
            bool result = int.TryParse(line.Substring(firstSpace + 1, length1), out success);
            return result;
        }

        public Core makeDataFromStringAndCore(int indexOfFirstSpace,int indexOfLastSpace, string line)
        {
            int indexFirstSpace = indexOfFirstSpace;
            int indexLastSpace = indexOfLastSpace;
            
            int sizeStringLength = indexLastSpace - indexFirstSpace;
            int docCountFinder = line.Length - indexLastSpace;

            string name = line.Substring(0, indexFirstSpace);
            long size = int.Parse(line.Substring(indexFirstSpace + 1, sizeStringLength - 1));
            int documentCount = int.Parse(line.Substring(indexLastSpace + 1, docCountFinder - 1));

            return new Core(name, size, documentCount);
        }

        public List<Core> setCore()
        {
            return coreArray;
        }
    }
}