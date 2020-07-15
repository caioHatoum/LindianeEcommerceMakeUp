using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LindianeEcommerceMakeUp.DAL;
using LindianeEcommerceMakeUp.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LindianeEcommerceMakeUp.Controllers
{
    public class CategoriaProdutoController : Controller
    {
        protected ApplicationDbContext Repositorio;
        public CategoriaProdutoController(ApplicationDbContext repositorio)
        {
            Repositorio = repositorio;
        }
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
