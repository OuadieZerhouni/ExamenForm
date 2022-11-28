using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenForm
{
    internal class Proposition
    {
        private int id_P;
        private int id_Q;
        private String P_text;
        private int P_num;

        public Proposition(int id_P,int id_Q, String text, int num)
        {
            this.id_P = id_P;
            this.id_Q = id_Q;
            this.P_text = text;
            this.P_num = num;
            mdb.AddProposition(id_P,id_Q, num, text);
        }
        public void Setid_Q(int Id)
        {
            this.id_Q = Id;
        }
                public int Getid_Q()
        {
            return this.id_Q;
        }
        public void SetP_text(String Ennonce)
        {
            this.P_text = Ennonce;
            
        }
        public String GetP_text()
        {
            return this.P_text;
        }
        public void SetP_num(int P_num)
        {
            this.P_num = P_num;
        }
        public int GetP_num()
        {
            return this.P_num;
        }    
        //delete from db
        public void deleteProposition(int id)
        {
            mdb.DeleteProposition(id);
        }
    }
}
