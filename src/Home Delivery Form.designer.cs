
namespace Goldfish_Corporation_Bicycle_Order_Application
{
    partial class homeDeliveryForm
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
            this.companynameLabel = new System.Windows.Forms.Label();
            this.contactNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.postalMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Ghg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.companylogoLabel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.companylogoLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // companynameLabel
            // 
            this.companynameLabel.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companynameLabel.ForeColor = System.Drawing.Color.Orange;
            this.companynameLabel.Location = new System.Drawing.Point(16, 54);
            this.companynameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.companynameLabel.Name = "companynameLabel";
            this.companynameLabel.Size = new System.Drawing.Size(477, 63);
            this.companynameLabel.TabIndex = 24;
            this.companynameLabel.Text = "Goldfish Corporation";
            // 
            // contactNumberMaskedTextBox
            // 
            this.contactNumberMaskedTextBox.Location = new System.Drawing.Point(598, 305);
            this.contactNumberMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.contactNumberMaskedTextBox.Mask = "00000000";
            this.contactNumberMaskedTextBox.Name = "contactNumberMaskedTextBox";
            this.contactNumberMaskedTextBox.Size = new System.Drawing.Size(163, 22);
            this.contactNumberMaskedTextBox.TabIndex = 2;
            // 
            // postalMaskedTextBox
            // 
            this.postalMaskedTextBox.Location = new System.Drawing.Point(598, 418);
            this.postalMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.postalMaskedTextBox.Mask = "000000";
            this.postalMaskedTextBox.Name = "postalMaskedTextBox";
            this.postalMaskedTextBox.Size = new System.Drawing.Size(163, 22);
            this.postalMaskedTextBox.TabIndex = 4;
            this.postalMaskedTextBox.ValidatingType = typeof(int);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(598, 249);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(163, 22);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F);
            this.label6.Location = new System.Drawing.Point(342, 418);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 33);
            this.label6.TabIndex = 40;
            this.label6.Text = "&Postal Code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F);
            this.label5.Location = new System.Drawing.Point(342, 362);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 33);
            this.label5.TabIndex = 41;
            this.label5.Text = "&Address:";
            // 
            // Ghg
            // 
            this.Ghg.AutoSize = true;
            this.Ghg.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F);
            this.Ghg.Location = new System.Drawing.Point(342, 305);
            this.Ghg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ghg.Name = "Ghg";
            this.Ghg.Size = new System.Drawing.Size(160, 33);
            this.Ghg.TabIndex = 42;
            this.Ghg.Text = "C&ontact Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F);
            this.label2.Location = new System.Drawing.Point(342, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 33);
            this.label2.TabIndex = 43;
            this.label2.Text = "&Name:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(598, 362);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(163, 22);
            this.addressTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F);
            this.label1.Location = new System.Drawing.Point(431, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 48);
            this.label1.TabIndex = 50;
            this.label1.Text = "Home Delivery";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(608, 517);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(163, 80);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "B&ack";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(329, 517);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(207, 80);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "&Continue to Payment";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // companylogoLabel
            // 
            this.companylogoLabel.Image = global::Goldfish_Corporation_Bicycle_Order_Application.Properties.Resources.fish;
            this.companylogoLabel.Location = new System.Drawing.Point(487, 54);
            this.companylogoLabel.Margin = new System.Windows.Forms.Padding(4);
            this.companylogoLabel.Name = "companylogoLabel";
            this.companylogoLabel.Size = new System.Drawing.Size(68, 53);
            this.companylogoLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.companylogoLabel.TabIndex = 25;
            this.companylogoLabel.TabStop = false;
            // 
            // homeDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 727);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.contactNumberMaskedTextBox);
            this.Controls.Add(this.postalMaskedTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Ghg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.companylogoLabel);
            this.Controls.Add(this.companynameLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "homeDeliveryForm";
            this.Text = "Home Delivery Form";
            this.Load += new System.EventHandler(this.homeDeliveryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companylogoLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox companylogoLabel;
        private System.Windows.Forms.Label companynameLabel;
        private System.Windows.Forms.MaskedTextBox contactNumberMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox postalMaskedTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Ghg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button nextButton;
    }
}