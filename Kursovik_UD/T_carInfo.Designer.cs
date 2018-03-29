namespace Kursovik_UD
{
    partial class T_carInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(T_carInfo));
            this.taxiDataSet = new Kursovik_UD.TaxiDataSet();
            this.tableAdapterManager = new Kursovik_UD.TaxiDataSetTableAdapters.TableAdapterManager();
            this.aVTOTableAdapter = new Kursovik_UD.TaxiDataSetTableAdapters.AVTOTableAdapter();
            this.dRIVER_AVTOTableAdapter = new Kursovik_UD.TaxiDataSetTableAdapters.DRIVER_AVTOTableAdapter();
            this.dRIVERAVTOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.dRIVERAVTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.tEHOSMOTRBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.aVTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEETableAdapter = new Kursovik_UD.TaxiDataSetTableAdapters.EMPLOYEETableAdapter();
            this.dRIVER_AVTODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.num_avto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.emp_fio = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vin = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mesta = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.addCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dRIVERAVTOBindingNavigator)).BeginInit();
            this.dRIVERAVTOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dRIVERAVTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aVTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dRIVER_AVTODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // taxiDataSet
            // 
            this.taxiDataSet.DataSetName = "TaxiDataSet";
            this.taxiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AVTOTableAdapter = this.aVTOTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DRIVER_AVTOTableAdapter = this.dRIVER_AVTOTableAdapter;
            this.tableAdapterManager.EMPLOYEETableAdapter = null;
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
            // aVTOTableAdapter
            // 
            this.aVTOTableAdapter.ClearBeforeFill = true;
            // 
            // dRIVER_AVTOTableAdapter
            // 
            this.dRIVER_AVTOTableAdapter.ClearBeforeFill = true;
            // 
            // dRIVERAVTOBindingNavigator
            // 
            this.dRIVERAVTOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dRIVERAVTOBindingNavigator.BindingSource = this.dRIVERAVTOBindingSource;
            this.dRIVERAVTOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dRIVERAVTOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dRIVERAVTOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tEHOSMOTRBindingNavigatorSaveItem});
            this.dRIVERAVTOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dRIVERAVTOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dRIVERAVTOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dRIVERAVTOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dRIVERAVTOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dRIVERAVTOBindingNavigator.Name = "dRIVERAVTOBindingNavigator";
            this.dRIVERAVTOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dRIVERAVTOBindingNavigator.Size = new System.Drawing.Size(889, 25);
            this.dRIVERAVTOBindingNavigator.TabIndex = 2;
            this.dRIVERAVTOBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // dRIVERAVTOBindingSource
            // 
            this.dRIVERAVTOBindingSource.DataMember = "DRIVER_AVTO";
            this.dRIVERAVTOBindingSource.DataSource = this.taxiDataSet;
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
            // tEHOSMOTRBindingNavigatorSaveItem
            // 
            this.tEHOSMOTRBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tEHOSMOTRBindingNavigatorSaveItem.Enabled = false;
            this.tEHOSMOTRBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tEHOSMOTRBindingNavigatorSaveItem.Image")));
            this.tEHOSMOTRBindingNavigatorSaveItem.Name = "tEHOSMOTRBindingNavigatorSaveItem";
            this.tEHOSMOTRBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tEHOSMOTRBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.tEHOSMOTRBindingNavigatorSaveItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // aVTOBindingSource
            // 
            this.aVTOBindingSource.DataMember = "AVTO";
            this.aVTOBindingSource.DataSource = this.taxiDataSet;
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.taxiDataSet;
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // dRIVER_AVTODataGridView
            // 
            this.dRIVER_AVTODataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dRIVER_AVTODataGridView.AutoGenerateColumns = false;
            this.dRIVER_AVTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dRIVER_AVTODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.avto,
            this.num_avto,
            this.emp_fio,
            this.dataGridViewTextBoxColumn3,
            this.phone,
            this.vin,
            this.mesta});
            this.dRIVER_AVTODataGridView.DataSource = this.dRIVERAVTOBindingSource;
            this.dRIVER_AVTODataGridView.Location = new System.Drawing.Point(12, 28);
            this.dRIVER_AVTODataGridView.Name = "dRIVER_AVTODataGridView";
            this.dRIVER_AVTODataGridView.Size = new System.Drawing.Size(865, 404);
            this.dRIVER_AVTODataGridView.TabIndex = 2;
            this.dRIVER_AVTODataGridView.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dRIVER_AVTODataGridView_RowLeave);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EMP_CODE";
            this.dataGridViewTextBoxColumn1.HeaderText = "EMP_CODE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AUTO_CODE";
            this.dataGridViewTextBoxColumn2.HeaderText = "AUTO_CODE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // avto
            // 
            this.avto.DataPropertyName = "AUTO_CODE";
            this.avto.DataSource = this.aVTOBindingSource;
            this.avto.DisplayMember = "NAME_AVTO";
            this.avto.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.avto.HeaderText = "Автомобиль";
            this.avto.Name = "avto";
            this.avto.ValueMember = "ID";
            // 
            // num_avto
            // 
            this.num_avto.DataPropertyName = "AUTO_CODE";
            this.num_avto.DataSource = this.aVTOBindingSource;
            this.num_avto.DisplayMember = "NUMBER_AVTO";
            this.num_avto.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.num_avto.HeaderText = "Номер";
            this.num_avto.Name = "num_avto";
            this.num_avto.ReadOnly = true;
            this.num_avto.ValueMember = "ID";
            // 
            // emp_fio
            // 
            this.emp_fio.DataPropertyName = "EMP_CODE";
            this.emp_fio.DataSource = this.eMPLOYEEBindingSource;
            this.emp_fio.DisplayMember = "FIO";
            this.emp_fio.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.emp_fio.HeaderText = "Сотрудник";
            this.emp_fio.Name = "emp_fio";
            this.emp_fio.ValueMember = "ID";
            this.emp_fio.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DATE_N";
            this.dataGridViewTextBoxColumn3.HeaderText = "Назначен";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // phone
            // 
            this.phone.DataPropertyName = "EMP_CODE";
            this.phone.DataSource = this.eMPLOYEEBindingSource;
            this.phone.DisplayMember = "PHONE_NUMBER";
            this.phone.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.phone.HeaderText = "Телефон";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.ValueMember = "ID";
            this.phone.Width = 120;
            // 
            // vin
            // 
            this.vin.DataPropertyName = "AUTO_CODE";
            this.vin.DataSource = this.aVTOBindingSource;
            this.vin.DisplayMember = "VIN";
            this.vin.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.vin.HeaderText = "№ кузова";
            this.vin.Name = "vin";
            this.vin.ReadOnly = true;
            this.vin.ValueMember = "ID";
            // 
            // mesta
            // 
            this.mesta.DataPropertyName = "AUTO_CODE";
            this.mesta.DataSource = this.aVTOBindingSource;
            this.mesta.DisplayMember = "MESTA";
            this.mesta.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.mesta.HeaderText = "Мест";
            this.mesta.Name = "mesta";
            this.mesta.ReadOnly = true;
            this.mesta.ValueMember = "ID";
            // 
            // addCar
            // 
            this.addCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addCar.Location = new System.Drawing.Point(12, 438);
            this.addCar.Name = "addCar";
            this.addCar.Size = new System.Drawing.Size(108, 44);
            this.addCar.TabIndex = 3;
            this.addCar.Text = "Добавить";
            this.addCar.UseVisualStyleBackColor = true;
            this.addCar.Click += new System.EventHandler(this.addCar_Click);
            // 
            // T_carInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 494);
            this.Controls.Add(this.addCar);
            this.Controls.Add(this.dRIVER_AVTODataGridView);
            this.Controls.Add(this.dRIVERAVTOBindingNavigator);
            this.Name = "T_carInfo";
            this.Text = "Автомобили и водители";
            this.Load += new System.EventHandler(this.T_AddService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dRIVERAVTOBindingNavigator)).EndInit();
            this.dRIVERAVTOBindingNavigator.ResumeLayout(false);
            this.dRIVERAVTOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dRIVERAVTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aVTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dRIVER_AVTODataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TaxiDataSet taxiDataSet;
        private TaxiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dRIVERAVTOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tEHOSMOTRBindingNavigatorSaveItem;
        private TaxiDataSetTableAdapters.AVTOTableAdapter aVTOTableAdapter;
        private System.Windows.Forms.BindingSource aVTOBindingSource;
        private System.Windows.Forms.BindingSource dRIVERAVTOBindingSource;
        private TaxiDataSetTableAdapters.DRIVER_AVTOTableAdapter dRIVER_AVTOTableAdapter;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private TaxiDataSetTableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private System.Windows.Forms.DataGridView dRIVER_AVTODataGridView;
        private System.Windows.Forms.Button addCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn avto;
        private System.Windows.Forms.DataGridViewComboBoxColumn num_avto;
        private System.Windows.Forms.DataGridViewComboBoxColumn emp_fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn phone;
        private System.Windows.Forms.DataGridViewComboBoxColumn vin;
        private System.Windows.Forms.DataGridViewComboBoxColumn mesta;
    }
}