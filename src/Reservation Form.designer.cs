
namespace Goldfish_Corporation_Bicycle_Order_Application
{
    partial class reservationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ghg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.timeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.contactNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.outletComboBox = new System.Windows.Forms.ComboBox();
            this.companylogoLabel = new System.Windows.Forms.PictureBox();
            this.companynameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.companylogoLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 42);
            this.label1.TabIndex = 21;
            this.label1.Text = "Reservation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(391, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "&Name:";
            // 
            // Ghg
            // 
            this.Ghg.AutoSize = true;
            this.Ghg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ghg.Location = new System.Drawing.Point(391, 249);
            this.Ghg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ghg.Name = "Ghg";
            this.Ghg.Size = new System.Drawing.Size(193, 29);
            this.Ghg.TabIndex = 22;
            this.Ghg.Text = "C&ontact Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(391, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "&Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(391, 357);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "T&ime:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(391, 414);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 29);
            this.label7.TabIndex = 22;
            this.label7.Text = "Outlet &Location:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(636, 201);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(163, 22);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // dateMaskedTextBox
            // 
            this.dateMaskedTextBox.Location = new System.Drawing.Point(636, 309);
            this.dateMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dateMaskedTextBox.Mask = "00/00/0000";
            this.dateMaskedTextBox.Name = "dateMaskedTextBox";
            this.dateMaskedTextBox.Size = new System.Drawing.Size(132, 22);
            this.dateMaskedTextBox.TabIndex = 3;
            this.dateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // timeMaskedTextBox
            // 
            this.timeMaskedTextBox.Location = new System.Drawing.Point(636, 364);
            this.timeMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.timeMaskedTextBox.Mask = "00:00";
            this.timeMaskedTextBox.Name = "timeMaskedTextBox";
            this.timeMaskedTextBox.Size = new System.Drawing.Size(103, 22);
            this.timeMaskedTextBox.TabIndex = 4;
            this.timeMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // contactNumberMaskedTextBox
            // 
            this.contactNumberMaskedTextBox.Location = new System.Drawing.Point(636, 255);
            this.contactNumberMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.contactNumberMaskedTextBox.Mask = "00000000";
            this.contactNumberMaskedTextBox.Name = "contactNumberMaskedTextBox";
            this.contactNumberMaskedTextBox.Size = new System.Drawing.Size(163, 22);
            this.contactNumberMaskedTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(344, 520);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 60);
            this.button1.TabIndex = 6;
            this.button1.Text = "&Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(690, 520);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(156, 60);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "B&ack";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // outletComboBox
            // 
            this.outletComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outletComboBox.FormattingEnabled = true;
            this.outletComboBox.Items.AddRange(new object[] {
            "HarbourFront",
            "Orchard",
            "Sengkang",
            "Yishun"});
            this.outletComboBox.Location = new System.Drawing.Point(636, 416);
            this.outletComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.outletComboBox.Name = "outletComboBox";
            this.outletComboBox.Size = new System.Drawing.Size(160, 24);
            this.outletComboBox.Sorted = true;
            this.outletComboBox.TabIndex = 23;
            this.toolTip1.SetToolTip(this.outletComboBox, "Please select one");
            this.outletComboBox.SelectedIndexChanged += new System.EventHandler(this.outletComboBox_SelectedIndexChanged);
            // 
            // companylogoLabel
            // 
            this.companylogoLabel.Image = global::Goldfish_Corporation_Bicycle_Order_Application.Properties.Resources.fish;
            this.companylogoLabel.Location = new System.Drawing.Point(505, 18);
            this.companylogoLabel.Margin = new System.Windows.Forms.Padding(4);
            this.companylogoLabel.Name = "companylogoLabel";
            this.companylogoLabel.Size = new System.Drawing.Size(68, 53);
            this.companylogoLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.companylogoLabel.TabIndex = 26;
            this.companylogoLabel.TabStop = false;
            // 
            // companynameLabel
            // 
            this.companynameLabel.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companynameLabel.ForeColor = System.Drawing.Color.Orange;
            this.companynameLabel.Location = new System.Drawing.Point(34, 18);
            this.companynameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.companynameLabel.Name = "companynameLabel";
            this.companynameLabel.Size = new System.Drawing.Size(477, 63);
            this.companynameLabel.TabIndex = 25;
            this.companynameLabel.Text = "Goldfish Corporation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 33);
            this.label3.TabIndex = 24;
            this.label3.Text = "Featured Products";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Size = new System.Drawing.Size(919, 715);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            // 
            // reservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 697);
            this.Controls.Add(this.companylogoLabel);
            this.Controls.Add(this.companynameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outletComboBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contactNumberMaskedTextBox);
            this.Controls.Add(this.timeMaskedTextBox);
            this.Controls.Add(this.dateMaskedTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Ghg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "reservationForm";
            this.Text = "Reservation Form";
            this.Load += new System.EventHandler(this.reservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companylogoLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Ghg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.MaskedTextBox dateMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox timeMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox contactNumberMaskedTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox outletComboBox;
        private System.Windows.Forms.PictureBox companylogoLabel;
        private System.Windows.Forms.Label companynameLabel;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}