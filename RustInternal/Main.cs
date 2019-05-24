using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Assets.Draws;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x0200004B RID: 75
	internal class Main : MonoBehaviour
	{
		// Token: 0x060002E5 RID: 741 RVA: 0x000113C4 File Offset: 0x0000F5C4
		private void Start()
		{
			Main.EspCat = new Menu.Option("Player&AnimalEsp", Menu.Option.OptType.Category, false);
			Main.shouldDrawPlayers = new Menu.Option("Username + Distance", Menu.Option.OptType.Toggle, false);
			Main.playerbox = new Menu.Option("Box", Menu.Option.OptType.Toggle, false);
			Main.vert = new Menu.Option("Health Number", Menu.Option.OptType.Toggle, false);
			Main.showid = new Menu.Option("Player ID", Menu.Option.OptType.Toggle, false);
			Main.Esp_Team_Color = new Menu.Option("Enemy Color", Menu.Option.OptType.Selector, 2);
			Main.Esp_Team_Color.SubContent = Main.EspColors;
			Main.friendcolor = new Menu.Option("Friends Color", Menu.Option.OptType.Selector, 2);
			Main.friendcolor.SubContent = Main.EspColors;
			Main.skeletoncolor = new Menu.Option("Skeleton Color", Menu.Option.OptType.Selector, 2);
			Main.skeletoncolor.SubContent = Main.EspColors;
			Main.target = new Menu.Option("Target Snapline", Menu.Option.OptType.Toggle, false);
			Main.inventory = new Menu.Option("Hotbar Esp", Menu.Option.OptType.Toggle, false);
			Main.cham = new Menu.Option("Chams", Menu.Option.OptType.Toggle, false);
			Main.shouldDrawHealthBar = new Menu.Option("Health Bar", Menu.Option.OptType.Toggle, true);
			Main.shouldDrawEquipedItem = new Menu.Option("Equipped Item", Menu.Option.OptType.Toggle, false);
			Main.Skeleton = new Menu.Option("Skeleton", Menu.Option.OptType.Toggle, false);
			Main.shouldDrawSleepers = new Menu.Option("Sleepers", Menu.Option.OptType.Toggle, false);
			Main.shouldDrawCorpses = new Menu.Option("Corpse", Menu.Option.OptType.Toggle, false);
			Main.npc = new Menu.Option("Scientist", Menu.Option.OptType.Toggle, false);
			Main.shouldDrawAnimals = new Menu.Option("Animals", Menu.Option.OptType.Toggle, false);
			Main.Esp_VisibilityCheck = new Menu.Option("Visbility Check", Menu.Option.OptType.Toggle, false);
			Main.EspCat.Items.AddRange(new Menu.Option[]
			{
				Main.shouldDrawPlayers,
				Main.playerbox,
				Main.friendcolor,
				Main.showid,
				Main.Esp_Team_Color,
				Main.shouldDrawHealthBar,
				Main.vert,
				Main.skeletoncolor,
				Main.shouldDrawEquipedItem,
				Main.inventory,
				Main.target,
				Main.Skeleton,
				Main.shouldDrawCorpses,
				Main.shouldDrawSleepers,
				Main.shouldDrawAnimals,
				Main.npc,
				Main.Esp_VisibilityCheck,
				Main.cham
			});
			Main.RadarCat = new Menu.Option("Radar", Menu.Option.OptType.Category, false);
			Main.Radar101 = new Menu.Option("Player", Menu.Option.OptType.Toggle, false);
			Main.animalradar = new Menu.Option("Animal", Menu.Option.OptType.Toggle, false);
			Main.moveable = new Menu.Option("Move+Resize Radar", Menu.Option.OptType.Toggle, false);
			Main.resize = new Menu.Option("Resize Radar([+] + [-])", Menu.Option.OptType.Toggle, false);
			Main.RadarStoneOre = new Menu.Option("Stone Ore", Menu.Option.OptType.Toggle, false);
			Main.RadarMetalOre = new Menu.Option("Metal Ore", Menu.Option.OptType.Toggle, false);
			Main.RadarSulfurOre = new Menu.Option("Sulfur Ore", Menu.Option.OptType.Toggle, false);
			Main.Radar1011 = new Menu.Option("Enable Radar Background", Menu.Option.OptType.Toggle, false);
			Main.Esp_Enemy_Color_Visible = new Menu.Option("Player Radar Color", Menu.Option.OptType.Selector, 0);
			Main.Esp_Enemy_Color_Visible.SubContent = Main.EspColors;
			Main.Esp_Team_Color_Visible = new Menu.Option("Animal Radar color", Menu.Option.OptType.Selector, 3);
			Main.Esp_Team_Color_Visible.SubContent = Main.EspColors;
			Main.RadarCat.Items.AddRange(new Menu.Option[]
			{
				Main.Radar101,
				Main.moveable,
				Main.resize,
				Main.animalradar,
				Main.RadarStoneOre,
				Main.RadarMetalOre,
				Main.RadarSulfurOre,
				Main.Radar1011,
				Main.Esp_Enemy_Color_Visible,
				Main.Esp_Team_Color_Visible
			});
			Main.AimCat = new Menu.Option("AIM", Menu.Option.OptType.Category, false);
			Main.Aim_Key = new Menu.Option("Aimbotkey", Menu.Option.OptType.Selector, 0);
			Main.aimkeyvisible = new Menu.Option("AimbotVisibleKey", Menu.Option.OptType.Selector, 0);
			Main.fovforaimbot = new Menu.Option("Fov Circle", Menu.Option.OptType.Toggle, false);
			Main.VisCheck = new Menu.Option("VisCheck", Menu.Option.OptType.Toggle, false);
			Main.friends = new Menu.Option("AimAtFriends", Menu.Option.OptType.Toggle, false);
			Main.shouldEnableAimbot = new Menu.Option("Aimbot", Menu.Option.OptType.Toggle, false);
			Main.body = new Menu.Option("BodyAimbot", Menu.Option.OptType.Toggle, false);
			Main.heliaim = new Menu.Option("HeliAimbot", Menu.Option.OptType.Toggle, false);
			Main.BulletDropPrediction = new Menu.Option("BulletDrop", Menu.Option.OptType.Toggle, false);
			Main.VelocityPrediction = new Menu.Option("Movement", Menu.Option.OptType.Toggle, false);
			Main.shouldDrawCrosshair = new Menu.Option("Crosshair", Menu.Option.OptType.Toggle, false);
			Main.aimkeyvisible.SubContent = new List<object>
			{
				KeyCode.LeftAlt,
				KeyCode.V,
				KeyCode.F,
				KeyCode.X,
				KeyCode.LeftShift,
				KeyCode.N,
				KeyCode.I,
				KeyCode.G,
				KeyCode.G,
				KeyCode.E,
				KeyCode.R,
				KeyCode.Mouse0,
				KeyCode.Mouse1,
				KeyCode.LeftControl
			};
			Main.Aim_Key.SubContent = new List<object>
			{
				KeyCode.LeftAlt,
				KeyCode.V,
				KeyCode.F,
				KeyCode.X,
				KeyCode.LeftShift,
				KeyCode.N,
				KeyCode.I,
				KeyCode.G,
				KeyCode.G,
				KeyCode.E,
				KeyCode.R,
				KeyCode.Mouse0,
				KeyCode.Mouse1,
				KeyCode.LeftControl
			};
			Main.AimCat.Items.AddRange(new Menu.Option[]
			{
				Main.fovforaimbot,
				Main.shouldEnableAimbot,
				Main.Aim_Key,
				Main.friends,
				Main.VisCheck,
				Main.aimkeyvisible,
				Main.body,
				Main.heliaim,
				Main.BulletDropPrediction,
				Main.VelocityPrediction,
				Main.shouldDrawCrosshair
			});
			Main.MiscEspCat = new Menu.Option("Trap Esp", Menu.Option.OptType.Category, false);
			Main.shouldDrawTurrets = new Menu.Option("AutoTurret(F)", Menu.Option.OptType.Toggle, false);
			Main.guntrap = new Menu.Option("ShotgunTrap(F)", Menu.Option.OptType.Toggle, false);
			Main.flametrap = new Menu.Option("FlameTrap(F)", Menu.Option.OptType.Toggle, false);
			Main.landmine = new Menu.Option("Landmine", Menu.Option.OptType.Toggle, false);
			Main.beartrap = new Menu.Option("BearTrap", Menu.Option.OptType.Toggle, false);
			Main.MiscEspCat.Items.AddRange(new Menu.Option[]
			{
				Main.beartrap,
				Main.landmine,
				Main.flametrap,
				Main.guntrap,
				Main.shouldDrawTurrets
			});
			Main.WorldEspCat = new Menu.Option("World Esp", Menu.Option.OptType.Category, false);
			Main.shouldDrawHeli = new Menu.Option("Helicopter", Menu.Option.OptType.Toggle, false);
			Main.miniheli = new Menu.Option("MiniHeli", Menu.Option.OptType.Toggle, false);
			Main.explosives = new Menu.Option("TimedExplosives", Menu.Option.OptType.Toggle, false);
			Main.dropzones = new Menu.Option("ChinookDropZones", Menu.Option.OptType.Toggle, false);
			Main.bradly = new Menu.Option("Bradly", Menu.Option.OptType.Toggle, false);
			Main.chinook = new Menu.Option("Chinook", Menu.Option.OptType.Toggle, false);
			Main.boatesp = new Menu.Option("Boats", Menu.Option.OptType.Toggle, false);
			Main.shouldDrawOthers = new Menu.Option("AllStorageContainers", Menu.Option.OptType.Toggle, false);
			Main.woodbox = new Menu.Option("SmallBox", Menu.Option.OptType.Toggle, false);
			Main.largebox = new Menu.Option("LargeBox", Menu.Option.OptType.Toggle, false);
			Main.shouldDrawRepairBenches = new Menu.Option("RepairBenches", Menu.Option.OptType.Toggle, false);
			Main.shouldDrawVendingMachines = new Menu.Option("VendingMachines", Menu.Option.OptType.Toggle, false);
			Main.shouldDrawWaterCatchers = new Menu.Option("WaterCatchers", Menu.Option.OptType.Toggle, false);
			Main.shouldDrawQuarries = new Menu.Option("Quarries", Menu.Option.OptType.Toggle, false);
			Main.shouldDrawLightSources = new Menu.Option("Lights", Menu.Option.OptType.Toggle, false);
			Main.shouldDrawFridges = new Menu.Option("Fridges", Menu.Option.OptType.Toggle, false);
			Main.Sleepingbag = new Menu.Option("SleepingBags", Menu.Option.OptType.Toggle, false);
			Main.shouldDrawCampfires = new Menu.Option("Campfire", Menu.Option.OptType.Toggle, false);
			Main.airdrop = new Menu.Option("Airdrop", Menu.Option.OptType.Toggle, false);
			Main.shouldDrawFurnaces = new Menu.Option("Furnaces", Menu.Option.OptType.Toggle, false);
			Main.shouldDrawRecyclers = new Menu.Option("Recycler", Menu.Option.OptType.Toggle, false);
			Main.shouldDrawRefineries = new Menu.Option("Refineries", Menu.Option.OptType.Toggle, false);
			Main.shouldDrawCupboards = new Menu.Option("Cupboards(F)", Menu.Option.OptType.Toggle, false);
			Main.authlist = new Menu.Option("Cupboard Auth List", Menu.Option.OptType.Toggle, false);
			Main.WorldEspCat.Items.AddRange(new Menu.Option[]
			{
				Main.woodbox,
				Main.explosives,
				Main.largebox,
				Main.shouldDrawOthers,
				Main.shouldDrawRepairBenches,
				Main.shouldDrawVendingMachines,
				Main.shouldDrawWaterCatchers,
				Main.shouldDrawQuarries,
				Main.shouldDrawLightSources,
				Main.shouldDrawFridges,
				Main.Sleepingbag,
				Main.shouldDrawCampfires,
				Main.airdrop,
				Main.shouldDrawFurnaces,
				Main.bradly,
				Main.chinook,
				Main.dropzones,
				Main.shouldDrawHeli,
				Main.miniheli,
				Main.boatesp,
				Main.shouldDrawRecyclers,
				Main.shouldDrawRefineries,
				Main.shouldDrawCupboards,
				Main.authlist
			});
			Main.AutoFarmCat = new Menu.Option("AutomaticStuff", Menu.Option.OptType.Category, false);
			Main.autoupgrade = new Menu.Option("AutoUpgrade(U,I,O,P)", Menu.Option.OptType.Toggle, false);
			Main.drink = new Menu.Option("AutoDrink", Menu.Option.OptType.Toggle, false);
			Main.demolish = new Menu.Option("AutoDemolish", Menu.Option.OptType.Toggle, false);
			Main.HOTKEY = new Menu.Option("AutoDemolishKey", Menu.Option.OptType.Selector, 0);
			Main.HOTKEY.SubContent = new List<object>
			{
				KeyCode.LeftAlt,
				KeyCode.C,
				KeyCode.L,
				KeyCode.H,
				KeyCode.O,
				KeyCode.X,
				KeyCode.V,
				KeyCode.F,
				KeyCode.LeftShift,
				KeyCode.Mouse0,
				KeyCode.Mouse1,
				KeyCode.LeftControl
			};
			Main.autopush = new Menu.Option("AutoPushBoat", Menu.Option.OptType.Toggle, false);
			Main.HOTKEY1 = new Menu.Option("AutoPushBoatKey", Menu.Option.OptType.Selector, 0);
			Main.HOTKEY1.SubContent = new List<object>
			{
				KeyCode.LeftAlt,
				KeyCode.C,
				KeyCode.L,
				KeyCode.H,
				KeyCode.X,
				KeyCode.O,
				KeyCode.V,
				KeyCode.F,
				KeyCode.LeftShift,
				KeyCode.Mouse0,
				KeyCode.Mouse1,
				KeyCode.LeftControl
			};
			Main.autolight = new Menu.Option("AutoLight Torch Anywhere", Menu.Option.OptType.Toggle, false);
			Main.autounlock = new Menu.Option("AutoAuthCodeLocks", Menu.Option.OptType.Toggle, false);
			Main.autounlockcodekey = new Menu.Option("AutoAuthKey", Menu.Option.OptType.Selector, 0);
			Main.autounlockcodekey.SubContent = new List<object>
			{
				KeyCode.LeftAlt,
				KeyCode.C,
				KeyCode.L,
				KeyCode.X,
				KeyCode.H,
				KeyCode.O,
				KeyCode.V,
				KeyCode.F,
				KeyCode.LeftShift,
				KeyCode.Mouse0,
				KeyCode.Mouse1,
				KeyCode.LeftControl
			};
			Main.autolock = new Menu.Option("AutoLockDoors", Menu.Option.OptType.Toggle, false);
			Main.doorheks = new Menu.Option("KnockOnDoors", Menu.Option.OptType.Toggle, false);
			Main.HOTKEY9 = new Menu.Option("AutoKnockKey", Menu.Option.OptType.Selector, 0);
			Main.HOTKEY9.SubContent = new List<object>
			{
				KeyCode.LeftAlt,
				KeyCode.C,
				KeyCode.L,
				KeyCode.H,
				KeyCode.O,
				KeyCode.X,
				KeyCode.V,
				KeyCode.F,
				KeyCode.LeftShift,
				KeyCode.Mouse0,
				KeyCode.Mouse1,
				KeyCode.LeftControl
			};
			Main.HOTKEY2 = new Menu.Option("AutoLockKey", Menu.Option.OptType.Selector, 0);
			Main.HOTKEY2.SubContent = new List<object>
			{
				KeyCode.LeftAlt,
				KeyCode.C,
				KeyCode.L,
				KeyCode.H,
				KeyCode.O,
				KeyCode.X,
				KeyCode.V,
				KeyCode.F,
				KeyCode.LeftShift,
				KeyCode.Mouse0,
				KeyCode.Mouse1,
				KeyCode.LeftControl
			};
			Main.autopick = new Menu.Option("AutoPickupDroppedItems", Menu.Option.OptType.Toggle, false);
			Main.HOTKEY3 = new Menu.Option("AutoPickupKey", Menu.Option.OptType.Selector, 0);
			Main.HOTKEY3.SubContent = new List<object>
			{
				KeyCode.LeftAlt,
				KeyCode.C,
				KeyCode.L,
				KeyCode.H,
				KeyCode.O,
				KeyCode.X,
				KeyCode.V,
				KeyCode.F,
				KeyCode.LeftShift,
				KeyCode.Mouse0,
				KeyCode.Mouse1,
				KeyCode.LeftControl
			};
			Main.autopickup = new Menu.Option("AutoPickupHemp", Menu.Option.OptType.Toggle, false);
			Main.autopickup1 = new Menu.Option("AutoPickupStone", Menu.Option.OptType.Toggle, false);
			Main.autopickup2 = new Menu.Option("AutoPickupMetal", Menu.Option.OptType.Toggle, false);
			Main.autopickup3 = new Menu.Option("AutoPickupMushroom", Menu.Option.OptType.Toggle, false);
			Main.autopickup4 = new Menu.Option("AutoPickSulfur", Menu.Option.OptType.Toggle, false);
			Main.autofarm = new Menu.Option("AutoFarmBarrels", Menu.Option.OptType.Toggle, false);
			Main.autofarm2 = new Menu.Option("AutoFarmOreHotspot", Menu.Option.OptType.Toggle, false);
			Main.autofarm5 = new Menu.Option("AutoAttackAnimals", Menu.Option.OptType.Toggle, false);
			Main.AutoFarmCat.Items.AddRange(new Menu.Option[]
			{
				Main.autoupgrade,
				Main.doorheks,
				Main.HOTKEY9,
				Main.drink,
				Main.demolish,
				Main.HOTKEY,
				Main.autolight,
				Main.autopush,
				Main.HOTKEY1,
				Main.autolock,
				Main.HOTKEY2,
				Main.autounlock,
				Main.autounlockcodekey,
				Main.autofarm2,
				Main.autofarm,
				Main.autofarm5,
				Main.autopick,
				Main.HOTKEY3,
				Main.autopickup,
				Main.autopickup1,
				Main.autopickup2,
				Main.autopickup4,
				Main.autopickup3
			});
			Main.weaponmod = new Menu.Option("WeaponMods", Menu.Option.OptType.Category, false);
			Main.bowhack = new Menu.Option("InstantlyShootBow", Menu.Option.OptType.Toggle, false);
			Main.silentaimbotdick = new Menu.Option("SilentAimDick", Menu.Option.OptType.Toggle, false);
			Main.shoot = new Menu.Option("ShootAnywhere", Menu.Option.OptType.Toggle, false);
			Main.killafterdead = new Menu.Option("KillDeadPlayers", Menu.Option.OptType.Toggle, false);
			Main.testing = new Menu.Option("SlowBulletVelocity", Menu.Option.OptType.Toggle, false);
			Main.fasty = new Menu.Option("FastBulletVelocity", Menu.Option.OptType.Toggle, false);
			Main.killscientist = new Menu.Option("SilentAimScientist", Menu.Option.OptType.Toggle, false);
			Main.shotgunnospread = new Menu.Option("ShotgunNospread", Menu.Option.OptType.Toggle, false);
			Main.silentaimbot = new Menu.Option("Player SilentAim", Menu.Option.OptType.Toggle, false);
			Main.silentaimbotheli = new Menu.Option("Heli SilentAim", Menu.Option.OptType.Toggle, false);
			Main.shouldNoSway = new Menu.Option("NoSway", Menu.Option.OptType.Toggle, true);
			Main.ForceAutomatic = new Menu.Option("ForceAllGunsAutomatic", Menu.Option.OptType.Toggle, true);
			Main.noclip = new Menu.Option("IncreaseBulletSize", Menu.Option.OptType.Toggle, false);
			Main.nospreadhvhxd = new Menu.Option("NoSpread", Menu.Option.OptType.Toggle, false);
			Main.admin = new Menu.Option("1 Hit Eoka", Menu.Option.OptType.Toggle, false);
			Main.shouldNoRecoil = new Menu.Option("No Recoil", Menu.Option.OptType.Toggle, false);
			Main.Distancee = new Menu.Option("Distance Hack", Menu.Option.OptType.Toggle, false);
			Main.rage = new Menu.Option("KilledFrom -10|0m", Menu.Option.OptType.Toggle, false);
			Main.rage1 = new Menu.Option("KilledFrom -2000m", Menu.Option.OptType.Toggle, false);
			Main.rage2 = new Menu.Option("KilledFrom 9999m", Menu.Option.OptType.Toggle, false);
			Main.legit = new Menu.Option("KilledFrom 40|45m", Menu.Option.OptType.Toggle, false);
			Main.legit1 = new Menu.Option("KilledFrom 100|110m", Menu.Option.OptType.Toggle, false);
			Main.weaponmod.Items.AddRange(new Menu.Option[]
			{
				Main.silentaimbot,
				Main.silentaimbotdick,
				Main.fasty,
				Main.testing,
				Main.silentaimbotheli,
				Main.killafterdead,
				Main.killscientist,
				Main.shoot,
				Main.noclip,
				Main.bowhack,
				Main.shouldNoRecoil,
				Main.nospreadhvhxd,
				Main.shotgunnospread,
				Main.shouldNoSway,
				Main.ForceAutomatic,
				Main.admin,
				Main.Distancee,
				Main.rage,
				Main.rage1,
				Main.rage2,
				Main.legit,
				Main.legit1
			});
			Main.movement = new Menu.Option("Player Hacks", Menu.Option.OptType.Category, false);
			Main.swim = new Menu.Option("SwimHack", Menu.Option.OptType.Toggle, false);
			Main.admin1 = new Menu.Option("3rd Person", Menu.Option.OptType.Toggle, false);
			Main.localcontrol = new Menu.Option("Move,DropLootWhileWounded", Menu.Option.OptType.Toggle, false);
			Main.ClimbHack = new Menu.Option("ClimbHack(Z)", Menu.Option.OptType.Toggle, false);
			Main.seated = new Menu.Option("DriveHack", Menu.Option.OptType.Toggle, false);
			Main.laddermovement = new Menu.Option("LadderHack", Menu.Option.OptType.Toggle, false);
			Main.NoFallDamage = new Menu.Option("NoFall Damage", Menu.Option.OptType.Toggle, false);
			Main.jump = new Menu.Option("JumpHack", Menu.Option.OptType.Toggle, false);
			Main.untieall = new Menu.Option("UnTieAllCrates", Menu.Option.OptType.Toggle, false);
			Main.nosink = new Menu.Option("NoSinkingInWater", Menu.Option.OptType.Toggle, false);
			Main.noloss = new Menu.Option("NoTimeoutForCompoundbow", Menu.Option.OptType.Toggle, false);
			Main.instantloot = new Menu.Option("Instant Loot", Menu.Option.OptType.Toggle, false);
			Main.jackhammerhack = new Menu.Option("JackHammerHack", Menu.Option.OptType.Toggle, false);
			Main.gravity = new Menu.Option("GravityHack", Menu.Option.OptType.Toggle, false);
			Main.removeblack = new Menu.Option("NoBlackoutInClothing", Menu.Option.OptType.Toggle, false);
			Main.aimarmour = new Menu.Option("AimWithHeavyArmour", Menu.Option.OptType.Toggle, false);
			Main.bows = new Menu.Option("Big Dick", Menu.Option.OptType.Toggle, false);
			Main.spawnlatter = new Menu.Option("Spawn Ladder", Menu.Option.OptType.Toggle, false);
			Main.aimkey1 = new Menu.Option("Spawn Ladder Key", Menu.Option.OptType.Selector, 0);
			Main.aimkey1.SubContent = new List<object>
			{
				KeyCode.LeftAlt,
				KeyCode.C,
				KeyCode.L,
				KeyCode.O,
				KeyCode.H,
				KeyCode.V,
				KeyCode.F,
				KeyCode.LeftShift,
				KeyCode.Mouse0,
				KeyCode.Mouse1,
				KeyCode.LeftControl
			};
			Main.speedhek = new Menu.Option("SpeedHack", Menu.Option.OptType.Toggle, false);
			Main.instant = new Menu.Option("InstantRevive", Menu.Option.OptType.Toggle, false);
			Main.fastheal = new Menu.Option("FastHeal", Menu.Option.OptType.Toggle, false);
			Main.aimkey3 = new Menu.Option("FastHeal Key", Menu.Option.OptType.Selector, 0);
			Main.aimkey3.SubContent = new List<object>
			{
				KeyCode.LeftAlt,
				KeyCode.C,
				KeyCode.L,
				KeyCode.H,
				KeyCode.O,
				KeyCode.V,
				KeyCode.F,
				KeyCode.LeftShift,
				KeyCode.Mouse0,
				KeyCode.Mouse1,
				KeyCode.LeftControl
			};
			Main.aimkey4 = new Menu.Option("InstantRevive Key", Menu.Option.OptType.Selector, 0);
			Main.aimkey4.SubContent = new List<object>
			{
				KeyCode.LeftAlt,
				KeyCode.C,
				KeyCode.L,
				KeyCode.E,
				KeyCode.H,
				KeyCode.O,
				KeyCode.V,
				KeyCode.F,
				KeyCode.LeftShift,
				KeyCode.Mouse0,
				KeyCode.Mouse1,
				KeyCode.LeftControl
			};
			Main.healfriend = new Menu.Option("InstantHealFriends", Menu.Option.OptType.Toggle, false);
			Main.aimkey5 = new Menu.Option("HealFriends Key", Menu.Option.OptType.Selector, 0);
			Main.aimkey5.SubContent = new List<object>
			{
				KeyCode.LeftAlt,
				KeyCode.C,
				KeyCode.L,
				KeyCode.E,
				KeyCode.H,
				KeyCode.O,
				KeyCode.V,
				KeyCode.F,
				KeyCode.LeftShift,
				KeyCode.Mouse0,
				KeyCode.Mouse1,
				KeyCode.LeftControl
			};
			Main.movement.Items.AddRange(new Menu.Option[]
			{
				Main.localcontrol,
				Main.swim,
				Main.seated,
				Main.laddermovement,
				Main.admin1,
				Main.ClimbHack,
				Main.NoFallDamage,
				Main.jump,
				Main.untieall,
				Main.nosink,
				Main.noloss,
				Main.instantloot,
				Main.jackhammerhack,
				Main.gravity,
				Main.removeblack,
				Main.aimarmour,
				Main.bows,
				Main.spawnlatter,
				Main.aimkey1,
				Main.instant,
				Main.aimkey4,
				Main.healfriend,
				Main.aimkey5,
				Main.fastheal,
				Main.aimkey3,
				Main.speedhek
			});
			Main.FarmEspCat = new Menu.Option("Farming Esp", Menu.Option.OptType.Category, false);
			Main.shouldDrawStorage = new Menu.Option("FarmEspEnabled", Menu.Option.OptType.Toggle, true);
			Main.eastereggs = new Menu.Option("EasterEggs", Menu.Option.OptType.Toggle, true);
			Main.shouldDrawResources = new Menu.Option("Trees and Ore", Menu.Option.OptType.Toggle, false);
			Main.hemp = new Menu.Option("Hemp Collectibles", Menu.Option.OptType.Toggle, false);
			Main.stone = new Menu.Option("Stone Collectibles", Menu.Option.OptType.Toggle, false);
			Main.shouldDrawDoors = new Menu.Option("Mushroom Collectibles", Menu.Option.OptType.Toggle, false);
			Main.DisableGrass = new Menu.Option("Metal Collectibles", Menu.Option.OptType.Toggle, false);
			Main.shouldDrawTrash = new Menu.Option("Sulfur Collectibles", Menu.Option.OptType.Toggle, false);
			Main.shouldDrawCollectible = new Menu.Option("AllCollectibles", Menu.Option.OptType.Toggle, false);
			Main.shouldDrawBarrels = new Menu.Option("Barrels", Menu.Option.OptType.Toggle, false);
			Main.shouldDrawStashes = new Menu.Option("HiddenStashes", Menu.Option.OptType.Toggle, false);
			Main.stash1 = new Menu.Option("NonHiddenStashes", Menu.Option.OptType.Toggle, false);
			Main.sulfur1 = new Menu.Option("SulfurOre", Menu.Option.OptType.Toggle, false);
			Main.metal1 = new Menu.Option("MetalOre", Menu.Option.OptType.Toggle, false);
			Main.stone1 = new Menu.Option("StoneOre", Menu.Option.OptType.Toggle, false);
			Main.shouldDrawCrates = new Menu.Option("Crate Esp", Menu.Option.OptType.Toggle, false);
			Main.shouldDrawFoodboxes = new Menu.Option("Food Box", Menu.Option.OptType.Toggle, false);
			Main.shouldDrawWorldItems = new Menu.Option("Dropped Items", Menu.Option.OptType.Toggle, false);
			Main.FarmEspCat.Items.AddRange(new Menu.Option[]
			{
				Main.eastereggs,
				Main.shouldDrawResources,
				Main.shouldDrawFoodboxes,
				Main.shouldDrawWorldItems,
				Main.shouldDrawTrash,
				Main.hemp,
				Main.stone,
				Main.shouldDrawStorage,
				Main.shouldDrawDoors,
				Main.DisableGrass,
				Main.shouldDrawCollectible,
				Main.shouldDrawBarrels,
				Main.shouldDrawStashes,
				Main.stash1,
				Main.sulfur1,
				Main.metal1,
				Main.stone1,
				Main.shouldDrawCrates
			});
			Main.MiscCat = new Menu.Option("Misc", Menu.Option.OptType.Category, false);
			Main.openbox = new Menu.Option("Loot Corpse", Menu.Option.OptType.Toggle, false);
			Main.aimkey2 = new Menu.Option("Loot Corpse Key", Menu.Option.OptType.Selector, 0);
			Main.aimkey2.SubContent = new List<object>
			{
				KeyCode.LeftAlt,
				KeyCode.C,
				KeyCode.L,
				KeyCode.O,
				KeyCode.V,
				KeyCode.H,
				KeyCode.F,
				KeyCode.LeftShift,
				KeyCode.Mouse0,
				KeyCode.Mouse1,
				KeyCode.LeftControl
			};
			Main.FastGathering = new Menu.Option("FastGather(F)", Menu.Option.OptType.Toggle, false);
			Main.suicide = new Menu.Option("Suicide", Menu.Option.OptType.Toggle, false);
			Main.cavedarkenss = new Menu.Option("NoDarkness", Menu.Option.OptType.Toggle, true);
			Main.meleerange = new Menu.Option("MeleeDistance", Menu.Option.OptType.Toggle, false);
			Main.meleehack = new Menu.Option("SilentMelee", Menu.Option.OptType.Toggle, false);
			Main.meleewalls = new Menu.Option("MeleeThroughWalls", Menu.Option.OptType.Toggle, false);
			Main.shouldAlwaysBeDaytime = new Menu.Option("DayHack", Menu.Option.OptType.Toggle, false);
			Main.MiscCat.Items.AddRange(new Menu.Option[]
			{
				Main.suicide,
				Main.openbox,
				Main.aimkey2,
				Main.meleerange,
				Main.shouldAlwaysBeDaytime,
				Main.cavedarkenss,
				Main.meleehack,
				Main.meleewalls,
				Main.FastGathering
			});
			Main.Menu.Opts.Add(Main.EspCat);
			Main.Menu.Opts.Add(Main.RadarCat);
			Main.Menu.Opts.Add(Main.AimCat);
			Main.Menu.Opts.Add(Main.weaponmod);
			Main.Menu.Opts.Add(Main.MiscEspCat);
			Main.Menu.Opts.Add(Main.WorldEspCat);
			Main.Menu.Opts.Add(Main.AutoFarmCat);
			Main.Menu.Opts.Add(Main.FarmEspCat);
			Main.Menu.Opts.Add(Main.movement);
			Main.Menu.Opts.Add(Main.MiscCat);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000133E0 File Offset: 0x000115E0
		private void mychams()
		{
			if (Main.smethod_1(Main.smethod_0()))
			{
				if (Main.smethod_2(Main._multiMesh, null))
				{
					Main._multiMesh = Main.smethod_4(Main.smethod_3(typeof(PlayerModel).TypeHandle), "_multiMesh", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField);
				}
				if (Main.smethod_5(Main.chamShader, null))
				{
					IEnumerator<BasePlayer> enumerator = Main.smethod_6().GetEnumerator();
					try
					{
						while (Main.smethod_17(enumerator))
						{
							BasePlayer basePlayer = enumerator.Current;
							SkinnedMultiMesh skinnedMultiMesh = (SkinnedMultiMesh)Main.smethod_7(Main._multiMesh, basePlayer.playerModel);
							foreach (Renderer renderer in Main.smethod_8(skinnedMultiMesh))
							{
								if (Main.smethod_10(Main.smethod_9(renderer), "hair") && Main.smethod_5(basePlayer, null) && Main.smethod_5(renderer, null) && Main.smethod_5(skinnedMultiMesh, null))
								{
									if (Main.cham.GetData<bool>())
									{
										if (Main.smethod_11(renderer))
										{
											Main.smethod_12(renderer, false);
										}
									}
									else if (!Main.smethod_11(renderer))
									{
										Main.smethod_12(renderer, true);
									}
								}
								else if (Main.cham.GetData<bool>())
								{
									if (!Main.dictShaders.ContainsKey(Main.smethod_9(Main.smethod_13(renderer))))
									{
										Main.dictShaders.Add(Main.smethod_9(Main.smethod_13(renderer)), Main.smethod_14(Main.smethod_13(renderer)));
									}
									if (Main.smethod_5(Main.smethod_14(Main.smethod_13(renderer)), Main.chamShader))
									{
										Main.smethod_15(Main.smethod_13(renderer), Main.chamShader);
									}
								}
								else if (Main.dictShaders.ContainsKey(Main.smethod_9(Main.smethod_13(renderer))) && Main.smethod_16(Main.smethod_14(Main.smethod_13(renderer)), Main.chamShader))
								{
									Main.smethod_15(Main.smethod_13(renderer), Main.dictShaders[Main.smethod_9(Main.smethod_13(renderer))]);
								}
							}
						}
					}
					finally
					{
						if (enumerator != null)
						{
							Main.smethod_18(enumerator);
						}
					}
				}
			}
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00013620 File Offset: 0x00011820
		public static void nigger()
		{
			if (Main.smethod_5(Main.smethod_0(), null))
			{
				BasePlayer basePlayer = null;
				float num = 250f;
				if (Main.smethod_6() != null)
				{
					foreach (BasePlayer basePlayer2 in Main.smethod_6())
					{
						Vector3 vector = Main.smethod_21(MainCamera.mainCamera, Main.smethod_20(Main.smethod_19(basePlayer2.model.headBone)));
						float num2 = Mathf.Abs(Vector2.Distance(new Vector2((float)(Main.smethod_22() / 2), (float)(Main.smethod_23() / 2)), new Vector2(vector.x, (float)Screen.height - vector.y)));
						if (num2 <= Main.aimbotFov && num2 < num)
						{
							num = num2;
							basePlayer = basePlayer2;
						}
					}
				}
				if (basePlayer != null && !basePlayer.IsSleeping() && !basePlayer.IsLocalPlayer() && !basePlayer.IsDead())
				{
					Vector3 screenPos = Misc.GetScreenPos(basePlayer.model.headBone.transform.position);
					if (screenPos.z > 0f && Main.target.GetData<bool>())
					{
						Rendering.DrawLine2(new Vector2((float)Screen.width / 2f, (float)Screen.height), new Vector2(screenPos.x, (float)Screen.height - screenPos.y), Color.red, 2f);
					}
				}
			}
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x000137A4 File Offset: 0x000119A4
		private void yeanigga()
		{
			if (Main.inventory.GetData<bool>())
			{
				try
				{
					Dictionary<BasePlayer, int> dictionary = new Dictionary<BasePlayer, int>();
					Vector2 b = new Vector2((float)Main.smethod_22() / 2f, (float)Main.smethod_23() / 2f);
					IEnumerator<BasePlayer> enumerator = Main.smethod_6().GetEnumerator();
					try
					{
						while (Main.smethod_17(enumerator))
						{
							BasePlayer basePlayer = enumerator.Current;
							if (Main.smethod_5(basePlayer, null))
							{
								int value = (int)Vector2.Distance(Main.smethod_21(MainCamera.mainCamera, Main.smethod_20(Main.smethod_19(basePlayer))), b);
								Vector3 rhs = Main.smethod_20(Main.smethod_19(basePlayer)) - Main.smethod_20(Main.smethod_19(MainCamera.mainCamera));
								if (!Main.smethod_24(basePlayer) && Main.smethod_25(basePlayer) > 0f && Vector3.Dot(Main.smethod_26(Main.smethod_19(MainCamera.mainCamera), Vector3.forward), rhs) > 0f)
								{
									dictionary.Add(basePlayer, value);
								}
							}
						}
					}
					finally
					{
						if (enumerator != null)
						{
							Main.smethod_18(enumerator);
						}
					}
					if (dictionary.Count > 0)
					{
						dictionary = (from pair in dictionary
						orderby pair.Value
						select pair).ToDictionary((KeyValuePair<BasePlayer, int> pair) => pair.Key, (KeyValuePair<BasePlayer, int> pair) => pair.Value);
						BasePlayer basePlayer2 = dictionary.Keys.First<BasePlayer>();
						if (Main.smethod_5(basePlayer2, null))
						{
							Item[] array = Main.smethod_27(basePlayer2.inventory);
							Rect rect = new Rect((float)Main.smethod_22() - 250f, 60f, 200f, 35f + (float)(array.Length * 16));
							Rendering.DrawRadarBackground(rect);
							Rendering.DrawString3(new Vector2((float)Main.smethod_22() - 240f, 70f), basePlayer2.displayName, Color.white, false, 14, true);
							for (int i = 0; i < array.Length; i++)
							{
								if (array[i] != null)
								{
									Rendering.DrawString3(new Vector2((float)Screen.width - 240f, 70f + (float)((i + 1) * 16)), array[i].amount.ToString() + "x " + array[i].info.displayName.english, Color.white, false, 14, true);
								}
							}
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00013A58 File Offset: 0x00011C58
		public static void SpawnLadder()
		{
			if (Main.spawnlatter.GetData<bool>())
			{
				Main.smethod_29(GameManager.client, "assets/prefabs/building/ladder.wall.wood/ladder.wooden.wall.prefab", Main.smethod_0().lookingAtPoint, Quaternion.Euler(Main.smethod_28(Main.smethod_19(Main.smethod_0())).x, 90f, 0f), true);
			}
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00013AB0 File Offset: 0x00011CB0
		private void Update()
		{
			Main.Menu.Update();
			if (Main.spawnlatter.GetData<bool>() && Main.smethod_30((KeyCode)Main.aimkey1.GetSubContent<List<object>>().ElementAtOrDefault(Main.aimkey1.GetData<int>())))
			{
				Main.SpawnLadder();
			}
			Misc.BuildingRotation.RotateDown();
			Misc.BuildingRotation.RotateLeft();
			Misc.BuildingRotation.RotateRight();
			Misc.BuildingRotation.RotateUp();
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000048D4 File Offset: 0x00002AD4
		private void OnGUI()
		{
			Main.Menu.OnGUI();
			this.hm();
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00013B14 File Offset: 0x00011D14
		private void yeaaaaa()
		{
			if (Main.shouldDrawCrosshair.GetData<bool>())
			{
				GUI.DrawTexture(new Rect((float)Main.smethod_22() / 2f - 8f, (float)Main.smethod_23() / 2f - 8f, 16f, 16f), Misc.mTex);
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x000048E6 File Offset: 0x00002AE6
		private void hm()
		{
			PlayerESP.DrawPlayers();
			Main.nigger();
			Traps.traps();
			randomshit.randoms();
			this.yeanigga();
			this.yeaaaaa();
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000042CF File Offset: 0x000024CF
		static BasePlayer smethod_0()
		{
			return LocalPlayer.Entity;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x000040AF File Offset: 0x000022AF
		static bool smethod_1(UnityEngine.Object object_0)
		{
			return object_0;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x000047EF File Offset: 0x000029EF
		static bool smethod_2(FieldInfo fieldInfo_0, FieldInfo fieldInfo_1)
		{
			return fieldInfo_0 == fieldInfo_1;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00003E9E File Offset: 0x0000209E
		static Type smethod_3(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00003E19 File Offset: 0x00002019
		static FieldInfo smethod_4(Type type_0, string string_0, BindingFlags bindingFlags_0)
		{
			return type_0.GetField(string_0, bindingFlags_0);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000400D File Offset: 0x0000220D
		static bool smethod_5(UnityEngine.Object object_0, UnityEngine.Object object_1)
		{
			return object_0 != object_1;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000425F File Offset: 0x0000245F
		static BufferList<BasePlayer> smethod_6()
		{
			return BasePlayer.VisiblePlayerList;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00003E23 File Offset: 0x00002023
		static object smethod_7(FieldInfo fieldInfo_0, object object_0)
		{
			return fieldInfo_0.GetValue(object_0);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00004917 File Offset: 0x00002B17
		static List<Renderer> smethod_8(SkinnedMultiMesh skinnedMultiMesh_0)
		{
			return skinnedMultiMesh_0.Renderers;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000491F File Offset: 0x00002B1F
		static string smethod_9(UnityEngine.Object object_0)
		{
			return object_0.name;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000440F File Offset: 0x0000260F
		static bool smethod_10(string string_0, string string_1)
		{
			return string_0.Contains(string_1);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00004927 File Offset: 0x00002B27
		static bool smethod_11(Renderer renderer_0)
		{
			return renderer_0.enabled;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000492F File Offset: 0x00002B2F
		static void smethod_12(Renderer renderer_0, bool bool_0)
		{
			renderer_0.enabled = bool_0;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00004938 File Offset: 0x00002B38
		static Material smethod_13(Renderer renderer_0)
		{
			return renderer_0.material;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00003F95 File Offset: 0x00002195
		static Shader smethod_14(Material material_0)
		{
			return material_0.shader;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00004940 File Offset: 0x00002B40
		static void smethod_15(Material material_0, Shader shader_0)
		{
			material_0.shader = shader_0;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00003F62 File Offset: 0x00002162
		static bool smethod_16(UnityEngine.Object object_0, UnityEngine.Object object_1)
		{
			return object_0 == object_1;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000428F File Offset: 0x0000248F
		static bool smethod_17(IEnumerator ienumerator_0)
		{
			return ienumerator_0.MoveNext();
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00004297 File Offset: 0x00002497
		static void smethod_18(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000429F File Offset: 0x0000249F
		static Transform smethod_19(Component component_0)
		{
			return component_0.transform;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x000042A7 File Offset: 0x000024A7
		static Vector3 smethod_20(Transform transform_0)
		{
			return transform_0.position;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00004286 File Offset: 0x00002486
		static Vector3 smethod_21(Camera camera_0, Vector3 vector3_0)
		{
			return camera_0.WorldToScreenPoint(vector3_0);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000421B File Offset: 0x0000241B
		static int smethod_22()
		{
			return Screen.width;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00004222 File Offset: 0x00002422
		static int smethod_23()
		{
			return Screen.height;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00004266 File Offset: 0x00002466
		static bool smethod_24(BasePlayer basePlayer_0)
		{
			return basePlayer_0.IsLocalPlayer();
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00004276 File Offset: 0x00002476
		static float smethod_25(BaseCombatEntity baseCombatEntity_0)
		{
			return baseCombatEntity_0.health;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00004949 File Offset: 0x00002B49
		static Vector3 smethod_26(Transform transform_0, Vector3 vector3_0)
		{
			return transform_0.TransformDirection(vector3_0);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00004952 File Offset: 0x00002B52
		static Item[] smethod_27(PlayerInventory playerInventory_0)
		{
			return playerInventory_0.AllItems();
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000495A File Offset: 0x00002B5A
		static Quaternion smethod_28(Transform transform_0)
		{
			return transform_0.rotation;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00004962 File Offset: 0x00002B62
		static GameObject smethod_29(GameManager gameManager_0, string string_0, Vector3 vector3_0, Quaternion quaternion_0, bool bool_0)
		{
			return gameManager_0.CreatePrefab(string_0, vector3_0, quaternion_0, bool_0);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x000042D6 File Offset: 0x000024D6
		static bool smethod_30(KeyCode keyCode_0)
		{
			return Input.GetKey(keyCode_0);
		}

		// Token: 0x04000163 RID: 355
		public static Menu Menu = new Menu();

		// Token: 0x04000164 RID: 356
		public GameObject RandomObject = null;

		// Token: 0x04000165 RID: 357
		public static float MinDistance = 200f;

		// Token: 0x04000166 RID: 358
		public static float Distance = 1000f;

		// Token: 0x04000167 RID: 359
		public static float scientistdistance = 100f;

		// Token: 0x04000168 RID: 360
		public static float Distanceeee = 300f;

		// Token: 0x04000169 RID: 361
		public static float aimbotFov = 125f;

		// Token: 0x0400016A RID: 362
		public static float MaxDistance = 5000f;

		// Token: 0x0400016B RID: 363
		public static FieldInfo _multiMesh = null;

		// Token: 0x0400016C RID: 364
		public static Dictionary<string, Shader> dictShaders = new Dictionary<string, Shader>();

		// Token: 0x0400016D RID: 365
		public static Menu.Option EspCat;

		// Token: 0x0400016E RID: 366
		public static Menu.Option shouldDrawPlayers;

		// Token: 0x0400016F RID: 367
		public static Menu.Option playerbox;

		// Token: 0x04000170 RID: 368
		public static Menu.Option admin1;

		// Token: 0x04000171 RID: 369
		public static Menu.Option authlist;

		// Token: 0x04000172 RID: 370
		public static Menu.Option bowhack;

		// Token: 0x04000173 RID: 371
		public static Menu.Option shouldDrawStorage;

		// Token: 0x04000174 RID: 372
		public static Menu.Option shouldDrawHealthBar;

		// Token: 0x04000175 RID: 373
		public static Menu.Option shouldDrawEquipedItem;

		// Token: 0x04000176 RID: 374
		public static Menu.Option demolish;

		// Token: 0x04000177 RID: 375
		public static Menu.Option doorheks;

		// Token: 0x04000178 RID: 376
		public static Menu.Option autounlock;

		// Token: 0x04000179 RID: 377
		public static Menu.Option heliaim;

		// Token: 0x0400017A RID: 378
		public static Menu.Option autoupgrade;

		// Token: 0x0400017B RID: 379
		public static Menu.Option inventory;

		// Token: 0x0400017C RID: 380
		public static Menu.Option target;

		// Token: 0x0400017D RID: 381
		public static Menu.Option fovforaimbot;

		// Token: 0x0400017E RID: 382
		public static Menu.Option moveable;

		// Token: 0x0400017F RID: 383
		public static Menu.Option Skeleton;

		// Token: 0x04000180 RID: 384
		public static Menu.Option shouldDrawSleepers;

		// Token: 0x04000181 RID: 385
		public static Menu.Option shouldDrawCorpses;

		// Token: 0x04000182 RID: 386
		public static Menu.Option npc;

		// Token: 0x04000183 RID: 387
		public static Menu.Option animalradar;

		// Token: 0x04000184 RID: 388
		public static Menu.Option shouldDrawFridges;

		// Token: 0x04000185 RID: 389
		public static Menu.Option shouldDrawCrates;

		// Token: 0x04000186 RID: 390
		public static Menu.Option testing;

		// Token: 0x04000187 RID: 391
		public static Menu.Option shouldDrawLightSources;

		// Token: 0x04000188 RID: 392
		public static Menu.Option shouldDrawQuarries;

		// Token: 0x04000189 RID: 393
		public static Menu.Option shouldDrawOthers;

		// Token: 0x0400018A RID: 394
		public static Menu.Option VisCheck;

		// Token: 0x0400018B RID: 395
		public static Menu.Option shouldDrawHeli;

		// Token: 0x0400018C RID: 396
		public static Menu.Option shouldDrawAnimals;

		// Token: 0x0400018D RID: 397
		public static Menu.Option hemp;

		// Token: 0x0400018E RID: 398
		public static Menu.Option Radar101;

		// Token: 0x0400018F RID: 399
		public static Menu.Option shouldDrawTurrets;

		// Token: 0x04000190 RID: 400
		public static Menu.Option ForceAutomatic;

		// Token: 0x04000191 RID: 401
		public static Menu.Option shouldNoSway;

		// Token: 0x04000192 RID: 402
		public static Menu.Option shouldDrawWorldItems;

		// Token: 0x04000193 RID: 403
		public static Menu.Option guntrap;

		// Token: 0x04000194 RID: 404
		public static Menu.Option flametrap;

		// Token: 0x04000195 RID: 405
		public static Menu.Option landmine;

		// Token: 0x04000196 RID: 406
		public static Menu.Option beartrap;

		// Token: 0x04000197 RID: 407
		public static Menu.Option stone1;

		// Token: 0x04000198 RID: 408
		public static Menu.Option resize;

		// Token: 0x04000199 RID: 409
		public static Menu.Option metal1;

		// Token: 0x0400019A RID: 410
		public static Menu.Option instantloot;

		// Token: 0x0400019B RID: 411
		public static Menu.Option sulfur1;

		// Token: 0x0400019C RID: 412
		public static Menu.Option shouldDrawTrash;

		// Token: 0x0400019D RID: 413
		public static Menu.Option DisableGrass;

		// Token: 0x0400019E RID: 414
		public static Menu.Option Sleepingbag;

		// Token: 0x0400019F RID: 415
		public static Menu.Option shouldDrawCampfires;

		// Token: 0x040001A0 RID: 416
		public static Menu.Option nospreadhvhxd;

		// Token: 0x040001A1 RID: 417
		public static Menu.Option shouldDrawBarrels;

		// Token: 0x040001A2 RID: 418
		public static Menu.Option airdrop;

		// Token: 0x040001A3 RID: 419
		public static Menu.Option shouldDrawFurnaces;

		// Token: 0x040001A4 RID: 420
		public static Menu.Option shouldDrawRecyclers;

		// Token: 0x040001A5 RID: 421
		public static Menu.Option shouldDrawRefineries;

		// Token: 0x040001A6 RID: 422
		public static Menu.Option shouldDrawStashes;

		// Token: 0x040001A7 RID: 423
		public static Menu.Option shouldDrawFoodboxes;

		// Token: 0x040001A8 RID: 424
		public static Menu.Option shouldDrawRepairBenches;

		// Token: 0x040001A9 RID: 425
		public static Menu.Option shouldDrawVendingMachines;

		// Token: 0x040001AA RID: 426
		public static Menu.Option shouldDrawWaterCatchers;

		// Token: 0x040001AB RID: 427
		public static Menu.Option woodbox;

		// Token: 0x040001AC RID: 428
		public static Menu.Option largebox;

		// Token: 0x040001AD RID: 429
		public static Menu.Option shouldDrawCupboards;

		// Token: 0x040001AE RID: 430
		public static Menu.Option shouldDrawCollectible;

		// Token: 0x040001AF RID: 431
		public static Menu.Option stone;

		// Token: 0x040001B0 RID: 432
		public static Menu.Option RadarStoneOre;

		// Token: 0x040001B1 RID: 433
		public static Menu.Option RadarSulfurOre;

		// Token: 0x040001B2 RID: 434
		public static Menu.Option nosink;

		// Token: 0x040001B3 RID: 435
		public static Menu.Option RadarMetalOre;

		// Token: 0x040001B4 RID: 436
		public static Menu.Option shouldDrawDoors;

		// Token: 0x040001B5 RID: 437
		public static Menu.Option Esp_Enemy_Color_Visible;

		// Token: 0x040001B6 RID: 438
		public static Menu.Option Esp_Team_Color;

		// Token: 0x040001B7 RID: 439
		public static Menu.Option Esp_Team_Color_Visible;

		// Token: 0x040001B8 RID: 440
		public static Menu.Option Esp_VisibilityCheck;

		// Token: 0x040001B9 RID: 441
		public static List<object> EspColors = new List<object>
		{
			Color.red,
			Color.yellow,
			Color.white,
			Color.green,
			Color.blue,
			Color.black
		};

		// Token: 0x040001BA RID: 442
		public static Menu.Option AimCat;

		// Token: 0x040001BB RID: 443
		public static Menu.Option Aim_Key;

		// Token: 0x040001BC RID: 444
		public static Menu.Option shouldEnableAimbot;

		// Token: 0x040001BD RID: 445
		public static Menu.Option BulletDropPrediction;

		// Token: 0x040001BE RID: 446
		public static Menu.Option shouldDrawCrosshair;

		// Token: 0x040001BF RID: 447
		public static Menu.Option autopickup1;

		// Token: 0x040001C0 RID: 448
		public static Menu.Option jackhammerhack;

		// Token: 0x040001C1 RID: 449
		public static Menu.Option autopickup2;

		// Token: 0x040001C2 RID: 450
		public static Menu.Option autopickup3;

		// Token: 0x040001C3 RID: 451
		public static Menu.Option autopickup4;

		// Token: 0x040001C4 RID: 452
		public static Menu.Option gravity;

		// Token: 0x040001C5 RID: 453
		public static Menu.Option MiscEspCat;

		// Token: 0x040001C6 RID: 454
		public static Menu.Option meleerange;

		// Token: 0x040001C7 RID: 455
		public static Menu.Option jump;

		// Token: 0x040001C8 RID: 456
		public static Menu.Option autopickup;

		// Token: 0x040001C9 RID: 457
		public static Menu.Option instant;

		// Token: 0x040001CA RID: 458
		public static Menu.Option showid;

		// Token: 0x040001CB RID: 459
		public static Menu.Option Radar1011;

		// Token: 0x040001CC RID: 460
		public static Menu.Option RadarCat;

		// Token: 0x040001CD RID: 461
		public static Menu.Option autofarm;

		// Token: 0x040001CE RID: 462
		public static Menu.Option shouldDrawResources;

		// Token: 0x040001CF RID: 463
		public static Menu.Option shoot;

		// Token: 0x040001D0 RID: 464
		public static Menu.Option meleehack;

		// Token: 0x040001D1 RID: 465
		public static Menu.Option WorldEspCat;

		// Token: 0x040001D2 RID: 466
		public static Menu.Option autopick;

		// Token: 0x040001D3 RID: 467
		public static Menu.Option eastereggs;

		// Token: 0x040001D4 RID: 468
		public static Menu.Option openbox;

		// Token: 0x040001D5 RID: 469
		public static Menu.Option autolight;

		// Token: 0x040001D6 RID: 470
		public static Menu.Option cham;

		// Token: 0x040001D7 RID: 471
		public static Menu.Option autofarm5;

		// Token: 0x040001D8 RID: 472
		public static Menu.Option bows;

		// Token: 0x040001D9 RID: 473
		public static Menu.Option autolock;

		// Token: 0x040001DA RID: 474
		public static Menu.Option boatesp;

		// Token: 0x040001DB RID: 475
		public static Menu.Option fastheal;

		// Token: 0x040001DC RID: 476
		public static Menu.Option AutoFarmCat;

		// Token: 0x040001DD RID: 477
		public static Menu.Option shouldAlwaysBeDaytime;

		// Token: 0x040001DE RID: 478
		public static Menu.Option admin;

		// Token: 0x040001DF RID: 479
		public static Menu.Option bradly;

		// Token: 0x040001E0 RID: 480
		public static Menu.Option shouldNoRecoil;

		// Token: 0x040001E1 RID: 481
		public static Menu.Option meleewalls;

		// Token: 0x040001E2 RID: 482
		public static Menu.Option autofarm2;

		// Token: 0x040001E3 RID: 483
		public static Menu.Option NoFallDamage;

		// Token: 0x040001E4 RID: 484
		public static Menu.Option killafterdead;

		// Token: 0x040001E5 RID: 485
		public static Menu.Option weaponmod;

		// Token: 0x040001E6 RID: 486
		public static Menu.Option FastGathering;

		// Token: 0x040001E7 RID: 487
		public static Menu.Option removeblack;

		// Token: 0x040001E8 RID: 488
		public static Menu.Option ClimbHack;

		// Token: 0x040001E9 RID: 489
		public static Menu.Option noclip;

		// Token: 0x040001EA RID: 490
		public static Menu.Option untieall;

		// Token: 0x040001EB RID: 491
		public static Menu.Option spawnlatter;

		// Token: 0x040001EC RID: 492
		public static Menu.Option VelocityPrediction;

		// Token: 0x040001ED RID: 493
		public static Menu.Option MiscCat;

		// Token: 0x040001EE RID: 494
		public static Menu.Option autopush;

		// Token: 0x040001EF RID: 495
		public static Menu.Option explosives;

		// Token: 0x040001F0 RID: 496
		public static Menu.Option noloss;

		// Token: 0x040001F1 RID: 497
		public static Menu.Option chinook;

		// Token: 0x040001F2 RID: 498
		public static Menu.Option dropzones;

		// Token: 0x040001F3 RID: 499
		public static Menu.Option aimarmour;

		// Token: 0x040001F4 RID: 500
		public static Menu.Option FarmEspCat;

		// Token: 0x040001F5 RID: 501
		public static Menu.Option healfriend;

		// Token: 0x040001F6 RID: 502
		public static Menu.Option stash1;

		// Token: 0x040001F7 RID: 503
		public static Menu.Option aimkey1;

		// Token: 0x040001F8 RID: 504
		public static Menu.Option aimkey2;

		// Token: 0x040001F9 RID: 505
		public static Menu.Option aimkey3;

		// Token: 0x040001FA RID: 506
		public static Menu.Option aimkey4;

		// Token: 0x040001FB RID: 507
		public static Menu.Option miniheli;

		// Token: 0x040001FC RID: 508
		public static Menu.Option aimkey5;

		// Token: 0x040001FD RID: 509
		public static Menu.Option rage;

		// Token: 0x040001FE RID: 510
		public static Menu.Option suicide;

		// Token: 0x040001FF RID: 511
		public static Menu.Option rage1;

		// Token: 0x04000200 RID: 512
		public static Menu.Option rage2;

		// Token: 0x04000201 RID: 513
		public static Menu.Option drink;

		// Token: 0x04000202 RID: 514
		public static Menu.Option legit;

		// Token: 0x04000203 RID: 515
		public static Menu.Option legit1;

		// Token: 0x04000204 RID: 516
		public static Menu.Option HOTKEY9;

		// Token: 0x04000205 RID: 517
		public static Menu.Option Distancee;

		// Token: 0x04000206 RID: 518
		public static Menu.Option vert;

		// Token: 0x04000207 RID: 519
		public static Menu.Option HOTKEY;

		// Token: 0x04000208 RID: 520
		public static Menu.Option HOTKEY1;

		// Token: 0x04000209 RID: 521
		public static Menu.Option HOTKEY2;

		// Token: 0x0400020A RID: 522
		public static Menu.Option body;

		// Token: 0x0400020B RID: 523
		public static Menu.Option HOTKEY3;

		// Token: 0x0400020C RID: 524
		public static Menu.Option silentaimbotheli;

		// Token: 0x0400020D RID: 525
		public static Menu.Option shotgunnospread;

		// Token: 0x0400020E RID: 526
		public static Menu.Option autounlockcodekey;

		// Token: 0x0400020F RID: 527
		public static Menu.Option silentaimbot;

		// Token: 0x04000210 RID: 528
		public static Menu.Option fasty;

		// Token: 0x04000211 RID: 529
		public static Menu.Option speedhek;

		// Token: 0x04000212 RID: 530
		public static Menu.Option killscientist;

		// Token: 0x04000213 RID: 531
		public static Menu.Option aimkeyvisible;

		// Token: 0x04000214 RID: 532
		public static Menu.Option friends;

		// Token: 0x04000215 RID: 533
		public static Menu.Option friendcolor;

		// Token: 0x04000216 RID: 534
		public static Menu.Option skeletoncolor;

		// Token: 0x04000217 RID: 535
		public static Menu.Option swim;

		// Token: 0x04000218 RID: 536
		public static Menu.Option movement;

		// Token: 0x04000219 RID: 537
		public static Menu.Option laddermovement;

		// Token: 0x0400021A RID: 538
		public static Menu.Option seated;

		// Token: 0x0400021B RID: 539
		public static Menu.Option silentaimbotdick;

		// Token: 0x0400021C RID: 540
		public static Menu.Option localcontrol;

		// Token: 0x0400021D RID: 541
		public static Menu.Option cavedarkenss;

		// Token: 0x0400021E RID: 542
		public static Shader chamShader;

		// Token: 0x0200004C RID: 76
		public static class Chams
		{
			// Token: 0x0600030F RID: 783 RVA: 0x0000496F File Offset: 0x00002B6F
			// Note: this type is marked as 'beforefieldinit'.
			static Chams()
			{
				byte[] array_ = new byte[4909];
				Main.Chams.smethod_0(array_, fieldof(<PrivateImplementationDetails>.struct7_0).FieldHandle);
				Main.Chams.chams = array_;
			}

			// Token: 0x06000310 RID: 784 RVA: 0x0000498B File Offset: 0x00002B8B
			static void smethod_0(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
			{
				RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
			}

			// Token: 0x0400021F RID: 543
			public static byte[] chams;
		}
	}
}
