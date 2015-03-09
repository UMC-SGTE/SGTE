using SGTE_UMC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SGTE_UMC.Models;
using System.Data.SqlClient;
using SGTE_UMC.Models.Repositório;

namespace SGTE_UMC.Controllers
{
    public class FuncionarioController : Controller
    {
        Contexto a = new Contexto();
                

        public Funcionario model = new Funcionario();
        // GET: Funcionario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Funcionario a)
        {
            
            if (ModelState.IsValid)
            {

                string strQueryInsertFuncionario = @"INSERT INTO Tbl_Funcionario(Funcao,Matricula,Nome,Endereco,Bairro,Cidade,CEP,Estado,Tel_Residencial,Tel_Celular,Email,RG,CPF,Data_Nasc,Sexo)
                                         VALUES(" + "'" + a.Funcao + "'" + "," + a.Matricula + "," + "'" + a.Nome + "'" + "," + "'" + a.Endereco + "'" + "," +
                                               "'" + a.Bairro + "'" + "," + "'" + a.Cidade + "'" + "," + "'" + a.CEP + "'" + "," + "'" + a.Estado + "'" + "," + "'" + a.Tel_Residencial + "'" + ","
                                                + "'" + a.Tel_Celular + "'" + "," + "'" + a.Email + "'" + "," + "'" + a.RG + "'" + "," + "'" + a.CPF + "'" + "," + "'" + a.Data_Nasc + "'" + "," + "'" + a.Sexo + "'" + ");" +
                                                    "INSERT INTO Tbl_Login(Login,Senha,Nivel_Acesso) VALUES(" + "'" + a.Email + "'" + "," + "'" + a.Matricula + "'" + "," + "1);";
                SqlCommand cmdComandoInsertFuncionario = new SqlCommand(strQueryInsertFuncionario);
                cmdComandoInsertFuncionario.ExecuteNonQuery();

                
            }
            return RedirectToAction("Create");
            //try
            //{
            //    if (model.Inserir(a).Equ)
            //    {
            //        return RedirectToAction("Index");
            //    }
            //    else
            //    {
            //        return RedirectToAction("Create");
            //    }
            //}
            //catch
            //{
            //    return View();
            //}
        }


    }
}