using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ingilizceKelimeOyunu
{
    public partial class Form3 : Form
    {
        public CountDownTimer Countdown = new CountDownTimer();
        public Form2 requestForm = null;
        public int PointForForm3 = 0;
        public int CurrentGroupForForm3 = 0;
        public string KelimeForForm3 = null;
        public int LanguageForForm3 = 1;
        public string TimeForForm3 = "10";
        public Form3(Form2 Form, int Point, int CurrentGroup, string Kelime, int language, string time)
        {
            InitializeComponent();
            PointForForm3 = Point;
            CurrentGroupForForm3 = CurrentGroup;
            KelimeForForm3 = Kelime;
            requestForm = Form;
            LanguageForForm3 = language;
            StartPosition = FormStartPosition.CenterScreen;
            TimeForForm3 = time;
        }

        // Doğru
        private void button2_Click(object sender, EventArgs e)
        {
            Countdown.Pause();
            requestForm.ChangePoint(PointForForm3, CurrentGroupForForm3, "+");
            button2.Visible = false;
            button1.Visible = false;
            button3.Visible = true;
        }

        // Yanlış
        private void button1_Click(object sender, EventArgs e)
        {
            Countdown.Pause();
            requestForm.ChangePoint(PointForForm3, CurrentGroupForForm3, "-");
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
        }
        private void fCountDown()
        {
            requestForm.ChangePoint(PointForForm3, CurrentGroupForForm3, "-");
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            if (LanguageForForm3 == 2)
            {
                button2.Text = "True";
                button2.RightToLeft = RightToLeft.No;
                button1.Text = "False";
                button1.RightToLeft = RightToLeft.No;
                button3.Text = "OK";
                button3.RightToLeft = RightToLeft.No;
            }
            else if (LanguageForForm3 == 3)
            {
                button2.Text = "صحيح";
                button2.RightToLeft = RightToLeft.Yes;
                button1.Text = "خاطئ";
                button1.RightToLeft = RightToLeft.Yes;
                button3.Text = "حسنا";
                button3.RightToLeft = RightToLeft.Yes;
            }
            else if (LanguageForForm3 == 4)
            {
                button2.Text = "Wahr";
                button2.RightToLeft = RightToLeft.No;
                button1.Text = "Falsch";
                button1.RightToLeft = RightToLeft.No;
                button3.Text = "OK";
                button3.RightToLeft = RightToLeft.No;
            }
            if (LanguageForForm3 == 2)
            {
                label2.Text = "When the time is up, the question is automatically considered incorrect.";
                label2.Left = 31;
                label2.RightToLeft = RightToLeft.No;
            }
            else if (LanguageForForm3 == 3)
            {
                label2.Text = "عندما يحين الوقت ، يعتبر السؤال غير صحيح تلقائيًا.";
                label2.Left = 50;
                label2.RightToLeft = RightToLeft.Yes;
            }
            else if (LanguageForForm3 == 4)
            {
                label2.Text = "Wenn die Zeit abgelaufen ist, gilt die Frage automatisch als falsch.";
                label2.Left = 50;
                label2.RightToLeft = RightToLeft.No;
            }
            int x = Int32.Parse(TimeForForm3);
            Countdown.SetTime(0, x);
            Countdown.Start();
            Countdown.StepMs = 89;
            Countdown.TimeChanged += () => label3.Text = Countdown.TimeLeftMsStr;
            Countdown.CountDownFinished += fCountDown;
            label1.Text = KelimeForForm3;
            
        }
        // Tamam
        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
            Countdown.CountDownFinished -= fCountDown;
            requestForm.UnBlur();
            requestForm.SwitchCurrentPosition(CurrentGroupForForm3);
            requestForm.checkEnd();
            Dispose();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    public class CountDownTimer : IDisposable
    {
        public Stopwatch _stpWatch = new Stopwatch();

        public Action TimeChanged;
        public Action CountDownFinished;

        public bool IsRunnign => timer.Enabled;

        public int StepMs
        {
            get => timer.Interval;
            set => timer.Interval = value;
        }

        private Timer timer = new Timer();

        private TimeSpan _max = TimeSpan.FromMilliseconds(30000);

        public TimeSpan TimeLeft => (_max.TotalMilliseconds - _stpWatch.ElapsedMilliseconds) > 0 ? TimeSpan.FromMilliseconds(_max.TotalMilliseconds - _stpWatch.ElapsedMilliseconds) : TimeSpan.FromMilliseconds(0);

        private bool _mustStop => (_max.TotalMilliseconds - _stpWatch.ElapsedMilliseconds) < 0;

        public string TimeLeftStr => TimeLeft.ToString(@"\mm\:ss");

        public string TimeLeftMsStr => TimeLeft.ToString(@"ss\,ff");

        private void TimerTick(object sender, EventArgs e)
        {
            TimeChanged?.Invoke();

            if (_mustStop)
            {
                CountDownFinished?.Invoke();
                _stpWatch.Stop();
                timer.Enabled = false;
            }
        }

        public CountDownTimer(int min, int sec)
        {
            SetTime(min, sec);
            Init();
        }

        public CountDownTimer(TimeSpan ts)
        {
            SetTime(ts);
            Init();
        }

        public CountDownTimer()
        {
            Init();
        }

        private void Init()
        {
            StepMs = 1000;
            timer.Tick += new EventHandler(TimerTick);
        }

        public void SetTime(TimeSpan ts)
        {
            _max = ts;
            TimeChanged?.Invoke();
        }

        public void SetTime(int min, int sec = 0) => SetTime(TimeSpan.FromSeconds(min * 60 + sec));

        public void Start()
        {
            timer.Start();
            _stpWatch.Start();
        }

        public void Pause()
        {
            timer.Stop();
            _stpWatch.Stop();
        }

        public void Stop()
        {
            Reset();
            Pause();
        }

        public void Reset()
        {
            _stpWatch.Reset();
        }

        public void Restart()
        {
            _stpWatch.Reset();
            timer.Start();
        }

        public void Dispose() => timer.Dispose();
    }
}
