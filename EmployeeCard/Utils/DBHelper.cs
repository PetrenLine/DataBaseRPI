using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace EmployeeCard.Utils
{
    public enum TableFieldTypes
    {
        integer,
        nvarchar,
    }
    public class TableField
    {
        public string TableFieldValue { get;  set; }
        public TableFieldTypes TableFieldType { get; set; }
    }
   public static class DBHelper
    {
        public static List <string> SelectValuesFromTable(string tableName, int Id)
        {

            var result = new List<string>();
            try
            {
                var conn = new SqlConnection(Properties.Settings.Default.GymDBConnectionString);
                var query = $"SELECT * FROM {tableName} WHERE Id = {Id}";
                var cmd = new SqlCommand(query, conn);
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Clear();
                    for (var i = 0; i < reader.FieldCount; i++)
                    {
                        result.Add(reader[i].ToString());

                    }

                }
            }
            catch
            {  
            }
            return result;
        }

        public static bool InsertEntry(string tableName, Dictionary<string, TableField > fields )
        {
            try
            {
                var conn = new SqlConnection(Properties.Settings.Default.GymDBConnectionString);


                var fieldsNames = string.Join(",", fields.Select(f => f.Key));
                var fieldsValues = string.Join(",", fields.Select(f =>
                 {
                     if (f.Value.TableFieldType == TableFieldTypes.integer)
                     {
                         return f.Value.TableFieldValue;
                     }
                     return $"'{f.Value.TableFieldValue}'";
                 }));

                var query = $"INSERT INTO {tableName} ({fieldsNames}) VALUES ({fieldsValues})";
                var cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }

            catch
            {
                return false;
            }

        }
        public static bool UpdateEntry(string tableName, int id, Dictionary<string, TableField> fields)
        {
            try
            { var conn = new SqlConnection(Properties.Settings.Default.GymDBConnectionString);

            var updatingFieldsValues = string.Join(",", fields.Select(f =>
            {
                var fieldValue = string.Empty;
                if (f.Value.TableFieldType == TableFieldTypes.integer)
                {
                    fieldValue = f.Value.TableFieldValue;
                }
                else
                {
                    fieldValue = $"'{f.Value.TableFieldValue}'";
                }
                return $"{f.Key}={fieldValue}";
            }));

            var query = $"UPDATE{tableName} SET {updatingFieldsValues} WHERE Id={id}";
            var cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            return true;
            }
            catch 
            {
                return false;
            }
        }
        public static bool DeleteEntry(string tableName, int id)
        {
            try
            {
                var conn = new SqlConnection(Properties.Settings.Default.GymDBConnectionString);
                var query = $"DELTE FROM {tableName} WHERE Id ={id}";
                var cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                
                return false;
            }
        }
    }

}
