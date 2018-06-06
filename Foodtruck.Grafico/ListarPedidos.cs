using Foodtruck.Negocio.Models;
using Foodtruck.Negocio;
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
    public partial class ListarPedidos : Form
    {
        public ListarPedidos()
        {
            InitializeComponent();
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            dgPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPedidos.MultiSelect = false;
            dgPedidos.SelectionChanged += DgPedidos_SelectionChanged;
            dgPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void DgPedidos_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void CarregarDados()
        {
            List<Pedido> pedidos = Util.Gerenciador.PedidosCadastrados();
            dgPedidos.DataSource = pedidos;
        }

        private void ListarPedidos_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            AdicionaPedido tela = new AdicionaPedido();
            tela.MdiParent = this.MdiParent;
            tela.FormClosed += Tela_FormClosed;
            tela.Show();
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarDados();
        }

        private void tbAdicionarBebida_Click(object sender, EventArgs e)
        {
            if (dgPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um pedido");
                return;
            }

            Int64 pedidoId = (Int64) dgPedidos.SelectedRows[0].Cells[0].Value;
            TelaAdicionarBebidaPedido tela = new TelaAdicionarBebidaPedido();
            tela.FormClosed += Tela_FormClosed1;
            tela.PedidoId = pedidoId;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void Tela_FormClosed1(object sender, FormClosedEventArgs e)
        {
            CarregarDados();
        }

        private void tbLanche_Click(object sender, EventArgs e)
        {
            if(dgPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um pedido");
                return;
            }
            Int64 pedidoId = (Int64)dgPedidos.SelectedRows[0].Cells[0].Value;
            TelaAdicionarLanchePedido tela = new TelaAdicionarLanchePedido();
            tela.FormClosed += Tela_FormClosed2;
            tela.PedidoId = pedidoId;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void Tela_FormClosed2(object sender, FormClosedEventArgs e)
        {
            CarregarDados();
        }

        private void tbDetalhe_Click(object sender, EventArgs e)
        {
            if(dgPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um pedido");
                return;
            }
            Int64 pedidoId = (Int64)dgPedidos.SelectedRows[0].Cells[0].Value;
            DetalhesPedido tela = new DetalhesPedido();
            tela.FormClosed += Tela_FormClosed3;
            tela.PedidoId = pedidoId;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void Tela_FormClosed3(object sender, FormClosedEventArgs e)
        {
            CarregarDados();
        }

        private void dgPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
