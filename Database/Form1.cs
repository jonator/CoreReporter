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
    public partial class Main : Form
    {
        public string file = "";
        private int ignoredLines;
        private List<Core> mainCore;


        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void sortButton_Click(object sender, EventArgs e)
        {
            if (file == string.Empty)
            {
                MessageBox.Show("No file selected");

                return;
            }

            string check = System.IO.File.ReadAllText(file);
            Read reader = new Read(file);
            mainCore = reader.setCore();
            ignoredLines = reader.setIgnoredLines();
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

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog mainDialog = new OpenFileDialog();

            mainDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            mainDialog.FilterIndex = 1;

            mainDialog.Multiselect = false;

            DialogResult result = mainDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                file = mainDialog.FileName;
                filePathLabel.Text = file;
            }
        }
    }
}