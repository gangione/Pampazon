namespace Pampazon.ModuloOperaciones.Recepcion.RecepcionarMercaderia.Dtos;

public class Cliente
{
    public long Numero { get; set; }
    public string Nombre { get; set; }
    public string Cuit { get; set; }
    public override bool Equals(object obj)
    {
        Cliente cliente = obj as Cliente;
        return cliente.Numero == Numero;
    }
}