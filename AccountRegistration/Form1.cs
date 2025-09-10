using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            StudentInfoClass.Program = Program.Text;
            StudentInfoClass.FirstName = txtLastName.Text + ", " + txtFirstName.Text + " " + txtMiddleName.Text;
            StudentInfoClass.Address = txtAddress.Text;
            StudentInfoClass.Age = Convert.ToInt64(txtAge.Text);
            StudentInfoClass.ContactNo = Convert.ToInt64(txtContactNo.Text);
            StudentInfoClass.StudentNo = Convert.ToInt64(txtStudentNo.Text);

            FrmConfirm confirmForm = new FrmConfirm();
            
            if (confirmForm.ShowDialog() == DialogResult.OK)
            {
                txtFirstName.Clear();
                txtLastName.Clear();
                txtMiddleName.Clear();
                txtAddress.Clear();
                txtAge.Clear();
                txtContactNo.Clear();
                txtStudentNo.Clear();
                Program.SelectedIndex = -1;
            }
        }

        private void Program_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
