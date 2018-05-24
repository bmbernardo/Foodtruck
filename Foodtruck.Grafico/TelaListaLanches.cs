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
    public partial class TelaListaLanches : Form
    {
        public TelaListaLanches()
        {
            InitializeComponent();
        }

        private void AbreTelaInclusaoAlteracao(Lanche LancheSelecionado)
        {
            ManterLanche tela = new ManterLanche();
            tela.MdiParent = this.MdiParent;
            tela.LancheSelecionado = LancheSelecionado;
            tela.FormClosed += Tela_FormClosed;
            tela.Show();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            AbreTelaInclusaoAlteracao(null);
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarLanche();
        }

        private void CarregarLanche()
        {
            dgLanches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgLanches.MultiSelect = false;
            dgLanches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLanches.AutoGenerateColumns = false;
            List<Lanche> lanches = Program.Gerenciador.TodosOsLanches();
            dgLanches.DataSource = lanches;
        }

        private void TelaListaLanches_Load(object sender, EventArgs e)
        {
            CarregarLanche();
        }

        private bool VerificarSelecao()
        {
            if (dgLanches.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                DialogResult resultado = MessageBox.Show("Tem certeza?", "Quer remover?", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    Lanche lancheSelecionado = (Lanche)dgLanches.SelectedRows[0].DataBoundItem;
                    var validacao = Program.Gerenciador.RemoverLanche(lancheSelecionado);
                    if (validacao.Valido)
                    {
                        MessageBox.Show("Lanche removido com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um problema ao remover o Bebida");
                    }
                    CarregarLanche();
                }
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                Lanche lancheSelecionado = (Lanche)dgLanches.SelectedRows[0].DataBoundItem;
                AbreTelaInclusaoAlteracao(lancheSelecionado);
            }
        }

        private void dgLanches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }       
}
