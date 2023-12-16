using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCard
{
    /// <summary>
    /// Класс констант
    /// </summary>
    public static class Constants
    {
        public static object FieldsNames { get; internal set; }

        /// <summary>
        /// Имена таблиц
        /// </summary>
        public static class TableNames
        {
            /// <summary>
            /// Отделы
            /// </summary>
            public const string DepartmentsTableName = "Departments";
            /// <summary>
            /// Сотрудники
            /// </summary>
            public const string EmployeesTableName = "Employees";
            /// <summary>
            /// Персональные данные
            /// </summary>
            public const string EmplPersonalDateTableName = "EmplPersonalDate";
            /// <summary>
            /// Рабочие данные
            /// </summary>
            public const string EmplWorkDateTableName = "EmplWorkDate";
        }
        public static class FieldsNemes
        {
            public const string Id = "Id";
            public static class DepartmentsTable
            {
                public const string Title = "Title";
            }
            public static class EmployeesTable
            {
                public const string DepartmentId = "DepartmentId";
                public const string LastName = "LastName";
                public const string FirstName = "FirstName";
                public const string MidleName = "MidleName";
            }
            public static class EmplPersonalDateTable
            {
                public const string EmployeId = "EmployeId";
                public const string Age = "Age";
                public const string BirthDate = "BirthDate";
                public const string CitizenShip = "CitizenShip";
                public const string Addres = "Addres";
                public const string PhotoFileName = "PhotoFileName";
            }
            public static class EmplWorkDateTable
            {
                public const string EmployeeId = "EmployeeId";
                public const string Post = "Post";
                public const string Education = "Education";
                public const string WorkExperience = "WorkExperience";
                public const string WorkCard = "WorkCard";

            }
        }
    }
}
