using System.Text.RegularExpressions;

namespace teste
{
    public partial class ucLogin : Form
    {
        public ucLogin()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidarLogin();

        }

        private bool ValidarLogin()
        {
            if (!ValidarEmail() || txtSenha.Text == string.Empty)
            {
                MessageBox.Show("ERROR! CREDENCIAIS INVÁLIDAS!");
                return false;
            }


            if (txtSenha.Text.Length < 8)
            {
                MessageBox.Show("ERROR! QUANTIDADE DE CARACTERES INVÁLIDA!");
                return false;

            }

            if (!Regex.IsMatch(txtSenha.Text, "[^a-zA-Z0-9]"))
            {
                MessageBox.Show("ERROR! A SENHA DEVE CONTER PELO MENOS UM CARACTERE ESPECIAL!");
                return false;
            }

            return true;

        }
        private bool ValidarEmail()
            => new Regex(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$").Match(txtEmail.Text).Success;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Width = 400;

            panel1.Height = 400;

            panel1.Location = new Point((this.Width - panel1.Width) / 2, (this.Height - panel1.Height) / 2);
        }

        //private void ucLogin_Enter(object sender, EventArgs e)
        //{

        //}

        //private void txtSenha_Leave(object sender, EventArgs e)
        //
        //    if (!validarmetodo())
        //    {
        //        txtSenha.Text = string.Empty;

        //        MessageBox.Show("ERROR! QUANTIDADE DE CARACTERES INVÁLIDA!");
        //    }
        //}
    }
}
