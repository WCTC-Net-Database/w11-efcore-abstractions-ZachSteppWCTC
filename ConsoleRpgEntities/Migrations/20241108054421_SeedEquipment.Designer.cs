﻿// <auto-generated />
using System;
using ConsoleRpgEntities.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsoleRpgEntities.Migrations
{
    [DbContext(typeof(GameContext))]
    [Migration("20241108054421_SeedEquipment")]
    partial class SeedEquipment
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AbilityPlayer", b =>
                {
                    b.Property<int>("AbilitiesId")
                        .HasColumnType("int");

                    b.Property<int>("PlayersId")
                        .HasColumnType("int");

                    b.HasKey("AbilitiesId", "PlayersId");

                    b.HasIndex("PlayersId");

                    b.ToTable("PlayerAbilities", (string)null);
                });

            modelBuilder.Entity("ConsoleRpgEntities.Models.Abilities.PlayerAbilities.Ability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AbilityType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Abilities");

                    b.HasDiscriminator<string>("AbilityType").HasValue("Ability");
                });

            modelBuilder.Entity("ConsoleRpgEntities.Models.Characters.Monsters.Monster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AggressionLevel")
                        .HasColumnType("int");

                    b.Property<int>("Health")
                        .HasColumnType("int");

                    b.Property<string>("MonsterType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Monsters");

                    b.HasDiscriminator<string>("MonsterType").HasValue("Monster");
                });

            modelBuilder.Entity("ConsoleRpgEntities.Models.Characters.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<int>("Health")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("ConsoleRpgEntities.Models.Items.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ArmorID")
                        .HasColumnType("int");

                    b.Property<int?>("ConsumableAmount")
                        .HasColumnType("int");

                    b.Property<int?>("ConsumableID")
                        .HasColumnType("int");

                    b.Property<int>("PlayerID")
                        .HasColumnType("int");

                    b.Property<int?>("WeaponID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArmorID");

                    b.HasIndex("ConsumableID");

                    b.HasIndex("PlayerID")
                        .IsUnique();

                    b.HasIndex("WeaponID");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("ConsoleRpgEntities.Models.Items.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasDiscriminator<string>("Type").HasValue("Item");
                });

            modelBuilder.Entity("ConsoleRpgEntities.Models.Abilities.PlayerAbilities.ShoveAbility", b =>
                {
                    b.HasBaseType("ConsoleRpgEntities.Models.Abilities.PlayerAbilities.Ability");

                    b.Property<int>("Damage")
                        .HasColumnType("int");

                    b.Property<int>("Distance")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("ShoveAbility");
                });

            modelBuilder.Entity("ConsoleRpgEntities.Models.Characters.Monsters.Goblin", b =>
                {
                    b.HasBaseType("ConsoleRpgEntities.Models.Characters.Monsters.Monster");

                    b.Property<int>("Sneakiness")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Goblin");
                });

            modelBuilder.Entity("ConsoleRpgEntities.Models.Items.Armor", b =>
                {
                    b.HasBaseType("ConsoleRpgEntities.Models.Items.Item");

                    b.Property<int>("Defense")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Armor");
                });

            modelBuilder.Entity("ConsoleRpgEntities.Models.Items.Consumable", b =>
                {
                    b.HasBaseType("ConsoleRpgEntities.Models.Items.Item");

                    b.Property<int>("Restore")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Consumable");
                });

            modelBuilder.Entity("ConsoleRpgEntities.Models.Items.Weapon", b =>
                {
                    b.HasBaseType("ConsoleRpgEntities.Models.Items.Item");

                    b.Property<int>("Damage")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Weapon");
                });

            modelBuilder.Entity("AbilityPlayer", b =>
                {
                    b.HasOne("ConsoleRpgEntities.Models.Abilities.PlayerAbilities.Ability", null)
                        .WithMany()
                        .HasForeignKey("AbilitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleRpgEntities.Models.Characters.Player", null)
                        .WithMany()
                        .HasForeignKey("PlayersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsoleRpgEntities.Models.Items.Equipment", b =>
                {
                    b.HasOne("ConsoleRpgEntities.Models.Items.Armor", "Armor")
                        .WithMany()
                        .HasForeignKey("ArmorID");

                    b.HasOne("ConsoleRpgEntities.Models.Items.Consumable", "Consumable")
                        .WithMany()
                        .HasForeignKey("ConsumableID");

                    b.HasOne("ConsoleRpgEntities.Models.Characters.Player", "Player")
                        .WithOne("Equipment")
                        .HasForeignKey("ConsoleRpgEntities.Models.Items.Equipment", "PlayerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleRpgEntities.Models.Items.Weapon", "Weapon")
                        .WithMany()
                        .HasForeignKey("WeaponID");

                    b.Navigation("Armor");

                    b.Navigation("Consumable");

                    b.Navigation("Player");

                    b.Navigation("Weapon");
                });

            modelBuilder.Entity("ConsoleRpgEntities.Models.Characters.Player", b =>
                {
                    b.Navigation("Equipment");
                });
#pragma warning restore 612, 618
        }
    }
}
