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
    public partial class sales_Report : Form
    {
        int atlas, eros, arktos, nine75, grx, tiDura, jbl, fly, wahoo, basic, exterior, crash;
        int totalBikes, totalAddOns, totalWarrantyPackages;
        decimal cumulativeSales = 0m;

        public sales_Report(int atlasInt, int erosInt, int arktosInt, int nine75Int, int grxInt,
            int tiDuraInt, int jblInt, int flyInt, int wahooInt, int basicInt, int exteriorInt, int crashInt, decimal totalSales)


        {
            InitializeComponent();
            atlas = atlasInt;
            eros = erosInt;
            arktos = arktosInt;
            nine75 = nine75Int;
            grx = grxInt;
            tiDura = tiDuraInt;

            jbl = jblInt;
            fly = flyInt;
            wahoo = wahooInt;

            basic = basicInt;
            exterior = exteriorInt;
            crash = crashInt;
            cumulativeSales = totalSales;

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void totalBikesTextBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void totalAddOnsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalPackagesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member_Login_Form mlFM = new Member_Login_Form();
            mlFM.Show();
        }

        private void eodSalesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "goldfishcorp123")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
            }
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void warrantySalesChart_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

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

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void sales_Report_Load(object sender, EventArgs e)
        {
            atlasLabel.Text = atlas.ToString();
            erosLabel.Text = eros.ToString();
            arktosLabel.Text = arktos.ToString();
            nine75Label.Text = nine75.ToString();
            grxLabel.Text = grx.ToString();
            tiDuraLabel.Text = tiDura.ToString();

            jblLabel.Text = jbl.ToString();
            flyLabel.Text = fly.ToString();
            wahooLabel.Text = wahoo.ToString();

            basicLabel.Text = basic.ToString();
            exteriorLabel.Text = exterior.ToString();
            crashLabel.Text = crash.ToString();

            eodSalesTextBox.Text = cumulativeSales.ToString("C");

            totalBikes = atlas + eros + arktos + nine75 + tiDura + grx;
            totalBikesTextBox.Text = totalBikes.ToString();

            totalAddOns = jbl + fly + wahoo;
            totalAddOnsTextBox.Text = totalAddOns.ToString();

            totalWarrantyPackages = basic + exterior + crash;
            totalPackagesTextBox.Text = totalWarrantyPackages.ToString();

            //set bar points for bikes
       
            bikesSalesChart.Series["Number of Bikes Sold"].Points.AddXY("Atlas", atlas.ToString());
            bikesSalesChart.Series["Number of Bikes Sold"].Points.AddXY("Eros", eros.ToString());
            bikesSalesChart.Series["Number of Bikes Sold"].Points.AddXY("Arktos", arktos.ToString());
            bikesSalesChart.Series["Number of Bikes Sold"].Points.AddXY("Nine 75", nine75.ToString());
            bikesSalesChart.Series["Number of Bikes Sold"].Points.AddXY("GRX", grx.ToString());
            bikesSalesChart.Series["Number of Bikes Sold"].Points.AddXY("Ti Dura", tiDura.ToString());

            //set bar points for addons

            addOnsSalesChart.Series["Number of Add Ons Sold"].Points.AddXY("JBL", jbl.ToString());
            addOnsSalesChart.Series["Number of Add Ons Sold"].Points.AddXY("FLY12", fly.ToString());
            addOnsSalesChart.Series["Number of Add Ons Sold"].Points.AddXY("Wahoo", wahoo.ToString());

            //set bar points for warranty packages

            warrantySalesChart.Series["Number of Warranty Sold"].Points.AddXY("Basic", basic.ToString());
            warrantySalesChart.Series["Number of Warranty Sold"].Points.AddXY("Exterior", exterior.ToString());
            warrantySalesChart.Series["Number of Warranty Sold"].Points.AddXY("Crash Replacement", crash.ToString());

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}

