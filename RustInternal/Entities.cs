using System;
using System.Collections;
using System.Collections.Generic;
using ProtoBuf;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000041 RID: 65
	public class Entities : MonoBehaviour
	{
		// Token: 0x0600027C RID: 636 RVA: 0x0000EB60 File Offset: 0x0000CD60
		private void Start()
		{
			Entities.stashes = new HashSet<StashContainer>();
			Entities.containers = new HashSet<StorageContainer>();
			Entities.hempBushes = new HashSet<CollectibleEntity>();
			Entities.collectibles = new HashSet<CollectibleEntity>();
			Entities.stone = new HashSet<CollectibleEntity>();
			Entities.mushroom = new HashSet<CollectibleEntity>();
			Entities.heli1 = new HashSet<BaseHelicopter>();
			Entities.door = new HashSet<global::CodeLock>();
			Entities.land = new HashSet<global::Landmine>();
			Entities.oretest1 = new HashSet<OreResourceEntity>();
			Entities.combatshit = new HashSet<BaseCombatEntity>();
			Entities.oreandtrees = new HashSet<ResourceEntity>();
			Entities.baseentity = new HashSet<global::BaseEntity>();
			Entities.oretest2 = new HashSet<OreResourceEntity>();
			Entities.boat = new HashSet<MotorRowboat>();
			Entities.shit = new HashSet<global::BuildingBlock>();
			Entities.shit1 = new HashSet<global::BuildingBlock>();
			Entities.shit2 = new HashSet<global::BuildingBlock>();
			Entities.shit3 = new HashSet<global::BuildingBlock>();
			Entities.tor = new HashSet<TorchWeapon>();
			Entities.metal = new HashSet<CollectibleEntity>();
			Entities.trees = new HashSet<TreeEntity>();
			Entities.tank = new HashSet<global::BradleyAPC>();
			Entities.sulfur = new HashSet<CollectibleEntity>();
			Entities.orehotspot = new HashSet<OreHotSpot>();
			Entities.whatever = new HashSet<CompoundBowWeapon>();
			Entities.plan1 = new HashSet<global::BaseNetworkable>();
			Entities.bear = new HashSet<BearTrap>();
			Entities.airdrops = new HashSet<SupplyDrop>();
			Entities.key = new HashSet<Keycard>();
			Entities.oretest = new HashSet<OreResourceEntity>();
			Entities.tcshit = new HashSet<BuildingPrivlidge>();
			Entities.oretest21 = new HashSet<OreResourceEntity>();
			Entities.treemarkerr = new HashSet<TreeMarker>();
			Entities.tool = new HashSet<BaseMelee>();
			Entities.bow = new HashSet<BowWeapon>();
			Entities.yea = new HashSet<TimedExplosive>();
			Entities.plan = new HashSet<Planner>();
			Entities.ch47 = new HashSet<CH47Helicopter>();
			Entities.baseliquid = new HashSet<BaseLiquidVessel>();
			Entities.jachammer = new HashSet<Jackhammer>();
			Entities.fuck = new HashSet<MedicalTool>();
			Entities.testing1 = new HashSet<MiniCopter>();
			Entities.hammertime = new HashSet<Jackhammer>();
			Entities.eggs = new HashSet<CollectableEasterEgg>();
			Entities.baloon = new HashSet<global::HotAirBalloon>();
			Entities.autoturretsss = new HashSet<global::AutoTurret>();
			Entities.niggers = new HashSet<Planner>();
			Entities.strike = new HashSet<FlintStrikeWeapon>();
			Entities.baseentity2 = new HashSet<global::BaseEntity>();
			Entities.eokt = new HashSet<FlintStrikeWeapon>();
			Entities.yeahh = new HashSet<BaseMountable>();
			Entities.eggs1 = new HashSet<EasterBasket>();
			Entities.corpses = new HashSet<global::LootableCorpse>();
			Entities.baseentity4 = new HashSet<global::BaseEntity>();
			Entities.dorhackl = new HashSet<Door>();
			Entities.sleepingBags = new HashSet<global::SleepingBag>();
			Entities.droppedItems = new HashSet<global::WorldItem>();
			Entities.baseentity1 = new HashSet<global::BaseEntity>();
			Entities.smethod_0(this, Entities.GetEntities());
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00004769 File Offset: 0x00002969
		public static IEnumerator GetEntities()
		{
			int num;
			do
			{
				if (Entities.<GetEntities>d__1.smethod_1(Entities.<GetEntities>d__1.smethod_0(), null) && Entities.<GetEntities>d__1.smethod_2(Entities.<GetEntities>d__1.smethod_0()) && global::BaseNetworkable.clientEntities != null)
				{
					Entities.stashes.Clear();
					Entities.containers.Clear();
					Entities.hempBushes.Clear();
					Entities.collectibles.Clear();
					Entities.fuck.Clear();
					Entities.airdrops.Clear();
					Entities.bear.Clear();
					Entities.strike.Clear();
					Entities.land.Clear();
					Entities.combatshit.Clear();
					Entities.shit.Clear();
					Entities.shit1.Clear();
					Entities.tor.Clear();
					Entities.jachammer.Clear();
					Entities.shit2.Clear();
					Entities.yeahh.Clear();
					Entities.shit3.Clear();
					Entities.heli1.Clear();
					Entities.eokt.Clear();
					Entities.tool.Clear();
					Entities.oretest1.Clear();
					Entities.oretest2.Clear();
					Entities.plan1.Clear();
					Entities.door.Clear();
					Entities.tank.Clear();
					Entities.bow.Clear();
					Entities.oreandtrees.Clear();
					Entities.baseentity.Clear();
					Entities.boat.Clear();
					Entities.orehotspot.Clear();
					Entities.plan.Clear();
					Entities.baseentity2.Clear();
					Entities.ch47.Clear();
					Entities.baseliquid.Clear();
					Entities.baloon.Clear();
					Entities.tcshit.Clear();
					Entities.stone.Clear();
					Entities.whatever.Clear();
					Entities.dorhackl.Clear();
					Entities.yea.Clear();
					Entities.niggers.Clear();
					Entities.autoturretsss.Clear();
					Entities.baseentity1.Clear();
					Entities.trees.Clear();
					Entities.testing1.Clear();
					Entities.key.Clear();
					Entities.mushroom.Clear();
					Entities.metal.Clear();
					Entities.baseentity4.Clear();
					Entities.eggs.Clear();
					Entities.oretest.Clear();
					Entities.eggs1.Clear();
					Entities.treemarkerr.Clear();
					Entities.oretest21.Clear();
					Entities.sulfur.Clear();
					Entities.hammertime.Clear();
					Entities.corpses.Clear();
					Entities.sleepingBags.Clear();
					Entities.droppedItems.Clear();
					IEnumerator<global::BaseNetworkable> enumerator = Entities.<GetEntities>d__1.smethod_3(global::BaseNetworkable.clientEntities);
					try
					{
						while (Entities.<GetEntities>d__1.smethod_6(enumerator))
						{
							global::BaseNetworkable baseNetworkable = enumerator.Current;
							if (baseNetworkable is StashContainer && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.stashes != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as StashContainer))
							{
								Entities.stashes.Add(baseNetworkable as StashContainer);
							}
							if (baseNetworkable is StorageContainer && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.containers != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as StorageContainer))
							{
								Entities.containers.Add(baseNetworkable as StorageContainer);
							}
							if (baseNetworkable is CollectibleEntity && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.hempBushes != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as CollectibleEntity) && Entities.<GetEntities>d__1.smethod_5(Entities.<GetEntities>d__1.smethod_4(baseNetworkable), "hemp"))
							{
								Entities.hempBushes.Add(baseNetworkable as CollectibleEntity);
							}
							if (baseNetworkable is CollectibleEntity && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.stone != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as CollectibleEntity) && Entities.<GetEntities>d__1.smethod_5(Entities.<GetEntities>d__1.smethod_4(baseNetworkable), "stone"))
							{
								Entities.stone.Add(baseNetworkable as CollectibleEntity);
							}
							if (baseNetworkable is CollectibleEntity && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.mushroom != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as CollectibleEntity) && Entities.<GetEntities>d__1.smethod_5(Entities.<GetEntities>d__1.smethod_4(baseNetworkable), "mushroom"))
							{
								Entities.mushroom.Add(baseNetworkable as CollectibleEntity);
							}
							if (baseNetworkable is global::Landmine && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.land != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as global::Landmine))
							{
								Entities.land.Add(baseNetworkable as global::Landmine);
							}
							if (baseNetworkable is CollectibleEntity && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.metal != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as CollectibleEntity) && Entities.<GetEntities>d__1.smethod_5(Entities.<GetEntities>d__1.smethod_4(baseNetworkable), "metal"))
							{
								Entities.metal.Add(baseNetworkable as CollectibleEntity);
							}
							if (baseNetworkable is MotorRowboat && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.boat != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as MotorRowboat))
							{
								Entities.boat.Add(baseNetworkable as MotorRowboat);
							}
							if (baseNetworkable is CollectibleEntity && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.sulfur != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as CollectibleEntity) && Entities.<GetEntities>d__1.smethod_5(Entities.<GetEntities>d__1.smethod_4(baseNetworkable), "sulfur"))
							{
								Entities.sulfur.Add(baseNetworkable as CollectibleEntity);
							}
							if (baseNetworkable is BaseMountable && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.yeahh != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as BaseMountable))
							{
								Entities.yeahh.Add(baseNetworkable as BaseMountable);
							}
							if (baseNetworkable is CollectibleEntity && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.collectibles != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as CollectibleEntity))
							{
								Entities.collectibles.Add(baseNetworkable as CollectibleEntity);
							}
							if (baseNetworkable is OreHotSpot && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.tool1 != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as OreHotSpot))
							{
								Entities.tool1.Add(baseNetworkable as OreHotSpot);
							}
							if (baseNetworkable is FlintStrikeWeapon && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.strike != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as FlintStrikeWeapon))
							{
								Entities.strike.Add(baseNetworkable as FlintStrikeWeapon);
							}
							if (baseNetworkable is SupplyDrop && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.airdrops != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as SupplyDrop))
							{
								Entities.airdrops.Add(baseNetworkable as SupplyDrop);
							}
							if (baseNetworkable is TreeEntity && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.trees != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as TreeEntity))
							{
								Entities.trees.Add(baseNetworkable as TreeEntity);
							}
							if (baseNetworkable is BaseMelee && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.tool != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as BaseMelee))
							{
								Entities.tool.Add(baseNetworkable as BaseMelee);
							}
							if (baseNetworkable is OreResourceEntity && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.oretest != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as OreResourceEntity) && Entities.<GetEntities>d__1.smethod_5(Entities.<GetEntities>d__1.smethod_4(baseNetworkable), "stone"))
							{
								Entities.oretest.Add(baseNetworkable as OreResourceEntity);
							}
							if (baseNetworkable is OreResourceEntity && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.oretest1 != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as OreResourceEntity) && Entities.<GetEntities>d__1.smethod_5(Entities.<GetEntities>d__1.smethod_4(baseNetworkable), "metal"))
							{
								Entities.oretest1.Add(baseNetworkable as OreResourceEntity);
							}
							if (baseNetworkable is BearTrap && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.bear != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as BearTrap))
							{
								Entities.bear.Add(baseNetworkable as BearTrap);
							}
							if (baseNetworkable is TimedExplosive && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.yea != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as TimedExplosive))
							{
								Entities.yea.Add(baseNetworkable as TimedExplosive);
							}
							if (baseNetworkable is OreResourceEntity && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.oretest2 != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as OreResourceEntity) && Entities.<GetEntities>d__1.smethod_5(Entities.<GetEntities>d__1.smethod_4(baseNetworkable), "sulfur"))
							{
								Entities.oretest2.Add(baseNetworkable as OreResourceEntity);
							}
							if (baseNetworkable is OreResourceEntity && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.oretest21 != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as OreResourceEntity))
							{
								Entities.oretest21.Add(baseNetworkable as OreResourceEntity);
							}
							if (baseNetworkable is MedicalTool && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.fuck != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as MedicalTool))
							{
								Entities.fuck.Add(baseNetworkable as MedicalTool);
							}
							if (baseNetworkable is global::BaseEntity && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.baseentity != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as global::BaseEntity) && Entities.<GetEntities>d__1.smethod_5(Entities.<GetEntities>d__1.smethod_4(baseNetworkable), "crate_underwater"))
							{
								Entities.baseentity.Add(baseNetworkable as global::BaseEntity);
							}
							if (baseNetworkable is global::BaseEntity && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.baseentity4 != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as global::BaseEntity) && Entities.<GetEntities>d__1.smethod_5(Entities.<GetEntities>d__1.smethod_4(baseNetworkable), "collectableegg"))
							{
								Entities.baseentity4.Add(baseNetworkable as global::BaseEntity);
							}
							if (baseNetworkable is global::BaseEntity && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.baseentity1 != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as global::BaseEntity))
							{
								Entities.baseentity1.Add(baseNetworkable as global::BaseEntity);
							}
							if (baseNetworkable is global::BaseEntity && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.baseentity2 != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as global::BaseEntity))
							{
								Entities.baseentity2.Add(baseNetworkable as global::BaseEntity);
							}
							if (baseNetworkable is BaseCombatEntity && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.combatshit != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as BaseCombatEntity))
							{
								Entities.combatshit.Add(baseNetworkable as BaseCombatEntity);
							}
							if (baseNetworkable is Planner && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.plan != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as Planner))
							{
								Entities.plan.Add(baseNetworkable as Planner);
							}
							if (baseNetworkable is TorchWeapon && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.tor != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as TorchWeapon))
							{
								Entities.tor.Add(baseNetworkable as TorchWeapon);
							}
							if (baseNetworkable is global::BuildingBlock && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.shit != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as global::BuildingBlock) && Entities.<GetEntities>d__1.smethod_5(Entities.<GetEntities>d__1.smethod_4(baseNetworkable), "wall"))
							{
								Entities.shit.Add(baseNetworkable as global::BuildingBlock);
							}
							if (baseNetworkable is global::BuildingBlock && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.shit != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as global::BuildingBlock) && Entities.<GetEntities>d__1.smethod_5(Entities.<GetEntities>d__1.smethod_4(baseNetworkable), "foundation"))
							{
								Entities.shit.Add(baseNetworkable as global::BuildingBlock);
							}
							if (baseNetworkable is global::BuildingBlock && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.shit != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as global::BuildingBlock) && Entities.<GetEntities>d__1.smethod_5(Entities.<GetEntities>d__1.smethod_4(baseNetworkable), "block"))
							{
								Entities.shit.Add(baseNetworkable as global::BuildingBlock);
							}
							if (baseNetworkable is global::BuildingBlock && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.shit != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as global::BuildingBlock) && Entities.<GetEntities>d__1.smethod_5(Entities.<GetEntities>d__1.smethod_4(baseNetworkable), "floor"))
							{
								Entities.shit.Add(baseNetworkable as global::BuildingBlock);
							}
							if (baseNetworkable is global::BradleyAPC && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.tank != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as global::BradleyAPC))
							{
								Entities.tank.Add(baseNetworkable as global::BradleyAPC);
							}
							if (baseNetworkable is global::BuildingBlock && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.shit != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as global::BuildingBlock) && Entities.<GetEntities>d__1.smethod_5(Entities.<GetEntities>d__1.smethod_4(baseNetworkable), "roof"))
							{
								Entities.shit.Add(baseNetworkable as global::BuildingBlock);
							}
							if (baseNetworkable is BaseHelicopter && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.heli1 != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as BaseHelicopter))
							{
								Entities.heli1.Add(baseNetworkable as BaseHelicopter);
							}
							if (baseNetworkable is BowWeapon && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.bow != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as BowWeapon))
							{
								Entities.bow.Add(baseNetworkable as BowWeapon);
							}
							if (baseNetworkable is Jackhammer && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.jachammer != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as Jackhammer))
							{
								Entities.jachammer.Add(baseNetworkable as Jackhammer);
							}
							if (baseNetworkable is CH47Helicopter && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.ch47 != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as CH47Helicopter))
							{
								Entities.ch47.Add(baseNetworkable as CH47Helicopter);
							}
							if (baseNetworkable is CompoundBowWeapon && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.whatever != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as CompoundBowWeapon))
							{
								Entities.whatever.Add(baseNetworkable as CompoundBowWeapon);
							}
							if (baseNetworkable is Door && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.dorhackl != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as Door))
							{
								Entities.dorhackl.Add(baseNetworkable as Door);
							}
							if (baseNetworkable is OreHotSpot && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.orehotspot != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as OreHotSpot))
							{
								Entities.orehotspot.Add(baseNetworkable as OreHotSpot);
							}
							if (baseNetworkable is Keycard && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.key != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as Keycard))
							{
								Entities.key.Add(baseNetworkable as Keycard);
							}
							if (baseNetworkable is Jackhammer && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.key != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as Jackhammer))
							{
								Entities.hammertime.Add(baseNetworkable as Jackhammer);
							}
							if (baseNetworkable is EasterBasket && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.eggs1 != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as EasterBasket))
							{
								Entities.eggs1.Add(baseNetworkable as EasterBasket);
							}
							if (baseNetworkable is MiniCopter && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.testing1 != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as MiniCopter))
							{
								Entities.testing1.Add(baseNetworkable as MiniCopter);
							}
							if (baseNetworkable is Planner && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.niggers != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as Planner))
							{
								Entities.niggers.Add(baseNetworkable as Planner);
							}
							if (baseNetworkable is CollectableEasterEgg && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.eggs != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as CollectableEasterEgg))
							{
								Entities.eggs.Add(baseNetworkable as CollectableEasterEgg);
							}
							if (baseNetworkable is global::HotAirBalloon && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.baloon != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as global::HotAirBalloon))
							{
								Entities.baloon.Add(baseNetworkable as global::HotAirBalloon);
							}
							if (baseNetworkable is BaseLiquidVessel && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.baseliquid != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as BaseLiquidVessel))
							{
								Entities.baseliquid.Add(baseNetworkable as BaseLiquidVessel);
							}
							if (baseNetworkable != null && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.plan1 != null)
							{
								Entities.plan1.Add(baseNetworkable);
							}
							if (baseNetworkable is BuildingPrivlidge && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.tcshit != null)
							{
								Entities.tcshit.Add(baseNetworkable as BuildingPrivlidge);
							}
							if (baseNetworkable is global::AutoTurret && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.autoturretsss != null)
							{
								Entities.autoturretsss.Add(baseNetworkable as global::AutoTurret);
							}
							if (baseNetworkable is FlintStrikeWeapon && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.eokt != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as FlintStrikeWeapon))
							{
								Entities.eokt.Add(baseNetworkable as FlintStrikeWeapon);
							}
							if (baseNetworkable is TreeMarker && Entities.<GetEntities>d__1.smethod_1(baseNetworkable, null) && Entities.treemarkerr != null && Entities.<GetEntities>d__1.smethod_2(baseNetworkable as TreeMarker))
							{
								Entities.treemarkerr.Add(baseNetworkable as TreeMarker);
							}
							ResourceEntity oreandtrees;
							if (Entities.<GetEntities>d__1.smethod_1(oreandtrees = (baseNetworkable as ResourceEntity), null) && Entities.<GetEntities>d__1.smethod_1(oreandtrees, null) && Entities.<GetEntities>d__1.smethod_2(oreandtrees))
							{
								Entities.oreandtrees.Add(oreandtrees);
							}
							global::LootableCorpse lootableCorpse;
							if (Entities.<GetEntities>d__1.smethod_1(lootableCorpse = (baseNetworkable as global::LootableCorpse), null) && Entities.<GetEntities>d__1.smethod_1(lootableCorpse, null) && Entities.<GetEntities>d__1.smethod_2(lootableCorpse))
							{
								Entities.corpses.Add(lootableCorpse);
							}
							global::SleepingBag sleepingBag;
							if (Entities.<GetEntities>d__1.smethod_1(sleepingBag = (baseNetworkable as global::SleepingBag), null) && Entities.<GetEntities>d__1.smethod_1(sleepingBag, null) && Entities.<GetEntities>d__1.smethod_2(sleepingBag))
							{
								Entities.sleepingBags.Add(sleepingBag);
							}
							global::CodeLock door;
							if (Entities.<GetEntities>d__1.smethod_1(door = (baseNetworkable as global::CodeLock), null) && Entities.<GetEntities>d__1.smethod_1(door, null) && Entities.<GetEntities>d__1.smethod_2(door))
							{
								Entities.door.Add(door);
							}
							global::WorldItem worldItem;
							if (Entities.<GetEntities>d__1.smethod_1(worldItem = (baseNetworkable as global::WorldItem), null) && Entities.<GetEntities>d__1.smethod_1(worldItem, null) && Entities.<GetEntities>d__1.smethod_2(worldItem))
							{
								Entities.droppedItems.Add(worldItem);
							}
							oreandtrees = null;
							lootableCorpse = null;
							sleepingBag = null;
							door = null;
							worldItem = null;
							baseNetworkable = null;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							Entities.<GetEntities>d__1.smethod_7(enumerator);
						}
					}
					enumerator = null;
				}
				yield return Entities.<GetEntities>d__1.smethod_8(0.5f);
			}
			while (num == 1);
			yield break;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00004771 File Offset: 0x00002971
		public static IEnumerator GetEntitiesFaster()
		{
			goto IL_01;
			for (;;)
			{
				IL_01:
				goto IL_01;
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00004312 File Offset: 0x00002512
		static Coroutine smethod_0(MonoBehaviour monoBehaviour_0, IEnumerator ienumerator_0)
		{
			return monoBehaviour_0.StartCoroutine(ienumerator_0);
		}

		// Token: 0x04000108 RID: 264
		public static HashSet<Planner> niggers;

		// Token: 0x04000109 RID: 265
		public static HashSet<global::HotAirBalloon> baloon;

		// Token: 0x0400010A RID: 266
		public static HashSet<global::BaseEntity> baseentity4;

		// Token: 0x0400010B RID: 267
		public static HashSet<EasterBasket> eggs1;

		// Token: 0x0400010C RID: 268
		public static HashSet<CollectableEasterEgg> eggs;

		// Token: 0x0400010D RID: 269
		public static HashSet<BaseCombatEntity> combat;

		// Token: 0x0400010E RID: 270
		public static HashSet<global::AutoTurret> autoturretsss;

		// Token: 0x0400010F RID: 271
		public static HashSet<Door> dorhackl;

		// Token: 0x04000110 RID: 272
		public static HashSet<BaseLiquidVessel> baseliquid;

		// Token: 0x04000111 RID: 273
		public static HashSet<MiniCopter> testing1;

		// Token: 0x04000112 RID: 274
		public static HashSet<Jackhammer> hammertime;

		// Token: 0x04000113 RID: 275
		public static HashSet<FlintStrikeWeapon> eokt;

		// Token: 0x04000114 RID: 276
		public static HashSet<TimedExplosive> yea;

		// Token: 0x04000115 RID: 277
		public static HashSet<BaseMountable> yeahh;

		// Token: 0x04000116 RID: 278
		public static HashSet<BowWeapon> bow;

		// Token: 0x04000117 RID: 279
		public static HashSet<CH47Helicopter> ch47;

		// Token: 0x04000118 RID: 280
		public static HashSet<Keycard> key;

		// Token: 0x04000119 RID: 281
		public static HashSet<TorchWeapon> tor;

		// Token: 0x0400011A RID: 282
		public static HashSet<StashContainer> stashes;

		// Token: 0x0400011B RID: 283
		public static HashSet<Planner> plan;

		// Token: 0x0400011C RID: 284
		public static HashSet<MotorRowboat> boat;

		// Token: 0x0400011D RID: 285
		public static HashSet<global::BradleyAPC> tank;

		// Token: 0x0400011E RID: 286
		public static HashSet<global::BaseNetworkable> plan1;

		// Token: 0x0400011F RID: 287
		public static HashSet<StorageContainer> containers;

		// Token: 0x04000120 RID: 288
		public static HashSet<BaseHelicopter> heli1;

		// Token: 0x04000121 RID: 289
		public static HashSet<global::BuildingBlock> shit;

		// Token: 0x04000122 RID: 290
		public static HashSet<global::BuildingBlock> shit1;

		// Token: 0x04000123 RID: 291
		public static HashSet<global::BuildingBlock> shit2;

		// Token: 0x04000124 RID: 292
		public static HashSet<global::BuildingBlock> shit3;

		// Token: 0x04000125 RID: 293
		public static HashSet<CollectibleEntity> hempBushes;

		// Token: 0x04000126 RID: 294
		public static HashSet<CollectibleEntity> collectibles;

		// Token: 0x04000127 RID: 295
		public static HashSet<CollectibleEntity> stone;

		// Token: 0x04000128 RID: 296
		public static HashSet<ResourceEntity> oreandtrees;

		// Token: 0x04000129 RID: 297
		public static HashSet<BaseCombatEntity> combatshit;

		// Token: 0x0400012A RID: 298
		public static HashSet<OreResourceEntity> oretest21;

		// Token: 0x0400012B RID: 299
		public static HashSet<CollectibleEntity> mushroom;

		// Token: 0x0400012C RID: 300
		public static HashSet<Jackhammer> jachammer;

		// Token: 0x0400012D RID: 301
		public static HashSet<OreResourceEntity> oretest;

		// Token: 0x0400012E RID: 302
		public static HashSet<TreeMarker> treemarkerr;

		// Token: 0x0400012F RID: 303
		public static HashSet<OreHotSpot> orehotspot;

		// Token: 0x04000130 RID: 304
		public static HashSet<OreResourceEntity> oretest1;

		// Token: 0x04000131 RID: 305
		public static HashSet<OreResourceEntity> oretest2;

		// Token: 0x04000132 RID: 306
		public static HashSet<CollectibleEntity> metal;

		// Token: 0x04000133 RID: 307
		public static HashSet<TreeEntity> trees;

		// Token: 0x04000134 RID: 308
		public static HashSet<BuildingPrivlidge> tcshit;

		// Token: 0x04000135 RID: 309
		public static HashSet<global::Landmine> land;

		// Token: 0x04000136 RID: 310
		public static HashSet<global::BaseEntity> baseentity2;

		// Token: 0x04000137 RID: 311
		public static HashSet<global::BaseEntity> baseentity;

		// Token: 0x04000138 RID: 312
		public static HashSet<global::BaseEntity> baseentity1;

		// Token: 0x04000139 RID: 313
		public static HashSet<global::CodeLock> door;

		// Token: 0x0400013A RID: 314
		public static HashSet<CollectibleEntity> sulfur;

		// Token: 0x0400013B RID: 315
		public static HashSet<SupplyDrop> airdrops;

		// Token: 0x0400013C RID: 316
		public static HashSet<global::LootableCorpse> corpses;

		// Token: 0x0400013D RID: 317
		public static HashSet<global::SleepingBag> sleepingBags;

		// Token: 0x0400013E RID: 318
		public static HashSet<MedicalTool> fuck;

		// Token: 0x0400013F RID: 319
		public static HashSet<BaseMelee> tool;

		// Token: 0x04000140 RID: 320
		public static HashSet<OreHotSpot> tool1;

		// Token: 0x04000141 RID: 321
		public static HashSet<CompoundBowWeapon> whatever;

		// Token: 0x04000142 RID: 322
		public static HashSet<BearTrap> bear;

		// Token: 0x04000143 RID: 323
		public static HashSet<FlintStrikeWeapon> strike;

		// Token: 0x04000144 RID: 324
		public static HashSet<PlayerProjectileAttack> attack;

		// Token: 0x04000145 RID: 325
		public static HashSet<global::WorldItem> droppedItems;
	}
}
