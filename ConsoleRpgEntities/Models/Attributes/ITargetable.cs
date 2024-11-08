namespace ConsoleRpgEntities.Models.Attributes;

public interface ITargetable
{
    string Name { get; set; }
    int Health { get; set; }

    public void ApplyDamage(int damage)
    {
        if (damage > 0)
        {
            Health -= damage;
            if (Health <= 0)
            {
                Health = 0;
                Console.WriteLine($"{Name} takes {damage} damage. They now have died.");
            }
            else
            {
                Console.WriteLine($"{Name} takes {damage} damage. They now have {Health} health remaining.");
            }
        }
    }

    public bool LifeCheck()
    {
        if (Health > 0)
            return true;
        else
            return false;
    }
}
