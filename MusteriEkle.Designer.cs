namespace arackiralamak
{
    partial class MusteriEkle
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
            txtTcNo = new TextBox();
            txtAdSoyad = new TextBox();
            txtEposta = new TextBox();
            txtAdres = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            musteriler = new Button();
            btncikis = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 18);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 0;
            label1.Text = "TC No :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 53);
            label2.Name = "label2";
            label2.Size = new Size(97, 23);
            label2.TabIndex = 1;
            label2.Text = "Ad Soyad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 90);
            label3.Name = "label3";
            label3.Size = new Size(106, 23);
            label3.TabIndex = 1;
            label3.Text = "Telefon No :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(23, 124);
            label4.Name = "label4";
            label4.Size = new Size(76, 23);
            label4.TabIndex = 1;
            label4.Text = "E Posta :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(23, 165);
            label5.Name = "label5";
            label5.Size = new Size(66, 23);
            label5.TabIndex = 1;
            label5.Text = "Adres :";
            // 
            // txtTcNo
            // 
            txtTcNo.Location = new Point(149, 18);
            txtTcNo.Name = "txtTcNo";
            txtTcNo.Size = new Size(208, 27);
            txtTcNo.TabIndex = 2;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(149, 53);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(208, 27);
            txtAdSoyad.TabIndex = 2;
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(149, 124);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(208, 27);
            txtEposta.TabIndex = 2;
            txtEposta.TextChanged += textBox3_TextChanged;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(149, 165);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(208, 81);
            txtAdres.TabIndex = 4;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(149, 89);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(208, 27);
            maskedTextBox1.TabIndex = 5;
            // 
            // musteriler
            // 
            musteriler.Image = Properties.Resources.pngegg__10_;
            musteriler.Location = new Point(149, 265);
            musteriler.Name = "musteriler";
            musteriler.Size = new Size(76, 60);
            musteriler.TabIndex = 6;
            musteriler.UseVisualStyleBackColor = true;
            musteriler.Click += btnKaydet_Click;
            // 
            // btncikis
            // 
            btncikis.Image = Properties.Resources.pngegg__5_1;
            btncikis.Location = new Point(23, 413);
            btncikis.Name = "btncikis";
            btncikis.Size = new Size(76, 60);
            btncikis.TabIndex = 7;
            btncikis.UseVisualStyleBackColor = true;
            btncikis.Click += btncikis_Click;
            // 
            // MusteriEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(596, 498);
            Controls.Add(btncikis);
            Controls.Add(musteriler);
            Controls.Add(maskedTextBox1);
            Controls.Add(txtAdres);
            Controls.Add(txtEposta);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtTcNo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MusteriEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MusteriEkle";
            Load += MusteriEkle_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTcNo;
        private TextBox txtAdSoyad;
        private TextBox txtEposta;
        private TextBox txtAdres;
        private MaskedTextBox maskedTextBox1;
        private Button musteriler;
        private Button btncikis;
    }
}