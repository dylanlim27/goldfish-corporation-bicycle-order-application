
namespace Goldfish_Corporation_Bicycle_Order_Application
{
    partial class selfCollectionForm
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
            this.companynameLabel = new System.Windows.Forms.Label();
            this.contactNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Ghg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.outletComboBox = new System.Windows.Forms.ComboBox();
            this.companylogoLabel = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.companylogoLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // companynameLabel
            // 
            this.companynameLabel.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companynameLabel.ForeColor = System.Drawing.Color.Orange;
            this.companynameLabel.Location = new System.Drawing.Point(23, 28);
            this.companynameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.companynameLabel.Name = "companynameLabel";
            this.companynameLabel.Size = new System.Drawing.Size(477, 63);
            this.companynameLabel.TabIndex = 22;
            this.companynameLabel.Text = "Goldfish Corporation";
            this.companynameLabel.Click += new System.EventHandler(this.companynameLabel_Click);
            // 
            // contactNumberMaskedTextBox
            // 
            this.contactNumberMaskedTextBox.Location = new System.Drawing.Point(456, 304);
            this.contactNumberMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.contactNumberMaskedTextBox.Mask = "00000000";
            this.contactNumberMaskedTextBox.Name = "contactNumberMaskedTextBox";
            this.contactNumberMaskedTextBox.Size = new System.Drawing.Size(160, 22);
            this.contactNumberMaskedTextBox.TabIndex = 2;
            this.contactNumberMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.contactNumberMaskedTextBox_MaskInputRejected);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(456, 250);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(160, 22);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.label7.Location = new System.Drawing.Point(221, 356);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 29);
            this.label7.TabIndex = 27;
            this.label7.Text = "&Outlet Location:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Ghg
            // 
            this.Ghg.AutoSize = true;
            this.Ghg.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.Ghg.Location = new System.Drawing.Point(221, 301);
            this.Ghg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ghg.Name = "Ghg";
            this.Ghg.Size = new System.Drawing.Size(143, 29);
            this.Ghg.TabIndex = 31;
            this.Ghg.Text = "C&ontact Number:";
            this.Ghg.Click += new System.EventHandler(this.Ghg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.label2.Location = new System.Drawing.Point(221, 247);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "&Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F);
            this.label1.Location = new System.Drawing.Point(289, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 41);
            this.label1.TabIndex = 39;
            this.label1.Text = "Self-Collection";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(200, 462);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(224, 71);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "&Continue to Payment";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(494, 462);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(152, 71);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "B&ack";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // outletComboBox
            // 
            this.outletComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outletComboBox.Items.AddRange(new object[] {
            "HarbourFront",
            "Orchard",
            "Sengkang",
            "Yishun"});
            this.outletComboBox.Location = new System.Drawing.Point(458, 358);
            this.outletComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.outletComboBox.Name = "outletComboBox";
            this.outletComboBox.Size = new System.Drawing.Size(160, 24);
            this.outletComboBox.Sorted = true;
            this.outletComboBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.outletComboBox, "Please select one");
            this.outletComboBox.SelectedIndexChanged += new System.EventHandler(this.outletComboBox_SelectedIndexChanged);
            // 
            // companylogoLabel
            // 
            this.companylogoLabel.Image = global::Goldfish_Corporation_Bicycle_Order_Application.Properties.Resources.fish;
            this.companylogoLabel.Location = new System.Drawing.Point(494, 28);
            this.companylogoLabel.Margin = new System.Windows.Forms.Padding(4);
            this.companylogoLabel.Name = "companylogoLabel";
            this.companylogoLabel.Size = new System.Drawing.Size(68, 53);
            this.companylogoLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.companylogoLabel.TabIndex = 23;
            this.companylogoLabel.TabStop = false;
            this.companylogoLabel.Click += new System.EventHandler(this.companylogoLabel_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 3000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            // 
            // selfCollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 767);
            this.Controls.Add(this.outletComboBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contactNumberMaskedTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Ghg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.companylogoLabel);
            this.Controls.Add(this.companynameLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "selfCollectionForm";
            this.Text = "Self-Collection Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companylogoLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox companylogoLabel;
        private System.Windows.Forms.Label companynameLabel;
        private System.Windows.Forms.MaskedTextBox contactNumberMaskedTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Ghg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox outletComboBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}