﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenForm
{
    internal class QuestionQcm : Question
    {


        private List<Proposition> propositions;

        public QuestionQcm(int id,int id_E, int num, String text) : base(id,id_E, num, "Qcm", text)
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
        public void deleteProposition(int id)
        {
            propositions.Find(x => x.Getid_Q() == id).deleteProposition(id);
            propositions.Remove(propositions.Find(x => x.Getid_Q() == id));
        }
        public List<Proposition> getPropositions()
        {
            return propositions;
        }
        
        public String getPropositionText(int Num)
        {
            return propositions.Find(x => x.Getid_Q() == Num).GetP_text();
        }
        public int GetNumProp()
        {
            return propositions.Count;
        }     
        public void setPropositionText(int num, String text)
        {
            propositions.Find(x => x.GetP_num() == num).SetP_text(text);
        }
        

    
    }
}
