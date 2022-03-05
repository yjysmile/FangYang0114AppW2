using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinFormsApp
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            errCustForm.SetError(textBox1, "");
            errCustForm.SetError(textBox2, "");
            errCustForm.SetError(textBox3, "");
            errCustForm.SetError(textBox4, "");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool flag;
            flag = true;
            if(textBox1.Text == "")
            {
                errCustForm.SetError(textBox1, "Please specify a valid car number");
                flag = false;
            }else
                errCustForm.SetError(textBox1, "");
            if (textBox2.Text == "")
            {
                errCustForm.SetError(textBox2, "Please specify a valid name");
                flag = false;
            }
            else
                errCustForm.SetError(textBox2, "");
            if (textBox3.Text == "")
            {
                errCustForm.SetError(textBox3, "Please specify a valid address");
                flag = false;
            }
            else
                errCustForm.SetError(textBox3, "");
            if (textBox4.Text == "")
            {
                errCustForm.SetError(textBox4, "Please specify a valid make");
                flag = false;
            }
            else
                errCustForm.SetError(textBox4, "");
            if (flag == false)
                return;
            else
            {
                //later
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
