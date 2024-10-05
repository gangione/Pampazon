namespace Pampazon.Entities
{
    public class OrdenDePreparacionEntity
    {
        public long Numero { get; set; }



        public List<MercaderiaEntity>? MercaderiasAPreparar { get; set; }
    }
}