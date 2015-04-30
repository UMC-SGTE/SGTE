using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SGTE_UMC.Models;
using System.ComponentModel.DataAnnotations;
using SGTE_UMC.Models.Repositório;
using System.Data.SqlClient;

//Teste commmm
namespace SGTE_UMC.Models
{
    public class Funcionario
    {
        SGTEDBDataContext contexto = new SGTEDBDataContext();

        public int Id { get; set; }
        public string Funcao { get; set; }

        [Required(ErrorMessage = "Insira a matricula")]
        public int Matricula { get; set; }

        [Required(ErrorMessage = "Insira o Nome")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
               "Números e caracteres especiais não são permitidos no nome.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Insira o Endereço")]

        public string Endereco { get; set; }
        [Required(ErrorMessage = "Insira o Bairro")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "Insira a Cidade")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Insira o CEP")]
        public string CEP { get; set; }
        [Required(ErrorMessage = "Insira o Estado")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Insira o Telefone Residêncial")]
        public string Tel_Residencial { get; set; }
        [Required(ErrorMessage = "Insira o telefone Celular")]
        public string Tel_Celular { get; set; }

        [Required(ErrorMessage = "Insira o Email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Insira lo RG")]
        public string RG { get; set; }

        [Required(ErrorMessage = "Insira o CPF")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Insira a Data de Nascimento")]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public System.DateTime Data_Nasc { get; set; }

        [Required(ErrorMessage = "Insira o Sexo")]
        public string Sexo { get; set; }

      



        public List<Funcionario> ListarFuncionarios()
        {
            
            List<Funcionario> lista = new List<Funcionario>();
            var consulta = contexto.stp_ListarFuncionario();

            foreach (var funcionario in consulta)
            {
                Funcionario a = new Funcionario();
                a.Id = funcionario.ID;
                a.Funcao = funcionario.Funcao;
                a.Nome = funcionario.Nome;
                a.Endereco = funcionario.Endereco;
                a.Bairro = funcionario.Bairro;
                a.Cidade = funcionario.Cidade;
                a.CEP = funcionario.CEP;
                a.Estado = funcionario.Estado;
                a.Tel_Residencial = funcionario.Tel_Residencial;
                a.Tel_Celular = funcionario.Tel_Celular;
                a.Email = funcionario.Email;
                a.RG = funcionario.RG;
                a.CPF = funcionario.CPF;
                a.Data_Nasc = funcionario.Data_Nasc;
                a.Sexo = a.Sexo;

                lista.Add(a);
                
            }
            return lista;
        }

        public string Inserir(Funcionario a)
        {
            string resultado = String.Empty;

            try
            {
                contexto.stp_CadastroFuncionario(a.Id, a.Funcao, a.Matricula, a.Nome, a.Endereco, a.Cidade, a.Bairro, a.CEP, a.Estado, a.Tel_Residencial, a.Tel_Celular, a.Email, a.RG, a.CPF, a.Data_Nasc, a.Sexo, null, 2, null);
                resultado = "OK";

            }
            catch (Exception ex)
            {
                resultado = ex.Message;

            }

            return resultado;
            
        }

        public Funcionario BuscarFuncionario(string cpf) {

            Funcionario a = new Funcionario();
            try
            {
                var consulta = contexto.stp_BuscarFuncionario(cpf);

                foreach (var funcionario in consulta)
                {
                  
                    a.Id = funcionario.ID;
                    a.Funcao = funcionario.Funcao;
                    a.Nome = funcionario.Nome;
                    a.Endereco = funcionario.Endereco;
                    a.Bairro = funcionario.Bairro;
                    a.Cidade = funcionario.Cidade;
                    a.CEP = funcionario.CEP;
                    a.Estado = funcionario.Estado;
                    a.Tel_Residencial = funcionario.Tel_Residencial;
                    a.Tel_Celular = funcionario.Tel_Celular;
                    a.Email = funcionario.Email;
                    a.RG = funcionario.RG;
                    a.CPF = funcionario.CPF;
                    a.Data_Nasc = funcionario.Data_Nasc;
                    a.Sexo = a.Sexo;
                   
                }

            }
            catch (Exception)
            {
                throw;
            }
            return a;
    
        }

        //Método para desativar um funcionario no Bando de dados (Set Ativo = 0);
        public string DesativarFuncioanrio(string cpf) 
        {
            string resultado = String.Empty;
            try{
                contexto.stp_DesativarFuncionario(cpf);
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