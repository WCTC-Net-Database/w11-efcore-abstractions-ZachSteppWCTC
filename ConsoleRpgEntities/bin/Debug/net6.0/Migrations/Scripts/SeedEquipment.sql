set IDENTITY_INSERT Items ON;
insert into Items (Id, Name, Type, Value, Defense, [Restore], Damage)
values
(1, 'Hero Blade', 'Weapon', 100, null, null, 3),
(2, 'Obsidian Armor', 'Armor', 50, 1, null, null),
(3, 'Health Potion', 'Consumable', 5, null, 3, null)
set IDENTITY_INSERT Items OFF;

insert into Equipment
values
(1, 1, 2, 3, 3)