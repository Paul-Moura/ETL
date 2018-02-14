namespace ETL.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnLoadData = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConfigureFields = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnReview = new System.Windows.Forms.Button();
            this.lblSource = new System.Windows.Forms.LinkLabel();
            this.lblConfigure = new System.Windows.Forms.Label();
            this.lblProcess = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnMapFields = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadData
            // 
            this.btnLoadData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoadData.ImageIndex = 0;
            this.btnLoadData.ImageList = this.imageList1;
            this.btnLoadData.Location = new System.Drawing.Point(41, 67);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(120, 80);
            this.btnLoadData.TabIndex = 0;
            this.btnLoadData.Text = "\r\n\r\n\r\nLoad Source Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_Open_32xLG.png");
            this.imageList1.Images.SetKeyName(1, "action_add_16xLG.png");
            this.imageList1.Images.SetKeyName(2, "arrow1600.png");
            this.imageList1.Images.SetKeyName(3, "Settings.ico");
            this.imageList1.Images.SetKeyName(4, "Editor.ico");
            this.imageList1.Images.SetKeyName(5, "screen_resolution1600.png");
            this.imageList1.Images.SetKeyName(6, "save.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Source and Processing Instructions";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(455, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // btnConfigureFields
            // 
            this.btnConfigureFields.Enabled = false;
            this.btnConfigureFields.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfigureFields.ImageIndex = 2;
            this.btnConfigureFields.ImageList = this.imageList1;
            this.btnConfigureFields.Location = new System.Drawing.Point(167, 67);
            this.btnConfigureFields.Name = "btnConfigureFields";
            this.btnConfigureFields.Size = new System.Drawing.Size(120, 80);
            this.btnConfigureFields.TabIndex = 7;
            this.btnConfigureFields.Text = "\r\n\r\n\r\nConfigure Target Fields";
            this.btnConfigureFields.UseVisualStyleBackColor = true;
            this.btnConfigureFields.Click += new System.EventHandler(this.btnConfigureFields_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Enabled = false;
            this.btnProcess.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProcess.ImageIndex = 3;
            this.btnProcess.ImageList = this.imageList1;
            this.btnProcess.Location = new System.Drawing.Point(41, 218);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(120, 80);
            this.btnProcess.TabIndex = 8;
            this.btnProcess.Text = "\r\n\r\n\r\nProcess";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Post-Processing";
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExport.ImageIndex = 6;
            this.btnExport.ImageList = this.imageList1;
            this.btnExport.Location = new System.Drawing.Point(293, 218);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 80);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "\r\n\r\n\r\nExport";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnReview
            // 
            this.btnReview.Enabled = false;
            this.btnReview.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReview.ImageIndex = 4;
            this.btnReview.ImageList = this.imageList1;
            this.btnReview.Location = new System.Drawing.Point(167, 218);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(120, 80);
            this.btnReview.TabIndex = 12;
            this.btnReview.Text = "\r\n\r\n\r\nReview/Edit";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // lblSource
            // 
            this.lblSource.Location = new System.Drawing.Point(41, 150);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(120, 13);
            this.lblSource.TabIndex = 13;
            this.lblSource.TabStop = true;
            this.lblSource.Text = "[10000 rows]";
            this.lblSource.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSource.Visible = false;
            this.lblSource.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSource_LinkClicked);
            // 
            // lblConfigure
            // 
            this.lblConfigure.Location = new System.Drawing.Point(167, 150);
            this.lblConfigure.Name = "lblConfigure";
            this.lblConfigure.Size = new System.Drawing.Size(120, 13);
            this.lblConfigure.TabIndex = 15;
            this.lblConfigure.TabStop = true;
            this.lblConfigure.Text = "[7 fields configured]";
            this.lblConfigure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConfigure.Visible = false;
            // 
            // lblProcess
            // 
            this.lblProcess.Location = new System.Drawing.Point(41, 301);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(120, 13);
            this.lblProcess.TabIndex = 16;
            this.lblProcess.TabStop = true;
            this.lblProcess.Text = "[10000 rows]";
            this.lblProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProcess.Visible = false;
            // 
            // lblEdit
            // 
            this.lblEdit.Location = new System.Drawing.Point(167, 301);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(120, 13);
            this.lblEdit.TabIndex = 17;
            this.lblEdit.TabStop = true;
            this.lblEdit.Text = "[10000 rows]";
            this.lblEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEdit.Visible = false;
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 355);
            this.listBox.Name = "listBox";
            this.listBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox.Size = new System.Drawing.Size(431, 173);
            this.listBox.TabIndex = 18;
            // 
            // btnMapFields
            // 
            this.btnMapFields.Enabled = false;
            this.btnMapFields.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMapFields.ImageIndex = 2;
            this.btnMapFields.ImageList = this.imageList1;
            this.btnMapFields.Location = new System.Drawing.Point(293, 67);
            this.btnMapFields.Name = "btnMapFields";
            this.btnMapFields.Size = new System.Drawing.Size(120, 80);
            this.btnMapFields.TabIndex = 19;
            this.btnMapFields.Text = "\r\n\r\n\r\nMap Source to Output";
            this.btnMapFields.UseVisualStyleBackColor = true;
            this.btnMapFields.Click += new System.EventHandler(this.btnMapFields_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(293, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 20;
            this.label3.TabStop = true;
            this.label3.Text = "[7 fields configured]";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(293, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 21;
            this.label4.TabStop = true;
            this.label4.Text = "[10000 rows]";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 540);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMapFields);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.lblConfigure);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnConfigureFields);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ETL Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.Button btnConfigureFields;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.LinkLabel lblSource;
        private System.Windows.Forms.Label lblConfigure;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnMapFields;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

