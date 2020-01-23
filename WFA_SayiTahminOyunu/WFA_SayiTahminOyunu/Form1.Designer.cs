namespace WFA_SayiTahminOyunu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_sayi = new System.Windows.Forms.TextBox();
            this.btn_tehminEt = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblTahminHakki = new System.Windows.Forms.Label();
            this.lblSeviye = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tahmin Girin : ";
            // 
            // txtbox_sayi
            // 
            this.txtbox_sayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_sayi.Location = new System.Drawing.Point(168, 41);
            this.txtbox_sayi.Name = "txtbox_sayi";
            this.txtbox_sayi.Size = new System.Drawing.Size(184, 30);
            this.txtbox_sayi.TabIndex = 1;
            // 
            // btn_tehminEt
            // 
            this.btn_tehminEt.BackColor = System.Drawing.Color.Purple;
            this.btn_tehminEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tehminEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tehminEt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_tehminEt.Location = new System.Drawing.Point(184, 77);
            this.btn_tehminEt.Name = "btn_tehminEt";
            this.btn_tehminEt.Size = new System.Drawing.Size(150, 35);
            this.btn_tehminEt.TabIndex = 2;
            this.btn_tehminEt.Text = "Tahmin Et";
            this.btn_tehminEt.UseVisualStyleBackColor = false;
            this.btn_tehminEt.Click += new System.EventHandler(this.Btn_tehminEt_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.BackColor = System.Drawing.Color.Thistle;
            this.lblSonuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonuc.Location = new System.Drawing.Point(90, 124);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(334, 105);
            this.lblSonuc.TabIndex = 3;
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTahminHakki
            // 
            this.lblTahminHakki.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblTahminHakki.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTahminHakki.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTahminHakki.Location = new System.Drawing.Point(90, 268);
            this.lblTahminHakki.Name = "lblTahminHakki";
            this.lblTahminHakki.Size = new System.Drawing.Size(113, 110);
            this.lblTahminHakki.TabIndex = 4;
            this.lblTahminHakki.Text = "5";
            this.lblTahminHakki.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeviye
            // 
            this.lblSeviye.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblSeviye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeviye.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeviye.Location = new System.Drawing.Point(311, 268);
            this.lblSeviye.Name = "lblSeviye";
            this.lblSeviye.Size = new System.Drawing.Size(113, 110);
            this.lblSeviye.TabIndex = 5;
            this.lblSeviye.Text = "1";
            this.lblSeviye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tahmin Hakkı";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seviye";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(480, 431);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSeviye);
            this.Controls.Add(this.lblTahminHakki);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btn_tehminEt);
            this.Controls.Add(this.txtbox_sayi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sayi Tahmin Oyuınu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_sayi;
        private System.Windows.Forms.Button btn_tehminEt;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblTahminHakki;
        private System.Windows.Forms.Label lblSeviye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

