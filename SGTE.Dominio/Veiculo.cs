using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGTE.Dominio
{
    class Veiculo
    {
        public int Cod_Veiculo { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Renavam { get; set; }
        public string Cidade { get; set; }
        public string Licenca { get; set; }
        public string Chassi { get; set; }
        public string Ano_Fabricacao { get; set; }
        public int Num_Lugares { get; set; }
        public int Lugares_Vagos { get; set; }
    }
}
