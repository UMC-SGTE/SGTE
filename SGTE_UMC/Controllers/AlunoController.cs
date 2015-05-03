using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SGTE_UMC.Models;
using SGTE_UMC.Models.Repositório;

namespace SGTE_UMC.Controllers
{
    public class AlunoController : Controller
    {

        Contexto a = new Contexto();

        public Aluno model = new Aluno();

        //Método para gerar uma lista de Alunos
        public ActionResult ListarAlunos()
        {

            return View(model.ListarAlunos());
        }


        //------- Método para cadastro de novo Alunop
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Aluno a)
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