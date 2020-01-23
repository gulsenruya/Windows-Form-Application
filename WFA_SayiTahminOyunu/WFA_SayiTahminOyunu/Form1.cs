using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SayiTahminOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        Random randomSayi = new Random();
        int rastgeleSayi;
        int  tahminhakki=5;
        int seviye = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
          rastgeleSayi= randomSayi.Next(1, 11);
          label4.Text = rastgeleSayi.ToString();
        }

        private void Btn_tehminEt_Click(object sender, EventArgs e)
        {
            int girilendeger = Convert.ToInt32(txtbox_sayi.Text);
            if(rastgeleSayi>girilendeger)
            {
                lblSonuc.Text = "lütfen daha büyük bir sayı giriniz";
                tahminhakki = tahminhakki - 1;
                lblTahminHakki.Text = tahminhakki.ToString();
                if (tahminhakki == 0)
                {
                    DialogResult dr = MessageBox.Show("Tahmin Hakkı Bitti", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
              
            }
            else if (rastgeleSayi < girilendeger)
            {
                lblSonuc.Text = "lütfen daha küçük bir sayı giriniz";
                tahminhakki = tahminhakki - 1;
                lblTahminHakki.Text = tahminhakki.ToString();
                if (tahminhakki == 0)
                {
                   
                    DialogResult dr = MessageBox.Show("Tahmin Hakkı Bitti", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                
            }
            else
            {
                
                DialogResult dr = MessageBox.Show("dogru tahmin", "seviyeniz arttı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    rastgeleSayi = rastgeleSayi + 10;
                    label4.Text = rastgeleSayi.ToString();
                    
                }
                else
                {
                    Application.Exit();
                }
                
                seviye = seviye + 1;
                lblSeviye.Text = seviye.ToString();
                tahminhakki = 5;
                lblTahminHakki.Text = tahminhakki.ToString();
                
            }
        }
    }
}
