using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_mcAdam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        string[] menu = { "McChicken", "Whooper", "DoubleQuarterPounder", "McAdana" };
        decimal[] fiyatlar = { 12.90M,20,45,30 };         
        decimal toplamTutar;
        private void Form1_Load(object sender, EventArgs e)
        {
            combobox_Menu.Items.Clear();
            foreach(string menu in menu)
            {
                combobox_Menu.Items.Add(menu);
            }
        }
        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            decimal siparisFiyat = 0; // finansal işlemler için
            siparisFiyat+=fiyatlar[combobox_Menu.SelectedIndex]; // fiyatı al topla ve aktar sürekli aynı deger gelmemesi için !
            string siparisBilgisi = string.Empty;
            siparisBilgisi += combobox_Menu.SelectedItem + " ";
            if (radioButtonBuyuk.Checked)
            {
                siparisFiyat += 2;
                siparisBilgisi += radioButtonBuyuk.Text + " ";
            }
            else if (radioButtonking.Checked)
            {
                siparisFiyat += 5;
                siparisBilgisi += radioButtonking.Text + " ";
            }
            else
            {              
                siparisBilgisi += radiobuttonOrta.Text + " ";
            }

            string ekstrabilgileri = "(";
        
            foreach(CheckBox item in groupBox1.Controls)
            {
                if (item.Checked)
                {
                    siparisFiyat += 1;
                    ekstrabilgileri += item.Text + " ";
                }
            }
            ekstrabilgileri += ")";

            siparisBilgisi += ekstrabilgileri + " ";
            siparisFiyat *= nudAdet.Value;
            siparisBilgisi += "Adet:" + nudAdet.Value + " ";
            siparisBilgisi += "Toplam Tutar:" + siparisFiyat.ToString();
            listBox1.Items.Add(siparisBilgisi);
            toplamTutar += siparisFiyat;
           
        }
         

        private void BtnSiparis_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("sipariş almak ister misiniz ?", "sipariş", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("toplam siparis adeti: " + listBox1.Items.Count + "\n" + "Odemeniz gereken tutar: " + toplamTutar);
            }
            else
            {
                Application.Exit();
            }
            foreach (Control ctrl in this.Controls)
            {

                if (ctrl is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctrl;
                    chk.Checked = false;
                }
                else if (ctrl is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)ctrl;
                    comboBox.SelectedIndex = -1;
                }
                else if (ctrl is GroupBox)
                {

                    foreach (Control ctrl1 in ctrl.Controls)
                    {
                        if (ctrl1 is CheckBox)
                        {
                            CheckBox chk = (CheckBox)ctrl1;
                            chk.Checked = false;
                        }
                    }


                }
                else if (ctrl is RadioButton)
                {
                    RadioButton rb = ctrl as RadioButton;
                    rb.Checked = false;
                }
                else if (ctrl is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)ctrl;
                    nud.Value = 0;
                }



            }
        }
    }
}
