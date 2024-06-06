namespace arackiralamak
{
    partial class Sozlesme
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
            btncikis = new Button();
            musteriler = new Button();
            maskedTextBox1 = new MaskedTextBox();
            txtAdres = new TextBox();
            txtEposta = new TextBox();
            txtAdSoyad = new TextBox();
            txtTcNo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btncikis
            // 
            btncikis.Image = Properties.Resources.pngegg__5_1;
            btncikis.Location = new Point(37, 450);
            btncikis.Name = "btncikis";
            btncikis.Size = new Size(76, 60);
            btncikis.TabIndex = 19;
            btncikis.UseVisualStyleBackColor = true;
            btncikis.Click += btncikis_Click;
            // 
            // musteriler
            // 
            musteriler.Image = Properties.Resources.pngegg__10_;
            musteriler.Location = new Point(163, 302);
            musteriler.Name = "musteriler";
            musteriler.Size = new Size(76, 60);
            musteriler.TabIndex = 18;
            musteriler.UseVisualStyleBackColor = true;
            musteriler.Click += musteriler_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(163, 126);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(208, 27);
            maskedTextBox1.TabIndex = 17;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(163, 202);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(208, 81);
            txtAdres.TabIndex = 16;
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(163, 161);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(208, 27);
            txtEposta.TabIndex = 13;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(163, 90);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(208, 27);
            txtAdSoyad.TabIndex = 14;
            // 
            // txtTcNo
            // 
            txtTcNo.Location = new Point(163, 55);
            txtTcNo.Name = "txtTcNo";
            txtTcNo.Size = new Size(208, 27);
            txtTcNo.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(37, 202);
            label5.Name = "label5";
            label5.Size = new Size(66, 23);
            label5.TabIndex = 9;
            label5.Text = "Adres :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(37, 161);
            label4.Name = "label4";
            label4.Size = new Size(76, 23);
            label4.TabIndex = 10;
            label4.Text = "E Posta :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(37, 127);
            label3.Name = "label3";
            label3.Size = new Size(106, 23);
            label3.TabIndex = 11;
            label3.Text = "Telefon No :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(37, 90);
            label2.Name = "label2";
            label2.Size = new Size(97, 23);
            label2.TabIndex = 12;
            label2.Text = "Ad Soyad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 55);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 8;
            label1.Text = "TC No :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(686, 45);
            label6.Name = "label6";
            label6.Size = new Size(153, 23);
            label6.TabIndex = 20;
            label6.Text = "Ehliyet Fotokopisi";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sahte_ehliyet_bodrum1;
            pictureBox1.Location = new Point(577, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(346, 333);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // Sozlesme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1028, 554);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
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
            Name = "Sozlesme";
            Text = "Sozlesme";
            Load += Sozlesme_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncikis;
        private Button musteriler;
        private MaskedTextBox maskedTextBox1;
        private TextBox txtAdres;
        private TextBox txtEposta;
        private TextBox txtAdSoyad;
        private TextBox txtTcNo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private PictureBox pictureBox1;
    }
}