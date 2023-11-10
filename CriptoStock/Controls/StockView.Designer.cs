namespace CryptoStock.Desktop.Controls
{
    partial class StockView
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            stockDown = new Label();
            stockUp = new Label();
            stockCurrency = new Label();
            stockSymbol = new Label();
            stockContainer = new GroupBox();
            stockContainer.SuspendLayout();
            SuspendLayout();
            // 
            // stockDown
            // 
            stockDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stockDown.AutoSize = true;
            stockDown.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            stockDown.ForeColor = Color.Red;
            stockDown.Location = new Point(286, 69);
            stockDown.Name = "stockDown";
            stockDown.Size = new Size(25, 23);
            stockDown.TabIndex = 5;
            stockDown.Text = "▼";
            // 
            // stockUp
            // 
            stockUp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stockUp.AutoSize = true;
            stockUp.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            stockUp.ForeColor = Color.Lime;
            stockUp.Location = new Point(286, 46);
            stockUp.Name = "stockUp";
            stockUp.Size = new Size(25, 23);
            stockUp.TabIndex = 4;
            stockUp.Text = "▲";
            // 
            // stockCurrency
            // 
            stockCurrency.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            stockCurrency.AutoSize = true;
            stockCurrency.BackColor = Color.Transparent;
            stockCurrency.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            stockCurrency.ForeColor = SystemColors.ControlLightLight;
            stockCurrency.Location = new Point(317, 43);
            stockCurrency.Name = "stockCurrency";
            stockCurrency.Size = new Size(39, 46);
            stockCurrency.TabIndex = 2;
            stockCurrency.Text = "0";
            // 
            // stockSymbol
            // 
            stockSymbol.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stockSymbol.AutoSize = true;
            stockSymbol.BackColor = Color.Transparent;
            stockSymbol.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            stockSymbol.ForeColor = SystemColors.ControlLightLight;
            stockSymbol.Location = new Point(3, 43);
            stockSymbol.Name = "stockSymbol";
            stockSymbol.Size = new Size(115, 46);
            stockSymbol.TabIndex = 0;
            stockSymbol.Text = "Wait...";
            // 
            // stockContainer
            // 
            stockContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stockContainer.BackColor = Color.RoyalBlue;
            stockContainer.Controls.Add(stockDown);
            stockContainer.Controls.Add(stockUp);
            stockContainer.Controls.Add(stockCurrency);
            stockContainer.Controls.Add(stockSymbol);
            stockContainer.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            stockContainer.ForeColor = SystemColors.ControlLightLight;
            stockContainer.Location = new Point(0, 0);
            stockContainer.Name = "stockContainer";
            stockContainer.Size = new Size(475, 150);
            stockContainer.TabIndex = 5;
            stockContainer.TabStop = false;
            // 
            // StockView
            // 
            Controls.Add(stockContainer);
            Name = "StockView";
            Size = new Size(475, 150);
            stockContainer.ResumeLayout(false);
            stockContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label stockCurrency;
        private Label stockSymbol;
        private Label stockDown;
        private Label stockUp;
        private GroupBox stockContainer;
    }
}
