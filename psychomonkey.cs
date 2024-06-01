using MelonLoader;
using BTD_Mod_Helper;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Models.TowerSets;
using Il2CppAssets.Scripts.Simulation.Towers;
using Il2CppAssets.Scripts.Simulation.Towers.Weapons;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Unity.Display;
using Il2CppSystem.IO;
using BTD_Mod_Helper.Api.Enums;
using Il2CppAssets.Scripts.Simulation.Bloons;
using Il2CppAssets.Scripts.Simulation.Towers.Projectiles;
using Il2Cpp;
using BTD_Mod_Helper.Api;
using Il2CppAssets.Scripts.Models.Towers.Weapons.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Models.Towers.TowerFilters;
using Il2CppAssets.Scripts.Models.Map;
using System.Collections.Generic;
using System.Linq;
using Il2CppAssets.Scripts.Models.GenericBehaviors;
using Il2CppAssets.Scripts.Models.Towers.Filters;
using System.Runtime.CompilerServices;
using Il2CppAssets.Scripts.Models.Bloons.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppAssets.Scripts.Models;
using psychomonkey;
using Il2CppAssets.Scripts.Simulation.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Unity.Towers;
using static Displays.Displays;
using UnityEngine;

[assembly: MelonInfo(typeof(Psychomonkey.psychomonkey), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace Psychomonkey
{
    public class psychomonkey : BloonsTD6Mod
    {
        public override void OnApplicationStart()
        {
            ModHelper.Msg<psychomonkey>("Psychomonkey loaded!");
        }
        public override void OnWeaponFire(Weapon weapon)
        {
            if (weapon.attack.tower.towerModel.name.Contains("psychomonkey-Psychomonkey"))
            {
                weapon.attack.tower.Node.graphic.GetComponent<Animator>().SetTrigger("Punch");
            }
            if (weapon.attack.tower.towerModel.name.Contains("psychomonkey-Golem"))
            {
                weapon.attack.tower.Node.graphic.GetComponent<Animator>().SetTrigger("Punch");
            }
        }
        public class Psychomonkey : ModTower
        {
            public override string Portrait => "psychoicon";
            public override string Icon => "psychoicon";

            public override TowerSet TowerSet => TowerSet.Magic;
            public override string BaseTower => TowerType.DartMonkey;
            public override int Cost => 430;

            public override int TopPathUpgrades => 5;
            public override int MiddlePathUpgrades => 5;
            public override int BottomPathUpgrades => 5;
            public override string Description => "Uses Psychokinesis to launch and control Darts. Upgrades expand psychic powers to manipulate Earth, Time or superior Psychokinetic abilities";

            public override string DisplayName => "Psychomonkey";

            public override void ModifyBaseTowerModel(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<tower.basedisplay>();
                towerModel.radius = Game.instance.model.GetTower(TowerType.BoomerangMonkey).radius;
                towerModel.range += 12;
                var attackModel = towerModel.GetAttackModel();
                attackModel.range += 12;
                var projectile = attackModel.weapons[0].projectile;
                var agemodel = Game.instance.model.GetTowerFromId("SpikeFactory").GetAttackModel().weapons[0].projectile.GetBehavior<AgeModel>().Duplicate();
                projectile.ApplyDisplay<psychodart>();
                attackModel.weapons[0].Rate = 3.2f;
                attackModel.weapons[0].projectile.pierce = 6;
                attackModel.weapons[0].projectile.AddBehavior(Game.instance.model.GetTowerFromId("Adora 20").GetAttackModel().weapons[0].projectile.GetBehavior<AdoraTrackTargetModel>().Duplicate());
                attackModel.weapons[0].projectile.GetBehavior<TravelStraitModel>().Lifespan = 999999f;
                attackModel.weapons[0].projectile.GetBehavior<TravelStraitModel>().Speed = 2f;
                attackModel.weapons[0].projectile.scale *= 2;
                attackModel.weapons[0].projectile.ignoreBlockers = true;
                attackModel.weapons[0].projectile.canCollisionBeBlockedByMapLos = false;
                attackModel.attackThroughWalls = true;
                agemodel.lifespanFrames = 9999;
                agemodel.lifespan = 999999f;
                agemodel.rounds = 9999;
                projectile.AddBehavior(agemodel);
            }
        }
        public class psychodart : ModDisplay
        {
            public override string BaseDisplay => Generic2dDisplay;

            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                Set2DTexture(node, Name);
            }
        }
        public class spikes : ModDisplay
        {
            public override string BaseDisplay => Generic2dDisplay;

            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                Set2DTexture(node, Name);
            }
        }
        public class psyclone : ModDisplay
        {
            public override string BaseDisplay => Generic2dDisplay;

            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                Set2DTexture(node, Name);
            }
        }
        public class rift : ModDisplay
        {
            public override string BaseDisplay => Generic2dDisplay;

            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                Set2DTexture(node, Name);
            }
        }
        public class eq : ModDisplay
        {
            public override string BaseDisplay => Generic2dDisplay;

            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                Set2DTexture(node, Name);
            }
        }
        public class eqproj : ModDisplay
        {
            public override string BaseDisplay => Generic2dDisplay;

            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                Set2DTexture(node, Name);
            }
        }
        public class rock : ModDisplay
        {
            public override string BaseDisplay => Generic2dDisplay;

            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                Set2DTexture(node, Name);
            }
        }
        public class psychosandsdart : ModDisplay
        {
            public override string BaseDisplay => Generic2dDisplay;

            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                Set2DTexture(node, Name);
            }
        }
        public class knife : ModDisplay
        {
            public override string BaseDisplay => Generic2dDisplay;

            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                Set2DTexture(node, Name);
            }
        }
        public class sword : ModDisplay
        {
            public override string BaseDisplay => Generic2dDisplay;

            public override void ModifyDisplayNode(UnityDisplayNode node)
            {
                Set2DTexture(node, Name);
            }
        }
        public class u010 : ModUpgrade<Psychomonkey>
        {
            public override int Path => MIDDLE;
            public override int Tier => 1;
            public override int Cost => 230;
            public override string Portrait => "010copy";
            public override string Icon => "u010";
            public override string DisplayName => "Speedy-Kinesis";
            public override string Description => "Launches darts faster";

            public override void ApplyUpgrade(TowerModel tower)
            {
                tower.ApplyDisplay<tower.display010>();
                var attackModel = tower.GetAttackModel();
                attackModel.weapons[0].Rate -= 0.1f;
            }
        }
        public class u020 : ModUpgrade<Psychomonkey>
        {
            public override int Path => MIDDLE;
            public override int Tier => 2;
            public override int Cost => 400;
            public override string Portrait => "020copy";
            public override string Icon => "u020";
            public override string DisplayName => "Diversion";
            public override string Description => "Darts can sometimes distract Bloons";
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<tower.display020>();
                var attackModel = towerModel.GetAttackModel();
                attackModel.weapons[0].Rate -= 0.2f;
                var Knockback = Game.instance.model.GetTowerFromId("NinjaMonkey-010").GetWeapon().projectile.GetBehavior<WindModel>().Duplicate<WindModel>();
                attackModel.weapons[0].projectile.AddBehavior(Knockback);
            }
        }
        public class u100 : ModUpgrade<Psychomonkey>
        {
            public override int Path => TOP;
            public override int Tier => 1;
            public override int Cost => 300;
            public override string Portrait => "100copy";
            public override string Icon => "u100";
            public override string DisplayName => "Hyper-Sense";
            public override string Description => "Increases range and allows the Psychomonkey to detect and attack Camo Bloons";

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<tower.display100>();
                towerModel.range += 4;
                var attackModel = towerModel.GetAttackModel();
                attackModel.range += 4;
                towerModel.AddBehavior(new OverrideCamoDetectionModel("CamoDetect", true));
                towerModel.GetAttackModel().AddBehavior(new TargetFirstPrioCamoModel("FirstPrioCamo", true, false));
                towerModel.GetAttackModel().AddBehavior(new TargetLastPrioCamoModel("LastPrioCamo", true, false));
                towerModel.GetAttackModel().AddBehavior(new TargetClosePrioCamoModel("ClosePrioCamo", true, false));
                towerModel.GetAttackModel().AddBehavior(new TargetStrongPrioCamoModel("StrongPrioCamo", true, false));
                towerModel.towerSelectionMenuThemeId = "Camo";
            }
        }
        public class u200 : ModUpgrade<Psychomonkey>
        {
            public override int Path => TOP;
            public override int Tier => 2;
            public override int Cost => 700;
            public override string Portrait => "200copy";
            public override string Icon => "u200";
            public override string DisplayName => "Telekinespikes";
            public override string Description => "Can now place road spikes that can remove camo properties.";
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<tower.display200>();
                var spikes = Game.instance.model.GetTowerFromId("ObynGreenfoot 3").GetAbility().GetBehavior<ActivateAttackModel>().attacks[0].Duplicate();
                spikes.weapons[0].Rate = 4.1f;
                spikes.weapons[0].projectile.GetDamageModel().damage = 1;
                spikes.weapons[0].projectile.RemoveBehavior<CreateEffectOnExhaustedModel>();
                spikes.weapons[0].projectile.pierce = 4;
                spikes.weapons[0].projectile.maxPierce = 5f;
                spikes.weapons[0].projectile.GetBehavior<AgeModel>().Lifespan = 17f;
                spikes.weapons[0].projectile.ApplyDisplay<spikes>();
                var decamo = Game.instance.model.GetTowerFromId("NinjaMonkey-020").GetWeapon().projectile.GetBehavior<RemoveBloonModifiersModel>().Duplicate<RemoveBloonModifiersModel>();
                decamo.cleanseCamo = true;
                spikes.weapons[0].projectile.AddBehavior(decamo);
                towerModel.AddBehavior(spikes);
                foreach (var weaponModel in towerModel.GetWeapons())
                {
                    spikes.weapons[0].projectile.collisionPasses = new int[] { 0, -1 };
                }

            }
        }
        public class u001 : ModUpgrade<Psychomonkey>
        {
            public override int Path => BOTTOM;
            public override int Tier => 1;
            public override int Cost => 425;
            public override string Portrait => "001copy";
            public override string Icon => "u001";
            public override string DisplayName => "Mindbreaker";
            public override string Description => "Each Dart can pop +1 Bloon layer";

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<tower.display001>();
                var attackModel = towerModel.GetAttackModel();
                var projectile = attackModel.weapons[0].projectile;
                projectile.GetDamageModel().damage += 1;

            }
        }
        public class u002 : ModUpgrade<Psychomonkey>
        {
            public override int Path => BOTTOM;
            public override int Tier => 2;
            public override int Cost => 350;
            public override string Portrait => "002copy";
            public override string Icon => "u002";
            public override string DisplayName => "Psyche Surge";
            public override string Description => "Darts now can pierce through more Bloons";

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<tower.display002>();
                var attackModel = towerModel.GetAttackModel();
                var projectile = attackModel.weapons[0].projectile;
                projectile.pierce += 2;

            }
        }

        public class u300 : ModUpgrade<Psychomonkey>
        {
            public override int Path => TOP;
            public override int Tier => 3;
            public override int Cost => 1100;
            public override string Portrait => "300copy";
            public override string Icon => "u300";
            public override string DisplayName => "Psyclone Disk";
            public override string Description => "Sometimes casts a Psyclone Disk attack that jumps from Bloon to Bloon.";
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<tower.display300>();
                var disk = Game.instance.model.GetTowerFromId("BoomerangMonkey-400").GetAttackModel().Duplicate();
                disk.weapons[0].projectile.ApplyDisplay<psyclone>();
                disk.weapons[0].Rate = 3.88f;
                disk.weapons[0].projectile.pierce = 20;
                disk.weapons[0].projectile.GetDamageModel().damage = 3;
                disk.weapons[0].projectile.scale += 0.3f;
                disk.range = 99999999;
                disk.weapons[0].projectile.GetDamageModel().immuneBloonProperties = BloonProperties.Purple;
                disk.weapons[0].projectile.GetDamageModel().immuneBloonProperties = BloonProperties.Lead;
                disk.name = "psyclonedisk";
                towerModel.AddBehavior(disk);
            }
        }
        public class u400 : ModUpgrade<Psychomonkey>
        {
            public override int Path => TOP;
            public override int Tier => 4;
            public override int Cost => 10400;
            public override string Portrait => "400copy";
            public override string Icon => "u400";
            public override string DisplayName => "Neo Bladesurge";
            public override string Description => "Rapidly Launches knives which deal high damage to weaker MOAB Bloons and sometimes Swords which penetrate all Bloons.";
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<tower.display400>();
                towerModel.range += 20;
                var attackModel = towerModel.GetAttackModel();
                attackModel.range += 20;
                var neuroknife = Game.instance.model.GetTowerFromId("DartMonkey-100").GetAttackModel().Duplicate();
                neuroknife.weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("Moab", "Moab", 1, 12, false, true));
                neuroknife.weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("Bfb", "Bfb", 1, 13, false, true));
                neuroknife.weapons[0].Rate = 0.35f;
                neuroknife.weapons[0].projectile.GetDamageModel().damage = 4;
                neuroknife.weapons[0].projectile.pierce = 4;
                neuroknife.weapons[0].projectile.ApplyDisplay<knife>();
                neuroknife.weapons[0].projectile.scale += 1.05f;
                neuroknife.name = "neuroknife";
                neuroknife.range = towerModel.range;
                neuroknife.weapons[0].projectile.GetBehavior<TravelStraitModel>().Lifespan = 99f;
                var neurosword = Game.instance.model.GetTowerFromId("DartMonkey-200").GetAttackModel().Duplicate();
                neurosword.weapons[0].projectile.GetDamageModel().damage = 10;
                neurosword.weapons[0].projectile.pierce = 20;
                neurosword.weapons[0].Rate = 2.5f;
                neurosword.weapons[0].projectile.GetDamageModel().immuneBloonProperties = BloonProperties.None;
                neurosword.weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Ceramic", "Ceramic", 1, 24, false, false));
                neurosword.weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("Moab", "Moab", 1, 40, false, true));
                neurosword.weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("Bfb", "Bfb", 1, 56, false, true));
                neurosword.weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("Zomg", "Zomg", 1, 18, false, true));
                neurosword.weapons[0].projectile.ApplyDisplay<sword>();
                neurosword.weapons[0].projectile.scale += 1.05f;
                neurosword.name = "neurosword";
                neurosword.range = towerModel.range;
                neurosword.weapons[0].projectile.GetBehavior<TravelStraitModel>().Lifespan = 999f;
                towerModel.AddBehavior(neuroknife);
                towerModel.AddBehavior(neurosword);
            }
        }
        public class u500 : ModUpgrade<Psychomonkey>
        {
            public override int Path => TOP;
            public override int Tier => 5;
            public override int Cost => 44500;
            public override string Portrait => "500copy";
            public override string Icon => "u500";
            public override string DisplayName => "Supa-Riftstorm";
            public override string Description => "Opens 2 Psychic Rift portals that slow down Bloons and spew out barrages of Knives and Swords. Psyclone Disks are much stronger.";
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<tower.display500>();
                towerModel.AddBehavior(new SlowBloonsZoneModel("SlowZone", 13, "Ice:Regular:ArcticWind", true, new Il2CppReferenceArray<FilterModel>(new FilterModel[] { new FilterInvisibleModel("Camo", true, false) }), 0.7f, 0, true, 5, "", false));
                var disk = towerModel.GetAttackModel("psyclonedisk");
                var sword = towerModel.GetAttackModel("neurosword");
                var knife = towerModel.GetAttackModel("neuroknife");
                disk.weapons[0].projectile.pierce += 50;
                disk.weapons[0].projectile.GetDamageModel().damage += 15;
                disk.weapons[0].Rate -= 1.5f;
                disk.weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Ceramic", "Ceramic", 1, 30, false, false));
                sword.weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("Bad", "Bad", 1, 125, false, true));
                sword.weapons[0].projectile.GetDamageModel().damage += 16;
                knife.weapons[0].projectile.GetDamageModel().damage += 7;
                sword.weapons[0].projectile.pierce += 20;
                sword.weapons[0].emission = new ArcEmissionModel("ArcEmissionModel_", 3, 0, 30, null, false, false);
                knife.weapons[0].emission = new ArcEmissionModel("ArcEmissionModel_", 3, 0, 30, null, false, false);
                knife.weapons[0].Rate = 0.15f;
                var orbit = Game.instance.model.GetTower(TowerType.BoomerangMonkey, 5).GetBehavior<OrbitModel>().Duplicate();
                orbit.projectile.ApplyDisplay<rift>();
                orbit.range = 19;
                orbit.projectile.scale = 0.75f;
                orbit.count = 2;
                orbit.projectile.GetBehavior<DisplayModel>().positionOffset = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(0, 0, 10);
                towerModel.AddBehavior(orbit);
            }
        }

        public class u003 : ModUpgrade<Psychomonkey>
        {
            public override int Path => BOTTOM;
            public override int Tier => 3;
            public override int Cost => 1050;
            public override string Portrait => "003copy";
            public override string Icon => "u003";
            public override string DisplayName => "Stick of Stone";
            public override string Description => "Channels psychic power to the mighty stick to cause small quakes.";

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<tower.display003>();
                var attackModel = towerModel.GetAttackModel();
                attackModel.weapons[0].projectile.GetBehavior<TravelStraitModel>().Speed = 50f;
                attackModel.weapons[0].projectile.ApplyDisplay<eqproj>();
                attackModel.weapons[0].rate = 1.7f;
                attackModel.weapons[0].projectile.pierce = 1;
                attackModel.weapons[0].projectile.AddBehavior(Game.instance.model.GetTowerFromId("BombShooter").GetWeapon().projectile.GetBehavior<CreateEffectOnContactModel>().Duplicate());
                attackModel.weapons[0].projectile.AddBehavior(Game.instance.model.GetTowerFromId("BombShooter-020").GetWeapon().projectile.GetBehavior<CreateProjectileOnContactModel>().Duplicate());
                attackModel.weapons[0].projectile.AddBehavior(Game.instance.model.GetTowerFromId("BombShooter").GetWeapon().projectile.GetBehavior<CreateSoundOnProjectileCollisionModel>().Duplicate());
                attackModel.weapons[0].projectile.GetDamageModel().damage = 0;
                attackModel.weapons[0].projectile.GetDamageModel().immuneBloonProperties = BloonProperties.None;
                var quake = Game.instance.model.GetTower(TowerType.BombShooter).GetWeapon().projectile.GetBehavior<CreateProjectileOnContactModel>().Duplicate();
                quake.projectile = Game.instance.model.GetTowerFromId("NinjaMonkey-002").GetAttackModel(1).weapons[0].projectile.Duplicate();
                quake.projectile.GetDamageModel().immuneBloonProperties = BloonProperties.None;
                quake.projectile.ApplyDisplay<eq>();
                quake.projectile.GetDamageModel().damage = 2;
                quake.projectile.pierce = 11;
                quake.projectile.GetBehavior<AgeModel>().Lifespan = 20f;
                quake.projectile.scale += .2f;
                attackModel.weapons[0].projectile.AddBehavior(quake);

            }
        }
        public class u004 : ModUpgrade<Psychomonkey>
        {
            public override int Path => BOTTOM;
            public override int Tier => 4;
            public override int Cost => 3980;
            public override string Portrait => "004copy";
            public override string Icon => "u004";
            public override string DisplayName => "Geomancer";
            public override string Description => "Manipulates earth to launch heavy rocks at the Bloons";

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<tower.display004>();
                var boulder = Game.instance.model.GetTowerFromId("DartMonkey-100").GetAttackModel().Duplicate();
                var agemodel = Game.instance.model.GetTowerFromId("SpikeFactory").GetAttackModel().weapons[0].projectile.GetBehavior<AgeModel>().Duplicate();
                boulder.weapons[0].projectile.AddBehavior(Game.instance.model.GetTowerFromId("BombShooter-100").GetWeapon().projectile.GetBehavior<CreateProjectileOnContactModel>().Duplicate());
                boulder.weapons[0].projectile.AddBehavior(Game.instance.model.GetTowerFromId("BombShooter").GetWeapon().projectile.GetBehavior<CreateSoundOnProjectileCollisionModel>().Duplicate());
                boulder.weapons[0].projectile.AddBehavior(Game.instance.model.GetTowerFromId("BombShooter").GetWeapon().projectile.GetBehavior<CreateEffectOnContactModel>().Duplicate());
                boulder.range += 35;
                boulder.weapons[0].projectile.pierce = 2;
                boulder.weapons[0].projectile.ApplyDisplay<rock>();
                boulder.weapons[0].projectile.AddBehavior(Game.instance.model.GetTowerFromId("Adora 20").GetAttackModel().weapons[0].projectile.GetBehavior<AdoraTrackTargetModel>().Duplicate());
                boulder.weapons[0].projectile.GetBehavior<TravelStraitModel>().Lifespan = 999999f;
                boulder.weapons[0].projectile.GetBehavior<TravelStraitModel>().Speed = 2f;
                boulder.weapons[0].projectile.scale /= 2.5f;
                boulder.weapons[0].projectile.GetDamageModel().damage = 10;
                boulder.weapons[0].rate = 1.85f;
                boulder.weapons[0].projectile.GetDamageModel().immuneBloonProperties = BloonProperties.None;
                agemodel.lifespanFrames = 9999;
                agemodel.lifespan = 999999f;
                agemodel.rounds = 9999;
                boulder.weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Ceramic", "Ceramic", 1, 4, false, false));
                boulder.weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("Moab", "Moab", 1, 55, false, true));
                boulder.weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("Bfb", "Bfb", 1, 55, false, true));
                boulder.weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("Zomg", "Zomg", 1, 55, false, true));
                boulder.weapons[0].projectile.AddBehavior(agemodel);
                towerModel.AddBehavior(boulder);
            }
        }
        public class u005 : ModUpgrade<Psychomonkey>
        {
            public override int Path => BOTTOM;
            public override int Tier => 5;
            public override int Cost => 72300;
            public override string Portrait => "005copy";
            public override string Icon => "u005";
            public override string DisplayName => "Golem Master";
            public override string Description => "The Bloons will know whats coming for them just from the vibrations in the ground...";

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<tower.display005>();
                var golem = Game.instance.model.GetTowerFromId("EngineerMonkey-200").GetAttackModel().Duplicate();
                golem.range = 30;
                golem.name = "Golem_Weapon";
                golem.weapons[0].Rate = 20f;
                golem.weapons[0].projectile.AddBehavior(new CreateTowerModel("golemspawn", GetTowerModel<Golemtower>().Duplicate(), 0f, true, true, false, true, true));
                towerModel.AddBehavior(golem);

            }
        }

        public class bufficon : ModBuffIcon
        {
            protected override int Order => 1;
            public override string Icon => "u030";
            public override int MaxStackSize => 1;
        }
   
        public class u030 : ModUpgrade<Psychomonkey>
        {
            public override int Path => MIDDLE;
            public override int Tier => 3;
            public override int Cost => 780;
            public override string Portrait => "030copy";
            public override string Icon => "u030";
            public override string DisplayName => "Magic Assist";
            public override string Description => "Grants 10% additional attack speed to all Wizard Monkeys in range.";

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<tower.display030>();
                TowerFilterModel wizard = new FilterInBaseTowerIdModel("BaseTowerFilter", new string[] { TowerType.WizardMonkey });
                var buff = new RateSupportModel("MagicAssist", 0.9f, true, "magicassistbuff", false, 1, new Il2CppReferenceArray<TowerFilterModel>(new TowerFilterModel[] { wizard }), "", "");
                buff.ApplyBuffIcon<bufficon>();
                towerModel.AddBehavior(buff);
            }
        }
        public class u040 : ModUpgrade<Psychomonkey>
        {
            public override int Path => MIDDLE;
            public override int Tier => 4;
            public override int Cost => 2280;
            public override string Portrait => "040copy";
            public override string Icon => "u040";
            public override string DisplayName => "Sands of Time";
            public override string Description => "Time Manipulation: Rewinds all nearby small Bloons a few seconds into the past";

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<tower.display040>();
                towerModel.GetAttackModel().weapons[0].projectile.ApplyDisplay<psychosandsdart>();
                towerModel.AddBehavior(Game.instance.model.GetTowerFromId("Psi 3").GetAbility().Duplicate());
                towerModel.GetAbility().icon = GetSpriteReference(mod, "u040");
                var activate = towerModel.GetAbility().GetBehavior<ActivateAttackModel>().attacks[0];
                activate.weapons[0].projectile.pierce = 99999999.0f;
                activate.weapons[0].projectile.scale *= 20;
                activate.weapons[0].projectile.RemoveBehavior<CreateSoundOnAbilityModel>();
                activate.weapons[0].projectile.RemoveBehavior<CreateEffectOnAbilityModel>();
                activate.weapons[0].projectile.RemoveBehavior<SlowModel>();
                activate.weapons[0].projectile.RemoveBehavior<DamageModel>();
                WindModel Knockback = Game.instance.model.GetTowerFromId("NinjaMonkey-010").GetWeapon().projectile.GetBehavior<WindModel>().Duplicate();
                Knockback.affectMoab = false;
                Knockback.chance = 100f;
                Knockback.distanceMin = 160;
                Knockback.name = "rewind";
                Knockback.distanceMax = 160;
                Knockback.distanceScaleForTags = 0;
                Knockback.distanceScaleForTagsTags = "Bad";
                activate.weapons[0].projectile.AddBehavior(Knockback);



            }
        }
        public class u050 : ModUpgrade<Psychomonkey>
        {
            public override int Path => MIDDLE;
            public override int Tier => 5;
            public override int Cost => 32800;
            public override string Portrait => "050copy";
            public override string Icon => "u050";
            public override string DisplayName => "Chronomancer";
            public override string Description => "The Chronomancer bends time's flow, rewinding all visible Bloons to their origin";

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<tower.display050>();
                towerModel.RemoveBehavior<AbilityModel>();
                towerModel.AddBehavior(Game.instance.model.GetTowerFromId("MonkeyAce-040").GetAbility().Duplicate());
                towerModel.GetAbility().icon = GetSpriteReference(mod, "u050");
                towerModel.GetAbility().RemoveBehavior<CreateEffectOnAbilityModel>();
                towerModel.GetAbility().RemoveBehavior<CreateSoundOnAbilityModel>();
                towerModel.GetAbility().AddBehavior(Game.instance.model.GetTowerFromId("AdmiralBrickell 20").GetBehavior<AbilityModel>().GetBehavior<CreateEffectOnAbilityModel>());
                towerModel.GetAbility().AddBehavior(Game.instance.model.GetTowerFromId("Adora 20").GetBehavior<AbilityModel>().GetBehavior<CreateSoundOnAbilityModel>());
                towerModel.GetAbility().cooldown = 405f;
                var activate = towerModel.GetAbility().GetBehavior<ActivateAttackModel>().attacks[0];
                activate.weapons[0].projectile.pierce = 99999999.0f;
                activate.weapons[0].projectile.scale *= 20;
                activate.weapons[0].projectile.RemoveBehavior<SlowModel>();
                activate.weapons[0].projectile.RemoveBehavior<DamageModel>();
                WindModel Knockback = Game.instance.model.GetTowerFromId("NinjaMonkey-010").GetWeapon().projectile.GetBehavior<WindModel>().Duplicate();
                Knockback.affectMoab = true;
                Knockback.chance = 100f;
                Knockback.distanceMin = 99999;
                Knockback.name = "chronorewind";
                Knockback.distanceMax = 99999;
                Knockback.distanceScaleForTags = 0;
                Knockback.distanceScaleForTagsTags = "Bad";
                activate.weapons[0].projectile.AddBehavior(Knockback);
            }
        }






    }
    public class Golemtower : ModTower
    {
        public override string Portrait => "golem";
        public override string Name => "Golem";
        public override TowerSet TowerSet => TowerSet.Magic;
        public override string BaseTower => TowerType.DartMonkey;

        public override bool DontAddToShop => true;
        public override int Cost => 0;

        public override int TopPathUpgrades => 0;
        public override int MiddlePathUpgrades => 0;
        public override int BottomPathUpgrades => 0;


        public override string DisplayName => "Monkey Golem";
        public override string Description => " ";

        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            towerModel.ApplyDisplay<tower.display005g>();
            towerModel.isSubTower = true;
            towerModel.AddBehavior(new TowerExpireModel("ExpireModel", 20f, 9, true, false));
            var attackModel = towerModel.GetAttackModel();
            towerModel.AddBehavior(new OverrideCamoDetectionModel("CamoDetect", true));
            towerModel.AddBehavior(new CreditPopsToParentTowerModel("DamageForMainTower"));
            towerModel.range = 115;
            attackModel.range = 115;
            towerModel.showBuffs = false;
            attackModel.weapons[0].projectile.ApplyDisplay<eqprojgolem>();
            attackModel.weapons[0].rate += 3f;
            attackModel.weapons[0].projectile.pierce = 1;
            attackModel.weapons[0].projectile.AddBehavior(Game.instance.model.GetTowerFromId("BombShooter-300").GetWeapon().projectile.GetBehavior<CreateEffectOnContactModel>().Duplicate());
            attackModel.weapons[0].projectile.AddBehavior(Game.instance.model.GetTowerFromId("BombShooter-020").GetWeapon().projectile.GetBehavior<CreateProjectileOnContactModel>().Duplicate());
            attackModel.weapons[0].projectile.AddBehavior(Game.instance.model.GetTowerFromId("BombShooter").GetWeapon().projectile.GetBehavior<CreateSoundOnProjectileCollisionModel>().Duplicate());
            attackModel.weapons[0].projectile.GetDamageModel().damage = 0;
            attackModel.weapons[0].projectile.GetDamageModel().immuneBloonProperties = BloonProperties.None;
            var quake = Game.instance.model.GetTower(TowerType.BombShooter).GetWeapon().projectile.GetBehavior<CreateProjectileOnContactModel>().Duplicate();
            quake.projectile = Game.instance.model.GetTowerFromId("NinjaMonkey-002").GetAttackModel(1).weapons[0].projectile.Duplicate();
            quake.projectile.GetDamageModel().immuneBloonProperties = BloonProperties.None;
            quake.projectile.ApplyDisplay<golemeq>();
            quake.projectile.GetDamageModel().damage = 70;
            quake.projectile.pierce = 90;
            quake.projectile.GetBehavior<AgeModel>().Lifespan = 10f;
            quake.projectile.scale += 1.4f;
            quake.projectile.AddBehavior(new DamageModifierForTagModel("Moab", "Moab", 1, 3, false, true));
            quake.projectile.AddBehavior(new DamageModifierForTagModel("Bfb", "Bfb", 1, 9, false, true));
            quake.projectile.AddBehavior(new DamageModifierForTagModel("Zomg", "Zomg", 1, 23, false, true));
            quake.projectile.AddBehavior(new DamageModifierForTagModel("Bad", "Bad", 1, 12, false, true));
            quake.projectile.AddBehavior(new DamageModifierForTagModel("Boss", "Boss", 1, 13, false, true));
            attackModel.weapons[0].projectile.AddBehavior(quake);
        }

    }
    public class golemeq : ModDisplay
    {
        public override string BaseDisplay => Generic2dDisplay;

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            Set2DTexture(node, Name);
        }
    }
    public class eqprojgolem : ModDisplay
    {
        public override string BaseDisplay => Generic2dDisplay;

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            Set2DTexture(node, Name);
        }
    }
}      