using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
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
            try
            {
                StudentInfoClass.SetProgram = cbProgram.Text;
                StudentInfoClass.SetFullName = txtLastName.Text + ", " + txtFirstName.Text + " " + txtMiddleName.Text;
                StudentInfoClass.SetAge = Convert.ToInt64(txtAge.Text);
                StudentInfoClass.SetContactNo = Convert.ToInt64(txtContactNo.Text);
                StudentInfoClass.SetStudentNo = Convert.ToInt64(txtStudentNo.Text);
                StudentInfoClass.SetGender = cbGender.Text;
                StudentInfoClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");


                FrmConfirm confirmForm = new FrmConfirm();

                confirmForm.ShowDialog();
            }
            catch (FormatException)
            {
                MessageBox.Show("")
            }
        }
        private void Program_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]{
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };

            
 
          for (int i = 0; i < 6; i++)
          {
                cbProgram.Items.Add(ListOfProgram[i].ToString());
          }
        }
    }
}
