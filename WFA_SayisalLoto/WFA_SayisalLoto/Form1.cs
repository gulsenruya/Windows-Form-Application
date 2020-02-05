using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SayisalLoto
{
    public partial class btnkontrolEt : Form
    {
        public btnkontrolEt()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int[] sayilar = new int[6];       
        private void BtnSayiUret_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {

                if (ctrl is ListBox)
                {

                    int sayac = 0;
                    ListBox listBox = (ListBox)ctrl;
                    listBox.Items.Clear();
                    while (sayac < 6)
                    {
                        int sayi = rnd.Next(1, 49);
                        if (!listBox.Items.Contains(sayi))
                        {
                            listBox.Items.Add(sayi);

                            sayac++;


                        }
                    }


                    for (int i = 0; i < 6; i++)
                    {
                        int sayi1 = rnd.Next(1, 49);
                        sayilar[i] = sayi1;
                    }
                    label1.Text = sayilar[0].ToString();
                    label2.Text = sayilar[1].ToString();
                    label3.Text = sayilar[2].ToString();
                    label4.Text = sayilar[3].ToString();
                    label5.Text = sayilar[4].ToString();
                    label6.Text = sayilar[5].ToString();
                    


                }

            }
        }

        private void BtnKontrlEt_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {

                if (listBox1.Items.Contains(sayilar[i]) || listBox2.Items.Contains(sayilar[i]) || listBox3.Items.Contains(sayilar[i]) || listBox4.Items.Contains(sayilar[i]) || listBox5.Items.Contains(sayilar[i]) || listBox6.Items.Contains(sayilar[i]) || listBox7.Items.Contains(sayilar[i]) || listBox8.Items.Contains(sayilar[i]))
                {
                    sayac++;


                }
            }
            label7.Text = sayac.ToString();
            if (sayac == 6)
            {
                MessageBox.Show("TEBRIKLER KAZANDINIZ :)) ");
            }
            else
            {
                MessageBox.Show("Şans sizden yana değill :( ");
            }
        }
    }
}
