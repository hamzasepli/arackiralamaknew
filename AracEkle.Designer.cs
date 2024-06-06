namespace arackiralamak
{
    partial class AracEkle
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtPlaka = new TextBox();
            txtModel = new TextBox();
            txtRenk = new TextBox();
            txtKm = new TextBox();
            txtUcret = new TextBox();
            cbxMarka = new ComboBox();
            cbxSeri = new ComboBox();
            cbxYakit = new ComboBox();
            cbxDurum = new ComboBox();
            btnKaydet = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 31);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 0;
            label1.Text = "Plaka :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 69);
            label2.Name = "label2";
            label2.Size = new Size(71, 23);
            label2.TabIndex = 0;
            label2.Text = "Marka :";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(35, 105);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 0;
            label3.Text = "Seri :";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(35, 143);
            label4.Name = "label4";
            label4.Size = new Size(71, 23);
            label4.TabIndex = 0;
            label4.Text = "Model :";
            label4.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(35, 190);
            label5.Name = "label5";
            label5.Size = new Size(60, 23);
            label5.TabIndex = 0;
            label5.Text = "Renk :";
            label5.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(35, 234);
            label6.Name = "label6";
            label6.Size = new Size(99, 23);
            label6.TabIndex = 0;
            label6.Text = "Kilometre :";
            label6.Click += label1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(39, 276);
            label7.Name = "label7";
            label7.Size = new Size(59, 23);
            label7.TabIndex = 0;
            label7.Text = "Yakıt :";
            label7.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(35, 317);
            label8.Name = "label8";
            label8.Size = new Size(105, 23);
            label8.TabIndex = 0;
            label8.Text = "Kira Ücreti :";
            label8.Click += label1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(35, 370);
            label9.Name = "label9";
            label9.Size = new Size(86, 23);
            label9.TabIndex = 0;
            label9.Text = "Durumu :";
            label9.Click += label1_Click;
            // 
            // txtPlaka
            // 
            txtPlaka.Location = new Point(161, 31);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(170, 27);
            txtPlaka.TabIndex = 1;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(161, 148);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(170, 27);
            txtModel.TabIndex = 1;
            // 
            // txtRenk
            // 
            txtRenk.Location = new Point(161, 190);
            txtRenk.Name = "txtRenk";
            txtRenk.Size = new Size(170, 27);
            txtRenk.TabIndex = 1;
            // 
            // txtKm
            // 
            txtKm.Location = new Point(161, 234);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(170, 27);
            txtKm.TabIndex = 1;
            // 
            // txtUcret
            // 
            txtUcret.Location = new Point(161, 317);
            txtUcret.Name = "txtUcret";
            txtUcret.Size = new Size(170, 27);
            txtUcret.TabIndex = 1;
            // 
            // cbxMarka
            // 
            cbxMarka.FormattingEnabled = true;
            cbxMarka.Items.AddRange(new object[] { "Audi", "Bmw", "Mercedes", "Chery" });
            cbxMarka.Location = new Point(161, 68);
            cbxMarka.Name = "cbxMarka";
            cbxMarka.Size = new Size(170, 28);
            cbxMarka.TabIndex = 2;
            cbxMarka.SelectedIndexChanged += cbxMarka_SelectedIndexChanged;
            // 
            // cbxSeri
            // 
            cbxSeri.FormattingEnabled = true;
            cbxSeri.Location = new Point(161, 108);
            cbxSeri.Name = "cbxSeri";
            cbxSeri.Size = new Size(170, 28);
            cbxSeri.TabIndex = 2;
            // 
            // cbxYakit
            // 
            cbxYakit.FormattingEnabled = true;
            cbxYakit.Items.AddRange(new object[] { "Dizel", "Benin", "Elektirikli" });
            cbxYakit.Location = new Point(161, 275);
            cbxYakit.Name = "cbxYakit";
            cbxYakit.Size = new Size(170, 28);
            cbxYakit.TabIndex = 2;
            // 
            // cbxDurum
            // 
            cbxDurum.FormattingEnabled = true;
            cbxDurum.Items.AddRange(new object[] { "Boş", "Dolu" });
            cbxDurum.Location = new Point(161, 365);
            cbxDurum.Name = "cbxDurum";
            cbxDurum.Size = new Size(170, 28);
            cbxDurum.TabIndex = 2;
            // 
            // btnKaydet
            // 
            btnKaydet.Image = Properties.Resources.pngegg__10_1;
            btnKaydet.Location = new Point(383, 317);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 77);
            btnKaydet.TabIndex = 3;
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnExit
            // 
            btnExit.Image = Properties.Resources.pngegg__5_2;
            btnExit.Location = new Point(4, 422);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 77);
            btnExit.TabIndex = 3;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // AracEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(873, 511);
            Controls.Add(btnExit);
            Controls.Add(btnKaydet);
            Controls.Add(cbxDurum);
            Controls.Add(cbxYakit);
            Controls.Add(cbxSeri);
            Controls.Add(cbxMarka);
            Controls.Add(txtUcret);
            Controls.Add(txtKm);
            Controls.Add(txtRenk);
            Controls.Add(txtModel);
            Controls.Add(txtPlaka);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AracEkle";
            Text = "AracEkle";
            Load += AracEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtPlaka;
        private TextBox txtModel;
        private TextBox txtRenk;
        private TextBox txtKm;
        private TextBox txtUcret;
        private ComboBox cbxMarka;
        private ComboBox cbxSeri;
        private ComboBox cbxYakit;
        private ComboBox cbxDurum;
        private Button btnKaydet;
        private Button btnExit;
    }
}