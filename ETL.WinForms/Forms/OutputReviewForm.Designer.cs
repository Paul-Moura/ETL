namespace ETL.Forms
{
    partial class OutputReviewForm
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.RadListDataItem radListDataItem6 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem7 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem8 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem9 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblStatus = new Telerik.WinControls.UI.RadLabelElement();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.grdFinalOutput = new Telerik.WinControls.UI.RadGridView();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.ddlShowRows = new Telerik.WinControls.UI.RadMenuComboItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.ddlInvalidRowType = new Telerik.WinControls.UI.RadMenuComboItem();
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage3 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.ddlPages = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.radPageViewPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFinalOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFinalOutput.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlShowRows.ComboBoxElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlInvalidRowType.ComboBoxElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblStatus});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 713);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(919, 26);
            this.radStatusStrip1.TabIndex = 0;
            this.radStatusStrip1.Text = "radStatusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Name = "lblStatus";
            this.radStatusStrip1.SetSpring(this.lblStatus, false);
            this.lblStatus.Text = "0 hard flags, 0 soft flags, 0 good rows, 0 bad rows, 0 total rows";
            this.lblStatus.TextWrap = true;
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.radPageViewPage1);
            this.radPageView1.Controls.Add(this.radPageViewPage2);
            this.radPageView1.Controls.Add(this.radPageViewPage3);
            this.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPageView1.Location = new System.Drawing.Point(0, 43);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.radPageViewPage1;
            this.radPageView1.Size = new System.Drawing.Size(919, 639);
            this.radPageView1.TabIndex = 1;
            this.radPageView1.Text = "Final Output";
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Controls.Add(this.grdFinalOutput);
            this.radPageViewPage1.Controls.Add(this.radMenu1);
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(78F, 28F);
            this.radPageViewPage1.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(898, 591);
            this.radPageViewPage1.Text = "Final Output";
            // 
            // grdFinalOutput
            // 
            this.grdFinalOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFinalOutput.Location = new System.Drawing.Point(0, 22);
            // 
            // 
            // 
            this.grdFinalOutput.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.grdFinalOutput.Name = "grdFinalOutput";
            this.grdFinalOutput.Size = new System.Drawing.Size(898, 569);
            this.grdFinalOutput.TabIndex = 0;
            this.grdFinalOutput.Text = "radGridView1";
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.ddlShowRows,
            this.radMenuItem2,
            this.ddlInvalidRowType});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(898, 22);
            this.radMenu1.TabIndex = 5;
            this.radMenu1.Text = "radMenu1";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Show rows:";
            this.radMenuItem1.UseCompatibleTextRendering = false;
            // 
            // ddlShowRows
            // 
            // 
            // 
            // 
            this.ddlShowRows.ComboBoxElement.ArrowButtonMinWidth = 17;
            this.ddlShowRows.ComboBoxElement.AutoCompleteAppend = null;
            this.ddlShowRows.ComboBoxElement.AutoCompleteDataSource = null;
            this.ddlShowRows.ComboBoxElement.AutoCompleteSuggest = null;
            this.ddlShowRows.ComboBoxElement.DataMember = "";
            this.ddlShowRows.ComboBoxElement.DataSource = null;
            this.ddlShowRows.ComboBoxElement.DefaultValue = null;
            this.ddlShowRows.ComboBoxElement.DisplayMember = "";
            this.ddlShowRows.ComboBoxElement.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InQuad;
            this.ddlShowRows.ComboBoxElement.DropDownAnimationEnabled = true;
            this.ddlShowRows.ComboBoxElement.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlShowRows.ComboBoxElement.EditableElementText = "(All Rows)";
            this.ddlShowRows.ComboBoxElement.EditorElement = this.ddlShowRows.ComboBoxElement;
            this.ddlShowRows.ComboBoxElement.EditorManager = null;
            this.ddlShowRows.ComboBoxElement.Filter = null;
            this.ddlShowRows.ComboBoxElement.FilterExpression = "";
            this.ddlShowRows.ComboBoxElement.Focusable = true;
            this.ddlShowRows.ComboBoxElement.FormatString = "";
            this.ddlShowRows.ComboBoxElement.FormattingEnabled = true;
            this.ddlShowRows.ComboBoxElement.ItemHeight = 18;
            radListDataItem6.Selected = true;
            radListDataItem6.Text = "(All Rows)";
            radListDataItem7.Text = "Rows that have passed validation";
            radListDataItem8.Text = "Rows that have failed validation";
            radListDataItem9.Text = "Rows that have hard flags";
            this.ddlShowRows.ComboBoxElement.Items.Add(radListDataItem6);
            this.ddlShowRows.ComboBoxElement.Items.Add(radListDataItem7);
            this.ddlShowRows.ComboBoxElement.Items.Add(radListDataItem8);
            this.ddlShowRows.ComboBoxElement.Items.Add(radListDataItem9);
            this.ddlShowRows.ComboBoxElement.MaxDropDownItems = 0;
            this.ddlShowRows.ComboBoxElement.MaxLength = 32767;
            this.ddlShowRows.ComboBoxElement.MaxValue = null;
            this.ddlShowRows.ComboBoxElement.MinValue = null;
            this.ddlShowRows.ComboBoxElement.NullValue = null;
            this.ddlShowRows.ComboBoxElement.OwnerOffset = 0;
            this.ddlShowRows.ComboBoxElement.ShowImageInEditorArea = true;
            this.ddlShowRows.ComboBoxElement.SortStyle = Telerik.WinControls.Enumerations.SortStyle.None;
            this.ddlShowRows.ComboBoxElement.SyncSelectionWithText = false;
            this.ddlShowRows.ComboBoxElement.Value = null;
            this.ddlShowRows.ComboBoxElement.ValueMember = "";
            this.ddlShowRows.DefaultSize = new System.Drawing.Size(0, 0);
            this.ddlShowRows.Name = "ddlShowRows";
            this.ddlShowRows.Text = "radMenuComboItem1";
            this.ddlShowRows.UseCompatibleTextRendering = false;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.ddlShowRows.GetChildAt(3))).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Show rows with invalid:";
            this.radMenuItem2.UseCompatibleTextRendering = false;
            // 
            // ddlInvalidRowType
            // 
            // 
            // 
            // 
            this.ddlInvalidRowType.ComboBoxElement.ArrowButtonMinWidth = 17;
            this.ddlInvalidRowType.ComboBoxElement.AutoCompleteAppend = null;
            this.ddlInvalidRowType.ComboBoxElement.AutoCompleteDataSource = null;
            this.ddlInvalidRowType.ComboBoxElement.AutoCompleteSuggest = null;
            this.ddlInvalidRowType.ComboBoxElement.DataMember = "";
            this.ddlInvalidRowType.ComboBoxElement.DataSource = null;
            this.ddlInvalidRowType.ComboBoxElement.DefaultValue = null;
            this.ddlInvalidRowType.ComboBoxElement.DisplayMember = "";
            this.ddlInvalidRowType.ComboBoxElement.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InQuad;
            this.ddlInvalidRowType.ComboBoxElement.DropDownAnimationEnabled = true;
            this.ddlInvalidRowType.ComboBoxElement.EditableElementText = "(Any)";
            this.ddlInvalidRowType.ComboBoxElement.EditorElement = this.ddlInvalidRowType.ComboBoxElement;
            this.ddlInvalidRowType.ComboBoxElement.EditorManager = null;
            this.ddlInvalidRowType.ComboBoxElement.Filter = null;
            this.ddlInvalidRowType.ComboBoxElement.FilterExpression = "";
            this.ddlInvalidRowType.ComboBoxElement.Focusable = true;
            this.ddlInvalidRowType.ComboBoxElement.FormatString = "";
            this.ddlInvalidRowType.ComboBoxElement.FormattingEnabled = true;
            this.ddlInvalidRowType.ComboBoxElement.ItemHeight = 18;
            radListDataItem1.Selected = true;
            radListDataItem1.Text = "(Any)";
            this.ddlInvalidRowType.ComboBoxElement.Items.Add(radListDataItem1);
            this.ddlInvalidRowType.ComboBoxElement.MaxDropDownItems = 0;
            this.ddlInvalidRowType.ComboBoxElement.MaxLength = 32767;
            this.ddlInvalidRowType.ComboBoxElement.MaxValue = null;
            this.ddlInvalidRowType.ComboBoxElement.MinValue = null;
            this.ddlInvalidRowType.ComboBoxElement.NullValue = null;
            this.ddlInvalidRowType.ComboBoxElement.OwnerOffset = 0;
            this.ddlInvalidRowType.ComboBoxElement.ShowImageInEditorArea = true;
            this.ddlInvalidRowType.ComboBoxElement.SortStyle = Telerik.WinControls.Enumerations.SortStyle.None;
            this.ddlInvalidRowType.ComboBoxElement.Value = null;
            this.ddlInvalidRowType.ComboBoxElement.ValueMember = "";
            this.ddlInvalidRowType.Name = "ddlInvalidRowType";
            this.ddlInvalidRowType.Text = "radMenuComboItem2";
            this.ddlInvalidRowType.UseCompatibleTextRendering = false;
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.ItemSize = new System.Drawing.SizeF(75F, 28F);
            this.radPageViewPage2.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPage2.Name = "radPageViewPage2";
            this.radPageViewPage2.Size = new System.Drawing.Size(898, 591);
            this.radPageViewPage2.Text = "Filtered Out";
            // 
            // radPageViewPage3
            // 
            this.radPageViewPage3.ItemSize = new System.Drawing.SizeF(68F, 28F);
            this.radPageViewPage3.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPage3.Name = "radPageViewPage3";
            this.radPageViewPage3.Size = new System.Drawing.Size(898, 591);
            this.radPageViewPage3.Text = "Duplicates";
            // 
            // radButton1
            // 
            this.radButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton1.Location = new System.Drawing.Point(690, 4);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 24);
            this.radButton1.TabIndex = 2;
            this.radButton1.Text = "OK";
            // 
            // radButton2
            // 
            this.radButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton2.Location = new System.Drawing.Point(806, 4);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(110, 24);
            this.radButton2.TabIndex = 3;
            this.radButton2.Text = "Cancel";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radButton2);
            this.panel1.Controls.Add(this.radButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 682);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 31);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ddlPages);
            this.panel2.Controls.Add(this.radLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 43);
            this.panel2.TabIndex = 6;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(33, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Page:";
            // 
            // ddlPages
            // 
            this.ddlPages.Location = new System.Drawing.Point(51, 12);
            this.ddlPages.Name = "ddlPages";
            this.ddlPages.Size = new System.Drawing.Size(250, 20);
            this.ddlPages.TabIndex = 1;
            this.ddlPages.Text = "radDropDownList1";
            this.ddlPages.SelectedValueChanged += new System.EventHandler(this.ddlPages_SelectedValueChanged);
            // 
            // OutputReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 739);
            this.Controls.Add(this.radPageView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radStatusStrip1);
            this.Name = "OutputReviewForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Manual Review";
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.radPageViewPage1.ResumeLayout(false);
            this.radPageViewPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFinalOutput.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFinalOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlShowRows.ComboBoxElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlInvalidRowType.ComboBoxElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage3;
        private Telerik.WinControls.UI.RadLabelElement lblStatus;
        private Telerik.WinControls.UI.RadGridView grdFinalOutput;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuComboItem ddlShowRows;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuComboItem ddlInvalidRowType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Telerik.WinControls.UI.RadDropDownList ddlPages;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}
