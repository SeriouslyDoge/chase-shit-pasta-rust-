using System;
using Facepunch;
using ProtoBuf;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000060 RID: 96
	public class SilentMelee0 : MonoBehaviour
	{
		// Token: 0x06000424 RID: 1060 RVA: 0x0001A2F8 File Offset: 0x000184F8
		private void Update()
		{
			if (Main.suicide.GetData<bool>() && SilentMelee0.smethod_1(SilentMelee0.smethod_0()) && SilentMelee0.smethod_2(SilentMelee0.smethod_0()) && SilentMelee0.smethod_3() >= this.nextAttack)
			{
				global::BasePlayer basePlayer = null;
				float num = 99999f;
				if (SilentMelee0.smethod_4() != null)
				{
					foreach (global::BasePlayer basePlayer2 in SilentMelee0.smethod_4())
					{
						Vector3 vector = SilentMelee0.smethod_7(MainCamera.mainCamera, SilentMelee0.smethod_6(SilentMelee0.smethod_5(basePlayer2, "head")));
						if (vector.z > 0f)
						{
							Vector2 vector2 = new Vector2(vector.x, (float)SilentMelee0.smethod_8() - vector.y);
							float num2 = Mathf.Abs(Vector2.Distance(new Vector2((float)(SilentMelee0.smethod_9() / 2), (float)(SilentMelee0.smethod_8() / 2)), new Vector2(vector2.x, (float)Screen.height - vector2.y)));
							if (num2 <= num)
							{
								num = num2;
								basePlayer = basePlayer2;
							}
						}
					}
				}
				if (basePlayer != null && basePlayer.IsValid())
				{
					Vector3 position = basePlayer.model.headBone.position;
					global::HeldEntity heldEntity = LocalPlayer.Entity.GetHeldEntity();
					if (heldEntity != null && heldEntity.IsValid())
					{
						float num3 = Vector3.Distance(LocalPlayer.Entity.transform.position, basePlayer.transform.position);
						BaseMelee baseMelee = heldEntity as BaseMelee;
						if (baseMelee != null && baseMelee.IsValid())
						{
							if (num3 < 2f)
							{
								using (PlayerAttack playerAttack = Pool.Get<PlayerAttack>())
								{
									playerAttack.attack = new Attack
									{
										hitID = basePlayer.net.ID,
										hitPositionWorld = basePlayer.FindBone("head").position,
										hitPositionLocal = new Vector3(-0.1f, -1f, 0f),
										hitNormalLocal = new Vector3(0f, -1f, 0f),
										hitNormalWorld = (MainCamera.mainCamera.transform.position - basePlayer.FindBone("head").position).normalized,
										pointStart = LocalPlayer.Entity.transform.position,
										pointEnd = basePlayer.FindBone("head").position
									};
									baseMelee.ServerRPC<PlayerAttack>("PlayerAttack", playerAttack);
									Debug.Log("Stop hitting yourself xD");
								}
							}
							this.nextAttack = Time.time + baseMelee.repeatDelay;
						}
					}
				}
			}
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x000042CF File Offset: 0x000024CF
		static global::BasePlayer smethod_0()
		{
			return LocalPlayer.Entity;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x000040AF File Offset: 0x000022AF
		static bool smethod_1(UnityEngine.Object object_0)
		{
			return object_0;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00004794 File Offset: 0x00002994
		static bool smethod_2(global::BaseEntity baseEntity_0)
		{
			return baseEntity_0.IsValid();
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x000042ED File Offset: 0x000024ED
		static float smethod_3()
		{
			return Time.time;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0000425F File Offset: 0x0000245F
		static BufferList<global::BasePlayer> smethod_4()
		{
			return global::BasePlayer.VisiblePlayerList;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00004A20 File Offset: 0x00002C20
		static Transform smethod_5(global::BaseEntity baseEntity_0, string string_0)
		{
			return baseEntity_0.FindBone(string_0);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x000042A7 File Offset: 0x000024A7
		static Vector3 smethod_6(Transform transform_0)
		{
			return transform_0.position;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00004286 File Offset: 0x00002486
		static Vector3 smethod_7(Camera camera_0, Vector3 vector3_0)
		{
			return camera_0.WorldToScreenPoint(vector3_0);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00004222 File Offset: 0x00002422
		static int smethod_8()
		{
			return Screen.height;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0000421B File Offset: 0x0000241B
		static int smethod_9()
		{
			return Screen.width;
		}

		// Token: 0x0400028C RID: 652
		private float nextAttack;

		// Token: 0x0400028D RID: 653
		public static bool Enabled;
	}
}
