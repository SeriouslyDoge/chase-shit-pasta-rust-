using System;
using System.Collections;
using ProtoBuf;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000067 RID: 103
	public class UpdateObjects : MonoBehaviour
	{
		// Token: 0x06000459 RID: 1113 RVA: 0x00004CCC File Offset: 0x00002ECC
		private void Start()
		{
			UpdateObjects.smethod_0(this, this.updateObjects());
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00004CDB File Offset: 0x00002EDB
		private IEnumerator updateObjects()
		{
			UpdateObjects.<updateObjects>d__37 <updateObjects>d__ = new UpdateObjects.<updateObjects>d__37(0);
			<updateObjects>d__.<>4__this = this;
			return <updateObjects>d__;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00004312 File Offset: 0x00002512
		static Coroutine smethod_0(MonoBehaviour monoBehaviour_0, IEnumerator ienumerator_0)
		{
			return monoBehaviour_0.StartCoroutine(ienumerator_0);
		}

		// Token: 0x040002AB RID: 683
		public static StorageContainer[] storageContainerArray;

		// Token: 0x040002AC RID: 684
		public static ResourceEntity[] baseResourceArray;

		// Token: 0x040002AD RID: 685
		public static BaseNpc[] baseNPCArray;

		// Token: 0x040002AE RID: 686
		public static BuildingPrivlidge[] cupboardArray;

		// Token: 0x040002AF RID: 687
		public static Door[] doorArray;

		// Token: 0x040002B0 RID: 688
		public static global::LootableCorpse[] corpseArray;

		// Token: 0x040002B1 RID: 689
		public static BaseHelicopter[] heli;

		// Token: 0x040002B2 RID: 690
		public static global::WorldItem[] worldItemArray;

		// Token: 0x040002B3 RID: 691
		public static global::SleepingBag[] sleeping;

		// Token: 0x040002B4 RID: 692
		public static global::BaseProjectile[] baseProjectileArray;

		// Token: 0x040002B5 RID: 693
		public static AttackEntity[] attackEntityArray;

		// Token: 0x040002B6 RID: 694
		public static PlayerWalkMovement playerWalkMovement;

		// Token: 0x040002B7 RID: 695
		public static Projectile[] fuckingreee;

		// Token: 0x040002B8 RID: 696
		public static TimedExplosive[] stashtest;

		// Token: 0x040002B9 RID: 697
		public static CollectibleEntity[] hempbush;

		// Token: 0x040002BA RID: 698
		public static Jackhammer[] jackhax;

		// Token: 0x040002BB RID: 699
		public static Chainsaw[] chain;

		// Token: 0x040002BC RID: 700
		public static FlintStrikeWeapon[] flintstrike;

		// Token: 0x040002BD RID: 701
		public static CrossbowWeapon[] crossy;

		// Token: 0x040002BE RID: 702
		public static ProjectileShoot[] shoot;

		// Token: 0x040002BF RID: 703
		public static GunTrap[] guntrap;

		// Token: 0x040002C0 RID: 704
		public static global::Landmine[] landmine;

		// Token: 0x040002C1 RID: 705
		public static BearTrap[] beartrap;

		// Token: 0x040002C2 RID: 706
		public static FlameTurret[] flameturret;

		// Token: 0x040002C3 RID: 707
		public static MedicalTool[] medicaltool;

		// Token: 0x040002C4 RID: 708
		public static global::AutoTurret[] autoturret;

		// Token: 0x040002C5 RID: 709
		public static BowWeapon[] bows1;

		// Token: 0x040002C6 RID: 710
		public static RecoilProperties[] fuck;

		// Token: 0x040002C7 RID: 711
		public static ItemIcon[] yea;

		// Token: 0x040002C8 RID: 712
		public static TreeEntity[] wutt;

		// Token: 0x040002C9 RID: 713
		public static CH47DropZone[] Drop;

		// Token: 0x040002CA RID: 714
		public static UIBlackoutOverlay[] nigger;

		// Token: 0x040002CB RID: 715
		public static ModelState[] uhtest;

		// Token: 0x040002CC RID: 716
		public static ItemModProjectile[] fukunigger1;

		// Token: 0x040002CD RID: 717
		public static WaterOverlay[] watershit;

		// Token: 0x040002CE RID: 718
		public static ItemModWearable[] testing;
	}
}
