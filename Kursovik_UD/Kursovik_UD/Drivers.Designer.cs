namespace Kursovik_UD
{
    partial class Drivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drivers));
            this.eMPLOYEEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxiDataSet1 = new Kursovik_UD.TaxiDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.eMPLOYEEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.eMPLOYEEDataGridView = new System.Windows.Forms.DataGridView();
            this.driver_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.eMPCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NUMBER_AVTO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.aVTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DATE_N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_AVTO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MESTA = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PHONE_NUMBER = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dRIVERAVTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEETableAdapter = new Kursovik_UD.TaxiDataSetTableAdapters.EMPLOYEETableAdapter();
            this.tableAdapterManager = new Kursovik_UD.TaxiDataSetTableAdapters.TableAdapterManager();
            this.dRIVER_AVTOTableAdapter = new Kursovik_UD.TaxiDataSetTableAdapters.DRIVER_AVTOTableAdapter();
            this.aVTOTableAdapter = new Kursovik_UD.TaxiDataSetTableAdapters.AVTOTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingNavigator)).BeginInit();
            this.eMPLOYEEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aVTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dRIVERAVTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eMPLOYEEBindingNavigator
            // 
            this.eMPLOYEEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eMPLOYEEBindingNavigator.BindingSource = this.eMPLOYEEBindingSource;
            this.eMPLOYEEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eMPLOYEEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eMPLOYEEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.eMPLOYEEBindingNavigatorSaveItem,
            this.toolStripSeparator1});
            this.eMPLOYEEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eMPLOYEEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eMPLOYEEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eMPLOYEEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eMPLOYEEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eMPLOYEEBindingNavigator.Name = "eMPLOYEEBindingNavigator";
            this.eMPLOYEEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eMPLOYEEBindingNavigator.Size = new System.Drawing.Size(846, 25);
            this.eMPLOYEEBindingNavigator.TabIndex = 0;
            this.eMPLOYEEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.taxiDataSet1;
            // 
            // taxiDataSet1
            // 
            this.taxiDataSet1.DataSetName = "TaxiDataSet";
            this.taxiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // eMPLOYEEBindingNavigatorSaveItem
            // 
            this.eMPLOYEEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eMPLOYEEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eMPLOYEEBindingNavigatorSaveItem.Image")));
            this.eMPLOYEEBindingNavigatorSaveItem.Name = "eMPLOYEEBindingNavigatorSaveItem";
            this.eMPLOYEEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.eMPLOYEEBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.eMPLOYEEBindingNavigatorSaveItem.Click += new System.EventHandler(this.eMPLOYEEBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // eMPLOYEEDataGridView
            // 
            this.eMPLOYEEDataGridView.AllowUserToAddRows = false;
            this.eMPLOYEEDataGridView.AllowUserToDeleteRows = false;
            this.eMPLOYEEDataGridView.AutoGenerateColumns = false;
            this.eMPLOYEEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eMPLOYEEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.driver_id,
            this.eMPCODEDataGridViewTextBoxColumn,
            this.NUMBER_AVTO,
            this.DATE_N,
            this.NAME_AVTO,
            this.MESTA,
            this.PHONE_NUMBER});
            this.eMPLOYEEDataGridView.DataSource = this.dRIVERAVTOBindingSource;
            this.eMPLOYEEDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eMPLOYEEDataGridView.Location = new System.Drawing.Point(0, 25);
            this.eMPLOYEEDataGridView.Name = "eMPLOYEEDataGridView";
            this.eMPLOYEEDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eMPLOYEEDataGridView.Size = new System.Drawing.Size(846, 380);
            this.eMPLOYEEDataGridView.TabIndex = 1;
            this.eMPLOYEEDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eMPLOYEEDataGridView_CellContentClick);
            // 
            // driver_id
            // 
            this.driver_id.DataPropertyName = "EMP_CODE";
            this.driver_id.DataSource = this.eMPLOYEEBindingSource;
            this.driver_id.DisplayMember = "ID";
            this.driver_id.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.driver_id.HeaderText = "driver_id";
            this.driver_id.Name = "driver_id";
            this.driver_id.ReadOnly = true;
            this.driver_id.ValueMember = "ID";
            this.driver_id.Visible = false;
            // 
            // eMPCODEDataGridViewTextBoxColumn
            // 
            this.eMPCODEDataGridViewTextBoxColumn.DataPropertyName = "EMP_CODE";
            this.eMPCODEDataGridViewTextBoxColumn.DataSource = this.eMPLOYEEBindingSource;
            this.eMPCODEDataGridViewTextBoxColumn.DisplayMember = "FIO";
            this.eMPCODEDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.eMPCODEDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eMPCODEDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.eMPCODEDataGridViewTextBoxColumn.Name = "eMPCODEDataGridViewTextBoxColumn";
            this.eMPCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMPCODEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eMPCODEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eMPCODEDataGridViewTextBoxColumn.ValueMember = "ID";
            this.eMPCODEDataGridViewTextBoxColumn.Width = 200;
            // 
            // NUMBER_AVTO
            // 
            this.NUMBER_AVTO.DataPropertyName = "AUTO_CODE";
            this.NUMBER_AVTO.DataSource = this.aVTOBindingSource;
            this.NUMBER_AVTO.DisplayMember = "NUMBER_AVTO";
            this.NUMBER_AVTO.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.NUMBER_AVTO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NUMBER_AVTO.HeaderText = "Номер авто";
            this.NUMBER_AVTO.Name = "NUMBER_AVTO";
            this.NUMBER_AVTO.ReadOnly = true;
            this.NUMBER_AVTO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NUMBER_AVTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NUMBER_AVTO.ValueMember = "ID";
            // 
            // aVTOBindingSource
            // 
            this.aVTOBindingSource.DataMember = "AVTO";
            this.aVTOBindingSource.DataSource = this.taxiDataSet1;
            // 
            // DATE_N
            // 
            this.DATE_N.DataPropertyName = "DATE_N";
            this.DATE_N.HeaderText = "Назначен";
            this.DATE_N.Name = "DATE_N";
            this.DATE_N.ReadOnly = true;
            this.DATE_N.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NAME_AVTO
            // 
            this.NAME_AVTO.DataPropertyName = "AUTO_CODE";
            this.NAME_AVTO.DataSource = this.aVTOBindingSource;
            this.NAME_AVTO.DisplayMember = "NAME_AVTO";
            this.NAME_AVTO.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.NAME_AVTO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NAME_AVTO.HeaderText = "Автомобиль";
            this.NAME_AVTO.Name = "NAME_AVTO";
            this.NAME_AVTO.ReadOnly = true;
            this.NAME_AVTO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NAME_AVTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NAME_AVTO.ValueMember = "ID";
            // 
            // MESTA
            // 
            this.MESTA.DataPropertyName = "AUTO_CODE";
            this.MESTA.DataSource = this.aVTOBindingSource;
            this.MESTA.DisplayMember = "MESTA";
            this.MESTA.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.MESTA.HeaderText = "Мест";
            this.MESTA.Name = "MESTA";
            this.MESTA.ReadOnly = true;
            this.MESTA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MESTA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MESTA.ValueMember = "ID";
            // 
            // PHONE_NUMBER
            // 
            this.PHONE_NUMBER.DataPropertyName = "EMP_CODE";
            this.PHONE_NUMBER.DataSource = this.eMPLOYEEBindingSource;
            this.PHONE_NUMBER.DisplayMember = "PHONE_NUMBER";
            this.PHONE_NUMBER.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.PHONE_NUMBER.HeaderText = "Телефон";
            this.PHONE_NUMBER.Name = "PHONE_NUMBER";
            this.PHONE_NUMBER.ReadOnly = true;
            this.PHONE_NUMBER.ValueMember = "ID";
            // 
            // dRIVERAVTOBindingSource
            // 
            this.dRIVERAVTOBindingSource.DataMember = "DRIVER_AVTO";
            this.dRIVERAVTOBindingSource.DataSource = this.taxiDataSet1;
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AVTOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DRIVER_AVTOTableAdapter = null;
            this.tableAdapterManager.EMPLOYEETableAdapter = this.eMPLOYEETableAdapter;
            this.tableAdapterManager.KLADR_KLADRTableAdapter = null;
            this.tableAdapterManager.KLADR_STREETTableAdapter = null;
            this.tableAdapterManager.MEDOSMOTRTableAdapter = null;
            this.tableAdapterManager.REGIONTableAdapter = null;
            this.tableAdapterManager.SERVICETableAdapter = null;
            this.tableAdapterManager.STATUS_EMPLOYEETableAdapter = null;
            this.tableAdapterManager.STATUS_MEDOSMOTRATableAdapter = null;
            this.tableAdapterManager.STATUS_TOTableAdapter = null;
            this.tableAdapterManager.STATUS_ZAYAVKITableAdapter = null;
            this.tableAdapterManager.STREETSTableAdapter = null;
            this.tableAdapterManager.TARIFTableAdapter = null;
            this.tableAdapterManager.TEHOSMOTRTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kursovik_UD.TaxiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZAYAVKATableAdapter = null;
            // 
            // dRIVER_AVTOTableAdapter
            // 
            this.dRIVER_AVTOTableAdapter.ClearBeforeFill = true;
            // 
            // aVTOTableAdapter
            // 
            this.aVTOTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(313, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Не занятые";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Drivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 405);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.eMPLOYEEDataGridView);
            this.Controls.Add(this.eMPLOYEEBindingNavigator);
            this.Name = "Drivers";
            this.Text = "Информация о водителях";
            this.Load += new System.EventHandler(this.Drivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingNavigator)).EndInit();
            this.eMPLOYEEBindingNavigator.ResumeLayout(false);
            this.eMPLOYEEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aVTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dRIVERAVTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TaxiDataSet taxiDataSet1;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private TaxiDataSetTableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private TaxiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eMPLOYEEBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton eMPLOYEEBindingNavigatorSaveItem;
        private TaxiDataSetTableAdapters.DRIVER_AVTOTableAdapter dRIVER_AVTOTableAdapter;
        private System.Windows.Forms.DataGridView eMPLOYEEDataGridView;
        private System.Windows.Forms.BindingSource dRIVERAVTOBindingSource;
        private System.Windows.Forms.BindingSource aVTOBindingSource;
        private TaxiDataSetTableAdapters.AVTOTableAdapter aVTOTableAdapter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewComboBoxColumn driver_id;
        private System.Windows.Forms.DataGridViewComboBoxColumn eMPCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn NUMBER_AVTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_N;
        private System.Windows.Forms.DataGridViewComboBoxColumn NAME_AVTO;
        private System.Windows.Forms.DataGridViewComboBoxColumn MESTA;
        private System.Windows.Forms.DataGridViewComboBoxColumn PHONE_NUMBER;
    }
}