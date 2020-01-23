using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Barbut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random zar = new Random();
        int rastgeleSayiBirinciOyuncu;
        int rastgeleSayiIkinciOyuncu;
        decimal bakiye;
        decimal bakiyeOyuncu1;
        decimal bakiyeOyuncu2;
        private void Form1_Load(object sender, EventArgs e)
        {
            //int rastgeleSayi =zar.Next(0, 7);
            //MessageBox.Show(rastgeleSayi.ToString());
            btn_Zarat2.Enabled = false;
            btnZarat1.Enabled = false;
            btnBahisYap.Enabled = false;
            this.ActiveControl = txtBirinciOyuncu;
            btnParaYatır1.Enabled = false;
            buttonParaCek1.Enabled = false;
            btnBahisyap1.Enabled = false;
            btnParaYatır2.Enabled = false;
            buttonParaCek2.Enabled = false;
            btnBahisYap.Enabled = false;


        }

        private void BtnZarat1_Click(object sender, EventArgs e)
        {
            btn_Zarat2.Enabled = true;
            rastgeleSayiBirinciOyuncu= zar.Next(1, 7);
            lblOyuncubir.Text = rastgeleSayiBirinciOyuncu.ToString();
            btnZarat1.Enabled = false;
            listBox1.Items.Add("1. oyuncu zar attı" + " " + rastgeleSayiBirinciOyuncu);
        }

        private void Btn_Zarat2_Click(object sender, EventArgs e)
        {
            
            rastgeleSayiIkinciOyuncu = zar.Next(1, 7);
            lblOyuncu2.Text = rastgeleSayiIkinciOyuncu.ToString();
            btn_Zarat2.Enabled = false;
            listBox1.Items.Add("2. oyuncu zar attı" + " " + rastgeleSayiIkinciOyuncu);
            if (rastgeleSayiBirinciOyuncu > rastgeleSayiIkinciOyuncu)
            {
                lblsonuc.Text = "kazanan oyuncu 1. oyuncudur ";
                decimal toplam = Convert.ToDecimal(lbltoplambakiye.Text);
                toplam = toplam + bakiyeOyuncu1;
                lblBakiye1.Text = toplam.ToString();
                lbltoplambakiye.Text = "toplam para 1. oyuncunun bakiyesine aktarılmıştır";
            }
            else if (rastgeleSayiIkinciOyuncu > rastgeleSayiBirinciOyuncu)
            {
                lblsonuc.Text = "kazanan oyuncu 2. oyuncudur ";
                decimal toplam = Convert.ToDecimal(lbltoplambakiye.Text);
                toplam = toplam + bakiyeOyuncu2;
                lblBakiye2.Text = toplam.ToString();
                lbltoplambakiye.Text = "toplam para 2. oyuncunun bakiyesine aktarılmıştır";
            }
            else
            {
                lblsonuc.Text = "Berabere bitti";
            }
            DialogResult dr= MessageBox.Show("tekrar oynamak ister misin?", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("tamam oynayalımmm :)");
                
            }
            else
            {
                Application.Exit();
            }

        }

        private void btnParaYatır1_Click(object sender, EventArgs e)
        {//bahis yap için
            if (nudPara1.Value > 0)
            {
                bakiye += nudPara1.Value;
                
            }
            else
            {
                MessageBox.Show("En az 1 TL yükleyin");
            }
            //lblBakiye1.Text = bakiye.ToString();
            lbltoplambakiye.Text = bakiye.ToString();
            btnBahisYap.Enabled = true;
            listBox1.Items.Add("1. oyuncu bahis yaptı miktar" + " " + nudPara1.Value);
            
        }

        private void buttonParaCek1_Click(object sender, EventArgs e)
        {
            if (bakiye >= nudPara1.Value)
            {
                bakiye -= nudPara1.Value;
                lblBakiye1.Text = bakiye.ToString();

            }
            else
            {
                MessageBox.Show("Bakiyeniz yetersizdir. Para Yükleyin!");
            }
        }

        private void btnParaYatır2_Click(object sender, EventArgs e)
        {//2. oyuncu bahis
            if (numPara2.Value > 0)
            {
                bakiye += numPara2.Value;
            }
            else
            {
                MessageBox.Show("En az 1 TL yükleyin");
            }
            //lblBakiye1.Text = bakiye.ToString();
            lbltoplambakiye.Text = bakiye.ToString();
            listBox1.Items.Add("2. oyuncu bahis yaptı miktar" + " " + nudPara1.Value);
            btnZarat1.Enabled = true;
        }

        private void buttonParaCek2_Click(object sender, EventArgs e)
        {
            if (bakiye >= numPara2.Value)
            {
                bakiye -= numPara2.Value;
                lblBakiye2.Text = bakiye.ToString();

            }
            else
            {
                MessageBox.Show("Bakiyeniz yetersizdir. Para Yükleyin!");
            }
        }

        private void btnParaYatır1_Click_1(object sender, EventArgs e)
        { //para yatır için
            if (nudPara1.Value > 0)
            {
                bakiyeOyuncu1 += nudPara1.Value;
               
            }
            else
            {
                MessageBox.Show("En az 1 TL yükleyin");
            }
            lblBakiye1.Text = bakiyeOyuncu1.ToString();
            listBox1.Items.Add("1. oyuncu para yatırdı miktar" + " "+ nudPara1.Value);
        }

        private void btnParaYatır2_Click_1(object sender, EventArgs e)
        {
            if (numPara2.Value > 0)
            {
                bakiyeOyuncu2 += numPara2.Value;
            }
            else
            {
                MessageBox.Show("En az 1 TL yükleyin");
            }
            lblBakiye2.Text = bakiyeOyuncu2.ToString();
        }

        private void txtİkinciOyuncu_TextChanged(object sender, EventArgs e)
        {
            label4.Text = txtİkinciOyuncu.Text;
            btnParaYatır1.Enabled = true;
            buttonParaCek1.Enabled = true;
            btnBahisyap1.Enabled = true;
            btnParaYatır2.Enabled = true;
            buttonParaCek2.Enabled = true;

        }

        private void txtBirinciOyuncu_TextChanged(object sender, EventArgs e)
        {
            label3.Text = txtBirinciOyuncu.Text;

        }

        
    }
}
