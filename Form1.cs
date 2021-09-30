using System;
using System.Windows.Forms;
namespace ingilizceKelimeOyunu
{
    public partial class ingilizceKelimeOyunu : Form
    {
        public int FormCloserAvailable = 1;
        public string Time
        {
            get { return (numericUpDown1.Value.ToString()); }
            set { Time = value;  }
        }
        public int language
        {
            get; set;
        }
        public int groupValue
        {
            get { return checkBox3.Checked ? 2 : (checkBox4.Checked ? 3 : (checkBox5.Checked ? 4 : 2)); }
            set { groupValue = value; }
        }
        public string pointValue
        {
            get { return checkBox9.Checked ? "1-2-3-5" : (checkBox10.Checked ? "5-10-20-50" : (checkBox8.Checked ? "15-25-50-75" : checkBox7.Checked ? "25-50-75-150" : "1-2-3-5")); }
            set { pointValue = value; }
        }
        public ingilizceKelimeOyunu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        // Dil değiştirme fonksiyonu
        private void ToggleLanguage(string language)
        {
            if (language == "tr_TR")
            {
                button1.Text = "Başlat";
                button1.RightToLeft = RightToLeft.No;

                button2.Text = "Ayarları Sıfırla";
                button2.RightToLeft = RightToLeft.No;

                button3.Text = "Çıkış";
                button3.RightToLeft = RightToLeft.No;

                button4.Text = "Düzenle";
                button3.RightToLeft = RightToLeft.No;

                groupBox1.Text = "Dil Ayarları";
                groupBox1.RightToLeft = RightToLeft.No;

                groupBox2.Text = "Grup Ayarları";
                groupBox2.RightToLeft = RightToLeft.No;

                groupBox3.Text = "Puan Ayarları";
                groupBox3.RightToLeft = RightToLeft.No;

                groupBox4.Text = "Süre (Gelişmiş)";
                groupBox4.RightToLeft = RightToLeft.No;

                groupBox5.Text = "Kelimeler (Devre Dışı)";
                groupBox5.RightToLeft = RightToLeft.No;

                label1.Text = "Ana Menü";
                label1.RightToLeft = RightToLeft.No;

                label2.Text = "(varsayılan)";
                label2.Left = 89;
                label2.RightToLeft = RightToLeft.No;

                label3.Text = "(varsayılan)";
                label3.Left = 94;
                label3.RightToLeft = RightToLeft.No;

                label4.Text = "(varsayılan)";
                label4.Left = 78;
                label4.RightToLeft = RightToLeft.No;

                label6.Text = "Saniye";
                label4.RightToLeft = RightToLeft.No;

                checkBox1.Text = "Türkçe";
                checkBox1.RightToLeft = RightToLeft.No;

                checkBox2.Text = "İngilizce";
                checkBox2.RightToLeft = RightToLeft.No;

                checkBox6.Text = "Arapça";
                checkBox6.RightToLeft = RightToLeft.No;

                checkBox11.Text = "Almanca";
                checkBox11.RightToLeft = RightToLeft.No;

                checkBox3.Text = "2 Grup";
                checkBox3.RightToLeft = RightToLeft.No;

                checkBox4.Text = "3 Grup";
                checkBox4.RightToLeft = RightToLeft.No;

                checkBox5.Text = "4 Grup";
                checkBox5.RightToLeft = RightToLeft.No;
            } 
            else if (language == "en_US")
            {
                button1.Text = "Start";
                button1.RightToLeft = RightToLeft.No;

                button2.Text = "Reset Settings";
                button2.RightToLeft = RightToLeft.No;

                button3.Text = "Exit";
                button3.RightToLeft = RightToLeft.No;

                button4.Text = "Edit";
                button3.RightToLeft = RightToLeft.No;

                groupBox1.Text = "Language Settings";
                groupBox1.RightToLeft = RightToLeft.No;

                groupBox2.Text = "Group Settings";
                groupBox2.RightToLeft = RightToLeft.No;

                groupBox3.Text = "Score Settings";
                groupBox3.RightToLeft = RightToLeft.No;

                groupBox4.Text = "Time (Advanced)";
                groupBox4.RightToLeft = RightToLeft.No;

                groupBox5.Text = "Words (Disabled)";
                groupBox5.RightToLeft = RightToLeft.No;

                label1.Text = "Main Menu";
                label1.RightToLeft = RightToLeft.No;

                label2.Text = "(default)";
                label2.Left = 89;
                label2.RightToLeft = RightToLeft.No;

                label3.Text = "(default)";
                label3.Left = 94;
                label3.RightToLeft = RightToLeft.No;

                label4.Text = "(default)";
                label4.Left = 104;
                label4.RightToLeft = RightToLeft.No;

                label6.Text = "Seconds";
                label4.RightToLeft = RightToLeft.No;

                checkBox1.Text = "Turkish";
                checkBox1.RightToLeft = RightToLeft.No;

                checkBox2.Text = "English";
                checkBox2.RightToLeft = RightToLeft.No;

                checkBox6.Text = "Arabic";
                checkBox6.RightToLeft = RightToLeft.No;

                checkBox11.Text = "German";
                checkBox11.RightToLeft = RightToLeft.No;

                checkBox3.Text = "2 Group(s)";
                checkBox3.RightToLeft = RightToLeft.No;

                checkBox4.Text = "3 Group(s)";
                checkBox4.RightToLeft = RightToLeft.No;

                checkBox5.Text = "4 Group(s)";
                checkBox5.RightToLeft = RightToLeft.No;
            } 
            else if (language == "ar_SA")
            {label6.Text = "ثانيا";
                label4.RightToLeft = RightToLeft.Yes;
                button1.Text = "بداية";
                button1.RightToLeft = RightToLeft.Yes;

                button2.Text = "أعد ضبط الإعدادات";
                button2.RightToLeft = RightToLeft.Yes;

                button3.Text = "مخرج";
                button3.RightToLeft = RightToLeft.Yes;

                button4.Text = "دوزينلي";
                button3.RightToLeft = RightToLeft.Yes;

                groupBox1.Text = "إعدادات اللغة";
                groupBox1.RightToLeft = RightToLeft.Yes;

                groupBox2.Text = "إعدادات المجموعة";
                groupBox2.RightToLeft = RightToLeft.Yes;

                groupBox3.Text = "إعدادات النتيجة";
                groupBox3.RightToLeft = RightToLeft.Yes;

                groupBox4.Text = "المدة (متقدم)";
                groupBox4.RightToLeft = RightToLeft.Yes;

                groupBox5.Text = "كلمات (معطل)";
                groupBox5.RightToLeft = RightToLeft.Yes;

                label1.Text = "القائمة الرئيسية";
                label1.RightToLeft = RightToLeft.Yes;

                label2.Text = "(الانجليزية)";
                label2.Left = 91;
                label2.RightToLeft = RightToLeft.Yes;
                

                label3.Text = "(الانجليزية)";
                label3.Left = 116;
                label3.RightToLeft = RightToLeft.Yes;

                label4.Text = "(الانجليزية)";
                label4.Left = 104;
                label4.RightToLeft = RightToLeft.Yes;

                label6.Text = "ثانيا";
                label4.RightToLeft = RightToLeft.Yes;

                checkBox1.Text = "اللغة التركية";
                checkBox1.RightToLeft = RightToLeft.Yes;

                checkBox2.Text = "الانجليزية";
                checkBox2.RightToLeft = RightToLeft.Yes;

                checkBox6.Text = "عربي";
                checkBox6.RightToLeft = RightToLeft.Yes;

                checkBox11.Text = "ألمانية";
                checkBox11.RightToLeft = RightToLeft.Yes;

                checkBox3.Text = "2 مجموعات";
                checkBox3.RightToLeft = RightToLeft.Yes;

                checkBox4.Text = "3 مجموعات";
                checkBox4.RightToLeft = RightToLeft.Yes;

                checkBox5.Text = "4 مجموعات";
                checkBox5.RightToLeft = RightToLeft.Yes;
            }
            else if (language == "de_CH")
            {
                button1.Text = "Anfang";
                button1.RightToLeft = RightToLeft.No;

                button2.Text = "Einstellungen Zurücksetzen";
                button2.RightToLeft = RightToLeft.No;

                button3.Text = "Ausgang";
                button3.RightToLeft = RightToLeft.No;

                button4.Text = "Bearbeiten";
                button3.RightToLeft = RightToLeft.No;

                groupBox1.Text = "Spracheinstellungen";
                groupBox1.RightToLeft = RightToLeft.No;

                groupBox2.Text = "Gruppeneinstellungen";
                groupBox2.RightToLeft = RightToLeft.No;

                groupBox3.Text = "Score-Einstellungen";
                groupBox3.RightToLeft = RightToLeft.No;

                groupBox4.Text = "Dauer (Erweitert)";
                groupBox4.RightToLeft = RightToLeft.No;

                groupBox5.Text = "Wörter (deaktiviert)";
                groupBox5.RightToLeft = RightToLeft.No;

                label1.Text = "Hauptmenü";
                label1.RightToLeft = RightToLeft.No;

                label2.Text = "(der default)";
                label2.Left = 89;
                label2.RightToLeft = RightToLeft.No;

                label3.Text = "(der default)";
                label3.Left = 99;
                label3.RightToLeft = RightToLeft.No;

                label4.Text = "(der default)";
                label4.Left = 104;
                label4.RightToLeft = RightToLeft.No;

                label6.Text = "Sekunde";
                label4.RightToLeft = RightToLeft.No;

                checkBox1.Text = "Türkisch";
                checkBox1.RightToLeft = RightToLeft.No;

                checkBox2.Text = "Englisch";
                checkBox2.RightToLeft = RightToLeft.No;

                checkBox6.Text = "Arabisch";
                checkBox6.RightToLeft = RightToLeft.No;

                checkBox11.Text = "Deutsch";
                checkBox11.RightToLeft = RightToLeft.No;

                checkBox3.Text = "2 Gruppen";
                checkBox3.RightToLeft = RightToLeft.No;

                checkBox4.Text = "3 Gruppen";
                checkBox4.RightToLeft = RightToLeft.No;

                checkBox5.Text = "4 Gruppen";
                checkBox5.RightToLeft = RightToLeft.No;
            }
        }
        public void ShowIngilizceKelime()
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            this.Show();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            int i = (int)Math.Round(numericUpDown1.Value, MidpointRounding.ToEven);

            if (i < 30 && i > 3)
            {
                this.Hide();
                var form2 = new Form2(this);
                form2.Show();
            }
            else { 
                if (language == 1) MessageBox.Show($"Süre saniye cinsinden olmalı ve 3 ile 30 arasında bir değer olmalıdır.", "Süre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (language == 2) MessageBox.Show("The time must be in seconds and be a value between 3 and 30..", "Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (language == 3) MessageBox.Show("يجب أن تكون المدة بالثواني وأن تكون قيمة بين 3 و 30.", "مدة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (language == 4) MessageBox.Show("Die Dauer muss in Sekunden angegeben werden und ein Wert zwischen 3 und 30 sein.", "Dauer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }           
        }

        // Dil Ayarı
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == false & checkBox2.Checked == false & checkBox6.Checked == false & (((CheckBox)sender).Checked == false)) ((CheckBox)sender).Checked = true;
            if (checkBox1.Checked == true && language != 1)
            {
                checkBox11.Checked = false;
                checkBox2.Checked = false;
                checkBox6.Checked = false;
                language = 1;
                ToggleLanguage("tr_TR");
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false & checkBox6.Checked == false & checkBox11.Checked == false & (((CheckBox)sender).Checked == false)) ((CheckBox)sender).Checked = true;
            if (checkBox2.Checked == true && language != 2)
            {
                checkBox1.Checked = false;
                checkBox11.Checked = false;
                checkBox6.Checked = false;
                language = 2;
                ToggleLanguage("en_US");
            }
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false & checkBox2.Checked == false & checkBox11.Checked == false & (((CheckBox)sender).Checked == false)) ((CheckBox)sender).Checked = true;
            if (checkBox6.Checked == true && language != 3)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox11.Checked = false;
                language = 3;
                ToggleLanguage("ar_SA");
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == false & checkBox2.Checked == false & checkBox6.Checked == false & (((CheckBox)sender).Checked == false))((CheckBox)sender).Checked = true;
            if (checkBox11.Checked == true && language != 4)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox6.Checked = false;   
                language = 4;
                ToggleLanguage("de_CH");
            }
        }
        // ----


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // Grup Sayısı
        // 1
        // 2
        // 3
        // 4
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox4.Checked == false & checkBox5.Checked == false) & (((CheckBox)sender).Checked == false)) ((CheckBox)sender).Checked = true;
            if (((CheckBox)sender).Checked)
            {
                checkBox4.CheckState = CheckState.Unchecked;
                checkBox5.CheckState = CheckState.Unchecked;
            }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox3.Checked == false & checkBox5.Checked == false) & (((CheckBox)sender).Checked == false)) ((CheckBox)sender).Checked = true;
            if (((CheckBox)sender).Checked)
            {
                checkBox3.CheckState = CheckState.Unchecked;
                checkBox5.CheckState = CheckState.Unchecked;
            }
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox4.Checked == false & checkBox3.Checked == false) & (((CheckBox)sender).Checked == false)) ((CheckBox)sender).Checked = true;
            if (((CheckBox)sender).Checked)
            {
                checkBox3.CheckState = CheckState.Unchecked;
                checkBox4.CheckState = CheckState.Unchecked;
            }
        }
        // -----------------------------------------


        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        // -----------------------------------------


        // Form yüklendi.
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            checkBox5.Checked = true;
            checkBox1.Checked = true;
            checkBox9.Checked = true;
        }
        // -----------------------------------------


        // Form çıkışı.
        public void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (language == 1)
            {
                if (MessageBox.Show("Oyundan çıkış yapmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            } 
            else if (language == 2)
            {
                if (MessageBox.Show("Are you sure you want to exit the game?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            } 
            else if (language == 3)
            {
                if (MessageBox.Show("هل أنت متأكد أنك تريد الخروج من اللعبة؟", "مخرج", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            } 
            else if (language == 4)
            {
                if (MessageBox.Show("Möchten Sie das Spiel wirklich beenden?", "Ausgang", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
        // -----------------------------------------


        // Ayarları Sıfırla
        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true & checkBox1.Checked == true & checkBox9.Checked == true)
            {
               if (language == 1) MessageBox.Show("Zaten varsayılan ayarları kullanıyorsunuz.", "Varsayılan Ayarlar", MessageBoxButtons.OK, MessageBoxIcon.Information);
               if (language == 2) MessageBox.Show("Already you are using default settings.", "Default Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
               if (language == 3) MessageBox.Show("أنت تستخدم بالفعل الإعدادات الافتراضية", "الإعدادات الافتراضية", MessageBoxButtons.OK, MessageBoxIcon.Information);
               if (language == 4) MessageBox.Show("Sie verwenden bereits die Standardeinstellungen.", "Standardeinstellungen", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            checkBox3.Checked = true;
            checkBox1.Checked = true;
            checkBox9.Checked = true;
            checkBox2.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox10.Checked = false;
        }
        // -----------------------------------------


        // Çıkış
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // -----------------------------------------




        // 1-2-3-4-5
        // 5-10-20-25-50
        // 10-25-50-75-100
        // 25-50-75-100-150
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox9.Checked == false & checkBox8.Checked == false & checkBox7.Checked == false) & (((CheckBox)sender).Checked == false)) ((CheckBox)sender).Checked = true;
            if (((CheckBox)sender).Checked)
            {
                checkBox9.CheckState = CheckState.Unchecked;
                checkBox8.CheckState = CheckState.Unchecked;
                checkBox7.CheckState = CheckState.Unchecked;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox10.Checked == false & checkBox8.Checked == false & checkBox7.Checked == false) & (((CheckBox)sender).Checked == false)) ((CheckBox)sender).Checked = true;
            if (((CheckBox)sender).Checked)
            {
                checkBox10.CheckState = CheckState.Unchecked;
                checkBox8.CheckState = CheckState.Unchecked;
                checkBox7.CheckState = CheckState.Unchecked;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox9.Checked == false & checkBox10.Checked == false & checkBox7.Checked == false) & (((CheckBox)sender).Checked == false)) ((CheckBox)sender).Checked = true;
            if (((CheckBox)sender).Checked)
            {
                checkBox9.CheckState = CheckState.Unchecked;
                checkBox10.CheckState = CheckState.Unchecked;
                checkBox7.CheckState = CheckState.Unchecked;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox9.Checked == false & checkBox8.Checked == false & checkBox10.Checked == false) & (((CheckBox)sender).Checked == false)) ((CheckBox)sender).Checked = true;
            if (((CheckBox)sender).Checked)
            {
                checkBox9.CheckState = CheckState.Unchecked;
                checkBox8.CheckState = CheckState.Unchecked;
                checkBox10.CheckState = CheckState.Unchecked;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (language == 1) MessageBox.Show("Program, 'Sabri Kanlı' tarafından tasarlandı. ", "Oyun:Hazırlayanlar", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
 
 
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        


        // -----------------------------------------
    }
}
