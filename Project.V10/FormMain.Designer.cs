namespace Project.V10
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonCatalog_VNS = new Button();
            labelMarket_VNS = new Label();
            labelAboutUs_VNS = new Label();
            labelDelivery_VNS = new Label();
            labelHelp_VNS = new Label();
            SuspendLayout();
            // 
            // buttonCatalog_VNS
            // 
            buttonCatalog_VNS.Anchor = AnchorStyles.Bottom;
            buttonCatalog_VNS.BackColor = SystemColors.ControlText;
            buttonCatalog_VNS.FlatStyle = FlatStyle.Popup;
            buttonCatalog_VNS.Font = new Font("Century Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCatalog_VNS.ForeColor = Color.White;
            buttonCatalog_VNS.Location = new Point(470, 724);
            buttonCatalog_VNS.Name = "buttonCatalog_VNS";
            buttonCatalog_VNS.Size = new Size(392, 97);
            buttonCatalog_VNS.TabIndex = 0;
            buttonCatalog_VNS.Text = "Каталог";
            buttonCatalog_VNS.UseVisualStyleBackColor = false;
            buttonCatalog_VNS.Click += buttonCatalog_VNS_Click;
            // 
            // labelMarket_VNS
            // 
            labelMarket_VNS.AutoSize = true;
            labelMarket_VNS.BackColor = Color.Transparent;
            labelMarket_VNS.Font = new Font("Century Gothic", 20F, FontStyle.Bold);
            labelMarket_VNS.Location = new Point(27, 19);
            labelMarket_VNS.Name = "labelMarket_VNS";
            labelMarket_VNS.Size = new Size(420, 40);
            labelMarket_VNS.TabIndex = 1;
            labelMarket_VNS.Text = "Магазин инструментов";
            // 
            // labelAboutUs_VNS
            // 
            labelAboutUs_VNS.AutoSize = true;
            labelAboutUs_VNS.BackColor = Color.Transparent;
            labelAboutUs_VNS.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            labelAboutUs_VNS.Location = new Point(27, 101);
            labelAboutUs_VNS.Name = "labelAboutUs_VNS";
            labelAboutUs_VNS.Size = new Size(107, 37);
            labelAboutUs_VNS.TabIndex = 2;
            labelAboutUs_VNS.Text = "О нас";
            labelAboutUs_VNS.Click += labelAboutUs_VNS_Click;
            // 
            // labelDelivery_VNS
            // 
            labelDelivery_VNS.AutoSize = true;
            labelDelivery_VNS.BackColor = Color.Transparent;
            labelDelivery_VNS.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            labelDelivery_VNS.Location = new Point(275, 101);
            labelDelivery_VNS.Name = "labelDelivery_VNS";
            labelDelivery_VNS.Size = new Size(166, 37);
            labelDelivery_VNS.TabIndex = 3;
            labelDelivery_VNS.Text = "Доставка";
            labelDelivery_VNS.Click += labelDelivery_VNS_Click;
            // 
            // labelHelp_VNS
            // 
            labelHelp_VNS.AutoSize = true;
            labelHelp_VNS.BackColor = Color.Transparent;
            labelHelp_VNS.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            labelHelp_VNS.Location = new Point(527, 101);
            labelHelp_VNS.Name = "labelHelp_VNS";
            labelHelp_VNS.Size = new Size(150, 37);
            labelHelp_VNS.TabIndex = 4;
            labelHelp_VNS.Text = "Справка";
            labelHelp_VNS.Click += labelHelp_VNS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1276, 855);
            Controls.Add(labelHelp_VNS);
            Controls.Add(labelDelivery_VNS);
            Controls.Add(labelAboutUs_VNS);
            Controls.Add(labelMarket_VNS);
            Controls.Add(buttonCatalog_VNS);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormMain";
            Text = "Главное меню";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCatalog_VNS;
        private Label labelMarket_VNS;
        private Label labelAboutUs_VNS;
        private Label labelDelivery_VNS;
        private Label labelHelp_VNS;
    }
}
