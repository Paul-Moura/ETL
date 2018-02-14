namespace ETL.Forms
{
    partial class ImportersExportersForm
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
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn2 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.grdImporters = new Telerik.WinControls.UI.RadGridView();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.grdExporters = new Telerik.WinControls.UI.RadGridView();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdImporters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdImporters.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExporters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdExporters.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // grdImporters
            // 
            this.grdImporters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdImporters.Location = new System.Drawing.Point(0, 18);
            // 
            // 
            // 
            this.grdImporters.MasterTemplate.AllowCellContextMenu = false;
            this.grdImporters.MasterTemplate.AllowColumnChooser = false;
            this.grdImporters.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.grdImporters.MasterTemplate.AllowColumnReorder = false;
            this.grdImporters.MasterTemplate.AllowDragToGroup = false;
            this.grdImporters.MasterTemplate.AllowRowHeaderContextMenu = false;
            this.grdImporters.MasterTemplate.AutoGenerateColumns = false;
            gridViewComboBoxColumn1.HeaderText = "Type";
            gridViewComboBoxColumn1.MinWidth = 100;
            gridViewComboBoxColumn1.Name = "colType";
            gridViewComboBoxColumn1.Width = 100;
            gridViewTextBoxColumn1.HeaderText = "Nickname";
            gridViewTextBoxColumn1.MinWidth = 150;
            gridViewTextBoxColumn1.Name = "colName";
            gridViewTextBoxColumn1.Width = 150;
            gridViewTextBoxColumn2.HeaderText = "Source";
            gridViewTextBoxColumn2.MinWidth = 400;
            gridViewTextBoxColumn2.Name = "colSource";
            gridViewTextBoxColumn2.Width = 400;
            this.grdImporters.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewComboBoxColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.grdImporters.MasterTemplate.ShowFilteringRow = false;
            this.grdImporters.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdImporters.Name = "grdImporters";
            this.grdImporters.ShowCellErrors = false;
            this.grdImporters.ShowGroupPanel = false;
            this.grdImporters.ShowRowErrors = false;
            this.grdImporters.Size = new System.Drawing.Size(675, 213);
            this.grdImporters.TabIndex = 0;
            this.grdImporters.Text = "radGridView1";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(571, 490);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 24);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(455, 490);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 24);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save && Close";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radSplitContainer1.Controls.Add(this.splitPanel1);
            this.radSplitContainer1.Controls.Add(this.splitPanel2);
            this.radSplitContainer1.Location = new System.Drawing.Point(9, 9);
            this.radSplitContainer1.Name = "radSplitContainer1";
            this.radSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(675, 466);
            this.radSplitContainer1.TabIndex = 4;
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.Text = "radSplitContainer1";
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.grdImporters);
            this.splitPanel1.Controls.Add(this.radLabel1);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(675, 231);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            // 
            // radLabel1
            // 
            this.radLabel1.AutoSize = false;
            this.radLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radLabel1.Location = new System.Drawing.Point(0, 0);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(675, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "IMPORTERS";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.grdExporters);
            this.splitPanel2.Controls.Add(this.radLabel2);
            this.splitPanel2.Location = new System.Drawing.Point(0, 235);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(675, 231);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            // 
            // grdExporters
            // 
            this.grdExporters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdExporters.Location = new System.Drawing.Point(0, 18);
            // 
            // 
            // 
            this.grdExporters.MasterTemplate.AllowCellContextMenu = false;
            this.grdExporters.MasterTemplate.AllowColumnChooser = false;
            this.grdExporters.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.grdExporters.MasterTemplate.AllowColumnReorder = false;
            this.grdExporters.MasterTemplate.AllowDragToGroup = false;
            this.grdExporters.MasterTemplate.AllowRowHeaderContextMenu = false;
            this.grdExporters.MasterTemplate.AutoGenerateColumns = false;
            gridViewComboBoxColumn2.HeaderText = "Type";
            gridViewComboBoxColumn2.MinWidth = 100;
            gridViewComboBoxColumn2.Name = "colType";
            gridViewComboBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.HeaderText = "Nickname";
            gridViewTextBoxColumn3.MinWidth = 150;
            gridViewTextBoxColumn3.Name = "colName";
            gridViewTextBoxColumn3.Width = 150;
            gridViewTextBoxColumn4.HeaderText = "Target";
            gridViewTextBoxColumn4.MinWidth = 400;
            gridViewTextBoxColumn4.Name = "colTarget";
            gridViewTextBoxColumn4.Width = 400;
            this.grdExporters.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewComboBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.grdExporters.MasterTemplate.ShowFilteringRow = false;
            this.grdExporters.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.grdExporters.Name = "grdExporters";
            this.grdExporters.ShowCellErrors = false;
            this.grdExporters.ShowGroupPanel = false;
            this.grdExporters.ShowRowErrors = false;
            this.grdExporters.Size = new System.Drawing.Size(675, 213);
            this.grdExporters.TabIndex = 1;
            this.grdExporters.Text = "radGridView1";
            this.grdExporters.CurrentCellChanged += new Telerik.WinControls.UI.CurrentCellChangedEventHandler(this.grdExporters_CurrentCellChanged);
            this.grdExporters.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.grdExporters_CellValueChanged);
            // 
            // radLabel2
            // 
            this.radLabel2.AutoSize = false;
            this.radLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radLabel2.Location = new System.Drawing.Point(0, 0);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(675, 18);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "EXPORTERS";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImportersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 526);
            this.Controls.Add(this.radSplitContainer1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "ImportersForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Importers & Exporters";
            ((System.ComponentModel.ISupportInitialize)(this.grdImporters.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdImporters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdExporters.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdExporters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView grdImporters;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private Telerik.WinControls.UI.RadGridView grdExporters;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}
