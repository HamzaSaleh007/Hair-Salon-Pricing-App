namespace Lab3B
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
            this.hairDresserGroupBox = new System.Windows.Forms.GroupBox();
            this.serviceGroupBox = new System.Windows.Forms.GroupBox();
            this.chargedItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.priceGroupBox = new System.Windows.Forms.GroupBox();
            this.Pricelabel = new System.Windows.Forms.Label();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.hairDresserComboBox = new System.Windows.Forms.ComboBox();
            this.ServiceslistBox = new System.Windows.Forms.ListBox();
            this.ChargedlistBox = new System.Windows.Forms.ListBox();
            this.PriceListBox = new System.Windows.Forms.ListBox();
            this.hairDresserGroupBox.SuspendLayout();
            this.serviceGroupBox.SuspendLayout();
            this.chargedItemsGroupBox.SuspendLayout();
            this.priceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // hairDresserGroupBox
            // 
            this.hairDresserGroupBox.Controls.Add(this.hairDresserComboBox);
            this.hairDresserGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hairDresserGroupBox.Location = new System.Drawing.Point(35, 23);
            this.hairDresserGroupBox.Name = "hairDresserGroupBox";
            this.hairDresserGroupBox.Size = new System.Drawing.Size(232, 216);
            this.hairDresserGroupBox.TabIndex = 0;
            this.hairDresserGroupBox.TabStop = false;
            this.hairDresserGroupBox.Text = "Select A Hair Dresser:";
            // 
            // serviceGroupBox
            // 
            this.serviceGroupBox.Controls.Add(this.ServiceslistBox);
            this.serviceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceGroupBox.Location = new System.Drawing.Point(299, 23);
            this.serviceGroupBox.Name = "serviceGroupBox";
            this.serviceGroupBox.Size = new System.Drawing.Size(264, 216);
            this.serviceGroupBox.TabIndex = 1;
            this.serviceGroupBox.TabStop = false;
            this.serviceGroupBox.Text = "Select A service:";
            // 
            // chargedItemsGroupBox
            // 
            this.chargedItemsGroupBox.Controls.Add(this.ChargedlistBox);
            this.chargedItemsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chargedItemsGroupBox.Location = new System.Drawing.Point(569, 23);
            this.chargedItemsGroupBox.Name = "chargedItemsGroupBox";
            this.chargedItemsGroupBox.Size = new System.Drawing.Size(272, 216);
            this.chargedItemsGroupBox.TabIndex = 2;
            this.chargedItemsGroupBox.TabStop = false;
            this.chargedItemsGroupBox.Text = "Charged Items:";
            // 
            // priceGroupBox
            // 
            this.priceGroupBox.Controls.Add(this.PriceListBox);
            this.priceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceGroupBox.Location = new System.Drawing.Point(864, 23);
            this.priceGroupBox.Name = "priceGroupBox";
            this.priceGroupBox.Size = new System.Drawing.Size(200, 216);
            this.priceGroupBox.TabIndex = 3;
            this.priceGroupBox.TabStop = false;
            this.priceGroupBox.Text = "Price:";
            // 
            // Pricelabel
            // 
            this.Pricelabel.AutoSize = true;
            this.Pricelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pricelabel.Location = new System.Drawing.Point(780, 289);
            this.Pricelabel.Name = "Pricelabel";
            this.Pricelabel.Size = new System.Drawing.Size(99, 20);
            this.Pricelabel.TabIndex = 4;
            this.Pricelabel.Text = "Total Price:";
            // 
            // addServiceButton
            // 
            this.addServiceButton.Location = new System.Drawing.Point(198, 352);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(191, 32);
            this.addServiceButton.TabIndex = 5;
            this.addServiceButton.Text = "Add Service";
            this.addServiceButton.UseVisualStyleBackColor = true;
            this.addServiceButton.Click += new System.EventHandler(this.addServiceButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(395, 352);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(173, 32);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate Total Price";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(574, 352);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(187, 32);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(767, 352);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(169, 32);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // hairDresserComboBox
            // 
            this.hairDresserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hairDresserComboBox.FormattingEnabled = true;
            this.hairDresserComboBox.Items.AddRange(new object[] {
            "Jane",
            "Pat",
            "Ron",
            "Sue",
            "Laurie"});
            this.hairDresserComboBox.Location = new System.Drawing.Point(6, 36);
            this.hairDresserComboBox.Name = "hairDresserComboBox";
            this.hairDresserComboBox.Size = new System.Drawing.Size(220, 28);
            this.hairDresserComboBox.TabIndex = 0;
            this.hairDresserComboBox.Tag = "";
            // 
            // ServiceslistBox
            // 
            this.ServiceslistBox.FormattingEnabled = true;
            this.ServiceslistBox.ItemHeight = 20;
            this.ServiceslistBox.Items.AddRange(new object[] {
            "Cut ",
            "Wash, blow-dry, and style ",
            "Colour ",
            "Highlights ",
            "Extension ",
            "Up-do "});
            this.ServiceslistBox.Location = new System.Drawing.Point(6, 26);
            this.ServiceslistBox.Name = "ServiceslistBox";
            this.ServiceslistBox.Size = new System.Drawing.Size(252, 164);
            this.ServiceslistBox.TabIndex = 0;
            this.ServiceslistBox.SelectedIndexChanged += new System.EventHandler(this.ServiceslistBox_SelectedIndexChanged);
            // 
            // ChargedlistBox
            // 
            this.ChargedlistBox.FormattingEnabled = true;
            this.ChargedlistBox.ItemHeight = 20;
            this.ChargedlistBox.Location = new System.Drawing.Point(6, 26);
            this.ChargedlistBox.Name = "ChargedlistBox";
            this.ChargedlistBox.Size = new System.Drawing.Size(260, 164);
            this.ChargedlistBox.TabIndex = 0;
            // 
            // PriceListBox
            // 
            this.PriceListBox.FormattingEnabled = true;
            this.PriceListBox.ItemHeight = 20;
            this.PriceListBox.Location = new System.Drawing.Point(6, 26);
            this.PriceListBox.Name = "PriceListBox";
            this.PriceListBox.Size = new System.Drawing.Size(174, 164);
            this.PriceListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.addServiceButton);
            this.Controls.Add(this.Pricelabel);
            this.Controls.Add(this.priceGroupBox);
            this.Controls.Add(this.chargedItemsGroupBox);
            this.Controls.Add(this.serviceGroupBox);
            this.Controls.Add(this.hairDresserGroupBox);
            this.Name = "Form1";
            this.Text = "Perfect Cut Hair Salon";
            this.hairDresserGroupBox.ResumeLayout(false);
            this.serviceGroupBox.ResumeLayout(false);
            this.chargedItemsGroupBox.ResumeLayout(false);
            this.priceGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox hairDresserGroupBox;
        private System.Windows.Forms.GroupBox serviceGroupBox;
        private System.Windows.Forms.GroupBox chargedItemsGroupBox;
        private System.Windows.Forms.GroupBox priceGroupBox;
        private System.Windows.Forms.Label Pricelabel;
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox hairDresserComboBox;
        private System.Windows.Forms.ListBox ServiceslistBox;
        private System.Windows.Forms.ListBox ChargedlistBox;
        private System.Windows.Forms.ListBox PriceListBox;
    }
}

