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
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
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

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frequently_Asked_Question faqFM = new Frequently_Asked_Question();
            faqFM.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frequently_Asked_Question faqFM = new Frequently_Asked_Question();
            faqFM.Show();
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
