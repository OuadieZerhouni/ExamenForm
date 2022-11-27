using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenForm
{
    public abstract class Question
    {


        protected int id_Q;
        protected String Q_type;
        protected String Q_text;
        protected int Q_num;

        public Question()
        {
            
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
        
        public void deleteQuestion()
        {
            mdb.DeleteQuestion(id_Q);
        }
    }
}
