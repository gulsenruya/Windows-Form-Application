using NTierNortwindProject.BLL.Repositories;
using NTierNortwindProject.BLL.Repositories.Service;
using NTierNortwindProject.DAL.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTierNortwindProject.WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NORTHWNDEntities db = new NORTHWNDEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            #region veri ekleme
            //NORTHWNDEntities db = new NORTHWNDEntities();
            //Category category = new Category();
            //category.CategoryName = "Test 1 ";
            //category.Description = "Descripton";
            //db.Categories.Add(category);
            //db.SaveChanges();
            //dataGridView1.DataSource = db.Categories.ToList();
            #endregion
            ComboBoxDoldur();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            ProductRepositry productRepositry = new ProductRepositry();
           
            Product product = new Product();
                 
            product.CategoryID = (int)cmbKategori.SelectedValue;
            product.SupplierID = (int)cmbTedarikci.SelectedValue;
            int ıd = (int)product.CategoryID;
            product.ProductName = txtUrunAd.Text;
            //productService.AddProduct(product, ıd);
            //dataGridView1.DataSource = db.Products.ToList();
        }
        #region
        //private void Button2_Click(object sender, EventArgs e)
        //{
        //    ProductService productService = new ProductService();
        //    Product product = new Product();
        //    product.CategoryID = Convert.ToInt32(tbxKategoryAdıUrun.Text);
        //    int ıd = (int)product.CategoryID;
        //    product.ProductName = tbxUrunAdı.Text;
        //    productService.AddProduct(product, ıd);
        //    dataGridView1.DataSource = db.Products.ToList();
        //}

        //private void Button1_Click(object sender, EventArgs e)
        //{

        //    CategoryService categoryService = new CategoryService();
        //    Category category = new Category();
        //    category.CategoryName = tbxKategoryAdı.Text;

        //    categoryService.Add(category);
        //    dataGridView1.DataSource = db.Categories.ToList();


        //}
        #endregion

        void ComboBoxDoldur()
        {
            //cmbKategori.DataSource = db.Categories.ToList();
            //cmbKategori.DisplayMember = "CategoryName";//Condiments
            //cmbKategori.ValueMember = "CategoryId";//2
            CategoryRepository categoryRepository = new CategoryRepository();

            cmbKategori.DataSource = categoryRepository.SelectAll();
            cmbTedarikci.DataSource = db.Suppliers.ToList();
            cmbTedarikci.DisplayMember = "CompanyName";
            cmbTedarikci.ValueMember = "supplierId";
        }
    }
}
