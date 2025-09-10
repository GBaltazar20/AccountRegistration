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
    public partial class FrmConfirm : Form
    {
       
        private void lblProgram_Click(object sender, EventArgs e)
        {

        }

        private void lblStudentNo1_Click(object sender, EventArgs e)
        {

        }

        public FrmConfirm()
        {
            InitializeComponent();
           
        }
        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = StudentInfoClass.SetStudentNo.ToString();
            lblName.Text = StudentInfoClass.SetFullName;
            lblProgram.Text = StudentInfoClass.SetProgram;
            lblBirthday.Text = StudentInfoClass.SetBirthday;
            lblGender.Text = StudentInfoClass.SetGender;
            lblContactNo.Text = StudentInfoClass.SetContactNo.ToString();
            lblAge.Text = StudentInfoClass.SetAge.ToString();


        }
        private void btnSumbit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
