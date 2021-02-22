namespace PortfolioApp
{
    partial class PortfolioPresentation
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
            this.clickButtonFetchPort = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCurrentPortfolio = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabQuote = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.textBoxTickerInput = new System.Windows.Forms.TextBox();
            this.labelQuoteAssetType = new System.Windows.Forms.Label();
            this.labelQuoteDescription = new System.Windows.Forms.Label();
            this.labelLastPrice = new System.Windows.Forms.Label();
            this.buttonGetQuote = new System.Windows.Forms.Button();
            this.tabPortfolioChanges = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonFetchTransactions = new System.Windows.Forms.Button();
            this.dataGridViewTransactions = new System.Windows.Forms.DataGridView();
            this.textBoxTradeTicker = new System.Windows.Forms.TextBox();
            this.comboBoxBuySell = new System.Windows.Forms.ComboBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.buttonTradeSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabCurrentPortfolio.SuspendLayout();
            this.tabQuote.SuspendLayout();
            this.tabPortfolioChanges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // clickButtonFetchPort
            // 
            this.clickButtonFetchPort.Location = new System.Drawing.Point(416, 137);
            this.clickButtonFetchPort.Name = "clickButtonFetchPort";
            this.clickButtonFetchPort.Size = new System.Drawing.Size(485, 51);
            this.clickButtonFetchPort.TabIndex = 0;
            this.clickButtonFetchPort.Text = "Fetch Portfolio";
            this.clickButtonFetchPort.UseVisualStyleBackColor = true;
            this.clickButtonFetchPort.Click += new System.EventHandler(this.clickButtonFetchPort_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(104, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1171, 557);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCurrentPortfolio);
            this.tabControl1.Controls.Add(this.tabQuote);
            this.tabControl1.Controls.Add(this.tabPortfolioChanges);
            this.tabControl1.Location = new System.Drawing.Point(12, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1390, 868);
            this.tabControl1.TabIndex = 2;
            // 
            // tabCurrentPortfolio
            // 
            this.tabCurrentPortfolio.BackColor = System.Drawing.Color.LightGreen;
            this.tabCurrentPortfolio.Controls.Add(this.label1);
            this.tabCurrentPortfolio.Controls.Add(this.dataGridView1);
            this.tabCurrentPortfolio.Controls.Add(this.clickButtonFetchPort);
            this.tabCurrentPortfolio.Location = new System.Drawing.Point(4, 33);
            this.tabCurrentPortfolio.Name = "tabCurrentPortfolio";
            this.tabCurrentPortfolio.Padding = new System.Windows.Forms.Padding(3);
            this.tabCurrentPortfolio.Size = new System.Drawing.Size(1382, 831);
            this.tabCurrentPortfolio.TabIndex = 0;
            this.tabCurrentPortfolio.Text = "Current Portfolio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Holdings";
            // 
            // tabQuote
            // 
            this.tabQuote.BackColor = System.Drawing.Color.LightGreen;
            this.tabQuote.Controls.Add(this.label7);
            this.tabQuote.Controls.Add(this.label6);
            this.tabQuote.Controls.Add(this.label5);
            this.tabQuote.Controls.Add(this.label4);
            this.tabQuote.Controls.Add(this.label3);
            this.tabQuote.Controls.Add(this.label2);
            this.tabQuote.Controls.Add(this.labelVolume);
            this.tabQuote.Controls.Add(this.textBoxTickerInput);
            this.tabQuote.Controls.Add(this.labelQuoteAssetType);
            this.tabQuote.Controls.Add(this.labelQuoteDescription);
            this.tabQuote.Controls.Add(this.labelLastPrice);
            this.tabQuote.Controls.Add(this.buttonGetQuote);
            this.tabQuote.Location = new System.Drawing.Point(4, 33);
            this.tabQuote.Name = "tabQuote";
            this.tabQuote.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuote.Size = new System.Drawing.Size(1382, 831);
            this.tabQuote.TabIndex = 1;
            this.tabQuote.Text = "Get Quote Info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(671, 528);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "Volume:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(671, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Last Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(671, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Asset Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(671, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 54);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stock Quote";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Ticker";
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolume.Location = new System.Drawing.Point(865, 528);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(0, 32);
            this.labelVolume.TabIndex = 5;
            // 
            // textBoxTickerInput
            // 
            this.textBoxTickerInput.Location = new System.Drawing.Point(336, 240);
            this.textBoxTickerInput.Name = "textBoxTickerInput";
            this.textBoxTickerInput.Size = new System.Drawing.Size(218, 29);
            this.textBoxTickerInput.TabIndex = 4;
            // 
            // labelQuoteAssetType
            // 
            this.labelQuoteAssetType.AutoSize = true;
            this.labelQuoteAssetType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuoteAssetType.Location = new System.Drawing.Point(865, 291);
            this.labelQuoteAssetType.Name = "labelQuoteAssetType";
            this.labelQuoteAssetType.Size = new System.Drawing.Size(0, 32);
            this.labelQuoteAssetType.TabIndex = 3;
            // 
            // labelQuoteDescription
            // 
            this.labelQuoteDescription.AutoSize = true;
            this.labelQuoteDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuoteDescription.Location = new System.Drawing.Point(868, 184);
            this.labelQuoteDescription.Name = "labelQuoteDescription";
            this.labelQuoteDescription.Size = new System.Drawing.Size(0, 25);
            this.labelQuoteDescription.TabIndex = 2;
            // 
            // labelLastPrice
            // 
            this.labelLastPrice.AutoSize = true;
            this.labelLastPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastPrice.Location = new System.Drawing.Point(865, 416);
            this.labelLastPrice.Name = "labelLastPrice";
            this.labelLastPrice.Size = new System.Drawing.Size(0, 32);
            this.labelLastPrice.TabIndex = 1;
            // 
            // buttonGetQuote
            // 
            this.buttonGetQuote.Location = new System.Drawing.Point(207, 361);
            this.buttonGetQuote.Name = "buttonGetQuote";
            this.buttonGetQuote.Size = new System.Drawing.Size(214, 139);
            this.buttonGetQuote.TabIndex = 0;
            this.buttonGetQuote.Text = "Get Quote";
            this.buttonGetQuote.UseVisualStyleBackColor = true;
            this.buttonGetQuote.Click += new System.EventHandler(this.buttonGetQuote_Click);
            // 
            // tabPortfolioChanges
            // 
            this.tabPortfolioChanges.BackColor = System.Drawing.Color.LightGreen;
            this.tabPortfolioChanges.Controls.Add(this.label11);
            this.tabPortfolioChanges.Controls.Add(this.label10);
            this.tabPortfolioChanges.Controls.Add(this.label9);
            this.tabPortfolioChanges.Controls.Add(this.label8);
            this.tabPortfolioChanges.Controls.Add(this.buttonFetchTransactions);
            this.tabPortfolioChanges.Controls.Add(this.dataGridViewTransactions);
            this.tabPortfolioChanges.Controls.Add(this.textBoxTradeTicker);
            this.tabPortfolioChanges.Controls.Add(this.comboBoxBuySell);
            this.tabPortfolioChanges.Controls.Add(this.textBoxQuantity);
            this.tabPortfolioChanges.Controls.Add(this.buttonTradeSubmit);
            this.tabPortfolioChanges.Location = new System.Drawing.Point(4, 33);
            this.tabPortfolioChanges.Name = "tabPortfolioChanges";
            this.tabPortfolioChanges.Padding = new System.Windows.Forms.Padding(3);
            this.tabPortfolioChanges.Size = new System.Drawing.Size(1382, 831);
            this.tabPortfolioChanges.TabIndex = 2;
            this.tabPortfolioChanges.Text = "Portfolio Transactions ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 21.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(46, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(738, 59);
            this.label11.TabIndex = 9;
            this.label11.Text = "Trade and Search Trades";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(677, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(246, 39);
            this.label10.TabIndex = 8;
            this.label10.Text = "Share Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(425, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 39);
            this.label9.TabIndex = 7;
            this.label9.Text = "Ticker";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(103, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 39);
            this.label8.TabIndex = 6;
            this.label8.Text = "Action";
            // 
            // buttonFetchTransactions
            // 
            this.buttonFetchTransactions.Location = new System.Drawing.Point(539, 346);
            this.buttonFetchTransactions.Name = "buttonFetchTransactions";
            this.buttonFetchTransactions.Size = new System.Drawing.Size(245, 59);
            this.buttonFetchTransactions.TabIndex = 5;
            this.buttonFetchTransactions.Text = "Fetch Transactions";
            this.buttonFetchTransactions.UseVisualStyleBackColor = true;
            this.buttonFetchTransactions.Click += new System.EventHandler(this.buttonFetchTransactions_Click);
            // 
            // dataGridViewTransactions
            // 
            this.dataGridViewTransactions.AllowUserToAddRows = false;
            this.dataGridViewTransactions.AllowUserToDeleteRows = false;
            this.dataGridViewTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactions.Location = new System.Drawing.Point(64, 465);
            this.dataGridViewTransactions.Name = "dataGridViewTransactions";
            this.dataGridViewTransactions.ReadOnly = true;
            this.dataGridViewTransactions.RowHeadersWidth = 72;
            this.dataGridViewTransactions.RowTemplate.Height = 31;
            this.dataGridViewTransactions.Size = new System.Drawing.Size(1228, 301);
            this.dataGridViewTransactions.TabIndex = 4;
            // 
            // textBoxTradeTicker
            // 
            this.textBoxTradeTicker.Location = new System.Drawing.Point(434, 205);
            this.textBoxTradeTicker.Name = "textBoxTradeTicker";
            this.textBoxTradeTicker.Size = new System.Drawing.Size(100, 29);
            this.textBoxTradeTicker.TabIndex = 3;
            // 
            // comboBoxBuySell
            // 
            this.comboBoxBuySell.FormattingEnabled = true;
            this.comboBoxBuySell.Items.AddRange(new object[] {
            "BUY",
            "SELL"});
            this.comboBoxBuySell.Location = new System.Drawing.Point(110, 205);
            this.comboBoxBuySell.Name = "comboBoxBuySell";
            this.comboBoxBuySell.Size = new System.Drawing.Size(210, 32);
            this.comboBoxBuySell.TabIndex = 2;
            this.comboBoxBuySell.Text = "Choose Action";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(684, 205);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 29);
            this.textBoxQuantity.TabIndex = 1;
            this.textBoxQuantity.Text = "0";
            // 
            // buttonTradeSubmit
            // 
            this.buttonTradeSubmit.Location = new System.Drawing.Point(989, 178);
            this.buttonTradeSubmit.Name = "buttonTradeSubmit";
            this.buttonTradeSubmit.Size = new System.Drawing.Size(294, 84);
            this.buttonTradeSubmit.TabIndex = 0;
            this.buttonTradeSubmit.Text = "Submit Trade";
            this.buttonTradeSubmit.UseVisualStyleBackColor = true;
            this.buttonTradeSubmit.Click += new System.EventHandler(this.buttonTradeSubmit_Click);
            // 
            // PortfolioPresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1437, 931);
            this.Controls.Add(this.tabControl1);
            this.Name = "PortfolioPresentation";
            this.Text = "Tracking Portfolio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabCurrentPortfolio.ResumeLayout(false);
            this.tabCurrentPortfolio.PerformLayout();
            this.tabQuote.ResumeLayout(false);
            this.tabQuote.PerformLayout();
            this.tabPortfolioChanges.ResumeLayout(false);
            this.tabPortfolioChanges.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clickButtonFetchPort;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCurrentPortfolio;
        private System.Windows.Forms.TabPage tabQuote;
        private System.Windows.Forms.TabPage tabPortfolioChanges;
        private System.Windows.Forms.Button buttonTradeSubmit;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.ComboBox comboBoxBuySell;
        private System.Windows.Forms.TextBox textBoxTradeTicker;
        private System.Windows.Forms.DataGridView dataGridViewTransactions;
        private System.Windows.Forms.Button buttonFetchTransactions;
        private System.Windows.Forms.Label labelQuoteAssetType;
        private System.Windows.Forms.Label labelQuoteDescription;
        private System.Windows.Forms.Label labelLastPrice;
        private System.Windows.Forms.Button buttonGetQuote;
        private System.Windows.Forms.TextBox textBoxTickerInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

