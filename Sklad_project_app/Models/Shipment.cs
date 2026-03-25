namespace Sklad_project_2.Models
{
    public class Shipment
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string UserId { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public virtual Client Client { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ShipmentItem> ShipmentItems { get; set; }
    }
}