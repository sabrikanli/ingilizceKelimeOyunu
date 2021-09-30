using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ingilizceKelimeOyunu
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = (button1.BackgroundImage == button30.BackgroundImage ? button31.BackgroundImage : button30.BackgroundImage);
            textBox1.PasswordChar = textBox1.PasswordChar == '\0' ? '*' : '\0';
        }
    }
    public class BitmapFilter2
    {
        private static bool Conv3x32(Bitmap b, ConvMatrix m)
        {
            // Avoid divide by zero errors
            if (0 == m.Factor2) return false;

            Bitmap bSrc = (Bitmap)b.Clone();

            // GDI+ still lies to us - the return format is BGR, NOT RGB.
            BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmSrc = bSrc.LockBits(new Rectangle(0, 0, bSrc.Width, bSrc.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = bmData.Stride;
            int stride2 = stride * 2;
            System.IntPtr Scan0 = bmData.Scan0;
            System.IntPtr SrcScan0 = bmSrc.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                byte* pSrc = (byte*)(void*)SrcScan0;

                int nOffset = stride + 6 - b.Width * 3;
                int nWidth = b.Width - 2;
                int nHeight = b.Height - 2;

                int nPixel;

                for (int y = 0; y < nHeight; ++y)
                {
                    for (int x = 0; x < nWidth; ++x)
                    {
                        nPixel = ((((pSrc[2] * m.TopLeft2) + (pSrc[5] * m.TopMid2) + (pSrc[8] * m.TopRight2) +
                            (pSrc[2 + stride] * m.MidLeft2) + (pSrc[5 + stride] * m.Pixel2) + (pSrc[8 + stride] * m.MidRight2) +
                            (pSrc[2 + stride2] * m.BottomLeft2) + (pSrc[5 + stride2] * m.BottomMid2) + (pSrc[8 + stride2] * m.BottomRight2)) / m.Factor2) + m.Offset2);

                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;

                        p[5 + stride] = (byte)nPixel;

                        nPixel = ((((pSrc[1] * m.TopLeft2) + (pSrc[4] * m.TopMid2) + (pSrc[7] * m.TopRight2) +
                            (pSrc[1 + stride] * m.MidLeft2) + (pSrc[4 + stride] * m.Pixel2) + (pSrc[7 + stride] * m.MidRight2) +
                            (pSrc[1 + stride2] * m.BottomLeft2) + (pSrc[4 + stride2] * m.BottomMid2) + (pSrc[7 + stride2] * m.BottomRight2)) / m.Factor2) + m.Offset2);

                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;

                        p[4 + stride] = (byte)nPixel;

                        nPixel = ((((pSrc[0] * m.TopLeft2) + (pSrc[3] * m.TopMid2) + (pSrc[6] * m.TopRight2) +
                            (pSrc[0 + stride] * m.MidLeft2) + (pSrc[3 + stride] * m.Pixel2) + (pSrc[6 + stride] * m.MidRight2) +
                            (pSrc[0 + stride2] * m.BottomLeft2) + (pSrc[3 + stride2] * m.BottomMid2) + (pSrc[6 + stride2] * m.BottomRight2)) / m.Factor2) + m.Offset2);

                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;

                        p[3 + stride] = (byte)nPixel;

                        p += 3;
                        pSrc += 3;
                    }

                    p += nOffset;
                    pSrc += nOffset;
                }
            }

            b.UnlockBits(bmData);
            bSrc.UnlockBits(bmSrc);

            return true;
        }

        public static bool GaussianBlur2(Bitmap b, int nWeight /* default to 4*/)
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll2(1);
            m.Pixel2 = nWeight;
            m.TopMid2 = m.MidLeft2 = m.MidRight2 = m.BottomMid2 = 2;
            m.Factor2 = nWeight + 12;

            return BitmapFilter2.Conv3x32(b, m);
        }

        public class ConvMatrix
        {
            public int TopLeft2 = 0, TopMid2 = 0, TopRight2 = 0;
            public int MidLeft2 = 0, Pixel2 = 1, MidRight2 = 0;
            public int BottomLeft2 = 0, BottomMid2 = 0, BottomRight2 = 0;
            public int Factor2 = 1;
            public int Offset2 = 0;
            public void SetAll2(int nVal)
            {
                TopLeft2 = TopMid2 = TopRight2 = MidLeft2 = Pixel2 = MidRight2 = BottomLeft2 = BottomMid2 = BottomRight2 = nVal;
            }
        }
    }

    class Screenshot2
    {
        public static Bitmap TakeSnapshot2(Control ctl)
        {
            Bitmap bmp = new Bitmap(ctl.Size.Width, ctl.Size.Height);
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bmp);
            g.CopyFromScreen(ctl.PointToScreen(ctl.ClientRectangle.Location), new Point(0, 0), ctl.ClientRectangle.Size);
            return bmp;
        }
    }
}
