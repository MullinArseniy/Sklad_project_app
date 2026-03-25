namespace Sklad_project_2.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Shipment> Shipments { get; set; }
    }
}
