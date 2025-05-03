namespace lab07_2
{
    partial class fMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            toolStrip1 = new ToolStrip();
            btnAdd = new ToolStripButton();
            btnEdit = new ToolStripButton();
            btnDel = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            gv = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            controlDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            wrapStatusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            factionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uniqueFeatureDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dangerLevelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            BindSrcPlanet = new BindingSource(components);
            btnClear = new ToolStripButton();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BindSrcPlanet).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdd, btnEdit, btnDel, toolStripSeparator1, btnClear });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(928, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(29, 24);
            btnAdd.Text = "Додати запис";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageTransparentColor = Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(29, 24);
            btnEdit.Text = "Редагувати запис";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDel
            // 
            btnDel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDel.Image = (Image)resources.GetObject("btnDel.Image");
            btnDel.ImageTransparentColor = Color.Magenta;
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(29, 24);
            btnDel.Text = "Видалити запис";
            btnDel.Click += btnDel_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // gv
            // 
            gv.AllowUserToAddRows = false;
            gv.AllowUserToDeleteRows = false;
            gv.AutoGenerateColumns = false;
            gv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gv.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, controlDataGridViewTextBoxColumn, wrapStatusDataGridViewTextBoxColumn, factionDataGridViewTextBoxColumn, uniqueFeatureDataGridViewTextBoxColumn, dangerLevelDataGridViewTextBoxColumn });
            gv.DataSource = BindSrcPlanet;
            gv.Dock = DockStyle.Fill;
            gv.Location = new Point(0, 27);
            gv.Name = "gv";
            gv.ReadOnly = true;
            gv.RowHeadersWidth = 51;
            gv.Size = new Size(928, 363);
            gv.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Type";
            typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.ReadOnly = true;
            typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // controlDataGridViewTextBoxColumn
            // 
            controlDataGridViewTextBoxColumn.DataPropertyName = "Control";
            controlDataGridViewTextBoxColumn.HeaderText = "Control";
            controlDataGridViewTextBoxColumn.MinimumWidth = 6;
            controlDataGridViewTextBoxColumn.Name = "controlDataGridViewTextBoxColumn";
            controlDataGridViewTextBoxColumn.ReadOnly = true;
            controlDataGridViewTextBoxColumn.Width = 125;
            // 
            // wrapStatusDataGridViewTextBoxColumn
            // 
            wrapStatusDataGridViewTextBoxColumn.DataPropertyName = "WrapStatus";
            wrapStatusDataGridViewTextBoxColumn.HeaderText = "WrapStatus";
            wrapStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            wrapStatusDataGridViewTextBoxColumn.Name = "wrapStatusDataGridViewTextBoxColumn";
            wrapStatusDataGridViewTextBoxColumn.ReadOnly = true;
            wrapStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // factionDataGridViewTextBoxColumn
            // 
            factionDataGridViewTextBoxColumn.DataPropertyName = "Faction";
            factionDataGridViewTextBoxColumn.HeaderText = "Faction";
            factionDataGridViewTextBoxColumn.MinimumWidth = 6;
            factionDataGridViewTextBoxColumn.Name = "factionDataGridViewTextBoxColumn";
            factionDataGridViewTextBoxColumn.ReadOnly = true;
            factionDataGridViewTextBoxColumn.Width = 125;
            // 
            // uniqueFeatureDataGridViewTextBoxColumn
            // 
            uniqueFeatureDataGridViewTextBoxColumn.DataPropertyName = "UniqueFeature";
            uniqueFeatureDataGridViewTextBoxColumn.HeaderText = "UniqueFeature";
            uniqueFeatureDataGridViewTextBoxColumn.MinimumWidth = 6;
            uniqueFeatureDataGridViewTextBoxColumn.Name = "uniqueFeatureDataGridViewTextBoxColumn";
            uniqueFeatureDataGridViewTextBoxColumn.ReadOnly = true;
            uniqueFeatureDataGridViewTextBoxColumn.Width = 125;
            // 
            // dangerLevelDataGridViewTextBoxColumn
            // 
            dangerLevelDataGridViewTextBoxColumn.DataPropertyName = "DangerLevel";
            dangerLevelDataGridViewTextBoxColumn.HeaderText = "DangerLevel";
            dangerLevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            dangerLevelDataGridViewTextBoxColumn.Name = "dangerLevelDataGridViewTextBoxColumn";
            dangerLevelDataGridViewTextBoxColumn.ReadOnly = true;
            dangerLevelDataGridViewTextBoxColumn.Width = 125;
            // 
            // BindSrcPlanet
            // 
            BindSrcPlanet.DataSource = typeof(Planet);
            // 
            // btnClear
            // 
            btnClear.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.ImageTransparentColor = Color.Magenta;
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(29, 24);
            btnClear.Text = "Очистити дані";
            btnClear.Click += btnClear_Click;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 390);
            Controls.Add(gv);
            Controls.Add(toolStrip1);
            MaximizeBox = false;
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторна робота №7";
            Load += fMain_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gv).EndInit();
            ((System.ComponentModel.ISupportInitialize)BindSrcPlanet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnAdd;
        private ToolStripButton btnEdit;
        private ToolStripButton btnDel;
        private ToolStripSeparator toolStripSeparator1;
        private DataGridView gv;
        private BindingSource BindSrcPlanet;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn controlDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn wrapStatusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn factionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uniqueFeatureDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dangerLevelDataGridViewTextBoxColumn;
        private ToolStripButton btnClear;
    }
}
