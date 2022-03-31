using EF_CodeFirstMimarisi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_CodeFirstMimarisi
{
    public partial class RaporForm : Form
    {
        public RaporForm()
        {
            InitializeComponent();
        }
        NorthwindContext ctx = new NorthwindContext();
        private void RaporForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ctx.Satis_Detaylaris.Join(
                ctx.Urunlers,
                sd => sd.UrunID,
                u => u.UrunID,
                (sd, u) => new
                {
                    sd.SatisID,
                    sd.UrunID,
                    sd.BirimFiyati,
                    sd.Miktar,
                    sd.İndirim
                }).ToList();
        }

        private void btnSatisRaporu_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ctx.Urunlers.Join(
                ctx.Satis_Detaylaris,
                u => u.UrunID,
                sd => sd.UrunID,
                (u, sd) => new
                {
                    u.UrunAdi,
                    sd.İndirim,
                    sd.BirimFiyati,
                    sd.Miktar
                }).GroupBy(x => x.UrunAdi).Select(x => new
                {
                    x.Key,
                    ToplamSatisTutari = x.Sum(y => y.BirimFiyati * y.Miktar),
                    ToplamMiktar = x.Sum(y => y.Miktar)
                }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ctx.Urunlers.Join(
                ctx.Satis_Detaylaris,
                u => u.UrunID,
                sd => sd.UrunID,
                (u, sd) => new
                {
                    u.Kategoriler.KategoriAdi,
                    u.Tedarikciler.SirketAdi,
                    sd.BirimFiyati,
                    sd.Miktar,
                }).GroupBy(x => new { x.SirketAdi, x.KategoriAdi }).Select(
                x => new
                {
                    x.Key.KategoriAdi,
                    x.Key.SirketAdi,
                    ToplamTutar = x.Sum(y => y.BirimFiyati * y.Miktar),
                    ToplamMiktar = x.Sum(y => y.Miktar)
                }).ToList();

            dataGridView1.Columns["ToplamTutar"].HeaderText = "Toplam Tutar";
            dataGridView1.Columns["ToplamMiktar"].HeaderText = "Toplam Miktar";
        }
    }
}
