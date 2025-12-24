using Project.V10.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project.V10
{
    public partial class FormCatalog : Form
    {
        public int countTools = 0, countPerfor = 0, countBosch = 0;
        static string openfile = @"C:\Users\Nikita\Documents\price.csv";
        static int rows;
        public int total = 0;
        static int columns;
        public string products;
        public string shopCount;
        public int countShop = 0;
        public FormCatalog()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonMinusTolls_VNS_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxTools_VNS.Text) >= 1)
            {
                textBoxTools_VNS.Text = Convert.ToString(Convert.ToInt32(textBoxTools_VNS.Text) - 1);
                countTools = Convert.ToInt32(textBoxTools_VNS.Text);
            }
        }

        private void buttonPlusTolls_VNS_Click(object sender, EventArgs e)
        {
            textBoxTools_VNS.Text = Convert.ToString(Convert.ToInt32(textBoxTools_VNS.Text) + 1);
            countTools = Convert.ToInt32(textBoxTools_VNS.Text);
        }

        private void buttonMinusPerfor_VNS_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxPerfor_VNS.Text) >= 1)
            {
                textBoxPerfor_VNS.Text = Convert.ToString(Convert.ToInt32(textBoxPerfor_VNS.Text) - 1);
                countPerfor = Convert.ToInt32(textBoxPerfor_VNS.Text);
            }
        }

        private void buttonPlusPerfor_VNS_Click(object sender, EventArgs e)
        {
            textBoxPerfor_VNS.Text = Convert.ToString(Convert.ToInt32(textBoxPerfor_VNS.Text) + 1);
            countPerfor = Convert.ToInt32(textBoxPerfor_VNS.Text);
        }

        private void buttonMinusBosch_VNS_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxBosch_VNS.Text) >= 1)
            {
                textBoxBosch_VNS.Text = Convert.ToString(Convert.ToInt32(textBoxBosch_VNS.Text) - 1);
                countBosch = Convert.ToInt32(textBoxBosch_VNS.Text);
            }
        }

        private void buttonPlusBosch_VNS_Click(object sender, EventArgs e)
        {
            textBoxBosch_VNS.Text = Convert.ToString(Convert.ToInt32(textBoxBosch_VNS.Text) + 1);
            countBosch = Convert.ToInt32(textBoxBosch_VNS.Text);
        }
        
        private void pictureBoxShopList_VNS_Click(object sender, EventArgs e)
        {
            pictureBoxBosch_VNS.Visible = false;
            pictureBoxPerfor_VNS.Visible = false;
            pictureBoxTools_VNS.Visible = false;

            panelBosch_VNS.Visible = false;
            panelPerfor_VNS.Visible = false;
            panelTools_VNS.Visible = false;

            labelBosch_VNS.Visible = false;
            labelPerfor_VNS.Visible = false;
            labelTools_VNS.Visible = false;

            buttonMinusBosch_VNS.Visible = false;
            buttonMinusPerfor_VNS.Visible = false;
            buttonMinusTools_VNS.Visible = false;

            buttonPlusBosch_VNS.Visible = false;
            buttonPlusPerfor_VNS.Visible = false;
            buttonPlusTools_VNS.Visible = false;

            textBoxBosch_VNS.Visible = false;
            textBoxPerfor_VNS.Visible = false;
            textBoxTools_VNS.Visible = false;
            pictureBoxShopList_VNS.Visible = false;

            labelName_VNS.Visible = true;
            labelCount_VNS.Visible = true;
            labelSum_VNS.Visible = true;

            labelResult_VNS.Visible = true;
            labelPrice_VNS.Visible = true;
            richTextBoxList_VNS.Visible = true;

            buttonBack_VNS.Visible = true;
            textBoxAllCount_VNS.Visible = true;
            labelSecondCatalog_VNS.Visible = true;

            buttonShopPerfor_VNS.Visible = false;
            buttonShopBosch_VNS.Visible = false;
            buttonShopTools_VNS.Visible = false;
            buttonOrder_VNS.Visible = true;
        }

        private void buttonBack_VNS_Click(object sender, EventArgs e)
        {
            pictureBoxBosch_VNS.Visible = true;
            pictureBoxPerfor_VNS.Visible = true;
            pictureBoxTools_VNS.Visible = true;



            buttonShopPerfor_VNS.Visible = true;
            buttonShopBosch_VNS.Visible = true;
            buttonShopTools_VNS.Visible = true;

            labelBosch_VNS.Visible = true;
            labelPerfor_VNS.Visible = true;
            labelTools_VNS.Visible = true;

            buttonMinusBosch_VNS.Visible = true;
            buttonMinusPerfor_VNS.Visible = true;
            buttonMinusTools_VNS.Visible = true;

            buttonPlusBosch_VNS.Visible = true;
            buttonPlusPerfor_VNS.Visible = true;
            buttonPlusTools_VNS.Visible = true;

            textBoxBosch_VNS.Visible = true;
            textBoxPerfor_VNS.Visible = true;
            textBoxTools_VNS.Visible = true;
            pictureBoxShopList_VNS.Visible = true;

            labelName_VNS.Visible = false;
            labelCount_VNS.Visible = false;
            labelSum_VNS.Visible = false;

            labelResult_VNS.Visible = false;
            labelPrice_VNS.Visible = false;
            richTextBoxList_VNS.Visible = false;

            buttonBack_VNS.Visible = false;
            textBoxAllCount_VNS.Visible = false;
            labelSecondCatalog_VNS.Visible = false;
            buttonOrder_VNS.Visible = false;

            panelBosch_VNS.Visible = true;
            panelPerfor_VNS.Visible = true;
            panelTools_VNS.Visible = true;

        }

        private void FormCatalog_Load(object sender, EventArgs e)
        {
            labelName_VNS.Visible = false;
            labelCount_VNS.Visible = false;
            labelSum_VNS.Visible = false;

            labelResult_VNS.Visible = false;
            labelPrice_VNS.Visible = false;
            richTextBoxList_VNS.Visible = false;

            buttonBack_VNS.Visible = false;
            textBoxAllCount_VNS.Visible = false;
            labelSecondCatalog_VNS.Visible = false;
            buttonOrder_VNS.Visible = false;

        }

        private void buttonShopTools_VNS_Click(object sender, EventArgs e)
        {

            rows = ds.LoadFromData(openfile).GetUpperBound(0) + 1;
            columns = ds.LoadFromData(openfile).GetUpperBound(1) + 1;
            int toolsindex;
            string[,] arrayValues = new string[rows, columns];
            arrayValues = ds.LoadFromData(openfile);
            string Tools = arrayValues[0, 0] + "\t\t\t\t\t\t\t\t\t" + Convert.ToString(Convert.ToInt32(arrayValues[0, 1])) + " pуб"
                + "\t\t\t\t\t\t" + Convert.ToString(countTools) + " шт." + "\t\t\t\t\t\t\t\t" + Convert.ToString(Convert.ToInt32(arrayValues[0, 1]) * countTools) + "руб";
            richTextBoxList_VNS.Text += "\n\t" + Tools + "\n";
            products += arrayValues[0, 0] + " " + Convert.ToString(countTools) + " шт.  ";
            
            shopCount = textBoxShopCount_VNS.Text;
            shopCount = Convert.ToString(countPerfor + countTools + countBosch);
            textBoxShopCount_VNS.Text = shopCount;
            toolsindex = richTextBoxList_VNS.Lines.Length;
            total = Convert.ToInt32(arrayValues[2, 1]) * countBosch + Convert.ToInt32(arrayValues[1, 1]) * countPerfor + Convert.ToInt32(arrayValues[0, 1]) * countTools;
            textBoxAllCount_VNS.Text = Convert.ToString(total) + " p.";


        }

        private void buttonShopPerfor_VNS_Click(object sender, EventArgs e)
        {

            rows = ds.LoadFromData(openfile).GetUpperBound(0) + 1;
            columns = ds.LoadFromData(openfile).GetUpperBound(1) + 1;

            string[,] arrayValues = new string[rows, columns];
            arrayValues = ds.LoadFromData(openfile);
            string Perfor = arrayValues[1, 0] + "\t\t\t\t\t\t\t\t\t" + Convert.ToString(Convert.ToInt32(arrayValues[1, 1])) + " pуб"
                + "\t\t\t\t\t\t" + Convert.ToString(countPerfor) + " шт." + "\t\t\t\t\t\t\t\t" + Convert.ToString(Convert.ToInt32(arrayValues[1, 1]) * countPerfor) + "руб";
            richTextBoxList_VNS.Text += "\n\t" + Perfor + "\n";
            products += arrayValues[1, 0] + " " + Convert.ToString(countPerfor) + " шт.  ";
            
            buttonShopPerfor_VNS.Text = "В корзине";
            shopCount = textBoxShopCount_VNS.Text;
            shopCount = Convert.ToString(countPerfor + countTools + countBosch);
            textBoxShopCount_VNS.Text = shopCount;
            int perforsindex = richTextBoxList_VNS.Lines.Length;
            total = Convert.ToInt32(arrayValues[2, 1]) * countBosch + Convert.ToInt32(arrayValues[1, 1]) * countPerfor + Convert.ToInt32(arrayValues[0, 1]) * countTools;
            textBoxAllCount_VNS.Text = Convert.ToString(total) + " p.";

        }

        private void buttonShopBosch_VNS_Click(object sender, EventArgs e)
        {
            rows = ds.LoadFromData(openfile).GetUpperBound(0) + 1;
            columns = ds.LoadFromData(openfile).GetUpperBound(1) + 1;

            string[,] arrayValues = new string[rows, columns];
            arrayValues = ds.LoadFromData(openfile);
            string Bosch = arrayValues[2, 0] + "\t\t\t\t\t\t\t\t\t\t" + Convert.ToString(Convert.ToInt32(arrayValues[2, 1])) + " pуб"
                + "\t\t\t\t\t\t" + Convert.ToString(countBosch) + " шт." + "\t\t\t\t\t\t\t\t" + Convert.ToString(Convert.ToInt32(arrayValues[2, 1]) * countBosch) + "руб";
            richTextBoxList_VNS.Text += "\n\t" + Bosch + "\n";
            products += arrayValues[2, 0] + " " + Convert.ToString(countBosch) + " шт.  ";         
            shopCount = textBoxShopCount_VNS.Text;
            shopCount = Convert.ToString(countPerfor + countTools + countBosch);
            textBoxShopCount_VNS.Text = shopCount;
            countShop++;
            total = Convert.ToInt32(arrayValues[2, 1]) * countBosch + Convert.ToInt32(arrayValues[1, 1]) * countPerfor + Convert.ToInt32(arrayValues[0, 1]) * countTools;
            textBoxAllCount_VNS.Text = Convert.ToString(total) + " p.";

        }
          


        private void buttonOrder_VNS_Click(object sender, EventArgs e)
        {
            FormOrder order = new FormOrder(total, products);
            order.Show();
            richTextBoxList_VNS.Text = "";
            textBoxAllCount_VNS.Text = "";
        }

    }
}
