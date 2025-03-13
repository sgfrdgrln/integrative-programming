namespace StudentGradeApplication
{
    public partial class frmStudentGradeProgram : Form
    {
        public frmStudentGradeProgram()
        {
            InitializeComponent();
        }
        private void generateAvgBtn_click(object Sender, EventArgs e)
        {

            if (nameTb.Text == "")
            {
                MessageBox.Show("Please enter your name.");
                return;
            }
            if (gradeTb1.Text == "" || gradeTb2.Text == "" || gradeTb3.Text == "" || gradeTb4.Text == "" || gradeTb5.Text == "")
            {
                MessageBox.Show("Please enter all grades.");
                return;
            }
            string name = nameTb.Text;
            double grade1 = Convert.ToDouble(gradeTb1.Text);
            double grade2 = Convert.ToDouble(gradeTb2.Text);
            double grade3 = Convert.ToDouble(gradeTb3.Text);
            double grade4 = Convert.ToDouble(gradeTb4.Text);
            double grade5 = Convert.ToDouble(gradeTb5.Text);

            if (grade1 < 0 || grade2 < 0 || grade3 < 0 || grade4 < 0 || grade5 < 0 || grade1 > 100 || grade2 > 100 || grade3 > 100 || grade4 > 100 || grade5 > 100)
            {
                MessageBox.Show("Please enter a valid grade.");
                return;
            }

            double average = (grade1 + grade2 + grade3 + grade4 + grade5) / 5;

            studentResultLabel.Text = average >= 75 ? "The student passed.\nThe general average of " + name + " is " + average + ".": "The student failed.\nThe general average of " + name + " is " + average + ".";
            studentResultLabel.TextAlign = ContentAlignment.TopCenter;
        }
    }
}
