
namespace EmployeeCard
{
    partial class EditEmployeeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.departmentCB = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataSet = new EmployeeCard.GymDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.employeeMergedDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editEmployeeDataSet = new EmployeeCard.EditEmployeeDataSet();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.midleNameTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.adressTxt = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.citizenTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.birthDateDP = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chooseCardBtn = new System.Windows.Forms.Button();
            this.choosePhotoBtn = new System.Windows.Forms.Button();
            this.workExDP = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.educationTxt = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.postTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.canselBtn = new System.Windows.Forms.Button();
            this.gymDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsTableAdapter = new EmployeeCard.GymDataSetTableAdapters.DepartmentsTableAdapter();
            this.employeeMergedDataTableTableAdapter = new EmployeeCard.EditEmployeeDataSetTableAdapters.EmployeeMergedDataTableTableAdapter();
            this.chooseImegwDialog = new System.Windows.Forms.OpenFileDialog();
            this.chooseCardFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeMergedDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editEmployeeDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отдел";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // departmentCB
            // 
            this.departmentCB.DataSource = this.departmentsBindingSource;
            this.departmentCB.DisplayMember = "Title";
            this.departmentCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentCB.FormattingEnabled = true;
            this.departmentCB.Location = new System.Drawing.Point(13, 34);
            this.departmentCB.Name = "departmentCB";
            this.departmentCB.Size = new System.Drawing.Size(361, 24);
            this.departmentCB.TabIndex = 1;
            this.departmentCB.ValueMember = "Id";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.gymDataSet;
            // 
            // gymDataSet
            // 
            this.gymDataSet.DataSetName = "GymDataSet";
            this.gymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Отчесво ";
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeMergedDataTableBindingSource, "LastName", true));
            this.lastNameTxt.Location = new System.Drawing.Point(10, 49);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(365, 22);
            this.lastNameTxt.TabIndex = 7;
            // 
            // employeeMergedDataTableBindingSource
            // 
            this.employeeMergedDataTableBindingSource.DataMember = "EmployeeMergedDataTable";
            this.employeeMergedDataTableBindingSource.DataSource = this.editEmployeeDataSet;
            // 
            // editEmployeeDataSet
            // 
            this.editEmployeeDataSet.DataSetName = "EditEmployeeDataSet";
            this.editEmployeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeMergedDataTableBindingSource, "FirstName", true));
            this.firstNameTxt.Location = new System.Drawing.Point(6, 117);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(365, 22);
            this.firstNameTxt.TabIndex = 8;
            // 
            // midleNameTxt
            // 
            this.midleNameTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeMergedDataTableBindingSource, "MidleName", true));
            this.midleNameTxt.Location = new System.Drawing.Point(6, 182);
            this.midleNameTxt.Name = "midleNameTxt";
            this.midleNameTxt.Size = new System.Drawing.Size(365, 22);
            this.midleNameTxt.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.adressTxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.citizenTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.birthDateDP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lastNameTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.midleNameTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.firstNameTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(6, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 509);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Персональные данные";
            // 
            // adressTxt
            // 
            this.adressTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeMergedDataTableBindingSource, "Addres", true));
            this.adressTxt.Location = new System.Drawing.Point(6, 376);
            this.adressTxt.Name = "adressTxt";
            this.adressTxt.Size = new System.Drawing.Size(370, 127);
            this.adressTxt.TabIndex = 15;
            this.adressTxt.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-2, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Адресс регистрации";
            // 
            // citizenTxt
            // 
            this.citizenTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeMergedDataTableBindingSource, "CitizenShip", true));
            this.citizenTxt.Location = new System.Drawing.Point(6, 319);
            this.citizenTxt.Name = "citizenTxt";
            this.citizenTxt.Size = new System.Drawing.Size(365, 22);
            this.citizenTxt.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Граждансво";
            // 
            // birthDateDP
            // 
            this.birthDateDP.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeeMergedDataTableBindingSource, "BirthDate", true));
            this.birthDateDP.Location = new System.Drawing.Point(6, 249);
            this.birthDateDP.Name = "birthDateDP";
            this.birthDateDP.Size = new System.Drawing.Size(362, 22);
            this.birthDateDP.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата рождения";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chooseCardBtn);
            this.groupBox2.Controls.Add(this.choosePhotoBtn);
            this.groupBox2.Controls.Add(this.workExDP);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.educationTxt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.postTxt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(405, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 531);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Рабочие данные";
            // 
            // chooseCardBtn
            // 
            this.chooseCardBtn.Location = new System.Drawing.Point(149, 458);
            this.chooseCardBtn.Name = "chooseCardBtn";
            this.chooseCardBtn.Size = new System.Drawing.Size(299, 23);
            this.chooseCardBtn.TabIndex = 20;
            this.chooseCardBtn.Text = "Карточка Сотрудника";
            this.chooseCardBtn.UseVisualStyleBackColor = true;
            // 
            // choosePhotoBtn
            // 
            this.choosePhotoBtn.Location = new System.Drawing.Point(149, 487);
            this.choosePhotoBtn.Name = "choosePhotoBtn";
            this.choosePhotoBtn.Size = new System.Drawing.Size(299, 23);
            this.choosePhotoBtn.TabIndex = 14;
            this.choosePhotoBtn.Text = "Выбрать фотографию";
            this.choosePhotoBtn.UseVisualStyleBackColor = true;
            // 
            // workExDP
            // 
            this.workExDP.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeeMergedDataTableBindingSource, "WorkExperience", true));
            this.workExDP.Location = new System.Drawing.Point(2, 285);
            this.workExDP.Name = "workExDP";
            this.workExDP.Size = new System.Drawing.Size(362, 22);
            this.workExDP.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Дата начала карьеры";
            // 
            // educationTxt
            // 
            this.educationTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeMergedDataTableBindingSource, "Education", true));
            this.educationTxt.Location = new System.Drawing.Point(5, 121);
            this.educationTxt.Name = "educationTxt";
            this.educationTxt.Size = new System.Drawing.Size(370, 127);
            this.educationTxt.TabIndex = 17;
            this.educationTxt.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-3, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Данные об образовании";
            // 
            // postTxt
            // 
            this.postTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeMergedDataTableBindingSource, "Post", true));
            this.postTxt.Location = new System.Drawing.Point(3, 60);
            this.postTxt.Name = "postTxt";
            this.postTxt.Size = new System.Drawing.Size(365, 22);
            this.postTxt.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-3, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Должность";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(4, 593);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(292, 23);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // canselBtn
            // 
            this.canselBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.canselBtn.Location = new System.Drawing.Point(554, 593);
            this.canselBtn.Name = "canselBtn";
            this.canselBtn.Size = new System.Drawing.Size(305, 23);
            this.canselBtn.TabIndex = 13;
            this.canselBtn.Text = "Отмена";
            this.canselBtn.UseVisualStyleBackColor = true;
            // 
            // gymDataSetBindingSource
            // 
            this.gymDataSetBindingSource.DataSource = this.gymDataSet;
            this.gymDataSetBindingSource.Position = 0;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // employeeMergedDataTableTableAdapter
            // 
            this.employeeMergedDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // chooseImegwDialog
            // 
            this.chooseImegwDialog.Filter = "Jpg images | *.jpg";
            // 
            // chooseCardFileDialog
            // 
            this.chooseCardFileDialog.Filter = "Word docs | *.docx";
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 620);
            this.Controls.Add(this.canselBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.departmentCB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(889, 667);
            this.MinimumSize = new System.Drawing.Size(889, 667);
            this.Name = "EditEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование данных о сотруднике";
            this.Load += new System.EventHandler(this.EditEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeMergedDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editEmployeeDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox departmentCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.TextBox midleNameTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox adressTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox citizenTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker birthDateDP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker workExDP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox educationTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox postTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button canselBtn;
        private System.Windows.Forms.BindingSource gymDataSetBindingSource;
        private GymDataSet gymDataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private GymDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.BindingSource employeeMergedDataTableBindingSource;
        private EditEmployeeDataSet editEmployeeDataSet;
        private EditEmployeeDataSetTableAdapters.EmployeeMergedDataTableTableAdapter employeeMergedDataTableTableAdapter;
        private System.Windows.Forms.Button choosePhotoBtn;
        private System.Windows.Forms.OpenFileDialog chooseImegwDialog;
        private System.Windows.Forms.Button chooseCardBtn;
        private System.Windows.Forms.OpenFileDialog chooseCardFileDialog;
    }
}