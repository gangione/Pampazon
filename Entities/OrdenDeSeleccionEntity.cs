namespace Pampazon.Entities;

public class OrdenDeSeleccionEntity
{
    public long Numero { get; set; }

    public Prioridad Prioridad { get; set; }
}

public enum Prioridad
{
    Alta,
    Media,
    Baja
}