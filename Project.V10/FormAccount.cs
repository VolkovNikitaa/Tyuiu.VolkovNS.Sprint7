using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.V10
{
    public partial class FormAccount : Form
    {
        public FormAccount(string fio, string address, string num, string pay)
        {
            InitializeComponent();
            textBoxFIO_VNS.Text = fio;
            textBoxAddress_VNS.Text = address;
            textBoxNumber_VNS.Text = num;
            textBoxPayment_VNS.Text = pay;
            labelTime_VNS.Text = Convert.ToString(DateTime.Now);
        }

        private void buttonOK_VNS_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
