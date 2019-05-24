using System;
using Facepunch;
using ProtoBuf;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000024 RID: 36
	public class SilentCat : MonoBehaviour
	{
		// Token: 0x0600016E RID: 366 RVA: 0x0000BAE0 File Offset: 0x00009CE0
		private void Update()
		{
			if (Main.autofarm.GetData<bool>())
			{
				global::HeldEntity heldEntity = SilentCat.smethod_1(SilentCat.smethod_0());
				BaseMelee baseMelee = heldEntity as BaseMelee;
				if (!SilentCat.smethod_2(baseMelee, null) && SilentCat.smethod_3() - this.float_0 >= baseMelee.repeatDelay * 0.5f + 0.01f && SilentCat.smethod_4(heldEntity, null))
				{
					foreach (StorageContainer storageContainer in Entities.containers)
					{
						float num = Vector3.Distance(SilentCat.smethod_6(SilentCat.smethod_5(SilentCat.smethod_0())), SilentCat.smethod_6(SilentCat.smethod_5(storageContainer)));
						if (num < 7f && !SilentCat.smethod_7(storageContainer) && !SilentCat.smethod_8(storageContainer) && SilentCat.smethod_10(SilentCat.smethod_9(storageContainer), "barrel"))
						{
							using (PlayerAttack playerAttack = Pool.Get<PlayerAttack>())
							{
								using (Attack attack = Pool.Get<Attack>())
								{
									playerAttack.attack = attack;
									playerAttack.attack.hitID = storageContainer.net.ID;
									playerAttack.attack.hitPositionWorld = SilentCat.smethod_6(SilentCat.smethod_5(storageContainer));
									playerAttack.attack.hitNormalWorld = (SilentCat.smethod_6(SilentCat.smethod_5(MainCamera.mainCamera)) - SilentCat.smethod_6(SilentCat.smethod_5(storageContainer))).normalized;
									playerAttack.attack.pointStart = Misc.localplayer.eyes.position;
									playerAttack.attack.pointEnd = storageContainer.transform.position;
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

		// Token: 0x06000170 RID: 368 RVA: 0x000042CF File Offset: 0x000024CF
		static global::BasePlayer smethod_0()
		{
			return LocalPlayer.Entity;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000042E5 File Offset: 0x000024E5
		static global::HeldEntity smethod_1(global::BasePlayer basePlayer_0)
		{
			return basePlayer_0.GetHeldEntity();
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00003F62 File Offset: 0x00002162
		static bool smethod_2(UnityEngine.Object object_0, UnityEngine.Object object_1)
		{
			return object_0 == object_1;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000042ED File Offset: 0x000024ED
		static float smethod_3()
		{
			return Time.time;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000400D File Offset: 0x0000220D
		static bool smethod_4(UnityEngine.Object object_0, UnityEngine.Object object_1)
		{
			return object_0 != object_1;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000429F File Offset: 0x0000249F
		static Transform smethod_5(Component component_0)
		{
			return component_0.transform;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x000042A7 File Offset: 0x000024A7
		static Vector3 smethod_6(Transform transform_0)
		{
			return transform_0.position;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000042C7 File Offset: 0x000024C7
		static bool smethod_7(BaseCombatEntity baseCombatEntity_0)
		{
			return baseCombatEntity_0.IsDead();
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000042B7 File Offset: 0x000024B7
		static bool smethod_8(global::BaseNetworkable baseNetworkable_0)
		{
			return baseNetworkable_0.IsDestroyed;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00004407 File Offset: 0x00002607
		static string smethod_9(global::BaseNetworkable baseNetworkable_0)
		{
			return baseNetworkable_0.ShortPrefabName;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000440F File Offset: 0x0000260F
		static bool smethod_10(string string_0, string string_1)
		{
			return string_0.Contains(string_1);
		}

		// Token: 0x040000A3 RID: 163
		private float float_0;

		// Token: 0x040000A4 RID: 164
		private float nextAttack;
	}
}
