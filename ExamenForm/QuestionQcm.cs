using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenForm
{
    internal class QuestionQcm : Question
    {


        private List<Proposition> propositions;

        public QuestionQcm(int id,int id_E, String text, int num) : base(id,id_E, num, "Qcm", text)
        {
            propositions = new List<Proposition>();
        }
        public void addProposition(int id , String text, int num)
        {
            propositions.Add(new Proposition(id,base.Getid_Q(), text, num));
        }
        //modify propositions
        public void modifyProposition(int id, String text, int num)
        {
            propositions.Find(x => x.Getid_Q() == id).SetP_text(text);
            propositions.Find(x => x.Getid_Q() == id).SetP_num(num);
        }
        

    
    }
}
