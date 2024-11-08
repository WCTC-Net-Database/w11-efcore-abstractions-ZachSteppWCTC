using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleRpgEntities.Models.Characters;

namespace ConsoleRpgEntities.Models.Items
{
    public class Equipment
    {
        public int Id { get; set; }
        public virtual Player Player { get; set; }
        public int PlayerID { get; set; }
        public virtual Weapon? Weapon { get; set; }
        public int? WeaponID { get; set; }
        public virtual Armor? Armor { get; set; }
        public int? ArmorID { get; set; }
        public virtual Consumable? Consumable { get; set; }
        public int? ConsumableID { get; set; }
        public int? ConsumableAmount { get; set; }

    }
}
