using EmployeeCard.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeCard
{
    public partial class EditEmployeeForm : Form
    {
        private bool _isEditMode = false;
        private int _id = 0;
        private byte[] _photo;
        private string _photoPath;
        private string _cardPath;
        private string currentFolder;


        public EditEmployeeForm()
        {
            InitializeComponent();
            var currentFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        }

        public EditEmployeeForm(bool isEditMode, int id)
        {
            _isEditMode = isEditMode;
            _id = id;
            InitializeComponent();

        }








        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.gymDataSet.Departments);
            if (_isEditMode)
            {
                this.employeeMergedDataTableTableAdapter.Fill(this.editEmployeeDataSet.EmployeeMergedDataTable, _id);
                var employeeData = employeeMergedDataTableTableAdapter.GetData(_id);
                if (employeeData?.Count > 0)
                {
                    var departmentId = employeeData.FirstOrDefault()?.DepartmentId ?? 0;
                    departmentCB.SelectedValue = departmentId;
                }
                choosePhotoBtn.Visible = true;
                chooseCardBtn.Visible = false;


            }

            else
            {
                choosePhotoBtn.Visible = false;
                chooseCardBtn.Visible = true;
            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {


            //Поля сотрудника
            var employeeFields = new Dictionary<string, TableField>();
            employeeFields.Add(Constants.FieldsNemes.EmployeesTable.DepartmentId, new TableField
            {
                TableFieldType = TableFieldTypes.integer,
                TableFieldValue = departmentCB.SelectedValue.ToString()
            });
            employeeFields.Add(Constants.FieldsNemes.EmployeesTable.LastName, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = lastNameTxt.Text

            });
            employeeFields.Add(Constants.FieldsNemes.EmployeesTable.FirstName, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = firstNameTxt.Text
            });
            employeeFields.Add(Constants.FieldsNemes.EmployeesTable.MidleName, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = midleNameTxt.Text
            });

            //персональыне данные 
            var personalDataFields = new Dictionary<string, TableField>();

            personalDataFields.Add(Constants.FieldsNemes.EmplPersonalDateTable.EmployeId, new TableField
            {
                TableFieldType = TableFieldTypes.integer,
                TableFieldValue = string.Empty
            });
            personalDataFields.Add(Constants.FieldsNemes.EmplPersonalDateTable.Age, new TableField
            {
                TableFieldType = TableFieldTypes.integer,
                TableFieldValue = Math.Ceiling((DateTime.Now - birthDateDP.Value).TotalDays / 365).ToString()
            });
            personalDataFields.Add(Constants.FieldsNemes.EmplPersonalDateTable.BirthDate, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = birthDateDP.Value.ToString("dd.MM.yyyy")
            });
            personalDataFields.Add(Constants.FieldsNemes.EmplPersonalDateTable.CitizenShip, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = citizenTxt.Text
            });
            personalDataFields.Add(Constants.FieldsNemes.EmplPersonalDateTable.Addres, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = adressTxt.Text
            });
            //рабочие данные
            var workDataFields = new Dictionary<string, TableField>();
            workDataFields.Add(Constants.FieldsNemes.EmplWorkDateTable.EmployeeId, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = string.Empty
            });
            workDataFields.Add(Constants.FieldsNemes.EmplWorkDateTable.Post, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = postTxt.Text
            });
            workDataFields.Add(Constants.FieldsNemes.EmplWorkDateTable.Education, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = educationTxt.Text
            });
            workDataFields.Add(Constants.FieldsNemes.EmplWorkDateTable.WorkExperience, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = workExDP.Value.ToString("dd.MM.yyyy")
            });
            if (!string.IsNullOrEmpty(_cardPath))
            {

                var technicalCardName = $"{DateTime.Now.ToString($"yyyy_MM_dd_hh_ss_ms")}.docx";

                File.Copy(_cardPath, $"{currentFolder}\\CardsData\\{technicalCardName}", true);
                workDataFields.Add(Constants.FieldsNemes.EmplWorkDateTable.WorkCard, new TableField
                {
                    TableFieldType = TableFieldTypes.nvarchar,
                    TableFieldValue = technicalCardName
                });

                if (_isEditMode)
                {
                    if (!string.IsNullOrEmpty(_photoPath))
                    {

                        var technicalFileName = $"{DateTime.Now.ToString($"yyyy_MM_dd_hh_ss_ms")}{Path.GetExtension(_photoPath)}";

                        File.Copy(_photoPath, $"{currentFolder}\\ImegeData\\{technicalFileName}", true);
                        personalDataFields.Add(Constants.FieldsNemes.EmplPersonalDateTable.PhotoFileName, new TableField
                        {
                            TableFieldType = TableFieldTypes.nvarchar,
                            TableFieldValue = technicalFileName
                        });

                        personalDataFields[Constants.FieldsNemes.EmplPersonalDateTable.EmployeId].TableFieldValue
                     = _id.ToString();
                        workDataFields[Constants.FieldsNemes.EmplWorkDateTable.EmployeeId].TableFieldValue
                         = _id.ToString();

                        DBHelper.UpdateEntry(Constants.TableNames.EmployeesTableName, _id, employeeFields);
                        DBHelper.UpdateEntry(Constants.TableNames.EmplPersonalDateTableName, new FieldForUpdate
                        {
                            FieldName = Constants.FieldsNemes.EmplPersonalDateTable.EmployeId,
                            FieldValue = new TableField
                            {
                                TableFieldType = TableFieldTypes.integer,
                                TableFieldValue = _id.ToString()
                            }
                        }, personalDataFields);
                        DBHelper.UpdateEntry(Constants.TableNames.EmplWorkDateTableName, new FieldForUpdate
                        {
                            FieldName = Constants.FieldsNemes.EmplWorkDateTable.EmployeeId,
                            FieldValue = new TableField
                            {
                                TableFieldType = TableFieldTypes.integer,
                                TableFieldValue = _id.ToString()
                            }
                        }, workDataFields);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        var employeeId = DBHelper.InsertEntry(Constants.TableNames.EmployeesTableName, employeeFields);
                        personalDataFields[Constants.FieldsNemes.EmplPersonalDateTable.EmployeId].TableFieldValue
                            = employeeId.ToString();
                        workDataFields[Constants.FieldsNemes.EmplWorkDateTable.EmployeeId].TableFieldValue
                            = employeeId.ToString();
                        DBHelper.InsertEntry(Constants.TableNames.EmplPersonalDateTableName, personalDataFields);
                        DBHelper.InsertEntry(Constants.TableNames.EmplWorkDateTableName, workDataFields);
                        DialogResult = DialogResult.OK;
                    }

                }
            }
        }
            private void choosePhotoBtn_Click(object sender, EventArgs e)
            {
                if (chooseImegwDialog.ShowDialog() == DialogResult.OK)
                {
                    _photoPath = chooseImegwDialog.FileName;

                }
            }
        
            private void chooseCardBtn_Click(object sender, EventArgs e)
            {

                if (chooseCardFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _cardPath = chooseCardFileDialog.FileName;

                }
            }
        }
    } 
