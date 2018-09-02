using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandixDPX
{
    public partial class Home : Form
    {
        CadastroVendedores cadopen = new CadastroVendedores();
        Config.Seleciona v = new Config.Seleciona();

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {


            LtBoxCliente.ValueMember = "CDVEND";
            LtBoxCliente.DisplayMember = "DSNOME";
            LtBoxCliente.DataSource = v.Clientes();

            ltBoxTipo.ValueMember = "CDVEND";
            ltBoxTipo.DisplayMember = "IDTIPO";
            ltBoxTipo.DataSource = v.Clientes();

            ltxBoxCredito.ValueMember = "CDVEND";
            ltxBoxCredito.DisplayMember = "DSLIM";
            ltxBoxCredito.DataSource = v.Clientes();

            cmBoxVendedor.ValueMember = "CDVEND";
            cmBoxVendedor.DisplayMember = "DSNOME";
            cmBoxVendedor.DataSource = v.Vendedores();


        }

        private void cadastrarVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {


            CadastroClientes cadastro = new CadastroClientes();

            cadastro.Show();

        }

        private void CmBoxFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }


        private void LtBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;

            if (l.SelectedIndex != 0)
            {
                ltxBoxCredito.SelectedIndex = l.SelectedIndex;
                LtBoxCliente.SelectedIndex = l.SelectedIndex;
                ltBoxTipo.SelectedIndex = l.SelectedIndex;


            }
        }

        private void cadastrarCliente(object sender, EventArgs e)
        {
            CadastroClientes cadastro = new CadastroClientes();

            cadastro.Show();
        }

        private void editarVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void manutençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroVendedores vecad = new CadastroVendedores();
            vecad.Show();
        }

        private void manutençãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroClientes cadcliente = new CadastroClientes();
            cadcliente.Show();
        }
    }
}
