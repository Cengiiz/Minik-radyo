using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://powerturkakustik.listenpowerapp.com/powerturkakustik/mpeg/icecast.audio";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.3.229/;";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://95.173.188.154:9910/;";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://37.247.98.8/stream/27/";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://80.radyopop.com/stream/1/"; 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://17703.live.streamtheworld.com/METRO_FM.mp3"; 
        }

        private void button12_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://37.247.98.8/stream/20/";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://kralpopwmp.radyotvonline.com:80/;";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://17703.live.streamtheworld.com/JOY_FM.mp3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://yayin2.canliyayin.org:8866/;"; 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://gebzefm.radyotvyayini.com:9530/;";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://stream.radyo45lik.com:4545/;stream.mp3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
