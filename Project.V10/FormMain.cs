namespace Project.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void labelHelp_VNS_Click(object sender, EventArgs e)
        {
            FormHelp help = new FormHelp();
            help.Show();
        }

        private void labelDelivery_VNS_Click(object sender, EventArgs e)
        {
            FormDelivery delivery = new FormDelivery();
            delivery.Show();
        }

        private void labelAboutUs_VNS_Click(object sender, EventArgs e)
        {
            FormAboutUs aboutUs = new FormAboutUs();
            aboutUs.Show();
        }

        private void buttonCatalog_VNS_Click(object sender, EventArgs e)
        {
            FormCatalog catalog = new FormCatalog();
            catalog.Show();
        }
    }
}
