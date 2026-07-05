using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goldfish_Corporation_Bicycle_Order_Application
{
    public partial class Payment_Form : Form
    {
        public Payment_Form()
        {
            InitializeComponent();
         
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void Payment_Form_Load(object sender, EventArgs e)
        {




        }

        private void paypalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        private void codRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            //Strip any non-numeric values
            txtCard.Text = Regex.Replace(txtCard.Text, @"[^\d]", "");
            Regex expressionVisa = new Regex("^4[0-9]{12}(?:[0-9]{3})?$");
            Regex expressionMasterCard = new Regex("^5[1-5][0-9]{14}?$");

            if (tncCheckBox.Checked) // 1. check if tnc box is checked first
            {
                if (nameTextBox.Text == "")
                {
                    string messageString = "Please input cardholder's name.";
                    MessageBox.Show(messageString, "Cardholder name missing");
                }
                else
                {
                    if (cvvMaskedTextBox2.Text == "") // 2. check if cvv is filled up
                    {
                        string messageString = "Please input card's CVV.";
                        MessageBox.Show(messageString, "CVV missing");
                    }
                    else
                    {
                        if (monthComboBox.Text == "") // 3. check if card expiry month/year is filled up
                        {
                            string messageString = "Please input card's expiry date.";
                            MessageBox.Show(messageString, "Expiry date missing");
                        }
                        else if (yearComboBox.Text == "")
                        {
                            string messageString = "Please input card's expiry date.";
                            MessageBox.Show(messageString, "Expiry date missing");
                        }
                        else
                        {
                            if (expressionVisa.IsMatch(txtCard.Text)) // 4. check credit card whether its mastercard/visa through first digit
                            {
                                string messageString = "Your payment has been made. Thank you for purchasing from Goldfish Corporation.";
                                MessageBox.Show(messageString, "Payment Successful");
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else if (expressionMasterCard.IsMatch(txtCard.Text))
                            {
                                string messageString = "Your payment has been made. Thank you for purchasing from Goldfish Corporation.";
                                MessageBox.Show(messageString, "Payment Successful");
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                string messageString = "Your card number is invalid. Please try again.";
                                MessageBox.Show(messageString, "Invalid card number");
                            }
                        }
                    }
                }
            }
            else
            {
                string messageString = "Please tick the terms and conditions";
                MessageBox.Show(messageString, "Terms and Conditions");
            }



            //^ represents the starting of the string.
            //4 represents the string should start with 5 (Visa cards)
            //[0 - 9]{12} represents the next twelve digits should be any between 0 - 9.
            //(represents the starting of the group.
            //? represents the 0 or 1 time.
            //[0 - 9]{3} represents the next three digits should be any between 0 - 9. 
            // represents the ending of the group.
            //? represents the 0 or 1 time.
            //$ represents the ending of the string.

            //^ represents the starting of the string.
            //5 represents the string should start with 5 (Mastercard cards)
            //[0 - 9]{12} represents the next twelve digits should be any between 0 - 9.
            //(represents the starting of the group.
            //? represents the 0 or 1 time.
            //[0 - 9]{3} represents the next three digits should be any between 0 - 9. 
            // represents the ending of the group.
            //? represents the 0 or 1 time.
            //$ represents the ending of the string.


        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtCard_TextChanged(object sender, EventArgs e)
        {

        }
    }


    
}
