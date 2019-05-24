using System;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000058 RID: 88
	public class randomshit : MonoBehaviour
	{
		// Token: 0x060003CC RID: 972 RVA: 0x000187C0 File Offset: 0x000169C0
		public static void randoms()
		{
			try
			{
				if (Main.hemp.GetData<bool>() && Entities.hempBushes != null)
				{
					foreach (CollectibleEntity collectibleEntity in Entities.hempBushes)
					{
						if (randomshit.smethod_0(collectibleEntity, null))
						{
							Vector3 a = randomshit.smethod_2(randomshit.smethod_1(collectibleEntity));
							Vector3 vector = randomshit.smethod_3(MainCamera.mainCamera, randomshit.smethod_2(randomshit.smethod_1(collectibleEntity)));
							Vector3 vector2 = MainCamera.mainCamera.WorldToScreenPoint(a + new Vector3(0f, 1f, 0f));
							if (vector.z > 0f)
							{
								int num = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, collectibleEntity.transform.position);
								if ((float)num <= Main.Distance)
								{
									Mathf.Abs(vector.y - vector2.y);
									vector.x += 3f;
									vector.y = (float)Screen.height - (vector.y + 1f);
									Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), collectibleEntity.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
								}
							}
						}
					}
				}
				if (Main.stone.GetData<bool>() && Entities.stone != null)
				{
					foreach (CollectibleEntity collectibleEntity2 in Entities.stone)
					{
						if (collectibleEntity2 != null)
						{
							Vector3 position = collectibleEntity2.transform.position;
							Vector3 vector3 = MainCamera.mainCamera.WorldToScreenPoint(collectibleEntity2.transform.position);
							Vector3 vector4 = MainCamera.mainCamera.WorldToScreenPoint(position + new Vector3(0f, 1f, 0f));
							if (vector3.z > 0f)
							{
								int num2 = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, collectibleEntity2.transform.position);
								if ((float)num2 <= Main.Distance)
								{
									Mathf.Abs(vector3.y - vector4.y);
									vector3.x += 3f;
									vector3.y = (float)Screen.height - (vector3.y + 1f);
									Rendering.DrawString1(new Vector2(vector3.x, vector3.y - 10f), collectibleEntity2.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
								}
							}
						}
					}
				}
				if (Main.shouldDrawCollectible.GetData<bool>() && Entities.collectibles != null)
				{
					foreach (CollectibleEntity collectibleEntity3 in Entities.collectibles)
					{
						if (collectibleEntity3 != null)
						{
							Vector3 position2 = collectibleEntity3.transform.position;
							Vector3 vector5 = MainCamera.mainCamera.WorldToScreenPoint(collectibleEntity3.transform.position);
							Vector3 vector6 = MainCamera.mainCamera.WorldToScreenPoint(position2 + new Vector3(0f, 1f, 0f));
							if (vector5.z > 0f)
							{
								int num3 = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, collectibleEntity3.transform.position);
								if ((float)num3 <= Main.Distance)
								{
									Mathf.Abs(vector5.y - vector6.y);
									vector5.x += 3f;
									vector5.y = (float)Screen.height - (vector5.y + 1f);
									Rendering.DrawString1(new Vector2(vector5.x, vector5.y - 10f), collectibleEntity3.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
								}
							}
						}
					}
				}
				if (Main.shouldDrawDoors.GetData<bool>() && Entities.mushroom != null)
				{
					foreach (CollectibleEntity collectibleEntity4 in Entities.mushroom)
					{
						if (collectibleEntity4 != null)
						{
							Vector3 position3 = collectibleEntity4.transform.position;
							Vector3 vector7 = MainCamera.mainCamera.WorldToScreenPoint(collectibleEntity4.transform.position);
							Vector3 vector8 = MainCamera.mainCamera.WorldToScreenPoint(position3 + new Vector3(0f, 1f, 0f));
							if (vector7.z > 0f)
							{
								int num4 = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, collectibleEntity4.transform.position);
								if ((float)num4 <= Main.Distance)
								{
									Mathf.Abs(vector7.y - vector8.y);
									vector7.x += 3f;
									vector7.y = (float)Screen.height - (vector7.y + 1f);
									Rendering.DrawString1(new Vector2(vector7.x, vector7.y - 10f), collectibleEntity4.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
								}
							}
						}
					}
				}
				if (Main.DisableGrass.GetData<bool>() && Entities.metal != null)
				{
					foreach (CollectibleEntity collectibleEntity5 in Entities.metal)
					{
						if (collectibleEntity5 != null)
						{
							Vector3 position4 = collectibleEntity5.transform.position;
							Vector3 vector9 = MainCamera.mainCamera.WorldToScreenPoint(collectibleEntity5.transform.position);
							Vector3 vector10 = MainCamera.mainCamera.WorldToScreenPoint(position4 + new Vector3(0f, 1f, 0f));
							if (vector9.z > 0f)
							{
								int num5 = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, collectibleEntity5.transform.position);
								if ((float)num5 <= Main.Distance)
								{
									Mathf.Abs(vector9.y - vector10.y);
									vector9.x += 3f;
									vector9.y = (float)Screen.height - (vector9.y + 1f);
									Rendering.DrawString1(new Vector2(vector9.x, vector9.y - 10f), collectibleEntity5.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
								}
							}
						}
					}
				}
				if (Main.eastereggs.GetData<bool>() && Entities.eggs != null)
				{
					foreach (CollectableEasterEgg collectableEasterEgg in Entities.eggs)
					{
						if (collectableEasterEgg != null)
						{
							Vector3 position5 = collectableEasterEgg.transform.position;
							Vector3 vector11 = MainCamera.mainCamera.WorldToScreenPoint(collectableEasterEgg.transform.position);
							Vector3 vector12 = MainCamera.mainCamera.WorldToScreenPoint(position5 + new Vector3(0f, 1f, 0f));
							if (vector11.z > 0f)
							{
								int num6 = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, collectableEasterEgg.transform.position);
								if ((float)num6 <= Main.Distance)
								{
									Mathf.Abs(vector11.y - vector12.y);
									vector11.x += 3f;
									vector11.y = (float)Screen.height - (vector11.y + 1f);
									Rendering.DrawString1(new Vector2(vector11.x, vector11.y - 10f), collectableEasterEgg.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
								}
							}
						}
					}
				}
				if (Main.shouldDrawTrash.GetData<bool>() && Entities.sulfur != null)
				{
					foreach (CollectibleEntity collectibleEntity6 in Entities.sulfur)
					{
						if (collectibleEntity6 != null)
						{
							Vector3 position6 = collectibleEntity6.transform.position;
							Vector3 vector13 = MainCamera.mainCamera.WorldToScreenPoint(collectibleEntity6.transform.position);
							Vector3 vector14 = MainCamera.mainCamera.WorldToScreenPoint(position6 + new Vector3(0f, 1f, 0f));
							if (vector13.z > 0f)
							{
								int num7 = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, collectibleEntity6.transform.position);
								if ((float)num7 <= Main.Distance)
								{
									Mathf.Abs(vector13.y - vector14.y);
									vector13.x += 3f;
									vector13.y = (float)Screen.height - (vector13.y + 1f);
									Rendering.DrawString1(new Vector2(vector13.x, vector13.y - 10f), collectibleEntity6.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
								}
							}
						}
					}
				}
				if (Main.Sleepingbag.GetData<bool>() && Entities.sleepingBags != null)
				{
					foreach (SleepingBag sleepingBag in Entities.sleepingBags)
					{
						if (sleepingBag != null)
						{
							Vector3 position7 = sleepingBag.transform.position;
							Vector3 vector15 = MainCamera.mainCamera.WorldToScreenPoint(sleepingBag.transform.position);
							Vector3 vector16 = MainCamera.mainCamera.WorldToScreenPoint(position7 + new Vector3(0f, 1f, 0f));
							if (vector15.z > 0f)
							{
								int num8 = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, sleepingBag.transform.position);
								if ((float)num8 <= Main.Distance)
								{
									Mathf.Abs(vector15.y - vector16.y);
									vector15.x += 3f;
									vector15.y = (float)Screen.height - (vector15.y + 1f);
									Rendering.DrawString1(new Vector2(vector15.x, vector15.y - 10f), sleepingBag.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
								}
							}
						}
					}
				}
				if (Main.airdrop.GetData<bool>() && Entities.airdrops != null)
				{
					foreach (SupplyDrop supplyDrop in Entities.airdrops)
					{
						if (supplyDrop != null)
						{
							Vector3 position8 = supplyDrop.transform.position;
							Vector3 vector17 = MainCamera.mainCamera.WorldToScreenPoint(supplyDrop.transform.position);
							Vector3 vector18 = MainCamera.mainCamera.WorldToScreenPoint(position8 + new Vector3(0f, 1f, 0f));
							if (vector17.z > 0f)
							{
								int num9 = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, supplyDrop.transform.position);
								if ((float)num9 <= Main.MaxDistance)
								{
									Mathf.Abs(vector17.y - vector18.y);
									vector17.x += 3f;
									vector17.y = (float)Screen.height - (vector17.y + 1f);
									Rendering.DrawString1(new Vector2(vector17.x, vector17.y - 10f), supplyDrop.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
								}
							}
						}
					}
				}
			}
			catch (NullReferenceException)
			{
				Debug.Log("NullRef in randomshit");
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0000400D File Offset: 0x0000220D
		static bool smethod_0(UnityEngine.Object object_0, UnityEngine.Object object_1)
		{
			return object_0 != object_1;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0000429F File Offset: 0x0000249F
		static Transform smethod_1(Component component_0)
		{
			return component_0.transform;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x000042A7 File Offset: 0x000024A7
		static Vector3 smethod_2(Transform transform_0)
		{
			return transform_0.position;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00004286 File Offset: 0x00002486
		static Vector3 smethod_3(Camera camera_0, Vector3 vector3_0)
		{
			return camera_0.WorldToScreenPoint(vector3_0);
		}
	}
}
