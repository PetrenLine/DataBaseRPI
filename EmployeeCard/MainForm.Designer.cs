
namespace EmployeeCard
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отделыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateDepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddDepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditDepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveDepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.deletInListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.createEmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddEmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditEmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveEmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exportDBToExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.leftparttableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupbax = new System.Windows.Forms.GroupBox();
            this.departmentCB = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GymBDbindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataSet = new EmployeeCard.GymDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EmplGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKEmployeesDepartmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.fKEmplPersonalDateEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addemploeeBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Editbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.removbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToWordBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToExcel = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.empdatatableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.workexperienceDisplTxt = new System.Windows.Forms.TextBox();
            this.workexperienceHiddenTxt = new System.Windows.Forms.TextBox();
            this.fKEmplWorkDateEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Posttxt = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.edacationtxt = new System.Windows.Forms.RichTextBox();
            this.imegeNameHidenField = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.EmpPersonDatatableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.AdressTxt = new System.Windows.Forms.RichTextBox();
            this.photoSeparatortableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.CitizenTxt = new System.Windows.Forms.TextBox();
            this.box = new System.Windows.Forms.GroupBox();
            this.Agetxt = new System.Windows.Forms.TextBox();
            this.birthtxt = new System.Windows.Forms.GroupBox();
            this.BithTxt = new System.Windows.Forms.TextBox();
            this.photoPictureBox_2 = new System.Windows.Forms.PictureBox();
            this.departmentsTableAdapter = new EmployeeCard.GymDataSetTableAdapters.DepartmentsTableAdapter();
            this.employeesTableAdapter = new EmployeeCard.GymDataSetTableAdapters.EmployeesTableAdapter();
            this.emplPersonalDateTableAdapter = new EmployeeCard.GymDataSetTableAdapters.EmplPersonalDateTableAdapter();
            this.emplWorkDateTableAdapter = new EmployeeCard.GymDataSetTableAdapters.EmplWorkDateTableAdapter();
            this.exportToWordFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.exportToExcelFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.exportToExcelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exportToExcelDataSet = new EmployeeCard.ExportToExcelDataSet();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.leftparttableLayoutPanel2.SuspendLayout();
            this.groupbax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GymBDbindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmplGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmployeesDepartmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmplPersonalDateEmployeesBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.empdatatableLayoutPanel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmplWorkDateEmployeesBindingSource)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.EmpPersonDatatableLayoutPanel3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.photoSeparatortableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.box.SuspendLayout();
            this.birthtxt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportToExcelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportToExcelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.отделыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // отделыToolStripMenuItem
            // 
            this.отделыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateDepToolStripMenuItem,
            this.toolStripMenuItem1,
            this.createEmpToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exportDBToExcel});
            this.отделыToolStripMenuItem.Name = "отделыToolStripMenuItem";
            this.отделыToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.отделыToolStripMenuItem.Text = "Управление данными";
            this.отделыToolStripMenuItem.Click += new System.EventHandler(this.отделыToolStripMenuItem_Click);
            // 
            // CreateDepToolStripMenuItem
            // 
            this.CreateDepToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddDepToolStripMenuItem,
            this.EditDepToolStripMenuItem,
            this.RemoveDepToolStripMenuItem,
            this.toolStripMenuItem2,
            this.deletInListToolStripMenuItem});
            this.CreateDepToolStripMenuItem.Name = "CreateDepToolStripMenuItem";
            this.CreateDepToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.CreateDepToolStripMenuItem.Text = "Отделы";
            // 
            // AddDepToolStripMenuItem
            // 
            this.AddDepToolStripMenuItem.Name = "AddDepToolStripMenuItem";
            this.AddDepToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.AddDepToolStripMenuItem.Text = "Добавить";
            this.AddDepToolStripMenuItem.Click += new System.EventHandler(this.AddDepToolStripMenuItem_Click);
            // 
            // EditDepToolStripMenuItem
            // 
            this.EditDepToolStripMenuItem.Name = "EditDepToolStripMenuItem";
            this.EditDepToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.EditDepToolStripMenuItem.Text = "Изменить";
            this.EditDepToolStripMenuItem.Click += new System.EventHandler(this.EditDepToolStripMenuItem_Click);
            // 
            // RemoveDepToolStripMenuItem
            // 
            this.RemoveDepToolStripMenuItem.Name = "RemoveDepToolStripMenuItem";
            this.RemoveDepToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.RemoveDepToolStripMenuItem.Text = "Удалить";
            this.RemoveDepToolStripMenuItem.Click += new System.EventHandler(this.RemoveDepToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(208, 6);
            // 
            // deletInListToolStripMenuItem
            // 
            this.deletInListToolStripMenuItem.Name = "deletInListToolStripMenuItem";
            this.deletInListToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.deletInListToolStripMenuItem.Text = "Удалить в списке";
            this.deletInListToolStripMenuItem.Click += new System.EventHandler(this.deletInListToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(218, 6);
            // 
            // createEmpToolStripMenuItem
            // 
            this.createEmpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddEmpToolStripMenuItem,
            this.EditEmpToolStripMenuItem,
            this.RemoveEmpToolStripMenuItem});
            this.createEmpToolStripMenuItem.Name = "createEmpToolStripMenuItem";
            this.createEmpToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.createEmpToolStripMenuItem.Text = "Сотрудники";
            // 
            // AddEmpToolStripMenuItem
            // 
            this.AddEmpToolStripMenuItem.Name = "AddEmpToolStripMenuItem";
            this.AddEmpToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.AddEmpToolStripMenuItem.Text = "Добавить";
            this.AddEmpToolStripMenuItem.Click += new System.EventHandler(this.AddEmpToolStripMenuItem_Click);
            // 
            // EditEmpToolStripMenuItem
            // 
            this.EditEmpToolStripMenuItem.Name = "EditEmpToolStripMenuItem";
            this.EditEmpToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.EditEmpToolStripMenuItem.Text = "Изменить";
            this.EditEmpToolStripMenuItem.Click += new System.EventHandler(this.EditEmpToolStripMenuItem_Click);
            // 
            // RemoveEmpToolStripMenuItem
            // 
            this.RemoveEmpToolStripMenuItem.Name = "RemoveEmpToolStripMenuItem";
            this.RemoveEmpToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.RemoveEmpToolStripMenuItem.Text = "Удалить";
            this.RemoveEmpToolStripMenuItem.Click += new System.EventHandler(this.RemoveEmpToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(218, 6);
            // 
            // exportDBToExcel
            // 
            this.exportDBToExcel.Name = "exportDBToExcel";
            this.exportDBToExcel.Size = new System.Drawing.Size(221, 26);
            this.exportDBToExcel.Text = "Экспорт БД в Excel";
            this.exportDBToExcel.Click += new System.EventHandler(this.exportDBToExcel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 480F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.leftparttableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1082, 598);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // leftparttableLayoutPanel2
            // 
            this.leftparttableLayoutPanel2.ColumnCount = 1;
            this.leftparttableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftparttableLayoutPanel2.Controls.Add(this.groupbax, 0, 0);
            this.leftparttableLayoutPanel2.Controls.Add(this.groupBox1, 0, 1);
            this.leftparttableLayoutPanel2.Controls.Add(this.toolStrip1, 0, 2);
            this.leftparttableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftparttableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.leftparttableLayoutPanel2.Name = "leftparttableLayoutPanel2";
            this.leftparttableLayoutPanel2.RowCount = 3;
            this.leftparttableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.leftparttableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftparttableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.leftparttableLayoutPanel2.Size = new System.Drawing.Size(474, 592);
            this.leftparttableLayoutPanel2.TabIndex = 0;
            // 
            // groupbax
            // 
            this.groupbax.Controls.Add(this.departmentCB);
            this.groupbax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupbax.Location = new System.Drawing.Point(3, 3);
            this.groupbax.Name = "groupbax";
            this.groupbax.Size = new System.Drawing.Size(468, 44);
            this.groupbax.TabIndex = 0;
            this.groupbax.TabStop = false;
            this.groupbax.Text = "Отделы";
            // 
            // departmentCB
            // 
            this.departmentCB.DataSource = this.departmentsBindingSource;
            this.departmentCB.DisplayMember = "Title";
            this.departmentCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentCB.FormattingEnabled = true;
            this.departmentCB.Location = new System.Drawing.Point(3, 18);
            this.departmentCB.Name = "departmentCB";
            this.departmentCB.Size = new System.Drawing.Size(462, 24);
            this.departmentCB.TabIndex = 0;
            this.departmentCB.ValueMember = "Id";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.GymBDbindingSource1;
            // 
            // GymBDbindingSource1
            // 
            this.GymBDbindingSource1.DataSource = this.gymDataSet;
            this.GymBDbindingSource1.Position = 0;
            // 
            // gymDataSet
            // 
            this.gymDataSet.DataSetName = "GymDataSet";
            this.gymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EmplGridView1);
            this.groupBox1.Controls.Add(this.photoPictureBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 506);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сотрудники";
            // 
            // EmplGridView1
            // 
            this.EmplGridView1.AllowUserToAddRows = false;
            this.EmplGridView1.AllowUserToDeleteRows = false;
            this.EmplGridView1.AutoGenerateColumns = false;
            this.EmplGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmplGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmplGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.departmentIdDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.midleNameDataGridViewTextBoxColumn});
            this.EmplGridView1.DataSource = this.fKEmployeesDepartmentsBindingSource;
            this.EmplGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmplGridView1.Location = new System.Drawing.Point(3, 18);
            this.EmplGridView1.Name = "EmplGridView1";
            this.EmplGridView1.ReadOnly = true;
            this.EmplGridView1.RowHeadersVisible = false;
            this.EmplGridView1.RowHeadersWidth = 51;
            this.EmplGridView1.RowTemplate.Height = 24;
            this.EmplGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmplGridView1.Size = new System.Drawing.Size(462, 485);
            this.EmplGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmentIdDataGridViewTextBoxColumn
            // 
            this.departmentIdDataGridViewTextBoxColumn.DataPropertyName = "DepartmentId";
            this.departmentIdDataGridViewTextBoxColumn.HeaderText = "DepartmentId";
            this.departmentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentIdDataGridViewTextBoxColumn.Name = "departmentIdDataGridViewTextBoxColumn";
            this.departmentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentIdDataGridViewTextBoxColumn.Visible = false;
            this.departmentIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // midleNameDataGridViewTextBoxColumn
            // 
            this.midleNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.midleNameDataGridViewTextBoxColumn.DataPropertyName = "MidleName";
            this.midleNameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.midleNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.midleNameDataGridViewTextBoxColumn.Name = "midleNameDataGridViewTextBoxColumn";
            this.midleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKEmployeesDepartmentsBindingSource
            // 
            this.fKEmployeesDepartmentsBindingSource.DataMember = "FK_Employees_Departments";
            this.fKEmployeesDepartmentsBindingSource.DataSource = this.departmentsBindingSource;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.fKEmplPersonalDateEmployeesBindingSource, "Photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(32724, 95);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(57, 56);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 1;
            this.photoPictureBox.TabStop = false;
            // 
            // fKEmplPersonalDateEmployeesBindingSource
            // 
            this.fKEmplPersonalDateEmployeesBindingSource.DataMember = "FK_EmplPersonalDate_Employees";
            this.fKEmplPersonalDateEmployeesBindingSource.DataSource = this.fKEmployeesDepartmentsBindingSource;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addemploeeBtn,
            this.toolStripSeparator1,
            this.Editbtn,
            this.toolStripSeparator2,
            this.removbtn,
            this.toolStripSeparator3,
            this.exportToWordBtn,
            this.toolStripSeparator4,
            this.exportToExcel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 562);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(474, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addemploeeBtn
            // 
            this.addemploeeBtn.Image = ((System.Drawing.Image)(resources.GetObject("addemploeeBtn.Image")));
            this.addemploeeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addemploeeBtn.Name = "addemploeeBtn";
            this.addemploeeBtn.Size = new System.Drawing.Size(100, 24);
            this.addemploeeBtn.Text = "Добавить";
            this.addemploeeBtn.Click += new System.EventHandler(this.addemploeeBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // Editbtn
            // 
            this.Editbtn.Image = ((System.Drawing.Image)(resources.GetObject("Editbtn.Image")));
            this.Editbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(111, 24);
            this.Editbtn.Text = "Измениить";
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // removbtn
            // 
            this.removbtn.Image = ((System.Drawing.Image)(resources.GetObject("removbtn.Image")));
            this.removbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removbtn.Name = "removbtn";
            this.removbtn.Size = new System.Drawing.Size(89, 24);
            this.removbtn.Text = "Удалить";
            this.removbtn.Click += new System.EventHandler(this.removbtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // exportToWordBtn
            // 
            this.exportToWordBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exportToWordBtn.Image = ((System.Drawing.Image)(resources.GetObject("exportToWordBtn.Image")));
            this.exportToWordBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportToWordBtn.Name = "exportToWordBtn";
            this.exportToWordBtn.Size = new System.Drawing.Size(29, 24);
            this.exportToWordBtn.Text = "Экспорт в Word";
            this.exportToWordBtn.Click += new System.EventHandler(this.exportToWordBtn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // exportToExcel
            // 
            this.exportToExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exportToExcel.Image = ((System.Drawing.Image)(resources.GetObject("exportToExcel.Image")));
            this.exportToExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportToExcel.Name = "exportToExcel";
            this.exportToExcel.Size = new System.Drawing.Size(29, 24);
            this.exportToExcel.Text = "Экспорт в  Excel";
            this.exportToExcel.Click += new System.EventHandler(this.exportToExcel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.empdatatableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(483, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 592);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные о сотруднике:";
            // 
            // empdatatableLayoutPanel3
            // 
            this.empdatatableLayoutPanel3.ColumnCount = 1;
            this.empdatatableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.empdatatableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.empdatatableLayoutPanel3.Controls.Add(this.groupBox4, 0, 1);
            this.empdatatableLayoutPanel3.Controls.Add(this.groupBox3, 0, 0);
            this.empdatatableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empdatatableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
            this.empdatatableLayoutPanel3.Name = "empdatatableLayoutPanel3";
            this.empdatatableLayoutPanel3.RowCount = 2;
            this.empdatatableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.empdatatableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.empdatatableLayoutPanel3.Size = new System.Drawing.Size(590, 571);
            this.empdatatableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 288);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(584, 280);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Рабочие данные:";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox9, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox6, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(578, 259);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.workexperienceDisplTxt);
            this.groupBox9.Controls.Add(this.workexperienceHiddenTxt);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(3, 212);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(572, 44);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Опыт работы:";
            // 
            // workexperienceDisplTxt
            // 
            this.workexperienceDisplTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.workexperienceDisplTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workexperienceDisplTxt.Location = new System.Drawing.Point(3, 18);
            this.workexperienceDisplTxt.Name = "workexperienceDisplTxt";
            this.workexperienceDisplTxt.ReadOnly = true;
            this.workexperienceDisplTxt.Size = new System.Drawing.Size(566, 22);
            this.workexperienceDisplTxt.TabIndex = 1;
            // 
            // workexperienceHiddenTxt
            // 
            this.workexperienceHiddenTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.workexperienceHiddenTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKEmplWorkDateEmployeesBindingSource, "WorkExperience", true));
            this.workexperienceHiddenTxt.Enabled = false;
            this.workexperienceHiddenTxt.Location = new System.Drawing.Point(3, 18);
            this.workexperienceHiddenTxt.Name = "workexperienceHiddenTxt";
            this.workexperienceHiddenTxt.Size = new System.Drawing.Size(0, 22);
            this.workexperienceHiddenTxt.TabIndex = 0;
            this.workexperienceHiddenTxt.TextChanged += new System.EventHandler(this.workexperienceHiddenTxt_TextChanged);
            // 
            // fKEmplWorkDateEmployeesBindingSource
            // 
            this.fKEmplWorkDateEmployeesBindingSource.DataMember = "FK_EmplWorkDate_Employees";
            this.fKEmplWorkDateEmployeesBindingSource.DataSource = this.fKEmployeesDepartmentsBindingSource;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Posttxt);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(572, 44);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Должность:";
            // 
            // Posttxt
            // 
            this.Posttxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Posttxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKEmplWorkDateEmployeesBindingSource, "Post", true));
            this.Posttxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Posttxt.Location = new System.Drawing.Point(3, 18);
            this.Posttxt.Name = "Posttxt";
            this.Posttxt.ReadOnly = true;
            this.Posttxt.Size = new System.Drawing.Size(566, 22);
            this.Posttxt.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.edacationtxt);
            this.groupBox6.Controls.Add(this.imegeNameHidenField);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 53);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(572, 153);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Образование:";
            // 
            // edacationtxt
            // 
            this.edacationtxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.edacationtxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKEmplWorkDateEmployeesBindingSource, "Education", true));
            this.edacationtxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edacationtxt.Location = new System.Drawing.Point(3, 18);
            this.edacationtxt.Name = "edacationtxt";
            this.edacationtxt.ReadOnly = true;
            this.edacationtxt.Size = new System.Drawing.Size(566, 132);
            this.edacationtxt.TabIndex = 1;
            this.edacationtxt.Text = "";
            // 
            // imegeNameHidenField
            // 
            this.imegeNameHidenField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKEmplPersonalDateEmployeesBindingSource, "PhotoFileName", true));
            this.imegeNameHidenField.Location = new System.Drawing.Point(7, 22);
            this.imegeNameHidenField.Name = "imegeNameHidenField";
            this.imegeNameHidenField.Size = new System.Drawing.Size(592, 22);
            this.imegeNameHidenField.TabIndex = 2;
            this.imegeNameHidenField.TextChanged += new System.EventHandler(this.imegeNameHidenField_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.EmpPersonDatatableLayoutPanel3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(584, 279);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Персональные данные:";
            // 
            // EmpPersonDatatableLayoutPanel3
            // 
            this.EmpPersonDatatableLayoutPanel3.ColumnCount = 1;
            this.EmpPersonDatatableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EmpPersonDatatableLayoutPanel3.Controls.Add(this.groupBox8, 0, 1);
            this.EmpPersonDatatableLayoutPanel3.Controls.Add(this.photoSeparatortableLayoutPanel, 0, 0);
            this.EmpPersonDatatableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmpPersonDatatableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
            this.EmpPersonDatatableLayoutPanel3.Name = "EmpPersonDatatableLayoutPanel3";
            this.EmpPersonDatatableLayoutPanel3.RowCount = 2;
            this.EmpPersonDatatableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.EmpPersonDatatableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EmpPersonDatatableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.EmpPersonDatatableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.EmpPersonDatatableLayoutPanel3.Size = new System.Drawing.Size(578, 258);
            this.EmpPersonDatatableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.AdressTxt);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(3, 153);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(572, 102);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Адрес регистрации:";
            // 
            // AdressTxt
            // 
            this.AdressTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AdressTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKEmplPersonalDateEmployeesBindingSource, "Addres", true));
            this.AdressTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdressTxt.Location = new System.Drawing.Point(3, 18);
            this.AdressTxt.Name = "AdressTxt";
            this.AdressTxt.ReadOnly = true;
            this.AdressTxt.Size = new System.Drawing.Size(566, 81);
            this.AdressTxt.TabIndex = 0;
            this.AdressTxt.Text = "";
            this.AdressTxt.TextChanged += new System.EventHandler(this.AdressTxt_TextChanged);
            // 
            // photoSeparatortableLayoutPanel
            // 
            this.photoSeparatortableLayoutPanel.ColumnCount = 2;
            this.photoSeparatortableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.photoSeparatortableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.photoSeparatortableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.photoSeparatortableLayoutPanel.Controls.Add(this.photoPictureBox_2, 0, 0);
            this.photoSeparatortableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.photoSeparatortableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.photoSeparatortableLayoutPanel.Name = "photoSeparatortableLayoutPanel";
            this.photoSeparatortableLayoutPanel.RowCount = 1;
            this.photoSeparatortableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.photoSeparatortableLayoutPanel.Size = new System.Drawing.Size(572, 144);
            this.photoSeparatortableLayoutPanel.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.box, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.birthtxt, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(163, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(406, 138);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.CitizenTxt);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(3, 103);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(400, 44);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Граждансво:";
            // 
            // CitizenTxt
            // 
            this.CitizenTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CitizenTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKEmplPersonalDateEmployeesBindingSource, "CitizenShip", true));
            this.CitizenTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CitizenTxt.Location = new System.Drawing.Point(3, 18);
            this.CitizenTxt.Name = "CitizenTxt";
            this.CitizenTxt.ReadOnly = true;
            this.CitizenTxt.Size = new System.Drawing.Size(394, 22);
            this.CitizenTxt.TabIndex = 0;
            // 
            // box
            // 
            this.box.Controls.Add(this.Agetxt);
            this.box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box.Location = new System.Drawing.Point(3, 3);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(400, 44);
            this.box.TabIndex = 0;
            this.box.TabStop = false;
            this.box.Text = "Возраст:";
            // 
            // Agetxt
            // 
            this.Agetxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Agetxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKEmplPersonalDateEmployeesBindingSource, "Age", true));
            this.Agetxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Agetxt.Location = new System.Drawing.Point(3, 18);
            this.Agetxt.Name = "Agetxt";
            this.Agetxt.ReadOnly = true;
            this.Agetxt.Size = new System.Drawing.Size(394, 22);
            this.Agetxt.TabIndex = 0;
            // 
            // birthtxt
            // 
            this.birthtxt.Controls.Add(this.BithTxt);
            this.birthtxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.birthtxt.Location = new System.Drawing.Point(3, 53);
            this.birthtxt.Name = "birthtxt";
            this.birthtxt.Size = new System.Drawing.Size(400, 44);
            this.birthtxt.TabIndex = 1;
            this.birthtxt.TabStop = false;
            this.birthtxt.Text = "Дата рождения:";
            // 
            // BithTxt
            // 
            this.BithTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BithTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKEmplPersonalDateEmployeesBindingSource, "BirthDate", true));
            this.BithTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BithTxt.Location = new System.Drawing.Point(3, 18);
            this.BithTxt.Name = "BithTxt";
            this.BithTxt.ReadOnly = true;
            this.BithTxt.Size = new System.Drawing.Size(394, 22);
            this.BithTxt.TabIndex = 0;
            // 
            // photoPictureBox_2
            // 
            this.photoPictureBox_2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.photoPictureBox_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.photoPictureBox_2.Location = new System.Drawing.Point(3, 3);
            this.photoPictureBox_2.Name = "photoPictureBox_2";
            this.photoPictureBox_2.Size = new System.Drawing.Size(154, 138);
            this.photoPictureBox_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox_2.TabIndex = 1;
            this.photoPictureBox_2.TabStop = false;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // emplPersonalDateTableAdapter
            // 
            this.emplPersonalDateTableAdapter.ClearBeforeFill = true;
            // 
            // emplWorkDateTableAdapter
            // 
            this.emplWorkDateTableAdapter.ClearBeforeFill = true;
            // 
            // exportToWordFileDialog
            // 
            this.exportToWordFileDialog.Filter = "Word files | *.docx";
            // 
            // exportToExcelFileDialog
            // 
            this.exportToExcelFileDialog.Filter = "Excel files | *.xlsx";
            // 
            // exportToExcelBindingSource
            // 
            this.exportToExcelBindingSource.DataSource = this.exportToExcelDataSet;
            this.exportToExcelBindingSource.Position = 0;
            // 
            // exportToExcelDataSet
            // 
            this.exportToExcelDataSet.DataSetName = "ExportToExcelDataSet";
            this.exportToExcelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 626);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1100, 673);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Карточка Сотрудника спортзала";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.leftparttableLayoutPanel2.ResumeLayout(false);
            this.leftparttableLayoutPanel2.PerformLayout();
            this.groupbax.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GymBDbindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmplGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmployeesDepartmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmplPersonalDateEmployeesBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.empdatatableLayoutPanel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmplWorkDateEmployeesBindingSource)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.EmpPersonDatatableLayoutPanel3.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.photoSeparatortableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.box.ResumeLayout(false);
            this.box.PerformLayout();
            this.birthtxt.ResumeLayout(false);
            this.birthtxt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportToExcelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportToExcelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отделыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateDepToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createEmpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddEmpToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel leftparttableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupbax;
        private System.Windows.Forms.ComboBox departmentCB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView EmplGridView1;
        private System.Windows.Forms.BindingSource GymBDbindingSource1;
        private GymDataSet gymDataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private GymDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.BindingSource fKEmployeesDepartmentsBindingSource;
        private GymDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel empdatatableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel EmpPersonDatatableLayoutPanel3;
        private System.Windows.Forms.GroupBox box;
        private System.Windows.Forms.TextBox Agetxt;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RichTextBox AdressTxt;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox CitizenTxt;
        private System.Windows.Forms.GroupBox birthtxt;
        private System.Windows.Forms.TextBox BithTxt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox workexperienceHiddenTxt;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox Posttxt;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox edacationtxt;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addemploeeBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Editbtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton removbtn;
        private System.Windows.Forms.ToolStripMenuItem EditEmpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveEmpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddDepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditDepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveDepToolStripMenuItem;
        private System.Windows.Forms.BindingSource fKEmplPersonalDateEmployeesBindingSource;
        private GymDataSetTableAdapters.EmplPersonalDateTableAdapter emplPersonalDateTableAdapter;
        private System.Windows.Forms.BindingSource fKEmplWorkDateEmployeesBindingSource;
        private GymDataSetTableAdapters.EmplWorkDateTableAdapter emplWorkDateTableAdapter;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deletInListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox workexperienceDisplTxt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton exportToWordBtn;
        private System.Windows.Forms.SaveFileDialog exportToWordFileDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton exportToExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exportDBToExcel;
        private System.Windows.Forms.SaveFileDialog exportToExcelFileDialog;
        private System.Windows.Forms.BindingSource exportToExcelBindingSource;
        private ExportToExcelDataSet exportToExcelDataSet;
        private System.Windows.Forms.TableLayoutPanel photoSeparatortableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.TextBox imegeNameHidenField;
        private System.Windows.Forms.PictureBox photoPictureBox_2;
    }
}

