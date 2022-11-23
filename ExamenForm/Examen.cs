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
        public void addQuestion(Question q)
        {
            questions.Add(q);
            mdb.AddQuestion(q.Getid_E(),id, q.GetNumQuestion(), q.GetQ_type(), q.GetQ_text());
        }
    }
}
