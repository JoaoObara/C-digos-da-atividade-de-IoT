using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonitoramentoDeAnimais.RegrasDeNegocio;
using MonitoramentoDeAnimais.Contexto;
using ClassMsg;

namespace MonitoramentoDeAnimais.Formularios
{
    public partial class FormExibir : Form
    {
        //Iniciar lista e objeto de msg ####################
        List<Animal> lista = Context.listaAnimais;
        Msg msg = new Msg("!!Aviso!!");

        // Metodo para carregar os dados #####################
        public void CarregarDados() 
        {
            bindingSource1.DataSource = lista;
            cbBuscar.DataSource = bindingSource1;
            cbBuscar.DisplayMember = "NumeroId";
            cbBuscar.SelectedIndex = -1;
            cbBuscar.Select();
        }

        public FormExibir()
        {
            InitializeComponent();
            CarregarDados();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            // Carregar objeto com dados selecionados ################
            Animal objAnimal = new Animal();
            objAnimal = lista.ToList().ElementAt(bindingSource1.Position); 
            edDataNasc.Text = Convert.ToString(objAnimal.DataNasc);
            edEstado.Text = Convert.ToString(objAnimal.Estado);
            edNumeroId.Text = Convert.ToString(objAnimal.NumeroId);
            edNumeroIdPai.Text = Convert.ToString(objAnimal.NumeroIdPai);
            edNumeroIdMae.Text = Convert.ToString(objAnimal.NumeroIdMae);
            edPeso.Text = Convert.ToString(objAnimal.Peso);
            edSexo.Text = Convert.ToString(objAnimal.Sexo);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            //Confirmar exclusão ###################
            string resposta = msg.Questao("Deseja mesmo EXCLUIR o animal?");
            if (resposta == "Yes")
            {
                lista.RemoveAt(bindingSource1.Position);
                msg.Informacao("Animal excluído");
            } 
            else msg.Informacao("Exclusão cancelada");

            //Limpar e atualizar ###############
            edDataNasc.Clear();
            edEstado.Clear();
            edNumeroId.Clear();
            edNumeroIdMae.Clear();
            edNumeroIdPai.Clear();
            edSexo.Clear();
            edPeso.Clear();
            cbBuscar.Select();
            CarregarDados();
        }

        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
