using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
{
    public class Mage : IEntity, ICastable
    {
        public string Name { get; set; }

        public void Move()
        {
            Console.WriteLine($"{Name} glides forward.");
        }

        public void Attack(IEntity target)
        {
            Console.WriteLine($"{Name} attacks {target.Name}.");
        }

        public void CastSpell(string spellName)
        {
            Console.WriteLine($"{Name} casts {spellName}.");
        }
    }
}
