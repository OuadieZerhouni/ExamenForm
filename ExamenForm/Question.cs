using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenForm
{
    public abstract class Question
    {

        private int id_E;
        private String Q_type;
        private String Q_text;
        private int NumQuestion;

        public Question(int id , int num,String type, String text)
        {
            id_E = id;
            Q_type = type;
            Q_text = text;
            NumQuestion = num;

        }

        public void Setid_E(int Id)
        {
            this.id_E = Id;
        }
        public int Getid_E()
        {
            return this.id_E;
        }
        public void SetQ_text(String Ennonce)
        {
            this.Q_text = Ennonce;
        }
        public String GetQ_text()
        {
            return this.Q_text;
        }
        public void SetNumQuestion(int NumQuestion)
        {
            this.NumQuestion = NumQuestion;
        }
        public int GetNumQuestion()
        {
            return this.NumQuestion;
        }
        public void SetQ_type(String Q_type)
        {
            this.Q_type = Q_type;
        }
        public String GetQ_type()
        {
            return this.Q_type;
        }
    }
}
