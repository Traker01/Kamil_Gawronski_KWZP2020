using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_1
{
    public partial class Form1 : Form
    {
        private SzwalniaEntities db;
        public Form1()
        {
            InitializeComponent();
            db = new SzwalniaEntities();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button.Enabled = checkButtonEnable.Checked;
         }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button_Click(object sender, EventArgs e)
        {
            drugaczesc detailsForm = new drugaczesc(db, textButtonLable.Text);
            detailsForm.Show();
        }
    }
}
