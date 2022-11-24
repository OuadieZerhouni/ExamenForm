using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenForm
{
    public abstract class Question
    {

        private int id_Q;
        private String Q_type;
        private String Q_text;
        private int Q_num;

        public Question(int id ,int id_E, int num,String type, String text)
        {
            id_Q = id;
            Q_type = type;
            Q_text = text;
            Q_num = num;
            mdb.AddQuestion(id, id_E, num, type, text);

        }

        public void Setid_Q(int Id)
        {
            this.id_Q = Id;
        }
        public int Getid_Q()
        {
            return this.id_Q;
        }
        public void SetQ_text(String Ennonce)
        {
            this.Q_text = Ennonce;
        }
        public String GetQ_text()
        {
            return this.Q_text;
        }
        public void SetQ_num(int Q_num)
        {
            this.Q_num = Q_num;
        }
        public int GetQ_num()
        {
            return this.Q_num;
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
