using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogUser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "*.txt";
            openFileDialog1.Filter = "Textfiles (*.txt)|*.txt|All files (*.*)|*.*";

            //if the file dialog opens successfully and the filename
            //entered is longer tahn 0
            if ((openFileDialog1.ShowDialog() == DialogResult.OK) &&
                (openFileDialog1.FileName.Length > 0))
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //selects the colour from the dialog ONLY if OK is clicked
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //create a new form2 object
            Form2 nextForm = new Form2();
            //show the new form
            nextForm.Show();
            //hide the current form
            this.Hide();
            //set the previous form to be this form
            FormState.previousPage = this;
        }
    }
    public static class FormState
    {
        public static Form previousPage;
    }
}
