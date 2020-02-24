using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_EFUrunEkleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UrunListele();
            ComboBoxDoldur();

        }
        NORTHWNDEntities db = new NORTHWNDEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            UrunEkle();
            UrunListele();
        }
        void UrunListele()
        {
            dataGridView1.DataSource = db.Products.OrderByDescending(x => x.ProductID).ToList();
        }
        void UrunEkle()
        {
            Product product = new Product();
            product.ProductName = txtUrunAd.Text;
            product.UnitPrice = nudFiyat.Value;
            product.UnitsInStock = Convert.ToInt16(nudStok.Value);
            product.CategoryID = (int)cmbKategori.SelectedValue;
            product.SupplierID = (int)cmbTedarikci.SelectedValue;
            db.Products.Add(product);
           /* db.SaveChanges();*///soun yasarsa -1 basarılı olursa 1 döner
            if (db.SaveChanges() > 0)
            {
                //MessageBox.Show(string.Format("{0} ürün başarılı bir şekilde kaydedildi", product.ProductName));
                MessageBox.Show($"{product.ProductName} ürün başarılı bir şekilde kaydedildi ");
            }
            else
            {
                MessageBox.Show("Birşeyler yanlış gitti...");
            }
           

        }
        void ComboBoxDoldur()
        {
            cmbKategori.DataSource = db.Categories.ToList();
            cmbKategori.DisplayMember = "CategoryName";//Condiments
            cmbKategori.ValueMember = "CategoryId";//2

            cmbTedarikci.DataSource = db.Suppliers.ToList();
            cmbTedarikci.DisplayMember = "CompanyName";
            cmbTedarikci.ValueMember = "SupplierId";
        }

        private void txtboxUrunAra_TextChanged(object sender, EventArgs e)
        {
            string metin = txtboxUrunAra.Text;
            dataGridView1.DataSource=db.Products.Where(x => x.ProductName.Contains(metin)).ToList();
        }

        private void rdbttnArtan_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.OrderBy(x => x.UnitPrice).ToList();
        }

        private void rdbuttonAzalan_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.OrderByDescending(x => x.UnitPrice).ToList();
        }
    }

}
