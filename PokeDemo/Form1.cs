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
            audio = new AudioFileReader(@"G:\CPTC Classwork\CPW 211 Advanced .Net\PokeDemo\PokeDemo\audio\FireRed & LeafGreen - Battle! Trainer Battle.mp3");
            output.Init(audio);
            output.Play();

            // Joe, my main concern is with file path strings, won't it ONLY work on my computer because someone else's
            // file structure would most likely be completely different? 

        }
    }
}
