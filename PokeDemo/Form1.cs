namespace PokeDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.R
            pictureBox2.Image = Image.FromFile("PokeDemo/sprites/firebird.png");
        }
    }
}
