namespace Project.V10
{
    partial class FormOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            panel1 = new Panel();
            labelTopic_VNS = new Label();
            textBoxSurname_VNS = new TextBox();
            textBoxName_VNS = new TextBox();
            textBoxMiddleName_VNS = new TextBox();
            textBoxAddress_VNS = new TextBox();
            labelSurname_VNS = new Label();
            labelName_VNS = new Label();
            labelMiddleName_VNS = new Label();
            labelAddress_VNS = new Label();
            labelPayment = new Label();
            textBoxResult_VNS = new TextBox();
            radioButtonCardPay_VNS = new RadioButton();
            radioButtonOnlinePay_VNS = new RadioButton();
            labelResult_VNS = new Label();
            buttonCreateOrder_VNS = new Button();
            saveFileDialog_VNS = new SaveFileDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(labelTopic_VNS);
            panel1.Location = new Point(-20, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(789, 171);
            panel1.TabIndex = 0;
            // 
            // labelTopic_VNS
            // 
            labelTopic_VNS.AutoSize = true;
            labelTopic_VNS.BackColor = Color.Transparent;
            labelTopic_VNS.Font = new Font("Segoe UI", 20F);
            labelTopic_VNS.Location = new Point(221, 58);
            labelTopic_VNS.Name = "labelTopic_VNS";
            labelTopic_VNS.Size = new Size(334, 46);
            labelTopic_VNS.TabIndex = 0;
            labelTopic_VNS.Text = "Оформление заказа";
            // 
            // textBoxSurname_VNS
            // 
            textBoxSurname_VNS.Location = new Point(30, 237);
            textBoxSurname_VNS.Name = "textBoxSurname_VNS";
            textBoxSurname_VNS.Size = new Size(190, 27);
            textBoxSurname_VNS.TabIndex = 1;
            textBoxSurname_VNS.KeyPress += textBoxSurname_VNS_KeyPress;
            // 
            // textBoxName_VNS
            // 
            textBoxName_VNS.Location = new Point(248, 237);
            textBoxName_VNS.Name = "textBoxName_VNS";
            textBoxName_VNS.Size = new Size(219, 27);
            textBoxName_VNS.TabIndex = 3;
            textBoxName_VNS.KeyPress += textBoxSurname_VNS_KeyPress;
            // 
            // textBoxMiddleName_VNS
            // 
            textBoxMiddleName_VNS.Location = new Point(488, 237);
            textBoxMiddleName_VNS.Name = "textBoxMiddleName_VNS";
            textBoxMiddleName_VNS.Size = new Size(236, 27);
            textBoxMiddleName_VNS.TabIndex = 5;
            textBoxMiddleName_VNS.KeyPress += textBoxSurname_VNS_KeyPress;
            // 
            // textBoxAddress_VNS
            // 
            textBoxAddress_VNS.Location = new Point(30, 364);
            textBoxAddress_VNS.Name = "textBoxAddress_VNS";
            textBoxAddress_VNS.Size = new Size(694, 27);
            textBoxAddress_VNS.TabIndex = 7;
            textBoxAddress_VNS.KeyPress += textBoxSurname_VNS_KeyPress;
            // 
            // labelSurname_VNS
            // 
            labelSurname_VNS.AutoSize = true;
            labelSurname_VNS.Location = new Point(30, 214);
            labelSurname_VNS.Name = "labelSurname_VNS";
            labelSurname_VNS.Size = new Size(73, 20);
            labelSurname_VNS.TabIndex = 8;
            labelSurname_VNS.Text = "Фамилия";
            // 
            // labelName_VNS
            // 
            labelName_VNS.AutoSize = true;
            labelName_VNS.Location = new Point(248, 214);
            labelName_VNS.Name = "labelName_VNS";
            labelName_VNS.Size = new Size(39, 20);
            labelName_VNS.TabIndex = 9;
            labelName_VNS.Text = "Имя";
            // 
            // labelMiddleName_VNS
            // 
            labelMiddleName_VNS.AutoSize = true;
            labelMiddleName_VNS.Location = new Point(488, 214);
            labelMiddleName_VNS.Name = "labelMiddleName_VNS";
            labelMiddleName_VNS.Size = new Size(72, 20);
            labelMiddleName_VNS.TabIndex = 10;
            labelMiddleName_VNS.Text = "Отчество";
            // 
            // labelAddress_VNS
            // 
            labelAddress_VNS.AutoSize = true;
            labelAddress_VNS.Location = new Point(30, 341);
            labelAddress_VNS.Name = "labelAddress_VNS";
            labelAddress_VNS.Size = new Size(117, 20);
            labelAddress_VNS.TabIndex = 11;
            labelAddress_VNS.Text = "Адрес доставки";
            // 
            // labelPayment
            // 
            labelPayment.AutoSize = true;
            labelPayment.Location = new Point(30, 452);
            labelPayment.Name = "labelPayment";
            labelPayment.Size = new Size(116, 20);
            labelPayment.TabIndex = 12;
            labelPayment.Text = "Способ оплаты";
            // 
            // textBoxResult_VNS
            // 
            textBoxResult_VNS.Location = new Point(574, 526);
            textBoxResult_VNS.Name = "textBoxResult_VNS";
            textBoxResult_VNS.ReadOnly = true;
            textBoxResult_VNS.Size = new Size(150, 27);
            textBoxResult_VNS.TabIndex = 16;
            // 
            // radioButtonCardPay_VNS
            // 
            radioButtonCardPay_VNS.AutoSize = true;
            radioButtonCardPay_VNS.Location = new Point(30, 492);
            radioButtonCardPay_VNS.Name = "radioButtonCardPay_VNS";
            radioButtonCardPay_VNS.Size = new Size(191, 24);
            radioButtonCardPay_VNS.TabIndex = 17;
            radioButtonCardPay_VNS.TabStop = true;
            radioButtonCardPay_VNS.Text = "Картой при получении";
            radioButtonCardPay_VNS.UseVisualStyleBackColor = true;
            // 
            // radioButtonOnlinePay_VNS
            // 
            radioButtonOnlinePay_VNS.AutoSize = true;
            radioButtonOnlinePay_VNS.Location = new Point(30, 527);
            radioButtonOnlinePay_VNS.Name = "radioButtonOnlinePay_VNS";
            radioButtonOnlinePay_VNS.Size = new Size(147, 24);
            radioButtonOnlinePay_VNS.TabIndex = 18;
            radioButtonOnlinePay_VNS.TabStop = true;
            radioButtonOnlinePay_VNS.Text = "Онлайн на сайте";
            radioButtonOnlinePay_VNS.UseVisualStyleBackColor = true;
            // 
            // labelResult_VNS
            // 
            labelResult_VNS.AutoSize = true;
            labelResult_VNS.Location = new Point(574, 496);
            labelResult_VNS.Name = "labelResult_VNS";
            labelResult_VNS.Size = new Size(60, 20);
            labelResult_VNS.TabIndex = 19;
            labelResult_VNS.Text = "ИТОГО:";
            // 
            // buttonCreateOrder_VNS
            // 
            buttonCreateOrder_VNS.Location = new Point(574, 581);
            buttonCreateOrder_VNS.Name = "buttonCreateOrder_VNS";
            buttonCreateOrder_VNS.Size = new Size(150, 47);
            buttonCreateOrder_VNS.TabIndex = 20;
            buttonCreateOrder_VNS.Text = "Оформить заказ";
            buttonCreateOrder_VNS.UseVisualStyleBackColor = true;
            buttonCreateOrder_VNS.Click += buttonCreateOrder_VNS_Click;
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 651);
            Controls.Add(buttonCreateOrder_VNS);
            Controls.Add(labelResult_VNS);
            Controls.Add(radioButtonOnlinePay_VNS);
            Controls.Add(radioButtonCardPay_VNS);
            Controls.Add(textBoxResult_VNS);
            Controls.Add(labelPayment);
            Controls.Add(labelAddress_VNS);
            Controls.Add(labelMiddleName_VNS);
            Controls.Add(labelName_VNS);
            Controls.Add(labelSurname_VNS);
            Controls.Add(textBoxAddress_VNS);
            Controls.Add(textBoxMiddleName_VNS);
            Controls.Add(textBoxName_VNS);
            Controls.Add(textBoxSurname_VNS);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormOrder";
            Text = "Оформление заказа";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelTopic_VNS;
        private TextBox textBoxSurname_VNS;
        private TextBox textBoxName_VNS;
        private TextBox textBoxMiddleName_VNS;
        private TextBox textBoxAddress_VNS;
        private Label labelSurname_VNS;
        private Label labelName_VNS;
        private Label labelMiddleName_VNS;
        private Label labelAddress_VNS;
        private Label labelPayment;
        private Label labelCardPay_VNS;
        private Label labelOnlinePay_VNS;
        private Label label8;
        private TextBox textBoxResult_VNS;
        private RadioButton radioButtonCardPay_VNS;
        private RadioButton radioButtonOnlinePay_VNS;
        private Label labelResult_VNS;
        private Button buttonCreateOrder_VNS;
        private SaveFileDialog saveFileDialog_VNS;
    }
}