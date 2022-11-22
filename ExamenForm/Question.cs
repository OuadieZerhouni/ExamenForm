using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenForm
{
    public abstract class Question
    {
        public void RepondreQuestion()
        {
            // TODO: implement
        }

        private int IdExamen;
        private String QuestionType;
        private String EnnonceQuestion;
        private int NumQuestion;

        public Question(int IdExamen, String EnnonceQuestion, int NumQuestion)
        {
            SetNumQuestion(NumQuestion);
            SetIdExamen(IdExamen);
            SetEcconceQuestion(EnnonceQuestion);

        }

        public void SetIdExamen(int Id)
        {
            this.IdExamen = Id;
        }
        public int GetIdExamen()
        {
            return this.IdExamen;
        }
        public void SetEcconceQuestion(String Ennonce)
        {
            this.EnnonceQuestion = Ennonce;
        }
        public String GetEcconceQuestion()
        {
            return this.EnnonceQuestion;
        }
        public void SetNumQuestion(int NumQuestion)
        {
            this.NumQuestion = NumQuestion;
        }
        public int GetNumQuestion()
        {
            return this.NumQuestion;
        }
    }
}
