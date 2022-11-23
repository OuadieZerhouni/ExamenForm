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

        public QuestionQcm(int id, String text, int num) : base(id, num, "Qcm", text)
        {
            propositions = new List<Proposition>();
        }

    
    }
}
