using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonitoramentoDeAnimais.Formularios;

namespace MonitoramentoDeAnimais
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void BtRelatorio_Click(object sender, EventArgs e)
        {
            FormEmitirRelatorio fr = new FormEmitirRelatorio();
            fr.ShowDialog();
        }

        private void BtCadastrarAnimal_Click(object sender, EventArgs e)
        {
            FormCadastrarAnimal fr = new FormCadastrarAnimal();
            fr.ShowDialog();
        }

        private void btExibir_Click(object sender, EventArgs e)
        {
            FormExibir fr = new FormExibir();
            fr.ShowDialog();
        }

        private void btMonitorar_Click(object sender, EventArgs e)
        {
            FormMonitorar fr = new FormMonitorar();
            fr.ShowDialog();
        }
    }
}
