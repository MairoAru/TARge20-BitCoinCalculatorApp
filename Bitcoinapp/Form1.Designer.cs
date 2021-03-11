namespace Bitcoinapp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currencyCombo = new System.Windows.Forms.ComboBox();
            this.BtnGetRates = new System.Windows.Forms.Button();
            this.amountOfCoinBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.ResulttextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // currencyCombo
            // 
            this.currencyCombo.FormattingEnabled = true;
            this.currencyCombo.Items.AddRange(new object[] {
            "EUR",
            "USD"});
            this.currencyCombo.Location = new System.Drawing.Point(85, 353);
            this.currencyCombo.Name = "currencyCombo";
            this.currencyCombo.Size = new System.Drawing.Size(162, 24);
            this.currencyCombo.TabIndex = 0;
            this.currencyCombo.Text = "Select Currency";
            // 
            // BtnGetRates
            // 
            this.BtnGetRates.Location = new System.Drawing.Point(259, 405);
            this.BtnGetRates.Name = "BtnGetRates";
            this.BtnGetRates.Size = new System.Drawing.Size(75, 23);
            this.BtnGetRates.TabIndex = 1;
            this.BtnGetRates.Text = "Get Rates";
            this.BtnGetRates.UseVisualStyleBackColor = true;
            this.BtnGetRates.Click += new System.EventHandler(this.BtnGetRates_Click);
            // 
            // amountOfCoinBox
            // 
            this.amountOfCoinBox.Location = new System.Drawing.Point(85, 449);
            this.amountOfCoinBox.Name = "amountOfCoinBox";
            this.amountOfCoinBox.Size = new System.Drawing.Size(100, 22);
            this.amountOfCoinBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(82, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount of BitCoins";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultLabel.Location = new System.Drawing.Point(333, 449);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(48, 17);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Result";
            this.resultLabel.Visible = false;
            // 
            // ResulttextBox
            // 
            this.ResulttextBox.Location = new System.Drawing.Point(421, 449);
            this.ResulttextBox.Name = "ResulttextBox";
            this.ResulttextBox.Size = new System.Drawing.Size(201, 22);
            this.ResulttextBox.TabIndex = 5;
            this.ResulttextBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(809, 577);
            this.Controls.Add(this.ResulttextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountOfCoinBox);
            this.Controls.Add(this.BtnGetRates);
            this.Controls.Add(this.currencyCombo);
            this.Name = "Form1";
            this.Text = "BitCoin Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyCombo;
        private System.Windows.Forms.Button BtnGetRates;
        private System.Windows.Forms.TextBox amountOfCoinBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox ResulttextBox;
    }
}

