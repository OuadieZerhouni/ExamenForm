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
            if(titleLabel.Text == "Créer Exam")
            {
                Exm= new Examen(1, textBox2.Text, textBox1.Text);
                LoadQuestionInitial();

            }
            else if(titleLabel.Text == "Questions")
            {
                ChoixDeType();
                
            }
            

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

        }

        private void modifybtn_Click(object sender, EventArgs e)
        {

        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            LoadQuestionInitial();

        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            if(titleLabel.Text== "Type de question")
            {
                if(Question_type.Text == "QCM")
                {
                    LaodAddQCM();
                    
                }
                
                
            }
            else if(titleLabel.Text == "Ajouter QCM")
            {
                int Qnum=int.Parse(textBox1.Text);
                int id_Q = new Random().Next(0000, 9999);
                Exm.addQuestion(id_Q,Qnum,"QCM",textBox2.Text );



                
            }

        }
        private void loadInitial()
        {
            titleLabel.Visible = true;
            titleLabel.Text = "Créer Exam";
            selectCombo.Visible = false;
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
            label3.Text = "_";
            label4.Text = "_";
        }
        // function LoadQuestionInitial set all invisible except SelectCombo and SelectLabel and addbtn
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
            label1.Text = "_";
            label2.Text = "_";
            label3.Text = "_";
            label4.Text = "_";
        }
        public void ChoixDeType()
        {
            titleLabel.Visible = true;
            titleLabel.Text = "Type de question";
            selectCombo.Visible = false;
            Question_type.Visible = true;
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
            label1.Text = "_";
            label2.Text = "_";
            label3.Text = "_";
            label4.Text = "_";
        }


        public void LaodAddQCM()
        {
            titleLabel.Visible = true;
            titleLabel.Text = "Ajouter QCM";
            selectCombo.Visible = false;
            Question_type.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = false;
            Addbtn.Visible = false;
            deletebtn.Visible = false;
            modifybtn.Visible = false;
            Cancelbtn.Visible = true;
            confirmbtn.Visible = true;
            SelectLabel.Visible =false;
            qTypeLabel.Visible = true;
            qTypeLabel.Text = "QCM";
            label1.Text = "Num de Question:";
            label2.Text = "Enoncé:";
            label3.Text = "Nbre de Prop (2-4):";
            label4.Text = "_";
        }
        private void LoadAddProp(int i){
            if(i==2)
            {
                textBox3.Visible = false;
                textBox4.Visible = false;
            }
            else if(i==3)
            {
                textBox3.Visible = true;
                textBox4.Visible = false;
            }
            else if(i==4)
            {
                textBox3.Visible = true;
                textBox4.Visible = true;
            }
            
            label1.Text = "P-1";
            label2.Text = "P-2";
            label3.Text = "P-3";
            label4.Text = "P-4";



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
        
    }
}