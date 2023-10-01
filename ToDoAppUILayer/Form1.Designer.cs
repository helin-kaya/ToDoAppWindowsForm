namespace ToDoAppUILayer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblGörev = new Label();
            lblAciklama = new Label();
            LBLtarih = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnGörevEkle = new Button();
            listBoxYapilacaklar = new ListBox();
            listBoxTamamlananlar = new ListBox();
            btnTamamlandi = new Button();
            btnGörevSil = new Button();
            lblYapilacaklar = new Label();
            lblTamamlananlar = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblGörev
            // 
            lblGörev.AutoSize = true;
            lblGörev.Location = new Point(85, 40);
            lblGörev.Name = "lblGörev";
            lblGörev.Size = new Size(38, 15);
            lblGörev.TabIndex = 0;
            lblGörev.Text = "Görev";
            // 
            // lblAciklama
            // 
            lblAciklama.AutoSize = true;
            lblAciklama.Location = new Point(85, 82);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new Size(56, 15);
            lblAciklama.TabIndex = 1;
            lblAciklama.Text = "Açıklama";
            // 
            // LBLtarih
            // 
            LBLtarih.AutoSize = true;
            LBLtarih.Location = new Point(85, 126);
            LBLtarih.Name = "LBLtarih";
            LBLtarih.Size = new Size(110, 15);
            LBLtarih.TabIndex = 2;
            LBLtarih.Text = "Tamamlanma Tarihi";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(207, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(207, 123);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // btnGörevEkle
            // 
            btnGörevEkle.Location = new Point(82, 193);
            btnGörevEkle.Name = "btnGörevEkle";
            btnGörevEkle.Size = new Size(325, 23);
            btnGörevEkle.TabIndex = 6;
            btnGörevEkle.Text = "GÖREV EKLE";
            btnGörevEkle.UseVisualStyleBackColor = true;
            btnGörevEkle.Click += btnGörevEkle_Click;
            // 
            // listBoxYapilacaklar
            // 
            listBoxYapilacaklar.FormattingEnabled = true;
            listBoxYapilacaklar.ItemHeight = 15;
            listBoxYapilacaklar.Location = new Point(48, 287);
            listBoxYapilacaklar.Name = "listBoxYapilacaklar";
            listBoxYapilacaklar.Size = new Size(166, 184);
            listBoxYapilacaklar.TabIndex = 7;
            listBoxYapilacaklar.SelectedIndexChanged += YAPILACAKLAR_SelectedIndexChanged;
            // 
            // listBoxTamamlananlar
            // 
            listBoxTamamlananlar.FormattingEnabled = true;
            listBoxTamamlananlar.ItemHeight = 15;
            listBoxTamamlananlar.Location = new Point(303, 287);
            listBoxTamamlananlar.Name = "listBoxTamamlananlar";
            listBoxTamamlananlar.Size = new Size(163, 184);
            listBoxTamamlananlar.TabIndex = 8;
            // 
            // btnTamamlandi
            // 
            btnTamamlandi.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btnTamamlandi.Location = new Point(48, 489);
            btnTamamlandi.Name = "btnTamamlandi";
            btnTamamlandi.Size = new Size(166, 23);
            btnTamamlandi.TabIndex = 9;
            btnTamamlandi.Text = "TAMAMLANDI OLARAK İŞARETLE";
            btnTamamlandi.UseVisualStyleBackColor = true;
            btnTamamlandi.Click += btnTamamlandi_Click;
            // 
            // btnGörevSil
            // 
            btnGörevSil.Location = new Point(48, 518);
            btnGörevSil.Name = "btnGörevSil";
            btnGörevSil.Size = new Size(163, 23);
            btnGörevSil.TabIndex = 10;
            btnGörevSil.Text = "GÖREVİ SİL";
            btnGörevSil.UseVisualStyleBackColor = true;
            btnGörevSil.Click += btnGörevSil_Click;
            // 
            // lblYapilacaklar
            // 
            lblYapilacaklar.AutoSize = true;
            lblYapilacaklar.Location = new Point(51, 268);
            lblYapilacaklar.Name = "lblYapilacaklar";
            lblYapilacaklar.Size = new Size(127, 15);
            lblYapilacaklar.TabIndex = 11;
            lblYapilacaklar.Text = "YAPILACAK GÖREVLER";
            // 
            // lblTamamlananlar
            // 
            lblTamamlananlar.AutoSize = true;
            lblTamamlananlar.Location = new Point(306, 268);
            lblTamamlananlar.Name = "lblTamamlananlar";
            lblTamamlananlar.Size = new Size(149, 15);
            lblTamamlananlar.TabIndex = 12;
            lblTamamlananlar.Text = "TAMAMLANAN GÖREVLER";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(507, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(544, 154);
            dataGridView1.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 623);
            Controls.Add(dataGridView1);
            Controls.Add(lblTamamlananlar);
            Controls.Add(lblYapilacaklar);
            Controls.Add(btnGörevSil);
            Controls.Add(btnTamamlandi);
            Controls.Add(listBoxTamamlananlar);
            Controls.Add(listBoxYapilacaklar);
            Controls.Add(btnGörevEkle);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(LBLtarih);
            Controls.Add(lblAciklama);
            Controls.Add(lblGörev);
            MinimumSize = new Size(5, 5);
            Name = "Form1";
            Padding = new Padding(3);
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGörev;
        private Label lblAciklama;
        private Label LBLtarih;
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private Button btnGörevEkle;
        private ListBox listBoxYapilacaklar;
        private ListBox listBoxTamamlananlar;
        private Button btnTamamlandi;
        private Button btnGörevSil;
        private Label lblYapilacaklar;
        private Label lblTamamlananlar;
        private DataGridView dataGridView1;
    }
}