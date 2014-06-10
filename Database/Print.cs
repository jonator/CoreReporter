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
    class Print
    {
            string fileInputtedPath;
            List<Core> coreListToPrint;
            int ignoredLines;

            public Print(string File, List<Core> CoreList, int IgnoredLines)
            {
                ignoredLines = IgnoredLines;
                coreListToPrint = CoreList;
                fileInputtedPath = File + "_Finished.txt";
            }
            
            
            public void makeFile()
            {
                string path = fileInputtedPath;

                if (File.Exists(path))
                {                     
                    File.Delete(path);
                }

                using (FileStream newFile = File.Create(path))
                {
                    using (StreamWriter writer = new StreamWriter(newFile))
                    {
                        writer.WriteLine("Name                       Size        Document Count");
                        writer.WriteLine("_____________________________________________________");
                    for (int i = 0; i < coreListToPrint.Count; i++)
                    {
                        writer.WriteLine(i + 1 + ": | " + coreListToPrint[i].CoreName + addSpacesName(i) + coreListToPrint[i].Size + addSpacesSizes(i) + coreListToPrint[i].Document);
                    }

                    writer.WriteLine();
                    writer.WriteLine();
                    writer.WriteLine();
                    writer.WriteLine("Number of failed lines: " + ignoredLines);
                    }
                }
            }
            
            //Add a method adds turns "final" into the biggest didget + 5

            public string addSpacesName(int lineN)
            {
                int final = 22;
                int l = coreListToPrint[lineN].CoreName.Length;
                final -= l;
                string ret = "";
                for(int x = 0;x < final;x++)
                {
                    ret += " ";
                }
                return ret;
            }
            
            public string addSpacesSizes(int lineN)
            {
                long final = 12;
                int l = coreListToPrint[lineN].Size.ToString().Length;
                final -= l;
                string ret = "";
                for(int x = 0;x < final;x++)
                {
                    ret += " ";
                }
                return ret;
            }
        }
}