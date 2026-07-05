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
    public partial class Checkout_Form : Form
    {
        //promotions and discounts
        const decimal ONLINEFIVE_Decimal = 0.95m;
        private decimal promotionDecimal = 0m,discountedPriceDecimal, finalAmountDueDecimal;
        decimal decExtendedPrice, decDiscountAmount;


        int intOrderQtySold;
        int[] intBikeQtySold;
        int[] intBikeFrameQty;
        int[] intWarrantyPackageQty;
        int[] intAddOnsQty;


        private void extendedPriceLabel_Click(object sender, EventArgs e)
        {

        }
        public void setBikeStats(int[] intTotalBikeQty) //pass on bike stats
        {
            intBikeQtySold = intTotalBikeQty;
        }

        public void setBikeFrameStats(int[] intTotalBikeFrameQty) //pass on bike stats
        {
            intBikeFrameQty = intTotalBikeFrameQty;
        }
        public void setPackageStats(int[] intTotalWarrantyPackageQty) //pass on warranty stats
        {
            intWarrantyPackageQty = intTotalWarrantyPackageQty;
        }

        public void setAddOnsStat(int[] intTotalAddOnsQty) //pass on addons stats
        {
            intAddOnsQty = intTotalAddOnsQty;
        }

        public Checkout_Form()
        { 
            InitializeComponent();


        }
       

        public void setExtendedPrice(decimal listAmountDueDecimal)
        {
            decExtendedPrice = listAmountDueDecimal;
            extendedPriceTextBox.Text = decExtendedPrice.ToString("C");
        }

        public void setQty(int quantityInteger)
        {
            intOrderQtySold = quantityInteger;
            quantityTextBox.Text = intOrderQtySold.ToString();
        }

        public void setDiscountedPrice (decimal discountedPriceDecimal)
        {
            if (decExtendedPrice <= 6500)
                discountTextBox.Text = decExtendedPrice.ToString("C");
            else
            {
                decDiscountAmount = discountedPriceDecimal;
                discountTextBox.Text = decDiscountAmount.ToString("C");
            }
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mmFM = new MainMenuForm(finalAmountDueDecimal);

            deliveryOptionsForm deliveryOptionsForm;
            deliveryOptionsForm = new deliveryOptionsForm();
            this.Hide();
            if (deliveryOptionsForm.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        //promotion code
        private void enterButton_Click(object sender, EventArgs e)
        {
            if (promotionCodeTextBox.Text != "")
            {
                decimal basePrice = (decExtendedPrice <= 6500) ? decExtendedPrice : decDiscountAmount;

                // promotion code reduction after promo is entered
                if (promotionCodeTextBox.Text == "cnyHuat")
                {
                    promotionDecimal = decExtendedPrice;
                    promoTextBox.Text = "Exclusive Goldfish Red Packets";
                }
                else if (promotionCodeTextBox.Text == "onlineFive")
                {
                    if (decExtendedPrice <= 6500) //this promo code will not be valid if minimum spend of $6500 not hit
                    {
                        promotionDecimal = decExtendedPrice;
                        label27.Text = "Promotion code is not\nvalid for this order!"; 
                    }
                    else
                    {
                        promotionDecimal = decDiscountAmount * ONLINEFIVE_Decimal;
                        promoTextBox.Text = "5% OFF";
                        discountedPriceDecimal = decDiscountAmount * 0.05m;
                        label27.Text = "- " + discountedPriceDecimal.ToString("C");
                    }
                }
                else if (promotionCodeTextBox.Text == "rideSafe")
                {
                    promotionDecimal = basePrice;
                    promoTextBox.Text = "Free mountain bike helmet gift";
                }
                else
                {
                    invalidPromoCode();
                    promotionDecimal = basePrice;
                }

                finalAmountDueDecimal = promotionDecimal;
                amountDueTextBox.Text = finalAmountDueDecimal.ToString("C");
                enterButton.Enabled = false;
                checkOutButton.Enabled = true;
            }
            else //no promo entered
            {
                promoTextBox.Text = "";
                finalAmountDueDecimal = (decExtendedPrice <= 6500) ? decExtendedPrice : decDiscountAmount;
                amountDueTextBox.Text = finalAmountDueDecimal.ToString("C");
                checkOutButton.Enabled = true;
            }
        }

        private void extendedPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frequentlyAskedQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void grxFSTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //method: if promo code is invalid
        private void invalidPromoCode()
        {
            promotionCodeTextBox.Clear();
            promotionCodeTextBox.Focus();
            MessageBox.Show("Invalid promotion code entered", "Please Try Again");
            finalAmountDueDecimal = decDiscountAmount;
        }

        // no promo code
        private void button1_Click(object sender, EventArgs e)
        {
            if (decExtendedPrice <= 6500)
            {
                finalAmountDueDecimal = decExtendedPrice;
                promotionCodeTextBox.Clear();
                promotionCodeTextBox.Focus();
                amountDueTextBox.Text = finalAmountDueDecimal.ToString("C");
                promoTextBox.Clear();
                enterButton.Enabled = true;
                label27.Text = "";
                checkOutButton.Enabled = true;
            }
            else
            {
                finalAmountDueDecimal = decDiscountAmount;
                promotionCodeTextBox.Clear();
                promotionCodeTextBox.Focus();
                amountDueTextBox.Text = finalAmountDueDecimal.ToString("C");
                promoTextBox.Clear();
                enterButton.Enabled = true;
                checkOutButton.Enabled = true;
                label27.Text = "";
            }


        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //xfer quantity from product page for BIKES
            atlasTextBox.Text = intBikeQtySold[0].ToString();
            erosTextBox.Text = intBikeQtySold[1].ToString();
            arktosTextBox.Text = intBikeQtySold[2].ToString();
            nine75TextBox.Text = intBikeQtySold[3].ToString();
            grxTextBox.Text = intBikeQtySold[4].ToString();
            tiDuraTextBox.Text = intBikeQtySold[5].ToString();

            MainMenuForm.bikeIntStatistics[0] += intBikeQtySold[0];
            MainMenuForm.bikeIntStatistics[1] += intBikeQtySold[1]; 
            MainMenuForm.bikeIntStatistics[2] += intBikeQtySold[2];
            MainMenuForm.bikeIntStatistics[3] += intBikeQtySold[3];
            MainMenuForm.bikeIntStatistics[4] += intBikeQtySold[4];
            MainMenuForm.bikeIntStatistics[5] += intBikeQtySold[5];

            //for bike FRAMES
            five2TextBox.Text = intBikeFrameQty[0].ToString();
            five4TextBox.Text = intBikeFrameQty[1].ToString();
            five6TextBox.Text = intBikeFrameQty[2].ToString();
            five8TextBox.Text = intBikeFrameQty[3].ToString();
            six1TextBox.Text = intBikeFrameQty[4].ToString();

            //for WARRANTY
            basicTextBox.Text = intWarrantyPackageQty[0].ToString();
            exteriorTextBox.Text = intWarrantyPackageQty[1].ToString();
            crashTextBox.Text = intWarrantyPackageQty[2].ToString();

            MainMenuForm.warrantyIntStatistics[0] += intWarrantyPackageQty[0];
            MainMenuForm.warrantyIntStatistics[1] += intWarrantyPackageQty[1];
            MainMenuForm.warrantyIntStatistics[2] += intWarrantyPackageQty[2];

            //for ADDONS
            jblTextBox.Text = intAddOnsQty[0].ToString();
            flyTextBox.Text = intAddOnsQty[1].ToString();
            wahooTextBox.Text = intAddOnsQty[2].ToString();

            MainMenuForm.addOnsIntStatistics[0] += intAddOnsQty[0];
            MainMenuForm.addOnsIntStatistics[1] += intAddOnsQty[1];
            MainMenuForm.addOnsIntStatistics[2] += intAddOnsQty[2];
        }


        private void discountTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void discountSchemeTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void FeaturedproductsLabel_Click(object sender, EventArgs e)
        {

        }

        private void companynameLabel_Click(object sender, EventArgs e)
        {

        }

        private void amountDueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void companylogoLabel_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void bikeTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
