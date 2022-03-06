using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWindowsFormsApp1
{
    public partial class JobDetailsForm : Form
    {
        public JobDetailsForm()
        {
            InitializeComponent();
        }

        private void JobDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void TxtCarNo_Leave(object sender, EventArgs e)
        {
            if ((txtCarNo.Text =="")||(txtCarNo.Text==null))
            {
                MessageBox.Show("please specify a valid value"+" of the car Number"," Error in put");
                txtCarNo.Focus();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCarNo.Text.Length < 6)
                {
                    MessageBox.Show("Please Specify a Valid Car Number");
                    txtCarNo.Focus();
                    return;
                }
                if (Convert.ToInt32(txtWokerId.Text) < 1)
                {
                    MessageBox.Show("Please Specify a Valid Worker Id");
                    txtWokerId.Focus();
                    return;
                }
                if (Convert.ToDateTime(dateTimePicker1.Text) > DateTime.Today)
                {
                    MessageBox.Show("Please Specify a Valid Date");
                    dateTimePicker1.Focus();
                    return;
                }
         }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
