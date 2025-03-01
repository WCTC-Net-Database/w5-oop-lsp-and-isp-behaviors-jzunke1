using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
{
    public class Archer : IEntity
    {
        public string Name { get; set; }

        public void Move()
        {
            Console.WriteLine($"{Name} moves.");
        }

        public void Attack(IEntity target)
        {
            Console.WriteLine($"{Name} shoots an arrow at {target.Name}.");
        }
    }
}
