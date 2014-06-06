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
namespace Database
{
    class Read
    {
        int x;
        int ignoredLines;
        List<Core> coreArray;
        public string[] lines;
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
            int slot1;
            int slot2;
            int slot3;
            int slot4;
            int length = lines.Length;
            int lengthStr;
            for (int i = 0; i < length; i++)
            {

                lengthStr = lines[i].Length;
                slot1 = lines[i].IndexOf(" ");
                slot2 = lines[i].LastIndexOf(" ");
                slot3 = slot2 - slot1;
                slot4 = lengthStr - slot2;
                if (slot1 != -1 || slot2 != -1)
                {
                    n = lines[i].Substring(0, slot1);
                    s = int.Parse(lines[i].Substring(slot1 + 1, slot3 - 1));
                    dC = int.Parse(lines[i].Substring(slot2 + 1, slot4 - 1));
                    makeCore(n, s, dC, i);
                }
                else
                {
                    ignoredLines++;
                }
            }
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
