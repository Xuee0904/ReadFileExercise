using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadFileExercise
{
    public partial class FrmStudentRecord : Form
    {
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

        private void FrmStudentRecord_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F3F3F3");
        }
    }
}
