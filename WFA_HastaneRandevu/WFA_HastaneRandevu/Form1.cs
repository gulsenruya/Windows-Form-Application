using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_HastaneRandevu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Doctor> doctors = new List<Doctor>();       
        List<Branch> branches = new List<Branch>();
        List<Appointment> appointments = new List<Appointment>();
        //object initilizaer
        List<string> times = new List<string>()
        {
                                        "09:00","09:30","10:00","10:30","11:00","11:30","12:00","12:30","13:00","13:30","14:00","14:30","15:00"
        };
      

        private void Form1_Load(object sender, EventArgs e)
        {
            Create();
        }
        
        private void btnDoctorAdd_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.FirstName = txtboxDoctor.Text;
            doctors.Add(doctor);
            Branch branch = comboboxBranch.SelectedItem as Branch;//dahiliye
            branch.Doctors.Add(doctor);
            comboboxBranch.SelectedIndex = -1;
            txtboxDoctor.Clear();
            cmboxDoctor.DataSource = doctors.ToList();
           
        }

        private void btnBranchAdd_Click(object sender, EventArgs e)
        {
            Branch branch = new Branch();
            branch.BranchName = txtboxBranch.Text;
            branch.Doctors = new List<Doctor>();
            branches.Add(branch);           
            //DataSource kullanıyorsam override edip ezmem lazım ToString() olarak göster(polymorphism)            
            comboboxBranch.DataSource = cmboboxBranch.DataSource = branches.ToList();
            txtboxBranch.Clear();
        }
       
        void Create()
        {
            for (int i = 0; i < times.Count; i++)
            {
                Button button = new Button();
                button.Text = times[i];
                button.Click += Button_Click;
                flowLayoutPanel1.Controls.Add(button);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            //if (button.BackColor == Color.Red)
            //{
            //    MessageBox.Show("Our doctor's appointment at this time is not appropriate.");
            //    return;
                
            //}
            if(txtTcNumber.Text==string.Empty|| txtboxFirstName.Text==string.Empty|| txtboxLastName.Text==string.Empty|| cmboboxBranch.SelectedIndex<0|| cmboxDoctor.SelectedIndex<0 || dtpickerRandevu.Value < DateTime.Now)
            {
                MessageBox.Show("please enter the appointment information completely and accurately");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to make an appointment?", "Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    button.BackColor = Color.Red;
                    button.Enabled = false;
                    Appointment appointment = new Appointment();
                    appointment.FirstName = txtboxFirstName.Text;
                    appointment.LastName = txtboxLastName.Text;
                    appointment.Doctor = cmboxDoctor.SelectedItem as Doctor;
                    appointment.Branch = cmboboxBranch.SelectedItem as Branch;
                    appointment.TcNumber = txtTcNumber.Text;
                    appointment.Time = button.Text;
                }
            }
            
        }

        private void cmboboxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Branch branch = cmboboxBranch.SelectedItem as Branch;
            cmboxDoctor.DataSource = branch.Doctors.ToList();

        }
    }
}
