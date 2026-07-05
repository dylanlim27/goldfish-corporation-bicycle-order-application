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
    public partial class Our_Products : Form
    {
        public Our_Products(string User)
        {
            InitializeComponent();
            label3.Text = User;

        }
        const decimal FIVEOFF_Decimal = 0.05m, SEVENOFF_Decimal = 0.07m, TENOFF_Decimal = 0.1m;
        decimal totalPriceDecimal, totalAmountPriceDecimal, finalAmountDueDecimal,
            listAmountDueDecimal, exceedQuantityDecimal, toMAxQuantityDecimal, cumulativeEodDec = 0m, discountDecimal = 0m, discountedPriceDecimal;
        int quantityInteger, currentOrderQtyInteger, toMaxQuantityInteger, cumulativeQtyInt = 0, cumulativeFrameSizeInt,
            cumulativeWarrantyPackageInt, cumulativeAddOnsInt, addOnsInt;
        string strBike, strBikeFrameSize, strAddOns, strWarrantyPackage;

        string[] strItemDetails;

        //for arrays 
        //track the quantity ordered for each item
        int[] intBikeQty = new int[6]; // there are 6 bikes
        int[] intBikeFrameQty = new int[5]; // there are 5 bike frames
        int[] intWarrantyPackageQty = new int[3]; // there are 3 warranty packages
        int[] intAddOnsQty = new int[3]; // there are 3 add ons

        //track the grand total number of quantity ordered
        int[] intTotalBikeQty = new int[6];
        int[] intTotalBikeFrameQty = new int[5];
        int[] intTotalWarrantyPackageQty = new int[3];
        int[] intTotalAddOnsQty = new int[3];
        public Our_Products()
        {
            InitializeComponent();

            for (int i = 0; i < 6; i++) //bikes
            {
                intBikeQty[i] = 0;
                intTotalBikeQty[i] = 0; 
            }
            for (int g = 0; g < 5; g++) //frame size
            {
                intBikeFrameQty[g] = 0;
                intTotalBikeFrameQty[g] = 0;
            }
            for (int m = 0; m < 3; m++) //warranty
            {
                intWarrantyPackageQty[m] = 0;
                intTotalWarrantyPackageQty[m] = 0;
            }
            for (int a = 0; a < 3; a++) //addons
            {
                intAddOnsQty[a] = 0;
                intTotalAddOnsQty[a] = 0;
            }
        }

        //method: warranty package
        private decimal findWarrantyPackage()
        {
            decimal warrantyPackagePriceDecimal = 0m;
            if (basicWarrantyRadioButton.Checked) warrantyPackagePriceDecimal += 200m;
            if (exteriorWarrantyRadioButton.Checked) warrantyPackagePriceDecimal += 30m;
            if (crashReplacementWarrantyRadioButton.Checked) warrantyPackagePriceDecimal += 125m;
            if (noWarrantyRadioButton.Checked) warrantyPackagePriceDecimal += 0m;
            return warrantyPackagePriceDecimal;
        }

        //method: add ons 
        private decimal findAddOnsPrice()
        {
            decimal addOnsPriceDecimal = 0m;
            if (jblSpeakerCheckBox.Checked) addOnsPriceDecimal += 90m;
            if (cameraCheckbox.Checked) addOnsPriceDecimal += 430m;
            if (cadenceSensorCheckbox.Checked) addOnsPriceDecimal += 70m;
            return addOnsPriceDecimal;
        }

        private void updateAddOns(CheckBox addOnsCheckBox)
        {
            if(jblSpeakerCheckBox.Checked)
            {
                addOnsTextBox1.Text = "JBL Wind Bike Portable Bluetooth Speaker";
            }
            else if (cameraCheckbox.Checked)
            {
                addOnsTextBox2.Text = "Fly 12 CE Eyes Front Camera";
            }
            else if (cadenceSensorCheckbox.Checked)
            {
                addOnsTextBox3.Text = "Wahoo RPM Speed and Cadence Sensor";
            }
            else
            {
                addOnsTextBox1.Text = "";
            }
       
        }

        //method: update total price
        private void updateItemPrice(RadioButton bikeRadioButton, decimal bikePriceDecimal)
        {
            totalPriceDecimal = bikePriceDecimal + findWarrantyPackage() + findAddOnsPrice();
            totalPriceTextBox.Text = totalPriceDecimal.ToString("C");
            warrantyPackagesGroupBox.Enabled = true; 
        }

        //method: update add ons price
        private void updateAddOnsPrice (CheckBox addOnsCheckBox, decimal addOnsPriceDecimal)
        {
            if (addOnsCheckBox.Checked)
            {
                totalPriceDecimal += addOnsPriceDecimal;
                addOnsInt++;
            }
            else
            {
                totalPriceDecimal -= addOnsPriceDecimal;
                addOnsInt--;
            }
            totalPriceTextBox.Text = totalPriceDecimal.ToString("C");
        }

        //method: update warranty price

        private void updateWarrantyPrice(RadioButton warrantyRadioButton, decimal warrantyPriceDecimal)
        {
            if (warrantyRadioButton.Checked)
            {
                totalPriceDecimal += warrantyPriceDecimal;
            }
            else
            {
                totalPriceDecimal -= warrantyPriceDecimal;
            }
            totalPriceTextBox.Text = totalPriceDecimal.ToString("C");
            warrantyPackagesGroupBox.Enabled = true; 
        }

        //Calculate: Bikes listbox radiobutton
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            updateItemPrice(atlasBikeRadioButton, 6400m);

            //display product image
            bikesPictureBox.Image = Goldfish_Corporation_Bicycle_Order_Application.Properties.Resources.bike_1;

            //Display bike details in details rich text box
            string detailsString = "Atlas Ultegra Mechanical Disc Carbon Blue (Road Bike)"
            + "\n\n" + "Price: $6,400"
            + "\n\n" + "Purpose-built for the mountain’s foothills"
            + "\n\n" + "Ability to transition from climb to descent which gives users a feel that the bike has changed after climbing and before descending" 
            + "\n\n" + "Once descending, its ride quality improves the faster one goes"
            + "\n\n" + "Bike shows confidence and stability without showing any difficulties of most lightweight climbing bikes";
            detailsorSpecificationsRichTextBox.Text = detailsString;

            //Display bike in order details group box
            bikeOrderDetailsTextBox.Text = "Atlas Ultegra Mechanical Disc";
            bikePriceOrderDetailsTextBox.Text = "$6,400";
        }

        private void erosBikeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updateItemPrice(erosBikeRadioButton, 10500m);
            
            //Display product image
            bikesPictureBox.Image = Goldfish_Corporation_Bicycle_Order_Application.Properties.Resources.bike_2;

            //Display bike details in details in rich textbox
            string detailsString = "Eros Dura Ace D12 Enve (Road Bike)"
            + "\n\n" + "Price: $10,500"
            + "\n\n" + "It is the very first Bike produced by Alchemy and constantly being improved"
            + "\n\n" + "Hand crafted with USA Titanium makes it stable when riding."
            + "\n\n" + "Excels at climbing steep mountains and descending sharp mountains descends and its classy and subtle design gives it a sleek look making one envious of the peloton.";
            detailsorSpecificationsRichTextBox.Text = detailsString;

            //Display bike in order details group box
            bikeOrderDetailsTextBox.Text = "Eros Dura Ace D12 Enve";
            bikePriceOrderDetailsTextBox.Text = "$10,500";
        }

        private void arktosBikeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updateItemPrice(arktosBikeRadioButton, 5330m);
            
            //Display product image
            bikesPictureBox.Image = Goldfish_Corporation_Bicycle_Order_Application.Properties.Resources.bike_3;

            //Display bike details in details in rich textbox
            string detailsString = "Arktos 29 ST GX Eagle Grey/Blue (Mountain Bike)"
           + "\n\n" + "Price: $5,330"
           + "\n\n" + "The Arktos 29 ST Series is the younger brother of Arktos 29 Series making it smaller and quicker than its older sibling"
           + "\n\n" + "Designed to traverse on fast, open and super techy EWS tracks"
           + "\n\n" + "Turns and switches direction faster and quicker than those tighter switchback bikes and remains stable at all speeds making it an everyday bike for traversing every track";
            detailsorSpecificationsRichTextBox.Text = detailsString;

            //Display bike in order details group box
            bikeOrderDetailsTextBox.Text = "Arktos 29 ST GX Eagle";
            bikePriceOrderDetailsTextBox.Text = "$5,330";
        }

        private void nine7FiveBikeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updateItemPrice(nine7FiveBikeRadioButton, 6800m);

            //Display product image
            bikesPictureBox.Image = Goldfish_Corporation_Bicycle_Order_Application.Properties.Resources.bike_4;

            //Display bike details in detals in rich textbox
            string detailsString = "Nine 7 Five SPRAM X01 Mint/Orange (Mountain Bike)"
           + "\n\n" + "Price: $6,800"
           + "\n\n" + "Crop of mixed wheel bikes makes it be described as a mullet bike as its design shows business in the front and party in the rear"
           + "\n\n" + "Serious endurance bike as with a big front wheel giving it the ability to go over any obstacles and a smaller rear wheel provides a quick handling of a 27.5 ride giving the user the best of 2 worlds.";
            detailsorSpecificationsRichTextBox.Text = detailsString;

            //Display bike in order details group box
            bikeOrderDetailsTextBox.Text = "Nine 7 Five SPRAM X01";
            bikePriceOrderDetailsTextBox.Text = "$6,800";
        }

        private void roninGRXBikeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updateItemPrice(roninGRXBikeRadioButton, 7500m);

            //Display product image
            bikesPictureBox.Image = Goldfish_Corporation_Bicycle_Order_Application.Properties.Resources.bike_5;

            //Display bike details in detals in rich textbox
            string detailsString = "Ronin GRX Di2 Carbon Olive (Gravel Bike)"
           + "\n\n" + "Price: $7,500"
           + "\n\n" + "All new gravel machine of Alchemy that has evolved over ten years which features an alchemy award winning carbon construction with layup specific only to gravel"
           + "\n\n" + "Front triangle is designed to be vertically compliant but laterally stiff which makes the top tube slightly thinner and lighter than their road models.At the same time, the down tube is both oversized and thicker to give the bike the BB stiffness one needs." 
           + "\n\n" + "Uses a thin wall 27.2 seat tube for saddle comfort with a smaller seat that stays with a more noticeable bow to give vertical compliance to the rider." 
           + "\n\n" + "Each Ronin frame has a third water - bottle - cage mount, bento - box bosses as well as a clearance for 700x45mm tires.";
            detailsorSpecificationsRichTextBox.Text = detailsString;

            //Display bike in order details group box
            bikeOrderDetailsTextBox.Text = "Ronin GRX Di2 Carbon Olive";
            bikePriceOrderDetailsTextBox.Text = "$7,500";
        }

        private void roninTiBikeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updateItemPrice(roninTiBikeRadioButton, 10500m);

            //Display product image
            bikesPictureBox.Image = Goldfish_Corporation_Bicycle_Order_Application.Properties.Resources.bike_6;

            //Display bike details in detals in rich textbox
            string detailsString = "Ronin Ti Dura Ace Di2 Disc Enve Titanium/Olive (Gravel Bike)"
           + "\n\n" + "Price: $10,500"
           + "\n\n" + "Purpose-built for gravel riding, with the rider as the benefactor."
           + "\n\n" + "S-bend seat and chain stays damped against any harsh feedback to the rider and to keep the rear wheel tracking, while offering increasing tire clearance over a traditional CX or gravel frame."
           + "\n\n" + "Accommodates 45mm 700c tires or 2.1s with 650 and uses"
           + "\n\n" + "Capable of fender mounting capability";
            detailsorSpecificationsRichTextBox.Text = detailsString;

            //Display bike in order details group box
            bikeOrderDetailsTextBox.Text = "Ronin Ti Dura Ace Di2 Disc Enve";
            bikePriceOrderDetailsTextBox.Text = "$10,500";
        }
        
        //bike frame size
        private void frameSize52RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Display frame size 52 in order details group box
            bikeFrameOrderDetailsTextBox.Text = "52";
        }

        private void frameSize54RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Display frame size 54 in order details group box
            bikeFrameOrderDetailsTextBox.Text = "54";
        }

        private void frameSize56RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Display frame size 56 in order details group box
            bikeFrameOrderDetailsTextBox.Text = "56";
        }

        private void frameSizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Display frame size 58 in order details group box
            bikeFrameOrderDetailsTextBox.Text = "58";
        }

        private void frameSize61RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Display frame size 61 in order details group box
            bikeFrameOrderDetailsTextBox.Text = "61";
        }

        //Add ons
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            updateAddOnsPrice(jblSpeakerCheckBox, 90m);

            //Display image in add ons picture box
            bikesPictureBox.Image = Goldfish_Corporation_Bicycle_Order_Application.Properties.Resources.add_on_1;
           
            //Display add on details specifications in rich text box
            string detailsString = "JBL Wind Bike Portable Bluetooth Speaker" 
                +"\n\n" + "Price: $90"
                + "\n\n" + "Digital Storage Capacity: 32GB"
                + "\n\n" + "Mounting Hardware:FM Radio"
                + "\n\n" + "Speaker Connectivity: Bluetooth, SD Card, USB, Auxiliary"
                + "\n\n" + "Battery Average Life: 10 hours" 
                + "\n\n" + "Product Dimensions: 6.35 x 6.35 x 6.35cm; 91grams";
            detailsorSpecificationsRichTextBox.Text = detailsString;

            //Display addons in order details group box
            if (jblSpeakerCheckBox.Checked)
            {
                addOnsTextBox1.Text = "JBL Wind Bike Portable Bluetooth Speaker";
                addOnsPriceTextBox1.Text = "$90";
            }
            else
            {
                addOnsTextBox1.Text = "";
                addOnsPriceTextBox1.Text = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            updateAddOnsPrice(cameraCheckbox, 430m);

            //Display image in add ons picture box
            bikesPictureBox.Image = Goldfish_Corporation_Bicycle_Order_Application.Properties.Resources.add_on_2;

            //Display add on details specifications in rich text box
            string detailsString = "FLY12 CE Eyes Front Camera"
                + "\n\n" + "Price: $430"
                + "\n\n" + "Front - facing bike camera"
                + "\n\n" + "600 lumenlight"
                + "\n\n" + "Crisp HD Audio"
                + "\n\n" + "Waterproof"
                + "\n\n" + "Battery Average Life: 8 hours of continuous recording";
            detailsorSpecificationsRichTextBox.Text = detailsString;

            //Display addons in order details group box
            if (cameraCheckbox.Checked)
            {
                addOnsTextBox2.Text = "FLY12 CE Eyes Front Camera";
                addOnsPriceTextBox2.Text = "$430";
            }
            else
            {
                addOnsTextBox2.Text = "";
                addOnsPriceTextBox2.Text = "";
            }
        }

        private void cadenceSensorCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            updateAddOnsPrice(cadenceSensorCheckbox, 70m);

            //Display image in add ons picture box
            bikesPictureBox.Image = Goldfish_Corporation_Bicycle_Order_Application.Properties.Resources.add_on_3;

            //Display add on details specifications in rich text box
            string detailsString = "Wahoo RPM Speed and Cadence Sensor"
                + "\n\n" + "Price: $70"
                + "\n\n" + "Track and capture real-time cycling speed and cadence on your bike computer or smartphone with compatible training apps"
                + "\n\n" + "Lightweight and easy to install"
                + "\n\n" + "Battery Average Life: 8760 hours"
                + "\n\n" + "Product Dimensions: 1.25 x 1 x 0.75 inches";
            detailsorSpecificationsRichTextBox.Text = detailsString;

            //Display addons in order details group box
            if(cadenceSensorCheckbox.Checked)
            {
                addOnsTextBox3.Text = "Wahoo RPM Speed and Cadence Sensor";
                addOnsPriceTextBox3.Text = "$70";
            }
            else
            {
                addOnsTextBox3.Text = "";
                addOnsPriceTextBox3.Text = "";
            }
        }
       

        //warranty package

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            updateWarrantyPrice(basicWarrantyRadioButton, 200m);

            //clear product image
            bikesPictureBox.Image = null;

            //Display package information into details in rich textbox
            string detailsString = "Basic Warranty"
                + "\n\n" + "Price: $200"
                + "\n\n" + "5-years warranty-Bikes must be registered within 6 weeks of purchase and proof of purchase will be required";
            detailsorSpecificationsRichTextBox.Text = detailsString;

            //Display bike in order details group box
            warrantyPackageOrderDetailsTextBox.Text = "Basic Warranty";
            warrantyPackagePriceOrderDetailsTextBox.Text = "$200";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            updateWarrantyPrice(exteriorWarrantyRadioButton, 30m);

            //clear product image
            bikesPictureBox.Image = null;

            //Display package information into details in rich textbox
            string detailsString = "Exterior Warranty"
                + "\n\n" + "Price: $30"
                + "\n\n" + "1-year warranty-Paint and finish are covered for from purchase date";
            detailsorSpecificationsRichTextBox.Text = detailsString;

            //Display bike in order details group box
            warrantyPackageOrderDetailsTextBox.Text = "Exterior Warranty";
            warrantyPackagePriceOrderDetailsTextBox.Text = "$30";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            updateWarrantyPrice(crashReplacementWarrantyRadioButton, 125m);

            //clear product image
            bikesPictureBox.Image = null;

            //Display package information into details in rich textbox
            string detailsString = "Crash Replacement Warranty"
                + "\n\n" + "Price: $125"
                + "\n\n" + "3-years warranty- If the bike is damaged because of a crash, caused by abuse, intentional harm, that the claim misrepresents the actual circumstances, or otherwise, Goldfish will offer a suitable replacement at a discounted charge to the original owner";
            detailsorSpecificationsRichTextBox.Text = detailsString;

            //Display bike in order details group box
            warrantyPackageOrderDetailsTextBox.Text = "Crash Replacement Warranty";
            warrantyPackagePriceOrderDetailsTextBox.Text = "$125";
        }

        private void noWarrantyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updateWarrantyPrice(noWarrantyRadioButton, 0m);

            //clear product image
            bikesPictureBox.Image = null;

            //Display package information into details in rich textbox
            detailsorSpecificationsRichTextBox.Text = "";

        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            proceedToCheckoutButton.Enabled = false;
            confirmButton.Enabled = true;
            
            //string: add order items when 'add to order'button is clicked
            if (noneRadioButton1.Checked) //if no bikes selected
            {
                MessageBox.Show("Please choose one of the bikes.", "Missing Product!");
                confirmButton.Enabled = false;
            }
            else //if bikes selected
            {
                
                currentOrderQtyInteger = Convert.ToInt32(bikeQtyNumericUpDown.Value);
                if (currentOrderQtyInteger > 0)
                {
                    quantityInteger += currentOrderQtyInteger; //maximum qty of 15

                    if (quantityInteger <= 15)
                    {
                        addOrder(); //proceed with calculation
                    }
                    else //if qty more than 15
                    {
                        MessageBox.Show("Maximum order quantity is 15. Please head on to our FAQ Page for bulk order enquiries.", "Maximum Order Reached");
                        exceedQuantityDecimal = quantityInteger - 15;
                        toMAxQuantityDecimal = currentOrderQtyInteger - exceedQuantityDecimal;

                        quantityInteger -= currentOrderQtyInteger;

                        if (toMAxQuantityDecimal > 0) //remaining qty allow purchase is more than 0
                        {
                            bikeQtyNumericUpDown.Value = toMAxQuantityDecimal;
                            toMaxQuantityInteger = Convert.ToInt32(bikeQtyNumericUpDown.Value);
                            currentOrderQtyInteger = toMaxQuantityInteger;
                            quantityInteger += currentOrderQtyInteger;

                            addOrder();
                        }
                    }
                    cumulativeAddOnsInt += (addOnsInt * currentOrderQtyInteger);

                }

                if (noneRadioButton3.Checked) //no bike frame size selected
                {
                    MessageBox.Show("Please select a bike frame size", "Frame Size Not Selected!");
                    confirmButton.Enabled = false;
                }
               
            }

            
            //clear for next purchase
            clearForNextOrder();
            warrantyPackagesGroupBox.Enabled = true;
            addOnsGroupBox.Enabled = true;
            frameSizeGroupBox.Enabled = true;
            proceedToCheckoutButton.Enabled = false;
            deleteOrderButton.Enabled = true;
            clearButton.Enabled = true;
            noneRadioButton1.Checked = true;
            noWarrantyRadioButton.Checked = true;
            noneRadioButton3.Checked = true;
            bikeOrderDetailsTextBox.Clear();
            bikeQtyNumericUpDown.Value = 1;
            bikeFrameOrderDetailsTextBox.Clear();
            bikePriceOrderDetailsTextBox.Clear();
            addOnsTextBox1.Clear();
            addOnsTextBox2.Clear();
            addOnsTextBox3.Clear();
            addOnsPriceTextBox1.Clear();
            addOnsPriceTextBox2.Clear();
            addOnsPriceTextBox3.Clear();
            warrantyPackageOrderDetailsTextBox.Clear();
            warrantyPackagePriceOrderDetailsTextBox.Clear();
            totalPriceTextBox.Clear();

        }

        //method: add order to list box and calculations
   
        private void addOrder()
        {
            strBike = string.Empty; //string bike [0]

            //get individual bike quantity (SALES REPORT FORM!!!)

            if (atlasBikeRadioButton.Checked)
            {
                strBike = "Atlas Ultegra Mechanical Disc";
                intBikeQty[0] += currentOrderQtyInteger;
            }
            else if (erosBikeRadioButton.Checked)
            {
                strBike = "Eros Dura Ace D12 Enve";
                intBikeQty[1] += currentOrderQtyInteger;
            }
            else if (arktosBikeRadioButton.Checked)
            {
                strBike = "Arktos 29 ST GX Eagle";
                intBikeQty[2] += currentOrderQtyInteger;
            }
            else if (nine7FiveBikeRadioButton.Checked)
            {
                strBike = "Nine 7 Five SRAM X01";
                intBikeQty[3] += currentOrderQtyInteger;
            }
            else if (roninGRXBikeRadioButton.Checked)
            {
                strBike = "Ronin GRX Di2 Carbon Olive";
                intBikeQty[4] += currentOrderQtyInteger;
            }
            else if (roninTiBikeRadioButton.Checked)
            {
                strBike = "Ronin Ti Dura ACE Di2 Disc Enve";
                intBikeQty[5] += currentOrderQtyInteger;
            }


            //string bike frame size
            if (frameSize52RadioButton.Checked)
            {
                strBikeFrameSize = "52";
                intBikeFrameQty[0] += currentOrderQtyInteger;
                cumulativeFrameSizeInt += currentOrderQtyInteger;
            }
            else if (frameSize54RadioButton.Checked)
            {
                strBikeFrameSize = "54";
                intBikeFrameQty[1] += currentOrderQtyInteger;
                cumulativeFrameSizeInt += currentOrderQtyInteger;
            }
            else if (frameSize56RadioButton.Checked)
            {
                strBikeFrameSize = "56";
                intBikeFrameQty[2] += currentOrderQtyInteger;
                cumulativeFrameSizeInt += currentOrderQtyInteger;
            }
            else if (frameSize58RadioButton.Checked)
            {
                strBikeFrameSize = "58";
                intBikeFrameQty[3] += currentOrderQtyInteger;
                cumulativeFrameSizeInt += currentOrderQtyInteger;
            }
            else if (frameSize61RadioButton.Checked)
            {
                strBikeFrameSize = "61";
                intBikeFrameQty[4] += currentOrderQtyInteger;
                cumulativeFrameSizeInt += currentOrderQtyInteger;
            }


            //string warranty package
            if (basicWarrantyRadioButton.Checked)
            {
                strWarrantyPackage = "Basic Warranty";
                intWarrantyPackageQty[0] += currentOrderQtyInteger;
                cumulativeWarrantyPackageInt += currentOrderQtyInteger;
            }
            else if (exteriorWarrantyRadioButton.Checked)
            {
                strWarrantyPackage = "Exterior Warranty";
                intWarrantyPackageQty[1] += currentOrderQtyInteger;
                cumulativeWarrantyPackageInt += currentOrderQtyInteger;
            }
            else if (crashReplacementWarrantyRadioButton.Checked)
            {
                strWarrantyPackage = "Crash Replacement Warranty";
                intWarrantyPackageQty[1] += currentOrderQtyInteger;
                cumulativeWarrantyPackageInt += currentOrderQtyInteger;
            }
            else if (noWarrantyRadioButton.Checked)
            {
                strWarrantyPackage = "NIL";
                cumulativeWarrantyPackageInt += 0;
            }
            else
            {
                strWarrantyPackage = "NIL";
                cumulativeWarrantyPackageInt += 0;
            }

            //string add ons
            strAddOns = "";
            if (jblSpeakerCheckBox.Checked)
            {
                strAddOns += "JBL Wind Bike Portable Bluetooth Speaker";
                intAddOnsQty[0] += currentOrderQtyInteger;
            }
            if (cameraCheckbox.Checked)
            {
                strAddOns += "FLY12 CE Eyes Front Camera";
                intAddOnsQty[1] += currentOrderQtyInteger;
            }
            if (cadenceSensorCheckbox.Checked)
            {
                strAddOns += "Wahoo RPM Speed and Cadence Sensor";
                intAddOnsQty[2] += currentOrderQtyInteger;
            }
            if (strAddOns == "")
            {
                strAddOns = "NIL";
            }

            //display in textbox: cumulate total value, totalPriceDecimal
            listAmountDueDecimal = currentOrderQtyInteger * totalPriceDecimal;
            totalAmountPriceDecimal += listAmountDueDecimal;
            textBox1.Text = totalAmountPriceDecimal.ToString("C");

            //add to list box (bike, frame size, addOns, warranty, quantity, total price
            listBox1.Items.Add
                (strBike + "\t" +
                strBikeFrameSize + "\t" +
                strAddOns + "\t" +
                strWarrantyPackage + "\t" +
                currentOrderQtyInteger.ToString() + "\t" +
                (currentOrderQtyInteger * totalPriceDecimal).ToString("N"));

            

            //apply discount
            //discount price reduction: discount decimal (after discount)
            if (totalAmountPriceDecimal >= 11000)
            {
                label2.Text =
                    "TENOFF \n" +
                    "10% Discount Applied \n" +
                    "(min. spend of $11,000)";
                discountDecimal = decimal.Round(totalAmountPriceDecimal * TENOFF_Decimal, 2);
                discountedPriceDecimal = totalAmountPriceDecimal - discountDecimal;
                discountPriceTextBox.Text = discountedPriceDecimal.ToString("C");
            }
            else if (totalAmountPriceDecimal>=8000)
            {
                label2.Text =
                    "SEVENOFF \n" +
                    "7% Discount Applied \n" +
                    "(min. spend of $8,000)";
                discountDecimal = decimal.Round(totalAmountPriceDecimal * SEVENOFF_Decimal, 2);
                discountedPriceDecimal = totalAmountPriceDecimal - discountDecimal;
                discountPriceTextBox.Text = discountedPriceDecimal.ToString("C");
            }
            else if (totalAmountPriceDecimal >= 6500)
            {
                label2.Text =
                    "FIVEOFF \n" +
                    "5% Discount Applied \n" +
                    "(min. spend of $6,500)";
                discountDecimal = decimal.Round(totalAmountPriceDecimal * FIVEOFF_Decimal, 2);
                discountedPriceDecimal = totalAmountPriceDecimal - discountDecimal;
                discountPriceTextBox.Text = discountedPriceDecimal.ToString("C");
            }



        }


        //delete order
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0) //if no item is selected
            {
                MessageBox.Show("Please select the item you want to delete", "Removal of product!");
            }
            else if (listBox1.SelectedIndex >=0) // if item is selected
            {
                string messageString = "Are you sure to delete the selected product?";
                DialogResult userResponseDialogResult;

                userResponseDialogResult = MessageBox.Show(messageString, "Delete Set?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (userResponseDialogResult == DialogResult.Yes) //answer is yes
                {
                    string strBikeItem = listBox1.SelectedItem.ToString();
                    strItemDetails = strBikeItem.Split('\t');

                    //array of string: bike, frame, addons, warranty, quantity, total price 
                    int intSetQty = int.Parse(strItemDetails[4]);
                    decimal decItemTotal = decimal.Parse(strItemDetails[5]);

                    quantityInteger -= intSetQty;
                    totalAmountPriceDecimal -= decItemTotal;

                    textBox1.Text = totalAmountPriceDecimal.ToString("C");
                    
                    //bikes [0]
                    if (strItemDetails [0] == "Atlas Ultegra Mechanical Disc")
                    {
                        intBikeQty[0] -= intSetQty;
                    }
                    else if (strItemDetails[0] == "Eros Dura Ace D12 Enve")
                    {
                        intBikeQty[1] -= intSetQty;
                    }
                    else if (strItemDetails[0] == "Arktos 29 ST GX Eagle")
                    {
                        intBikeQty[2] -= intSetQty;
                    }
                    else if (strItemDetails[0] == "Nine 7 Five SRAM X01")
                    {
                        intBikeQty[3] -= intSetQty;
                    }
                    else if (strItemDetails[0] == "Ronin GRX Di2 Carbon Olive")
                    {
                        intBikeQty[4] -= intSetQty;
                    }
                    else if (strItemDetails[0] == "Ronin Ti Dura ACE Di2 Disc Enve")
                    {
                        intBikeQty[5] -= intSetQty;
                    }

                    //frame [1]
                    if (strItemDetails[1] == "52")
                    {
                        intBikeFrameQty[0] -= intSetQty;
                        cumulativeFrameSizeInt -= intSetQty;
                    }
                    else if (strItemDetails[1] == "54")
                    {
                        intBikeFrameQty[1] -= intSetQty;
                        cumulativeFrameSizeInt -= intSetQty;
                    }
                    else if (strItemDetails[1] == "56")
                    {
                        intBikeFrameQty[2] -= intSetQty;
                        cumulativeFrameSizeInt -= intSetQty;
                    }
                    else if (strItemDetails[1] == "58")
                    {
                        intBikeFrameQty[3] -= intSetQty;
                        cumulativeFrameSizeInt -= intSetQty;
                    }
                    else if (strItemDetails[1] == "61")
                    {
                        intBikeFrameQty[4] -= intSetQty;
                        cumulativeFrameSizeInt -= intSetQty;
                    }

                    //addOns [2]
                    if (strItemDetails[2] == "JBL Wind Bike Portable Bluetooth Speaker")
                    {
                        intAddOnsQty[0] -= intSetQty;
                        cumulativeAddOnsInt -= intSetQty;
                    }
                    else if (strItemDetails[2] == "FLY12 CE Eyes Front Camera")
                    {
                        intAddOnsQty[1] -= intSetQty;
                        cumulativeAddOnsInt -= intSetQty;
                    }
                    else if (strItemDetails[2] == "Wahoo RPM Speed and Cadence Sensor")
                    {
                        intAddOnsQty[2] -= intSetQty;
                        cumulativeAddOnsInt -= intSetQty;
                    }

                    //warranty [3]
                    if (strItemDetails[3] == "Basic Warranty")
                    {
                        intWarrantyPackageQty[0] -= intSetQty;
                        cumulativeWarrantyPackageInt -= intSetQty;
                    }
                    else if (strItemDetails[3] == "Exterior Warranty")
                    {
                        intWarrantyPackageQty[1] -= intSetQty;
                        cumulativeWarrantyPackageInt -= intSetQty;
                    }
                    else if (strItemDetails[3] == "Crash Replacement Warranty")
                    {
                        intWarrantyPackageQty[2] -= intSetQty;
                        cumulativeWarrantyPackageInt -= intSetQty;
                    }

                    //remove list
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    deleteOrderButton.Enabled = false;
                    discountPriceTextBox.Clear();
                }

                //if list box is empty 
                if (listBox1.Items.Count ==0)
                {
                    deleteOrderButton.Enabled = false;
                    proceedToCheckoutButton.Enabled = false;
                    bikesPictureBox.Image = null;
                }
                bikesGroupBox.Enabled = true;
                warrantyPackagesGroupBox.Enabled = true;
                addOnsGroupBox.Enabled = true;
                frameSizeGroupBox.Enabled = true;
                addToOrderButton.Enabled = true;
                label2.Text = "";

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                deleteOrderButton.Enabled = true;
            }
            else
            {
                deleteOrderButton.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
   

        }

        //checkout form        
        private void proceedToCheckoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Checkout_Form coForm;
            coForm = new Checkout_Form();
            coForm.setQty(quantityInteger);
            coForm.setExtendedPrice(totalAmountPriceDecimal);
            coForm.setDiscountedPrice(discountedPriceDecimal);
            coForm.setBikeStats(intTotalBikeQty); //checked
            coForm.setBikeFrameStats(intTotalBikeFrameQty); //checked
            coForm.setPackageStats(intTotalWarrantyPackageQty); //checked
            coForm.setAddOnsStat(intTotalAddOnsQty); //checked
            
            if (coForm.ShowDialog() == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        //clear for next order
        private void clearForNextOrder()
        {
            //reset all
            bikesGroupBox.Enabled = true;
            noneRadioButton1.Checked = true;
            noWarrantyRadioButton.Checked = true;
            noneRadioButton3.Checked = true;
            jblSpeakerCheckBox.Checked = false;
            cameraCheckbox.Checked = false;
            cadenceSensorCheckbox.Checked = false;

            bikeQtyNumericUpDown.Value = 1;
            addOnsInt = 0;
        }

        //method: clear whole form
        private void clearWholeForm()
        {
            listBox1.Items.Clear();
            totalAmountPriceDecimal = 0m;
            totalPriceDecimal = 0m;
            label2.Text = "";

            finalAmountDueDecimal = 0m;
            quantityInteger = 0;
            bikesPictureBox.Image = null;
            deleteOrderButton.Enabled = false;
            proceedToCheckoutButton.Enabled = false;
            confirmButton.Enabled = true;
        }

        //clear button
        private void button1_Click_2(object sender, EventArgs e)
        {
            clearForNextOrder();
            clearWholeForm();
            textBox1.Clear();
            discountPriceTextBox.Clear();
            bikesGroupBox.Focus();

            int i = 0; //while loop: bikes (initialize)
            while (i<6)
            {
                intBikeQty[i] = 0;
                i++;
            }

            int g = 0; //while loop: frame size (initialize)
            while (g < 5)
            {
                intBikeFrameQty[g] = 0;
                g++;
            }

            int a = 0; //while loop: addons (initialize)
            while (a < 3)
            {
                intAddOnsQty[a] = 0;
                a++;
            }

            int m = 0; //while loop: warranty (initialize)
            while (m < 3)
            {
                intWarrantyPackageQty[m] = 0;
                m++;
            }
        }

        private void invisibleRadioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            //while loop: bikes
            int i = 0;
            while (i < 6)
            {
                if (intBikeQty[i] > 0)
                {
                    intTotalBikeQty[i] += intBikeQty[i];
                }
                intBikeQty[i] = 0;
                i++;
            }

            //while loop: bike frame
            int g = 0;
            while (g < 5)
            {
                if (intBikeFrameQty[g] > 0)
                {
                    intTotalBikeFrameQty[g] += intBikeFrameQty[g];
                }
                intBikeFrameQty[g] = 0;
                g++;
            }

            //while loop: addOns
            int a = 0;
            while (a < 3)
            {
                if (intAddOnsQty[a] > 0)
                {
                    intTotalAddOnsQty[a] += intAddOnsQty[a];
                }
                intAddOnsQty[a] = 0;
                a++;
            }

            //while loop: warranty
            int m = 0;
            while (m < 3)
            {
                if (intWarrantyPackageQty[m] > 0)
                {
                    intTotalWarrantyPackageQty[m] += intWarrantyPackageQty[m];
                }
                intWarrantyPackageQty[m] = 0;
                m++;
            }

            DialogResult userResponseDialogResult;
            string messageString2 = "Confirm order?";
            userResponseDialogResult = MessageBox.Show(messageString2, "Submit order",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (userResponseDialogResult == DialogResult.Yes)
            {
                cumulativeQtyInt += quantityInteger;
                cumulativeEodDec += finalAmountDueDecimal;

                proceedToCheckoutButton.Enabled = true;
                clearButton.Enabled = false;
                returnButton.Enabled = false;
                deleteOrderButton.Enabled = false;
                bikesGroupBox.Enabled = false;
                addToOrderButton.Enabled = false;
                proceedToCheckoutButton.Focus();
            }
            else
            {
                addToOrderButton.Enabled = true;
                bikesGroupBox.Enabled = true;
                warrantyPackagesGroupBox.Enabled = true;
                addOnsGroupBox.Enabled = true;
                frameSizeGroupBox.Enabled = true;
                proceedToCheckoutButton.Enabled = false;
                deleteOrderButton.Enabled = true;
                clearButton.Enabled = true;
                noneRadioButton1.Checked = true;
                noWarrantyRadioButton.Checked = true;
                noneRadioButton3.Checked = true;
                bikeOrderDetailsTextBox.Clear();
                bikeQtyNumericUpDown.Value = 1;
                bikeFrameOrderDetailsTextBox.Clear();
                bikePriceOrderDetailsTextBox.Clear();
                addOnsTextBox1.Clear();
                addOnsTextBox2.Clear();
                addOnsTextBox3.Clear();
                addOnsPriceTextBox1.Clear();
                addOnsPriceTextBox2.Clear();
                addOnsPriceTextBox3.Clear();
                warrantyPackageOrderDetailsTextBox.Clear();
                warrantyPackagePriceOrderDetailsTextBox.Clear();
                totalPriceTextBox.Clear();
                discountPriceTextBox.Clear();
                label2.Text = "";
                bikesGroupBox.Focus();
            }
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member_Login_Form mlFM = new Member_Login_Form();
            mlFM.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void invisibleRadioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalAmountDueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void warrantyPackagePriceOrderDetailsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void detailsorSpecificationsRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addOnsGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bikeOrderDetailsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        
        private void addOnOrderDetailsTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void addOnsPriceOrderDetailsTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void companynameLabel_Click(object sender, EventArgs e)
        {

        }

      


        private void invisibleRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void invisibleRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Our_Products_Load(object sender, EventArgs e)
        {

        }

        private void bikeFrameSizeOrderDetailsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bikePriceOrderDetailsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalPriceOrderDetailsTextBox_TextChanged(object sender, EventArgs e)
        {
            
          
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            
        }


        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bikesPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void addOnsPictureBox_Click(object sender, EventArgs e)
        {

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }






        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
