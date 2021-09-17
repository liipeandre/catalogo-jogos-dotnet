using System;
using System.ComponentModel;
using System.Net.Http;
using CatalogoJogos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoJogos.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class JogosController : Controller
    {
        [HttpGet]
        [HttpPost]
        [Route("insert")]
        public IActionResult Insert()
        {
            if (HttpMethods.IsGet(Request.Method))
                return View("~/views/jogos/insert.cshtml");

            var Jogo = new Jogo
            {
                Nome = Request.Form["nome"],
                IdCategoria = int.Parse(Request.Form["id_categoria"]),
                Joguei = Request.Form["joguei"] == "1"
            };

            if (!ModelState.IsValid) 
                return View("~/views/jogos/insert.cshtml");
            
            Jogo.Insert();
            ViewData["Message"] = "Operação realizada com sucesso";

            return View("~/views/jogos/insert.cshtml");
        }

        
        [HttpGet]
        [HttpPost]
        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var Jogo = new Jogo
            {
                IdJogo = id
            };

            if (ModelState.IsValid)
            {
                Jogo.Delete();
                ViewData["Message"] = "Operação realizada com sucesso";
            }
            else
            {
                ViewData["Message"] = "Erro ao realizar exclusão: Id inválido ou inexistente.";
            }
            
            ViewData["Data"] = Jogo.List();
            
            return View("~/views/jogos/list.cshtml");
        }
        
        
        [HttpGet]
        [Route("")]
        public IActionResult List()
        {
            var Jogo = new Jogo();
            
            ViewData["Data"] = Jogo.List();
            
            return View("~/views/jogos/list.cshtml");
        }

        
        [HttpGet]
        [HttpPost]
        [Route("edit/{id:int}")]
        public IActionResult Edit(int id)
        {
            Jogo Jogo;
            
            if (HttpMethods.IsGet(Request.Method))
            {
                Jogo = new Jogo
                {
                    IdJogo = id
                };

                if (!ModelState.IsValid)
                {
                    ViewData["Message"] = "Erro ao realizar consulta: Id inválido ou inexistente.";
                    return View("~/views/jogos/list.cshtml");
                } 
                    
                
                ViewData["Data"] = Jogo.View();
                return View("~/views/jogos/edit.cshtml");

            }

            Jogo = new Jogo
            {
                IdJogo = id,
                Nome = Request.Form["nome"],
                IdCategoria = int.Parse(Request.Form["id_categoria"]),
                Joguei = Request.Form["joguei"] == "1"
            };

            if (ModelState.IsValid)
            {
                Jogo.Edit();
                ViewData["Message"] = "Operação realizada com sucesso";
            }
            else
            {
                ViewData["Message"] = "Erro ao realizar alteração: Campos Inválidos";
            }
            
            ViewData["Data"] = Jogo.View();
            return View("~/views/jogos/edit.cshtml");
        }
    }
}