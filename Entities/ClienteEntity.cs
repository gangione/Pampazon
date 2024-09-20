namespace Pampazon.Entities;

public class ClienteEntity
{
    public string Numero { get; set; }
    public string Nombre { get; set; }
    public string Cuit {  get; set; }

    public string CalleNumero {  get; set; }
    public string Departamento { get; set; }
    public string Ciudad { get; set; }
    public string Provincia { get; set; }
    public string CodigoPostal { get; set; }

    public override bool Equals(object obj)
    {
        ClienteEntity cliente = obj as ClienteEntity;
        return cliente.Numero == Numero;
    }
}