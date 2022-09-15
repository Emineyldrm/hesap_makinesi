namespace WinFormsApp2
{
    public partial class Hesap_Makinesi : Form
    {
        char islem;
        bool ekranKontrol;
        int ilkSayi;
       

        public Hesap_Makinesi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rakam1Button_Click(object sender, EventArgs e)
        {
            if (ekranKontrol)
            {
                sonucLabel.Text = "";
                ekranKontrol = false;
            }
            if (sonucLabel.Text == "0") sonucLabel.Text = "";
            sonucLabel.Text += "1";

        }

        private void rakam2Button_Click(object sender, EventArgs e)
        {
            if (ekranKontrol)
            {
                sonucLabel.Text = "";
                ekranKontrol = false;
            }
            if (sonucLabel.Text == "0") sonucLabel.Text = "";
            sonucLabel.Text += "2";
        }

        private void rakam3Button_Click(object sender, EventArgs e)
        {
            if(ekranKontrol)
            {
                sonucLabel.Text = "";
                ekranKontrol = false;
            }
            if (sonucLabel.Text == "0") sonucLabel.Text = "";
            sonucLabel.Text += "3";
        }

        private void rakam4Button_Click(object sender, EventArgs e)
        {
            if (ekranKontrol)
            {
                sonucLabel.Text = "";
                ekranKontrol = false;
            }
            if (sonucLabel.Text == "0") sonucLabel.Text = "";
            sonucLabel.Text += "4";
        }

        private void rakam5Button_Click(object sender, EventArgs e)
        {
            if (ekranKontrol)
            {
                sonucLabel.Text = "";
                ekranKontrol = false;
            }
            if (sonucLabel.Text == "0") sonucLabel.Text = "";
            sonucLabel.Text += "5";
        }

        private void rakam6Button_Click(object sender, EventArgs e)
        {
            if (ekranKontrol)
            {
                sonucLabel.Text = "";
                ekranKontrol = false;
            }
            if (sonucLabel.Text == "0") sonucLabel.Text = "";
            sonucLabel.Text += "6";
        }

        private void rakam7Button_Click(object sender, EventArgs e)
        {
            if (ekranKontrol)
            {
                sonucLabel.Text = "";
                ekranKontrol = false;
            }
            if (sonucLabel.Text == "0") sonucLabel.Text = "";
            sonucLabel.Text += "7";
        }

        private void rakam8Button_Click(object sender, EventArgs e)
        {
            if (ekranKontrol)
            {
                sonucLabel.Text = "";
                ekranKontrol = false;
            }
            if (sonucLabel.Text == "0") sonucLabel.Text = "";
            sonucLabel.Text += "8";
        }

        private void rakam9Button_Click(object sender, EventArgs e)
        {
            if (ekranKontrol)
            {
                sonucLabel.Text = "";
                ekranKontrol = false;
            }
            if (sonucLabel.Text == "0") sonucLabel.Text = "";
            sonucLabel.Text += "9";
        }

        private void rakam0Button_Click(object sender, EventArgs e)
        {
            if (ekranKontrol)
            {
                sonucLabel.Text = "";
                ekranKontrol = false;
            }
            if (sonucLabel.Text == "0") sonucLabel.Text = "";
            sonucLabel.Text += "0";
        }

        private void artiButton_Click(object sender, EventArgs e)
        {
            islem = '+';
            ekranKontrol = true;
            ilkSayi = Convert.ToInt32(sonucLabel.Text);

        }

        private void eksiButton_Click(object sender, EventArgs e)
        {
            islem = '-';
            ekranKontrol = true;
            ilkSayi = Convert.ToInt32(sonucLabel.Text);
        }

        private void carpýmButton_Click(object sender, EventArgs e)
        {
            islem = '*';
            ekranKontrol = true;
            ilkSayi = Convert.ToInt32(sonucLabel.Text);
        }

        private void bolumButton_Click(object sender, EventArgs e)
        {
            islem = '/';
            ekranKontrol = true;
            ilkSayi = Convert.ToInt32(sonucLabel.Text);
        }

        private void esittirButton_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(sonucLabel.Text);
            int sonuc;
            switch(islem)
                {
                case '+':
                    sonuc = ilkSayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = ilkSayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = ilkSayi / ikinciSayi;
                    break;

                default:
                    sonuc= 0;
                    break;
            }
            sonucLabel.Text = Convert.ToString(sonuc);
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            sonucLabel.Text = "0";
        }
    }
}

       