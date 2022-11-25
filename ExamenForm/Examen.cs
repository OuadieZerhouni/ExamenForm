using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenForm
{
    internal class Examen
    {
        int id;
        String theme;
        String date;
        List<Question> questions;
        public Examen(int id, String date, String theme)
        {
            this.id = id;
            this.date = date;
            this.theme = theme;
            questions = new List<Question>();
            mdb.AddExam(id, date, theme);
        }
        //setexam to modify exam 
        public void setExam(int id, String date, String theme)
        {
            this.id = id;
            this.date = date;
            this.theme = theme;
            mdb.ModifyExam(id, date, theme);
        }
        public void addQuestion(int id ,int id_E, int num,String type, String text)
        {
            if(type == "Qcm")
            {
                questions.Add(new QuestionQcm(id,id_E, num, text));
            }
            
        }   
        //getQuestionNumbers
        public List<int> getQuestionNumbers()
        {
            List<int> numbers = new List<int>();
            foreach (Question q in questions)
            {
                numbers.Add(q.GetQ_num());
            }
            return numbers;
        }
    }
}
