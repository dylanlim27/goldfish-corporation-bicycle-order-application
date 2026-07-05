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
    public partial class homeDeliveryForm : Form
    {
        public homeDeliveryForm()
        {
            InitializeComponent();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Please input your name", "Missing Name");
                nameTextBox.Focus();
            }
            else if (contactNumberMaskedTextBox.Text == "")
            {
                MessageBox.Show("Please input contact number details", "Missing Contact Number");
                contactNumberMaskedTextBox.Focus();
            }
            else if (addressTextBox.Text == "")
            {
                MessageBox.Show("Please indicate address details", "Missing Address");
                addressTextBox.Focus();
            }
            else if (postalMaskedTextBox.Text == "")
            {
                MessageBox.Show("Please indicate postal code number", "Missing Postal Code");
                postalMaskedTextBox.Focus();
            }
            else
            {
                string strName = nameTextBox.Text;
                string strContact = contactNumberMaskedTextBox.Text;
                string strAddress = addressTextBox.Text;
                string strCode = postalMaskedTextBox.Text;

                string messageString = "Thank you " + strName + " for ordering from Goldfish Corporation." + " We will notify you via text when your product(s) is shipped." + "Your contact number is "
                    + strContact + " and your address is " + strAddress + " and your postal code is " + strCode + "." + "\n" + "Please proceed to complete your payment.";
                MessageBox.Show(messageString, "Delivery details confirmed");

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

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            
        }

        private void homeDeliveryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
