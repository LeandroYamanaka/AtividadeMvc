using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoMVC.Models;
using Microsoft.AspNetCore.Http;

namespace ProjetoMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Passeios()
        {
            return View();
        }
        public IActionResult Fotos()
        {
            return View();
        }
        public IActionResult Restaurantes()
        {
            return View();
        }

        public IActionResult Agendamento()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Agendamento(Usuario u)
        {
            BaseDados cadastro = new BaseDados();
            cadastro.Insert(u);
            ViewBag.Mensagem = "Agendamento Realizado !";
            return View();
        }

        public IActionResult ComoChegar()
        {
            return View();
        }
        public IActionResult Contato()
        {
            return View();
        }
        public IActionResult Depoimento()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Depoimento(Depoimento d)
        {
            DepoRepository depoimento = new DepoRepository();
            depoimento.Insert(d);
            ViewBag.Mensagem = "Depoimento Cadastrado!";

            return View();
        }

        public IActionResult ListaDepoimento()
        {
            DepoRepository depoimento = new DepoRepository();
            List<Depoimento> listaDepo = depoimento.Listar();
            return View(listaDepo);
        }

        public IActionResult Cadastro()
        {
            BaseDados cadastro = new BaseDados();
            List<Usuario> list = cadastro.Listar();
            return View(list);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
