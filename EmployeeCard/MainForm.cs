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
using WordTemplateFiller;
using WordTemplateFiller.Models;
using ExelExporter;
using EmployeeCard.ExportToExcelDataSetTableAdapters;

namespace EmployeeCard
{
    public partial class MainForm : Form
    {
        private const string templatesFolderName = "Templates";
        private const string templateFileName = "EmployeeCardTemplate.docx";
        private string templatePath;

        private const int lastNameColumnIdx = 2;
        private const int firstNameColumnIdx = 3;
        private const int patronimicColumnIdx = 4;
        public MainForm()
        {
            var currentAssemblyPath = Assembly.GetEntryAssembly().Location;
            var currentFolder = Path.GetDirectoryName(currentAssemblyPath);
            templatePath = $"{currentFolder}\\{templatesFolderName}\\{templateFileName}";
            InitializeComponent();
        }

        private void RefreshData()
        {
            // TODO: This line of code loads data into the 'gymDataSet.EmplWorkDate' table. You can move, or remove it, as needed.
            this.emplWorkDateTableAdapter.Fill(this.gymDataSet.EmplWorkDate);
            // TODO: This line of code loads data into the 'gymDataSet.EmplPersonalDate' table. You can move, or remove it, as needed.
            this.emplPersonalDateTableAdapter.Fill(this.gymDataSet.EmplPersonalDate);
            // TODO: This line of code loads data into the 'gymDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.gymDataSet.Employees);
            // TODO: This line of code loads data into the 'gymDataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.gymDataSet.Departments);
        }

        private void RefreshEmployees()
        {
            this.emplWorkDateTableAdapter.Fill(this.gymDataSet.EmplWorkDate);
            this.emplPersonalDateTableAdapter.Fill(this.gymDataSet.EmplPersonalDate);
            this.employeesTableAdapter.Fill(this.gymDataSet.Employees);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshData();
                AdressTxt.ReadOnly = true;
                edacationtxt.ReadOnly = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void отделыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AdressTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddDepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (new EditDepartmentForm().ShowDialog() == DialogResult.OK)
                {
                    this.departmentsTableAdapter.Fill(this.gymDataSet.Departments);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void EditDepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (departmentCB.Items.Count == 0)
                {
                    MessageBox.Show("Отсутствует выбранный отдел!");
                    return;
                }
                var id = 0;

                if (int.TryParse(departmentCB.SelectedValue.ToString(), out id)
                      && new EditDepartmentForm(true, id).ShowDialog() == DialogResult.OK)
                {
                    this.departmentsTableAdapter.Fill(this.gymDataSet.Departments);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void RemoveDepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (departmentCB.Items.Count == 0)
                {
                    MessageBox.Show("Отсутствует выбранный отдел!");
                    return;
                }
                var id = 0;
                if (int.TryParse(departmentCB.SelectedValue.ToString(), out id)
                  && MessageBox.Show($"Вы дейсвительно хотите удалить выбранный отдел({departmentCB.Text})?",
                  "Удалить выбранный отдел?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DBHelper.DeleteEntry(Constants.TableNames.DepartmentsTableName, id);
                    this.departmentsTableAdapter.Fill(this.gymDataSet.Departments);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void deletInListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (new DeleteDepForm().ShowDialog() == DialogResult.OK)
                {
                    this.departmentsTableAdapter.Fill(this.gymDataSet.Departments);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DeleteEmployee()
        {
            try
            {
                if (EmplGridView1.Rows.Count == 0 || EmplGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Не выбран ни один сотрудник!");
                    return;

                }
                var id = 0;
                int.TryParse(EmplGridView1.SelectedRows[0].Cells[0].Value?.ToString(), out id);
                var firstName = EmplGridView1.SelectedRows[0].Cells[2].Value?.ToString() ?? string.Empty;
                var lastName = EmplGridView1.SelectedRows[0].Cells[3].Value?.ToString() ?? string.Empty;
                var midleName = EmplGridView1.SelectedRows[0].Cells[4].Value?.ToString() ?? string.Empty;
                var fio = $" {firstName} {lastName} {midleName}";
                if (id != 0
                    && MessageBox.Show($"Вы дейвительно хотите удалить сотрудника{fio}?",
                    "Удаление сотрудника", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DBHelper.DeleteEntry(Constants.TableNames.EmployeesTableName, id);
                    this.employeesTableAdapter.Fill(this.gymDataSet.Employees);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void EditEmployee(bool isEditMode = false)
        {
            try
            {
                if (isEditMode)
                {
                    if (EmplGridView1.Rows.Count == 0 || EmplGridView1.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Не выбран ни один сотрудник!");
                        return;

                    }
                    var id = 0;
                    int.TryParse(EmplGridView1.SelectedRows[0].Cells[0].Value?.ToString(), out id);
                    if (id != 0 && new EditEmployeeForm(true, id).ShowDialog() == DialogResult.OK)
                    {
                        RefreshEmployees();
                    }
                }
                else if (new EditEmployeeForm().ShowDialog() == DialogResult.OK)

                {
                    RefreshEmployees();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AddEmpToolStripMenuItem_Click(object sender, EventArgs e)
       => EditEmployee();

        private void addemploeeBtn_Click(object sender, EventArgs e)
      => EditEmployee();

        private void EditEmpToolStripMenuItem_Click(object sender, EventArgs e)
       => EditEmployee(true);

        private void Editbtn_Click(object sender, EventArgs e)
     => EditEmployee(true);

        private void removbtn_Click(object sender, EventArgs e)
           => DeleteEmployee();

        private void RemoveEmpToolStripMenuItem_Click(object sender, EventArgs e)
           => DeleteEmployee();

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        => Application.Exit();

        private void workexperienceDisplTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void workexperienceHiddenTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var parsedDate = DateTime.Now;
                if (DateTime.TryParse(((TextBox)sender).Text, out parsedDate))
                {
                    var diff = DateTime.Now - parsedDate;
                    var totalDays = diff.TotalDays;

                    var years = Math.Floor(totalDays / 365);
                    var months = Math.Floor((totalDays - years * 365) / 30);
                    var days = Math.Floor(totalDays - years * 365 - months * 30);

                    workexperienceDisplTxt.Text = $"Лет: {years}, месяцев: {months}, дней: {days}";
                }
                else
                {
                    workexperienceDisplTxt.Clear();
                }
            }
            catch (Exception ex)
            {
                workexperienceDisplTxt.Clear();
                MessageBox.Show(ex.ToString());
            }

        }

        private void exportToWordBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmplGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Список сотрудников пуст");
                    return;
                }

                if (exportToWordFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var path = exportToWordFileDialog.FileName;
                    var employeeGVselectedRow = EmplGridView1.SelectedRows[0];
                    var fio = $"{employeeGVselectedRow.Cells[lastNameColumnIdx].Value} {employeeGVselectedRow.Cells[firstNameColumnIdx].Value} {employeeGVselectedRow.Cells[patronimicColumnIdx].Value}";
                    var bmList = new List<BookMark>
                    {

                        new BookMark
                        {
                            BookMarkType = BookMarkType.Text,
                            BookMarkName = "FIO",
                            BookMarkValue = fio
                        },
                         new BookMark
                        {
                            BookMarkType = BookMarkType.Text,
                            BookMarkName = "CITIZENSHIP",
                            BookMarkValue = CitizenTxt.Text
                        },
                          new BookMark
                        {
                            BookMarkType = BookMarkType.Text,
                            BookMarkName = "DATE",
                            BookMarkValue = BithTxt.Text
                        },
                           new BookMark
                        {
                            BookMarkType = BookMarkType.Text,
                            BookMarkName = "AGE",
                            BookMarkValue = Agetxt.Text
                        },
                            new BookMark
                        {
                            BookMarkType = BookMarkType.Text,
                            BookMarkName = "POST",
                            BookMarkValue = Posttxt.Text
                        },
                             new BookMark
                        {
                            BookMarkType = BookMarkType.Text,
                            BookMarkName = "OTDEL",
                            BookMarkValue = departmentCB.Text
                        },
                              new BookMark
                        {
                            BookMarkType = BookMarkType.Text,
                            BookMarkName = "WORHYEARS",
                            BookMarkValue = workexperienceDisplTxt.Text
                        },
                               new BookMark
                        {
                            BookMarkType = BookMarkType.Text,
                            BookMarkName = "ADRESS",
                            BookMarkValue = AdressTxt.Text
                        },
                               new BookMark
                        {
                            BookMarkType = BookMarkType.Text,
                            BookMarkName = "EDUCATION",
                            BookMarkValue = edacationtxt.Text
                        }
                    };

                    new DocumentManager(templatePath, bmList).saveDocument(path);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void exportDBToExcel_Click(object sender, EventArgs e)
        {

            try
            {
                if (exportToExcelFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = exportToExcelFileDialog.FileName;
                    new ExcelExportManager().ExportDataSet(gymDataSet, filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void exportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (exportToExcelFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = exportToExcelFileDialog.FileName;

                    var departmentId = 0;
                    int.TryParse(departmentCB.SelectedValue.ToString(), out departmentId);

                    var exportTableAdapter = new ExportToExcelTableAdapter();
                    exportTableAdapter.Fill(exportToExcelDataSet.Сотрудники, departmentId);

                    new ExcelExportManager().ExportDataSet(exportToExcelDataSet, filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void imegeNameHidenField_TextChanged(object sender, EventArgs e)
        {
          
            {
                try
                {
                var currentAssemblyPath = Assembly.GetEntryAssembly().Location;
                var currentFolder = Path.GetDirectoryName(currentAssemblyPath);
                 var imageName = ((TextBox)sender).Text;
                    photoPictureBox_2.ImageLocation = !string.IsNullOrEmpty(imageName) ? $"{currentFolder}\\ImgData\\{imageName}" : null;
                 }
                   catch (Exception ex)
                     {
                            MessageBox.Show(ex.ToString());
                         }
                
                 }
                }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
        }

