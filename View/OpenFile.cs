using FileComparator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextComparatorGUI
{
    public partial class OpenFile : System.Windows.Forms.Form
    {
        public PrimaryFileWorker fileWorker;
        public OpenFile()
        {
            fileWorker = new PrimaryFileWorker();
            InitializeComponent();
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            //var text1 = new Text();
            //var text2 = new Text();
            //try
            //{
            //    text1 = fileWorker.ReadFile(FIRST_FILE_FILEPATH);
            //    text2 = fileWorker.ReadFile(SECOND_FILE_FILEPATH);
            //}
            //catch (Exception e)
            //{
            //    view.DisplayText(e.Message);
            //}
        }

        private void firstFileButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {

            }
        }
    }
}
