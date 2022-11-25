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
        
        public QuestionOuverte(int id,int id_E, int num,String text) : base(id,id_E, num,"Ouverte" , text)
        {

        }
        //method to answer the question
    
}}
