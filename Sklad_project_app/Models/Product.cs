namespace Sklad_project_2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Article { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int UnitId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual Stock Stock { get; set; }
    }
}