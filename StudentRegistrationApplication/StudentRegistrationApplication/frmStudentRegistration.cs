namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
            PopulateDateComboBoxes();
            // Add event handlers to update day selection when month or year changes
            monthCb.SelectedIndexChanged += ComboBoxMonthOrYear_SelectedIndexChanged;
            yearCb.SelectedIndexChanged += ComboBoxMonthOrYear_SelectedIndexChanged;
        }

        private void PopulateDateComboBoxes()
        {
            // Add placeholders
            dayCb.Items.Add("-Day-");
            monthCb.Items.Add("-Month-");
            yearCb.Items.Add("-Year-");

            // Populate days (1-31)
            for (int day = 1; day <= 31; day++)
            {
                dayCb.Items.Add(day);
            }

            // Populate months (1-12)
            for (int month = 1; month <= 12; month++)
            {
                monthCb.Items.Add(month);
            }

            // Populate years (1900 - current year)
            int currentYear = DateTime.Now.Year;
            for (int year = 1900; year <= currentYear; year++)
            {
                yearCb.Items.Add(year);
            }

            // Set default selection to placeholders
            dayCb.SelectedIndex = 0;
            monthCb.SelectedIndex = 0;
            yearCb.SelectedIndex = 0;
        }

        private void ComboBoxMonthOrYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDayComboBox();
        }

        private void UpdateDayComboBox()
        {
            // Ensure valid selection before updating days
            if (monthCb.SelectedIndex == 0 || yearCb.SelectedIndex == 0)
            {
                return; // If month or year is not selected, do nothing
            }

            // Get selected month and year (skip placeholder)
            int selectedMonth = int.Parse(monthCb.SelectedItem.ToString());
            int selectedYear = int.Parse(yearCb.SelectedItem.ToString());

            // Calculate the number of days in the selected month and year
            int daysInMonth = DateTime.DaysInMonth(selectedYear, selectedMonth);

            // Clear and repopulate Day ComboBox
            dayCb.Items.Clear();
            dayCb.Items.Add("-Day-"); // Re-add placeholder
            for (int day = 1; day <= daysInMonth; day++)
            {
                dayCb.Items.Add(day);
            }

            // Reset selection to placeholder
            dayCb.SelectedIndex = 0;
        }

        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {

        }


        private void dayCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void yearCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {

            // Ensure all fields are filled
            if (lastNameTb.Text == "" || firstNameTb.Text == "" || middleNameTb.Text == "" ||
                dayCb.SelectedIndex == 0 || monthCb.SelectedIndex == 0 || yearCb.SelectedIndex == 0 ||
                (!radioBtn1.Checked && !radioBtn2.Checked))
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                // Get selected gender
                string gender = radioBtn1.Checked ? "Male" : "Female";

                // Get date of birth
                string day = dayCb.SelectedItem.ToString();
                string month = monthCb.SelectedItem.ToString();
                string year = yearCb.SelectedItem.ToString();
                string dateOfBirth = day + "/" + month + "/" + year;

                // Display student info in a message box
                MessageBox.Show(
                    "Student name: " + firstNameTb.Text + " " + middleNameTb.Text + " " + lastNameTb.Text +
                    "\nGender: " + gender +
                    "\nDate of birth: " + dateOfBirth
                );
            }

        }
    }
}
