using System;
using System.Collections.Generic;
using Facepunch;
using ProtoBuf;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x0200001B RID: 27
	public class SilentCat1111 : MonoBehaviour
	{
		// Token: 0x0600011E RID: 286 RVA: 0x0000B3C8 File Offset: 0x000095C8
		private void Update()
		{
			if (Main.autofarm5.GetData<bool>())
			{
				global::HeldEntity heldEntity = SilentCat1111.smethod_1(SilentCat1111.smethod_0());
				BaseMelee baseMelee = heldEntity as BaseMelee;
				if (!SilentCat1111.smethod_2(baseMelee, null) && SilentCat1111.smethod_3() - this.float_0 >= baseMelee.repeatDelay * 0.5f + 0.01f && SilentCat1111.smethod_4(heldEntity, null))
				{
					foreach (BaseNpc baseNpc in SilentCat1111.smethod_5())
					{
						float num = Vector3.Distance(SilentCat1111.smethod_7(SilentCat1111.smethod_6(SilentCat1111.smethod_0())), SilentCat1111.smethod_7(SilentCat1111.smethod_6(baseNpc)));
						if (num < 7f && !SilentCat1111.smethod_8(baseNpc) && !SilentCat1111.smethod_9(baseNpc))
						{
							using (PlayerAttack playerAttack = Pool.Get<PlayerAttack>())
							{
								using (Attack attack = Pool.Get<Attack>())
								{
									playerAttack.attack = attack;
									playerAttack.attack.hitID = baseNpc.net.ID;
									playerAttack.attack.hitPositionWorld = SilentCat1111.smethod_7(SilentCat1111.smethod_6(baseNpc));
									playerAttack.attack.hitNormalWorld = (SilentCat1111.smethod_7(SilentCat1111.smethod_6(MainCamera.mainCamera)) - SilentCat1111.smethod_7(SilentCat1111.smethod_6(baseNpc))).normalized;
									playerAttack.attack.pointStart = Misc.localplayer.eyes.position;
									playerAttack.attack.pointEnd = baseNpc.transform.position;
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

		// Token: 0x06000120 RID: 288 RVA: 0x000042CF File Offset: 0x000024CF
		static global::BasePlayer smethod_0()
		{
			return LocalPlayer.Entity;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000042E5 File Offset: 0x000024E5
		static global::HeldEntity smethod_1(global::BasePlayer basePlayer_0)
		{
			return basePlayer_0.GetHeldEntity();
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00003F62 File Offset: 0x00002162
		static bool smethod_2(UnityEngine.Object object_0, UnityEngine.Object object_1)
		{
			return object_0 == object_1;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000042ED File Offset: 0x000024ED
		static float smethod_3()
		{
			return Time.time;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000400D File Offset: 0x0000220D
		static bool smethod_4(UnityEngine.Object object_0, UnityEngine.Object object_1)
		{
			return object_0 != object_1;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000042DE File Offset: 0x000024DE
		static List<BaseNpc> smethod_5()
		{
			return BaseNpc.VisibleNpcList;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000429F File Offset: 0x0000249F
		static Transform smethod_6(Component component_0)
		{
			return component_0.transform;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000042A7 File Offset: 0x000024A7
		static Vector3 smethod_7(Transform transform_0)
		{
			return transform_0.position;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000042C7 File Offset: 0x000024C7
		static bool smethod_8(BaseCombatEntity baseCombatEntity_0)
		{
			return baseCombatEntity_0.IsDead();
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000042B7 File Offset: 0x000024B7
		static bool smethod_9(global::BaseNetworkable baseNetworkable_0)
		{
			return baseNetworkable_0.IsDestroyed;
		}

		// Token: 0x04000086 RID: 134
		private float float_0;
	}
}
