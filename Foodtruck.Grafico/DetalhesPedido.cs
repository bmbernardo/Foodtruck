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
    public partial class DetalhesPedido : Form
    {
        public Int64 PedidoId { get; set; }

        public DetalhesPedido()
        {
            InitializeComponent();
            ConfigurarDataGrid();
        }

        private void ConfigurarDataGrid()
        {
            dgLanches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgLanches.ColumnHeadersVisible = true;
            dgLanches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgBebidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgBebidas.ColumnHeadersVisible = true;
            dgBebidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void DetalhesPedido_Load(object sender, EventArgs e)
        {
            CarregarDados();
            tbID.Text = PedidoId.ToString();
        }

        private void CarregarDados()
        {
        Pedido pedido = Util.Gerenciador.BuscarPedidoPorCodigo(PedidoId);
            dgLanches.DataSource = pedido.Lanches;
            dgBebidas.DataSource = pedido.Bebidas;
            tbCliente.Text = pedido.Cliente.Nome.ToString();
            tbValor.Text = pedido.ValorTotal().ToString();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
