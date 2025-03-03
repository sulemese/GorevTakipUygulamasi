using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GörevTakipUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string dosyaYolu = "C:\\Users\\şule meşe\\Desktop\\DERSLERİM\\C# Programlama Dili\\Uygulama Geliştirerek C# Öğrenin A'dan Z'ye Eğitim Seti Projeler\\GörevTakipUygulaması\\A.txt";
        string hataLogYolu = "C:\\Users\\şule meşe\\Desktop\\DERSLERİM\\C# Programlama Dili\\Uygulama Geliştirerek C# Öğrenin A'dan Z'ye Eğitim Seti Projeler\\GörevTakipUygulaması\\log.txt";

        private void btnGörevEkle_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (!string.IsNullOrEmpty(txtGorevAdi.Text))
                {
                    ListViewItem item = new ListViewItem(); //yeni bir listviewitem oluştur
                    item.Checked = false;
                    item.SubItems.Add(txtGorevAdi.Text);
                    item.SubItems.Add(dtpGorevBitisTarih.Text);
                    listView1.Items.Add(item);

                }
                else
                {
                    throw new ArgumentException("Görev boş geçilemez!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                File.AppendAllText(hataLogYolu, DateTime.Now + " - " + ex.Message + Environment.NewLine);
            }

        }

        private void ListViewBaşlangıçAyarlarınıYap()
        {
            listView1.Items.Clear();
            listView1.Columns.Add("Seç", 50 );
            listView1.Columns.Add("Görev Adı", 600);
            listView1.Columns.Add("Son Tarih", 200);
           

        }

        private void pbarBaşlangıçAyarlarınıYap()
        {
            pbarTamamlamaYüzdesi.Minimum = 0;
            pbarTamamlamaYüzdesi.Maximum = 100;
        }

        private void DosyadanListeyeVerileriÇek()
        {
            StreamReader dr = new StreamReader(dosyaYolu);
            
            string line;
            while ((line = dr.ReadLine()) != null)
            {
                //veriyi dosyadan çeker
                string[] gorev = line.Split('_');
                bool tamamlanmaDurum = Convert.ToBoolean(gorev[0]);
                string görevMetni = gorev[1];
                DateTime TamamlanmaTarihi = Convert.ToDateTime(gorev[2]).Date;

                //Veriyi Listview a taşır
                ListViewItem item = new ListViewItem(); 
                item.Checked = tamamlanmaDurum;
                item.SubItems.Add(görevMetni);
                item.SubItems.Add(TamamlanmaTarihi.ToString());
                listView1.Items.Add(item);
            }
            dr.Close();

        }
        private void DosyanınİçiniBoşalt()
        {
            StreamWriter sw = new StreamWriter(dosyaYolu);
            sw.Write(string.Empty);
            sw.Close();
        }

        private void VerileriListviewdenDosyayaYaz()
        {
            StreamWriter sw = new StreamWriter(dosyaYolu);
            //listview öğelerini dosyaya geçirir
            foreach (ListViewItem item in listView1.Items)
            {
                string tamamlanmaDurum = item.Checked.ToString();
                string gorevMetni = item.SubItems[1].Text;
                string gorevTamamlanmaTarih = item.SubItems[2].Text;
                sw.WriteLine(tamamlanmaDurum + "_" + gorevMetni + "_" + gorevTamamlanmaTarih);
            }
            sw.Close();
        }
        private void TamamlanmaYüzdesiniHesapla()
        {
            int seçilenGörevSayısı = 0;
            int tümGörevSayısı = listView1.Items.Count;
            foreach (ListViewItem x in listView1.Items)
            {
                if (x.Checked)
                {
                    seçilenGörevSayısı++;
                }
            }
            if (tümGörevSayısı > 0)
            {
                pbarTamamlamaYüzdesi.Value = (seçilenGörevSayısı * 100) / tümGörevSayısı;
            }
            else
            {
                pbarTamamlamaYüzdesi.Value = 0;
            }
            lblTamamlamaYuzdesi.Text = "%" + pbarTamamlamaYüzdesi.Value;



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewBaşlangıçAyarlarınıYap();
            pbarBaşlangıçAyarlarınıYap();
            DosyadanListeyeVerileriÇek();
            SüresiGeçenGörevleriVurgula();
            
        }      
        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                e.Item.SubItems[0].Font = new Font(e.Item.SubItems[0].Font, FontStyle.Strikeout);
            }
            else
            {
                e.Item.SubItems[0].Font = new Font(e.Item.SubItems[0].Font, FontStyle.Regular);
            }
            TamamlanmaYüzdesiniHesapla();
        }

       private void SüresiGeçenGörevleriVurgula()
        {
            DateTime bugününTarihi = DateTime.Now.Date;
            DateTime görevBitişTarihi;

            foreach (ListViewItem item in listView1.Items)
            {
                görevBitişTarihi = Convert.ToDateTime(item.SubItems[2].Text);
                if (bugününTarihi>görevBitişTarihi)
                {
                    item.ForeColor = Color.Red;
                }
                else
                {
                    item.ForeColor = Color.Black;
                }
            }


        }

      
       



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DosyanınİçiniBoşalt();
            VerileriListviewdenDosyayaYaz();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TıklananGöreviGroupboxaTaşı()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                chDurum.Checked = selectedItem.Checked;
                dtpSonTarih.Text = selectedItem.SubItems[2].Text;
                rchmetin.Text = selectedItem.SubItems[1].Text;
            }
        }
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            TıklananGöreviGroupboxaTaşı();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            TıklananGöreviGroupboxaTaşı();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            listView1.Items.Remove(item);
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            item.Checked = chDurum.Checked;
            item.SubItems[1].Text = rchmetin.Text;
            item.SubItems[2].Text = dtpSonTarih.Text;
            SüresiGeçenGörevleriVurgula();

        }
    }
}
