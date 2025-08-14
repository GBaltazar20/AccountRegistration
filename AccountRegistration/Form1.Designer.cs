namespace AccountRegistration
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.Program = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student No:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Middle Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contact No:";
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Location = new System.Drawing.Point(72, 49);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(175, 22);
            this.txtStudentNo.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Program:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(72, 109);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(175, 22);
            this.txtLastName.TabIndex = 8;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(72, 176);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(175, 22);
            this.txtAge.TabIndex = 9;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(263, 109);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(175, 22);
            this.txtFirstName.TabIndex = 10;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(263, 176);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(175, 22);
            this.txtContactNo.TabIndex = 11;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(451, 109);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(175, 22);
            this.txtMiddleName.TabIndex = 12;
            // 
            // Program
            // 
            this.Program.FormattingEnabled = true;
            this.Program.Items.AddRange(new object[] {
            "Bachelor of Science in Information Technology",
            "Bachelor of Science in Hospitality Management",
            "Bachelor of Science in Business Administration",
            "Bachelor of Science in Accountancy"});
            this.Program.Location = new System.Drawing.Point(263, 49);
            this.Program.Name = "Program";
            this.Program.Size = new System.Drawing.Size(363, 24);
            this.Program.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(72, 236);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(554, 125);
            this.txtAddress.TabIndex = 15;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(287, 367);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Program);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FrmRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.ComboBox Program;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnNext;
    }
}

