using System;
using Facepunch;
using ProtoBuf;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000055 RID: 85
	public class SilentCat11 : MonoBehaviour
	{
		// Token: 0x060003B0 RID: 944 RVA: 0x00016CB0 File Offset: 0x00014EB0
		private void Update()
		{
			if (Main.autofarm2.GetData<bool>())
			{
				global::HeldEntity heldEntity = SilentCat11.smethod_1(SilentCat11.smethod_0());
				BaseMelee baseMelee = heldEntity as BaseMelee;
				if (!SilentCat11.smethod_2(baseMelee, null) && SilentCat11.smethod_3() - this.float_0 >= baseMelee.repeatDelay && SilentCat11.smethod_4(heldEntity, null))
				{
					foreach (OreHotSpot oreHotSpot in Entities.orehotspot)
					{
						float num = Vector3.Distance(SilentCat11.smethod_6(SilentCat11.smethod_5(SilentCat11.smethod_0())), SilentCat11.smethod_6(SilentCat11.smethod_5(oreHotSpot)));
						if (num < 7f && !SilentCat11.smethod_7(oreHotSpot))
						{
							using (PlayerAttack playerAttack = Pool.Get<PlayerAttack>())
							{
								using (Attack attack = Pool.Get<Attack>())
								{
									playerAttack.attack = attack;
									playerAttack.attack.hitID = oreHotSpot.net.ID;
									playerAttack.attack.hitPositionWorld = SilentCat11.smethod_6(SilentCat11.smethod_5(oreHotSpot));
									playerAttack.attack.hitNormalWorld = (SilentCat11.smethod_6(SilentCat11.smethod_5(MainCamera.mainCamera)) - SilentCat11.smethod_6(SilentCat11.smethod_5(oreHotSpot))).normalized;
									playerAttack.attack.pointStart = Misc.localplayer.eyes.position;
									playerAttack.attack.pointEnd = oreHotSpot.transform.position;
									baseMelee.ServerRPC<PlayerAttack>("PlayerAttack", playerAttack);
									this.float_0 = Time.time;
									Debug.Log("YAS BITCH");
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x000042CF File Offset: 0x000024CF
		static global::BasePlayer smethod_0()
		{
			return LocalPlayer.Entity;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x000042E5 File Offset: 0x000024E5
		static global::HeldEntity smethod_1(global::BasePlayer basePlayer_0)
		{
			return basePlayer_0.GetHeldEntity();
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00003F62 File Offset: 0x00002162
		static bool smethod_2(UnityEngine.Object object_0, UnityEngine.Object object_1)
		{
			return object_0 == object_1;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x000042ED File Offset: 0x000024ED
		static float smethod_3()
		{
			return Time.time;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000400D File Offset: 0x0000220D
		static bool smethod_4(UnityEngine.Object object_0, UnityEngine.Object object_1)
		{
			return object_0 != object_1;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000429F File Offset: 0x0000249F
		static Transform smethod_5(Component component_0)
		{
			return component_0.transform;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x000042A7 File Offset: 0x000024A7
		static Vector3 smethod_6(Transform transform_0)
		{
			return transform_0.position;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x000042B7 File Offset: 0x000024B7
		static bool smethod_7(global::BaseNetworkable baseNetworkable_0)
		{
			return baseNetworkable_0.IsDestroyed;
		}

		// Token: 0x04000271 RID: 625
		private float float_0;
	}
}
