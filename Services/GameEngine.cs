using W5_assignment_template.Interfaces;
using W5_assignment_template.Models;

namespace W5_assignment_template.Services
{
    public class GameEngine
    {
        private readonly IEntity _character;
        private readonly IEntity _goblin;
        private readonly IEntity _ghost;
        private readonly IEntity _archer;
        private readonly IEntity _mage;

        public GameEngine(IEntity character, IEntity goblin, IEntity ghost, IEntity archer, IEntity mage)
        {
            _character = character;
            _goblin = goblin;
            _ghost = ghost;
            _archer = archer;
            _mage = mage;
        }

        public void Run()
        {
            _character.Name = "Hero";
            _goblin.Name = "Goblin";
            _ghost.Name = "Ghost";
            _archer.Name = "Archer";
            _mage.Name = "Mage";

            _character.Move();
            _character.Attack(_goblin);
            if (_character is ICastable castableCharacter)
            {
                castableCharacter.CastSpell("Fireball");
            }
            if (_character is IShootable shootableCharacter)
            {
                shootableCharacter.Shoot();
            }
            if (_character is IFlyable flyableCharacter)
            {
                flyableCharacter.Fly();
            }

            _goblin.Move();
            _goblin.Attack(_character);
            if (_goblin is ICastable castableGoblin)
            {
                castableGoblin.CastSpell("Dark Magic");
            }
            if (_goblin is IShootable shootableGoblin)
            {
                shootableGoblin.Shoot();
            }
            if (_goblin is IFlyable flyableGoblin)
            {
                flyableGoblin.Fly();
            }

            _ghost.Move();
            _ghost.Attack(_character);
            if (_ghost is ICastable castableGhost)
            {
                castableGhost.CastSpell("Haunt");
            }
            if (_ghost is IShootable shootableGhost)
            {
                shootableGhost.Shoot();
            }
            if (_ghost is IFlyable flyableGhost)
            {
                flyableGhost.Fly();
            }

            _archer.Move();
            _archer.Attack(_goblin);
            if (_archer is ICastable castableArcher)
            {
                castableArcher.CastSpell("Arrow Rain");
            }
            if (_archer is IShootable shootableArcher)
            {
                shootableArcher.Shoot();
            }
            if (_archer is IFlyable flyableArcher)
            {
                flyableArcher.Fly();
            }

            _mage.Move();
            _mage.Attack(_ghost);
            if (_mage is ICastable castableMage)
            {
                castableMage.CastSpell("Lightning Bolt");
            }
            if (_mage is IShootable shootableMage)
            {
                shootableMage.Shoot();
            }
            if (_mage is IFlyable flyableMage)
            {
                flyableMage.Fly();
            }
        }
    }
}
