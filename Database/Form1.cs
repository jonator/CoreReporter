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
    public partial class Form1 : Form
    {
        private int ignoredLines;
        private List<Core> mainCore;
        private string file;
        private Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void sortButton_Click(object sender, EventArgs e)
        {
            file = @"C:\WS\Database\Database\bin\Debug\testData - Copy.txt";
            string check = System.IO.File.ReadAllText(file);
            Read reader = new Read(file);
            mainCore = reader.setCore();

            if (coreNameRadio.Checked)
            {
                SortingEngine nameSorter = new SortingEngine(mainCore, new CoreNameComparer());
                mainCore = nameSorter.setCore();
            }
            else if (sizeRadio.Checked)
            {
                SortingEngine sizeSorter = new SortingEngine(mainCore, new CoreSizeComparer());
                mainCore = sizeSorter.setCore();
            }
            else if(documentCountRadio.Checked)
            {
                SortingEngine docSorter = new SortingEngine(mainCore, new CoreDocumentCountComparer());
                mainCore = docSorter.setCore();
            }
            else
            {
                MessageBox.Show("No radio buttons selected");
            }

            Print printer = new Print(file, mainCore, ignoredLines);
            printer.makeFile();
            MessageBox.Show("Finished");
        }
    }
}