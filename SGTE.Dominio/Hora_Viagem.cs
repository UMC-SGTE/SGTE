using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGTE.Dominio
{
    class Hora_Viagem
    {
        public DateTime Data { get; set; }
        public string HoraReal_Embarque { get; set; }
        public string HoraReal_Desembarque { get; set; }
        public string HoraPrev_Embarque { get; set; }
        public string HoraPrev_Desembarque { get; set; }
    }
}
