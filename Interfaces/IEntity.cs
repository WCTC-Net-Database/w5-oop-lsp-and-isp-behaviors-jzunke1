namespace W5_assignment_template.Interfaces
{
    public interface IEntity
    {
        string Name { get; set; }
        void Attack(IEntity target);
        void Move();
    }

}
