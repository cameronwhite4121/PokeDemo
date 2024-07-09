using System.Media;
using NAudio;
using NAudio.Wave;

namespace PokeDemo
{
    public partial class Form1 : Form
    {
        private WaveOutEvent output;
        private AudioFileReader audio;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
                Need to import song into project so it plays on startup
                Using Naudio package

                https://github.com/naudio/NAudio/blob/master/Docs/PlayAudioFileWinForms.md 
             */

            output = new WaveOutEvent();
            audio = new AudioFileReader("FireRed & LeafGreen - Battle! Trainer Battle.mp3");
            output.Init(audio);
            output.Play();

            
        }

        private void btnVolumeUp_Click(object sender, EventArgs e)
        {
            audio.Volume += 0.1f;
        }

        private void btnVolumeDown_Click(object sender, EventArgs e)
        {
            audio.Volume -= 0.1f;
        }
    }
}
