using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goldfish_Corporation_Bicycle_Order_Application
{
    public partial class Create_an_Account_Form : Form
    {
        public Create_an_Account_Form()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "")
            {
                MessageBox.Show("Please enter a username/email!");
                return;
            }
            if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Please enter a password!");
                return;
            }
            
            MessageBox.Show("Enter “cnyHuat” for Exclusive Goldfish Red Packets!\n\nEnter “onlineFive” for 5% off your next purchase!  \n\nEnter “rideSafe” for a free mountain bike helmet!\n\n \nNo minimum purchase required. \nValid for one-time use.");
            this.Hide();
            Our_Products OpFM = new Our_Products("Welcome, " + emailTextBox.Text + "!");
            OpFM.ShowDialog();
            this.Close();
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member_Login_Form mlFM = new Member_Login_Form();
            mlFM.Show();
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

        private void frequentlyAskedQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frequently_Asked_Question faqFM = new Frequently_Asked_Question();
            faqFM.Show();
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Create_an_Account_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
