using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGTE_Repositorio;

namespace SGTE.Dominio
{
    class Aluno : Cliente
    {
        

        public string Nome { get; set; }
        public string RG { get; set; }
        public string Escola { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Endereco_1 { get; set; }
        public string Endereco_2 { get; set; }

        //Não esquecer de checar o Tbl.Aluno(SGTE V1.8) para o restante das opções

        //public void incluirAluno()
        //{
        //    SGTE2Entities db = new SGTE2Entities();

            


        //}
    }
}
