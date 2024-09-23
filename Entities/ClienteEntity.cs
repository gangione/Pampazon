namespace Pampazon.Entities;

public class ClienteEntity
{
    public long Numero {  get; set; }
    public string Nombre { get; set; }
    public string Cuit { get; set; }
    public DomicilioEntity? Domicilio { get; set; }
    public override bool Equals(object obj)
    {
        ClienteEntity cliente = obj as ClienteEntity;
        return cliente.Numero == Numero;
    }
}