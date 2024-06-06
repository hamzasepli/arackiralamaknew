namespace arackiralamak
{
    partial class AracListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracListele));
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            btnExit = new Button();
            btnGuncelle = new Button();
            cbxDurum = new ComboBox();
            cbxYakit = new ComboBox();
            cbxSeri = new ComboBox();
            cbxMarka = new ComboBox();
            txtUcret = new TextBox();
            txtKm = new TextBox();
            txtRenk = new TextBox();
            txtModel = new TextBox();
            txtPlaka = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(395, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(750, 492);
            dataGridView1.TabIndex = 31;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.pngegg__6_;
            btnDelete.Location = new Point(270, 417);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 67);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Sil";
            btnDelete.TextAlign = ContentAlignment.BottomCenter;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(4, 417);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(108, 67);
            btnExit.TabIndex = 29;
            btnExit.TextAlign = ContentAlignment.BottomCenter;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Image = Properties.Resources.pngegg__8_;
            btnGuncelle.Location = new Point(139, 417);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(108, 67);
            btnGuncelle.TabIndex = 30;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.TextAlign = ContentAlignment.BottomCenter;
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // cbxDurum
            // 
            cbxDurum.FormattingEnabled = true;
            cbxDurum.Items.AddRange(new object[] { "Boş", "Dolu" });
            cbxDurum.Location = new Point(139, 346);
            cbxDurum.Name = "cbxDurum";
            cbxDurum.Size = new Size(170, 28);
            cbxDurum.TabIndex = 49;
            // 
            // cbxYakit
            // 
            cbxYakit.FormattingEnabled = true;
            cbxYakit.Items.AddRange(new object[] { "Dizel", "Benin", "Elektirikli" });
            cbxYakit.Location = new Point(139, 257);
            cbxYakit.Name = "cbxYakit";
            cbxYakit.Size = new Size(170, 28);
            cbxYakit.TabIndex = 48;
            // 
            // cbxSeri
            // 
            cbxSeri.FormattingEnabled = true;
            cbxSeri.Location = new Point(139, 89);
            cbxSeri.Name = "cbxSeri";
            cbxSeri.Size = new Size(170, 28);
            cbxSeri.TabIndex = 47;
            // 
            // cbxMarka
            // 
            cbxMarka.FormattingEnabled = true;
            cbxMarka.Items.AddRange(new object[] { "Audi", "Bmw", "Mercedes", "Chery" });
            cbxMarka.Location = new Point(139, 49);
            cbxMarka.Name = "cbxMarka";
            cbxMarka.Size = new Size(170, 28);
            cbxMarka.TabIndex = 46;
            cbxMarka.SelectedIndexChanged += cbxMarka_SelectedIndexChanged;
            // 
            // txtUcret
            // 
            txtUcret.Location = new Point(139, 298);
            txtUcret.Name = "txtUcret";
            txtUcret.Size = new Size(170, 27);
            txtUcret.TabIndex = 44;
            // 
            // txtKm
            // 
            txtKm.Location = new Point(139, 215);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(170, 27);
            txtKm.TabIndex = 43;
            // 
            // txtRenk
            // 
            txtRenk.Location = new Point(139, 171);
            txtRenk.Name = "txtRenk";
            txtRenk.Size = new Size(170, 27);
            txtRenk.TabIndex = 42;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(139, 129);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(170, 27);
            txtModel.TabIndex = 45;
            // 
            // txtPlaka
            // 
            txtPlaka.Location = new Point(139, 12);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(170, 27);
            txtPlaka.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(13, 351);
            label9.Name = "label9";
            label9.Size = new Size(86, 23);
            label9.TabIndex = 39;
            label9.Text = "Durumu :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(13, 298);
            label8.Name = "label8";
            label8.Size = new Size(105, 23);
            label8.TabIndex = 38;
            label8.Text = "Kira Ücreti :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(17, 257);
            label7.Name = "label7";
            label7.Size = new Size(59, 23);
            label7.TabIndex = 37;
            label7.Text = "Yakıt :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(13, 215);
            label6.Name = "label6";
            label6.Size = new Size(99, 23);
            label6.TabIndex = 36;
            label6.Text = "Kilometre :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(13, 171);
            label5.Name = "label5";
            label5.Size = new Size(60, 23);
            label5.TabIndex = 35;
            label5.Text = "Renk :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(13, 124);
            label4.Name = "label4";
            label4.Size = new Size(71, 23);
            label4.TabIndex = 34;
            label4.Text = "Model :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 86);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 33;
            label3.Text = "Seri :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 50);
            label2.Name = "label2";
            label2.Size = new Size(71, 23);
            label2.TabIndex = 40;
            label2.Text = "Marka :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 32;
            label1.Text = "Plaka :";
            // 
            // AracListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1157, 521);
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
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnExit);
            Controls.Add(btnGuncelle);
            Name = "AracListele";
            Text = "AracListele";
            Load += AracListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnDelete;
        private Button btnExit;
        private Button btnGuncelle;
        private ComboBox cbxDurum;
        private ComboBox cbxYakit;
        private ComboBox cbxSeri;
        private ComboBox cbxMarka;
        private TextBox txtUcret;
        private TextBox txtKm;
        private TextBox txtRenk;
        private TextBox txtModel;
        private TextBox txtPlaka;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}