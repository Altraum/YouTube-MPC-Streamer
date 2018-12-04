using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace YouTubeClient
{
    public partial class VideoPanel : TableLayoutPanel
    {
        private Label TitleLabel = new Label();
        private Panel ThumbnailPanel = new Panel();
        private Label ChannelLabel = new Label();
        private String videoID = null;
        private String youtubeDlPath = null;
        private String mpcPath = null;
        public VideoPanel()
        {
            InitializeComponent();
            youtubeDlPath = GetYoutubeDL();
            mpcPath = GetMPC();
            TitleLabel.Dock = DockStyle.Fill;
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Font = new Font("Trebuchet MS", 12, FontStyle.Bold);
            ThumbnailPanel.Dock = DockStyle.Fill;
            ThumbnailPanel.Click += new EventHandler(videoPanelEvent);
            ChannelLabel.Dock = DockStyle.Fill;
            ChannelLabel.ForeColor = Color.White;
            ChannelLabel.Font = new Font("Trebuchet MS", ChannelLabel.Font.Size, FontStyle.Bold);
            this.ColumnCount = 1;
            this.RowCount = 3;
            this.Dock = DockStyle.Fill;
            this.Controls.Add(TitleLabel);
            this.Controls.Add(ThumbnailPanel);
            this.Controls.Add(ChannelLabel);
        }

        private String GetYoutubeDL()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"c:\youtubeDLpath.txt");
            if ((line = file.ReadLine()) != null)
            {
                file.Close();
                return line;
            }

            else
            {
                file.Close();
                return null;
            }
        }

        private String GetMPC()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"c:\mpcPath.txt");
            if ((line = file.ReadLine()) != null)
            {
                file.Close();
                return line;
            }

            else
            {
                file.Close();
                return null;
            }
        }

        public string getTitleLabel()
        {
            return TitleLabel.Text;
        }

        public void setTitleLabel(String title)
        {
            TitleLabel.Text = title;
        }

        public String getVideoID()
        {
            return videoID;
        }

        public void setVideoID(String ID)
        {
            videoID = ID;
        }

        public void setThumbnail(String thumbnailURL)
        {
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(thumbnailURL);
            MemoryStream ms = new MemoryStream(bytes);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
            ResizeImage(img, ThumbnailPanel.Width, ThumbnailPanel.Height);
            ThumbnailPanel.BackgroundImage = img;
            ThumbnailPanel.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public  String getChannelTitle()
        {
            return ChannelLabel.Text;
        }

        public void setChannelTitle(String title)
        {
            ChannelLabel.Text = title;
        }

        void videoPanelEvent(object sender, EventArgs e)
        {
            VideoPanel video = (VideoPanel)((Panel)sender).Parent;
            Debug.Print("Loading " + video.getTitleLabel());
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            //startInfo.Arguments = "/C \" FOR /F %i IN ('" + youtubeDlPath + " -f best -g -- " + video.getVideoID() + "')  DO \"" + mpcPath + "\" %i /play \"";
            startInfo.Arguments = "/C \" FOR /F %i IN ('" + youtubeDlPath + " -f bestvideo -g -- " + video.getVideoID() + "')  DO (FOR /F %f IN ('" + youtubeDlPath + " -f bestaudio -g -- " + video.getVideoID() + "')  DO \"" + mpcPath + "\" %i /play /dub %f \")";
            process.StartInfo = startInfo;
            process.Start();
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            ThumbnailPanel.Height = (int)(Width * .5625);
            base.OnPaint(pe);
        }
    }
}
