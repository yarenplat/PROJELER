namespace CafeSiparis
{
    public partial class BAGY : Form
    {
        int caySayisi = 0;
        double cayFiyat = 2.5;
        double cay = 0;
        int kahveSayisi = 0;
        double kahveFiyat = 5.25;
        double kahve = 0;
        int gazozSayisi = 0;
        double gazozFiyat = 6.75;
        double gazoz = 0;
        double TOPLAM = 0;
        public BAGY()
        {
            InitializeComponent();
        }

        private void lblCay_Click(object sender, EventArgs e)
        {

        }

        private void btnCA_Click(object sender, EventArgs e)
        {

            caySayisi++;
            lblCaySayisi.Text = Convert.ToString(caySayisi);
        }

        private void btnCE_Click(object sender, EventArgs e)
        {

            if (caySayisi > 0)
            {
                caySayisi--;
                lblCaySayisi.Text = Convert.ToString(caySayisi);
            }

        }

        private void btnKA_Click(object sender, EventArgs e)
        {

            kahveSayisi++;
            lblKahveSayisi.Text = Convert.ToString(kahveSayisi);
        }

        private void btnKE_Click(object sender, EventArgs e)
        {

            if (kahveSayisi > 0)
            {
                kahveSayisi--;
                lblKahveSayisi.Text = Convert.ToString(kahveSayisi);
            }

        }

        private void btnGA_Click(object sender, EventArgs e)
        {

            gazozSayisi++;
            lblGazozSayisi.Text = Convert.ToString(gazozSayisi);
        }

        private void btnGE_Click(object sender, EventArgs e)
        {

            if (gazozSayisi > 0)
            {
                gazozSayisi--;
                lblGazozSayisi.Text = Convert.ToString(gazozSayisi);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            caySayisi = 0;
            kahveSayisi = 0;
            gazozSayisi = 0;

            lblCaySayisi.Text = "0";
            lblKahveSayisi.Text = "0";
            lblGazozSayisi.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cay = caySayisi * cayFiyat;
            kahve = kahveSayisi * kahveFiyat;
            gazoz = gazozSayisi * gazozFiyat;
            TOPLAM = cay + kahve + gazoz;
            MessageBox.Show("Sipariþ Özeti " + lblCaySayisi.Text + " ÇAY " + lblKahveSayisi.Text + " KAHVE " + lblGazozSayisi.Text + " GAZOZ"+"*******" +" HESAP="+TOPLAM);
        }
    }
}