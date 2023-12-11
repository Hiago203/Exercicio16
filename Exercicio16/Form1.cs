namespace Exercicio16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            MinhaClasse.Nome = textBox1.Text;
            MinhaClasse.Email = textBox2.Text;
            MinhaClasse.Password = textBox3.Text;
            label4.Text = "Utilizador: " + MinhaClasse.Nome;

            MessageBox.Show("Foi Guardado");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
            }

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
} /* mostrar password
   */