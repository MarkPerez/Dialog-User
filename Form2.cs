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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            //hide this form 
            this.Hide();
            //display the previous form
            FormState.previousPage.Show();
            //now set this form to be the previous form
            FormState.previousPage = this;
        }
    }
}
