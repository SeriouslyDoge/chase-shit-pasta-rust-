using System;
using System.Collections.Generic;
using ProtoBuf;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000032 RID: 50
	public class CupboardESP : MonoBehaviour
	{
		// Token: 0x060001F3 RID: 499 RVA: 0x0000CFD4 File Offset: 0x0000B1D4
		public static void DrawCupboards()
		{
			try
			{
				if (Entities.tcshit != null)
				{
					foreach (BuildingPrivlidge buildingPrivlidge in Entities.tcshit)
					{
						if (CupboardESP.smethod_0(buildingPrivlidge, null))
						{
							Vector3 a = CupboardESP.smethod_2(CupboardESP.smethod_1(buildingPrivlidge));
							Vector3 vector = CupboardESP.smethod_3(MainCamera.mainCamera, CupboardESP.smethod_2(CupboardESP.smethod_1(buildingPrivlidge)));
							Vector3 vector2 = MainCamera.mainCamera.WorldToScreenPoint(a + new Vector3(0f, 1f, 0f));
							Vector3 vector3 = MainCamera.mainCamera.WorldToScreenPoint(a + new Vector3(0f, 1.7f, 0f));
							if (vector.z > 0f)
							{
								int num = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, buildingPrivlidge.transform.position);
								if ((float)num <= Main.Distance)
								{
									Mathf.Abs(vector.y - vector2.y);
									vector.x += 3f;
									vector.y = (float)Screen.height - (vector.y + 1f);
									if (Main.shouldDrawCupboards.GetData<bool>())
									{
										Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), buildingPrivlidge.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
									}
									if (Main.authlist.GetData<bool>() && vector3.z > 0f)
									{
										vector3.x += 3f;
										vector3.y = (float)Screen.height - (vector3.y + 1f);
										List<PlayerNameID> list = new List<PlayerNameID>();
										list = buildingPrivlidge.authorizedPlayers;
										for (int i = 0; i < list.Count; i++)
										{
											Rendering.DrawString(new Vector2(vector3.x, vector3.y - (float)(i + 1) * 15f), list[i].username, Color.yellow, true, 12, false, 1);
										}
									}
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

		// Token: 0x060001F4 RID: 500 RVA: 0x0000D244 File Offset: 0x0000B444
		private void OnGUI()
		{
			try
			{
				CupboardESP.DrawCupboards();
			}
			catch
			{
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000400D File Offset: 0x0000220D
		static bool smethod_0(UnityEngine.Object object_0, UnityEngine.Object object_1)
		{
			return object_0 != object_1;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000429F File Offset: 0x0000249F
		static Transform smethod_1(Component component_0)
		{
			return component_0.transform;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x000042A7 File Offset: 0x000024A7
		static Vector3 smethod_2(Transform transform_0)
		{
			return transform_0.position;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00004286 File Offset: 0x00002486
		static Vector3 smethod_3(Camera camera_0, Vector3 vector3_0)
		{
			return camera_0.WorldToScreenPoint(vector3_0);
		}
	}
}
