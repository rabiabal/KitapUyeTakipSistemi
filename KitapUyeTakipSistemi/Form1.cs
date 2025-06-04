using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapUyeTakipSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Kitap> kitaplar = new List<Kitap>();
        List<Uye> uyeler = new List<Uye>();
        List<BorcKitap> borcKitaplar = new List<BorcKitap>();
        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string kitapAdi = txtKitapAdi.Text;
                string yazarAdi = txtYazarAdi.Text;
                int sayfaSayisi = int.Parse(txtSayfaSayisi.Text);

                Kitap kitap = new Kitap(kitapAdi, yazarAdi, sayfaSayisi);
                kitaplar.Add(kitap);
                listBoxKitap.Items.Add(kitap);

                txtKitapAdi.Clear();
                txtYazarAdi.Clear();
                txtSayfaSayisi.Clear();
            }
            catch
            {
                MessageBox.Show("Sayfa sayısı yalnızca sayı olmalıdır.");
            }
        }
        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            
        {
            string ad = txtUyeAdi.Text;
            string soyad = txtUyeSoyadi.Text;
            string tc = txtUyeTc.Text;

            Uye uye = new Uye(ad, soyad, tc);
            uyeler.Add(uye);
            listBoxUye.Items.Add(uye);

            txtUyeAdi.Clear();
            txtUyeSoyadi.Clear();
            txtUyeTc.Clear();
        }
    }
      
        private void btnBorcVer_Click(object sender, EventArgs e)
        {
            if (listBoxKitap.SelectedItem == null || listBoxUye.SelectedItem == null)
            {
                MessageBox.Show("Lütfen hem bir kitap hem bir üye seçiniz.");
                return;
            }

            Kitap secilenKitap = (Kitap)listBoxKitap.SelectedItem;
            Uye secilenUye = (Uye)listBoxUye.SelectedItem;

            BorcKitap borc = new BorcKitap(secilenUye.UyeTC, secilenKitap.KitapAdi);
            borcKitaplar.Add(borc);
            listBoxAlacak.Items.Add(borc);

            
            kitaplar.Remove(secilenKitap);
            uyeler.Remove(secilenUye);
            listBoxKitap.Items.Remove(secilenKitap);
            listBoxUye.Items.Remove(secilenUye);

            
            lblAlacakAdet.Text = listBoxAlacak.Items.Count.ToString();
        }
    }
    }
    

