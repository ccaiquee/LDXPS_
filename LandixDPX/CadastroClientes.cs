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
    public partial class CadastroClientes : Form
    {
        Config.Cadastro CadastraCliente = new Config.Cadastro();
        Config.Seleciona CadastraVendedor = new Config.Seleciona();

        public CadastroClientes()
        {
            InitializeComponent();
        }

        private void CadastroClientes_Load(object sender, EventArgs e)
        {
            LtBoxCliente.ValueMember = "CDVEND";
            LtBoxCliente.DisplayMember = "DSNOME";
            LtBoxCliente.DataSource = CadastraVendedor.Clientes();

            ltBoxTipo.ValueMember = "CDVEND";
            ltBoxTipo.DisplayMember = "IDTIPO";
            ltBoxTipo.DataSource = CadastraVendedor.Clientes();

            ltxBoxCredito.ValueMember = "CDVEND";
            ltxBoxCredito.DisplayMember = "DSLIM";
            ltxBoxCredito.DataSource = CadastraVendedor.Clientes();

            CodVend.DisplayMember = "DSNOME";
            CodVend.ValueMember = "CDVEND";
            CodVend.DataSource = CadastraVendedor.Clientes();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string CDVEND = LtCdvend.Text;
            Guid gerardorguidc = Guid.NewGuid();

            string dsnome = txtnome.Text;
            char idtipo = Convert.ToChar(txtipoT.Text);
            decimal dslim = Convert.ToDecimal(txtcredito.Text);


            CadastraCliente.CadastrarClientes(gerardorguidc, dsnome, idtipo, CDVEND, dslim);
        }

                


     

        private void Ltnome_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //SINCRONIZA O SELECT  
            ListBox l = sender as ListBox;

            if (l.SelectedIndex != 0)
            {
                LtBoxCliente.SelectedIndex = l.SelectedIndex;
                ltBoxTipo.SelectedIndex = l.SelectedIndex;
                ltxBoxCredito.SelectedIndex = l.SelectedIndex;

                txtnome.Text = LtBoxCliente.Text;
                txtipoT.Text = ltBoxTipo.Text;
                txtcredito.Text = ltxBoxCredito.Text;
            }
        }

        private void ltxBoxCredito_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;

            if (l.SelectedIndex != 0)
            {
                LtBoxCliente.SelectedIndex = l.SelectedIndex;
                ltBoxTipo.SelectedIndex = l.SelectedIndex;
                ltxBoxCredito.SelectedIndex = l.SelectedIndex;


                //txbNome.Text = LtDSNOME.SelectedItem.ToString();

                txtnome.Text = LtBoxCliente.Text;
                txtipoT.Text = ltBoxTipo.Text;
                txtcredito.Text = ltxBoxCredito.Text;
            }
        }

        private void criarVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroVendedores cadastrov = new CadastroVendedores();
            cadastrov.Show();
        }

        private void cmbFunc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            LtCdvend.Text = Convert.ToString(CodVend.SelectedValue);
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //ALTERAR DADOS
            string nome = txtnome.Text;
            char idtipo = Convert.ToChar(txtipoT.Text);
            decimal dslim = Convert.ToInt64(txtcredito.Text);

          
            CadastraCliente.AlterarCliente(nome, idtipo, dslim);
            txtnome.Text = ("");
            txtipoT.Text = ("");
            txtcredito.Text = ("");
            CodVend.Text = ("");
            LtCdvend.Text = ("");

            txtnome.Clear();
            txtipoT.Clear();
            txtcredito.Clear();

            LtCdvend.Clear();
        }

        private void txtipoT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            string nit = txtnome.Text;
            CadastraCliente.DelClientes(nit);


            //cmbclientes.DataSource = verifi.Vendedores();

            txtnome.Text = ("");
            txtipoT.Text = ("");
            txtcredito.Text = ("");
            CodVend.Text = ("");
        }
    }
}
