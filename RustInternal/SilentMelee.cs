using System;
using Facepunch;
using ProtoBuf;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x0200005C RID: 92
	public class SilentMelee : MonoBehaviour
	{
		// Token: 0x060003F2 RID: 1010 RVA: 0x00019C00 File Offset: 0x00017E00
		private void Update()
		{
			if (Main.meleehack.GetData<bool>())
			{
				global::HeldEntity heldEntity = SilentMelee.smethod_1(SilentMelee.smethod_0());
				BaseMelee baseMelee = heldEntity as BaseMelee;
				if (!SilentMelee.smethod_2(baseMelee, null) && SilentMelee.smethod_3() - this.float_0 >= baseMelee.repeatDelay && SilentMelee.smethod_4(heldEntity, null))
				{
					foreach (global::BasePlayer basePlayer in SilentMelee.smethod_5())
					{
						float num = Vector3.Distance(SilentMelee.smethod_7(SilentMelee.smethod_6(SilentMelee.smethod_0())), SilentMelee.smethod_7(SilentMelee.smethod_6(basePlayer)));
						if (num < 7f && !SilentMelee.smethod_8(basePlayer) && !SilentMelee.smethod_9(basePlayer))
						{
							if (Main.meleewalls.GetData<bool>())
							{
								PlayerAttack playerAttack = Pool.Get<PlayerAttack>();
								try
								{
									PlayerAttack playerAttack2 = playerAttack;
									Attack attack = SilentMelee.smethod_10();
									attack.hitID = basePlayer.net.ID;
									attack.hitPositionWorld = SilentMelee.smethod_7(SilentMelee.smethod_6(SilentMelee.smethod_0()));
									attack.hitPositionLocal = SilentMelee.smethod_7(SilentMelee.smethod_6(SilentMelee.smethod_0()));
									attack.hitNormalLocal = SilentMelee.smethod_7(SilentMelee.smethod_6(SilentMelee.smethod_0()));
									attack.hitNormalWorld = SilentMelee.smethod_7(SilentMelee.smethod_6(SilentMelee.smethod_0()));
									attack.pointStart = SilentMelee.smethod_7(SilentMelee.smethod_6(SilentMelee.smethod_0())) + Vector3.up;
									attack.pointEnd = SilentMelee.smethod_7(SilentMelee.smethod_6(SilentMelee.smethod_0())) + Vector3.up;
									attack.ShouldPool = true;
									playerAttack2.attack = attack;
									baseMelee.ServerRPC<PlayerAttack>("PlayerAttack", playerAttack);
									goto IL_287;
								}
								finally
								{
									if (playerAttack != null)
									{
										SilentMelee.smethod_11(playerAttack);
									}
								}
								goto IL_19A;
							}
							goto IL_19A;
							IL_287:
							this.float_0 = Time.time;
							continue;
							IL_19A:
							using (PlayerAttack playerAttack3 = Pool.Get<PlayerAttack>())
							{
								using (Attack attack2 = Pool.Get<Attack>())
								{
									playerAttack3.attack = attack2;
									playerAttack3.attack.hitID = basePlayer.net.ID;
									playerAttack3.attack.hitPositionWorld = SilentMelee.smethod_7(SilentMelee.smethod_12(basePlayer, "head"));
									playerAttack3.attack.hitNormalWorld = (SilentMelee.smethod_7(SilentMelee.smethod_6(MainCamera.mainCamera)) - SilentMelee.smethod_7(SilentMelee.smethod_12(basePlayer, "head"))).normalized;
									playerAttack3.attack.pointStart = Misc.localplayer.eyes.position;
									playerAttack3.attack.pointEnd = basePlayer.FindBone("head").position;
									baseMelee.ServerRPC<PlayerAttack>("PlayerAttack", playerAttack3);
									Debug.Log("YAS BITCH");
								}
							}
							goto IL_287;
						}
					}
				}
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000042CF File Offset: 0x000024CF
		static global::BasePlayer smethod_0()
		{
			return LocalPlayer.Entity;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000042E5 File Offset: 0x000024E5
		static global::HeldEntity smethod_1(global::BasePlayer basePlayer_0)
		{
			return basePlayer_0.GetHeldEntity();
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00003F62 File Offset: 0x00002162
		static bool smethod_2(UnityEngine.Object object_0, UnityEngine.Object object_1)
		{
			return object_0 == object_1;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x000042ED File Offset: 0x000024ED
		static float smethod_3()
		{
			return Time.time;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000400D File Offset: 0x0000220D
		static bool smethod_4(UnityEngine.Object object_0, UnityEngine.Object object_1)
		{
			return object_0 != object_1;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000425F File Offset: 0x0000245F
		static BufferList<global::BasePlayer> smethod_5()
		{
			return global::BasePlayer.VisiblePlayerList;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000429F File Offset: 0x0000249F
		static Transform smethod_6(Component component_0)
		{
			return component_0.transform;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x000042A7 File Offset: 0x000024A7
		static Vector3 smethod_7(Transform transform_0)
		{
			return transform_0.position;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x000042C7 File Offset: 0x000024C7
		static bool smethod_8(BaseCombatEntity baseCombatEntity_0)
		{
			return baseCombatEntity_0.IsDead();
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00004266 File Offset: 0x00002466
		static bool smethod_9(global::BasePlayer basePlayer_0)
		{
			return basePlayer_0.IsLocalPlayer();
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00004C09 File Offset: 0x00002E09
		static Attack smethod_10()
		{
			return new Attack();
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00004297 File Offset: 0x00002497
		static void smethod_11(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00004A20 File Offset: 0x00002C20
		static Transform smethod_12(global::BaseEntity baseEntity_0, string string_0)
		{
			return baseEntity_0.FindBone(string_0);
		}

		// Token: 0x0400027E RID: 638
		private float float_0;
	}
}
