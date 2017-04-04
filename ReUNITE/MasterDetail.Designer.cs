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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.TextToImageBtn = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.detailsDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1486, 696);
            this.splitContainer1.SplitterDistance = 473;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.searchTextBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.masterDataGridView);
            this.splitContainer2.Size = new System.Drawing.Size(1486, 473);
            this.splitContainer2.SplitterDistance = 52;
            this.splitContainer2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(728, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Analytics & Reports";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search By Child Name:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(251, 17);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(440, 30);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // masterDataGridView
            // 
            this.masterDataGridView.AllowUserToAddRows = false;
            this.masterDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.masterDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.masterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.masterDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.masterDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.masterDataGridView.Location = new System.Drawing.Point(0, 0);
            this.masterDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.masterDataGridView.MultiSelect = false;
            this.masterDataGridView.Name = "masterDataGridView";
            this.masterDataGridView.RowTemplate.Height = 24;
            this.masterDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.masterDataGridView.Size = new System.Drawing.Size(1486, 417);
            this.masterDataGridView.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.TextToImageBtn);
            this.panel1.Controls.Add(this.YouTubeBtn);
            this.panel1.Controls.Add(this.InstagramBtn);
            this.panel1.Controls.Add(this.FacebookBtn);
            this.panel1.Controls.Add(this.TwitterBtn);
            this.panel1.Controls.Add(this.GoogleImgMatchBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.GoogleSearchBtn);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1486, 122);
            this.panel1.TabIndex = 3;
            // 
            // YouTubeBtn
            // 
            this.YouTubeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.YouTubeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YouTubeBtn.Location = new System.Drawing.Point(1085, 68);
            this.YouTubeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.YouTubeBtn.Name = "YouTubeBtn";
            this.YouTubeBtn.Size = new System.Drawing.Size(187, 39);
            this.YouTubeBtn.TabIndex = 9;
            this.YouTubeBtn.Text = "YouTube";
            this.YouTubeBtn.UseVisualStyleBackColor = true;
            this.YouTubeBtn.Click += new System.EventHandler(this.YouTubeBtn_Click);
            // 
            // InstagramBtn
            // 
            this.InstagramBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InstagramBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstagramBtn.Location = new System.Drawing.Point(865, 68);
            this.InstagramBtn.Margin = new System.Windows.Forms.Padding(4);
            this.InstagramBtn.Name = "InstagramBtn";
            this.InstagramBtn.Size = new System.Drawing.Size(212, 39);
            this.InstagramBtn.TabIndex = 8;
            this.InstagramBtn.Text = "Instagram";
            this.InstagramBtn.UseVisualStyleBackColor = true;
            this.InstagramBtn.Click += new System.EventHandler(this.InstagramBtn_Click);
            // 
            // FacebookBtn
            // 
            this.FacebookBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FacebookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacebookBtn.Location = new System.Drawing.Point(668, 67);
            this.FacebookBtn.Margin = new System.Windows.Forms.Padding(4);
            this.FacebookBtn.Name = "FacebookBtn";
            this.FacebookBtn.Size = new System.Drawing.Size(189, 39);
            this.FacebookBtn.TabIndex = 7;
            this.FacebookBtn.Text = "Facebook";
            this.FacebookBtn.UseVisualStyleBackColor = true;
            this.FacebookBtn.Click += new System.EventHandler(this.FacebookBtn_Click);
            // 
            // TwitterBtn
            // 
            this.TwitterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TwitterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwitterBtn.Location = new System.Drawing.Point(452, 68);
            this.TwitterBtn.Margin = new System.Windows.Forms.Padding(4);
            this.TwitterBtn.Name = "TwitterBtn";
            this.TwitterBtn.Size = new System.Drawing.Size(208, 39);
            this.TwitterBtn.TabIndex = 6;
            this.TwitterBtn.Text = "Twitter";
            this.TwitterBtn.UseVisualStyleBackColor = true;
            this.TwitterBtn.Click += new System.EventHandler(this.TwitterBtn_Click);
            // 
            // GoogleImgMatchBtn
            // 
            this.GoogleImgMatchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GoogleImgMatchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoogleImgMatchBtn.Location = new System.Drawing.Point(228, 68);
            this.GoogleImgMatchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GoogleImgMatchBtn.Name = "GoogleImgMatchBtn";
            this.GoogleImgMatchBtn.Size = new System.Drawing.Size(216, 39);
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
            this.label3.Location = new System.Drawing.Point(487, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Social Media Quick Search";
            // 
            // GoogleSearchBtn
            // 
            this.GoogleSearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GoogleSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoogleSearchBtn.Location = new System.Drawing.Point(31, 67);
            this.GoogleSearchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GoogleSearchBtn.Name = "GoogleSearchBtn";
            this.GoogleSearchBtn.Size = new System.Drawing.Size(189, 39);
            this.GoogleSearchBtn.TabIndex = 0;
            this.GoogleSearchBtn.Text = "Google Search";
            this.GoogleSearchBtn.UseVisualStyleBackColor = true;
            this.GoogleSearchBtn.Click += new System.EventHandler(this.GoogleSearchBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-5, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Additional Details:";
            // 
            // detailsDataGridView
            // 
            this.detailsDataGridView.AllowUserToAddRows = false;
            this.detailsDataGridView.AllowUserToDeleteRows = false;
            this.detailsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detailsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.detailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.detailsDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.detailsDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.detailsDataGridView.Location = new System.Drawing.Point(0, 31);
            this.detailsDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.detailsDataGridView.Name = "detailsDataGridView";
            this.detailsDataGridView.ReadOnly = true;
            this.detailsDataGridView.RowTemplate.Height = 24;
            this.detailsDataGridView.Size = new System.Drawing.Size(1486, 65);
            this.detailsDataGridView.TabIndex = 1;
            // 
            // TextToImageBtn
            // 
            this.TextToImageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TextToImageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextToImageBtn.Location = new System.Drawing.Point(1280, 67);
            this.TextToImageBtn.Margin = new System.Windows.Forms.Padding(4);
            this.TextToImageBtn.Name = "TextToImageBtn";
            this.TextToImageBtn.Size = new System.Drawing.Size(187, 39);
            this.TextToImageBtn.TabIndex = 10;
            this.TextToImageBtn.Text = "Text To Image Search";
            this.TextToImageBtn.UseVisualStyleBackColor = true;
            this.TextToImageBtn.Click += new System.EventHandler(this.TextToImageBtn_Click);
            // 
            // MasterDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1486, 696);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MasterDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Missing Child Details Viewer";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
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
        private Button TextToImageBtn;
    }
}