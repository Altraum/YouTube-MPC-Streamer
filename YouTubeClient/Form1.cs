using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

using Google.Apis.Services;
using Google.Apis.YouTube.v3;

namespace YouTubeClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            urlTextbox.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
        }

        private String GetAPI()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"c:\api.txt");
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

        private void browseLabel_Click(object sender, EventArgs e)
        {
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Debug.Print("Searching for " + urlTextbox.Text);
            //TableLayoutPanel SearchResultPanel = new TableLayoutPanel();
            SearchResultPanel.AutoScroll = true;
            SearchResultPanel.ColumnCount = 5;

            SearchResultPanel.Dock = DockStyle.Fill;

            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = GetAPI(),
                ApplicationName = this.GetType().ToString()
            });

            var searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.Q = urlTextbox.Text;
            searchListRequest.MaxResults = 25;
            searchListRequest.Type = "video";

            List<string> videos = new List<string>();
            //List<string> channels = new List<string>();
            //List<string> playlists = new List<string>();

            var searchListResponse = searchListRequest.Execute();

            SearchResultPanel.SuspendLayout();

            SearchResultPanel.Controls.Clear();
            SearchResultPanel.RowStyles.Clear();
            for (int x = 0; x < SearchResultPanel.ColumnCount; x++)
            {
                SearchResultPanel.RowStyles.Add(new RowStyle() { Height = 275, SizeType = SizeType.Absolute });
            }

            foreach (var searchResult in searchListResponse.Items)
            {
                switch (searchResult.Id.Kind)
                {
                    case "youtube#video":
                        VideoPanel VidPanel = new VideoPanel();
                        VidPanel.setVideoID(searchResult.Id.VideoId);
                        VidPanel.setTitleLabel(searchResult.Snippet.Title);
                        VidPanel.setChannelTitle(searchResult.Snippet.ChannelTitle);
                        VidPanel.setThumbnail(searchResult.Snippet.Thumbnails.Medium.Url);
                        SearchResultPanel.Controls.Add(VidPanel);
                        break;

                    case "youtube#channel":
                        //channels.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.ChannelId));
                        break;

                    case "youtube#playlist":
                        //playlists.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.PlaylistId));
                        break;
                }
            }

            SearchResultPanel.ResumeLayout();
        }
    }
}
