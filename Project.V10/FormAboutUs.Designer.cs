namespace Project.V10
{
    partial class FormAboutUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutUs));
            buttonAboutUsClose_VNS = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            labelInfoRight_VNS = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonAboutUsClose_VNS
            // 
            buttonAboutUsClose_VNS.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonAboutUsClose_VNS.Location = new Point(51, 565);
            buttonAboutUsClose_VNS.Name = "buttonAboutUsClose_VNS";
            buttonAboutUsClose_VNS.Size = new Size(118, 38);
            buttonAboutUsClose_VNS.TabIndex = 0;
            buttonAboutUsClose_VNS.Text = "Закрыть";
            buttonAboutUsClose_VNS.UseVisualStyleBackColor = true;
            buttonAboutUsClose_VNS.Click += buttonAboutUsClose_VNS_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonAboutUsClose_VNS);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 629);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 172);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 277);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(97, 70);
            label1.Name = "label1";
            label1.Size = new Size(89, 37);
            label1.TabIndex = 2;
            label1.Text = "О нас";
            // 
            // labelInfoRight_VNS
            // 
            labelInfoRight_VNS.AutoSize = true;
            labelInfoRight_VNS.BackColor = Color.Transparent;
            labelInfoRight_VNS.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelInfoRight_VNS.Location = new Point(344, 45);
            labelInfoRight_VNS.Name = "labelInfoRight_VNS";
            labelInfoRight_VNS.Size = new Size(626, 416);
            labelInfoRight_VNS.TabIndex = 2;
            labelInfoRight_VNS.Text = resources.GetString("labelInfoRight_VNS.Text");
            // 
            // FormAboutUs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(982, 653);
            Controls.Add(labelInfoRight_VNS);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAboutUs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О нас";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAboutUsClose_VNS;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label labelInfoRight_VNS;
    }
}