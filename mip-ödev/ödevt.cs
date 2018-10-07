using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;


namespace mip_ödev
{
    public partial class Form3 : Form
    {
        Bitmap kaynak, islem;
        public Form3()
        {
            InitializeComponent();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            ImageFormat format = ImageFormat.Png;
            if (sonuc == DialogResult.OK)
            {
                islem.Save(saveFileDialog1.FileName, format);
            }
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakbox.Image = kaynak;
            }
        }

        private void lumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            islem = new Bitmap(gen, yuk);
            
            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    
                    Color lumaRenk = kaynak.GetPixel(x, y);
                    
                    int luma =(int)((lumaRenk.R*.3) + (lumaRenk.G*.59) + (lumaRenk.B*.11));
                    Color griRenk = Color.FromArgb(luma,luma,luma);
                    islem.SetPixel(x, y, griRenk);
                }
            }
            işlembox.Image = islem;
        }

        private void bt709ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            islem = new Bitmap(gen, yuk);
            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color btrenk = kaynak.GetPixel(x, y);
                    int bt_709 =(int)((btrenk.R*.2125) + (btrenk.G*.7154) + (btrenk.B*.072)) ;
                    Color griRenk = Color.FromArgb(bt_709, bt_709, bt_709);
                    islem.SetPixel(x, y, griRenk);
                }
            }
            işlembox.Image = islem;
        }

        private void ortalamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            islem = new Bitmap(gen, yuk);
            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak.GetPixel(x, y);
                    int ortalama= (renkliRenk.R + renkliRenk.G + renkliRenk.B) / 3;
                    Color griRenk = Color.FromArgb(ortalama, ortalama, ortalama);
                    islem.SetPixel(x, y, griRenk);
                }
            }
            işlembox.Image = islem;
        }
    }
}
