using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SGTE_UMC.Models.Repositório
{
    public class Contexto : SGTEDBDataContext
    {
        public DbSet<Tbl_Funcionario> Funcionario { get; set; }

        public DbSet<Tbl_Aluno> Aluno { get; set; }



    }
}