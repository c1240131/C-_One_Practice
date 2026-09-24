namespace BirthDateString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dayOfWeekTextBox.Clear();
            monthTextBox.Clear();
            dayOfMonthTextBox.Clear();
            yearTextBox.Clear();
            dateOutputLabel.Text = "";
        }

        private void sowDateButton_Click(object sender, EventArgs e)
        {
            dateOutputLabel.Text = 
                dayOfWeekTextBox.Text + ", "
                    + monthTextBox.Text + " "
                    + dayOfMonthTextBox.Text + 
                    ", "
                    + yearTextBox.Text;

            }
    }
}
