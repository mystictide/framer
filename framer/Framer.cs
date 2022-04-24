using Emgu.CV;

namespace framer
{
    public partial class Framer : Form
    {
        string[] files;
        string appDir = AppContext.BaseDirectory;

        public Framer()
        {
            InitializeComponent();
        }

        private void Framer_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(appDir + "framed");
        }

        async Task Frame(string ext)
        {
            foreach (var item in files)
            {
                var filename = Path.GetFileNameWithoutExtension(item);
                var filenameExt = Path.GetFileName(item);
                await labelUpdater("processing file " + filename);

                Directory.CreateDirectory(appDir + "framed/" + filename);
                var outputDir = appDir + "framed/" + filename + "/";
                try
                {
                    if (ext == "png")
                    {
                        using (var video = new VideoCapture(item))
                        using (var img = new Mat())
                        {
                            int outputCounter = 1;
                            double fps = video.Get(Emgu.CV.CvEnum.CapProp.Fps);
                            var multiplier = fps * 5;
                            while (video.Grab())
                            {
                                var currentFrame = video.Get(Emgu.CV.CvEnum.CapProp.PosFrames);
                                if (currentFrame % multiplier == 0)
                                {
                                    video.Retrieve(img);
                                    CvInvoke.Imwrite(outputDir + filename + $"-{outputCounter}.png", img);
                                    outputCounter++;
                                }
                            }
                        }
                    }
                    else if (ext == "jpg")
                    {
                        using (var video = new VideoCapture(item))
                        using (var img = new Mat())
                        {
                            int outputCounter = 1;
                            while (video.Grab())
                            {
                                var currentFrame = video.Get(Emgu.CV.CvEnum.CapProp.PosFrames);
                                if (currentFrame % 50 == 0)
                                {
                                    video.Retrieve(img);
                                    CvInvoke.Imwrite(outputDir + filename + $"-{outputCounter}.jpg", img);
                                    outputCounter++;
                                }
                            }
                        }
                    }
                    else if (ext == "bmp")
                    {
                        using (var video = new VideoCapture(item))
                        using (var img = new Mat())
                        {
                            int outputCounter = 1;
                            double fps = video.Get(Emgu.CV.CvEnum.CapProp.Fps);
                            var multiplier = fps * 5;
                            while (video.Grab())
                            {
                                var currentFrame = video.Get(Emgu.CV.CvEnum.CapProp.PosFrames);
                                if (currentFrame % multiplier == 0)
                                {
                                    video.Retrieve(img);
                                    CvInvoke.Imwrite(outputDir + filename + $"-{outputCounter}.bmp", img);
                                    outputCounter++;
                                }
                            }
                        }
                    }
                    await labelUpdater("done processing " + filename);
                }
                catch (Exception ex)
                {
                    await labelUpdater(ex.Message);
                }
            }
        }

        async Task labelUpdater(string msg)
        {
            lblProcess.Text = msg;
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    files = ofd.FileNames;
                    enableButtons();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void enableButtons()
        {
            btnBMP.Enabled = true;
            btnJPG.Enabled = true;
            btnPNG.Enabled = true;
        }

        private async void btnBMP_Click(object sender, EventArgs e)
        {
            await Frame("bmp");
        }

        private async void btnJPG_Click(object sender, EventArgs e)
        {
            await Frame("jpg");
        }

        private async void btnPNG_Click(object sender, EventArgs e)
        {
            await Frame("png");
        }
    }
}