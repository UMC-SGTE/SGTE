using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; 


namespace SGTE.Dominio
{
    class Cliente
    {
        [Required]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Endereco { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public System.DateTime Data_Nasc { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public Nullable<int> Ativo { get; set; }
    }
}
