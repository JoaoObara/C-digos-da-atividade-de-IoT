using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoramentoDeAnimais.RegrasDeNegocio
{
    //Classe com os dados do animal #############
    
    public class Animal
    {
        public int NumeroId { get; set; }
        public int NumeroIdMae { get; set; }
        public int NumeroIdPai { get; set; }
        public DateTime DataNasc { get; set; }
        public string Sexo { get; set; }
        public string Estado { get; set; }
        public string Peso { get; set; }
    }
}
