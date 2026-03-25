namespace Sklad_project_2.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public int Role_id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public virtual Role Role { get; set; }
    }
}