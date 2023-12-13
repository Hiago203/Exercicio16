using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio16
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = MinhaClasse.Nome;
            textBox1.Text = MinhaClasse.Nome;
            textBox2.Text = MinhaClasse.Email;
            textBox3.Text = MinhaClasse.Password;
        }
    }
}
