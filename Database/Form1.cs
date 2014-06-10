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
        private string file = "";
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

            checkAndPrint(mainCore);

            Printer printer = new Printer(file, mainCore, ignoredLines);
            printer.makeFile();
            MessageBox.Show("Finished");
        }

        private void checkAndPrint(List<Core> mainCore)
        {
            if (coreNameRadio.Checked)
            {
                SortingEngine namesorter = new SortingEngine(mainCore, new CoreNameComparer());
                mainCore = namesorter.setCore();
            }
            else if (sizeRadio.Checked)
            {
                SortingEngine sizeSorter = new SortingEngine(mainCore, new CoreNameComparer());
                mainCore = sizeSorter.setCore();
            }
            else if (documentCountRadio.Checked)
            {
                SortingEngine docSorter = new SortingEngine(mainCore, new CoreNameComparer());
                mainCore = docSorter.setCore();
            }
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            makeFileDialog();
        }

        private void makeFileDialog()
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