namespace projeto_barbearia.Screens
{
    partial class agendamento_novo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            listBox1 = new ListBox();
            groupBox2 = new GroupBox();
            button1_excluir = new Button();
            label6 = new Label();
            textBox5 = new TextBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1_entrar = new Button();
            label1 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ImageAlign = ContentAlignment.TopRight;
            button1.Location = new Point(710, 317);
            button1.Name = "button1";
            button1.Size = new Size(151, 41);
            button1.TabIndex = 37;
            button1.Text = "LISTAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(582, 85);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(393, 214);
            listBox1.TabIndex = 36;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1_excluir);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Location = new Point(593, 364);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(367, 202);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // button1_excluir
            // 
            button1_excluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1_excluir.ImageAlign = ContentAlignment.TopRight;
            button1_excluir.Location = new Point(111, 152);
            button1_excluir.Name = "button1_excluir";
            button1_excluir.Size = new Size(151, 41);
            button1_excluir.TabIndex = 32;
            button1_excluir.Text = "EXCLUIR";
            button1_excluir.UseVisualStyleBackColor = true;
            button1_excluir.Click += button1_excluir_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(24, 56);
            label6.Name = "label6";
            label6.Size = new Size(315, 25);
            label6.TabIndex = 31;
            label6.Text = "Id do agendamento a ser excluido";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(55, 109);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(265, 23);
            textBox5.TabIndex = 30;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button1_entrar);
            groupBox1.Location = new Point(43, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(472, 366);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ImageAlign = ContentAlignment.TopRight;
            button2.Location = new Point(268, 298);
            button2.Name = "button2";
            button2.Size = new Size(151, 41);
            button2.TabIndex = 44;
            button2.Text = "ALTERAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(178, 225);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(261, 23);
            dateTimePicker1.TabIndex = 43;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(178, 182);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(261, 23);
            comboBox3.TabIndex = 41;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(178, 132);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(261, 23);
            comboBox2.TabIndex = 40;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(178, 84);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(261, 23);
            comboBox1.TabIndex = 39;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(178, 19);
            label7.Name = "label7";
            label7.Size = new Size(112, 25);
            label7.TabIndex = 24;
            label7.Text = "CADASTRO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(32, 84);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 14;
            label2.Text = "Nome Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(32, 223);
            label5.Name = "label5";
            label5.Size = new Size(118, 25);
            label5.TabIndex = 20;
            label5.Text = "Data e Hora";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 130);
            label3.Name = "label3";
            label3.Size = new Size(148, 25);
            label3.TabIndex = 15;
            label3.Text = "Nome Barbeiro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 177);
            label4.Name = "label4";
            label4.Size = new Size(138, 25);
            label4.TabIndex = 18;
            label4.Text = "Qual o serviço";
            // 
            // button1_entrar
            // 
            button1_entrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1_entrar.ImageAlign = ContentAlignment.TopRight;
            button1_entrar.Location = new Point(47, 298);
            button1_entrar.Name = "button1_entrar";
            button1_entrar.Size = new Size(151, 41);
            button1_entrar.TabIndex = 17;
            button1_entrar.Text = "CADASTRAR";
            button1_entrar.UseVisualStyleBackColor = true;
            button1_entrar.Click += button1_entrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(406, 9);
            label1.Name = "label1";
            label1.Size = new Size(283, 25);
            label1.TabIndex = 38;
            label1.Text = "Barbearia Novo Agendamento";
            // 
            // agendamento_novo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 588);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "agendamento_novo";
            Text = "agendamento_novo";
            Load += agendamento_novo_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private GroupBox groupBox2;
        private Button button1_excluir;
        private Label label6;
        private TextBox textBox5;
        private GroupBox groupBox1;
        private Label label7;
        private Label label2;
        private Label label5;
        private Label label3;
        private Label label4;
        private Button button1_entrar;
        private Label label1;
        public ComboBox comboBox1;
        public ComboBox comboBox3;
        public ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private Button button2;
    }
}