using api.Models;

namespace api.Repositorios.Interface;


public interface IServico
{
    Task<List<Cliente>> TodosAsync();

    Task IncluirAsync(Cliente cliente);
    Task<Cliente> AtualizarAsync(Cliente cliente);
    Task ApagarAsync(Cliente cliente);
}