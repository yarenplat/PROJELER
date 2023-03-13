namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        private char _islem;
        bool _ekrantemizlenecekMi;
        int _ilkSayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekrantemizlenecekMi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekrantemizlenecekMi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekrantemizlenecekMi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekrantemizlenecekMi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekrantemizlenecekMi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekrantemizlenecekMi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekrantemizlenecekMi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekrantemizlenecekMi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekrantemizlenecekMi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekrantemizlenecekMi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "0";
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(lblEkran.Text);
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            int _ikinciSayi = Convert.ToInt32(lblEkran.Text);
            int _sonuc;
            switch (_islem)
            {
                case '+':
                    _sonuc = _ilkSayi + _ikinciSayi;
                    break;
                case '-':
                    _sonuc = _ilkSayi - _ikinciSayi;
                    break;
                case '*':
                    _sonuc = _ilkSayi * _ikinciSayi;
                    break;
                case '/':
                    _sonuc = _ilkSayi / _ikinciSayi;
                    break;
                default:
                    _sonuc = 0;
                    break;
            }
            lblEkran.Text = Convert.ToString(_sonuc);
        }

        private void btnCikartma_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(lblEkran.Text);

        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(lblEkran.Text);
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(lblEkran.Text);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblEkran.Text = "0";
        }
    }
}