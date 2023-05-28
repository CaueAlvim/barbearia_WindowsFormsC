namespace projeto_barbearia
{
    partial class cliente_novo
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
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            button1_excluir = new Button();
            label5 = new Label();
            textBox3 = new TextBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1_entrar
            // 
            button1_entrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1_entrar.ImageAlign = ContentAlignment.TopRight;
            button1_entrar.Location = new Point(152, 201);
            button1_entrar.Name = "button1_entrar";
            button1_entrar.Size = new Size(151, 41);
            button1_entrar.TabIndex = 11;
            button1_entrar.Text = "CADASTRAR";
            button1_entrar.UseVisualStyleBackColor = true;
            button1_entrar.Click += button1_entrar_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(191, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(265, 23);
            textBox2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 147);
            label3.Name = "label3";
            label3.Size = new Size(164, 25);
            label3.TabIndex = 9;
            label3.Text = "Telefone Contato";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 88);
            label2.Name = "label2";
            label2.Size = new Size(158, 25);
            label2.TabIndex = 8;
            label2.Text = "Nome Completo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 23);
            textBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(400, 9);
            label1.Name = "label1";
            label1.Size = new Size(220, 25);
            label1.TabIndex = 6;
            label1.Text = "Barbearia Menu Cliente";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1_entrar);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(482, 281);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(191, 19);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 13;
            label4.Text = "CADASTRO";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ImageAlign = ContentAlignment.TopRight;
            button1.Location = new Point(676, 303);
            button1.Name = "button1";
            button1.Size = new Size(151, 41);
            button1.TabIndex = 30;
            button1.Text = "LISTAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(588, 58);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(330, 229);
            listBox1.TabIndex = 29;
            // 
            // button1_excluir
            // 
            button1_excluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1_excluir.ImageAlign = ContentAlignment.TopRight;
            button1_excluir.Location = new Point(160, 91);
            button1_excluir.Name = "button1_excluir";
            button1_excluir.Size = new Size(151, 41);
            button1_excluir.TabIndex = 28;
            button1_excluir.Text = "EXCLUIR";
            button1_excluir.UseVisualStyleBackColor = true;
            button1_excluir.Click += button1_excluir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(110, 19);
            label5.Name = "label5";
            label5.Size = new Size(249, 25);
            label5.TabIndex = 27;
            label5.Text = "Id do cliente a ser excluido";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(110, 62);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(265, 23);
            textBox3.TabIndex = 26;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(button1_excluir);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(516, 361);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(501, 151);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // cliente_novo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 543);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "cliente_novo";
            Text = "nova_reserva";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1_entrar;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Button button1;
        private ListBox listBox1;
        private Button button1_excluir;
        private Label label5;
        private TextBox textBox3;
        private GroupBox groupBox2;
    }
}