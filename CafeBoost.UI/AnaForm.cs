﻿using CafeBoost.Data;
using CafeBoost.UI.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeBoost.UI
{
    public partial class AnaForm : Form
    {
        CafeBoostContext db = new CafeBoostContext();
        public AnaForm()
        {
            InitializeComponent();
            MasalariOlustur();
        }

        private void MasalariOlustur()
        {
            ImageList il = new ImageList();
            il.Images.Add("dolu", Resources.dolu);
            il.Images.Add("bos", Resources.bos);
            il.ImageSize = new Size(64, 64);
            lvwMasalar.LargeImageList = il;
            ListViewItem lvi;
            for (int i = 1; i <= db.MasaAdet; i++)
            {
                lvi = new ListViewItem("Masa" + i);
                lvi.ImageKey = db.Siparisler.Any(x => x.MasaNo == i && x.Durum == SiparisDurum.Aktif) ? "dolu" : "bos";
                lvi.Tag = i;
                lvwMasalar.Items.Add(lvi);
            }
        }

        private void tsmiUrunler_Click(object sender, EventArgs e)
        {
            new UrunlerForm(db).ShowDialog();
        }

        private void tsmiGecmisSiparisler_Click(object sender, EventArgs e)
        {
            new GecmisSiparislerForm(db).ShowDialog();
        }

        private void lvwMasalar_DoubleClick(object sender, EventArgs e)
        {
            int masaNo = (int)lvwMasalar.SelectedItems[0].Tag;
            Siparis siparis = AktifSiparisBul(masaNo);
            if (siparis == null)
            {
                siparis = new Siparis();
                siparis.MasaNo = masaNo;
                db.Siparisler.Add(siparis);
                db.SaveChanges();
                lvwMasalar.SelectedItems[0].ImageKey = "dolu";
            }
            SiparisForm frmSiparis = new SiparisForm(db, siparis);
            frmSiparis.MasaTasindi += FrmSiparis_MasaTasindi;
            DialogResult dr = frmSiparis.ShowDialog();
            if (dr == DialogResult.OK)
            {
                lvwMasalar.SelectedItems[0].ImageKey = "bos";
            }
        }

        private void FrmSiparis_MasaTasindi(object sender, MasaTasimaEventArgs e)
        {
            MasaTasi(e.EskiMasaNo, e.YeniMasaNo);
        }

        private Siparis AktifSiparisBul(int masaNo)
        {
            return db.Siparisler.FirstOrDefault(x => x.MasaNo == masaNo && x.Durum == SiparisDurum.Aktif);
        }
        private void MasaTasi(int kaynak, int hedef)
        {
            foreach (ListViewItem item in lvwMasalar.Items)
            {
                if ((int)item.Tag == kaynak)
                {
                    item.ImageKey = "bos";
                    item.Selected = false;
                }
                if ((int)item.Tag == hedef)
                {
                    item.ImageKey = "dolu";
                    item.Selected = true;
                }
            }
        }


     
    }
}
