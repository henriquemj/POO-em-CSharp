using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // instanciar a classe
            Pessoa PessoaNova = new Pessoa();
            // passar o conteudo que vai ser digitado para as variaveis
            PessoaNova.setNome(textBox1.Text);
            try
            {
                PessoaNova.setIdade(int.Parse(textBox2.Text));
                //Obter o nome e a idade
                string xnome = PessoaNova.getNome();
                int xidade = PessoaNova.getIdade();
                string strsaida = "Nome da Pessoa : " + xnome.ToUpper() + "\n\n" + "Idade : " + xidade.ToString();
                MessageBox.Show(strsaida, " ****Resultado****",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message + "\n\nTente Novamente ;(", "***** ERRO NA ENTRADA***",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string texto = "Deseja Sair da aplicação?";
            string titulo = "*** FINALIZANDO APLICAÇÃO";
            if (MessageBox.Show(texto, titulo,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
    }
