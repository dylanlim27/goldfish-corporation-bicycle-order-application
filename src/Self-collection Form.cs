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
    public partial class selfCollectionForm : Form
    {
        public selfCollectionForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Please input your name.", "Missing Name");
                nameTextBox.Focus();
            }
            else if (contactNumberMaskedTextBox.Text == "")
            {
                MessageBox.Show("Please input contact number details.", "Missing Contact Number");
                contactNumberMaskedTextBox.Focus();
            }
            else if (outletComboBox.Text == "")
            {
                MessageBox.Show("Please input location of outlet.", "Missing Outlet Location");
            }
            else
            {
                string strName = nameTextBox.Text;
                string strContact = contactNumberMaskedTextBox.Text;
                string strLocation = outletComboBox.Text;
                
                string messageString = "Thank you " + strName + " for ordering from Goldfish Corporation." + " We will notify you through text when your products are ready for collection."
                    + " Your contact number is " + strContact + " and your collection outlet is " + strLocation + ". " + "\n" + "Your collection details has been confirmed." + "\n" + "Please proceed to complete your payment.";
                
                MessageBox.Show(messageString, "Self-collection confirmed");
                this.Hide();
                Payment_Form paymentFM = new Payment_Form();
                if (paymentFM.ShowDialog() == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    this.Show();
                }
            }
        }

        private void contactNumberMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void locationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Ghg_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void companylogoLabel_Click(object sender, EventArgs e)
        {

        }

        private void companynameLabel_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void outletComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frequentlyAskedQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
