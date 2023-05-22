using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class ucCadastro : Form
    {
        public ucCadastro()
        {
            InitializeComponent();
            this.Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Width = 400;

            panel1.Height = 400;

            panel1.Location = new Point((this.Width - panel1.Width) / 2, (this.Height - panel1.Height) / 2);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void txtCEmail_Leave(object sender, EventArgs e)
        {

        }
    }
}
