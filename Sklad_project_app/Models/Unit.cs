namespace Sklad_project_2.Models
{
    public class Unit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}