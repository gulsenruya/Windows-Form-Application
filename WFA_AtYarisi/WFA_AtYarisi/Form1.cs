using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        Random rnd = new Random();
        
        
        private void Timer1_Tick(object sender, EventArgs e)
        {
            pbat1.Left += rnd.Next(10, 50);
            pbat2.Left += rnd.Next(10, 50);
            pbat3.Left += rnd.Next(10, 50);

            if (pbat1.Right > pbat2.Right && pbat1.Right>pbat3.Right)
            {
                lblsonuc.Text = "1. at önde gidiyor";
            }
          
            else if (pbat2.Right>pbat3.Right && pbat2.Right > pbat1.Right)
            {
                lblsonuc.Text = "2. at önde gidiyor";

            }
          
            else if (pbat3.Right > pbat1.Right && pbat3.Right > pbat2.Right)
            {
                lblsonuc.Text = "3. at önde gidiyor";
            }
          



            if (pbat1.Right >= lblFinish.Left )
            {
                timer1.Enabled = false;
                
                lblsonuc.Text = "1. At kazandı";
            }
            else if (pbat2.Right >= lblFinish.Left)
            {
                timer1.Enabled = false;
                lblsonuc.Text = "2. At kazandı";
            }
            else if (pbat3.Right>=lblFinish.Left)
            {
                timer1.Enabled = false;
                lblsonuc.Text = "3. At kazandı";
            }
          

        }

        private void BtnBasla_Click(object sender, EventArgs e)
        {

            timer1.Start();
        }    
         
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
