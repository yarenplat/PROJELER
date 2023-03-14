namespace CafeSiparis
{
    public partial class BAGY : Form
    {
        public BAGY()
        {
            InitializeComponent();
        }

        private void lblCay_Click(object sender, EventArgs e)
        {

        }

        private void btnCA_Click(object sender, EventArgs e)
        {
            int caySayisi = Convert.ToInt32(lblCaySayisi.Text);
            caySayisi++;
            lblCaySayisi.Text = Convert.ToString(caySayisi);
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            int caySayisi = Convert.ToInt32(lblCaySayisi.Text);
            if (caySayisi > 0)
            {
                caySayisi--;
                lblCaySayisi.Text = Convert.ToString(caySayisi);
            }

        }

        private void btnKA_Click(object sender, EventArgs e)
        {
            int kahveSayisi = Convert.ToInt32(lblKahveSayisi.Text);
            kahveSayisi++;
            lblKahveSayisi.Text = Convert.ToString(kahveSayisi);
        }

        private void btnKE_Click(object sender, EventArgs e)
        {
            int kahveSayisi = Convert.ToInt32(lblKahveSayisi.Text);
            if (kahveSayisi > 0)
            {
                kahveSayisi--;
                lblKahveSayisi.Text = Convert.ToString(kahveSayisi);
            }

        }

        private void btnGA_Click(object sender, EventArgs e)
        {
            int gazozoSayisi = Convert.ToInt32(lblGazozSayisi.Text);
            gazozoSayisi++;
            lblGazozSayisi.Text = Convert.ToString(gazozoSayisi);
        }

        private void btnGE_Click(object sender, EventArgs e)
        {
            int gazozoSayisi = Convert.ToInt32(lblGazozSayisi.Text);
            if (gazozoSayisi > 0)
            {
                gazozoSayisi--;
                lblGazozSayisi.Text = Convert.ToString(gazozoSayisi);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblCaySayisi.Text = "0";
            lblKahveSayisi.Text = "0";
            lblGazozSayisi.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sipariþ Özeti " + lblCaySayisi.Text + " ÇAY " + lblKahveSayisi.Text + " KAHVE " + lblGazozSayisi.Text + " GAZOZ");
        }
    }
}