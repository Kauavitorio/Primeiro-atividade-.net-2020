using Atividade01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Atividade01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Test()
        {
            return View();
        }

        public ActionResult escola()
        {
            return View();
        }

        public ActionResult opini()
        {
            return View();
        }

        public ActionResult calc()
        {
            return View();
        }

        public ActionResult Contato()
        {
            Pessoa pessoa = new Pessoa()
            {
                PessoaId = 1,
                Nome = "Kauã",
                Tipo = "Administrador"
            };
            ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Tipo"] = pessoa.Tipo;
            return View();
        }
    }
}
