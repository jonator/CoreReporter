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
            sortLines(lines);
        }



        public void sortLines(string[] lineArr)//pulls apart each line parse
        {
            string n;
            long s;
            int dC;
            int findFirstSpaceIndex;
            int findSecondSpaceIndex;
            int sizeFinder;
            int docCountFinder;
            int length = lines.Length;
            int lengthStr;
            string stringVersionSize;
            string stringVersionDocCount;
            for (int i = 0; i < length; i++)
            {
                lengthStr = lines[i].Length;
                findFirstSpaceIndex = lines[i].IndexOf(" ");
                findSecondSpaceIndex = lines[i].LastIndexOf(" ");
                sizeFinder = findSecondSpaceIndex - findFirstSpaceIndex;
                docCountFinder = lengthStr - findSecondSpaceIndex;

                stringVersionSize = sizeFinder.ToString();
                stringVersionDocCount = docCountFinder.ToString();

                if (findFirstSpaceIndex != -1 && findSecondSpaceIndex != findFirstSpaceIndex && checkParse(findFirstSpaceIndex, findSecondSpaceIndex, i))
                {
                    n = lines[i].Substring(0, findFirstSpaceIndex);
                    s = int.Parse(lines[i].Substring(findFirstSpaceIndex + 1, sizeFinder - 1));
                    dC = int.Parse(lines[i].Substring(findSecondSpaceIndex + 1, docCountFinder - 1));
                    makeCore(n, s, dC, i);
                }
                else
                {
                    ignoredLines++;
                }
            }
        }

        public int setIgnoredLines()
        {
            return ignoredLines;
        }

        public bool checkParse(int firstSpace, int secondSpace, int line)
        {
            int length1 = secondSpace - firstSpace;
            int success;
            bool result = int.TryParse(lines[line].Substring(firstSpace + 1, length1), out success);
            return result;
        }

        public void makeCore(string coreN, long Size, int docCount, int i)
        {
            coreArray.Add(new Core(coreN, Size, docCount));
        }

        public List<Core> setCore()
        {
            return coreArray;
        }
    }
}