using CryptoStock.Desktop.Controls;

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
            binanceStockView = new StockView();
            bitgetStockView = new StockView();
            bybitStockView = new StockView();
            kucoinStockView = new StockView();
            quoteAssetCombobox = new ComboBox();
            baseAssetComboBox = new ComboBox();
            label1 = new Label();
            coinPairBox = new GroupBox();
            channelSetButton = new Button();
            coinPairBox.SuspendLayout();
            SuspendLayout();
            // 
            // binanceStockView
            // 
            binanceStockView.Location = new Point(10, 10);
            binanceStockView.Name = "binanceStockView";
            binanceStockView.Size = new Size(475, 150);
            binanceStockView.StockType = CryptoStock.Desktop.Models.Enums.StockTypes.Binance;
            binanceStockView.TabIndex = 0;
            // 
            // bitgetStockView
            // 
            bitgetStockView.Location = new Point(510, 10);
            bitgetStockView.Name = "bitgetStockView";
            bitgetStockView.Size = new Size(475, 150);
            bitgetStockView.StockType = CryptoStock.Desktop.Models.Enums.StockTypes.Bitget;
            bitgetStockView.TabIndex = 1;
            // 
            // bybitStockView
            // 
            bybitStockView.Location = new Point(10, 200);
            bybitStockView.Name = "bybitStockView";
            bybitStockView.Size = new Size(475, 150);
            bybitStockView.StockType = CryptoStock.Desktop.Models.Enums.StockTypes.Bybit;
            bybitStockView.TabIndex = 2;
            // 
            // kucoinStockView
            // 
            kucoinStockView.Location = new Point(510, 200);
            kucoinStockView.Name = "kucoinStockView";
            kucoinStockView.Size = new Size(475, 150);
            kucoinStockView.StockType = CryptoStock.Desktop.Models.Enums.StockTypes.Kucoin;
            kucoinStockView.TabIndex = 3;
            // 
            // quoteAssetCombobox
            // 
            quoteAssetCombobox.FormattingEnabled = true;
            quoteAssetCombobox.Location = new Point(236, 49);
            quoteAssetCombobox.Name = "quoteAssetCombobox";
            quoteAssetCombobox.Size = new Size(151, 43);
            quoteAssetCombobox.TabIndex = 4;
            quoteAssetCombobox.SelectedIndexChanged += QuoteAssetComboBox_SelectedIndexChanged;
            // 
            // baseAssetComboBox
            // 
            baseAssetComboBox.FormattingEnabled = true;
            baseAssetComboBox.Location = new Point(20, 49);
            baseAssetComboBox.Name = "baseAssetComboBox";
            baseAssetComboBox.Size = new Size(151, 43);
            baseAssetComboBox.TabIndex = 5;
            baseAssetComboBox.SelectedIndexChanged += BaseAssetComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(186, 36);
            label1.Name = "label1";
            label1.Size = new Size(34, 46);
            label1.TabIndex = 6;
            label1.Text = "-";
            // 
            // coinPairBox
            // 
            coinPairBox.Controls.Add(channelSetButton);
            coinPairBox.Controls.Add(quoteAssetCombobox);
            coinPairBox.Controls.Add(label1);
            coinPairBox.Controls.Add(baseAssetComboBox);
            coinPairBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            coinPairBox.Location = new Point(1070, 10);
            coinPairBox.Name = "coinPairBox";
            coinPairBox.Size = new Size(400, 213);
            coinPairBox.TabIndex = 7;
            coinPairBox.TabStop = false;
            coinPairBox.Text = "Выбор пары";
            // 
            // channelSetButton
            // 
            channelSetButton.Location = new Point(125, 141);
            channelSetButton.Name = "channelSetButton";
            channelSetButton.Size = new Size(165, 45);
            channelSetButton.TabIndex = 7;
            channelSetButton.Text = "Применить";
            channelSetButton.UseVisualStyleBackColor = true;
            channelSetButton.Click += ChannelSetButton_Click;
            // 
            // StockForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 373);
            Controls.Add(coinPairBox);
            Controls.Add(kucoinStockView);
            Controls.Add(bybitStockView);
            Controls.Add(bitgetStockView);
            Controls.Add(binanceStockView);
            Name = "StockForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockForm";
            coinPairBox.ResumeLayout(false);
            coinPairBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private StockView binanceStockView;
        private StockView bitgetStockView;
        private StockView bybitStockView;
        private StockView kucoinStockView;
        private ComboBox quoteAssetCombobox;
        private ComboBox baseAssetComboBox;
        private Label label1;
        private GroupBox coinPairBox;
        private Button channelSetButton;
    }
}