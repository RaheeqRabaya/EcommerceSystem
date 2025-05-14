namespace ECommerceSystem.DataLayer.Entities
{
    public class Employee : Person
    {
        public string Role { get; set; }

        public Employee(int id, string name, string role)
            : base(id, name)
        {
            Role = role;
        }
    }
}
