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
        public Examen( String date, String theme)
        {
            this.id = new Random().Next(1, 1000);
            this.date = date;
            this.theme = theme;
            questions = new List<Question>();
            mdb.AddExam(id, date, theme);
        }
        //setexam to modify exam 
        public void setExam(int id, String date, String theme)
        {
            this.date = date;
            this.theme = theme;
            mdb.ModifyExam(id, date, theme);
        }
        public void addQuestion(int id_Q , int num,String type, String text)
        {
            if(type == "QCM")
            {   QuestionQcm q = new QuestionQcm(id_Q, this.id, num, text);
                questions.Add(q);
            }
            else if(type=="Ouverte")
            {
                QuestionOuverte q = new QuestionOuverte(id_Q, this.id, num, text);
                questions.Add(q);
            }
            
            
        }   
        public List<int> getQuestionNumbers()
        {
            List<int> numbers = new List<int>();
            foreach (Question q in questions)
            {
                numbers.Add(q.GetQ_num());
            }
            return numbers;
        }
        public Question getQuestionByNum(int num)
        {
            foreach (Question q in questions)
            {
                if (q.GetQ_num() == num)
                    return (Question)q;
            }
            return null;
        }
        public int Getid_E()
        {
            return id;
        }
        //deletquestion 
        public void deleteQuestion(int id)
        {
            
            mdb.DeleteQuestion(id);
            foreach (Question q in questions)
            {
                if (q.Getid_Q() == id)
                {
                    questions.Remove(q);
                    break;
                }
            }
        }
        //QuestionExists
        public bool QuestionExists(int num)
        {
            foreach (Question q in questions)
            {
                if (q.GetQ_num() == num)
                    return true;
            }
            return false;
        }
       
    }
}
