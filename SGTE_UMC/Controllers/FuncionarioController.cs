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

        public ActionResult ListarFuncioanrios() {

            return View(model.ListarFuncionarios());
        
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