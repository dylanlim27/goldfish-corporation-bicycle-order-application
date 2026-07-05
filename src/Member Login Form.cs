using System;
using System.Windows.Forms;

namespace Goldfish_Corporation_Bicycle_Order_Application
{
    public partial class Member_Login_Form : Form
    {
        public Member_Login_Form()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e) //continue as guest
        {
            Our_Products OpFM = new Our_Products("Welcome, Guest!");
            this.Hide();
            OpFM.ShowDialog();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Create_an_Account_Form CaaFm = new Create_an_Account_Form();
            this.Hide();
            CaaFm.ShowDialog();
            this.Close();
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "dbs@gmail.com")
            {
                if (passwordTextBox.Text != "dbs123")
                {
                    string messageString2 = "You have entered the wrong password, please try again.";
                    MessageBox.Show(messageString2, " Email Error.", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Enter “cnyHuat” for Exclusive Goldfish Red Packets!\n\nEnter “onlineFive” for 5% off your next purchase!  \n\nEnter “rideSafe” for a free mountain bike helmet!\n\n \nNo minimum purchase required. \nValid for one-time use.");
                    this.Hide();
                    Our_Products OpFM = new Our_Products("Welcome, DBS!");
                    OpFM.ShowDialog();
                    this.Close();
                }

            }
            else if (emailTextBox.Text == "DBS")
            {
                if (passwordTextBox.Text != "dbs123")
                {
                    string messageString = "You have entered the wrong password, please try again.";
                    MessageBox.Show(messageString, " Email Error.", MessageBoxButtons.OK);
                }

                else
                {
                    MessageBox.Show("Enter “cnyHuat” for Exclusive Goldfish Red Packets!\n\n Enter “onlineFive” for 5% off your next purchase!  \n\n Enter “rideSafe” for a free mountain bike helmet!\n\n \n No minimum purchase required. \n Valid for one-time use.");
                    this.Hide();
                    Our_Products OpFM = new Our_Products("Welcome, DBS!");
                    OpFM.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                string messageString = "You have entered the wrong username/email, please try again.";
                MessageBox.Show(messageString, " Username/Email Error.", MessageBoxButtons.OK);

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Our_Products opFM = new Our_Products();
            opFM.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frequentlyAskedQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frequently_Asked_Question faqFM = new Frequently_Asked_Question();
            faqFM.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Member_Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}





