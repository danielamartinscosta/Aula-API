using api.ModelViews;
using Microsoft.AspNetCore.Mvc;

namespace EstudoAPI._07._01.Controllers;

[ApiController]

public class HomeController : ControllerBase
{

    [Route("/")]
    [HttpGet]
    public ActionResult Index() //como não vai usar banco de dados, deixa como sem ser assincrono
    {
        return StatusCode(200, new Home{  //esse Home é a tipagem que vem la da ModelViews
            Mensagem = "Bem vindo a minha API"
        });
    }
}
