namespace ETL.Forms
{
    partial class ManageFieldsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageFieldsControl));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnTargetUp = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnTargetDown = new System.Windows.Forms.Button();
            this.btnNewTarget = new System.Windows.Forms.Button();
            this.btnRemoveTargetAll = new System.Windows.Forms.Button();
            this.btnRemoveTarget = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstSource = new System.Windows.Forms.ListBox();
            this.btnAddSource = new System.Windows.Forms.Button();
            this.btnAddSourceAll = new System.Windows.Forms.Button();
            this.fieldInfoControl = new ETL.Forms.FieldInfoControl();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.lstOutput);
            this.groupBox2.Controls.Add(this.btnTargetUp);
            this.groupBox2.Controls.Add(this.btnTargetDown);
            this.groupBox2.Controls.Add(this.btnNewTarget);
            this.groupBox2.Controls.Add(this.btnRemoveTargetAll);
            this.groupBox2.Controls.Add(this.btnRemoveTarget);
            this.groupBox2.Location = new System.Drawing.Point(259, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 589);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Fields";
            // 
            // lstOutput
            // 
            this.lstOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(6, 19);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstOutput.Size = new System.Drawing.Size(238, 498);
            this.lstOutput.TabIndex = 9;
            this.lstOutput.SelectedValueChanged += new System.EventHandler(this.lstOutput_SelectedValueChanged);
            // 
            // btnTargetUp
            // 
            this.btnTargetUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTargetUp.Enabled = false;
            this.btnTargetUp.ImageIndex = 2;
            this.btnTargetUp.ImageList = this.imageList1;
            this.btnTargetUp.Location = new System.Drawing.Point(52, 543);
            this.btnTargetUp.Name = "btnTargetUp";
            this.btnTargetUp.Size = new System.Drawing.Size(40, 40);
            this.btnTargetUp.TabIndex = 8;
            this.btnTargetUp.UseVisualStyleBackColor = true;
            this.btnTargetUp.Click += new System.EventHandler(this.btnTargetUp_Click);
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
            this.btnTargetDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTargetDown.Enabled = false;
            this.btnTargetDown.ImageIndex = 3;
            this.btnTargetDown.ImageList = this.imageList1;
            this.btnTargetDown.Location = new System.Drawing.Point(98, 543);
            this.btnTargetDown.Name = "btnTargetDown";
            this.btnTargetDown.Size = new System.Drawing.Size(40, 40);
            this.btnTargetDown.TabIndex = 7;
            this.btnTargetDown.UseVisualStyleBackColor = true;
            this.btnTargetDown.Click += new System.EventHandler(this.btnTargetDown_Click);
            // 
            // btnNewTarget
            // 
            this.btnNewTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewTarget.ImageIndex = 4;
            this.btnNewTarget.ImageList = this.imageList1;
            this.btnNewTarget.Location = new System.Drawing.Point(6, 543);
            this.btnNewTarget.Name = "btnNewTarget";
            this.btnNewTarget.Size = new System.Drawing.Size(40, 40);
            this.btnNewTarget.TabIndex = 6;
            this.btnNewTarget.UseVisualStyleBackColor = true;
            this.btnNewTarget.Click += new System.EventHandler(this.btnNewTarget_Click);
            // 
            // btnRemoveTargetAll
            // 
            this.btnRemoveTargetAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveTargetAll.Enabled = false;
            this.btnRemoveTargetAll.ImageIndex = 1;
            this.btnRemoveTargetAll.ImageList = this.imageList1;
            this.btnRemoveTargetAll.Location = new System.Drawing.Point(204, 543);
            this.btnRemoveTargetAll.Name = "btnRemoveTargetAll";
            this.btnRemoveTargetAll.Size = new System.Drawing.Size(40, 40);
            this.btnRemoveTargetAll.TabIndex = 1;
            this.btnRemoveTargetAll.UseVisualStyleBackColor = true;
            this.btnRemoveTargetAll.Click += new System.EventHandler(this.btnRemoveTargetAll_Click);
            // 
            // btnRemoveTarget
            // 
            this.btnRemoveTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveTarget.Enabled = false;
            this.btnRemoveTarget.ImageIndex = 5;
            this.btnRemoveTarget.ImageList = this.imageList1;
            this.btnRemoveTarget.Location = new System.Drawing.Point(158, 543);
            this.btnRemoveTarget.Name = "btnRemoveTarget";
            this.btnRemoveTarget.Size = new System.Drawing.Size(40, 40);
            this.btnRemoveTarget.TabIndex = 0;
            this.btnRemoveTarget.UseVisualStyleBackColor = true;
            this.btnRemoveTarget.Click += new System.EventHandler(this.btnRemoveTarget_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lstSource);
            this.groupBox1.Controls.Add(this.btnAddSource);
            this.groupBox1.Controls.Add(this.btnAddSourceAll);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 589);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Source Fields";
            // 
            // lstSource
            // 
            this.lstSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSource.FormattingEnabled = true;
            this.lstSource.Location = new System.Drawing.Point(6, 19);
            this.lstSource.Name = "lstSource";
            this.lstSource.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSource.Size = new System.Drawing.Size(238, 498);
            this.lstSource.TabIndex = 2;
            this.lstSource.SelectedIndexChanged += new System.EventHandler(this.lstSource_SelectedIndexChanged);
            // 
            // btnAddSource
            // 
            this.btnAddSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSource.Enabled = false;
            this.btnAddSource.ImageIndex = 4;
            this.btnAddSource.ImageList = this.imageList1;
            this.btnAddSource.Location = new System.Drawing.Point(158, 543);
            this.btnAddSource.Name = "btnAddSource";
            this.btnAddSource.Size = new System.Drawing.Size(40, 40);
            this.btnAddSource.TabIndex = 1;
            this.btnAddSource.UseVisualStyleBackColor = true;
            this.btnAddSource.Click += new System.EventHandler(this.btnAddSource_Click);
            // 
            // btnAddSourceAll
            // 
            this.btnAddSourceAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSourceAll.ImageIndex = 0;
            this.btnAddSourceAll.ImageList = this.imageList1;
            this.btnAddSourceAll.Location = new System.Drawing.Point(204, 543);
            this.btnAddSourceAll.Name = "btnAddSourceAll";
            this.btnAddSourceAll.Size = new System.Drawing.Size(40, 40);
            this.btnAddSourceAll.TabIndex = 0;
            this.btnAddSourceAll.UseVisualStyleBackColor = true;
            this.btnAddSourceAll.Click += new System.EventHandler(this.btnAddSourceAll_Click);
            // 
            // fieldInfoControl
            // 
            this.fieldInfoControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldInfoControl.Enabled = false;
            this.fieldInfoControl.Location = new System.Drawing.Point(515, 3);
            this.fieldInfoControl.Name = "fieldInfoControl";
            this.fieldInfoControl.Size = new System.Drawing.Size(498, 589);
            this.fieldInfoControl.TabIndex = 7;
            // 
            // ManageFieldsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fieldInfoControl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageFieldsControl";
            this.Size = new System.Drawing.Size(1016, 595);
            this.Load += new System.EventHandler(this.ManageFieldsControl_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnTargetUp;
        private System.Windows.Forms.Button btnTargetDown;
        private System.Windows.Forms.Button btnNewTarget;
        private System.Windows.Forms.Button btnRemoveTargetAll;
        private System.Windows.Forms.Button btnRemoveTarget;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstSource;
        private System.Windows.Forms.Button btnAddSource;
        private System.Windows.Forms.Button btnAddSourceAll;
        private FieldInfoControl fieldInfoControl;
        private System.Windows.Forms.ImageList imageList1;
    }
}
