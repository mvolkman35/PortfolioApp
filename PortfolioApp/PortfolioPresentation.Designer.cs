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
            this.tabPortfolioChanges = new System.Windows.Forms.TabPage();
            this.buttonTradeSubmit = new System.Windows.Forms.Button();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.comboBoxBuySell = new System.Windows.Forms.ComboBox();
            this.textBoxTradeTicker = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabCurrentPortfolio.SuspendLayout();
            this.tabPortfolioChanges.SuspendLayout();
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
            this.tabQuote.Location = new System.Drawing.Point(4, 33);
            this.tabQuote.Name = "tabQuote";
            this.tabQuote.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuote.Size = new System.Drawing.Size(1382, 831);
            this.tabQuote.TabIndex = 1;
            this.tabQuote.Text = "Get Quote Info";
            this.tabQuote.UseVisualStyleBackColor = true;
            // 
            // tabPortfolioChanges
            // 
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
            // buttonTradeSubmit
            // 
            this.buttonTradeSubmit.Location = new System.Drawing.Point(1053, 367);
            this.buttonTradeSubmit.Name = "buttonTradeSubmit";
            this.buttonTradeSubmit.Size = new System.Drawing.Size(126, 144);
            this.buttonTradeSubmit.TabIndex = 0;
            this.buttonTradeSubmit.Text = "Submit Trade";
            this.buttonTradeSubmit.UseVisualStyleBackColor = true;
            this.buttonTradeSubmit.Click += new System.EventHandler(this.buttonTradeSubmit_Click);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(698, 411);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 29);
            this.textBoxQuantity.TabIndex = 1;
            this.textBoxQuantity.Text = "0";
            // 
            // comboBoxBuySell
            // 
            this.comboBoxBuySell.FormattingEnabled = true;
            this.comboBoxBuySell.Items.AddRange(new object[] {
            "BUY",
            "SELL"});
            this.comboBoxBuySell.Location = new System.Drawing.Point(102, 408);
            this.comboBoxBuySell.Name = "comboBoxBuySell";
            this.comboBoxBuySell.Size = new System.Drawing.Size(210, 32);
            this.comboBoxBuySell.TabIndex = 2;
            this.comboBoxBuySell.Text = "Choose Action";
            // 
            // textBoxTradeTicker
            // 
            this.textBoxTradeTicker.Location = new System.Drawing.Point(437, 408);
            this.textBoxTradeTicker.Name = "textBoxTradeTicker";
            this.textBoxTradeTicker.Size = new System.Drawing.Size(100, 29);
            this.textBoxTradeTicker.TabIndex = 3;
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
            this.tabPortfolioChanges.ResumeLayout(false);
            this.tabPortfolioChanges.PerformLayout();
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
    }
}

