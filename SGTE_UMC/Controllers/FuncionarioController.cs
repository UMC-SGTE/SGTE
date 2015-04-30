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
        public ActionResult Details(string c = "46776647467") //recebe o cpf da modelo Funcionario, a string declarada é apenas um teste! remover e deixar apenas a variavel c
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



        //Busca Personalizada de funcionario
        public ActionResult BuscarFuncionario(string c = "46776647467") //recebe o cpf da modelo Funcionario, a string declarada é apenas um teste! remover e deixar apenas a variavel c
        {
            var funcionario = model.BuscarFuncionario(c);
            return View(funcionario);
        }





        //Desativa um funcionario do Sistema
        [HttpGet]
        public ActionResult DeletarFuncionario(string cpf = "54566644456") 
        {
            var funcionario = model.BuscarFuncionario(cpf);
            return View(funcionario);
        }

        [HttpPost]
        public ActionResult DeletarFuncionario(string cpf)
        {
            try
            {
                if (model.DesativarFuncioanrio(cpf).Equals("OK"))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("DeletarFuncionario");
                }
            }

            catch {
                return View();
            }
        }

        
    }
}