namespace ExamenForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectCombo = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Question_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectLabel = new System.Windows.Forms.Label();
            this.qTypeLabel = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.modifybtn = new System.Windows.Forms.Button();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.Select_Q = new System.Windows.Forms.Button();
            this.Select_P = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // selectCombo
            // 
            this.selectCombo.FormattingEnabled = true;
            this.selectCombo.Location = new System.Drawing.Point(177, 47);
            this.selectCombo.Name = "selectCombo";
            this.selectCombo.Size = new System.Drawing.Size(208, 23);
            this.selectCombo.TabIndex = 0;
            this.selectCombo.SelectedIndexChanged += new System.EventHandler(this.selectCombo_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(177, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 23);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(177, 204);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(208, 23);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(177, 244);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(208, 23);
            this.textBox4.TabIndex = 4;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Question_type
            // 
            this.Question_type.FormattingEnabled = true;
            this.Question_type.Location = new System.Drawing.Point(177, 83);
            this.Question_type.Name = "Question_type";
            this.Question_type.Size = new System.Drawing.Size(208, 23);
            this.Question_type.TabIndex = 5;
            this.Question_type.SelectedIndexChanged += new System.EventHandler(this.Question_type_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // SelectLabel
            // 
            this.SelectLabel.AutoSize = true;
            this.SelectLabel.Location = new System.Drawing.Point(22, 47);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(38, 15);
            this.SelectLabel.TabIndex = 10;
            this.SelectLabel.Text = "Select";
            // 
            // qTypeLabel
            // 
            this.qTypeLabel.AutoSize = true;
            this.qTypeLabel.Location = new System.Drawing.Point(22, 83);
            this.qTypeLabel.Name = "qTypeLabel";
            this.qTypeLabel.Size = new System.Drawing.Size(47, 15);
            this.qTypeLabel.TabIndex = 11;
            this.qTypeLabel.Text = "type Qs";
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(167, 273);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(75, 23);
            this.Addbtn.TabIndex = 12;
            this.Addbtn.Text = "Ajouter";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(248, 273);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 13;
            this.deletebtn.Text = "Suprimer";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // modifybtn
            // 
            this.modifybtn.Location = new System.Drawing.Point(329, 273);
            this.modifybtn.Name = "modifybtn";
            this.modifybtn.Size = new System.Drawing.Size(75, 23);
            this.modifybtn.TabIndex = 14;
            this.modifybtn.Text = "modifier";
            this.modifybtn.UseVisualStyleBackColor = true;
            this.modifybtn.Click += new System.EventHandler(this.modifybtn_Click);
            // 
            // confirmbtn
            // 
            this.confirmbtn.Location = new System.Drawing.Point(293, 302);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(75, 23);
            this.confirmbtn.TabIndex = 15;
            this.confirmbtn.Text = "Confirmer";
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "label2";
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Location = new System.Drawing.Point(212, 302);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.Cancelbtn.TabIndex = 17;
            this.Cancelbtn.Text = "Annuler";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(262, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 15);
            this.titleLabel.TabIndex = 18;
            this.titleLabel.Text = "title";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // Select_Q
            // 
            this.Select_Q.Location = new System.Drawing.Point(490, 273);
            this.Select_Q.Name = "Select_Q";
            this.Select_Q.Size = new System.Drawing.Size(75, 23);
            this.Select_Q.TabIndex = 19;
            this.Select_Q.Text = "Questions";
            this.Select_Q.UseVisualStyleBackColor = true;
            this.Select_Q.Click += new System.EventHandler(this.Select_Q_Click);
            // 
            // Select_P
            // 
            this.Select_P.Location = new System.Drawing.Point(571, 273);
            this.Select_P.Name = "Select_P";
            this.Select_P.Size = new System.Drawing.Size(75, 23);
            this.Select_P.TabIndex = 20;
            this.Select_P.Text = "Propositions";
            this.Select_P.UseVisualStyleBackColor = true;
            this.Select_P.Click += new System.EventHandler(this.Select_P_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(439, 47);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 25;
            this.dataGrid.Size = new System.Drawing.Size(263, 208);
            this.dataGrid.TabIndex = 21;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 344);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.Select_P);
            this.Controls.Add(this.Select_Q);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirmbtn);
            this.Controls.Add(this.modifybtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.qTypeLabel);
            this.Controls.Add(this.SelectLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Question_type);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.selectCombo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox selectCombo;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox Question_type;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label SelectLabel;
        private Label qTypeLabel;
        private Button Addbtn;
        private Button deletebtn;
        private Button modifybtn;
        private Button confirmbtn;
        private Label label2;
        private Button Cancelbtn;
        private Label titleLabel;
        private Button Select_Q;
        private Button Select_P;
        private DataGridView dataGrid;
    }
}