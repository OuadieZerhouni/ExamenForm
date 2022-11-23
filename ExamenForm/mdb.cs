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
        static string chaine = @"Data Source=localhost;Initial Catalog=BDGED_copy;Integrated Security=True";
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
            cmd.CommandText = "insert into Exam values(" + id + ",'" + date + "','" + theme + "')";
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public static void AddQuestion(int id_Q, int id_E, int num_Q, string type_Q, string text_Q)
        {
            cmd.Connection = cnx;
            cmd.CommandText = "insert into Question values(" + id_Q + "," + id_E + "," + num_Q + ",'" + type_Q + "','" + text_Q + "')";
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public static void AddProposition(int id_P, int id_Q, int num_P, string text_P)
        {
            cmd.Connection = cnx;
            cmd.CommandText = "insert into Proposition values(" + id_P + "," + id_Q + "," + num_P + ",'" + text_P + "')";
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public static void ModifyExam(int id, string date, string theme)
        {
            cmd.Connection = cnx;
            cmd.CommandText = "update Exam set date_E='" + date + "',theme='" + theme + "' where id_E=" + id;
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public static void ModifyQuestion(int id_Q, int id_E, int num_Q, string type_Q, string text_Q)
        {
            cmd.Connection = cnx;
            cmd.CommandText = "update Question set id_E=" + id_E + ",num_Q=" + num_Q + ",type_Q='" + type_Q + "',text_Q='" + text_Q + "' where id_Q=" + id_Q;
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public static void ModifyProposition(int id_P, int id_Q, int num_P, string text_P)
        {
            cmd.Connection = cnx;
            cmd.CommandText = "update Proposition set id_Q=" + id_Q + ",num_P=" + num_P + ",text_P='" + text_P + "' where id_P=" + id_P;
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        public static String GetTypeQuestion(int id_Q){
            cmd.Connection = cnx;
            cmd.CommandText = "select type_Q from Question where id_Q=" + id_Q;
            cnx.Open();
            String type = cmd.ExecuteScalar().ToString();
            cnx.Close();
            return type;

        }
        public static void DeleteProposition(int id_P)
        {
            cmd.Connection = cnx;
            cmd.CommandText = "delete from Proposition where id_P=" + id_P;
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public static void DeleteQuestion(int id_Q)
        {
            cmd.Connection = cnx;
            cmd.CommandText = "delete from Question where id_Q=" + id_Q;
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
            if (GetTypeQuestion(id_Q) == "Qcm")
            {
                cmd.Connection = cnx;
                cmd.CommandText = "delete from Proposition where id_Q=" + id_Q;
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
            }
        }

        public static void DeleteExam(int id)
        {
            cmd.Connection = cnx;
            cmd.CommandText = "delete from Exam where id_E=" + id;
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        


    }
}
