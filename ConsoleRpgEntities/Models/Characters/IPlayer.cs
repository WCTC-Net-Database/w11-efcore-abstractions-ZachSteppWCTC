using ConsoleRpgEntities.Models.Abilities.PlayerAbilities;
using ConsoleRpgEntities.Models.Attributes;
using ConsoleRpgEntities.Models.Items;

namespace ConsoleRpgEntities.Models.Characters;

public interface IPlayer
{
    int Id { get; set; }
    int Health { get; set; }
    string Name { get; set; }

    IEnumerable<Ability> Abilities { get; set; }
    Equipment? Equipment { get; set; }
    void Attack(ITargetable target);
    void UseAbility(IAbility ability, ITargetable target);
    void UseHeal();


}
