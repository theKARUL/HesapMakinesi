using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        char _islem;
        bool _ekranTemiz;
        double _ilksayi;


        public Form1()
        {
            InitializeComponent();
        }

        private void bir_Click(object sender, EventArgs e)
        {
            if (_ekranTemiz == true)
            {
                lblSonuc.Text = "";
                _ekranTemiz = false;
            }
            if (lblSonuc.Text == "0") lblSonuc.Text = "";
            lblSonuc.Text += "1";

            sil.Enabled = true;
        }

        private void iki_Click(object sender, EventArgs e)
        {
            if (_ekranTemiz == true)
            {
                lblSonuc.Text = "";
                _ekranTemiz = false;
            }
            if (lblSonuc.Text == "0") lblSonuc.Text = "";
            lblSonuc.Text += "2";
            sil.Enabled = true;
        }

        private void üc_Click(object sender, EventArgs e)
        {
            if (_ekranTemiz == true)
            {
                lblSonuc.Text = "";
                _ekranTemiz = false;
            }
            if (lblSonuc.Text == "0") lblSonuc.Text = "";
            lblSonuc.Text += "3";
            sil.Enabled = true;
        }

        private void dort_Click(object sender, EventArgs e)
        {
            if (_ekranTemiz == true)
            {
                lblSonuc.Text = "";
                _ekranTemiz = false;
            }
            if (lblSonuc.Text == "0") lblSonuc.Text = "";
            lblSonuc.Text += "4";
            sil.Enabled = true;
        }

        private void bes_Click(object sender, EventArgs e)
        {
            if (_ekranTemiz == true)
            {
                lblSonuc.Text = "";
                _ekranTemiz = false;
            }
            if (lblSonuc.Text == "0") lblSonuc.Text = "";
            lblSonuc.Text += "5";
            sil.Enabled = true;
        }

        private void alti_Click(object sender, EventArgs e)
        {
            if (_ekranTemiz == true)
            {
                lblSonuc.Text = "";
                _ekranTemiz = false;
            }
            if (lblSonuc.Text == "0") lblSonuc.Text = "";
            lblSonuc.Text += "6";
            sil.Enabled = true;
        }

        private void yedi_Click(object sender, EventArgs e)
        {
            if (_ekranTemiz == true)
            {
                lblSonuc.Text = "";
                _ekranTemiz = false;
            }
            if (lblSonuc.Text == "0") lblSonuc.Text = "";
            lblSonuc.Text += "7";
            sil.Enabled = true;
        }

        private void sekiz_Click(object sender, EventArgs e)
        {
            if (_ekranTemiz == true)
            {
                lblSonuc.Text = "";
                _ekranTemiz = false;
            }
            if (lblSonuc.Text == "0") lblSonuc.Text = "";
            lblSonuc.Text += "8";
            sil.Enabled = true;
        }

        private void dokuz_Click(object sender, EventArgs e)
        {
            if (_ekranTemiz == true)
            {
                lblSonuc.Text = "";
                _ekranTemiz = false;
            }
            if (lblSonuc.Text == "0") lblSonuc.Text = "";
            lblSonuc.Text += "9";
            sil.Enabled = true;
        }

        private void sifir_Click(object sender, EventArgs e)
        {
            if (_ekranTemiz == true)
            {
                lblSonuc.Text = "";
                _ekranTemiz = false;
            }
            lblSonuc.Text += "0";
            sil.Enabled = true;
        }

        private void topla_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemiz = true;
            _ilksayi = Convert.ToDouble(lblSonuc.Text);

            sil.Enabled = false;
        }

        private void nokta_Click(object sender, EventArgs e)
        {
            if (_ekranTemiz == true)
            {
                lblSonuc.Text = "";
                _ekranTemiz = false;
            }
            lblSonuc.Text += ".";
            sil.Enabled = false;
        }

        private void deger_Click(object sender, EventArgs e)
        {

            double deger;
            double x;
            x = Convert.ToDouble(lblSonuc.Text);
            if (_ekranTemiz == true)
            {
                lblSonuc.Text = "";
                _ekranTemiz = false;
            }
            deger = x*(-1);

            lblSonuc.Text = Convert.ToString(deger) ;
            sil.Enabled = true;
        }

        private void cikar_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemiz = true;
            _ilksayi = Convert.ToDouble(lblSonuc.Text);
            sil.Enabled = false;
        }

        private void carp_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemiz = true;
            _ilksayi = Convert.ToDouble(lblSonuc.Text);
            sil.Enabled = false;
        }

        private void bol_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemiz = true;
            _ilksayi = Convert.ToDouble(lblSonuc.Text);
            sil.Enabled = false;
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (_ekranTemiz == true)
            {
                lblSonuc.Text = "";
                _ekranTemiz = false;
            }
            lblSonuc.Text = lblSonuc.Text.Remove(lblSonuc.Text.Length - 1, 1);

            if (lblSonuc.Text == "") lblSonuc.Text="0";
                    

                    
        }

        private void esit_Click(object sender, EventArgs e)
        {
            double ikinciSayi = Convert.ToDouble(lblSonuc.Text);
            double sonuc;
            switch(_islem)
            {
                case '+':
                    sonuc = _ilksayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilksayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilksayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilksayi / ikinciSayi;
                    break;
                case '%':
                    sonuc = _ilksayi % ikinciSayi;
                    break;
                default:
                    sonuc = 0;
                    break;

                    sil.Enabled = true;

            }

            lblSonuc.Text = Convert.ToString(sonuc);
        }

        private void temizle_Click(object sender, EventArgs e)
        {

            _ilksayi = 0;
           
            lblSonuc.Text = "0";

            sil.Enabled = true;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            _islem = '%';
            _ekranTemiz = true;
            _ilksayi = Convert.ToDouble(lblSonuc.Text);

            sil.Enabled = false;
        }
    }
}
