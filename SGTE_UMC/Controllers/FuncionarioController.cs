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

        //Método para gerar uma lista de funcionarios
        public ActionResult ListarFuncioanrios() {

            return View(model.ListarFuncionarios());  
        }

        //Método que retorna detalhes de um funcionario consultado.
        public ActionResult Details(string c = "36898877787") //recebe o cpf da modelo Funcionario, a string declarada é apenas um teste! remover e deixar apenas a variavel c
        {
            var funcionario = model.BuscarFuncionario(c);
            return View(funcionario);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Funcionario a)
        {
                                  
            try
            {
                if (model.Inserir(a).Equals("OK"))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Create");  
                }
            }
            catch
            {
                return View();
            }
            
        }


    }
}