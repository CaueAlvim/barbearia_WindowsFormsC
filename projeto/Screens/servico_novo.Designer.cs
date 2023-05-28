namespace projeto_barbearia.Screens
{
    partial class servico_novo
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
            button1_entrar = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1_excluir = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1_entrar
            // 
            button1_entrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1_entrar.ImageAlign = ContentAlignment.TopRight;
            button1_entrar.Location = new Point(74, 136);
            button1_entrar.Name = "button1_entrar";
            button1_entrar.Size = new Size(151, 41);
            button1_entrar.TabIndex = 17;
            button1_entrar.Text = "CADASTRAR";
            button1_entrar.UseVisualStyleBackColor = true;
            button1_entrar.Click += button1_entrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(74, 40);
            label2.Name = "label2";
            label2.Size = new Size(149, 25);
            label2.TabIndex = 14;
            label2.Text = "Tipo do servico";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 23);
            textBox1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(280, 21);
            label1.Name = "label1";
            label1.Size = new Size(222, 25);
            label1.TabIndex = 12;
            label1.Text = "Barbearia Novo Servico";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1_entrar);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(29, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(296, 211);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button1_excluir
            // 
            button1_excluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1_excluir.ImageAlign = ContentAlignment.TopRight;
            button1_excluir.Location = new Point(113, 84);
            button1_excluir.Name = "button1_excluir";
            button1_excluir.Size = new Size(151, 41);
            button1_excluir.TabIndex = 32;
            button1_excluir.Text = "EXCLUIR";
            button1_excluir.UseVisualStyleBackColor = true;
            button1_excluir.Click += button1_excluir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(57, 19);
            label3.Name = "label3";
            label3.Size = new Size(254, 25);
            label3.TabIndex = 31;
            label3.Text = "Id do servico a ser excluido";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(57, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(265, 23);
            textBox2.TabIndex = 30;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(button1_excluir);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(377, 314);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(353, 145);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ImageAlign = ContentAlignment.TopRight;
            button1.Location = new Point(478, 250);
            button1.Name = "button1";
            button1.Size = new Size(151, 48);
            button1.TabIndex = 34;
            button1.Text = "LISTAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(400, 65);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(330, 169);
            listBox1.TabIndex = 33;
            // 
            // servico_novo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 482);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "servico_novo";
            Text = "servico_novo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1_entrar;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Button button1_excluir;
        private Label label3;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private Button button1;
        private ListBox listBox1;
    }
}