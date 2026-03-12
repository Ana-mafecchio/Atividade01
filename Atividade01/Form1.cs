using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade01
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
        private void btnIdade_Click(object sender, EventArgs e)
        {
            if (txtCampo.Text != string.Empty)
            {
                int idadeUsuario = int.Parse(txtCampo.Text);
                if (idadeUsuario >= 18)
                {
                    lbResultado.Text = "Você é maior de idade!";
                }
                else
                {
                    lbResultado.Text = "Você é menor de idade!";
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira a idade.", "Mensagem de Aviso");
            }
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            if (txtCampo.Text != string.Empty)
            {
                int numeroUsuario = int.Parse(txtCampo.Text);
                int resultado = 0;
                string respostaFinal = "";

                for (int contador = 1; contador <= 10; contador += 1)
                {
                    resultado = numeroUsuario * contador;
                    respostaFinal += numeroUsuario + " x " + contador + " = " + resultado + "\n\n";
                }
                MessageBox.Show(respostaFinal, "Tabuada do " + numeroUsuario);
            }
            else
            {
                MessageBox.Show("Insira um número para a tabuada.", "Mensagem de Aviso");
            }
        }

        private void btnContar10_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificarLetra_Click(object sender, EventArgs e)
        {

        }

        private void btnAprendendo_Click(object sender, EventArgs e)
        {
            if (txtCampo.Text != string.Empty)
            {
                int qtdRepeticao = int.Parse(txtCampo.Text);
                int contador = 1;
                string respostaFinal = "";
                if (qtdRepeticao > 50)
                {
                    MessageBox.Show("Calma dog, o limite é 50.", "Mensagem de Aviso");
                }
                else
                {
                    while (contador <= qtdRepeticao)
                    {
                        respostaFinal += contador + "- Estou aprendendo laços de repetição!\n";
                        contador++;
                    }
                    MessageBox.Show(respostaFinal, "Repetindo " + qtdRepeticao + " vez(es)!");
                }
            }
            else
            {
                MessageBox.Show("Insira um número a ser repetido.", "Mensagem de Aviso");
            }
          }

        private void btnContar10_Click_1(object sender, EventArgs e)
        {
            int numeroUsuario = 7;
            int contador = 0;

            while (contador < 10) 
            {
                contador++;
                if (contador == numeroUsuario)
                {
                    break;
                }
                MessageBox.Show("Contagem" + contador);
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            int numeroSorteado = aleatorio.Next(1, 11);

            string numeroSecretoSorteado = lbResultado.Text;
            string numeroDigitadoUsuario = txtCampo.Text;

            if (numeroSecretoSorteado == "Resultado") ;
            {
                lbResultado.Text = numeroSorteado.ToString();
                numeroSecretoSorteado = numeroSorteado.ToString();
            }
            if (numeroSecretoSorteado == numeroDigitadoUsuario)

            {

                MessageBox.Show("Parabéns você ganhou!");

            }

            if (int.Parse(numeroDigitadoUsuario) > int.Parse(numeroSecretoSorteado))

            {

                MessageBox.Show("O numero que você digitou é MAIOR que o valor secreto");

            }

            if (int.Parse(numeroDigitadoUsuario) > int.Parse(numeroSecretoSorteado))

            {

                MessageBox.Show("O numero que você digitou é MENOR que o valor secreto");

            }

        }
    }
}
