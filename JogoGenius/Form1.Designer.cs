namespace JogoGenius
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
            components = new System.ComponentModel.Container();
            btVerde = new Button();
            btAmarelo = new Button();
            btAzul = new Button();
            btVermelho = new Button();
            label1 = new Label();
            lbNivel = new Label();
            btIniciar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btCiano = new Button();
            btRoxo = new Button();
            SuspendLayout();
            // 
            // btVerde
            // 
            btVerde.FlatStyle = FlatStyle.Flat;
            btVerde.Location = new Point(130, 71);
            btVerde.Name = "btVerde";
            btVerde.Size = new Size(106, 105);
            btVerde.TabIndex = 0;
            btVerde.UseVisualStyleBackColor = true;
            btVerde.Click += bt_Click;
            // 
            // btAmarelo
            // 
            btAmarelo.BackColor = SystemColors.Control;
            btAmarelo.FlatStyle = FlatStyle.Flat;
            btAmarelo.Location = new Point(255, 71);
            btAmarelo.Name = "btAmarelo";
            btAmarelo.Size = new Size(108, 105);
            btAmarelo.TabIndex = 1;
            btAmarelo.UseVisualStyleBackColor = false;
            btAmarelo.Click += bt_Click;
            // 
            // btAzul
            // 
            btAzul.FlatStyle = FlatStyle.Flat;
            btAzul.Location = new Point(255, 195);
            btAzul.Name = "btAzul";
            btAzul.Size = new Size(108, 103);
            btAzul.TabIndex = 3;
            btAzul.UseVisualStyleBackColor = true;
            btAzul.Click += bt_Click;
            // 
            // btVermelho
            // 
            btVermelho.FlatStyle = FlatStyle.Flat;
            btVermelho.Location = new Point(132, 195);
            btVermelho.Name = "btVermelho";
            btVermelho.Size = new Size(104, 103);
            btVermelho.TabIndex = 2;
            btVermelho.UseVisualStyleBackColor = true;
            btVermelho.Click += bt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(186, 339);
            label1.Name = "label1";
            label1.Size = new Size(91, 37);
            label1.TabIndex = 4;
            label1.Text = "Nível :";
            label1.Click += label1_Click;
            // 
            // lbNivel
            // 
            lbNivel.AutoSize = true;
            lbNivel.Font = new Font("Segoe UI", 20F);
            lbNivel.Location = new Point(322, 339);
            lbNivel.Name = "lbNivel";
            lbNivel.Size = new Size(0, 37);
            lbNivel.TabIndex = 5;
            // 
            // btIniciar
            // 
            btIniciar.Font = new Font("Segoe UI", 16F);
            btIniciar.Location = new Point(255, 399);
            btIniciar.Name = "btIniciar";
            btIniciar.Size = new Size(108, 50);
            btIniciar.TabIndex = 6;
            btIniciar.Text = "Iniciar";
            btIniciar.UseVisualStyleBackColor = true;
            btIniciar.Click += btIniciar_Click;
            // 
            // timer1
            // 
            timer1.Interval = 250;
            timer1.Tick += timer1_Tick;
            // 
            // btCiano
            // 
            btCiano.FlatStyle = FlatStyle.Flat;
            btCiano.Location = new Point(383, 195);
            btCiano.Name = "btCiano";
            btCiano.Size = new Size(108, 103);
            btCiano.TabIndex = 8;
            btCiano.UseVisualStyleBackColor = true;
            btCiano.Click += bt_Click;
            // 
            // btRoxo
            // 
            btRoxo.BackColor = SystemColors.Control;
            btRoxo.FlatStyle = FlatStyle.Flat;
            btRoxo.Location = new Point(383, 71);
            btRoxo.Name = "btRoxo";
            btRoxo.Size = new Size(108, 105);
            btRoxo.TabIndex = 7;
            btRoxo.UseVisualStyleBackColor = false;
            btRoxo.Click += bt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 523);
            Controls.Add(btCiano);
            Controls.Add(btRoxo);
            Controls.Add(btIniciar);
            Controls.Add(lbNivel);
            Controls.Add(label1);
            Controls.Add(btAzul);
            Controls.Add(btVermelho);
            Controls.Add(btAmarelo);
            Controls.Add(btVerde);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btVerde;
        private Button btAmarelo;
        private Button btAzul;
        private Button btVermelho;
        private Label label1;
        private Label lbNivel;
        private Button btIniciar;
        private System.Windows.Forms.Timer timer1;
        private Button btCiano;
        private Button btRoxo;
    }
}
