using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frm_cliente : Form
    {
        //sqlConection con = new sqlConection(); conexao com o banco de dados sendo con a conexão
        public frm_cliente()
        {
            InitializeComponent();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            frm_principal frmMain = new frm_principal();
            frmMain.Show();
            this.Hide();

        }

        private void acessar_Click(object sender, EventArgs e)
        {
            DesabilitarBotao();
            DesabiltarCampos();
            Limpar();
            btn_novo.Enabled = true;
            //con.AbrirConexao();
            MessageBox.Show("Novo Usuario cadastrado");

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
            btn_novo.Enabled = false;

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            HabiltarCampos();
            Limpar();
            id_text.Focus();

            HabilitarBotao();
            btn_novo.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void id_text_TextChanged(object sender, EventArgs e)
        {

        }
        private void DesabilitarBotao()
        {
            btn_novo.Enabled = false;
            btn_limpar.Enabled = false;
            acessar.Enabled = false;
        }


        private void HabilitarBotao()
        {
            btn_novo.Enabled = true;
            btn_limpar.Enabled = true;
            acessar.Enabled = true;
        }

        private void HabiltarCampos() 
        {
            id_text.Enabled = true;
            cliente_text.Enabled = true;
            email_text.Enabled = true;
            data_text.Enabled = true;
            vendedor_text.Enabled = true;
            contato_text.Enabled= true;
            combocidade.Enabled = true;
            combogenero.Enabled = true;
            endereco_text.Enabled = true;
        }

        private void DesabiltarCampos()
        {
            id_text.Enabled = false;
            cliente_text.Enabled = false;
            email_text.Enabled = false;
            data_text.Enabled = false;
            vendedor_text.Enabled = false;
            contato_text.Enabled = false;
            combocidade.Enabled = false;
            combogenero.Enabled = false;
            endereco_text.Enabled = true;
        }
        private void Limpar()
        {
            id_text.Text = "";
            cliente_text.Text = "";
            email_text.Text = "";
            data_text.Text = "";
            vendedor_text.Text = "";
            contato_text.Text = "";
            combocidade.Text = "";
            combogenero.Text = "";
            endereco_text.Text = "";
        }
    }
}
