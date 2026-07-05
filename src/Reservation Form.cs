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
    public partial class reservationForm : Form
    {
        public reservationForm()
        {
            InitializeComponent();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void enterButton_Click(object sender, EventArgs e)
        {

        }

        private object confirmReservation()
        {
            throw new NotImplementedException();
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            
        }

        private void dateMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Please input name", "Missing Name");
                nameTextBox.Focus();
            }


            else if (contactNumberMaskedTextBox.Text == "")
            {
                MessageBox.Show("Please input contact number", "Missing Contact Number");
                contactNumberMaskedTextBox.Focus();
            }

            else if (dateMaskedTextBox.Text == "  /  /")
            {
                MessageBox.Show("Please indicate date", "Missing Date");
                dateMaskedTextBox.Focus();
            }

            else if (timeMaskedTextBox.Text == "  :")
            {
                MessageBox.Show("Please indicate time", "Missing Time");
                timeMaskedTextBox.Focus();
            }

            else if (outletComboBox.Text == "")
            {
                MessageBox.Show("Please indicate place of location", "Missing location details");
                outletComboBox.Focus();
            }

            else
            {
                string strName = nameTextBox.Text;
                string strContact = contactNumberMaskedTextBox.Text;
                string strDate = dateMaskedTextBox.Text;
                string strTime = timeMaskedTextBox.Text;
                string strOutlet = outletComboBox.Text;

                string messageString = "Thank you " + strName + " for your reservation on " + strDate
                    + " at " + strTime + " under " + strOutlet + " outlet. Please be on time for your reservation. Thank you.";
                MessageBox.Show(messageString, "Reservation confirmed");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void reservationForm_Load(object sender, EventArgs e)
        {

        }

        private void outletComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
