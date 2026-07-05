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
    public partial class Frequently_Asked_Question : Form
    {
        //declare 3 variables for submit button
        string nameString;
        string emailString;
        string questionString;

        public Frequently_Asked_Question()
        {
            InitializeComponent();
        }

        private void Frequently_Asked_Question_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FeaturedproductsLabel_Click(object sender, EventArgs e)
        {

        }

        private void Frequently_Asked_Question_Load_1(object sender, EventArgs e)
        {
            
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            nameString = "Name: \t" + nameTextBox.Text;
            emailString = "Email: \t" + emailTextBox.Text;
            questionString = "Question: \t" + questionRichTextBox.Text;

            DialogResult UserResponseDialogResult;

            //display in message box
            UserResponseDialogResult = MessageBox.Show(nameString + "\n\n" + emailString + "\n\n" + questionString,
                "Please confirm your information and question.",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (UserResponseDialogResult == DialogResult.Yes)
            {
                // proceed to record response
                nameTextBox.Clear();
                emailTextBox.Clear();
                questionRichTextBox.Clear();

                MessageBox.Show("Your response has been recorded." + "\n" + "We will reply via email within 3-5 working days.", "Response Recorded"); 
                nameTextBox.Focus();
            }
            else
            {
                nameTextBox.Focus(); 
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
