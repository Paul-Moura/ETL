namespace ETL.Forms
{
    partial class FormulaEditorForm
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
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.menuSourceFields = new Telerik.WinControls.UI.RadMenuItem();
            this.btnSource = new Telerik.WinControls.UI.RadMenuItem();
            this.menuChangeCase = new Telerik.WinControls.UI.RadMenuItem();
            this.btnUpper = new Telerik.WinControls.UI.RadMenuItem();
            this.btnLower = new Telerik.WinControls.UI.RadMenuItem();
            this.btnProper = new Telerik.WinControls.UI.RadMenuItem();
            this.menuDateTime = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem6 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem7 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem8 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem9 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem10 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem11 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem12 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem13 = new Telerik.WinControls.UI.RadMenuItem();
            this.menuReformat = new Telerik.WinControls.UI.RadMenuItem();
            this.menuSelectCombine = new Telerik.WinControls.UI.RadMenuItem();
            this.txtFormula = new Telerik.WinControls.UI.RadTextBoxControl();
            this.btnCheckSyntax = new Telerik.WinControls.UI.RadButton();
            this.btnOK = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnTest = new Telerik.WinControls.UI.RadButton();
            this.txtTestResult = new Telerik.WinControls.UI.RadTextBox();
            this.ddlRow = new Telerik.WinControls.UI.RadDropDownList();
            this.lblFieldName = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheckSyntax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTestResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFieldName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.menuSourceFields,
            this.menuChangeCase,
            this.menuDateTime,
            this.menuReformat,
            this.menuSelectCombine});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(656, 20);
            this.radMenu1.TabIndex = 0;
            this.radMenu1.Text = "radMenu1";
            // 
            // menuSourceFields
            // 
            this.menuSourceFields.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnSource,
            this.radMenuItem1});
            this.menuSourceFields.Name = "menuSourceFields";
            this.menuSourceFields.Text = "Source Field";
            // 
            // btnSource
            // 
            this.btnSource.Name = "btnSource";
            this.btnSource.Text = "Source";
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // menuChangeCase
            // 
            this.menuChangeCase.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnUpper,
            this.btnLower,
            this.btnProper});
            this.menuChangeCase.Name = "menuChangeCase";
            this.menuChangeCase.Text = "Change Case";
            // 
            // btnUpper
            // 
            this.btnUpper.Name = "btnUpper";
            this.btnUpper.Text = "Upper()";
            this.btnUpper.Click += new System.EventHandler(this.btnUpper_Click);
            // 
            // btnLower
            // 
            this.btnLower.Name = "btnLower";
            this.btnLower.Text = "Lower()";
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // btnProper
            // 
            this.btnProper.Name = "btnProper";
            this.btnProper.Text = "Proper()";
            this.btnProper.Click += new System.EventHandler(this.btnProper_Click);
            // 
            // menuDateTime
            // 
            this.menuDateTime.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem5,
            this.radMenuItem6,
            this.radMenuItem7,
            this.radMenuItem8,
            this.radMenuItem9,
            this.radMenuItem10,
            this.radMenuItem11,
            this.radMenuItem12,
            this.radMenuItem13});
            this.menuDateTime.Name = "menuDateTime";
            this.menuDateTime.Text = "Date/Time";
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "Now()";
            // 
            // radMenuItem6
            // 
            this.radMenuItem6.Name = "radMenuItem6";
            this.radMenuItem6.Text = "Day()";
            // 
            // radMenuItem7
            // 
            this.radMenuItem7.Name = "radMenuItem7";
            this.radMenuItem7.Text = "Month()";
            // 
            // radMenuItem8
            // 
            this.radMenuItem8.Name = "radMenuItem8";
            this.radMenuItem8.Text = "Year()";
            // 
            // radMenuItem9
            // 
            this.radMenuItem9.Name = "radMenuItem9";
            this.radMenuItem9.Text = "Date()";
            // 
            // radMenuItem10
            // 
            this.radMenuItem10.Name = "radMenuItem10";
            this.radMenuItem10.Text = "Time()";
            // 
            // radMenuItem11
            // 
            this.radMenuItem11.Name = "radMenuItem11";
            this.radMenuItem11.Text = "Hour()";
            // 
            // radMenuItem12
            // 
            this.radMenuItem12.Name = "radMenuItem12";
            this.radMenuItem12.Text = "Minute()";
            // 
            // radMenuItem13
            // 
            this.radMenuItem13.Name = "radMenuItem13";
            this.radMenuItem13.Text = "Second()";
            // 
            // menuReformat
            // 
            this.menuReformat.Name = "menuReformat";
            this.menuReformat.Text = "Reformat";
            this.menuReformat.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // menuSelectCombine
            // 
            this.menuSelectCombine.Name = "menuSelectCombine";
            this.menuSelectCombine.Text = "Select / Combine";
            this.menuSelectCombine.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // txtFormula
            // 
            this.txtFormula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFormula.Location = new System.Drawing.Point(12, 26);
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.Size = new System.Drawing.Size(632, 194);
            this.txtFormula.TabIndex = 1;
            // 
            // btnCheckSyntax
            // 
            this.btnCheckSyntax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckSyntax.Location = new System.Drawing.Point(242, 350);
            this.btnCheckSyntax.Name = "btnCheckSyntax";
            this.btnCheckSyntax.Size = new System.Drawing.Size(110, 24);
            this.btnCheckSyntax.TabIndex = 2;
            this.btnCheckSyntax.Text = "Check Syntax";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(418, 350);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(110, 24);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(534, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 24);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.btnTest);
            this.radGroupBox1.Controls.Add(this.txtTestResult);
            this.radGroupBox1.Controls.Add(this.ddlRow);
            this.radGroupBox1.Controls.Add(this.lblFieldName);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.HeaderText = "Test";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 226);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(632, 107);
            this.radGroupBox1.TabIndex = 5;
            this.radGroupBox1.Text = "Test";
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.Location = new System.Drawing.Point(517, 71);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(110, 24);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "Test Formula";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtTestResult
            // 
            this.txtTestResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTestResult.Location = new System.Drawing.Point(5, 73);
            this.txtTestResult.Name = "txtTestResult";
            this.txtTestResult.Size = new System.Drawing.Size(506, 20);
            this.txtTestResult.TabIndex = 3;
            // 
            // ddlRow
            // 
            this.ddlRow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlRow.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlRow.Location = new System.Drawing.Point(5, 45);
            this.ddlRow.Name = "ddlRow";
            this.ddlRow.Size = new System.Drawing.Size(622, 20);
            this.ddlRow.TabIndex = 2;
            this.ddlRow.Text = "radDropDownList1";
            // 
            // lblFieldName
            // 
            this.lblFieldName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFieldName.AutoSize = false;
            this.lblFieldName.Location = new System.Drawing.Point(306, 21);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(321, 18);
            this.lblFieldName.TabIndex = 1;
            this.lblFieldName.Text = "FieldName";
            this.lblFieldName.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(5, 21);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(28, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Row";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Row()";
            // 
            // FormulaEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 386);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCheckSyntax);
            this.Controls.Add(this.txtFormula);
            this.Controls.Add(this.radMenu1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormulaEditorForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Formula Editor";
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheckSyntax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTestResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFieldName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem menuChangeCase;
        private Telerik.WinControls.UI.RadMenuItem btnUpper;
        private Telerik.WinControls.UI.RadMenuItem btnLower;
        private Telerik.WinControls.UI.RadMenuItem btnProper;
        private Telerik.WinControls.UI.RadMenuItem menuReformat;
        private Telerik.WinControls.UI.RadMenuItem menuSelectCombine;
        private Telerik.WinControls.UI.RadTextBoxControl txtFormula;
        private Telerik.WinControls.UI.RadButton btnCheckSyntax;
        private Telerik.WinControls.UI.RadButton btnOK;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnTest;
        private Telerik.WinControls.UI.RadTextBox txtTestResult;
        private Telerik.WinControls.UI.RadDropDownList ddlRow;
        private Telerik.WinControls.UI.RadLabel lblFieldName;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadMenuItem menuSourceFields;
        private Telerik.WinControls.UI.RadMenuItem menuDateTime;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem6;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem7;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem8;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem9;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem10;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem11;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem12;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem13;
        private Telerik.WinControls.UI.RadMenuItem btnSource;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
    }
}
