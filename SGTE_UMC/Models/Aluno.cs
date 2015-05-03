using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SGTE_UMC.Models;
using SGTE_UMC.Models.Repositório;
using System.Data.SqlClient;

namespace SGTE_UMC.Models
{
    public class Aluno
    {
        SGTEDBDataContext contexto = new SGTEDBDataContext();

        public string Nome { get; set; }
        public string RG { get; set; }
        public string Escola { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Endereco_1 { get; set; }
        public string Endereco_2 { get; set; }
        public int matricula { get; set; }
        public Nullable<int> Cliente_ID { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Escola EscolaID { get; set; }




        //Método para gerar uma lista de Alunos cadastrados
        public List<Aluno> ListarAlunos()
        {

            List<Aluno> lista = new List<Aluno>();
            var consulta = contexto.stp_ListarAluno();

            foreach (var aluno in consulta)
            {
                Aluno a = new Aluno();

                a.Nome = aluno.Nome;
                a.RG = aluno.RG;
                a.Escola = aluno.Escola;
                a.Cidade = aluno.Cidade;
                a.Bairro = aluno.Bairro;
                a.CEP = aluno.CEP;
                a.Estado = aluno.Estado;
                a.Endereco_1 = aluno.Endereco_1;
                a.Endereco_2 = aluno.Endereco_2;

                lista.Add(a);

            }
            return lista;
        }


        // -----
        //Método para Cadastro de novo aluno.
        public string Inserir(Aluno a)
        {
            string resultado = String.Empty;

            try
            {
                contexto.stp_CadastroAluno(a.Cliente_ID,a.Cliente.Nome, a.Nome, a.Endereco_1, a.Endereco_2, a.RG,a.Escola,a.EscolaID.ID,a.matricula,"Tira isso alvaro!!");
                resultado = "OK";

            }
            catch (Exception ex)
            {
                resultado = ex.Message;

            }

            return resultado;

        }



    }

   
}