namespace Sklad_project_2.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public decimal PurchasePrice { get; set; }
        public int Rest { get; set; }
        public virtual Product Product { get; set; }
    }
}