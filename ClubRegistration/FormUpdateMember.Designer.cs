namespace ClubRegistration
{
    partial class FormUpdateMember
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cbStudentID = new ComboBox();
            cbGender = new ComboBox();
            cbProgram = new ComboBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            txtAge = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 186);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 3;
            label4.Text = "Middle Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 244);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 4;
            label5.Text = "Age:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 310);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 5;
            label6.Text = "Gender:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 376);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 6;
            label7.Text = "Program:";
            // 
            // cbStudentID
            // 
            cbStudentID.FormattingEnabled = true;
            cbStudentID.Location = new Point(12, 27);
            cbStudentID.Name = "cbStudentID";
            cbStudentID.Size = new Size(121, 23);
            cbStudentID.TabIndex = 7;
            cbStudentID.SelectedIndexChanged += cbStudentID_SelectedIndexChanged;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "MALE", "FEMALE" });
            cbGender.Location = new Point(12, 328);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(121, 23);
            cbGender.TabIndex = 8;
            // 
            // cbProgram
            // 
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "BSIT", "BSCS", "BMMA", "BSBA" });
            cbProgram.Location = new Point(12, 394);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(121, 23);
            cbProgram.TabIndex = 9;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(12, 81);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 10;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(12, 139);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 11;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(12, 204);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(100, 23);
            txtMiddleName.TabIndex = 12;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(12, 273);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(48, 23);
            txtAge.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 14;
            label1.Text = "Student ID:";
            // 
            // button1
            // 
            button1.Location = new Point(109, 469);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormUpdateMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 526);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtAge);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(cbProgram);
            Controls.Add(cbGender);
            Controls.Add(cbStudentID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FormUpdateMember";
            Text = "FormUpdateMember";
            Load += FormUpdateMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cbStudentID;
        private ComboBox cbGender;
        private ComboBox cbProgram;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private TextBox txtAge;
        private Label label1;
        private Button button1;
    }
}