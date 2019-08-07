using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMvcControllersActions.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreMvcControllersActions.Controllers
{
    public class PessoaController : Controller
    {
        public IActionResult Formulario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Formulario(Pessoa pessoa)
        {
            return View("Pessoa", pessoa);
        }
    }
}
