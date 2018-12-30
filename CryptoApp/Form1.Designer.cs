namespace CryptoApp
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.PluginComboBox = new System.Windows.Forms.ComboBox();
            this.CurrencyRateGrid = new System.Windows.Forms.DataGridView();
            this.SaveToXmlButton = new System.Windows.Forms.Button();
            this.LoadFromXml = new System.Windows.Forms.Button();
            this.CurrencyLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyRateGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PluginComboBox
            // 
            this.PluginComboBox.FormattingEnabled = true;
            this.PluginComboBox.Location = new System.Drawing.Point(71, 12);
            this.PluginComboBox.Name = "PluginComboBox";
            this.PluginComboBox.Size = new System.Drawing.Size(235, 21);
            this.PluginComboBox.TabIndex = 0;
            this.PluginComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CurrencyRateGrid
            // 
            this.CurrencyRateGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurrencyRateGrid.Location = new System.Drawing.Point(16, 64);
            this.CurrencyRateGrid.Name = "CurrencyRateGrid";
            this.CurrencyRateGrid.Size = new System.Drawing.Size(290, 340);
            this.CurrencyRateGrid.TabIndex = 1;
            this.CurrencyRateGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SaveToXmlButton
            // 
            this.SaveToXmlButton.Location = new System.Drawing.Point(164, 415);
            this.SaveToXmlButton.Name = "SaveToXmlButton";
            this.SaveToXmlButton.Size = new System.Drawing.Size(142, 23);
            this.SaveToXmlButton.TabIndex = 2;
            this.SaveToXmlButton.Text = "Save to XML";
            this.SaveToXmlButton.UseVisualStyleBackColor = true;
            this.SaveToXmlButton.Click += new System.EventHandler(this.SaveToXmlButton_Click);
            // 
            // LoadFromXml
            // 
            this.LoadFromXml.Location = new System.Drawing.Point(16, 415);
            this.LoadFromXml.Name = "LoadFromXml";
            this.LoadFromXml.Size = new System.Drawing.Size(142, 23);
            this.LoadFromXml.TabIndex = 3;
            this.LoadFromXml.Text = "Load from XML";
            this.LoadFromXml.UseVisualStyleBackColor = true;
            this.LoadFromXml.Click += new System.EventHandler(this.LoadFromXmlButton_Click);
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.AutoSize = true;
            this.CurrencyLabel.Location = new System.Drawing.Point(13, 15);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(52, 13);
            this.CurrencyLabel.TabIndex = 4;
            this.CurrencyLabel.Text = "Currency:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Code: XYZ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CurrencyLabel);
            this.Controls.Add(this.LoadFromXml);
            this.Controls.Add(this.SaveToXmlButton);
            this.Controls.Add(this.CurrencyRateGrid);
            this.Controls.Add(this.PluginComboBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CryptoApp";
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyRateGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PluginComboBox;
        private System.Windows.Forms.DataGridView CurrencyRateGrid;
        private System.Windows.Forms.Button SaveToXmlButton;
        private System.Windows.Forms.Button LoadFromXml;
        private System.Windows.Forms.Label CurrencyLabel;
        private System.Windows.Forms.Label label2;
    }
}

