namespace CriptoStock
{
    partial class StockForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GroupBox groupBox1;
            GroupBox groupBox2;
            GroupBox groupBox3;
            GroupBox groupBox4;
            bybitStockCurrency = new Label();
            bybitStockSymbol = new Label();
            bybitStockDown = new Label();
            bybitStockUp = new Label();
            binanceStockCurrency = new Label();
            binanceStockDown = new Label();
            binanceStockUp = new Label();
            label3 = new Label();
            binanceStockSymbol = new Label();
            bitGetStockCurrency = new Label();
            bitGetStockDown = new Label();
            bitGetStockUp = new Label();
            label5 = new Label();
            bitGetStockSymbol = new Label();
            kucoinStockCurrency = new Label();
            kucoinStockSymbol = new Label();
            kucoinStockDown = new Label();
            kucoinStockUp = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.RoyalBlue;
            groupBox1.Controls.Add(bybitStockCurrency);
            groupBox1.Controls.Add(bybitStockSymbol);
            groupBox1.Controls.Add(bybitStockDown);
            groupBox1.Controls.Add(bybitStockUp);
            groupBox1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(12, 203);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(326, 144);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bybit";
            // 
            // bybitStockCurrency
            // 
            bybitStockCurrency.AutoSize = true;
            bybitStockCurrency.BackColor = Color.Transparent;
            bybitStockCurrency.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            bybitStockCurrency.ForeColor = SystemColors.ControlLightLight;
            bybitStockCurrency.Location = new Point(232, 43);
            bybitStockCurrency.Name = "bybitStockCurrency";
            bybitStockCurrency.Size = new Size(39, 46);
            bybitStockCurrency.TabIndex = 4;
            bybitStockCurrency.Text = "0";
            // 
            // bybitStockSymbol
            // 
            bybitStockSymbol.AutoSize = true;
            bybitStockSymbol.BackColor = Color.Transparent;
            bybitStockSymbol.Dock = DockStyle.Left;
            bybitStockSymbol.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            bybitStockSymbol.ForeColor = SystemColors.ControlLightLight;
            bybitStockSymbol.Location = new Point(3, 43);
            bybitStockSymbol.Name = "bybitStockSymbol";
            bybitStockSymbol.Size = new Size(115, 46);
            bybitStockSymbol.TabIndex = 3;
            bybitStockSymbol.Text = "Wait...";
            // 
            // bybitStockDown
            // 
            bybitStockDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bybitStockDown.AutoSize = true;
            bybitStockDown.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            bybitStockDown.ForeColor = Color.Red;
            bybitStockDown.Location = new Point(201, 75);
            bybitStockDown.Name = "bybitStockDown";
            bybitStockDown.Size = new Size(25, 23);
            bybitStockDown.TabIndex = 2;
            bybitStockDown.Text = "▼";
            // 
            // bybitStockUp
            // 
            bybitStockUp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bybitStockUp.AutoSize = true;
            bybitStockUp.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            bybitStockUp.ForeColor = Color.Lime;
            bybitStockUp.Location = new Point(201, 45);
            bybitStockUp.Name = "bybitStockUp";
            bybitStockUp.Size = new Size(25, 23);
            bybitStockUp.TabIndex = 1;
            bybitStockUp.Text = "▲";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.RoyalBlue;
            groupBox2.Controls.Add(binanceStockCurrency);
            groupBox2.Controls.Add(binanceStockDown);
            groupBox2.Controls.Add(binanceStockUp);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(binanceStockSymbol);
            groupBox2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(326, 144);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Binance";
            // 
            // binanceStockCurrency
            // 
            binanceStockCurrency.AutoSize = true;
            binanceStockCurrency.BackColor = Color.Transparent;
            binanceStockCurrency.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            binanceStockCurrency.ForeColor = SystemColors.ControlLightLight;
            binanceStockCurrency.Location = new Point(232, 43);
            binanceStockCurrency.Name = "binanceStockCurrency";
            binanceStockCurrency.Size = new Size(39, 46);
            binanceStockCurrency.TabIndex = 2;
            binanceStockCurrency.Text = "0";
            // 
            // binanceStockDown
            // 
            binanceStockDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            binanceStockDown.AutoSize = true;
            binanceStockDown.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            binanceStockDown.ForeColor = Color.Red;
            binanceStockDown.Location = new Point(201, 75);
            binanceStockDown.Name = "binanceStockDown";
            binanceStockDown.Size = new Size(25, 23);
            binanceStockDown.TabIndex = 3;
            binanceStockDown.Text = "▼";
            // 
            // binanceStockUp
            // 
            binanceStockUp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            binanceStockUp.AutoSize = true;
            binanceStockUp.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            binanceStockUp.ForeColor = Color.Lime;
            binanceStockUp.Location = new Point(201, 45);
            binanceStockUp.Name = "binanceStockUp";
            binanceStockUp.Size = new Size(25, 23);
            binanceStockUp.TabIndex = 2;
            binanceStockUp.Text = "▲";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(-509, 64);
            label3.Name = "label3";
            label3.Size = new Size(0, 31);
            label3.TabIndex = 1;
            // 
            // binanceStockSymbol
            // 
            binanceStockSymbol.AutoSize = true;
            binanceStockSymbol.BackColor = Color.Transparent;
            binanceStockSymbol.Dock = DockStyle.Left;
            binanceStockSymbol.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            binanceStockSymbol.ForeColor = SystemColors.ControlLightLight;
            binanceStockSymbol.Location = new Point(3, 43);
            binanceStockSymbol.Name = "binanceStockSymbol";
            binanceStockSymbol.Size = new Size(115, 46);
            binanceStockSymbol.TabIndex = 0;
            binanceStockSymbol.Text = "Wait...";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.RoyalBlue;
            groupBox3.Controls.Add(bitGetStockCurrency);
            groupBox3.Controls.Add(bitGetStockDown);
            groupBox3.Controls.Add(bitGetStockUp);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(bitGetStockSymbol);
            groupBox3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.ForeColor = SystemColors.ControlLightLight;
            groupBox3.Location = new Point(397, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(326, 144);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "BitGet";
            // 
            // bitGetStockCurrency
            // 
            bitGetStockCurrency.AutoSize = true;
            bitGetStockCurrency.BackColor = Color.Transparent;
            bitGetStockCurrency.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            bitGetStockCurrency.ForeColor = SystemColors.ControlLightLight;
            bitGetStockCurrency.Location = new Point(232, 43);
            bitGetStockCurrency.Name = "bitGetStockCurrency";
            bitGetStockCurrency.Size = new Size(39, 46);
            bitGetStockCurrency.TabIndex = 2;
            bitGetStockCurrency.Text = "0";
            // 
            // bitGetStockDown
            // 
            bitGetStockDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bitGetStockDown.AutoSize = true;
            bitGetStockDown.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            bitGetStockDown.ForeColor = Color.Red;
            bitGetStockDown.Location = new Point(201, 75);
            bitGetStockDown.Name = "bitGetStockDown";
            bitGetStockDown.Size = new Size(25, 23);
            bitGetStockDown.TabIndex = 3;
            bitGetStockDown.Text = "▼";
            // 
            // bitGetStockUp
            // 
            bitGetStockUp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bitGetStockUp.AutoSize = true;
            bitGetStockUp.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            bitGetStockUp.ForeColor = Color.Lime;
            bitGetStockUp.Location = new Point(201, 45);
            bitGetStockUp.Name = "bitGetStockUp";
            bitGetStockUp.Size = new Size(25, 23);
            bitGetStockUp.TabIndex = 2;
            bitGetStockUp.Text = "▲";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(-459, 64);
            label5.Name = "label5";
            label5.Size = new Size(0, 31);
            label5.TabIndex = 1;
            // 
            // bitGetStockSymbol
            // 
            bitGetStockSymbol.AutoSize = true;
            bitGetStockSymbol.BackColor = Color.Transparent;
            bitGetStockSymbol.Dock = DockStyle.Left;
            bitGetStockSymbol.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            bitGetStockSymbol.ForeColor = SystemColors.ControlLightLight;
            bitGetStockSymbol.Location = new Point(3, 43);
            bitGetStockSymbol.Name = "bitGetStockSymbol";
            bitGetStockSymbol.Size = new Size(115, 46);
            bitGetStockSymbol.TabIndex = 0;
            bitGetStockSymbol.Text = "Wait...";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.RoyalBlue;
            groupBox4.Controls.Add(kucoinStockCurrency);
            groupBox4.Controls.Add(kucoinStockSymbol);
            groupBox4.Controls.Add(kucoinStockDown);
            groupBox4.Controls.Add(kucoinStockUp);
            groupBox4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.ForeColor = SystemColors.ControlLightLight;
            groupBox4.Location = new Point(400, 203);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(326, 144);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kucoin";
            // 
            // kucoinStockCurrency
            // 
            kucoinStockCurrency.AutoSize = true;
            kucoinStockCurrency.BackColor = Color.Transparent;
            kucoinStockCurrency.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            kucoinStockCurrency.ForeColor = SystemColors.ControlLightLight;
            kucoinStockCurrency.Location = new Point(232, 43);
            kucoinStockCurrency.Name = "kucoinStockCurrency";
            kucoinStockCurrency.Size = new Size(39, 46);
            kucoinStockCurrency.TabIndex = 4;
            kucoinStockCurrency.Text = "0";
            // 
            // kucoinStockSymbol
            // 
            kucoinStockSymbol.AutoSize = true;
            kucoinStockSymbol.BackColor = Color.Transparent;
            kucoinStockSymbol.Dock = DockStyle.Left;
            kucoinStockSymbol.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            kucoinStockSymbol.ForeColor = SystemColors.ControlLightLight;
            kucoinStockSymbol.Location = new Point(3, 43);
            kucoinStockSymbol.Name = "kucoinStockSymbol";
            kucoinStockSymbol.Size = new Size(115, 46);
            kucoinStockSymbol.TabIndex = 3;
            kucoinStockSymbol.Text = "Wait...";
            // 
            // kucoinStockDown
            // 
            kucoinStockDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kucoinStockDown.AutoSize = true;
            kucoinStockDown.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            kucoinStockDown.ForeColor = Color.Red;
            kucoinStockDown.Location = new Point(201, 75);
            kucoinStockDown.Name = "kucoinStockDown";
            kucoinStockDown.Size = new Size(25, 23);
            kucoinStockDown.TabIndex = 2;
            kucoinStockDown.Text = "▼";
            // 
            // kucoinStockUp
            // 
            kucoinStockUp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kucoinStockUp.AutoSize = true;
            kucoinStockUp.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            kucoinStockUp.ForeColor = Color.Lime;
            kucoinStockUp.Location = new Point(201, 45);
            kucoinStockUp.Name = "kucoinStockUp";
            kucoinStockUp.Size = new Size(25, 23);
            kucoinStockUp.TabIndex = 1;
            kucoinStockUp.Text = "▲";
            // 
            // StockForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 453);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "StockForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label bybitStockUp;
        private Label bybitStockDown;
        private Label binanceStockDown;
        private Label binanceStockUp;
        private Label label3;
        private Label bybitStockCurrency;
        private Label bybitStockSymbol;
        private Label binanceStockCurrency;
        private Label binanceStockSymbol;
        private Label bitGetStockCurrency;
        private Label bitGetStockDown;
        private Label bitGetStockUp;
        private Label label5;
        private Label bitGetStockSymbol;
        private Label kucoinStockCurrency;
        private Label kucoinStockSymbol;
        private Label kucoinStockDown;
        private Label kucoinStockUp;
    }
}