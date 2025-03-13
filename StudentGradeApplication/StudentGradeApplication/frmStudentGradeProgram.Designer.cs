namespace StudentGradeApplication
{
    partial class frmStudentGradeProgram
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
            nameLabel = new Label();
            nameTb = new TextBox();
            gradeTb1 = new TextBox();
            label2 = new Label();
            gradeTb2 = new TextBox();
            gradeTb3 = new TextBox();
            gradeTb4 = new TextBox();
            gradeTb5 = new TextBox();
            englishLabel = new Label();
            mathLabel = new Label();
            scienceLabel = new Label();
            filipinoLabel = new Label();
            historyLabel = new Label();
            studentResultLabel = new Label();
            generateAvgBtn = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(28, 32);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(56, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name: ";
            // 
            // nameTb
            // 
            nameTb.Location = new Point(90, 29);
            nameTb.Name = "nameTb";
            nameTb.Size = new Size(517, 27);
            nameTb.TabIndex = 1;
            // 
            // gradeTb1
            // 
            gradeTb1.Location = new Point(90, 93);
            gradeTb1.Name = "gradeTb1";
            gradeTb1.Size = new Size(86, 27);
            gradeTb1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 70);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 3;
            label2.Text = "Grades";
            // 
            // gradeTb2
            // 
            gradeTb2.Location = new Point(90, 126);
            gradeTb2.Name = "gradeTb2";
            gradeTb2.Size = new Size(86, 27);
            gradeTb2.TabIndex = 4;
            // 
            // gradeTb3
            // 
            gradeTb3.Location = new Point(90, 159);
            gradeTb3.Name = "gradeTb3";
            gradeTb3.Size = new Size(86, 27);
            gradeTb3.TabIndex = 5;
            // 
            // gradeTb4
            // 
            gradeTb4.Location = new Point(90, 192);
            gradeTb4.Name = "gradeTb4";
            gradeTb4.Size = new Size(86, 27);
            gradeTb4.TabIndex = 6;
            // 
            // gradeTb5
            // 
            gradeTb5.Location = new Point(90, 225);
            gradeTb5.Name = "gradeTb5";
            gradeTb5.Size = new Size(86, 27);
            gradeTb5.TabIndex = 7;
            // 
            // englishLabel
            // 
            englishLabel.AutoSize = true;
            englishLabel.Location = new Point(28, 96);
            englishLabel.Name = "englishLabel";
            englishLabel.Size = new Size(56, 20);
            englishLabel.TabIndex = 8;
            englishLabel.Text = "English";
            // 
            // mathLabel
            // 
            mathLabel.AutoSize = true;
            mathLabel.Location = new Point(28, 128);
            mathLabel.Name = "mathLabel";
            mathLabel.Size = new Size(43, 20);
            mathLabel.TabIndex = 9;
            mathLabel.Text = "Math";
            // 
            // scienceLabel
            // 
            scienceLabel.AutoSize = true;
            scienceLabel.Location = new Point(28, 162);
            scienceLabel.Name = "scienceLabel";
            scienceLabel.Size = new Size(59, 20);
            scienceLabel.TabIndex = 10;
            scienceLabel.Text = "Science";
            // 
            // filipinoLabel
            // 
            filipinoLabel.AutoSize = true;
            filipinoLabel.Location = new Point(28, 195);
            filipinoLabel.Name = "filipinoLabel";
            filipinoLabel.Size = new Size(58, 20);
            filipinoLabel.TabIndex = 11;
            filipinoLabel.Text = "Filipino";
            // 
            // historyLabel
            // 
            historyLabel.AutoSize = true;
            historyLabel.Location = new Point(28, 228);
            historyLabel.Name = "historyLabel";
            historyLabel.Size = new Size(56, 20);
            historyLabel.TabIndex = 12;
            historyLabel.Text = "History";
            // 
            // studentResultLabel
            // 
            studentResultLabel.AutoSize = true;
            studentResultLabel.Location = new Point(293, 159);
            studentResultLabel.Name = "studentResultLabel";
            studentResultLabel.Size = new Size(0, 20);
            studentResultLabel.TabIndex = 13;
            // 
            // generateAvgBtn
            // 
            generateAvgBtn.Location = new Point(28, 274);
            generateAvgBtn.Name = "generateAvgBtn";
            generateAvgBtn.Size = new Size(148, 76);
            generateAvgBtn.TabIndex = 14;
            generateAvgBtn.Text = "Generate Average";
            generateAvgBtn.UseVisualStyleBackColor = true;
            generateAvgBtn.Click += generateAvgBtn_click;
            // 
            // frmStudentGradeProgram
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 383);
            Controls.Add(generateAvgBtn);
            Controls.Add(studentResultLabel);
            Controls.Add(historyLabel);
            Controls.Add(filipinoLabel);
            Controls.Add(scienceLabel);
            Controls.Add(mathLabel);
            Controls.Add(englishLabel);
            Controls.Add(gradeTb5);
            Controls.Add(gradeTb4);
            Controls.Add(gradeTb3);
            Controls.Add(gradeTb2);
            Controls.Add(label2);
            Controls.Add(gradeTb1);
            Controls.Add(nameTb);
            Controls.Add(nameLabel);
            Name = "frmStudentGradeProgram";
            Text = "Student Grade Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameTb;
        private TextBox gradeTb1;
        private Label label2;
        private TextBox gradeTb2;
        private TextBox gradeTb3;
        private TextBox gradeTb4;
        private TextBox gradeTb5;
        private Label englishLabel;
        private Label mathLabel;
        private Label scienceLabel;
        private Label filipinoLabel;
        private Label historyLabel;
        private Label studentResultLabel;
        private Button generateAvgBtn;
    }
}
