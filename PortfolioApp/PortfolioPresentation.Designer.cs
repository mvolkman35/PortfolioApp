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
            this.tabQuote = new System.Windows.Forms.TabPage();
            this.labelQuoteAssetType = new System.Windows.Forms.Label();
            this.labelQuoteDescription = new System.Windows.Forms.Label();
            this.labelLastPrice = new System.Windows.Forms.Label();
            this.buttonGetQuote = new System.Windows.Forms.Button();
            this.tabPortfolioChanges = new System.Windows.Forms.TabPage();
            this.buttonFetchTransactions = new System.Windows.Forms.Button();
            this.dataGridViewTransactions = new System.Windows.Forms.DataGridView();
            this.textBoxTradeTicker = new System.Windows.Forms.TextBox();
            this.comboBoxBuySell = new System.Windows.Forms.ComboBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.buttonTradeSubmit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelVolume = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.clickButtonFetchPort.Location = new System.Drawing.Point(401, 80);
            this.clickButtonFetchPort.Name = "clickButtonFetchPort";
            this.clickButtonFetchPort.Size = new System.Drawing.Size(127, 58);
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
            this.dataGridView1.Size = new System.Drawing.Size(790, 478);
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
            this.tabCurrentPortfolio.Controls.Add(this.dataGridView1);
            this.tabCurrentPortfolio.Controls.Add(this.clickButtonFetchPort);
            this.tabCurrentPortfolio.Location = new System.Drawing.Point(4, 33);
            this.tabCurrentPortfolio.Name = "tabCurrentPortfolio";
            this.tabCurrentPortfolio.Padding = new System.Windows.Forms.Padding(3);
            this.tabCurrentPortfolio.Size = new System.Drawing.Size(1382, 831);
            this.tabCurrentPortfolio.TabIndex = 0;
            this.tabCurrentPortfolio.Text = "Current Portfolio";
            this.tabCurrentPortfolio.UseVisualStyleBackColor = true;
            // 
            // tabQuote
            // 
            this.tabQuote.Controls.Add(this.label2);
            this.tabQuote.Controls.Add(this.labelVolume);
            this.tabQuote.Controls.Add(this.textBox1);
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
            this.tabQuote.UseVisualStyleBackColor = true;
            // 
            // labelQuoteAssetType
            // 
            this.labelQuoteAssetType.AutoSize = true;
            this.labelQuoteAssetType.Location = new System.Drawing.Point(751, 358);
            this.labelQuoteAssetType.Name = "labelQuoteAssetType";
            this.labelQuoteAssetType.Size = new System.Drawing.Size(112, 25);
            this.labelQuoteAssetType.TabIndex = 3;
            this.labelQuoteAssetType.Text = "Asset Type";
            // 
            // labelQuoteDescription
            // 
            this.labelQuoteDescription.AutoSize = true;
            this.labelQuoteDescription.Location = new System.Drawing.Point(746, 291);
            this.labelQuoteDescription.Name = "labelQuoteDescription";
            this.labelQuoteDescription.Size = new System.Drawing.Size(109, 25);
            this.labelQuoteDescription.TabIndex = 2;
            this.labelQuoteDescription.Text = "Description";
            // 
            // labelLastPrice
            // 
            this.labelLastPrice.AutoSize = true;
            this.labelLastPrice.Location = new System.Drawing.Point(746, 225);
            this.labelLastPrice.Name = "labelLastPrice";
            this.labelLastPrice.Size = new System.Drawing.Size(98, 25);
            this.labelLastPrice.TabIndex = 1;
            this.labelLastPrice.Text = "Last Price";
            // 
            // buttonGetQuote
            // 
            this.buttonGetQuote.Location = new System.Drawing.Point(191, 256);
            this.buttonGetQuote.Name = "buttonGetQuote";
            this.buttonGetQuote.Size = new System.Drawing.Size(177, 117);
            this.buttonGetQuote.TabIndex = 0;
            this.buttonGetQuote.Text = "Get Quote";
            this.buttonGetQuote.UseVisualStyleBackColor = true;
            this.buttonGetQuote.Click += new System.EventHandler(this.buttonGetQuote_Click);
            // 
            // tabPortfolioChanges
            // 
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
            this.tabPortfolioChanges.UseVisualStyleBackColor = true;
            // 
            // buttonFetchTransactions
            // 
            this.buttonFetchTransactions.Location = new System.Drawing.Point(108, 384);
            this.buttonFetchTransactions.Name = "buttonFetchTransactions";
            this.buttonFetchTransactions.Size = new System.Drawing.Size(142, 59);
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
            this.textBoxTradeTicker.Location = new System.Drawing.Point(400, 190);
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
            this.comboBoxBuySell.Location = new System.Drawing.Point(108, 187);
            this.comboBoxBuySell.Name = "comboBoxBuySell";
            this.comboBoxBuySell.Size = new System.Drawing.Size(210, 32);
            this.comboBoxBuySell.TabIndex = 2;
            this.comboBoxBuySell.Text = "Choose Action";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(659, 190);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 29);
            this.textBoxQuantity.TabIndex = 1;
            this.textBoxQuantity.Text = "0";
            // 
            // buttonTradeSubmit
            // 
            this.buttonTradeSubmit.Location = new System.Drawing.Point(946, 150);
            this.buttonTradeSubmit.Name = "buttonTradeSubmit";
            this.buttonTradeSubmit.Size = new System.Drawing.Size(126, 144);
            this.buttonTradeSubmit.TabIndex = 0;
            this.buttonTradeSubmit.Text = "Submit Trade";
            this.buttonTradeSubmit.UseVisualStyleBackColor = true;
            this.buttonTradeSubmit.Click += new System.EventHandler(this.buttonTradeSubmit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 4;
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(756, 421);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(79, 25);
            this.labelVolume.TabIndex = 5;
            this.labelVolume.Text = "Volume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Ticker";
            // 
            // PortfolioPresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 1005);
            this.Controls.Add(this.tabControl1);
            this.Name = "PortfolioPresentation";
            this.Text = "Current Portfolio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabCurrentPortfolio.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelVolume;
    }
}

