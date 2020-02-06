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
                Description = row["Description"] != DBNull.Value ? (byte[])row["Description"] : null
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

    public class LessonParametersManager
    {
        public static void CreateLesson(int lesson_id, Protobuf.Wrappers.LessonParametersWrapper lessonParameters)
        {
            SqlCommand command = new SqlCommand("INSERT INTO LessonCheckParameters(Lesson_id, ParametersJson) VALUES (@lesson_id, @parameters);");
            command.Parameters.AddWithValue("@lesson_id", lesson_id);
            command.Parameters.AddWithValue("@parameters", lessonParameters.ToJsonFormat());

            DBManager.executeNonSqlCommand(command);
        }

        public static string GetParametersLessonJson(int lesson_id)
        {
            SqlCommand command = new SqlCommand("SELECT ParametersJson FROM LessonCheckParameters WHERE Lesson_id = @lesson_id;");
            command.Parameters.AddWithValue("@lesson_id", lesson_id);

            var ds = DBManager.executeSqlQuery(command);

            return ds.Tables[0].Rows[0][0] as string;
        }

        public static LessonParametersSet.LessonParameters GetParametersLesson(int lesson_id)
        {
            string jsonParams = GetParametersLessonJson(lesson_id);

            Google.Protobuf.JsonParser jsonParser = new Google.Protobuf.JsonParser(new Google.Protobuf.JsonParser.Settings(1000));
            return jsonParser.Parse<LessonParametersSet.LessonParameters>(jsonParams);
        }
    }
}
