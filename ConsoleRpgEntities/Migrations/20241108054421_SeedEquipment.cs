using System.Collections.Generic;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore.Migrations;
using static System.Net.Mime.MediaTypeNames;

#nullable disable

namespace ConsoleRpgEntities.Migrations
{
    public partial class SeedEquipment : BaseMigration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.Sql(@"
            //set IDENTITY_INSERT Items ON;
            //insert into Items(Id, Name, Type, Value, Defense, [Restore], Damage)
            //values
            //(1, 'Hero Blade', 'Weapon', 100, null, null, 3),
            //(2, 'Obsidian Armor', 'Armor', 50, 1, null, null),
            //(3, 'Health Potion', 'Consumable', 5, null, 3, null)
            //set IDENTITY_INSERT Items OFF;
            
            //insert into Equipment
            //values
            //(1, 1, 2, 3, 3)
            //");

            RunSql(migrationBuilder);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.Sql(@"
            //delete from Equipment
            //delete from Items
            //");

            RunSqlRollback(migrationBuilder);
        }
    }
}
