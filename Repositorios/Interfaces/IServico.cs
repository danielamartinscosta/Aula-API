using api.Models;

namespace api.Repositorios.Interface;


public interface IServico
{
    List<Cliente> Todos();

    void Incluir(Cliente cliente);
    Cliente Atualizar(Cliente cliente);
    void Apagar(Cliente cliente);
}