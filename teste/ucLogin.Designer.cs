namespace teste
{
    partial class ucLogin
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
            Button LOGAR;
            panel1 = new Panel();
            label3 = new Label();
            txtSenha = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
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
            LOGAR.Location = new Point(136, 271);
            LOGAR.Name = "LOGAR";
            LOGAR.Size = new Size(114, 43);
            LOGAR.TabIndex = 0;
            LOGAR.Text = "LOGAR";
            LOGAR.UseVisualStyleBackColor = false;
            LOGAR.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = SystemColors.MenuBar;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LOGAR);
            panel1.Location = new Point(25, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 400);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(139, 36);
            label3.Name = "label3";
            label3.Size = new Size(103, 32);
            label3.TabIndex = 5;
            label3.Text = "LOGAR";
            label3.Click += label3_Click;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSenha.Location = new Point(80, 207);
            txtSenha.MaximumSize = new Size(224, 27);
            txtSenha.MaxLength = 10;
            txtSenha.MinimumSize = new Size(224, 27);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(224, 27);
            txtSenha.TabIndex = 4;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(80, 173);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 3;
            label2.Text = "SENHA:";
            label2.Click += label2_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(80, 127);
            txtEmail.MaximumSize = new Size(224, 27);
            txtEmail.MinimumSize = new Size(224, 27);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(224, 27);
            txtEmail.TabIndex = 2;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(80, 93);
            label1.Name = "label1";
            label1.Size = new Size(83, 23);
            label1.TabIndex = 1;
            label1.Text = "E-MAIL:";
            label1.Click += label1_Click;
            // 
            // ucLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(815, 450);
            Controls.Add(panel1);
            Name = "ucLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
          
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button LOGAR;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label label2;
        private Label label3;
    }
}