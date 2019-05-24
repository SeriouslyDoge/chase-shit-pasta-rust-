using System;
using System.Collections.Generic;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x0200001A RID: 26
	public class AnimalESP : MonoBehaviour
	{
		// Token: 0x06000116 RID: 278 RVA: 0x0000B204 File Offset: 0x00009404
		public static void DrawAnimals()
		{
			try
			{
				if (Main.shouldDrawAnimals.GetData<bool>() && AnimalESP.smethod_0() != null)
				{
					foreach (BaseNpc baseNpc in AnimalESP.smethod_0())
					{
						if (AnimalESP.smethod_1(baseNpc, null))
						{
							Vector3 a = AnimalESP.smethod_3(AnimalESP.smethod_2(baseNpc));
							Vector3 vector = AnimalESP.smethod_4(MainCamera.mainCamera, AnimalESP.smethod_3(AnimalESP.smethod_2(baseNpc)));
							Vector3 vector2 = MainCamera.mainCamera.WorldToScreenPoint(a + new Vector3(0f, 1f, 0f));
							if (vector.z > 0f)
							{
								int num = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, baseNpc.transform.position);
								if ((float)num <= Main.Distance)
								{
									Mathf.Abs(vector.y - vector2.y);
									vector.x += 3f;
									vector.y = (float)Screen.height - (vector.y + 1f);
									Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), baseNpc.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
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

		// Token: 0x06000117 RID: 279 RVA: 0x0000B3A0 File Offset: 0x000095A0
		private void OnGUI()
		{
			try
			{
				AnimalESP.DrawAnimals();
			}
			catch
			{
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000042DE File Offset: 0x000024DE
		static List<BaseNpc> smethod_0()
		{
			return BaseNpc.VisibleNpcList;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000400D File Offset: 0x0000220D
		static bool smethod_1(UnityEngine.Object object_0, UnityEngine.Object object_1)
		{
			return object_0 != object_1;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000429F File Offset: 0x0000249F
		static Transform smethod_2(Component component_0)
		{
			return component_0.transform;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000042A7 File Offset: 0x000024A7
		static Vector3 smethod_3(Transform transform_0)
		{
			return transform_0.position;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00004286 File Offset: 0x00002486
		static Vector3 smethod_4(Camera camera_0, Vector3 vector3_0)
		{
			return camera_0.WorldToScreenPoint(vector3_0);
		}
	}
}
