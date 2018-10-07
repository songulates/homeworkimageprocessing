using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mip_ödev
{
    public partial class Form2 : Form
    {
        Bitmap kaynak;
        public Form2()
        {
            InitializeComponent();
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

        private void renkalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = int.Parse(xkord.Text);
            
            int y = int.Parse(ykord.Text);
            Color rengim = kaynak.GetPixel(x, y); //rengim=seçilen
            renkbox.BackColor = rengim;
            Console.WriteLine("R: " + rengim.R + " G: " + rengim.G + " B: " + rengim.B);
        }
    }
}
