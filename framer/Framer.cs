namespace framer
{
    public partial class Framer : Form
    {
        public Framer()
        {
            InitializeComponent();
        }

        private void Framer_Load(object sender, EventArgs e)
        {

        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            enableButtons();
        }

        void enableButtons()
        {
            btnBMP.Enabled = true;
            btnJPG.Enabled = true;
            btnPNG.Enabled = true;
        }
    }
}