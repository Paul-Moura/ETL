namespace ETL.Forms
{
    partial class AddEditFilterForm
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.ddlType = new Telerik.WinControls.UI.RadDropDownList();
            this.ddlAction = new Telerik.WinControls.UI.RadDropDownList();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnOK = new Telerik.WinControls.UI.RadButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlRegEx = new System.Windows.Forms.Panel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnTest = new Telerik.WinControls.UI.RadButton();
            this.btnParse = new Telerik.WinControls.UI.RadButton();
            this.txtPattern = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlList = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlRegEx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnParse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPattern)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(3, 4);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(64, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Filter Name";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(3, 29);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(58, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Filter Type";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(3, 55);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(38, 18);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Action";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(106, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(533, 20);
            this.txtName.TabIndex = 3;
            // 
            // ddlType
            // 
            this.ddlType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlType.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlType.Location = new System.Drawing.Point(106, 29);
            this.ddlType.Name = "ddlType";
            this.ddlType.Size = new System.Drawing.Size(533, 20);
            this.ddlType.TabIndex = 4;
            this.ddlType.Text = "radDropDownList1";
            this.ddlType.SelectedValueChanged += new System.EventHandler(this.ddlType_SelectedValueChanged);
            // 
            // ddlAction
            // 
            this.ddlAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlAction.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlAction.Location = new System.Drawing.Point(106, 55);
            this.ddlAction.Name = "ddlAction";
            this.ddlAction.Size = new System.Drawing.Size(533, 20);
            this.ddlAction.TabIndex = 5;
            this.ddlAction.Text = "radDropDownList2";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(520, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 24);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(404, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(110, 24);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.ddlType);
            this.panel1.Controls.Add(this.ddlAction);
            this.panel1.Controls.Add(this.radLabel1);
            this.panel1.Controls.Add(this.radLabel2);
            this.panel1.Controls.Add(this.radLabel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 83);
            this.panel1.TabIndex = 9;
            // 
            // pnlRegEx
            // 
            this.pnlRegEx.Controls.Add(this.radGroupBox1);
            this.pnlRegEx.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRegEx.Location = new System.Drawing.Point(0, 83);
            this.pnlRegEx.Name = "pnlRegEx";
            this.pnlRegEx.Size = new System.Drawing.Size(642, 65);
            this.pnlRegEx.TabIndex = 10;
            this.pnlRegEx.Visible = false;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.btnTest);
            this.radGroupBox1.Controls.Add(this.btnParse);
            this.radGroupBox1.Controls.Add(this.txtPattern);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.HeaderText = "RegEx";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 6);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(618, 53);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "RegEx";
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.Enabled = false;
            this.btnTest.Location = new System.Drawing.Point(536, 19);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(77, 24);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "Test";
            // 
            // btnParse
            // 
            this.btnParse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParse.Location = new System.Drawing.Point(453, 19);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(77, 24);
            this.btnParse.TabIndex = 10;
            this.btnParse.Text = "Parse";
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // txtPattern
            // 
            this.txtPattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPattern.Location = new System.Drawing.Point(94, 21);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(353, 20);
            this.txtPattern.TabIndex = 4;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(46, 22);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(42, 18);
            this.radLabel4.TabIndex = 1;
            this.radLabel4.Text = "Pattern";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnOK);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 269);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(642, 31);
            this.panel3.TabIndex = 11;
            // 
            // pnlList
            // 
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlList.Location = new System.Drawing.Point(0, 148);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(642, 121);
            this.pnlList.TabIndex = 12;
            this.pnlList.Visible = false;
            // 
            // AddEditFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(642, 325);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.pnlRegEx);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(650, 0);
            this.Name = "AddEditFilterForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Filter";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlRegEx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnParse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPattern)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadDropDownList ddlType;
        private Telerik.WinControls.UI.RadDropDownList ddlAction;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlRegEx;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.Panel panel3;
        private Telerik.WinControls.UI.RadTextBox txtPattern;
        private Telerik.WinControls.UI.RadButton btnParse;
        private Telerik.WinControls.UI.RadButton btnTest;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private System.Windows.Forms.Panel pnlList;
    }
}
