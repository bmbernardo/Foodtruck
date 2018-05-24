using Foodtruck.Negocio;
using Foodtruck.Negocio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodtruck.Grafico
{
    public partial class ManterBebida : Form
    {
        public Bebida BebidaSelecionado { get; set; }

        public ManterBebida()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Bebida bebida = new Bebida();
            if(Int64.TryParse(tbId.Text, out long value))
            {
                bebida.Id = value;
            }
            else
            {
                bebida.Id = -1;
                //passa indentificador com valor negativo se não conseguir converter
            }

            bebida.Nome = tbNome.Text;
            if (Decimal.TryParse(tbValor.Text, out decimal valor))
            {
                bebida.Valor = valor;
            }
            if (Single.TryParse(tbTamanho.Text, out float tamanho))
            {
                bebida.Tamanho = tamanho;
            }

            Validacao validacao;
            if (BebidaSelecionado == null)
            {
                validacao = Program.Gerenciador.AdicionarBebida(bebida);
            }
            else
            {
                validacao = Program.Gerenciador.AlterarBebida(bebida);
            }
            

            
            if (!validacao.Valido)
            {
                String mensagemValidacao = "";
                foreach(var chave in validacao.Mensagens.Keys)
                {
                    String msg = validacao.Mensagens[chave];
                    mensagemValidacao += msg;
                    mensagemValidacao += Environment.NewLine;
                }
                MessageBox.Show(mensagemValidacao);
            }
            else
            {
                MessageBox.Show("Bebida salvo com sucesso");
            }

            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManterBebida_Shown(object sender, EventArgs e)
        {
            if(BebidaSelecionado != null)
            {
                this.tbId.Text = BebidaSelecionado.Id.ToString();
                this.tbNome.Text = BebidaSelecionado.Nome;
                this.tbValor.Text = BebidaSelecionado.Valor.ToString();
                this.tbTamanho.Text = BebidaSelecionado.Tamanho.ToString();
            }
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
