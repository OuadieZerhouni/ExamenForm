using System.Data;


namespace ExamenForm
{
    public partial class Form1 : Form
    {
        private Examen Exm;


        public Form1()
        {
            InitializeComponent();
            loadInitial();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void selectCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectCombo.Text != "")
            {
                int Qnum = Convert.ToInt32(selectCombo.Text);
                Question q = Exm.getQuestionByNum(Qnum);
                textBox1.Visible = true;
                textBox1.Text = q.GetQ_num().ToString();
                textBox2.Visible = true;
                textBox2.Text = q.GetQ_text();
                modifybtn.Visible = true;
                deletebtn.Visible = true;
                label1.Visible = true;
                label1.Text = "Num de Question:";
                label2.Visible = true;
                label2.Text = "Ennonce de Question:";
            }
            else
            {
                LoadQuestionInitial();
            }

        }

        private void Question_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (titleLabel.Text == "Créer Exam")
            {
                Exm = new Examen(textBox2.Text, textBox1.Text);

                LoadQuestionInitial();

            }
            else if (titleLabel.Text == "Questions")
            {
                ChoixDeType();

            }


        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (titleLabel.Text == "Questions")
            {
                int Qnum = Convert.ToInt32(selectCombo.Text);
                Exm.deleteQuestion(Qnum);
                LoadQuestionInitial();
            }
            // else if (titleLabel.Text == "Propositions")
            // {
            //     int Pnum = Convert.ToInt32(selectCombo.Text);
            //     Exm.deleteProposition(Pnum);
            //     LoadPropositionInitial();
            // }

        }

        private void modifybtn_Click(object sender, EventArgs e)
        {
            int Qnum = Convert.ToInt32(textBox1.Text);
            Question q = Exm.getQuestionByNum(Qnum);
            String type = q.GetQ_type();
            if (type == "QCM")
            {
                q.SetQ_text(textBox2.Text);
                QuestionQcm q1 = (QuestionQcm)q;
                LoadAddProp(q1.GetNbrProp(), Qnum);
                titleLabel.Text = "modifier Propostion";
                textBox1.Text = q1.getPropositionText(1);
                textBox2.Text = q1.getPropositionText(2);
                if (q1.GetNbrProp() == 3)
                {
                    textBox3.Text = q1.getPropositionText(3);
                }
                else if (q1.GetNbrProp() == 4)
                {
                    textBox3.Text = q1.getPropositionText(3);
                    textBox4.Text = q1.getPropositionText(4);
                }


            }
            else if (type == "Ouverte")
            {
                q.SetQ_text(textBox2.Text);
            }

        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            LoadQuestionInitial();

        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            if (titleLabel.Text == "Type de question")
            {
                if (Question_type.Text == "QCM")
                {
                    LaodAddQCM();

                }
                else
                {
                    LoadAddOueverte();

                }


            }
            else if (titleLabel.Text == "Ajouter QCM")
            {
                int Qnum = Convert.ToInt32(textBox1.Text);
                if (Exm.QuestionExists(Qnum))
                {
                    MessageBox.Show("Question existe deja");
                    LaodAddQCM();
                }
                else
                {
                    int id_Q = new Random().Next(0000, 9999);
                    Exm.addQuestion(id_Q, Qnum, "QCM", textBox2.Text);
                    LoadAddProp(int.Parse(textBox3.Text), Qnum);
                }

            }
            else if (titleLabel.Text == "Ajouter Prop")
            {
                int Qnum = Convert.ToInt32(SelectLabel.Text);
                QuestionQcm q = (QuestionQcm)Exm.getQuestionByNum(Qnum);
                int id_Q = q.Getid_Q();

                int id_P = new Random().Next(0000, 9999);
                q.addProposition(id_P, textBox1.Text, 1);
                id_P = new Random().Next(0000, 9999);
                q.addProposition(id_P, textBox2.Text, 2);
                if (textBox3.Visible)
                {
                    id_P = new Random().Next(0000, 9999);
                    q.addProposition(id_P, textBox3.Text, 3);
                }
                if (textBox4.Visible)
                {
                    id_P = new Random().Next(0000, 9999);
                    q.addProposition(id_P, textBox4.Text, 4);
                }

                LoadQuestionInitial();
            }
            else if (titleLabel.Text == "modifier Propostion")
            {
                int Qnum = Convert.ToInt32(SelectLabel.Text);
                QuestionQcm q = (QuestionQcm)Exm.getQuestionByNum(Qnum);
                q.setPropositionText(1, textBox1.Text);
                q.setPropositionText(2, textBox2.Text);
                if (textBox3.Visible)
                {
                    q.setPropositionText(3, textBox3.Text);
                }
                if (textBox4.Visible)
                {
                    q.setPropositionText(4, textBox4.Text);
                }
                
                LoadQuestionInitial();
            }
            else if (titleLabel.Text == "Ajouter Question Oueverte")
            {
                int Qnum = Convert.ToInt32(textBox1.Text);
                if (Exm.QuestionExists(Qnum))
                {
                    MessageBox.Show("Question existe deja");
                    LoadAddOueverte();
                }
                else
                {
                    int id_Q = new Random().Next(0000, 9999);
                    Exm.addQuestion(id_Q, Qnum, "Ouverte", textBox2.Text);
                    LoadQuestionInitial();
                }
            }


        }
        private void loadInitial()
        {
            titleLabel.Visible = true;
            titleLabel.Text = "Créer Exam";
            selectCombo.Visible = false;
            SelectLabel.Visible = false;
            Question_type.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = false;
            Addbtn.Visible = true;
            deletebtn.Visible = false;
            modifybtn.Visible = false;
            Cancelbtn.Visible = false;
            confirmbtn.Visible = false;
            qTypeLabel.Visible = false;
            label1.Text = "Theme";
            label2.Text = "date";
            label3.Text = "";
            label4.Text = "";
        }
        private void LoadQuestionInitial()
        {
            titleLabel.Visible = true;
            titleLabel.Text = "Questions";
            selectCombo.Visible = true;
            Fill_Q(selectCombo);
            Question_type.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            Addbtn.Visible = true;
            deletebtn.Visible = false;
            modifybtn.Visible = false;
            Cancelbtn.Visible = false;
            confirmbtn.Visible = false;
            SelectLabel.Visible = false;
            qTypeLabel.Visible = false;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
        }
        public void ChoixDeType()
        {
            titleLabel.Visible = true;
            titleLabel.Text = "Type de question";
            selectCombo.Visible = false;
            Question_type.Visible = true;
            Fill_type(Question_type);
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            Addbtn.Visible = false;
            deletebtn.Visible = false;
            modifybtn.Visible = false;
            Cancelbtn.Visible = true;
            confirmbtn.Visible = true;
            qTypeLabel.Visible = true;
            qTypeLabel.Text = "Type de question";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
        }


        public void LaodAddQCM()
        {
            titleLabel.Visible = true;
            titleLabel.Text = "Ajouter QCM";
            selectCombo.Visible = false;
            SelectLabel.Visible = false;
            Question_type.Visible = false;
            textBox1.Visible = true;
            textBox1.Text = "";
            textBox2.Visible = true;
            textBox2.Text = "";
            textBox3.Visible = true;
            textBox4.Visible = false;
            Addbtn.Visible = false;
            deletebtn.Visible = false;
            modifybtn.Visible = false;
            Cancelbtn.Visible = true;
            confirmbtn.Visible = true;
            qTypeLabel.Visible = true;
            qTypeLabel.Text = "QCM";
            label1.Text = "Num de Question:";
            label2.Text = "Enoncé:";
            label3.Text = "Nbre de Prop (2-4):";
            label4.Text = "";
        }
        private void LoadAddProp(int i, int Qnum)
        {
            selectCombo.Visible = false;
            titleLabel.Visible = true;
            titleLabel.Text = "Ajouter Prop";
            SelectLabel.Visible = true;
            SelectLabel.Text = Qnum.ToString();
            label1.Text = "P-1";
            label2.Text = "P-2";
            label3.Text = "";
            label4.Text = "";
            modifybtn.Visible = false;
            deletebtn.Visible = false;
            Addbtn.Visible = false;
            Cancelbtn.Visible = true;
            confirmbtn.Visible = true;
            if (i == 2)
            {
                textBox3.Visible = false;
                textBox4.Visible = false;
            }
            else if (i == 3)
            {
                label3.Text = "P-3";
                textBox3.Visible = true;
                textBox4.Visible = false;
            }
            else if (i == 4)
            {
                label3.Text = "P-3";
                label4.Text = "P-4";
                textBox3.Visible = true;
                textBox4.Visible = true;
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";


            






        }
        //LoadAddOueverte
        public void LoadAddOueverte()
        {
            titleLabel.Visible = true;
            titleLabel.Text = "Ajouter Question Oueverte";
            selectCombo.Visible = false;
            SelectLabel.Visible = false;
            Question_type.Visible = false;
            textBox1.Visible = true;
            textBox1.Text = "";
            textBox2.Visible = true;
            textBox2.Text = "";
            textBox3.Visible = false;
            textBox4.Visible = false;
            Addbtn.Visible = false;
            deletebtn.Visible = false;
            modifybtn.Visible = false;
            Cancelbtn.Visible = true;
            confirmbtn.Visible = true;
            qTypeLabel.Visible = true;
            qTypeLabel.Text = "Question Oueverte";
            label1.Text = "Num de Question:";
            label2.Text = "Enoncé:";
            label3.Text = "";
            label4.Text = "";
        }




        private void Fill_Q(ComboBox combo)
        {
            combo.Items.Clear();
            List<int> numbers = Exm.getQuestionNumbers();
            foreach (int num in numbers)
            {
                combo.Items.Add(num);
            }
        }
        private void Fill_type(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add("QCM");
            combo.Items.Add("Ouverte");
        }

        

        private void Select_Q_Click(object sender, EventArgs e)
        {
            DataTable dt = mdb.GetQuestions(Exm.Getid_E());
            dataGrid.DataSource = dt;
                


        }

        private void Select_P_Click(object sender, EventArgs e)
        {
            DataTable dt = mdb.GetPropositions(Exm.Getid_E());
            dataGrid.DataSource = dt;

        }
        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}