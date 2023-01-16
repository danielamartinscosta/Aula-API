using api.Models;
using Microsoft.AspNetCore.Mvc;
using api.Repositorios.Interface;


namespace api.Controllers;

[Route("clientes")] //rota
public class ClientesController : ControllerBase
{

    private IServico _servico; //esse servico vai receber por injeção de dependencia no controlador

    public ClientesController(IServico servico)
    {
        _servico = servico;

    }
    // GET: Clientes
    [Route("")] //complemento da Rota ex. se eu digitar clientes + nada (pq tá vazio""), vem para a rota de clientes
    [HttpGet]

    //[HttpGet("")] // o item acima pode ser represantado assim também
    public IActionResult Index()
    {

        var clientes = _servico.Todos();
        return StatusCode(200, clientes);


    }

    // com a rota de cima + a rota de baixo, mostra detalhes do cliente. Ex: clientes/id

    [HttpGet("{id}")]
    public IActionResult Details([FromRoute] int id)
    {
        var cliente = _servico.Todos().Find(c => c.Id == id);

        return StatusCode(200, cliente);
    }




    // POST: Clientes
    [HttpPost("")]
    //[ValidateAntiForgeryToken] //essa validação é usanda quando se trabalha com formulario
    public IActionResult Create([FromBody] Cliente cliente)
    {
        _servico.Incluir(cliente);
        return StatusCode(201, cliente);
    }



    // PUT: Clientes/5
    [HttpPut("{id}")]
    public IActionResult Update([FromRoute] int id, [FromBody] Cliente cliente)
    {
        if (id != cliente.Id)
        {
            return StatusCode(400, new
            {

                Mensagem = "O id do cliente precisa bater com o id da URL"
            });
        }

        var clienteDb = _servico.Atualizar(cliente);

        return StatusCode(200, clienteDb);

    }

    // POST: Clientes/5
    [HttpDelete("{id}")]
    public IActionResult Delete([FromRoute] int id)
    {
        var clienteDb = _servico.Todos().Find(c => c.Id == id);

        if (clienteDb is null)
        {
            return StatusCode(404, new
            {

                Mensagem = "Cliente não encontrado"

            });

        }
        _servico.Apagar(clienteDb);

        return RedirectToAction(nameof(Index));
    }


}

