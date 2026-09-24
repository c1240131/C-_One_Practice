using System.Xml.Linq;

namespace Student_Information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            Lbloutput.Text = "Name: " + textname.Text +
                     "\nStudent ID: " + textstudentid.Text +
                     "\nDepartment: " + textdepartment.Text +
                     "\nSemester: " + textsemester.Text;
        }

        private void bntclear_Click(object sender, EventArgs e)
        {
            textname.Clear();
            textstudentid.Clear();
            textdepartment.Clear();
            textsemester.Clear();
            Lbloutput.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    
