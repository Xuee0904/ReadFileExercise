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
    public partial class FrmStudentRecord : Form
    {

        FormRegistration registration = new FormRegistration();

        public FrmStudentRecord()
        {
            InitializeComponent();

            RegisterButton.BackColor = ColorTranslator.FromHtml("#3A5A40");
            RegisterButton.ForeColor = ColorTranslator.FromHtml("#DFE6DA");
            FindButton.BackColor = ColorTranslator.FromHtml("#3A5A40");
            FindButton.ForeColor = ColorTranslator.FromHtml("#DFE6DA");
            UploadButton.BackColor = ColorTranslator.FromHtml("#3A5A40");
            UploadButton.ForeColor = ColorTranslator.FromHtml("#DFE6DA");
        }

        public void DisplayToList(string path)
        {
            openFileDialog1.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
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
                    listView1.Items.Add(_getText);
                }
            }
        }

        private void FrmStudentRecord_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F3F3F3");
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (registration.ShowDialog() == DialogResult.OK) { this.Show(); }

        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded! ^^");
            listView1.Clear();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            DisplayToList(openFileDialog1.FileName);
        }
    }
}
