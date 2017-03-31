using System.Windows.Forms;

namespace ReUNITE
{
    partial class MasterDetail
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.masterDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.YouTubeBtn = new System.Windows.Forms.Button();
            this.InstagramBtn = new System.Windows.Forms.Button();
            this.FacebookBtn = new System.Windows.Forms.Button();
            this.TwitterBtn = new System.Windows.Forms.Button();
            this.GoogleImgMatchBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.GoogleSearchBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.detailsDataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.googleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byNameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.detailsDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(981, 615);
            this.splitContainer1.SplitterDistance = 418;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.searchTextBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.masterDataGridView);
            this.splitContainer2.Size = new System.Drawing.Size(981, 418);
            this.splitContainer2.SplitterDistance = 47;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(546, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Analytics & Reports";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search By Child Name";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(188, 14);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(331, 20);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // masterDataGridView
            // 
            this.masterDataGridView.AllowUserToAddRows = false;
            this.masterDataGridView.AllowUserToDeleteRows = false;
            this.masterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.masterDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.masterDataGridView.Location = new System.Drawing.Point(0, 0);
            this.masterDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.masterDataGridView.MultiSelect = false;
            this.masterDataGridView.Name = "masterDataGridView";
            this.masterDataGridView.RowTemplate.Height = 24;
            this.masterDataGridView.Size = new System.Drawing.Size(981, 368);
            this.masterDataGridView.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.YouTubeBtn);
            this.panel1.Controls.Add(this.InstagramBtn);
            this.panel1.Controls.Add(this.FacebookBtn);
            this.panel1.Controls.Add(this.TwitterBtn);
            this.panel1.Controls.Add(this.GoogleImgMatchBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.GoogleSearchBtn);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 92);
            this.panel1.TabIndex = 3;
            // 
            // YouTubeBtn
            // 
            this.YouTubeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.YouTubeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YouTubeBtn.Location = new System.Drawing.Point(817, 40);
            this.YouTubeBtn.Name = "YouTubeBtn";
            this.YouTubeBtn.Size = new System.Drawing.Size(140, 32);
            this.YouTubeBtn.TabIndex = 9;
            this.YouTubeBtn.Text = "YouTube";
            this.YouTubeBtn.UseVisualStyleBackColor = true;
            this.YouTubeBtn.Click += new System.EventHandler(this.YouTubeBtn_Click);
            // 
            // InstagramBtn
            // 
            this.InstagramBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InstagramBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstagramBtn.Location = new System.Drawing.Point(652, 40);
            this.InstagramBtn.Name = "InstagramBtn";
            this.InstagramBtn.Size = new System.Drawing.Size(159, 32);
            this.InstagramBtn.TabIndex = 8;
            this.InstagramBtn.Text = "Instagram";
            this.InstagramBtn.UseVisualStyleBackColor = true;
            this.InstagramBtn.Click += new System.EventHandler(this.InstagramBtn_Click);
            // 
            // FacebookBtn
            // 
            this.FacebookBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FacebookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacebookBtn.Location = new System.Drawing.Point(504, 39);
            this.FacebookBtn.Name = "FacebookBtn";
            this.FacebookBtn.Size = new System.Drawing.Size(142, 32);
            this.FacebookBtn.TabIndex = 7;
            this.FacebookBtn.Text = "Facebook";
            this.FacebookBtn.UseVisualStyleBackColor = true;
            this.FacebookBtn.Click += new System.EventHandler(this.FacebookBtn_Click);
            // 
            // TwitterBtn
            // 
            this.TwitterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TwitterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwitterBtn.Location = new System.Drawing.Point(342, 40);
            this.TwitterBtn.Name = "TwitterBtn";
            this.TwitterBtn.Size = new System.Drawing.Size(156, 32);
            this.TwitterBtn.TabIndex = 6;
            this.TwitterBtn.Text = "Twitter";
            this.TwitterBtn.UseVisualStyleBackColor = true;
            this.TwitterBtn.Click += new System.EventHandler(this.TwitterBtn_Click);
            // 
            // GoogleImgMatchBtn
            // 
            this.GoogleImgMatchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GoogleImgMatchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoogleImgMatchBtn.Location = new System.Drawing.Point(174, 40);
            this.GoogleImgMatchBtn.Name = "GoogleImgMatchBtn";
            this.GoogleImgMatchBtn.Size = new System.Drawing.Size(162, 32);
            this.GoogleImgMatchBtn.TabIndex = 5;
            this.GoogleImgMatchBtn.Text = "Google Image Match";
            this.GoogleImgMatchBtn.UseVisualStyleBackColor = true;
            this.GoogleImgMatchBtn.Click += new System.EventHandler(this.GoogleImgMatchBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(395, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Social Media Channels";
            // 
            // GoogleSearchBtn
            // 
            this.GoogleSearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GoogleSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoogleSearchBtn.Location = new System.Drawing.Point(26, 39);
            this.GoogleSearchBtn.Name = "GoogleSearchBtn";
            this.GoogleSearchBtn.Size = new System.Drawing.Size(142, 32);
            this.GoogleSearchBtn.TabIndex = 0;
            this.GoogleSearchBtn.Text = "Google Search";
            this.GoogleSearchBtn.UseVisualStyleBackColor = true;
            this.GoogleSearchBtn.Click += new System.EventHandler(this.GoogleSearchBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-4, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Detailed Information for a Selected Kid";
            // 
            // detailsDataGridView
            // 
            this.detailsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.detailsDataGridView.Location = new System.Drawing.Point(0, 25);
            this.detailsDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.detailsDataGridView.Name = "detailsDataGridView";
            this.detailsDataGridView.RowTemplate.Height = 24;
            this.detailsDataGridView.Size = new System.Drawing.Size(979, 87);
            this.detailsDataGridView.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.googleToolStripMenuItem,
            this.twitterToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 48);
            // 
            // googleToolStripMenuItem
            // 
            this.googleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byImageToolStripMenuItem,
            this.byNameToolStripMenuItem});
            this.googleToolStripMenuItem.Name = "googleToolStripMenuItem";
            this.googleToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.googleToolStripMenuItem.Text = "Google";
            // 
            // byImageToolStripMenuItem
            // 
            this.byImageToolStripMenuItem.Name = "byImageToolStripMenuItem";
            this.byImageToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.byImageToolStripMenuItem.Text = "By Image";
            // 
            // byNameToolStripMenuItem
            // 
            this.byNameToolStripMenuItem.Name = "byNameToolStripMenuItem";
            this.byNameToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.byNameToolStripMenuItem.Text = "By Name";
            // 
            // twitterToolStripMenuItem
            // 
            this.twitterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byNameToolStripMenuItem1});
            this.twitterToolStripMenuItem.Name = "twitterToolStripMenuItem";
            this.twitterToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.twitterToolStripMenuItem.Text = "Twitter";
            // 
            // byNameToolStripMenuItem1
            // 
            this.byNameToolStripMenuItem1.Name = "byNameToolStripMenuItem1";
            this.byNameToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.byNameToolStripMenuItem1.Text = "By Name";
            // 
            // MasterDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 615);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MasterDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterDetail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem googleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byNameToolStripMenuItem1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView masterDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView detailsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GoogleSearchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GoogleImgMatchBtn;
        private System.Windows.Forms.Button FacebookBtn;
        private System.Windows.Forms.Button TwitterBtn;
        private System.Windows.Forms.Button InstagramBtn;
        private System.Windows.Forms.Button YouTubeBtn;
    }
}