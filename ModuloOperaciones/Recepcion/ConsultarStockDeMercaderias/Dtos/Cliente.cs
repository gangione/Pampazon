namespace Pampazon.ModuloOperaciones.Recepcion.ConsultarStockDeMercaderias.Dtos;

public class Cliente
{
    public long Numero { get; set; }
    public string Nombre { get; set; }
    public override string ToString()
    {
        return Nombre;
    }
}