namespace teste
{
    partial class ucCadastro
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
            Button LOGAR;
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            txtCConfSenha = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtCSenha = new TextBox();
            label2 = new Label();
            txtCEmail = new TextBox();
            label1 = new Label();
            LOGAR = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LOGAR
            // 
            LOGAR.BackColor = SystemColors.MenuHighlight;
            LOGAR.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            LOGAR.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            LOGAR.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            LOGAR.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            LOGAR.ForeColor = SystemColors.MenuText;
            LOGAR.Location = new Point(102, 339);
            LOGAR.Name = "LOGAR";
            LOGAR.Size = new Size(188, 43);
            LOGAR.TabIndex = 0;
            LOGAR.Text = "SALVAR";
            LOGAR.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = SystemColors.MenuBar;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(txtCConfSenha);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtCSenha);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtCEmail);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LOGAR);
            panel1.Location = new Point(25, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 400);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(148, 396);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(97, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "FAZER LOGIN";
            // 
            // txtCConfSenha
            // 
            txtCConfSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCConfSenha.Location = new Point(84, 288);
            txtCConfSenha.MaximumSize = new Size(224, 27);
            txtCConfSenha.MaxLength = 10;
            txtCConfSenha.MinimumSize = new Size(224, 27);
            txtCConfSenha.Name = "txtCConfSenha";
            txtCConfSenha.PasswordChar = '*';
            txtCConfSenha.Size = new Size(224, 27);
            txtCConfSenha.TabIndex = 7;
            txtCConfSenha.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(84, 253);
            label4.Name = "label4";
            label4.Size = new Size(206, 23);
            label4.TabIndex = 6;
            label4.Text = "CONFIRMAR SENHA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(110, 31);
            label3.Name = "label3";
            label3.Size = new Size(173, 32);
            label3.TabIndex = 5;
            label3.Text = "CADASTRAR";
            label3.Click += label3_Click;
            // 
            // txtCSenha
            // 
            txtCSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCSenha.Location = new Point(84, 207);
            txtCSenha.MaximumSize = new Size(224, 27);
            txtCSenha.MaxLength = 10;
            txtCSenha.MinimumSize = new Size(224, 27);
            txtCSenha.Name = "txtCSenha";
            txtCSenha.PasswordChar = '*';
            txtCSenha.Size = new Size(224, 27);
            txtCSenha.TabIndex = 4;
            txtCSenha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(84, 172);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 3;
            label2.Text = "SENHA:";
            // 
            // txtCEmail
            // 
            txtCEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCEmail.Location = new Point(84, 127);
            txtCEmail.MaximumSize = new Size(224, 27);
            txtCEmail.MinimumSize = new Size(224, 27);
            txtCEmail.Multiline = true;
            txtCEmail.Name = "txtCEmail";
            txtCEmail.Size = new Size(224, 27);
            txtCEmail.TabIndex = 2;
            txtCEmail.TextChanged += textBox1_TextChanged;
            txtCEmail.Leave += txtCEmail_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(84, 93);
            label1.Name = "label1";
            label1.Size = new Size(83, 23);
            label1.TabIndex = 1;
            label1.Text = "E-MAIL:";
            // 
            // ucCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "ucCadastro";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox3;
        private Label label4;
        private LinkLabel linkLabel1;
        private TextBox ucCConfSenha;
        private TextBox ucCSenha;
        private TextBox txtCConfSenha;
        private TextBox txtCSenha;
        private TextBox txtCEmail;
    }
}