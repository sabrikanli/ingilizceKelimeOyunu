using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ingilizceKelimeOyunu
{
    public partial class Form5 : Form
    {
        string Group = null;
        int Language = 1;
        string Point = null;
        Form2 FormTwo = null;
        public Form5(Form2 Form, string group, string point, int language)
        {
            Group = group;
            FormTwo = Form;
            Point = point;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (Language == 1)
            {
                label1.Text = String.Format("{0}. Grup", Group);
                label1.RightToLeft = RightToLeft.No;
                label2.Text = "Tamam'a bastığınızda Ana Menü'ye yönlendirileceksiniz.";
                label2.RightToLeft = RightToLeft.No;
                label5.Text = Point;
                label5.RightToLeft = RightToLeft.No;
                button3.Text = "Tamam";
                button3.RightToLeft = RightToLeft.No;
            } 
            else if (Language == 2)
            {
                label1.Text = String.Format("{0}. Group", Group);
                label1.RightToLeft = RightToLeft.No;
                label2.Text = "When you press OK button, you will be directed to the Main Menu.";
                label2.RightToLeft = RightToLeft.No;
                label5.Text = Point;
                label5.RightToLeft = RightToLeft.No;
                button3.Text = "OK";
                button3.RightToLeft = RightToLeft.No;
            }
            else if (Language == 3)
            {
                label1.Text = String.Format("{0}. المجموعة", Group);
                label1.RightToLeft = RightToLeft.Yes;
                label2.Text = "عندما تضغط على زر موافق ، سيتم توجيهك إلى القائمة الرئيسية.";
                label2.RightToLeft = RightToLeft.Yes;
                label5.Text = Point;
                label5.RightToLeft = RightToLeft.Yes;
                button3.Text = "نعم";
                button3.RightToLeft = RightToLeft.Yes;
            }
            else if (Language == 4)
            {
                label1.Text = String.Format("{0}. Gruppe", Group);
                label1.RightToLeft = RightToLeft.No;
                label2.Text = "Wenn Sie die OK-Taste drücken, werden Sie zum Hauptmenü weitergeleitet.";
                label2.RightToLeft = RightToLeft.No;
                label5.Text = Point;
                label5.RightToLeft = RightToLeft.No;
                button3.Text = "OK";
                button3.RightToLeft = RightToLeft.No;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTwo.GoToMainMenu();
            Dispose();
            Close();
        }
    }
}
