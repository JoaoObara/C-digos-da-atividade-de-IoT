using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassMsg;
using MonitoramentoDeAnimais.RegrasDeNegocio;
using MonitoramentoDeAnimais.Contexto;

namespace MonitoramentoDeAnimais.Formularios
{
    public partial class FormCadastrarAnimal : Form
    {

        public FormCadastrarAnimal()
        {
            InitializeComponent();
            rdMacho.Select();
            edNumeroId.Select();
            DesativarCampos();

        }

        //Metodo para Desabilitar TextBox e btSalvar #############
        public void DesativarCampos()
        {
            edNumeroId.Clear();
            edNumeroIdPai.Enabled = false;
            edNumeroIdMae.Enabled = false;
            edEstado.Enabled = false;
            btSalvar.Enabled = false;
            edPeso.Enabled = false;
            edNumeroId.Select();
        }

        // Armazenar seleção do botão de radio ###################
        public static string sexo;

        private void btSalvar_Click(object sender, EventArgs e)
        {
            //Instanciar objetos ###################
            Msg msg = new Msg("Sistema de monitoramento");
            Animal objAnimal = new Animal();

            //Armazenar Valores #####################
            objAnimal.NumeroId = Convert.ToInt32(edNumeroId.Text);
            objAnimal.NumeroIdMae = Convert.ToInt32(edNumeroIdMae.Text);
            objAnimal.NumeroIdPai = Convert.ToInt32(edNumeroIdPai.Text);
            objAnimal.DataNasc = dtNasc.Value;
            objAnimal.Sexo = sexo;
            objAnimal.Estado = edEstado.Text;
            objAnimal.Peso = edPeso.Text;

            // Adicionar objeto a lista "salvar" ####################
            Context.id++;
            Context.listaAnimais.Add(objAnimal);
            msg.Informacao("Animal cadastrado!!");
            btCancelar_Click(sender, e);

        }

        // Seleção dos Botões de Radio #################
        private void rdMacho_Click(object sender, EventArgs e)
        {
            sexo = "Macho";
        }
        private void rdFemea_Click(object sender, EventArgs e)
        {
            sexo = "Femea";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            //Limpar campos e voltar ao inicio #########################
            edNumeroId.Clear();
            edNumeroIdPai.Clear();
            edNumeroIdMae.Clear();
            edEstado.Clear();
            edPeso.Clear();
            edNumeroId.Select();
            DesativarCampos();
        }

        //Somente números no textbox ######################
        private void edNumeroIdMae_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar == 8) return;
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void edNumeroIdPai_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar == 8) return;
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void edNumeroId_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar == 8) return;
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Habilitar campos #################################################
        private void edNumeroId_KeyUp(object sender, KeyEventArgs e)
        {
            //Habilitar textbox ######
            if (edNumeroId.TextLength != 0)
            {
                edPeso.Enabled = true;
            }
            else edPeso.Enabled = false;
        }

        private void edPeso_KeyUp(object sender, KeyEventArgs e)
        {
            //Habilitar textbox ######
            if (edPeso.TextLength != 0)
            {
                edEstado.Enabled = true;
            }
            else edEstado.Enabled = false;
        }

        private void edEstado_KeyUp(object sender, KeyEventArgs e)
        {
            //Habilitar textbox ######
            if (edEstado.TextLength !=0)
            {
                edNumeroIdPai.Enabled = true;
            }
            else edNumeroIdPai.Enabled = false;
        }

        private void edNumeroIdPai_KeyUp(object sender, KeyEventArgs e)
        {
            //Habilitar botão salvar ######
            if (edNumeroIdPai.TextLength != 0)
            {
                edNumeroIdMae.Enabled = true;
            }
            else edNumeroIdMae.Enabled = false;
        }

        private void edNumeroIdMae_KeyUp(object sender, KeyEventArgs e)
        {
            //Habilitar textbox ######
            if (edNumeroIdMae.TextLength != 0)
            {
                btSalvar.Enabled = true;
            }
            else btSalvar.Enabled = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
