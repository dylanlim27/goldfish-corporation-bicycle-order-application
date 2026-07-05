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
    public partial class deliveryOptionsForm : Form
    {
        public deliveryOptionsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void selfCollectionButton_Click(object sender, EventArgs e)
        {
            selfCollectionForm selfCollectionForm = new selfCollectionForm();
            this.Hide();
            if (selfCollectionForm.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void homeDeliveryButton_Click(object sender, EventArgs e)
        {
            homeDeliveryForm homeDeliveryForm = new homeDeliveryForm();
            this.Hide();
            if (homeDeliveryForm.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void reservationButton_Click(object sender, EventArgs e)
        {
            reservationForm reservationForm = new reservationForm();
            this.Hide();
            if (reservationForm.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
