namespace Sklad_project_2.Models
{
    public class ShipmentItem
    {
        public int Id { get; set; }
        public int ShipmentId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public virtual Shipment Shipment { get; set; }
        public virtual Product Product { get; set; }
    }
}