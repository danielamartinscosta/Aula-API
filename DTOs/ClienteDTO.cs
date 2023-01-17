namespace api.DTOs;

public record ClienteDTO
{

    //[JsonPropertyName("Name")] modo de exibição
    
    public string Nome { get; set; } = default!;

    public string Email { get; set; } = default!;

    public string? Telefone { get; set; }

    public string? Endereco { get; set; }
}

