using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenForm
{
    //class QuestionOuverte that inherits from Question
    public class QuestionOuverte : Question
    {
        
        public QuestionOuverte(int id,int id_E, int num,String text) : base()
        {
            this.id_Q = id;
            this.Q_num = num;
            this.Q_text = text;
            this.Q_type = "Ouverte";
            mdb.AddQuestion(id_Q, id_E, Q_num, Q_type, Q_text);

        }
        public void modifyQuestion(int id,int id_E, int num, String text)
        {
            this.id_Q = id;
            this.Q_num = num;
            this.Q_text = text;
            mdb.ModifyQuestion(id_Q,id_E, Q_num, Q_type, Q_text);
        }    
}}
