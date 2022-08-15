using PersonelManagerLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void temizle()
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtMaas.Text = "";
            txtSehir.Text = "";
            txtMeslek.Text = "";
            txtTelNo.Text = "";

        }
        private void kayitGetir()  //Listele
        {
            PersonelManager personelManager = new PersonelManager();
            dataGridView1.DataSource = personelManager.GetirHepsi();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.Ad = txtAd.Text;
            personel.Soyad = txtSoyad.Text;
            personel.Maas = txtMaas.Text;
            personel.Sehir = txtSehir.Text;
            personel.Meslek = txtMeslek.Text;
            personel.TelNo = txtTelNo.Text;

            PersonelManager personelManager = new PersonelManager();

            if (txtId.Text == "")
            {
                personelManager.Ekle(personel);
                lblMesaj.Text = "Personel eklendi";
                kayitGetir();
                temizle();
            }
            else
            {
                lblMesaj.Text = "Personel eklenemedi , id alanını boş bırakın";
                temizle();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.Id = Convert.ToInt32(txtId.Text);
            personel.Ad = txtAd.Text;
            personel.Soyad = txtSoyad.Text;
            personel.Maas = txtMaas.Text;
            personel.Sehir = txtSehir.Text;
            personel.Meslek = txtMeslek.Text;
            personel.TelNo = txtTelNo.Text;

            PersonelManager personelManager = new PersonelManager();

            if (personelManager.Guncelle(personel))
            {
                lblMesaj.Text = "Personel güncellendi";
                kayitGetir();
                temizle();
            }
            else
            {
                lblMesaj.Text = "Personel güncellenemedi , tekrar deneyin";
                temizle();
            }
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            PersonelManager personelManager = new PersonelManager();
            Personel personel = personelManager.GetirById(id);

            if (personel.Ad != null)
            {
                txtAd.Text = personel.Ad;
                txtSoyad.Text = personel.Soyad;
                txtMaas.Text = personel.Maas;
                txtSehir.Text = personel.Sehir;
                txtMeslek.Text = personel.Meslek;
                txtTelNo.Text = personel.TelNo;

                lblMesaj.Text = "Kayıt getirildi";
            }
            else
            {
                lblMesaj.Text = "Kayıt bulunamadı , geçerli bir id giriniz.";
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            PersonelManager personelManager = new PersonelManager();

            if (personelManager.Sil(Convert.ToInt32(txtId.Text)))
            {
                lblMesaj.Text = "Personel silindi";
                kayitGetir();
                temizle();
            }
            else
            {
                lblMesaj.Text = "Personel silinemedi , tekrar deneyin";
                temizle();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            txtMaas.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            txtSehir.Text = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secim].Cells[5].Value.ToString();
            txtTelNo.Text = dataGridView1.Rows[secim].Cells[6].Value.ToString();
        }
    }
}
