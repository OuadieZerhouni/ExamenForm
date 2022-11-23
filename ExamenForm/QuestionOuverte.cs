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
        
        public QuestionOuverte(int id,String text, int num) : base(id, num,"Ouverte" , text)
        {

        }
        //method to answer the question
    
}}
