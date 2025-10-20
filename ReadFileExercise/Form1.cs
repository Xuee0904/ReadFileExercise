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

namespace ReadFileExercise
{
    public partial class FrmOpenTextFile : Form
    {
        public FrmOpenTextFile()
        {
            InitializeComponent();

            NextButton.BackColor = ColorTranslator.FromHtml("#3A5A40");
            NextButton.ForeColor = ColorTranslator.FromHtml("#DFE6DA");
            OpenButton.BackColor = ColorTranslator.FromHtml("#3A5A40");
            OpenButton.ForeColor = ColorTranslator.FromHtml("#DFE6DA");
        }

        public void DisplayToList(string path)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    ReadTextListView.Items.Add(_getText);
                }
            }
        }

        private void FrmOpenTextFile_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F3F3F3");
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            DisplayToList(openFileDialog1.FileName);
        }
    }
}
