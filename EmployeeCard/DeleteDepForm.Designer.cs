
namespace EmployeeCard
{
    partial class DeleteDepForm
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
            this.departcomboBox = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataSet = new EmployeeCard.GymDataSet();
            this.deletebutton = new System.Windows.Forms.Button();
            this.departmentsTableAdapter = new EmployeeCard.GymDataSetTableAdapters.DepartmentsTableAdapter();
            this.closebutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отдел";
            // 
            // departcomboBox
            // 
            this.departcomboBox.DataSource = this.departmentsBindingSource;
            this.departcomboBox.DisplayMember = "Title";
            this.departcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departcomboBox.FormattingEnabled = true;
            this.departcomboBox.Location = new System.Drawing.Point(15, 51);
            this.departcomboBox.Name = "departcomboBox";
            this.departcomboBox.Size = new System.Drawing.Size(525, 24);
            this.departcomboBox.TabIndex = 1;
            this.departcomboBox.ValueMember = "Id";
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
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(15, 81);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(523, 23);
            this.deletebutton.TabIndex = 2;
            this.deletebutton.Text = "Удалить";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // closebutton1
            // 
            this.closebutton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.closebutton1.Location = new System.Drawing.Point(15, 122);
            this.closebutton1.Name = "closebutton1";
            this.closebutton1.Size = new System.Drawing.Size(523, 23);
            this.closebutton1.TabIndex = 4;
            this.closebutton1.Text = "Закрыть";
            this.closebutton1.UseVisualStyleBackColor = true;
            // 
            // DeleteDepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 157);
            this.Controls.Add(this.closebutton1);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.departcomboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(581, 204);
            this.MinimumSize = new System.Drawing.Size(581, 204);
            this.Name = "DeleteDepForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удалить отдел";
            this.Load += new System.EventHandler(this.DeleteDepForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox departcomboBox;
        private System.Windows.Forms.Button deletebutton;
        private GymDataSet gymDataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private GymDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.Button closebutton1;
    }
}