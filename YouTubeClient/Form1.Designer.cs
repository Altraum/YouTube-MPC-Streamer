namespace YouTubeClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.navPanel = new System.Windows.Forms.Panel();
            this.browsePanel = new System.Windows.Forms.Panel();
            this.browseLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SearchResultPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BrowseBarTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.urlTextbox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.navPanel.SuspendLayout();
            this.browsePanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.BrowseBarTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.navPanel.Controls.Add(this.browsePanel);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navPanel.Location = new System.Drawing.Point(0, 50);
            this.navPanel.Margin = new System.Windows.Forms.Padding(0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(120, 631);
            this.navPanel.TabIndex = 3;
            // 
            // browsePanel
            // 
            this.browsePanel.Controls.Add(this.browseLabel);
            this.browsePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.browsePanel.Location = new System.Drawing.Point(0, 0);
            this.browsePanel.Name = "browsePanel";
            this.browsePanel.Size = new System.Drawing.Size(120, 54);
            this.browsePanel.TabIndex = 0;
            // 
            // browseLabel
            // 
            this.browseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browseLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseLabel.ForeColor = System.Drawing.Color.White;
            this.browseLabel.Location = new System.Drawing.Point(0, 0);
            this.browseLabel.Name = "browseLabel";
            this.browseLabel.Size = new System.Drawing.Size(120, 54);
            this.browseLabel.TabIndex = 0;
            this.browseLabel.Text = "Browse";
            this.browseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.browseLabel.Click += new System.EventHandler(this.browseLabel_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 2;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainPanel.Controls.Add(this.navPanel, 0, 1);
            this.mainPanel.Controls.Add(this.SearchResultPanel, 1, 1);
            this.mainPanel.Controls.Add(this.BrowseBarTablePanel, 1, 0);
            this.mainPanel.Controls.Add(this.logoPicture, 0, 0);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 2;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainPanel.Size = new System.Drawing.Size(1264, 681);
            this.mainPanel.TabIndex = 4;
            // 
            // SearchResultPanel
            // 
            this.SearchResultPanel.AutoScroll = true;
            this.SearchResultPanel.ColumnCount = 5;
            this.SearchResultPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SearchResultPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SearchResultPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SearchResultPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SearchResultPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SearchResultPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchResultPanel.Location = new System.Drawing.Point(123, 53);
            this.SearchResultPanel.Name = "SearchResultPanel";
            this.SearchResultPanel.RowCount = 2;
            this.SearchResultPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SearchResultPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SearchResultPanel.Size = new System.Drawing.Size(1138, 625);
            this.SearchResultPanel.TabIndex = 6;
            // 
            // BrowseBarTablePanel
            // 
            this.BrowseBarTablePanel.ColumnCount = 2;
            this.BrowseBarTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BrowseBarTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BrowseBarTablePanel.Controls.Add(this.urlTextbox, 0, 0);
            this.BrowseBarTablePanel.Controls.Add(this.SearchBtn, 1, 0);
            this.BrowseBarTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowseBarTablePanel.Location = new System.Drawing.Point(123, 3);
            this.BrowseBarTablePanel.Name = "BrowseBarTablePanel";
            this.BrowseBarTablePanel.RowCount = 1;
            this.BrowseBarTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BrowseBarTablePanel.Size = new System.Drawing.Size(1138, 44);
            this.BrowseBarTablePanel.TabIndex = 7;
            // 
            // urlTextbox
            // 
            this.urlTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.urlTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.urlTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urlTextbox.Font = new System.Drawing.Font("Trebuchet MS", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlTextbox.ForeColor = System.Drawing.Color.LightGray;
            this.urlTextbox.Location = new System.Drawing.Point(0, 0);
            this.urlTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.urlTextbox.Name = "urlTextbox";
            this.urlTextbox.Size = new System.Drawing.Size(1078, 50);
            this.urlTextbox.TabIndex = 3;
            this.urlTextbox.TabStop = false;
            this.urlTextbox.Text = "Giant Bomb";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SearchBtn.AutoSize = true;
            this.SearchBtn.Location = new System.Drawing.Point(1081, 3);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(54, 38);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // logoPicture
            // 
            this.logoPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPicture.BackgroundImage")));
            this.logoPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPicture.InitialImage = null;
            this.logoPicture.Location = new System.Drawing.Point(0, 0);
            this.logoPicture.Margin = new System.Windows.Forms.Padding(0);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(120, 50);
            this.logoPicture.TabIndex = 8;
            this.logoPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.SearchBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 39);
            this.Name = "Form1";
            this.Text = "YouTube";
            this.navPanel.ResumeLayout(false);
            this.browsePanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.BrowseBarTablePanel.ResumeLayout(false);
            this.BrowseBarTablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.Panel browsePanel;
        private System.Windows.Forms.Label browseLabel;
        private System.Windows.Forms.TableLayoutPanel SearchResultPanel;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox urlTextbox;
        private System.Windows.Forms.TableLayoutPanel BrowseBarTablePanel;
        private System.Windows.Forms.PictureBox logoPicture;
    }
}

