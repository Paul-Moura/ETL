namespace ETL.Forms
{
    partial class MapFieldsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapFieldsControl));
            this.lstSourceFields = new System.Windows.Forms.CheckedListBox();
            this.lstOutputFields = new System.Windows.Forms.CheckedListBox();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.ddlSourcePages = new Telerik.WinControls.UI.RadDropDownList();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.ddlOutputPages = new Telerik.WinControls.UI.RadDropDownList();
            this.btnTargetUp = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnTargetDown = new System.Windows.Forms.Button();
            this.fieldInfoControl1 = new ETL.Forms.FieldInfoControl();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlSourcePages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlOutputPages)).BeginInit();
            this.SuspendLayout();
            // 
            // lstSourceFields
            // 
            this.lstSourceFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstSourceFields.FormattingEnabled = true;
            this.lstSourceFields.Location = new System.Drawing.Point(5, 44);
            this.lstSourceFields.Name = "lstSourceFields";
            this.lstSourceFields.Size = new System.Drawing.Size(240, 548);
            this.lstSourceFields.TabIndex = 0;
            this.lstSourceFields.SelectedIndexChanged += new System.EventHandler(this.lstSourceFields_SelectedIndexChanged);
            // 
            // lstOutputFields
            // 
            this.lstOutputFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstOutputFields.FormattingEnabled = true;
            this.lstOutputFields.Location = new System.Drawing.Point(5, 44);
            this.lstOutputFields.Name = "lstOutputFields";
            this.lstOutputFields.Size = new System.Drawing.Size(240, 548);
            this.lstOutputFields.TabIndex = 1;
            this.lstOutputFields.SelectedIndexChanged += new System.EventHandler(this.lstOutputFields_SelectedIndexChanged);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.ddlSourcePages);
            this.radGroupBox1.Controls.Add(this.btnTargetUp);
            this.radGroupBox1.Controls.Add(this.lstSourceFields);
            this.radGroupBox1.Controls.Add(this.btnTargetDown);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radGroupBox1.HeaderText = "Source Fields";
            this.radGroupBox1.Location = new System.Drawing.Point(250, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(250, 642);
            this.radGroupBox1.TabIndex = 2;
            this.radGroupBox1.Text = "Source Fields";
            // 
            // ddlSourcePages
            // 
            this.ddlSourcePages.Location = new System.Drawing.Point(5, 18);
            this.ddlSourcePages.Name = "ddlSourcePages";
            this.ddlSourcePages.Size = new System.Drawing.Size(239, 20);
            this.ddlSourcePages.TabIndex = 1;
            this.ddlSourcePages.Text = "radDropDownList1";
            this.ddlSourcePages.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddlSourcePages_SelectedIndexChanged);
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.ddlOutputPages);
            this.radGroupBox2.Controls.Add(this.lstOutputFields);
            this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.radGroupBox2.HeaderText = "Output Fields";
            this.radGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(250, 642);
            this.radGroupBox2.TabIndex = 3;
            this.radGroupBox2.Text = "Output Fields";
            // 
            // ddlOutputPages
            // 
            this.ddlOutputPages.Location = new System.Drawing.Point(6, 18);
            this.ddlOutputPages.Name = "ddlOutputPages";
            this.ddlOutputPages.Size = new System.Drawing.Size(238, 20);
            this.ddlOutputPages.TabIndex = 11;
            this.ddlOutputPages.Text = "radDropDownList2";
            this.ddlOutputPages.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddlOutputPages_SelectedIndexChanged);
            // 
            // btnTargetUp
            // 
            this.btnTargetUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTargetUp.Enabled = false;
            this.btnTargetUp.ImageIndex = 2;
            this.btnTargetUp.ImageList = this.imageList1;
            this.btnTargetUp.Location = new System.Drawing.Point(158, 598);
            this.btnTargetUp.Name = "btnTargetUp";
            this.btnTargetUp.Size = new System.Drawing.Size(40, 40);
            this.btnTargetUp.TabIndex = 10;
            this.btnTargetUp.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Next_grey_24x.png");
            this.imageList1.Images.SetKeyName(1, "ClearWindowContent_16x.png");
            this.imageList1.Images.SetKeyName(2, "Upload_gray_48x.png");
            this.imageList1.Images.SetKeyName(3, "Download_grey_48x.png");
            this.imageList1.Images.SetKeyName(4, "action_add_16xLG.png");
            this.imageList1.Images.SetKeyName(5, "Remove_color_16x.png");
            this.imageList1.Images.SetKeyName(6, "new.png");
            this.imageList1.Images.SetKeyName(7, "save.png");
            this.imageList1.Images.SetKeyName(8, "open.png");
            this.imageList1.Images.SetKeyName(9, "Previous_grey_48x.png");
            // 
            // btnTargetDown
            // 
            this.btnTargetDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTargetDown.Enabled = false;
            this.btnTargetDown.ImageIndex = 3;
            this.btnTargetDown.ImageList = this.imageList1;
            this.btnTargetDown.Location = new System.Drawing.Point(204, 598);
            this.btnTargetDown.Name = "btnTargetDown";
            this.btnTargetDown.Size = new System.Drawing.Size(40, 40);
            this.btnTargetDown.TabIndex = 9;
            this.btnTargetDown.UseVisualStyleBackColor = true;
            // 
            // fieldInfoControl1
            // 
            this.fieldInfoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldInfoControl1.Enabled = false;
            this.fieldInfoControl1.Location = new System.Drawing.Point(500, 0);
            this.fieldInfoControl1.Name = "fieldInfoControl1";
            this.fieldInfoControl1.ShowFieldProperties = false;
            this.fieldInfoControl1.Size = new System.Drawing.Size(336, 642);
            this.fieldInfoControl1.TabIndex = 4;
            // 
            // MapFieldsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fieldInfoControl1);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radGroupBox2);
            this.DoubleBuffered = true;
            this.Name = "MapFieldsControl";
            this.Size = new System.Drawing.Size(836, 642);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlSourcePages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlOutputPages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstSourceFields;
        private System.Windows.Forms.CheckedListBox lstOutputFields;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnTargetUp;
        private System.Windows.Forms.Button btnTargetDown;
        private FieldInfoControl fieldInfoControl1;
        private Telerik.WinControls.UI.RadDropDownList ddlSourcePages;
        private Telerik.WinControls.UI.RadDropDownList ddlOutputPages;
    }
}
