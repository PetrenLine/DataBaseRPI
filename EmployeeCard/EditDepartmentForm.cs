using EmployeeCard.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeCard
{
    public partial class EditDepartmentForm : Form
    {
        private bool _editMode = false;
        private int _depId = 0;
        public EditDepartmentForm()
        {
             
            InitializeComponent();
        }
        public EditDepartmentForm(bool editMode = false, int depId = 0 )
        {
            _editMode = editMode;
            _depId = depId;
            InitializeComponent();
        }

        private void EditDepartment_Load(object sender, EventArgs e)
        {
            if (_editMode)
            {
                var fieldsValues = DBHelper.SelectValuesFromTable(Constants.TableNames.DepartmentsTableName, _depId);
                depTitle.Text = fieldsValues[1];
            }
          
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (_editMode)
                {
                var fields = new Dictionary<string, TableField>();
                fields.Add(Constants.FieldsNemes.DepartmentsTable.Title, new TableField
                {
                    TableFieldType = TableFieldTypes.nvarchar,
                    TableFieldValue = depTitle.Text
                });
                DBHelper.UpdateEntry(Constants.TableNames.DepartmentsTableName, _depId, fields);
                DialogResult = DialogResult.OK;
            }
            else
            {
                var fields = new Dictionary<string, TableField>();
                fields.Add(Constants.FieldsNemes.DepartmentsTable.Title, new TableField {
                    TableFieldType = TableFieldTypes.nvarchar,
                    TableFieldValue = depTitle.Text
                });
                DBHelper.InsertEntry(Constants.TableNames.DepartmentsTableName, fields);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
