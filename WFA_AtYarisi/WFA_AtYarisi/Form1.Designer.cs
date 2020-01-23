namespace WFA_AtYarisi
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.pbat1 = new System.Windows.Forms.PictureBox();
            this.pbat2 = new System.Windows.Forms.PictureBox();
            this.pbat3 = new System.Windows.Forms.PictureBox();
            this.btnBasla = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblsonuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbat3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-5, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1093, 37);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(-5, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1093, 37);
            this.label2.TabIndex = 1;
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.Color.Crimson;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFinish.Location = new System.Drawing.Point(1082, 69);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(57, 310);
            this.lblFinish.TabIndex = 2;
            this.lblFinish.Text = "FINISH";
            this.lblFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbat1
            // 
            this.pbat1.BackColor = System.Drawing.Color.Transparent;
            this.pbat1.Image = global::WFA_AtYarisi.Properties.Resources.ganyan;
            this.pbat1.Location = new System.Drawing.Point(-2, 69);
            this.pbat1.Name = "pbat1";
            this.pbat1.Size = new System.Drawing.Size(100, 76);
            this.pbat1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbat1.TabIndex = 3;
            this.pbat1.TabStop = false;
            // 
            // pbat2
            // 
            this.pbat2.BackColor = System.Drawing.Color.Transparent;
            this.pbat2.Image = global::WFA_AtYarisi.Properties.Resources._5139947333409;
            this.pbat2.Location = new System.Drawing.Point(-2, 188);
            this.pbat2.Name = "pbat2";
            this.pbat2.Size = new System.Drawing.Size(100, 76);
            this.pbat2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbat2.TabIndex = 4;
            this.pbat2.TabStop = false;
            // 
            // pbat3
            // 
            this.pbat3.BackColor = System.Drawing.Color.Transparent;
            this.pbat3.Image = global::WFA_AtYarisi.Properties.Resources.hrs;
            this.pbat3.Location = new System.Drawing.Point(-2, 307);
            this.pbat3.Name = "pbat3";
            this.pbat3.Size = new System.Drawing.Size(100, 72);
            this.pbat3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbat3.TabIndex = 5;
            this.pbat3.TabStop = false;
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.Transparent;
            this.btnBasla.Location = new System.Drawing.Point(-2, 515);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(141, 36);
            this.btnBasla.TabIndex = 6;
            this.btnBasla.Text = "BAŞLA";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.BtnBasla_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblsonuc
            // 
            this.lblsonuc.Location = new System.Drawing.Point(145, 515);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(338, 139);
            this.lblsonuc.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WFA_AtYarisi.Properties.Resources.area1;
            this.ClientSize = new System.Drawing.Size(1137, 656);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.pbat3);
            this.Controls.Add(this.pbat2);
            this.Controls.Add(this.pbat1);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AtYarisi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbat3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.PictureBox pbat1;
        private System.Windows.Forms.PictureBox pbat2;
        private System.Windows.Forms.PictureBox pbat3;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblsonuc;
    }
}

