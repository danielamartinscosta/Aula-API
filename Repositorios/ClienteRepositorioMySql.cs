using api.Models;

namespace api.Models;

public class ClienteRepositorioMySql
{

    //private pq o contrutor vai ser privado para que possa não criar uma instancia
    private ClienteRepositorioMySql() { // aqui, quando criar uma nova instacia, a lista de clientes ser preenchida
        Lista = new List<Cliente>();
    } 

    public List<Cliente> Lista = default!;

    private static ClienteRepositorioMySql? clienteRepositorio;

    public static ClienteRepositorioMySql Instancia() //toda vez que quiser usar essa class, terá um .Intanacia
    {
        if(clienteRepositorio is null) clienteRepositorio = new ClienteRepositorioMySql();
        return clienteRepositorio;
    } 
}

//essa é uma class singleton pois se tem uma única instancia