using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Media;
using System.Diagnostics;

namespace ingilizceKelimeOyunu
{
    public partial class Form2 : Form
    {
        private PictureBox pb;
        private int current_group_position = 1;
        public int grouponepoint = 0;
        public int grouptwopoint = 0;
        public int groupthreepoint = 0;
        public int groupfourpoint = 0;
        ingilizceKelimeOyunu FORMFIRST = null; // Passing data
        private readonly Color current_color = Color.Lime; // Current group's color
        private readonly Color default_color = Color.Black; // Panel default
        private readonly Color default_text_color = Color.White; // Default text color
        private readonly IDictionary<string, string> SORUCEVAPLAR = new Dictionary<string, string>(){};
        
        public void ChangePoint(int Point, int groupNumber, string process)
        {
            if (groupNumber == 1)
            {
                if (process == "+") grouponepoint += Point;
                if (process == "-") grouponepoint = grouponepoint - Point;
                textBox1.Text = $"{Convert.ToString(grouponepoint)}";
            }
            else if (groupNumber == 2)
            {
                if (process == "+") grouptwopoint += Point;
                if (process == "-") grouptwopoint = grouptwopoint - Point;
                textBox2.Text = $"{Convert.ToString(grouptwopoint)}";
            }
            else if (groupNumber == 3)
            {
                if (process == "+") groupthreepoint += Point;
                if (process == "-") groupthreepoint = groupthreepoint - Point;
                textBox3.Text = $"{Convert.ToString(groupthreepoint)}";
            }
            else if (groupNumber == 4)
            {
                if (process == "+") groupfourpoint += Point;
                if (process == "-") groupfourpoint = groupfourpoint - Point;
                textBox4.Text = $"{Convert.ToString(groupfourpoint)}";
            }
        }
        public Form2(ingilizceKelimeOyunu form)
        {
            FORMFIRST = form;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            pb = new PictureBox();
            panel1.Controls.Add(pb);
            pb.Dock = DockStyle.Fill;
        }
        public void Blur()
        {
            Bitmap bmp = Screenshot.TakeSnapshot(panel1);
            BitmapFilter.GaussianBlur(bmp, 4);
            BitmapFilter.GaussianBlur(bmp, 4);
            BitmapFilter.GaussianBlur(bmp, 4);
            BitmapFilter.GaussianBlur(bmp, 4);
            pb.Image = bmp;
            pb.BringToFront();
        }

        public void UnBlur()
        {
            pb.Image = null;
            pb.SendToBack();
        }
        public void ResetGame()
        {
            SwitchCurrentPosition(FORMFIRST.groupValue);
            button1.Enabled = false;
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            grouponepoint = 0;
            grouptwopoint = 0;
            groupthreepoint = 0;
            groupfourpoint = 0;
            button18.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;

            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;

            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;

            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button17.Visible = true;

            button19.Visible = true;
            button20.Visible = true;
            button21.Visible = true;
            button22.Visible = true;

            button27.Visible = true;
            button28.Visible = true;
            button29.Visible = true;
            button30.Visible = true;

            button31.Visible = true;
            button32.Visible = true;
            button33.Visible = true;
            button34.Visible = true;
            SwitchCurrentPosition(FORMFIRST.groupValue);
        }
        public void SwitchCurrentPosition(int current_position)
        {
            int Group = FORMFIRST.groupValue;
            if (Group == current_position)
            {
                current_group_position = 1;
                panel2.BackColor = default_color;
                label2.ForeColor = default_text_color;
                panel3.BackColor = default_color;
                label3.ForeColor = default_text_color;
                panel4.BackColor = default_color;
                label4.ForeColor = default_text_color;
                panel5.BackColor = current_color;
                label1.ForeColor = Color.Black;
            }
            else if (current_position == 1)
            {
                current_group_position += 1;
                panel5.BackColor = default_color;
                label1.ForeColor = default_text_color;
                panel2.BackColor = current_color;
                label2.ForeColor = Color.Black;
            }
            else if (current_position == 2)
            {
                current_group_position += 1;
                panel2.BackColor = default_color;
                label2.ForeColor = default_text_color;
                panel3.BackColor = current_color;
                label3.ForeColor = Color.Black;
            }
            else if (current_position == 3)
            {
                current_group_position += 1;
                panel3.BackColor = default_color;
                label3.ForeColor = default_text_color;
                panel4.BackColor = current_color;
                label4.ForeColor = Color.Black;
            }
            else if (current_position == 4)
            {
                current_group_position = 1;
                panel4.BackColor = default_color;
                label4.ForeColor = default_text_color;
                panel5.BackColor = current_color;
                label1.ForeColor = Color.Black;
            }

        }
        private void ToggleLanguage(int language)
        {
            string[] ScoreString = FORMFIRST.pointValue.Split('-');
            if (language == 1)
            {
                button1.Text = "Oyunu Sıfırla";
                button1.RightToLeft = RightToLeft.No;
                button2.Text = "Ana Menü";
                button2.RightToLeft = RightToLeft.No;

                label1.Text = "1. Grup";
                label1.RightToLeft = RightToLeft.No;
                label2.Text = "2. Grup";
                label1.RightToLeft = RightToLeft.No;
                label3.Text = "3. Grup";
                label1.RightToLeft = RightToLeft.No;
                label4.Text = "4. Grup";
                label1.RightToLeft = RightToLeft.No;

                button18.Text = $"{ScoreString[0]} Puan";
                button18.RightToLeft = RightToLeft.No;
                button3.Text = $"{ScoreString[1]} Puan";
                button3.RightToLeft = RightToLeft.No;
                button4.Text = $"{ScoreString[2]} Puan";
                button4.RightToLeft = RightToLeft.No;
                button5.Text = $"{ScoreString[3]} Puan";
                button5.RightToLeft = RightToLeft.No;

                // 1. SATIR
                button9.Text = button18.Text;
                button9.RightToLeft = button18.RightToLeft;
                button13.Text = button18.Text;
                button13.RightToLeft = button18.RightToLeft;
                button17.Text = button18.Text;
                button17.RightToLeft = button18.RightToLeft;
                button22.Text = button18.Text;
                button22.RightToLeft = button18.RightToLeft;
                button30.Text = button18.Text;
                button30.RightToLeft = button18.RightToLeft;
                button34.Text = button18.Text;
                button34.RightToLeft = button18.RightToLeft;
                // 2. satır
                button8.Text = button3.Text;
                button8.RightToLeft = button3.RightToLeft;
                button12.Text = button3.Text;
                button12.RightToLeft = button3.RightToLeft;
                button16.Text = button3.Text;
                button16.RightToLeft = button3.RightToLeft;
                button21.Text = button3.Text;
                button21.RightToLeft = button3.RightToLeft;
                button29.Text = button3.Text;
                button29.RightToLeft = button3.RightToLeft;
                button33.Text = button3.Text;
                button33.RightToLeft = button3.RightToLeft;
                // 3. satır
                button7.Text = button4.Text;
                button7.RightToLeft = button4.RightToLeft;
                button11.Text = button4.Text;
                button11.RightToLeft = button4.RightToLeft;
                button15.Text = button4.Text;
                button15.RightToLeft = button4.RightToLeft;
                button20.Text = button4.Text;
                button20.RightToLeft = button4.RightToLeft;
                button28.Text = button4.Text;
                button28.RightToLeft = button4.RightToLeft;
                button32.Text = button4.Text;
                button32.RightToLeft = button4.RightToLeft;
                // 4. satır
                button6.Text = button5.Text;
                button6.RightToLeft = button5.RightToLeft;
                button10.Text = button5.Text;
                button10.RightToLeft = button5.RightToLeft;
                button14.Text = button5.Text;
                button14.RightToLeft = button5.RightToLeft;
                button19.Text = button5.Text;
                button19.RightToLeft = button5.RightToLeft;
                button27.Text = button5.Text;
                button27.RightToLeft = button5.RightToLeft;
                button31.Text = button5.Text;
                button31.RightToLeft = button5.RightToLeft;
            }
            else if (language == 2)
            {
                button1.Text = "Reset Game";
                button1.RightToLeft = RightToLeft.No;
                button2.Text = "Main Menu";
                button2.RightToLeft = RightToLeft.No;
                label1.Text = "1. Group";
                label1.RightToLeft = RightToLeft.No;
                label2.Text = "2. Group";
                label1.RightToLeft = RightToLeft.No;
                label3.Text = "3. Group";
                label1.RightToLeft = RightToLeft.No;
                label4.Text = "4. Group";
                label1.RightToLeft = RightToLeft.No;
                button18.Text = $"{ScoreString[0]} Point(s)";
                button18.RightToLeft = RightToLeft.No;
                button3.Text = $"{ScoreString[1]} Point(s)";
                button3.RightToLeft = RightToLeft.No;
                button4.Text = $"{ScoreString[2]} Point(s)";
                button4.RightToLeft = RightToLeft.No;
                button5.Text = $"{ScoreString[3]} Point(s)";
                button5.RightToLeft = RightToLeft.No;

                // 1. SATIR
                button9.Text = button18.Text;
                button9.RightToLeft = button18.RightToLeft;
                button13.Text = button18.Text;
                button13.RightToLeft = button18.RightToLeft;
                button17.Text = button18.Text;
                button17.RightToLeft = button18.RightToLeft;
                button22.Text = button18.Text;
                button22.RightToLeft = button18.RightToLeft;
                button30.Text = button18.Text;
                button30.RightToLeft = button18.RightToLeft;
                button34.Text = button18.Text;
                button34.RightToLeft = button18.RightToLeft;
                // 2. satır
                button8.Text = button3.Text;
                button8.RightToLeft = button3.RightToLeft;
                button12.Text = button3.Text;
                button12.RightToLeft = button3.RightToLeft;
                button16.Text = button3.Text;
                button16.RightToLeft = button3.RightToLeft;
                button21.Text = button3.Text;
                button21.RightToLeft = button3.RightToLeft;
                button29.Text = button3.Text;
                button29.RightToLeft = button3.RightToLeft;
                button33.Text = button3.Text;
                button33.RightToLeft = button3.RightToLeft;
                // 3. satır
                button7.Text = button4.Text;
                button7.RightToLeft = button4.RightToLeft;
                button11.Text = button4.Text;
                button11.RightToLeft = button4.RightToLeft;
                button15.Text = button4.Text;
                button15.RightToLeft = button4.RightToLeft;
                button20.Text = button4.Text;
                button20.RightToLeft = button4.RightToLeft;
                button28.Text = button4.Text;
                button28.RightToLeft = button4.RightToLeft;
                button32.Text = button4.Text;
                button32.RightToLeft = button4.RightToLeft;
                // 4. satır
                button6.Text = button5.Text;
                button6.RightToLeft = button5.RightToLeft;
                button10.Text = button5.Text;
                button10.RightToLeft = button5.RightToLeft;
                button14.Text = button5.Text;
                button14.RightToLeft = button5.RightToLeft;
                button19.Text = button5.Text;
                button19.RightToLeft = button5.RightToLeft;
                button27.Text = button5.Text;
                button27.RightToLeft = button5.RightToLeft;
                button31.Text = button5.Text;
                button31.RightToLeft = button5.RightToLeft;
            }
            else if (language == 3)
            {
                button1.Text = "أعد اعداد اللعبة";
                button1.RightToLeft = RightToLeft.Yes;
                button2.Text = "القائمة الرئيسية";
                button2.RightToLeft = RightToLeft.Yes;
                label1.Text = "1. المجموعة";
                label1.RightToLeft = RightToLeft.Yes;
                label2.Text = "2. المجموعة";
                label1.RightToLeft = RightToLeft.Yes;
                label3.Text = "3. المجموعة";
                label1.RightToLeft = RightToLeft.Yes;
                label4.Text = "4. المجموعة";
                label1.RightToLeft = RightToLeft.Yes;

                button18.Text = $"{ScoreString[0]} نقاط";
                button18.RightToLeft = RightToLeft.Yes;
                button3.Text = $"{ScoreString[1]} نقاط";
                button3.RightToLeft = RightToLeft.Yes;
                button4.Text = $"{ScoreString[2]} نقاط";
                button4.RightToLeft = RightToLeft.Yes;
                button5.Text = $"{ScoreString[3]} نقاط";
                button5.RightToLeft = RightToLeft.Yes;

                // 1. SATIR
                button9.Text = button18.Text;
                button9.RightToLeft = button18.RightToLeft;
                button13.Text = button18.Text;
                button13.RightToLeft = button18.RightToLeft;
                button17.Text = button18.Text;
                button17.RightToLeft = button18.RightToLeft;
                button22.Text = button18.Text;
                button22.RightToLeft = button18.RightToLeft;
                button30.Text = button18.Text;
                button30.RightToLeft = button18.RightToLeft;
                button34.Text = button18.Text;
                button34.RightToLeft = button18.RightToLeft;
                // 2. satır
                button8.Text = button3.Text;
                button8.RightToLeft = button3.RightToLeft;
                button12.Text = button3.Text;
                button12.RightToLeft = button3.RightToLeft;
                button16.Text = button3.Text;
                button16.RightToLeft = button3.RightToLeft;
                button21.Text = button3.Text;
                button21.RightToLeft = button3.RightToLeft;
                button29.Text = button3.Text;
                button29.RightToLeft = button3.RightToLeft;
                button33.Text = button3.Text;
                button33.RightToLeft = button3.RightToLeft;
                // 3. satır
                button7.Text = button4.Text;
                button7.RightToLeft = button4.RightToLeft;
                button11.Text = button4.Text;
                button11.RightToLeft = button4.RightToLeft;
                button15.Text = button4.Text;
                button15.RightToLeft = button4.RightToLeft;
                button20.Text = button4.Text;
                button20.RightToLeft = button4.RightToLeft;
                button28.Text = button4.Text;
                button28.RightToLeft = button4.RightToLeft;
                button32.Text = button4.Text;
                button32.RightToLeft = button4.RightToLeft;
                // 4. satır
                button6.Text = button5.Text;
                button6.RightToLeft = button5.RightToLeft;
                button10.Text = button5.Text;
                button10.RightToLeft = button5.RightToLeft;
                button14.Text = button5.Text;
                button14.RightToLeft = button5.RightToLeft;
                button19.Text = button5.Text;
                button19.RightToLeft = button5.RightToLeft;
                button27.Text = button5.Text;
                button27.RightToLeft = button5.RightToLeft;
                button31.Text = button5.Text;
                button31.RightToLeft = button5.RightToLeft;
            }
            else if (language == 4)
            {
                button1.Text = "Spiel Zurücksetzen";
                button1.RightToLeft = RightToLeft.No;
                button2.Text = "Hauptmenü";
                button2.RightToLeft = RightToLeft.No;
                label1.Text = "1. Gruppe";
                label1.RightToLeft = RightToLeft.No;
                label2.Text = "2. Gruppe";
                label1.RightToLeft = RightToLeft.No;
                label3.Text = "3. Gruppe";
                label1.RightToLeft = RightToLeft.No;
                label4.Text = "4. Gruppe";
                label1.RightToLeft = RightToLeft.No;
                button18.Text = $"{ScoreString[0]} Punkt";
                button18.RightToLeft = RightToLeft.No;
                button3.Text = $"{ScoreString[1]} Punkt";
                button3.RightToLeft = RightToLeft.No;
                button4.Text = $"{ScoreString[2]} Punkt";
                button4.RightToLeft = RightToLeft.No;
                button5.Text = $"{ScoreString[3]} Punkt";
                button5.RightToLeft = RightToLeft.No;

                // 1. SATIR
                button9.Text = button18.Text;
                button9.RightToLeft = button18.RightToLeft;
                button13.Text = button18.Text;
                button13.RightToLeft = button18.RightToLeft;
                button17.Text = button18.Text;
                button17.RightToLeft = button18.RightToLeft;
                button22.Text = button18.Text;
                button22.RightToLeft = button18.RightToLeft;
                button30.Text = button18.Text;
                button30.RightToLeft = button18.RightToLeft;
                button34.Text = button18.Text;
                button34.RightToLeft = button18.RightToLeft;
                // 2. satır
                button8.Text = button3.Text;
                button8.RightToLeft = button3.RightToLeft;
                button12.Text = button3.Text;
                button12.RightToLeft = button3.RightToLeft;
                button16.Text = button3.Text;
                button16.RightToLeft = button3.RightToLeft;
                button21.Text = button3.Text;
                button21.RightToLeft = button3.RightToLeft;
                button29.Text = button3.Text;
                button29.RightToLeft = button3.RightToLeft;
                button33.Text = button3.Text;
                button33.RightToLeft = button3.RightToLeft;
                // 3. satır
                button7.Text = button4.Text;
                button7.RightToLeft = button4.RightToLeft;
                button11.Text = button4.Text;
                button11.RightToLeft = button4.RightToLeft;
                button15.Text = button4.Text;
                button15.RightToLeft = button4.RightToLeft;
                button20.Text = button4.Text;
                button20.RightToLeft = button4.RightToLeft;
                button28.Text = button4.Text;
                button28.RightToLeft = button4.RightToLeft;
                button32.Text = button4.Text;
                button32.RightToLeft = button4.RightToLeft;
                // 4. satır
                button6.Text = button5.Text;
                button6.RightToLeft = button5.RightToLeft;
                button10.Text = button5.Text;
                button10.RightToLeft = button5.RightToLeft;
                button14.Text = button5.Text;
                button14.RightToLeft = button5.RightToLeft;
                button19.Text = button5.Text;
                button19.RightToLeft = button5.RightToLeft;
                button27.Text = button5.Text;
                button27.RightToLeft = button5.RightToLeft;
                button31.Text = button5.Text;
                button31.RightToLeft = button5.RightToLeft;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (FORMFIRST.groupValue == 2)
            {
                panel5.Left = 244;
                panel2.Left = 432;
                panel3.Visible = false;
                panel4.Visible = false;
            }
            else if (FORMFIRST.groupValue == 3)
            {
                panel5.Left = 133;
                panel2.Left = 320;
                panel3.Left = 508;
                panel4.Visible = false;
            }

            this.FormClosing += new FormClosingEventHandler(Form2_FormClosing);
                ToggleLanguage(this.FORMFIRST.language);
                ContextMenu bruh = new ContextMenu();
                textBox1.ContextMenu = bruh;
                textBox2.ContextMenu = bruh;
                textBox3.ContextMenu = bruh;
                textBox4.ContextMenu = bruh;
                panel5.BackColor = current_color;
                label1.ForeColor = Color.Black;
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FORMFIRST.language == 1)
            {
                if (MessageBox.Show("Oyundan çıkış yapmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            else if (FORMFIRST.language == 2)
            {
                if (MessageBox.Show("Are you sure you want to exit the game?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            else if (FORMFIRST.language == 3)
            {
                if (MessageBox.Show("هل أنت متأكد أنك تريد الخروج من اللعبة؟", "مخرج", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            else if (FORMFIRST.language == 4)
            {
                if (MessageBox.Show("Möchten Sie das Spiel wirklich beenden?", "Ausgang", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            FORMFIRST.FormClosing -= FORMFIRST.Form1_FormClosing;
            FORMFIRST.Close();
        }
        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label5_Click_1(object sender, EventArgs e)
        {
            if (FORMFIRST.language == 1) MessageBox.Show("Program, 'Sabri Kanlı' tarafından 'C#' yazılım dili kullanılarak tasarlandı.\n\nKullandığım kaynaklar:\nhttps://docs.microsoft.com/tr-tr/dotnet/framework/\nhttps://stackoverflow.com\nhttps://codeproject.com/\nhttps://www.w3schools.com/cs/", "Oyun:Hazırlayanlar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (FORMFIRST.language == 2) MessageBox.Show("The program was designed by 'Sabri Kanlı' and 'Taşkın Tazıcı' using 'C#' software language.\n\nResources:\nhttps://docs.microsoft.com/tr-tr/dotnet/framework/\nhttps://stackoverflow.com\nhttps://codeproject.com/\nhttps://www.w3schools.com/cs/", "Game:Developers", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (FORMFIRST.language == 3) MessageBox.Show("تم تصميم البرنامج من قبل Sabri Kanlı و Taşkın Tazıcı باستخدام لغة برمجية C #.\n\nالموارد التي أستخدمها:\nhttps://docs.microsoft.com/tr-tr/dotnet/framework/\nhttps://stackoverflow.com\nhttps://codeproject.com/\nhttps://www.w3schools.com/cs/", "لعبة: المحضرين", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (FORMFIRST.language == 4) MessageBox.Show("Das Programm wurde von 'Sabri Kanlı' und 'Taşkın Tazıcı' unter Verwendung der Softwaresprache 'C#' entwickelt.\n\nVon mir verwendete Ressourcen:\nhttps://docs.microsoft.com/tr-tr/dotnet/framework/\nhttps://stackoverflow.com\nhttps://codeproject.com/\nhttps://www.w3schools.com/cs/", "Spiel:Vorbereiter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }
        // OYUN GENEL BÖLÜMÜ (BUTONLAR VE SORU TANIMLAMALARI)
        // 1 PUANLAR
        
        private void button9_Click(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[0]), current_group_position, "Fortunately", FORMFIRST.language, FORMFIRST.Time);
            button9.Visible = false;
            Blur();
            form3.Show();
        }
        private void button18_Click_1(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[0]), current_group_position, "Focus", FORMFIRST.language, FORMFIRST.Time);
            button18.Visible = false;
            Blur();
            form3.Show();
        }
        private void button13_Click_1(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[0]), current_group_position, "Challenging", FORMFIRST.language, FORMFIRST.Time);
            button13.Visible = false;
            Blur();
            form3.Show();
        }
        private void button17_Click_1(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[0]), current_group_position, "Feeling", FORMFIRST.language, FORMFIRST.Time);
            button17.Visible = false;
            Blur();
            form3.Show();
        }
        private void button30_Click_1(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[0]), current_group_position, "Keen On", FORMFIRST.language, FORMFIRST.Time);
            button30.Visible = false;
            Blur();
            form3.Show();
        }
        private void button22_Click_1(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[0]), current_group_position, "Skip Courses", FORMFIRST.language, FORMFIRST.Time);
            button22.Visible = false;
            Blur();
            form3.Show();
        }
        private void button34_Click_1(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[0]), current_group_position, "As Soon As Possible (ASAP)", FORMFIRST.language, FORMFIRST.Time);
            button34.Visible = false;
            Blur();
            form3.Show();
        }
        // ---------------------------------------------------------

        // 2
        private void button3_Click_1(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[1]), current_group_position, "Issue", FORMFIRST.language, FORMFIRST.Time);
            button3.Visible = false;
            Blur();
            form3.Show();
        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[1]), current_group_position, "Go Abroad", FORMFIRST.language, FORMFIRST.Time);
            button8.Visible = false;
            Blur();
            form3.Show();
        }
        private void button12_Click_1(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[1]), current_group_position, "Science Lab", FORMFIRST.language, FORMFIRST.Time);
            button12.Visible = false;
            Blur();
            form3.Show();
        }
        private void button16_Click_1(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[1]), current_group_position, "Go Jogging", FORMFIRST.language, FORMFIRST.Time);
            button16.Visible = false;
            Blur();
            form3.Show();
        }
        private void button21_Click_1(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[1]), current_group_position, "Have Some Snacks", FORMFIRST.language, FORMFIRST.Time);
            button21.Visible = false;
            Blur();
            form3.Show();
        }
        private void button29_Click_1(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[1]), current_group_position, "Play Chess", FORMFIRST.language, FORMFIRST.Time);
            button29.Visible = false;
            Blur();
            form3.Show();
        }
        private void button33_Click_1(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[1]), current_group_position, "Break Time", FORMFIRST.language, FORMFIRST.Time);
            button33.Visible = false;
            Blur();
            form3.Show();
        }
        // ------------------------------------------------------------

        // 3 PUANLAR
        private void button4_Click_1(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[2]), current_group_position, "Literature", FORMFIRST.language, FORMFIRST.Time);
            button4.Visible = false;
            Blur();
            form3.Show();
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[2]), current_group_position, "Optional Subjects", FORMFIRST.language, FORMFIRST.Time);
            button7.Visible = false;
            Blur();
            form3.Show();
        }
        private void button11_Click_1(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[2]), current_group_position, "Study Habits", FORMFIRST.language, FORMFIRST.Time);
            button11.Visible = false;
            Blur();
            form3.Show();
        }
        private void button15_Click_1(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[2]), current_group_position, "Revise Regularly", FORMFIRST.language, FORMFIRST.Time);
            button15.Visible = false;
            Blur();
            form3.Show();
        }
        private void button20_Click_1(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[2]), current_group_position, "Impact", FORMFIRST.language, FORMFIRST.Time);
            button20.Visible = false;
            Blur();
            form3.Show();
        }
        private void button28_Click_1(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[2]), current_group_position, "Invaluable", FORMFIRST.language, FORMFIRST.Time);
            button28.Visible = false;
            Blur();
            form3.Show();
        }
        private void button32_Click_1(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[2]), current_group_position, "Dormitory", FORMFIRST.language, FORMFIRST.Time);
            button32.Visible = false;
            Blur();
            form3.Show();
        }

        // 4 PUANLAR
        private void button5_Click_1(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[3]), current_group_position, "Cope with Stress", FORMFIRST.language, FORMFIRST.Time);
            button5.Visible = false;
            Blur();
            form3.Show();
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[3]), current_group_position, "Compulsory", FORMFIRST.language, FORMFIRST.Time);
            button6.Visible = false;
            Blur();
            form3.Show();
        }
        private void button10_Click_1(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[3]), current_group_position, "Evaluate", FORMFIRST.language, FORMFIRST.Time);
            button10.Visible = false;
            Blur();
            form3.Show();
        }
        private void button14_Click_1(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[3]), current_group_position, "Achieve Success", FORMFIRST.language, FORMFIRST.Time);
            button14.Visible = false;
            Blur();
            form3.Show();
        }
        private void button19_Click_1(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[3]), current_group_position, "Citizenship", FORMFIRST.language, FORMFIRST.Time);
            button19.Visible = false;
            Blur();
            form3.Show();
        }
        private void button27_Click_1(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[3]), current_group_position, "Foreign Language", FORMFIRST.language, FORMFIRST.Time);
            button27.Visible = false;
            Blur();
            form3.Show();
        }
        private void button31_Click_1(object sender, EventArgs e)
        {
            string[] points = FORMFIRST.pointValue.Split('-');
            button1.Enabled = true;
            var form3 = new Form3(this, Int32.Parse(points[3]), current_group_position, "Nurse Aide", FORMFIRST.language, FORMFIRST.Time);
            button31.Visible = false;
            Blur();
            form3.Show();
        }
        // ----------------------------------------------------------
        public void checkEnd()
        {
            if (button18.Visible == false &
            button3.Visible == false &
            button4.Visible == false &
            button5.Visible == false &

            button6.Visible == false &
            button7.Visible == false &
            button8.Visible == false &
            button9.Visible == false &

            button10.Visible == false &
            button11.Visible == false &
            button12.Visible == false &
            button13.Visible == false &

            button14.Visible == false &
            button15.Visible == false &
            button16.Visible == false &
            button17.Visible == false &

            button19.Visible == false &
            button20.Visible == false &
            button21.Visible == false &
            button22.Visible == false &

            button27.Visible == false &
            button28.Visible == false &
            button29.Visible == false &
            button30.Visible == false &

            button31.Visible == false &
            button32.Visible == false &
            button33.Visible == false &
            button34.Visible == false)
            {
                int[] GroupPoints = { grouponepoint, grouptwopoint, groupthreepoint, groupfourpoint };
                if (GroupPoints.Max() == grouponepoint)
                {
                    var form5 = new Form5(this, "1", grouponepoint.ToString(), FORMFIRST.language);
                    Blur();
                    form5.Show();
                } else if (GroupPoints.Max() == grouptwopoint)
                {
                    var form5 = new Form5(this, "2", grouptwopoint.ToString(), FORMFIRST.language);
                    Blur();
                    form5.Show();
                } else if (GroupPoints.Max() == groupthreepoint)
                {
                    var form5 = new Form5(this, "3", groupthreepoint.ToString(), FORMFIRST.language);
                    Blur();
                    form5.Show();
                } else if (GroupPoints.Max() == groupfourpoint)
                {
                    var form5 = new Form5(this, "4", groupfourpoint.ToString(), FORMFIRST.language);
                    Blur();
                    form5.Show();
                }

            }
        }
            private void button2_Click(object sender, EventArgs e)
        {
                if (FORMFIRST.language == 1)
                {
                    if (MessageBox.Show("Ana menüye dönmek, oyunu sonlandırır. Emin misiniz?", "Ana Menü", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;
                    }
                }
                else if (FORMFIRST.language == 2)
                {
                    if (MessageBox.Show("Returning to the main menu ends the game. Are you sure?", "Main Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;
                    }
                }
                else if (FORMFIRST.language == 3)
                {
                    if (MessageBox.Show("العودة إلى القائمة الرئيسية تنتهي اللعبة. هل انتم متأكدون", "القائمة الرئيسية", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;
                    }
                }
                else if (FORMFIRST.language == 4)
                {
                    if (MessageBox.Show("Die Rückkehr zum Hauptmenü beendet das Spiel. Bist du sicher??", "Hauptmenü", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;
                    }
                }


            GoToMainMenu();
        }
        public void GoToMainMenu()
        {
            FORMFIRST.ShowIngilizceKelime();
            this.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (FORMFIRST.language == 1)
            {
                if (MessageBox.Show("Oyunu sıfırlamak istediğine emin misin?", "Oyunu Sıfırla", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }
            else if (FORMFIRST.language == 2)
            {
                if (MessageBox.Show("Are you sure you want to reset the game?", "Reset Game", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }
            else if (FORMFIRST.language == 3)
            {
                if (MessageBox.Show("هل أنت متأكد أنك تريد إعادة ضبط اللعبة؟", "أعد اعداد اللعبة", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }
            else if (FORMFIRST.language == 4)
            {
                if (MessageBox.Show("Möchten Sie das Spiel wirklich zurücksetzen?", "Spiel Zurücksetzen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }
            ResetGame();
        }
        
        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }



        
    }
    public class BitmapFilter
    {
        private static bool Conv3x3(Bitmap b, ConvMatrix m)
        {
            // Avoid divide by zero errors
            if (0 == m.Factor) return false;

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
                        nPixel = ((((pSrc[2] * m.TopLeft) + (pSrc[5] * m.TopMid) + (pSrc[8] * m.TopRight) +
                            (pSrc[2 + stride] * m.MidLeft) + (pSrc[5 + stride] * m.Pixel) + (pSrc[8 + stride] * m.MidRight) +
                            (pSrc[2 + stride2] * m.BottomLeft) + (pSrc[5 + stride2] * m.BottomMid) + (pSrc[8 + stride2] * m.BottomRight)) / m.Factor) + m.Offset);

                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;

                        p[5 + stride] = (byte)nPixel;

                        nPixel = ((((pSrc[1] * m.TopLeft) + (pSrc[4] * m.TopMid) + (pSrc[7] * m.TopRight) +
                            (pSrc[1 + stride] * m.MidLeft) + (pSrc[4 + stride] * m.Pixel) + (pSrc[7 + stride] * m.MidRight) +
                            (pSrc[1 + stride2] * m.BottomLeft) + (pSrc[4 + stride2] * m.BottomMid) + (pSrc[7 + stride2] * m.BottomRight)) / m.Factor) + m.Offset);

                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;

                        p[4 + stride] = (byte)nPixel;

                        nPixel = ((((pSrc[0] * m.TopLeft) + (pSrc[3] * m.TopMid) + (pSrc[6] * m.TopRight) +
                            (pSrc[0 + stride] * m.MidLeft) + (pSrc[3 + stride] * m.Pixel) + (pSrc[6 + stride] * m.MidRight) +
                            (pSrc[0 + stride2] * m.BottomLeft) + (pSrc[3 + stride2] * m.BottomMid) + (pSrc[6 + stride2] * m.BottomRight)) / m.Factor) + m.Offset);

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

        public static bool GaussianBlur(Bitmap b, int nWeight /* default to 4*/)
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(1);
            m.Pixel = nWeight;
            m.TopMid = m.MidLeft = m.MidRight = m.BottomMid = 2;
            m.Factor = nWeight + 12;

            return BitmapFilter.Conv3x3(b, m);
        }

        public class ConvMatrix
        {
            public int TopLeft = 0, TopMid = 0, TopRight = 0;
            public int MidLeft = 0, Pixel = 1, MidRight = 0;
            public int BottomLeft = 0, BottomMid = 0, BottomRight = 0;
            public int Factor = 1;
            public int Offset = 0;
            public void SetAll(int nVal)
            {
                TopLeft = TopMid = TopRight = MidLeft = Pixel = MidRight = BottomLeft = BottomMid = BottomRight = nVal;
            }
        }
    }

    class Screenshot
    {
        public static Bitmap TakeSnapshot(Control ctl)
        {
            Bitmap bmp = new Bitmap(ctl.Size.Width, ctl.Size.Height);
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bmp);
            g.CopyFromScreen(ctl.PointToScreen(ctl.ClientRectangle.Location), new Point(0, 0), ctl.ClientRectangle.Size);
            return bmp;
        }
    }
}
