namespace Project.V10
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            buttonHelpOk_VNS = new Button();
            panelBackHelp_VNS = new Panel();
            textBoxInfoLeft_VNS = new TextBox();
            labelRequest_VNS = new Label();
            labelFAQ_VNS = new Label();
            textBoxFAQ_VNS = new TextBox();
            panelBackHelp_VNS.SuspendLayout();
            SuspendLayout();
            // 
            // buttonHelpOk_VNS
            // 
            buttonHelpOk_VNS.BackColor = Color.Black;
            buttonHelpOk_VNS.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonHelpOk_VNS.ForeColor = SystemColors.ButtonFace;
            buttonHelpOk_VNS.Location = new Point(135, 534);
            buttonHelpOk_VNS.Name = "buttonHelpOk_VNS";
            buttonHelpOk_VNS.Size = new Size(164, 33);
            buttonHelpOk_VNS.TabIndex = 0;
            buttonHelpOk_VNS.Text = "OK";
            buttonHelpOk_VNS.UseVisualStyleBackColor = false;
            buttonHelpOk_VNS.Click += buttonHelpOk_VNS_Click;
            // 
            // panelBackHelp_VNS
            // 
            panelBackHelp_VNS.BackColor = Color.FromArgb(255, 128, 128);
            panelBackHelp_VNS.Controls.Add(textBoxInfoLeft_VNS);
            panelBackHelp_VNS.Controls.Add(labelRequest_VNS);
            panelBackHelp_VNS.Controls.Add(buttonHelpOk_VNS);
            panelBackHelp_VNS.Location = new Point(-3, -3);
            panelBackHelp_VNS.Name = "panelBackHelp_VNS";
            panelBackHelp_VNS.Size = new Size(455, 674);
            panelBackHelp_VNS.TabIndex = 1;
            // 
            // textBoxInfoLeft_VNS
            // 
            textBoxInfoLeft_VNS.BackColor = Color.FromArgb(255, 128, 128);
            textBoxInfoLeft_VNS.BorderStyle = BorderStyle.None;
            textBoxInfoLeft_VNS.Font = new Font("Segoe UI", 12F);
            textBoxInfoLeft_VNS.Location = new Point(26, 170);
            textBoxInfoLeft_VNS.Multiline = true;
            textBoxInfoLeft_VNS.Name = "textBoxInfoLeft_VNS";
            textBoxInfoLeft_VNS.Size = new Size(388, 306);
            textBoxInfoLeft_VNS.TabIndex = 3;
            textBoxInfoLeft_VNS.Text = resources.GetString("textBoxInfoLeft_VNS.Text");
            // 
            // labelRequest_VNS
            // 
            labelRequest_VNS.AutoSize = true;
            labelRequest_VNS.Font = new Font("Times New Roman", 100F, FontStyle.Bold);
            labelRequest_VNS.Location = new Point(135, -22);
            labelRequest_VNS.Name = "labelRequest_VNS";
            labelRequest_VNS.Size = new Size(164, 189);
            labelRequest_VNS.TabIndex = 2;
            labelRequest_VNS.Text = "?";
            // 
            // labelFAQ_VNS
            // 
            labelFAQ_VNS.AutoSize = true;
            labelFAQ_VNS.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelFAQ_VNS.Location = new Point(548, 18);
            labelFAQ_VNS.Name = "labelFAQ_VNS";
            labelFAQ_VNS.Size = new Size(347, 32);
            labelFAQ_VNS.TabIndex = 2;
            labelFAQ_VNS.Text = "Часто задаваемые вопросы";
            // 
            // textBoxFAQ_VNS
            // 
            textBoxFAQ_VNS.BackColor = SystemColors.Control;
            textBoxFAQ_VNS.BorderStyle = BorderStyle.None;
            textBoxFAQ_VNS.Font = new Font("Segoe UI", 11F);
            textBoxFAQ_VNS.Location = new Point(474, 66);
            textBoxFAQ_VNS.Multiline = true;
            textBoxFAQ_VNS.Name = "textBoxFAQ_VNS";
            textBoxFAQ_VNS.Size = new Size(486, 555);
            textBoxFAQ_VNS.TabIndex = 3;
            textBoxFAQ_VNS.Text = resources.GetString("textBoxFAQ_VNS.Text");
            // 
            // FormHelp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(textBoxFAQ_VNS);
            Controls.Add(labelFAQ_VNS);
            Controls.Add(panelBackHelp_VNS);
            Name = "FormHelp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Справка";
            panelBackHelp_VNS.ResumeLayout(false);
            panelBackHelp_VNS.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonHelpOk_VNS;
        private Panel panelBackHelp_VNS;
        private Label labelRequest_VNS;
        private TextBox textBoxInfoLeft_VNS;
        private Label labelFAQ_VNS;
        private TextBox textBoxFAQ_VNS;
    }
}