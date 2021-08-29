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
using ClassMsg;

namespace MonitoramentoDeAnimais.Formularios
{
    public partial class FormRelatorio : Form
    {
        public FormRelatorio()
        {
            InitializeComponent();
            bsRelatorio.DataSource = Context.listaAnimais.ToList(); 
        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
