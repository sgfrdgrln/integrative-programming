namespace StudentRegistrationApplication
{
    partial class frmStudentRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textLabel = new Label();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            middleNameLabel = new Label();
            lastNameTb = new TextBox();
            firstNameTb = new TextBox();
            middleNameTb = new TextBox();
            genderLabel = new Label();
            radioBtn1 = new RadioButton();
            radioBtn2 = new RadioButton();
            dobLabel = new Label();
            dayCb = new ComboBox();
            monthCb = new ComboBox();
            yearCb = new ComboBox();
            registerBtn = new Button();
            SuspendLayout();
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.BackColor = Color.Transparent;
            textLabel.Font = new Font("Arial", 12F, FontStyle.Bold);
            textLabel.ForeColor = SystemColors.ControlText;
            textLabel.ImageAlign = ContentAlignment.BottomRight;
            textLabel.Location = new Point(109, 44);
            textLabel.Margin = new Padding(4, 0, 4, 0);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(260, 24);
            textLabel.TabIndex = 0;
            textLabel.Text = "Student Registration Form";
            textLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.BackColor = Color.Transparent;
            lastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lastNameLabel.Location = new Point(23, 113);
            lastNameLabel.Margin = new Padding(4, 0, 4, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(127, 28);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Last Name *";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = Color.Transparent;
            firstNameLabel.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold);
            firstNameLabel.Location = new Point(23, 207);
            firstNameLabel.Margin = new Padding(4, 0, 4, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(135, 30);
            firstNameLabel.TabIndex = 2;
            firstNameLabel.Text = "First Name *";
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.BackColor = Color.Transparent;
            middleNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            middleNameLabel.Location = new Point(23, 305);
            middleNameLabel.Margin = new Padding(4, 0, 4, 0);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new Size(155, 28);
            middleNameLabel.TabIndex = 3;
            middleNameLabel.Text = "Middle Name *";
            // 
            // lastNameTb
            // 
            lastNameTb.Location = new Point(29, 150);
            lastNameTb.Margin = new Padding(4);
            lastNameTb.Name = "lastNameTb";
            lastNameTb.Size = new Size(408, 34);
            lastNameTb.TabIndex = 4;
            // 
            // firstNameTb
            // 
            firstNameTb.Location = new Point(29, 244);
            firstNameTb.Margin = new Padding(4);
            firstNameTb.Name = "firstNameTb";
            firstNameTb.Size = new Size(408, 34);
            firstNameTb.TabIndex = 5;
            // 
            // middleNameTb
            // 
            middleNameTb.Location = new Point(29, 342);
            middleNameTb.Margin = new Padding(4);
            middleNameTb.Name = "middleNameTb";
            middleNameTb.Size = new Size(408, 34);
            middleNameTb.TabIndex = 6;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.BackColor = Color.Transparent;
            genderLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            genderLabel.Location = new Point(26, 395);
            genderLabel.Margin = new Padding(4, 0, 4, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(95, 28);
            genderLabel.TabIndex = 7;
            genderLabel.Text = "Gender *";
            // 
            // radioBtn1
            // 
            radioBtn1.AutoSize = true;
            radioBtn1.Location = new Point(142, 396);
            radioBtn1.Margin = new Padding(4);
            radioBtn1.Name = "radioBtn1";
            radioBtn1.Size = new Size(76, 32);
            radioBtn1.TabIndex = 8;
            radioBtn1.TabStop = true;
            radioBtn1.Text = "Male";
            radioBtn1.UseVisualStyleBackColor = true;
            // 
            // radioBtn2
            // 
            radioBtn2.AutoSize = true;
            radioBtn2.Location = new Point(236, 396);
            radioBtn2.Margin = new Padding(4);
            radioBtn2.Name = "radioBtn2";
            radioBtn2.Size = new Size(95, 32);
            radioBtn2.TabIndex = 9;
            radioBtn2.TabStop = true;
            radioBtn2.Text = "Female";
            radioBtn2.UseVisualStyleBackColor = true;
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.BackColor = Color.Transparent;
            dobLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dobLabel.Location = new Point(26, 438);
            dobLabel.Margin = new Padding(4, 0, 4, 0);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(151, 28);
            dobLabel.TabIndex = 10;
            dobLabel.Text = "Date of birth *";
            // 
            // dayCb
            // 
            dayCb.FormattingEnabled = true;
            dayCb.Location = new Point(29, 486);
            dayCb.Margin = new Padding(4);
            dayCb.Name = "dayCb";
            dayCb.Size = new Size(129, 36);
            dayCb.TabIndex = 11;
            dayCb.Tag = "";
            dayCb.SelectedIndexChanged += dayCb_SelectedIndexChanged;
            // 
            // monthCb
            // 
            monthCb.FormattingEnabled = true;
            monthCb.Location = new Point(168, 486);
            monthCb.Margin = new Padding(4);
            monthCb.Name = "monthCb";
            monthCb.Size = new Size(129, 36);
            monthCb.TabIndex = 12;
            // 
            // yearCb
            // 
            yearCb.FormattingEnabled = true;
            yearCb.Location = new Point(308, 484);
            yearCb.Margin = new Padding(4);
            yearCb.Name = "yearCb";
            yearCb.Size = new Size(129, 36);
            yearCb.TabIndex = 13;
            yearCb.SelectedIndexChanged += yearCb_SelectedIndexChanged;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.Crimson;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Segoe UI", 12F);
            registerBtn.ForeColor = Color.White;
            registerBtn.Location = new Point(109, 550);
            registerBtn.Margin = new Padding(4);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(242, 67);
            registerBtn.TabIndex = 14;
            registerBtn.Text = "Register Student";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // frmStudentRegistration
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 649);
            Controls.Add(registerBtn);
            Controls.Add(yearCb);
            Controls.Add(monthCb);
            Controls.Add(dayCb);
            Controls.Add(dobLabel);
            Controls.Add(radioBtn2);
            Controls.Add(radioBtn1);
            Controls.Add(genderLabel);
            Controls.Add(middleNameTb);
            Controls.Add(firstNameTb);
            Controls.Add(lastNameTb);
            Controls.Add(middleNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(textLabel);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmStudentRegistration";
            Text = "Student Registration";
            Load += frmStudentRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private Label middleNameLabel;
        private TextBox lastNameTb;
        private TextBox firstNameTb;
        private TextBox middleNameTb;
        private Label genderLabel;
        private RadioButton radioBtn1;
        private RadioButton radioBtn2;
        private Label dobLabel;
        private ComboBox dayCb;
        private ComboBox monthCb;
        private ComboBox yearCb;
        private Button registerBtn;
    }
}
