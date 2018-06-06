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
    public partial class TelaAdicionarLanchePedido : Form
    {
        public Int64 PedidoId { get; set; }

        public TelaAdicionarLanchePedido()
        {
            InitializeComponent();
            ConfigurarComboBox();
        }

        private void ConfigurarComboBox()
        {
            cbLanche.DisplayMember = "Nome";
            cbLanche.ValueMember = "Id";
        }

        private void CarregarComboBox()
        {
            List<Lanche> lanches = Util.Gerenciador.LanchesCadastrados();
            cbLanche.DataSource = lanches;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido pedido = Util.Gerenciador.BuscarPedidoPorCodigo(PedidoId);
                Int64 lancheId = (Int64)cbLanche.SelectedValue;
                Lanche lanche = Util.Gerenciador.BuscarLanchePorCodigo(lancheId);
                Util.Gerenciador.AdicionarLancheAoPedido(pedido, lanche);
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TelaAdicionarLanchePedido_Load(object sender, EventArgs e)
        {
            CarregarComboBox();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
