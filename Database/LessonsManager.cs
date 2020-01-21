using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfHarris78.Database
{
    public class Lesson
    {
        public int Id = 0;
        public string Name = "";
        public byte[] Description = null;

        public static Lesson ParseFromDataRow(DataRow row)
        {
            return new Lesson { 
                Id = (int)row["Id"],
                Name = (string)row["Name"],
                Description = (byte[])row["Description"]
            };
        }
    }
    public class LessonsManager
    {
        public static void CreateLesson(Lesson lesson)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Lessons(Name, Description) VALUES (@name, @description); SET @id=SCOPE_IDENTITY();");
            command.Parameters.AddWithValue("@name", lesson.Name);
            command.Parameters.AddWithValue("@description", lesson.Description);

            SqlParameter idParam = command.Parameters.Add("@id", SqlDbType.Int);
            idParam.Direction = ParameterDirection.Output;
            DBManager.executeNonSqlCommand(command);

            lesson.Id = Convert.ToInt32(idParam.Value);
        }

        public static List<Lesson> GetLessons()
        {
            List<Lesson> lessons = new List<Lesson>();
            var ds = DBManager.executeSqlQuery("SELECT * FROM Lessons");

            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataRow row in dt.Rows)
                {
                    lessons.Add(Lesson.ParseFromDataRow(row));
                }
            }

            return lessons;
        }
    }
}
