using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonitoramentoDeAnimais.Contexto;
using MonitoramentoDeAnimais.RegrasDeNegocio;

namespace MonitoramentoDeAnimais.Formularios
{
    public partial class FormEmitirRelatorio : Form
    {
        //Carregando a lista ###################
        List<Animal> lista = Context.listaAnimais; 
        public FormEmitirRelatorio()
        {
            InitializeComponent();
            tbAnimais.AutoGenerateColumns = false;
            bindingSource1.DataSource = lista;
            tbAnimais.DataSource = lista;
            
        }

        private void tbAnimais_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormRelatorio fr = new FormRelatorio();
            fr.ShowDialog();
        }
    }
}
