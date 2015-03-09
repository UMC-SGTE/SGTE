using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGTE_Repositorio
{
    public class Contexto : SGTEDATADataContext
    {
        public DbSet<Tbl_Funcionario> Funcionario { get; set; }


        
    }
}
