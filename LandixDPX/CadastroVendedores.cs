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
    public partial class CadastroVendedores : Form

    {
        Config.Cadastro conexo = new Config.Cadastro();
        Config.Seleciona verifi = new Config.Seleciona();




        public CadastroVendedores()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //CADASTRAR VENDEDOR

            Guid GerardorGuidV = Guid.NewGuid();
            string Nome = txbNome.Text;
            int CodTabela = Convert.ToInt16(txbCod.Text);
            DateTime DataNascimento = Convert.ToDateTime(dtpNascimento.Text);

            conexo.CadastrarVendedor(GerardorGuidV, Nome, CodTabela, DataNascimento);

            txbNome.Text = ("");
            txbCod.Text = ("");
            dtpNascimento.Text = ("");
            cmbclientes.Text = ("");

        }


        private void LtBoxVendedores_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void CadastroVendedores_Load(object sender, EventArgs e)
        {

            //INICIALIZA OS DADOS NO LISTBOX

            cmbclientes.ValueMember = "CDVEND";
            cmbclientes.DisplayMember = "DSNOME";
            cmbclientes.DataSource = verifi.Clientes();

            LtCDVEND.ValueMember = "CDVEND";
            LtCDVEND.DisplayMember = "CDVEND";
            LtCDVEND.DataSource = verifi.Vendedores();

            LtDSNOME.ValueMember = "CDVEND";
            LtDSNOME.DisplayMember = "DSNOME";
            LtDSNOME.DataSource = verifi.Vendedores();

            LtCDTAB.ValueMember = "CDVEND";
            LtCDTAB.DisplayMember = "CDTAB";
            LtCDTAB.DataSource = verifi.Vendedores();

            LtDTNASC.ValueMember = "CDVEND";
            LtDTNASC.DisplayMember = "DTNASC";
            LtDTNASC.DataSource = verifi.Vendedores();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void cmbclientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            // BOTÃO DE EXCLUIR

            string nit = txbNome.Text;
            conexo.DelVendedor(nit);

            cmbclientes.DataSource = verifi.Vendedores();

            txbNome.Text = ("");
            txbCod.Text = ("");
            dtpNascimento.Text = ("");
            txbNome.Clear();

        }



        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CENTRALIZA OS LISTBOX SELECIONADOS

            ListBox l = sender as ListBox;

            if (l.SelectedIndex != 0)
            {
                LtCDTAB.SelectedIndex = l.SelectedIndex;
                LtCDVEND.SelectedIndex = l.SelectedIndex;
                LtDSNOME.SelectedIndex = l.SelectedIndex;
                LtDTNASC.SelectedIndex = l.SelectedIndex;
                txbNome.Text = LtDSNOME.Text;
                txbCod.Text = LtCDTAB.Text;
                dtpNascimento.Text = LtDTNASC.Text;

            }

        }

        private void Atualizar_Click(object sender, EventArgs e)
        {

            //ATUALIZAR DADOS

            string nome = txbNome.Text;
            int codTabela = Convert.ToUInt16(txbCod.Text);
            DateTime dataNascimento = Convert.ToDateTime(dtpNascimento.Text);
            conexo.AlteVendedor(nome, codTabela, dataNascimento);

            txbNome.Text = ("");
            txbCod.Text = ("");
            dtpNascimento.Text = ("");
            panel1.Hide();

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
           
        }

        private void Visualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void criarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroClientes p = new CadastroClientes();
            p.Show();
        }
    }
}
