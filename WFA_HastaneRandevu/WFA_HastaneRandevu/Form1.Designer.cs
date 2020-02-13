namespace WFA_HastaneRandevu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBranchAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxBranch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDoctorAdd = new System.Windows.Forms.Button();
            this.txtboxDoctor = new System.Windows.Forms.TextBox();
            this.comboboxBranch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmboboxBranch = new System.Windows.Forms.ComboBox();
            this.dtpickerRandevu = new System.Windows.Forms.DateTimePicker();
            this.txtboxLastName = new System.Windows.Forms.TextBox();
            this.cmboxDoctor = new System.Windows.Forms.ComboBox();
            this.txtboxFirstName = new System.Windows.Forms.TextBox();
            this.txtTcNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBranchAdd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtboxBranch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(383, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Branş Ekle";
            // 
            // btnBranchAdd
            // 
            this.btnBranchAdd.Location = new System.Drawing.Point(49, 122);
            this.btnBranchAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnBranchAdd.Name = "btnBranchAdd";
            this.btnBranchAdd.Size = new System.Drawing.Size(272, 55);
            this.btnBranchAdd.TabIndex = 3;
            this.btnBranchAdd.Text = "Branş Ekle";
            this.btnBranchAdd.UseVisualStyleBackColor = true;
            this.btnBranchAdd.Click += new System.EventHandler(this.btnBranchAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branş Adı:";
            // 
            // txtboxBranch
            // 
            this.txtboxBranch.Location = new System.Drawing.Point(45, 82);
            this.txtboxBranch.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxBranch.Name = "txtboxBranch";
            this.txtboxBranch.Size = new System.Drawing.Size(284, 30);
            this.txtboxBranch.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDoctorAdd);
            this.groupBox2.Controls.Add(this.txtboxDoctor);
            this.groupBox2.Controls.Add(this.comboboxBranch);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(409, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(372, 202);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doktor Ekle:";
            // 
            // btnDoctorAdd
            // 
            this.btnDoctorAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoctorAdd.Location = new System.Drawing.Point(40, 137);
            this.btnDoctorAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoctorAdd.Name = "btnDoctorAdd";
            this.btnDoctorAdd.Size = new System.Drawing.Size(272, 55);
            this.btnDoctorAdd.TabIndex = 3;
            this.btnDoctorAdd.Text = "Doktor Ekle";
            this.btnDoctorAdd.UseVisualStyleBackColor = true;
            this.btnDoctorAdd.Click += new System.EventHandler(this.btnDoctorAdd_Click);
            // 
            // txtboxDoctor
            // 
            this.txtboxDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxDoctor.Location = new System.Drawing.Point(40, 55);
            this.txtboxDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxDoctor.Name = "txtboxDoctor";
            this.txtboxDoctor.Size = new System.Drawing.Size(275, 26);
            this.txtboxDoctor.TabIndex = 2;
            // 
            // comboboxBranch
            // 
            this.comboboxBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboboxBranch.FormattingEnabled = true;
            this.comboboxBranch.Location = new System.Drawing.Point(40, 95);
            this.comboboxBranch.Margin = new System.Windows.Forms.Padding(4);
            this.comboboxBranch.Name = "comboboxBranch";
            this.comboboxBranch.Size = new System.Drawing.Size(275, 28);
            this.comboboxBranch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Doktor Adı ve Soyadı:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmboboxBranch);
            this.groupBox3.Controls.Add(this.dtpickerRandevu);
            this.groupBox3.Controls.Add(this.txtboxLastName);
            this.groupBox3.Controls.Add(this.cmboxDoctor);
            this.groupBox3.Controls.Add(this.txtboxFirstName);
            this.groupBox3.Controls.Add(this.txtTcNumber);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(0, 192);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(505, 358);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Bilgileri";
            // 
            // cmboboxBranch
            // 
            this.cmboboxBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmboboxBranch.FormattingEnabled = true;
            this.cmboboxBranch.Location = new System.Drawing.Point(199, 208);
            this.cmboboxBranch.Margin = new System.Windows.Forms.Padding(4);
            this.cmboboxBranch.Name = "cmboboxBranch";
            this.cmboboxBranch.Size = new System.Drawing.Size(284, 28);
            this.cmboboxBranch.TabIndex = 4;
            this.cmboboxBranch.SelectedIndexChanged += new System.EventHandler(this.cmboboxBranch_SelectedIndexChanged);
            // 
            // dtpickerRandevu
            // 
            this.dtpickerRandevu.Location = new System.Drawing.Point(199, 299);
            this.dtpickerRandevu.Margin = new System.Windows.Forms.Padding(4);
            this.dtpickerRandevu.Name = "dtpickerRandevu";
            this.dtpickerRandevu.Size = new System.Drawing.Size(284, 30);
            this.dtpickerRandevu.TabIndex = 3;
            // 
            // txtboxLastName
            // 
            this.txtboxLastName.Location = new System.Drawing.Point(199, 151);
            this.txtboxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxLastName.Name = "txtboxLastName";
            this.txtboxLastName.Size = new System.Drawing.Size(284, 30);
            this.txtboxLastName.TabIndex = 2;
            // 
            // cmboxDoctor
            // 
            this.cmboxDoctor.FormattingEnabled = true;
            this.cmboxDoctor.Location = new System.Drawing.Point(199, 254);
            this.cmboxDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.cmboxDoctor.Name = "cmboxDoctor";
            this.cmboxDoctor.Size = new System.Drawing.Size(284, 33);
            this.cmboxDoctor.TabIndex = 1;
            // 
            // txtboxFirstName
            // 
            this.txtboxFirstName.Location = new System.Drawing.Point(199, 112);
            this.txtboxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxFirstName.Name = "txtboxFirstName";
            this.txtboxFirstName.Size = new System.Drawing.Size(284, 30);
            this.txtboxFirstName.TabIndex = 2;
            // 
            // txtTcNumber
            // 
            this.txtTcNumber.Location = new System.Drawing.Point(199, 60);
            this.txtTcNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtTcNumber.Name = "txtTcNumber";
            this.txtTcNumber.Size = new System.Drawing.Size(284, 30);
            this.txtTcNumber.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 305);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Randevu Tarih:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 257);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Doktor Seçin:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 208);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Branş Seçin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tc Kimlik No:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(515, 209);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(756, 341);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 586);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBranchAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDoctorAdd;
        private System.Windows.Forms.TextBox txtboxDoctor;
        private System.Windows.Forms.ComboBox comboboxBranch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpickerRandevu;
        private System.Windows.Forms.TextBox txtboxLastName;
        private System.Windows.Forms.ComboBox cmboxDoctor;
        private System.Windows.Forms.TextBox txtboxFirstName;
        private System.Windows.Forms.TextBox txtTcNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtboxBranch;
        private System.Windows.Forms.ComboBox cmboboxBranch;
    }
}

