using System;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000063 RID: 99
	public class Traps : MonoBehaviour
	{
		// Token: 0x06000441 RID: 1089 RVA: 0x0001A71C File Offset: 0x0001891C
		public static void traps()
		{
			try
			{
				if (Main.guntrap.GetData<bool>() && UpdateObjects.guntrap != null)
				{
					foreach (GunTrap gunTrap in UpdateObjects.guntrap)
					{
						if (Traps.smethod_0(gunTrap, null))
						{
							Vector3 a = Traps.smethod_2(Traps.smethod_1(gunTrap));
							Vector3 vector = Traps.smethod_3(MainCamera.mainCamera, Traps.smethod_2(Traps.smethod_1(gunTrap)));
							Vector3 vector2 = MainCamera.mainCamera.WorldToScreenPoint(a + new Vector3(0f, 1f, 0f));
							if (vector.z > 0f)
							{
								int num = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, gunTrap.transform.position);
								Vector3 screenPos = Misc.GetScreenPos(a + new Vector3(0f, 0.3f, 0f));
								if ((float)num <= Main.Distance)
								{
									Mathf.Abs(vector.y - vector2.y);
									float num2 = Mathf.Abs(vector.y - screenPos.y);
									float width = num2 / 2f;
									vector.x += 3f;
									vector.y = (float)Screen.height - (vector.y + 1f);
									Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), gunTrap.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
									Rendering.DrawVerticalHealth(new Vector2(screenPos.x, (float)Screen.height - screenPos.y), width, num2, gunTrap.health);
								}
							}
						}
					}
				}
				if (Main.shouldDrawTurrets.GetData<bool>() && Entities.autoturretsss != null)
				{
					foreach (AutoTurret autoTurret in Entities.autoturretsss)
					{
						if (autoTurret != null)
						{
							Vector3 position = autoTurret.transform.position;
							Vector3 vector3 = MainCamera.mainCamera.WorldToScreenPoint(autoTurret.transform.position);
							Vector3 vector4 = MainCamera.mainCamera.WorldToScreenPoint(position + new Vector3(0f, 1f, 0f));
							Vector3 v = MainCamera.mainCamera.WorldToScreenPoint(position);
							Vector3 vector5 = MainCamera.mainCamera.WorldToScreenPoint(position);
							Vector2 vector6 = v;
							vector6.y = (float)Screen.height - vector6.y;
							vector5.x += 3f;
							vector5.y = (float)Screen.height - (vector5.y + 1f);
							Vector3 position2 = autoTurret.transform.position;
							Vector3 screenPos2 = Misc.GetScreenPos(position2 + new Vector3(0f, 0.3f, 0f));
							float num3 = Mathf.Abs(vector5.y - screenPos2.y);
							float width2 = num3 / 2f;
							if (vector3.z > 0f)
							{
								int num4 = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, autoTurret.transform.position);
								if ((float)num4 <= Main.Distance)
								{
									Mathf.Abs(vector3.y - vector4.y);
									vector3.x += 3f;
									vector3.y = (float)Screen.height - (vector3.y + 1f);
									Rendering.DrawVerticalHealth(new Vector2(screenPos2.x, (float)Screen.height - screenPos2.y), width2, num3, autoTurret.health);
									Rendering.DrawString1(new Vector2(vector3.x, vector3.y - 10f), autoTurret.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
								}
							}
						}
					}
				}
				if (Main.beartrap.GetData<bool>() && Entities.bear != null)
				{
					foreach (BearTrap bearTrap in Entities.bear)
					{
						if (bearTrap != null)
						{
							Vector3 position3 = bearTrap.transform.position;
							Vector3 vector7 = MainCamera.mainCamera.WorldToScreenPoint(bearTrap.transform.position);
							Vector3 vector8 = MainCamera.mainCamera.WorldToScreenPoint(position3 + new Vector3(0f, 1f, 0f));
							if (vector7.z > 0f)
							{
								int num5 = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, bearTrap.transform.position);
								if ((float)num5 <= Main.Distance)
								{
									Mathf.Abs(vector7.y - vector8.y);
									vector7.x += 3f;
									vector7.y = (float)Screen.height - (vector7.y + 1f);
									Rendering.DrawString1(new Vector2(vector7.x, vector7.y - 10f), bearTrap.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
								}
							}
						}
					}
				}
				if (Main.flametrap.GetData<bool>() && UpdateObjects.flameturret != null)
				{
					foreach (FlameTurret flameTurret in UpdateObjects.flameturret)
					{
						if (flameTurret != null)
						{
							Vector3 position4 = flameTurret.transform.position;
							Vector3 vector9 = MainCamera.mainCamera.WorldToScreenPoint(flameTurret.transform.position);
							Vector3 vector10 = MainCamera.mainCamera.WorldToScreenPoint(position4 + new Vector3(0f, 1f, 0f));
							if (vector9.z > 0f)
							{
								int num6 = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, flameTurret.transform.position);
								Vector3 screenPos3 = Misc.GetScreenPos(position4 + new Vector3(0f, 0.3f, 0f));
								float num7 = Mathf.Abs(vector9.y - screenPos3.y);
								float width3 = num7 / 2f;
								if ((float)num6 <= Main.Distance)
								{
									Mathf.Abs(vector9.y - vector10.y);
									vector9.x += 3f;
									vector9.y = (float)Screen.height - (vector9.y + 1f);
									Rendering.DrawString1(new Vector2(vector9.x, vector9.y - 10f), flameTurret.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
									Rendering.DrawVerticalHealth(new Vector2(screenPos3.x, (float)Screen.height - screenPos3.y), width3, num7, flameTurret.health);
								}
							}
						}
					}
				}
				if (Main.stone1.GetData<bool>() && Entities.oretest != null)
				{
					foreach (OreResourceEntity oreResourceEntity in Entities.oretest)
					{
						if (oreResourceEntity != null)
						{
							Vector3 position5 = oreResourceEntity.transform.position;
							Vector3 vector11 = MainCamera.mainCamera.WorldToScreenPoint(oreResourceEntity.transform.position);
							Vector3 vector12 = MainCamera.mainCamera.WorldToScreenPoint(position5 + new Vector3(0f, 1f, 0f));
							if (vector11.z > 0f)
							{
								int num8 = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, oreResourceEntity.transform.position);
								if ((float)num8 <= Main.Distance)
								{
									Mathf.Abs(vector11.y - vector12.y);
									vector11.x += 3f;
									vector11.y = (float)Screen.height - (vector11.y + 1f);
									Rendering.DrawString1(new Vector2(vector11.x, vector11.y - 10f), oreResourceEntity.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
								}
							}
						}
					}
				}
				if (Main.metal1.GetData<bool>() && Entities.oretest1 != null)
				{
					foreach (OreResourceEntity oreResourceEntity2 in Entities.oretest1)
					{
						if (oreResourceEntity2 != null)
						{
							Vector3 position6 = oreResourceEntity2.transform.position;
							Vector3 vector13 = MainCamera.mainCamera.WorldToScreenPoint(oreResourceEntity2.transform.position);
							Vector3 vector14 = MainCamera.mainCamera.WorldToScreenPoint(position6 + new Vector3(0f, 1f, 0f));
							if (vector13.z > 0f)
							{
								int num9 = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, oreResourceEntity2.transform.position);
								if ((float)num9 <= Main.Distance)
								{
									Mathf.Abs(vector13.y - vector14.y);
									vector13.x += 3f;
									vector13.y = (float)Screen.height - (vector13.y + 1f);
									Rendering.DrawString1(new Vector2(vector13.x, vector13.y - 10f), oreResourceEntity2.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
								}
							}
						}
					}
				}
				if (Main.sulfur1.GetData<bool>() && Entities.oretest2 != null)
				{
					foreach (OreResourceEntity oreResourceEntity3 in Entities.oretest2)
					{
						if (oreResourceEntity3 != null)
						{
							Vector3 position7 = oreResourceEntity3.transform.position;
							Vector3 vector15 = MainCamera.mainCamera.WorldToScreenPoint(oreResourceEntity3.transform.position);
							Vector3 vector16 = MainCamera.mainCamera.WorldToScreenPoint(position7 + new Vector3(0f, 1f, 0f));
							if (vector15.z > 0f)
							{
								int num10 = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, oreResourceEntity3.transform.position);
								if ((float)num10 <= Main.Distance)
								{
									Mathf.Abs(vector15.y - vector16.y);
									vector15.x += 3f;
									vector15.y = (float)Screen.height - (vector15.y + 1f);
									Rendering.DrawString1(new Vector2(vector15.x, vector15.y - 10f), oreResourceEntity3.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
								}
							}
						}
					}
				}
				if (Main.landmine.GetData<bool>() && Entities.land != null)
				{
					foreach (Landmine landmine in Entities.land)
					{
						if (landmine != null)
						{
							Vector3 position8 = landmine.transform.position;
							Vector3 vector17 = MainCamera.mainCamera.WorldToScreenPoint(landmine.transform.position);
							Vector3 vector18 = MainCamera.mainCamera.WorldToScreenPoint(position8 + new Vector3(0f, 1f, 0f));
							if (vector17.z > 0f)
							{
								int num11 = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, landmine.transform.position);
								if ((float)num11 <= Main.Distance)
								{
									Mathf.Abs(vector17.y - vector18.y);
									vector17.x += 3f;
									vector17.y = (float)Screen.height - (vector17.y + 1f);
									Rendering.DrawString1(new Vector2(vector17.x, vector17.y - 10f), landmine.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
								}
							}
						}
					}
				}
			}
			catch (NullReferenceException)
			{
				Debug.Log("NullRefrenceException in Traps");
			}
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0000400D File Offset: 0x0000220D
		static bool smethod_0(UnityEngine.Object object_0, UnityEngine.Object object_1)
		{
			return object_0 != object_1;
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0000429F File Offset: 0x0000249F
		static Transform smethod_1(Component component_0)
		{
			return component_0.transform;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x000042A7 File Offset: 0x000024A7
		static Vector3 smethod_2(Transform transform_0)
		{
			return transform_0.position;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00004286 File Offset: 0x00002486
		static Vector3 smethod_3(Camera camera_0, Vector3 vector3_0)
		{
			return camera_0.WorldToScreenPoint(vector3_0);
		}
	}
}
