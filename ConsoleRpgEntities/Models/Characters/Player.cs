using ConsoleRpgEntities.Models.Abilities.PlayerAbilities;
using ConsoleRpgEntities.Models.Attributes;
using ConsoleRpgEntities.Models.Items;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleRpgEntities.Models.Characters
{
    public class Player : ITargetable, IPlayer
    {
        public int Experience { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public virtual IEnumerable<Ability> Abilities { get; set; }
        public virtual Equipment? Equipment { get; set; }
        public void Attack(ITargetable target)
        {
            // Player-specific attack logic
            if (Equipment != null) 
            {
                if (Equipment.Weapon != null)
                {
                    Console.WriteLine($"{Name} attacks {target.Name} with {Equipment.Weapon.Name} for {Equipment.Weapon.Damage} damage!");
                    target.ApplyDamage(Equipment.Weapon.Damage);
                }
                else
                {
                    Console.WriteLine($"{Name} attacks {target.Name} with their fists!");
                    target.ApplyDamage(1);
                }
            }
            else
            {
                Console.WriteLine($"{Name} attacks {target.Name} with their fists!");
                target.ApplyDamage(1);
            }
        }

        public void UseAbility(IAbility ability, ITargetable target)
        {
            if (Abilities.Contains(ability))
            {
                ability.Activate(this, target);
            }
            else
            {
                Console.WriteLine($"{Name} does not have the ability {ability.Name}!");
            }
        }
        public void UseHeal()
        {
            if (Equipment != null)
            {
                if (Equipment.Consumable != null)
                {
                    if (Equipment.ConsumableAmount > 0)
                    {
                        Health += Equipment.Consumable.Restore;
                        Equipment.ConsumableAmount -= 1;
                        Console.WriteLine($"{Name} uses a {Equipment.Consumable.Name} and restores {Equipment.Consumable.Restore}.");
                        Console.WriteLine($"{Name} has {Health} health and {Equipment.ConsumableAmount} {Equipment.Consumable.Name}s remaining.");
                    }
                    else
                    {
                        Console.WriteLine($"{Name} is out of {Equipment.Consumable.Name}s.");
                    }
                }
                else
                {
                    Console.WriteLine($"{Name} has no consumables.");
                }
            }
            else
            {
                Console.WriteLine($"{Name} has no consumables.");
            }
        }
        public int DefendDamage(int damage)
        {
            if (Equipment != null)
            {
                if (Equipment.Armor != null)
                {
                    if (damage - Equipment.Armor.Defense <= 0)
                    {
                        Console.WriteLine($"{Name}'s {Equipment.Armor.Name} blocks all of the damage.");
                        return 0;
                    }
                    else
                    {
                        damage -= Equipment.Armor.Defense;
                        Console.WriteLine($"{Name}'s {Equipment.Armor.Name} blocks {Equipment.Armor.Defense} damage.");
                        return damage;
                    }
                }
                else
                {
                    return damage;
                }
            }
            else
            {
                return damage;
            }
        }
    }
}
