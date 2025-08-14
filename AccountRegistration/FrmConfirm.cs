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
        private StudentInfoClass.DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private StudentInfoClass.DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;
        public FrmConfirm()
        {
            InitializeComponent();
            DelProgram = new StudentInfoClass.DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new StudentInfoClass.DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new StudentInfoClass.DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new StudentInfoClass.DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new StudentInfoClass.DelegateText(StudentInfoClass.GetAddress);

            DelNumAge = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetStudentNo);
        }
        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            lblProgram1.Text = DelProgram(StudentInfoClass.Program);
            lblLastName1.Text = DelLastName(StudentInfoClass.LastName);
            lblFirstName1.Text = DelFirstName(StudentInfoClass.FirstName);
            lblMiddleName1.Text = DelMiddleName(StudentInfoClass.MiddleName);
            lblAddress1.Text = DelAddress(StudentInfoClass.Address);
            lblAge1.Text = DelNumAge(StudentInfoClass.Age).ToString();
            lblContactNo1.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            lblStudentNo1.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
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
