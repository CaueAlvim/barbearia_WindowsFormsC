namespace projeto_barbearia
{
    partial class login
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            button1_entrar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(270, 22);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 0;
            label1.Text = "Barbearia";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(311, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(196, 159);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 2;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(196, 213);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 3;
            label3.Text = "Senha";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(311, 213);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(169, 23);
            textBox2.TabIndex = 4;
            // 
            // button1_entrar
            // 
            button1_entrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1_entrar.ImageAlign = ContentAlignment.TopRight;
            button1_entrar.Location = new Point(295, 315);
            button1_entrar.Name = "button1_entrar";
            button1_entrar.Size = new Size(93, 41);
            button1_entrar.TabIndex = 5;
            button1_entrar.Text = "ENTRAR";
            button1_entrar.UseVisualStyleBackColor = true;
            button1_entrar.Click += button1_entrar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 421);
            Controls.Add(button1_entrar);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "login";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Button button1_entrar;
        private ErrorProvider errorProvider1;
    }
}