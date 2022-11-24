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
            label1.Text = "Exam theme";
            label2.Text = "Exam date";
        }
    }
}