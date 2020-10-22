using CafeBoost.Data;
using CafeBoost.UI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeBoost.UI
{
    public partial class AnaForm : Form
    {
        int masaAdet = 20;
        KafeVeri db = new KafeVeri();
        public AnaForm()
        {
            InitializeComponent();
            OrnekUrunleriYukle();
            MasalariOlustur();
        }

        private void OrnekUrunleriYukle()
        {
            db.Urunler.Add(new Urun
            {
                UrunAd = "Kola",
                BirimFiyat = 6m
            });
            db.Urunler.Add(new Urun
            {
                UrunAd = "Ayran",
                BirimFiyat = 4m
            });
        }

        private void MasalariOlustur()
        {
            ImageList il = new ImageList();
            il.Images.Add("dolu", Resources.dolu);
            il.Images.Add("bos", Resources.bos);
            il.ImageSize = new Size(64, 64);
            lvwMasalar.LargeImageList = il;
            ListViewItem lvi;
            for (int i = 1; i <= masaAdet; i++)
            {
                lvi = new ListViewItem("Masa" + i);
                lvi.ImageKey = "bos";
                lvi.Tag = i;
                lvwMasalar.Items.Add(lvi);
            }
        }

        private void tsmiUrunler_Click(object sender, EventArgs e)
        {
            new UrunlerForm().ShowDialog();
        }

        private void tsmiGecmisSiparisler_Click(object sender, EventArgs e)
        {
            new GecmisSiparislerForm().ShowDialog();
        }

        private void lvwMasalar_DoubleClick(object sender, EventArgs e)
        {
            int masaNo = (int)lvwMasalar.SelectedItems[0].Tag;
            Siparis siparis = AktifSiparisBul(masaNo);
            if (siparis == null)
            {
                siparis = new Siparis();
                siparis.MasaNo = masaNo;
                db.AktifSiparisler.Add(siparis);
                lvwMasalar.SelectedItems[0].ImageKey = "dolu";
            }
            new SiparisForm(db,siparis).ShowDialog();
        }

        private Siparis AktifSiparisBul(int masaNo)
        {
            //foreach (var item in db.AktifSiparisler)
            //{
            //    if (item.MasaNo == )
            //    {
            //        return item;
            //    }
            //}
            //return null;
            return db.AktifSiparisler.FirstOrDefault(x => x.MasaNo == masaNo);
        }
    }
}
