using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExamenForm
{
    internal class mdb
    {
        static string chaine = @"Data Source=localhost;Initial Catalog=Exams;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);                  

        public static DataTable GetTable(string sql)
        {
            DataTable dt = new DataTable();
            cmd.Connection = cnx;
            cmd.CommandText = sql;
            adapter.Fill(dt);
            return dt;
        }

        public static void AddExam(int id ,string date, string theme)
        {
            cmd.Connection = cnx;
            cmd.Parameters.Clear();
            cmd.CommandText = "insert into Exam values(@id,@date,@theme)";
            cnx.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@theme", theme);
            cmd.ExecuteNonQuery();
            cnx.Close();
            
        }
        public static void AddQuestion(int id_Q, int id_E, int num_Q, string type_Q, string text_Q)
        {
            cmd.Connection = cnx;
            cmd.Parameters.Clear();
            cmd.CommandText = "insert into Question values(@id_Q,@id_E,@num_Q,@type_Q,@text_Q);";
            cnx.Open();
            cmd.Parameters.AddWithValue("@id_Q", id_Q);
            cmd.Parameters.AddWithValue("@id_E", id_E);
            cmd.Parameters.AddWithValue("@num_Q", num_Q);
            cmd.Parameters.AddWithValue("@type_Q", type_Q);
            cmd.Parameters.AddWithValue("@text_Q", text_Q);
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public static void AddProposition(int id_P, int id_Q, int num_P, string text_P)
        {
            cmd.Connection = cnx;
            cmd.Parameters.Clear();
            cmd.CommandText = "insert into Proposition values(@id_P,@id_Q,@num_P,@text_P);";
            cnx.Open();
            cmd.Parameters.AddWithValue("@id_P", id_P);
            cmd.Parameters.AddWithValue("@id_Q", id_Q);
            cmd.Parameters.AddWithValue("@num_P", num_P);
            cmd.Parameters.AddWithValue("@text_P", text_P);

            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public static void ModifyExam(int id, string date, string theme)
        {
            cmd.Connection = cnx;
            cmd.Parameters.Clear();
            cmd.CommandText = "update Exam set date_E=@date,theme_E=@theme where id_E=@id";
            cnx.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@theme", theme);
            
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public static void ModifyQuestion(int id_Q, int id_E, int num_Q, string type_Q, string text_Q)
        {
            cmd.Connection = cnx;
            cmd.Parameters.Clear();
            cmd.CommandText = "update Question set id_E=@id_E,num_Q=@num_Q,type_Q=@type_Q,text_Q=@text_Q where id_Q=@id_Q";
            cnx.Open();
            cmd.Parameters.AddWithValue("@id_Q", id_Q);
            cmd.Parameters.AddWithValue("@id_E", id_E);
            cmd.Parameters.AddWithValue("@num_Q", num_Q);
            cmd.Parameters.AddWithValue("@type_Q", type_Q);
            cmd.Parameters.AddWithValue("@text_Q", text_Q);
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public static void ModifyProposition(int id_P, int id_Q, int num_P, string text_P)
        {
            cmd.Connection = cnx;
            cmd.Parameters.Clear();
            cmd.CommandText = "update Proposition set id_Q=@id_Q,num_P=@num_P,text_P=@text_P where id_P=@id_P";
            cnx.Open();
            cmd.Parameters.AddWithValue("@id_P", id_P);
            cmd.Parameters.AddWithValue("@id_Q", id_Q);
            cmd.Parameters.AddWithValue("@num_P", num_P);
            cmd.Parameters.AddWithValue("@text_P", text_P);
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        public static String GetTypeQuestion(int id_Q){
            cmd.Connection = cnx;
            cmd.Parameters.Clear();
            cmd.CommandText = "select type_Q from Question where id_Q=@id_Q";
            cnx.Open();
            cmd.Parameters.AddWithValue("@id_Q", id_Q);
            var type = cmd.ExecuteScalar();
            if (type != null)
            {
                return type.ToString();
            }
            else
            {
                return null;
            }
            

        }
        public static void DeleteProposition(int id_P)
        {
            cmd.Connection = cnx;
            cmd.Parameters.Clear();
            cmd.CommandText = "delete from Proposition where id_P=@id_P";
            cnx.Open();
            cmd.Parameters.AddWithValue("@id_P", id_P);
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public static void DeleteQuestion(int Q_num)
        {   int id_Q = GetQ_id(Q_num);
            if (GetTypeQuestion(id_Q) == "Qcm")
            {
                cmd.Connection = cnx;
                cmd.Parameters.Clear();
                cmd.CommandText = "delete from Proposition where id_Q=@id_Q";
                cnx.Open();
                cmd.Parameters.AddWithValue("@id_Q", id_Q);
                cmd.ExecuteNonQuery();

                cnx.Close();
            }
            cmd.Connection = cnx;
            cmd.Parameters.Clear();
            cmd.CommandText = "delete from Question where id_Q=@id_Q";
            cnx.Open();
            cmd.Parameters.AddWithValue("@id_Q", id_Q);
            cmd.ExecuteNonQuery();
            cnx.Close();
            
        }

        public static void DeleteExam(int id)
        {
            cmd.Connection = cnx;
            cmd.Parameters.Clear();
            cmd.CommandText = "delete from Exam where id_E=@id";
            cnx.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        
        public static int GetQ_id(int num)
        {
            cmd.Connection = cnx;
            cmd.Parameters.Clear();
            cmd.CommandText = "select id_Q from Question where num_Q=@num";
            cnx.Open();
            cmd.Parameters.AddWithValue("@num", num);
            var id = cmd.ExecuteScalar();
            if (id != null)
            {
                return int.Parse(id.ToString());
            }
            else
            {
                return 0;
            }
        }
        


    }
}
