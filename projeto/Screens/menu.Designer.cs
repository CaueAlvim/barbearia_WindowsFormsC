namespace projeto_barbearia
{
    partial class menu
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
            button1_nova = new Button();
            label14 = new Label();
            label1 = new Label();
            button1 = new Button();
            label15 = new Label();
            button3 = new Button();
            label16 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1_nova
            // 
            button1_nova.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1_nova.Location = new Point(35, 93);
            button1_nova.Name = "button1_nova";
            button1_nova.Size = new Size(102, 47);
            button1_nova.TabIndex = 1;
            button1_nova.Text = "MENU";
            button1_nova.UseVisualStyleBackColor = true;
            button1_nova.Click += button1_nova_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(35, 35);
            label14.Name = "label14";
            label14.Size = new Size(104, 32);
            label14.TabIndex = 14;
            label14.Text = "Clientes";
            label14.Click += label14_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 176);
            label1.Name = "label1";
            label1.Size = new Size(123, 32);
            label1.TabIndex = 16;
            label1.Text = "Barbeiros";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(46, 234);
            button1.Name = "button1";
            button1.Size = new Size(102, 47);
            button1.TabIndex = 17;
            button1.Text = "MENU";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(35, 316);
            label15.Name = "label15";
            label15.Size = new Size(109, 32);
            label15.TabIndex = 19;
            label15.Text = "Servicos";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(46, 374);
            button3.Name = "button3";
            button3.Size = new Size(102, 47);
            button3.TabIndex = 20;
            button3.Text = "MENU";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(296, 35);
            label16.Name = "label16";
            label16.Size = new Size(201, 32);
            label16.TabIndex = 21;
            label16.Text = "AGENDAMENTO";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(310, 93);
            button2.Name = "button2";
            button2.Size = new Size(175, 101);
            button2.TabIndex = 22;
            button2.Text = "MENU";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(718, 457);
            Controls.Add(button2);
            Controls.Add(label16);
            Controls.Add(button3);
            Controls.Add(label15);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label14);
            Controls.Add(button1_nova);
            Name = "menu";
            Text = "cadastrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Label label8;
        private Label label7;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button button3_excluir;
        private Button button1_nova;
        private Label label14;
        private Label label1;
        private Button button1;
        private Label label15;
        private Button button3;
        private Label label16;
        private Button button2;
    }
}