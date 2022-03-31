using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF_CodeFirstMimarisi.Models;

namespace EF_CodeFirstMimarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindContext ctx = new NorthwindContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            UrunListele();

            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.ValueMember = "KategoriID";
            cmbKategori.DataSource = ctx.Kategorilers.ToList();

            cmbTedarikci.DisplayMember = "SirketAdi";
            cmbTedarikci.ValueMember = "TedarikciID";
            cmbTedarikci.DataSource = ctx.Tedarikcilers.ToList();
        }

        void UrunListele()
        {
            var sonuc = ctx.Urunlers.Join(
                    ctx.Kategorilers,
                    u => u.KategoriID,
                    k => k.KategoriID,
                    (urun, ktg) => new
                    {
                        urun.UrunID,
                        urun.TedarikciID,
                        urun.UrunAdi,
                        urun.BirimFiyati,
                        urun.HedefStokDuzeyi,
                        ktg.KategoriAdi,
                        ktg.KategoriID
                    }).Join(
                    ctx.Tedarikcilers,
                    uk => uk.TedarikciID,
                    t => t.TedarikciID,
                    (uk, t) => new
                    {
                        uk.UrunID,
                        uk.UrunAdi,
                        uk.BirimFiyati,
                        uk.HedefStokDuzeyi,
                        uk.KategoriAdi,
                        t.SirketAdi,
                        uk.TedarikciID,
                        uk.KategoriID
                    }).OrderBy(x => x.UrunID).ToList();

            dataGridView1.DataSource = sonuc;
            dataGridView1.Columns["TedarikciID"].Visible = false;
            dataGridView1.Columns["KategoriID"].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler();
            u.UrunAdi = txtUrunAdi.Text;
            u.BirimFiyati = nudFiyat.Value;
            u.HedefStokDuzeyi = Convert.ToInt16(nudStok.Value);
            u.KategoriID = (int)cmbKategori.SelectedValue;
            u.TedarikciID = (int)cmbTedarikci.SelectedValue;

            ctx.Urunlers.Add(u);
            ctx.SaveChanges();
            dataGridView1.DataSource = ctx.Urunlers.ToList();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string ara = txtAra.Text;
            dataGridView1.DataSource = ctx.Urunlers.Where(x => x.UrunAdi.Contains(ara)).ToList();
        }

        private void rdbArtan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbArtan.Checked)
            {
                dataGridView1.DataSource = ctx.Urunlers.OrderBy(x => x.BirimFiyati).ToList();
            }
        }

        private void rdbAzalan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAzalan.Checked)
            {
                dataGridView1.DataSource = ctx.Urunlers.OrderByDescending(x => x.BirimFiyati).ToList();
            }
        }

        private void btnIlkOnKayit_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ctx.Urunlers.Take(10).ToList();
        }

        private void btnSonOnKayit_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ctx.Urunlers.OrderByDescending(x => x.BirimFiyati).Take(10).ToList();
        }

        private void btnRaporForm_Click(object sender, EventArgs e)
        {
            RaporForm rf = new RaporForm();
            rf.ShowDialog();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["UrunID"].Value;
                Urunler u = ctx.Urunlers.FirstOrDefault(x => x.UrunID == id);
                ctx.Urunlers.Remove(u);
                ctx.SaveChanges();
                UrunListele();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txtUrunAdi.Text = row.Cells["UrunAdi"].Value.ToString();
            nudFiyat.Value = (decimal)row.Cells["BirimFiyati"].Value;
            nudStok.Value = Convert.ToDecimal(row.Cells["HedefStokDuzeyi"].Value);
            cmbKategori.SelectedValue = row.Cells["KategoriID"].Value;
            cmbTedarikci.SelectedValue = row.Cells["TedarikciID"].Value;
            txtUrunAdi.Tag = row.Cells["UrunID"].Value;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Urunler u = ctx.Urunlers.FirstOrDefault(x => x.UrunID == (int)txtUrunAdi.Tag);
            u.UrunAdi = txtUrunAdi.Text;
            u.BirimFiyati = nudFiyat.Value;
            u.HedefStokDuzeyi = Convert.ToInt16(nudStok.Value);
            u.KategoriID = (int)cmbKategori.SelectedValue;
            u.TedarikciID = (int)cmbTedarikci.SelectedValue;

            ctx.SaveChanges();
            UrunListele();
        }
    }
}
