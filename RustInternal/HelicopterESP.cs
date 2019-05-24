using System;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000048 RID: 72
	public class HelicopterESP : MonoBehaviour
	{
		// Token: 0x060002C8 RID: 712 RVA: 0x00010918 File Offset: 0x0000EB18
		public static void DrawHelis()
		{
			try
			{
				if (Main.shouldDrawHeli.GetData<bool>() && Entities.heli1 != null)
				{
					foreach (BaseHelicopter baseHelicopter in Entities.heli1)
					{
						if (HelicopterESP.smethod_0(baseHelicopter, null))
						{
							Vector3 a = HelicopterESP.smethod_2(HelicopterESP.smethod_1(baseHelicopter));
							Vector3 vector = HelicopterESP.smethod_3(MainCamera.mainCamera, HelicopterESP.smethod_2(HelicopterESP.smethod_1(baseHelicopter)));
							Vector3 vector2 = MainCamera.mainCamera.WorldToScreenPoint(a + new Vector3(0f, 3f, 0f));
							Vector3 vector3 = MainCamera.mainCamera.WorldToScreenPoint(a + new Vector3(0f, 1f, 0f));
							if (vector.z > 0f)
							{
								int num = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, baseHelicopter.transform.position);
								Vector3 screenPos = Misc.GetScreenPos(a + new Vector3(0f, 0.3f, 0f));
								Vector3 screenPos2 = Misc.GetScreenPos(a + new Vector3(0f, 0.3f, 0f));
								if ((float)num <= Main.MaxDistance)
								{
									Mathf.Abs(vector2.y - screenPos2.y);
									float num2 = Mathf.Abs(vector.y - vector3.y);
									vector.x += 3f;
									vector.y = (float)Screen.height - (vector.y + 1f);
									float width = num2 / 2f;
									Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), baseHelicopter.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
									Rendering.DrawString1(new Vector2(vector2.x, (float)Screen.height - vector2.y - -10f), string.Format("[{0}m]", num), Color.yellow, true, 10, FontStyle.Bold, 3);
									Rendering.DrawVerticalHealth(new Vector2(screenPos.x, (float)Screen.height - screenPos.y), width, num2, baseHelicopter.health);
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

		// Token: 0x060002C9 RID: 713 RVA: 0x00010BAC File Offset: 0x0000EDAC
		public static void DrawMiniHelis()
		{
			try
			{
				if (Main.miniheli.GetData<bool>() && Entities.testing1 != null)
				{
					foreach (MiniCopter miniCopter in Entities.testing1)
					{
						if (HelicopterESP.smethod_0(miniCopter, null))
						{
							Vector3 a = HelicopterESP.smethod_2(HelicopterESP.smethod_1(miniCopter));
							Vector3 vector = HelicopterESP.smethod_3(MainCamera.mainCamera, HelicopterESP.smethod_2(HelicopterESP.smethod_1(miniCopter)));
							Vector3 vector2 = HelicopterESP.smethod_3(MainCamera.mainCamera, HelicopterESP.smethod_2(HelicopterESP.smethod_1(miniCopter)));
							Vector3 vector3 = MainCamera.mainCamera.WorldToScreenPoint(a + new Vector3(0f, 1f, 0f));
							if (vector.z > 0f)
							{
								int num = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, miniCopter.transform.position);
								Vector3 screenPos = Misc.GetScreenPos(a + new Vector3(0f, 0.3f, 0f));
								if ((float)num <= Main.MaxDistance)
								{
									float num2 = Mathf.Abs(vector.y - vector3.y);
									vector.x += 3f;
									vector.y = (float)Screen.height - (vector.y + 1f);
									float width = num2 / 2f;
									Mathf.Abs(vector2.y - screenPos.y);
									Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), miniCopter.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
									Rendering.DrawString1(new Vector2(vector2.x, (float)Screen.height - vector2.y - -10f), string.Format("[{0}m]", num), Color.yellow, true, 10, FontStyle.Bold, 3);
									Rendering.DrawVerticalHealth(new Vector2(screenPos.x, (float)Screen.height - screenPos.y), width, num2, miniCopter.health);
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

		// Token: 0x060002CA RID: 714 RVA: 0x00010E0C File Offset: 0x0000F00C
		public static void DrawBradly()
		{
			try
			{
				if (Main.bradly.GetData<bool>() && Entities.tank != null)
				{
					foreach (BradleyAPC bradleyAPC in Entities.tank)
					{
						if (HelicopterESP.smethod_0(bradleyAPC, null))
						{
							Vector3 a = HelicopterESP.smethod_2(HelicopterESP.smethod_1(bradleyAPC));
							Vector3 vector = HelicopterESP.smethod_3(MainCamera.mainCamera, HelicopterESP.smethod_2(HelicopterESP.smethod_1(bradleyAPC)));
							Vector3 vector2 = MainCamera.mainCamera.WorldToScreenPoint(a + new Vector3(0f, 1f, 0f));
							if (vector.z > 0f)
							{
								int num = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, bradleyAPC.transform.position);
								if ((float)num <= Main.MaxDistance)
								{
									float num2 = Mathf.Abs(vector.y - vector2.y);
									vector.x += 3f;
									vector.y = (float)Screen.height - (vector.y + 1f);
									float width = num2 / 2f;
									Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), bradleyAPC.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
									Vector3 screenPos = Misc.GetScreenPos(a + new Vector3(0f, 0.3f, 0f));
									Rendering.DrawVerticalHealth(new Vector2(screenPos.x, (float)Screen.height - screenPos.y), width, num2, bradleyAPC.health);
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

		// Token: 0x060002CB RID: 715 RVA: 0x00011004 File Offset: 0x0000F204
		private void OnGUI()
		{
			try
			{
				HelicopterESP.DrawHelis();
				HelicopterESP.DrawBradly();
				HelicopterESP.DrawMiniHelis();
			}
			catch
			{
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000400D File Offset: 0x0000220D
		static bool smethod_0(UnityEngine.Object object_0, UnityEngine.Object object_1)
		{
			return object_0 != object_1;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000429F File Offset: 0x0000249F
		static Transform smethod_1(Component component_0)
		{
			return component_0.transform;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000042A7 File Offset: 0x000024A7
		static Vector3 smethod_2(Transform transform_0)
		{
			return transform_0.position;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00004286 File Offset: 0x00002486
		static Vector3 smethod_3(Camera camera_0, Vector3 vector3_0)
		{
			return camera_0.WorldToScreenPoint(vector3_0);
		}
	}
}
