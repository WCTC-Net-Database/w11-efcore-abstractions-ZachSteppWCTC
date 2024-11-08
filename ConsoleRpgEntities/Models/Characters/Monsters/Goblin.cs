using ConsoleRpgEntities.Models.Attributes;

namespace ConsoleRpgEntities.Models.Characters.Monsters
{
    public class Goblin : Monster
    {
        public int Sneakiness { get; set; }

        public override void Attack(ITargetable target)
        {
            // Goblin-specific attack logic
            Console.WriteLine($"{Name} sneaks up and attacks {target.Name} for {BaseDamage} damage!");
            int damage = BaseDamage;
            if (target is Player _targetableplayer)
            {
                damage = _targetableplayer.DefendDamage(BaseDamage);
            }
            target.ApplyDamage(damage);
        }
    }
}
