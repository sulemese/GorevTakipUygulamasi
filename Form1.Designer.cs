
namespace GörevTakipUygulaması
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGorevAdi = new System.Windows.Forms.TextBox();
            this.btnGörevEkle = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtpGorevBitisTarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pbarTamamlamaYüzdesi = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTamamlamaYuzdesi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rchmetin = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chDurum = new System.Windows.Forms.CheckBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDüzenle = new System.Windows.Forms.Button();
            this.dtpSonTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1461, 45);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(700, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "To Do List";
            // 
            // txtGorevAdi
            // 
            this.txtGorevAdi.Location = new System.Drawing.Point(20, 141);
            this.txtGorevAdi.Name = "txtGorevAdi";
            this.txtGorevAdi.Size = new System.Drawing.Size(976, 30);
            this.txtGorevAdi.TabIndex = 4;
            // 
            // btnGörevEkle
            // 
            this.btnGörevEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGörevEkle.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGörevEkle.ForeColor = System.Drawing.Color.White;
            this.btnGörevEkle.Location = new System.Drawing.Point(1219, 134);
            this.btnGörevEkle.Name = "btnGörevEkle";
            this.btnGörevEkle.Size = new System.Drawing.Size(86, 46);
            this.btnGörevEkle.TabIndex = 5;
            this.btnGörevEkle.Text = "Ekle";
            this.btnGörevEkle.UseVisualStyleBackColor = false;
            this.btnGörevEkle.Click += new System.EventHandler(this.btnGörevEkle_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // dtpGorevBitisTarih
            // 
            this.dtpGorevBitisTarih.Location = new System.Drawing.Point(1009, 139);
            this.dtpGorevBitisTarih.Name = "dtpGorevBitisTarih";
            this.dtpGorevBitisTarih.Size = new System.Drawing.Size(188, 30);
            this.dtpGorevBitisTarih.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(14, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 42);
            this.label2.TabIndex = 9;
            this.label2.Text = "Görevler";
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(22, 226);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(974, 400);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            this.listView1.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView1_ItemChecked);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // pbarTamamlamaYüzdesi
            // 
            this.pbarTamamlamaYüzdesi.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pbarTamamlamaYüzdesi.Location = new System.Drawing.Point(20, 657);
            this.pbarTamamlamaYüzdesi.Name = "pbarTamamlamaYüzdesi";
            this.pbarTamamlamaYüzdesi.Size = new System.Drawing.Size(236, 20);
            this.pbarTamamlamaYüzdesi.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbarTamamlamaYüzdesi.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(16, 631);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tamamlama Yüzdesi:";
            // 
            // lblTamamlamaYuzdesi
            // 
            this.lblTamamlamaYuzdesi.AutoSize = true;
            this.lblTamamlamaYuzdesi.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamamlamaYuzdesi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTamamlamaYuzdesi.Location = new System.Drawing.Point(206, 631);
            this.lblTamamlamaYuzdesi.Name = "lblTamamlamaYuzdesi";
            this.lblTamamlamaYuzdesi.Size = new System.Drawing.Size(37, 23);
            this.lblTamamlamaYuzdesi.TabIndex = 14;
            this.lblTamamlamaYuzdesi.Text = "%0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpSonTarih);
            this.groupBox1.Controls.Add(this.btnDüzenle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.chDurum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rchmetin);
            this.groupBox1.Location = new System.Drawing.Point(1009, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 400);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Görev";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rchmetin
            // 
            this.rchmetin.Location = new System.Drawing.Point(19, 136);
            this.rchmetin.Name = "rchmetin";
            this.rchmetin.Size = new System.Drawing.Size(373, 146);
            this.rchmetin.TabIndex = 0;
            this.rchmetin.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Durum:";
            // 
            // chDurum
            // 
            this.chDurum.AutoSize = true;
            this.chDurum.Location = new System.Drawing.Point(123, 59);
            this.chDurum.Name = "chDurum";
            this.chDurum.Size = new System.Drawing.Size(18, 17);
            this.chDurum.TabIndex = 5;
            this.chDurum.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(210, 288);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(62, 46);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDüzenle.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDüzenle.ForeColor = System.Drawing.Color.White;
            this.btnDüzenle.Location = new System.Drawing.Point(278, 288);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(112, 46);
            this.btnDüzenle.TabIndex = 18;
            this.btnDüzenle.Text = "Kaydet";
            this.btnDüzenle.UseVisualStyleBackColor = false;
            this.btnDüzenle.Click += new System.EventHandler(this.btnDüzenle_Click);
            // 
            // dtpSonTarih
            // 
            this.dtpSonTarih.Location = new System.Drawing.Point(123, 86);
            this.dtpSonTarih.Name = "dtpSonTarih";
            this.dtpSonTarih.Size = new System.Drawing.Size(269, 30);
            this.dtpSonTarih.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Son Tarih:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 696);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtGorevAdi);
            this.Controls.Add(this.btnGörevEkle);
            this.Controls.Add(this.lblTamamlamaYuzdesi);
            this.Controls.Add(this.dtpGorevBitisTarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbarTamamlamaYüzdesi);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGorevAdi;
        private System.Windows.Forms.Button btnGörevEkle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dtpGorevBitisTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ProgressBar pbarTamamlamaYüzdesi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTamamlamaYuzdesi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rchmetin;
        private System.Windows.Forms.CheckBox chDurum;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDüzenle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpSonTarih;
    }
}

