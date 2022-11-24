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

        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            if(titleLabel.Text== "Question Type")
            {
                
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
            label1.Text = "_";
            label2.Text = "_";
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
            qTypeLabel.Visible = false;
            label1.Text = "_";
            label2.Text = "_";
            label3.Text = "_";
            label4.Text = "_";
        }
        public void ChoixDeType()
        {
            titleLabel.Visible = true;
            titleLabel.Text = "Question Type";
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
            qTypeLabel.Text = "Question Type";
            label1.Text = "_";
            label2.Text = "_";
            label3.Text = "_";
            label4.Text = "_";
        }

        //funcition addQCM thant make textbox1 visible and confirme btn visible
        public void addQCM()
        {
            titleLabel.Visible = true;
            titleLabel.Text = "QCM";
            selectCombo.Visible = false;
            Question_type.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            Addbtn.Visible = false;
            deletebtn.Visible = false;
            modifybtn.Visible = false;
            Cancelbtn.Visible = true;
            confirmbtn.Visible = true;
            qTypeLabel.Visible = true;
            qTypeLabel.Text = "QCM";
            label1.Text = "_";
            label2.Text = "_";
            label3.Text = "_";
            label4.Text = "_";
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