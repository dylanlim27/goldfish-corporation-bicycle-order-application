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
    public partial class MainMenuForm : Form
    {
        int atlasInt, erosInt, arktosInt, nine75Int, grxInt, tiDuraInt;
        int jblInt, flyInt, wahooInt;
        int basicInt, exteriorInt, crashInt;
        public static decimal totalSales;
        public static int[] bikeIntStatistics = new int[6];
        public static int[] addOnsIntStatistics = new int[3];
        public static int[] warrantyIntStatistics = new int[3];


        public MainMenuForm()
        {
            InitializeComponent();
            bikeIntStatistics[0] = 0;
            bikeIntStatistics[1] = 0;
            bikeIntStatistics[2] = 0;
            bikeIntStatistics[3] = 0;
            bikeIntStatistics[4] = 0;
            bikeIntStatistics[5] = 0;

            addOnsIntStatistics[0] = 0;
            addOnsIntStatistics[1] = 0;
            addOnsIntStatistics[2] = 0;

            warrantyIntStatistics[0] = 0;
            warrantyIntStatistics[1] = 0;
            warrantyIntStatistics[2] = 0;

        }

        public MainMenuForm(decimal finalAmountDueDecimal)
        {
            InitializeComponent();
            totalSales = finalAmountDueDecimal;
        }

        

        private void label3_Click(object sender, EventArgs e)
        {
            Arktos_29_ST_GX_Eagle_GreyBlue_Review_Page arktosFM = new Arktos_29_ST_GX_Eagle_GreyBlue_Review_Page();
            arktosFM.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Atlas_Uletegra_Mechanical_Disc_Carbon_Blue_Review aumFM = new Atlas_Uletegra_Mechanical_Disc_Carbon_Blue_Review();
            aumFM.Show();
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string messageString = "Are you sure you want to exit?";
            DialogResult userResponseDialogResult;
            userResponseDialogResult = MessageBox.Show(messageString, "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (userResponseDialogResult == DialogResult.Yes)
                this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Eros_Dura_Ace_D12_Enve_Review_Page erosFm = new Eros_Dura_Ace_D12_Enve_Review_Page();
            erosFm.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Atlas_Uletegra_Mechanical_Disc_Carbon_Blue_Review AumFm = new Atlas_Uletegra_Mechanical_Disc_Carbon_Blue_Review();
            AumFm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member_Login_Form MbLnFm = new Member_Login_Form();
            MbLnFm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Our_Products OpFM = new Our_Products("Welcome, Guest!");
            OpFM.Show();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void orderCompleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            Arktos_29_ST_GX_Eagle_GreyBlue_Review_Page arktosFM = new Arktos_29_ST_GX_Eagle_GreyBlue_Review_Page();
            arktosFM.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Eros_Dura_Ace_D12_Enve_Review_Page erosFM = new Eros_Dura_Ace_D12_Enve_Review_Page();
            erosFM.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Frequently_Asked_Question faqFM = new Frequently_Asked_Question();
            faqFM.Show();
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

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs aboutusFM = new AboutUs();
            aboutusFM.Show();
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
            atlasInt = bikeIntStatistics[0];
            erosInt = bikeIntStatistics[1];
            arktosInt = bikeIntStatistics[2];
            nine75Int = bikeIntStatistics[3];
            grxInt = bikeIntStatistics[4];
            tiDuraInt = bikeIntStatistics[5];

            jblInt = addOnsIntStatistics[0];
            flyInt = addOnsIntStatistics[1];
            wahooInt = addOnsIntStatistics[2];

            basicInt = warrantyIntStatistics[0];
            exteriorInt = warrantyIntStatistics[1];
            crashInt = warrantyIntStatistics[2];


            sales_Report srFM = new sales_Report(atlasInt, erosInt, arktosInt, nine75Int, grxInt,
                tiDuraInt, jblInt, flyInt, wahooInt, basicInt, exteriorInt, crashInt, totalSales);
            srFM.Show();
        }

        private void aboutUsButton_Click(object sender, EventArgs e)
        {
            AboutUs aboutusFM = new AboutUs();
            aboutusFM.Show();
        }
    }
}
