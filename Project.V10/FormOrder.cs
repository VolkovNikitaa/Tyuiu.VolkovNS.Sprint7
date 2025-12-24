using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.V10
{
    public partial class FormOrder : Form
    {
        public string fio;
        public string address;
        public string pay;
        public string totalSum;
        public string num;
        public string name;
        public string surname;
        public string middlename;
        public string productsOrder;
        public FormOrder(int total, string products)
        {
            InitializeComponent();
            textBoxResult_VNS.Text = Convert.ToString(total) + " pуб";
            productsOrder = products;
        }

        private void buttonCreateOrder_VNS_Click(object sender, EventArgs e)
        {
            Random rand = new Random((int)(DateTime.Now.Ticks));
            totalSum = textBoxResult_VNS.Text;

            if ((textBoxName_VNS.Text != "") && (textBoxSurname_VNS.Text != "") &&
               (textBoxAddress_VNS.Text != "") && (textBoxMiddleName_VNS.Text != "") &&
               (radioButtonCardPay_VNS.Text != "" || radioButtonOnlinePay_VNS.Text != ""))
            {
                name = textBoxName_VNS.Text;
                surname = textBoxSurname_VNS.Text;
                middlename = textBoxMiddleName_VNS.Text;
                totalSum = textBoxResult_VNS.Text;


                fio = surname + "\t" + name + "\t" + middlename;
                address = textBoxAddress_VNS.Text;
                if (radioButtonCardPay_VNS.Checked == true)
                    pay = radioButtonCardPay_VNS.Text;
                else
                    pay = radioButtonOnlinePay_VNS.Text;
                num = Convert.ToString(rand.Next(1000, 10000));

                FormAccount account = new FormAccount(fio, address, num, pay);
                account.Show();
                this.Close();
            }
            else
                MessageBox.Show("Данные введены неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            string[] inforegister = new string[] { surname, name, middlename, address, num, pay, totalSum, productsOrder };
            saveFileDialog_VNS.FileName = "Информация о заказах.csv";
            saveFileDialog_VNS.InitialDirectory = @"C: \Users\Nikita\Documents\project";

            string path = saveFileDialog_VNS.FileName;
            int columns = 8;
            StringBuilder str = new StringBuilder();


            for (int j = 0; j < columns; j++)
            {
                if (j != columns - 1)
                {
                    str.Append(inforegister[j] + ";");
                }
                else
                {
                    str.Append(inforegister[j]);
                }
            }
            File.AppendAllText(path, str + Environment.NewLine, Encoding.UTF8);

        }

        private void textBoxSurname_VNS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z'))
            {
                e.Handled = true;
            }
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    e.Handled = true;
                    return;
            }
        }

    }
}
