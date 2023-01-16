using api.Models;
using api.Repositorios.Interface;

namespace api.Models;

public class ClienteRepositorio : IServico
{

    //private pq o contrutor vai ser privado para que possa não criar uma instancia

    private static List<Cliente> lista = new List<Cliente>();


    public List<Cliente> Todos()
    {
        return lista;
    }

    public void Incluir(Cliente cliente)
    {
        lista.Add(cliente);
    }

    public Cliente Atualizar(Cliente cliente)
    {

        if (cliente.Id == 0) throw new Exception("Id não pode ser zero");
        var clienteDb = lista.Find(c => c.Id == cliente.Id);

        if (clienteDb is null)
        {
            throw new Exception("Cliente informado não existe");

        }


        clienteDb.Nome = cliente.Nome;
        clienteDb.Endereco = cliente.Endereco;
        clienteDb.Telefone = cliente.Telefone;
        clienteDb.Email = cliente.Email;
        return clienteDb;
    }

    public void Apagar(Cliente cliente)
    {
        lista.Remove(cliente);
    }
}

//essa é uma class singleton pois se tem uma única instancia