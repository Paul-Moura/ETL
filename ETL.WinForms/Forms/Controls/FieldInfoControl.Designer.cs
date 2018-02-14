namespace ETL.Forms
{
    partial class FieldInfoControl
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn2 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FieldInfoControl));
            this.grpProperties = new System.Windows.Forms.GroupBox();
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.lnkFormulaBuilder = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOutputDataSize = new System.Windows.Forms.TextBox();
            this.ddlOutputDataType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOutputFieldName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlSource = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grdFilters = new Telerik.WinControls.UI.RadGridView();
            this.btnAddFilter = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnNewFilters = new System.Windows.Forms.Button();
            this.btnSaveFilters = new System.Windows.Forms.Button();
            this.btnOpenFilters = new System.Windows.Forms.Button();
            this.btnRemoveFilterAll = new System.Windows.Forms.Button();
            this.btnRemoveFilter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpProperties.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFilters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFilters.MasterTemplate)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpProperties
            // 
            this.grpProperties.Controls.Add(this.label4);
            this.grpProperties.Controls.Add(this.txtOutputDataSize);
            this.grpProperties.Controls.Add(this.ddlOutputDataType);
            this.grpProperties.Controls.Add(this.label3);
            this.grpProperties.Controls.Add(this.txtOutputFieldName);
            this.grpProperties.Controls.Add(this.label2);
            this.grpProperties.Controls.Add(this.ddlSource);
            this.grpProperties.Controls.Add(this.label1);
            this.grpProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpProperties.Location = new System.Drawing.Point(0, 0);
            this.grpProperties.Name = "grpProperties";
            this.grpProperties.Size = new System.Drawing.Size(578, 159);
            this.grpProperties.TabIndex = 6;
            this.grpProperties.TabStop = false;
            this.grpProperties.Text = "Target Field Properties";
            // 
            // txtFormula
            // 
            this.txtFormula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFormula.Location = new System.Drawing.Point(3, 19);
            this.txtFormula.Multiline = true;
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.Size = new System.Drawing.Size(566, 122);
            this.txtFormula.TabIndex = 15;
            this.txtFormula.Text = "$[source]";
            // 
            // lnkFormulaBuilder
            // 
            this.lnkFormulaBuilder.AutoSize = true;
            this.lnkFormulaBuilder.Location = new System.Drawing.Point(3, 3);
            this.lnkFormulaBuilder.Name = "lnkFormulaBuilder";
            this.lnkFormulaBuilder.Size = new System.Drawing.Size(79, 13);
            this.lnkFormulaBuilder.TabIndex = 14;
            this.lnkFormulaBuilder.TabStop = true;
            this.lnkFormulaBuilder.Text = "Formula Builder";
            this.lnkFormulaBuilder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFormulaBuilder_LinkClicked);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Size";
            // 
            // txtOutputDataSize
            // 
            this.txtOutputDataSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputDataSize.Location = new System.Drawing.Point(480, 126);
            this.txtOutputDataSize.Name = "txtOutputDataSize";
            this.txtOutputDataSize.Size = new System.Drawing.Size(92, 20);
            this.txtOutputDataSize.TabIndex = 12;
            // 
            // ddlOutputDataType
            // 
            this.ddlOutputDataType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlOutputDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlOutputDataType.FormattingEnabled = true;
            this.ddlOutputDataType.Items.AddRange(new object[] {
            "Text",
            "Whole Number",
            "Decimal",
            "Date / Time",
            "True / False"});
            this.ddlOutputDataType.Location = new System.Drawing.Point(6, 126);
            this.ddlOutputDataType.Name = "ddlOutputDataType";
            this.ddlOutputDataType.Size = new System.Drawing.Size(468, 21);
            this.ddlOutputDataType.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Output Data Type";
            // 
            // txtOutputFieldName
            // 
            this.txtOutputFieldName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputFieldName.Location = new System.Drawing.Point(6, 82);
            this.txtOutputFieldName.Name = "txtOutputFieldName";
            this.txtOutputFieldName.Size = new System.Drawing.Size(566, 20);
            this.txtOutputFieldName.TabIndex = 9;
            this.txtOutputFieldName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOutputFieldName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Output Field Name";
            // 
            // ddlSource
            // 
            this.ddlSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSource.FormattingEnabled = true;
            this.ddlSource.Location = new System.Drawing.Point(6, 37);
            this.ddlSource.Name = "ddlSource";
            this.ddlSource.Size = new System.Drawing.Size(566, 21);
            this.ddlSource.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Source Field";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grdFilters);
            this.groupBox4.Controls.Add(this.btnAddFilter);
            this.groupBox4.Controls.Add(this.btnNewFilters);
            this.groupBox4.Controls.Add(this.btnSaveFilters);
            this.groupBox4.Controls.Add(this.btnOpenFilters);
            this.groupBox4.Controls.Add(this.btnRemoveFilterAll);
            this.groupBox4.Controls.Add(this.btnRemoveFilter);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 306);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(578, 486);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filters";
            // 
            // grdFilters
            // 
            this.grdFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdFilters.EnableHotTracking = false;
            this.grdFilters.Location = new System.Drawing.Point(6, 19);
            // 
            // 
            // 
            this.grdFilters.MasterTemplate.AllowAddNewRow = false;
            this.grdFilters.MasterTemplate.AllowCellContextMenu = false;
            this.grdFilters.MasterTemplate.AllowColumnChooser = false;
            this.grdFilters.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.grdFilters.MasterTemplate.AllowColumnReorder = false;
            this.grdFilters.MasterTemplate.AllowDeleteRow = false;
            this.grdFilters.MasterTemplate.AllowDragToGroup = false;
            this.grdFilters.MasterTemplate.AllowEditRow = false;
            this.grdFilters.MasterTemplate.AllowRowHeaderContextMenu = false;
            this.grdFilters.MasterTemplate.AllowRowResize = false;
            this.grdFilters.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.FieldName = "Name";
            gridViewTextBoxColumn1.HeaderText = "Name";
            gridViewTextBoxColumn1.MinWidth = 200;
            gridViewTextBoxColumn1.Name = "colName";
            gridViewTextBoxColumn1.Width = 300;
            gridViewComboBoxColumn1.FieldName = "Type";
            gridViewComboBoxColumn1.HeaderText = "Type";
            gridViewComboBoxColumn1.MinWidth = 150;
            gridViewComboBoxColumn1.Name = "colType";
            gridViewComboBoxColumn1.Width = 150;
            gridViewComboBoxColumn2.FieldName = "Action";
            gridViewComboBoxColumn2.HeaderText = "Action";
            gridViewComboBoxColumn2.MinWidth = 150;
            gridViewComboBoxColumn2.Name = "colAction";
            gridViewComboBoxColumn2.Width = 150;
            this.grdFilters.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewComboBoxColumn1,
            gridViewComboBoxColumn2});
            this.grdFilters.MasterTemplate.EnableGrouping = false;
            this.grdFilters.MasterTemplate.EnableSorting = false;
            this.grdFilters.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdFilters.Name = "grdFilters";
            this.grdFilters.ReadOnly = true;
            this.grdFilters.Size = new System.Drawing.Size(566, 415);
            this.grdFilters.TabIndex = 6;
            this.grdFilters.Text = "radGridView1";
            // 
            // btnAddFilter
            // 
            this.btnAddFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddFilter.ImageIndex = 4;
            this.btnAddFilter.ImageList = this.imageList1;
            this.btnAddFilter.Location = new System.Drawing.Point(6, 440);
            this.btnAddFilter.Name = "btnAddFilter";
            this.btnAddFilter.Size = new System.Drawing.Size(40, 40);
            this.btnAddFilter.TabIndex = 5;
            this.btnAddFilter.UseVisualStyleBackColor = true;
            this.btnAddFilter.Click += new System.EventHandler(this.btnAddFilter_Click);
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
            // btnNewFilters
            // 
            this.btnNewFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewFilters.Enabled = false;
            this.btnNewFilters.ImageIndex = 6;
            this.btnNewFilters.ImageList = this.imageList1;
            this.btnNewFilters.Location = new System.Drawing.Point(52, 440);
            this.btnNewFilters.Name = "btnNewFilters";
            this.btnNewFilters.Size = new System.Drawing.Size(40, 40);
            this.btnNewFilters.TabIndex = 4;
            this.btnNewFilters.UseVisualStyleBackColor = true;
            // 
            // btnSaveFilters
            // 
            this.btnSaveFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveFilters.Enabled = false;
            this.btnSaveFilters.ImageIndex = 7;
            this.btnSaveFilters.ImageList = this.imageList1;
            this.btnSaveFilters.Location = new System.Drawing.Point(98, 440);
            this.btnSaveFilters.Name = "btnSaveFilters";
            this.btnSaveFilters.Size = new System.Drawing.Size(40, 40);
            this.btnSaveFilters.TabIndex = 3;
            this.btnSaveFilters.UseVisualStyleBackColor = true;
            // 
            // btnOpenFilters
            // 
            this.btnOpenFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenFilters.Enabled = false;
            this.btnOpenFilters.ImageIndex = 8;
            this.btnOpenFilters.ImageList = this.imageList1;
            this.btnOpenFilters.Location = new System.Drawing.Point(144, 440);
            this.btnOpenFilters.Name = "btnOpenFilters";
            this.btnOpenFilters.Size = new System.Drawing.Size(40, 40);
            this.btnOpenFilters.TabIndex = 2;
            this.btnOpenFilters.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFilterAll
            // 
            this.btnRemoveFilterAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveFilterAll.ImageIndex = 1;
            this.btnRemoveFilterAll.ImageList = this.imageList1;
            this.btnRemoveFilterAll.Location = new System.Drawing.Point(532, 440);
            this.btnRemoveFilterAll.Name = "btnRemoveFilterAll";
            this.btnRemoveFilterAll.Size = new System.Drawing.Size(40, 40);
            this.btnRemoveFilterAll.TabIndex = 1;
            this.btnRemoveFilterAll.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFilter
            // 
            this.btnRemoveFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveFilter.ImageIndex = 5;
            this.btnRemoveFilter.ImageList = this.imageList1;
            this.btnRemoveFilter.Location = new System.Drawing.Point(486, 440);
            this.btnRemoveFilter.Name = "btnRemoveFilter";
            this.btnRemoveFilter.Size = new System.Drawing.Size(40, 40);
            this.btnRemoveFilter.TabIndex = 0;
            this.btnRemoveFilter.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFormula);
            this.panel1.Controls.Add(this.lnkFormulaBuilder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 147);
            this.panel1.TabIndex = 7;
            // 
            // FieldInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpProperties);
            this.Name = "FieldInfoControl";
            this.Size = new System.Drawing.Size(578, 792);
            this.Load += new System.EventHandler(this.FieldInfoControl_Load);
            this.grpProperties.ResumeLayout(false);
            this.grpProperties.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFilters.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFilters)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProperties;
        private System.Windows.Forms.TextBox txtFormula;
        private System.Windows.Forms.LinkLabel lnkFormulaBuilder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOutputDataSize;
        private System.Windows.Forms.ComboBox ddlOutputDataType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOutputFieldName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddFilter;
        private System.Windows.Forms.Button btnNewFilters;
        private System.Windows.Forms.Button btnSaveFilters;
        private System.Windows.Forms.Button btnOpenFilters;
        private System.Windows.Forms.Button btnRemoveFilterAll;
        private System.Windows.Forms.Button btnRemoveFilter;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadGridView grdFilters;
        private System.Windows.Forms.Panel panel1;
    }
}
