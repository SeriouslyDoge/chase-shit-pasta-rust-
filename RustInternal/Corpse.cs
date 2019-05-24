using System;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000031 RID: 49
	public class Corpse : MonoBehaviour
	{
		// Token: 0x060001EB RID: 491 RVA: 0x0000CC1C File Offset: 0x0000AE1C
		public static void DrawExplosive()
		{
			try
			{
				if (Main.explosives.GetData<bool>() && Entities.yea != null)
				{
					foreach (TimedExplosive timedExplosive in Entities.yea)
					{
						if (Corpse.smethod_0(timedExplosive, null))
						{
							Vector3 a = Corpse.smethod_2(Corpse.smethod_1(timedExplosive));
							Vector3 vector = Corpse.smethod_3(MainCamera.mainCamera, Corpse.smethod_2(Corpse.smethod_1(timedExplosive)));
							Vector3 vector2 = MainCamera.mainCamera.WorldToScreenPoint(a + new Vector3(0f, 1f, 0f));
							if (vector.z > 0f)
							{
								int num = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, timedExplosive.transform.position);
								if ((float)num <= Main.Distance)
								{
									float num2 = Mathf.Abs(vector.y - vector2.y);
									vector.x += 3f;
									vector.y = (float)Screen.height - (vector.y + 1f);
									Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), timedExplosive.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
									Rendering.CornerBox(new Vector2(vector2.x, (float)Screen.height - vector2.y), num2, num2 / 2f, 2f, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), false);
								}
							}
						}
					}
				}
			}
			catch (NullReferenceException)
			{
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000CE08 File Offset: 0x0000B008
		public static void DrawCorpses()
		{
			try
			{
				if (Main.shouldDrawCorpses.GetData<bool>() && Entities.corpses != null)
				{
					foreach (LootableCorpse lootableCorpse in Entities.corpses)
					{
						if (Corpse.smethod_0(lootableCorpse, null))
						{
							Vector3 a = Corpse.smethod_2(Corpse.smethod_1(lootableCorpse));
							Vector3 vector = Corpse.smethod_3(MainCamera.mainCamera, Corpse.smethod_2(Corpse.smethod_1(lootableCorpse)));
							Vector3 vector2 = MainCamera.mainCamera.WorldToScreenPoint(a + new Vector3(0f, 1f, 0f));
							if (vector.z > 0f)
							{
								int num = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, lootableCorpse.transform.position);
								if ((float)num <= Main.Distance)
								{
									Mathf.Abs(vector.y - vector2.y);
									vector.x += 3f;
									vector.y = (float)Screen.height - (vector.y + 1f);
									Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), lootableCorpse.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
								}
							}
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000CFA4 File Offset: 0x0000B1A4
		private void OnGUI()
		{
			try
			{
				Corpse.DrawCorpses();
				Corpse.DrawExplosive();
			}
			catch
			{
			}
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000400D File Offset: 0x0000220D
		static bool smethod_0(UnityEngine.Object object_0, UnityEngine.Object object_1)
		{
			return object_0 != object_1;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000429F File Offset: 0x0000249F
		static Transform smethod_1(Component component_0)
		{
			return component_0.transform;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000042A7 File Offset: 0x000024A7
		static Vector3 smethod_2(Transform transform_0)
		{
			return transform_0.position;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00004286 File Offset: 0x00002486
		static Vector3 smethod_3(Camera camera_0, Vector3 vector3_0)
		{
			return camera_0.WorldToScreenPoint(vector3_0);
		}
	}
}
