using Microsoft.AspNetCore.Mvc;

namespace ProjetoRec.Controllers
{
    [Route("Cadastro")]
    public class CadastroController : Controller
    {
        public IActionResult Index => View();
        [Route("Cadastro")]
        
         public IActionResult Index()
         {
             return View();
         }
         
     }
}