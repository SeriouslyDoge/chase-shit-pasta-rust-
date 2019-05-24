using System;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000040 RID: 64
	public class LootESP : MonoBehaviour
	{
		// Token: 0x06000277 RID: 631 RVA: 0x0000DE4C File Offset: 0x0000C04C
		public static void DrawStorages()
		{
			try
			{
				if (Main.shouldDrawStorage.GetData<bool>() && Entities.containers != null)
				{
					foreach (StorageContainer storageContainer in Entities.containers)
					{
						Vector3 a = LootESP.smethod_1(LootESP.smethod_0(storageContainer)) + new Vector3(0f, -0.5f, 0f);
						Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(storageContainer.transform.position);
						Vector3 vector2 = MainCamera.mainCamera.WorldToScreenPoint(a + new Vector3(0f, 1f, 0f));
						if (vector.z > 0f)
						{
							int num = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, storageContainer.transform.position);
							if ((float)num <= Main.MinDistance)
							{
								float num2 = Mathf.Abs(vector.y - vector2.y);
								vector.x += 3f;
								vector.y = (float)Screen.height - (vector.y + 1f);
								if (!storageContainer.ShortPrefabName.Contains("barrel") || !Main.shouldDrawBarrels.GetData<bool>())
								{
									if (storageContainer.ShortPrefabName.Contains("furnace") && Main.shouldDrawFurnaces.GetData<bool>())
									{
										Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), storageContainer.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
										Rendering.CornerBox(new Vector2(vector2.x, (float)Screen.height - vector2.y), num2, num2 / 2f, 2f, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), false);
									}
									else if (storageContainer.ShortPrefabName.Contains("fridge") && Main.shouldDrawFridges.GetData<bool>())
									{
										Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), storageContainer.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
										Rendering.CornerBox(new Vector2(vector2.x, (float)Screen.height - vector2.y), num2, num2 / 2f, 2f, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), false);
									}
									else if (storageContainer.ShortPrefabName.Contains("crate") && Main.shouldDrawCrates.GetData<bool>())
									{
										Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), storageContainer.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
										Rendering.CornerBox(new Vector2(vector2.x, (float)Screen.height - vector2.y), num2, num2 / 2f, 2f, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), false);
									}
									else if (storageContainer.ShortPrefabName.Contains("repair") && Main.shouldDrawRepairBenches.GetData<bool>())
									{
										Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), storageContainer.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
										Rendering.CornerBox(new Vector2(vector2.x, (float)Screen.height - vector2.y), num2, num2 / 2f, 2f, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), false);
									}
									else if (!storageContainer.ShortPrefabName.Contains("recycler") || !Main.shouldDrawRecyclers.GetData<bool>())
									{
										if (storageContainer.ShortPrefabName.Contains("food") && Main.shouldDrawFoodboxes.GetData<bool>())
										{
											Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), storageContainer.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
											Rendering.CornerBox(new Vector2(vector2.x, (float)Screen.height - vector2.y), num2, num2 / 2f, 2f, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), false);
										}
										else if (storageContainer.ShortPrefabName.Contains("codelocked") && Main.shouldDrawRecyclers.GetData<bool>())
										{
											Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), storageContainer.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
											Rendering.CornerBox(new Vector2(vector2.x, (float)Screen.height - vector2.y), num2, num2 / 2f, 2f, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), false);
										}
										else if (!storageContainer.ShortPrefabName.Contains("large") || !Main.largebox.GetData<bool>())
										{
											if (!storageContainer.ShortPrefabName.Contains("woodbox") || !Main.woodbox.GetData<bool>())
											{
												if (!storageContainer.ShortPrefabName.Contains("campfire") || !Main.shouldDrawCampfires.GetData<bool>())
												{
													if (storageContainer.ShortPrefabName.Contains("lantern") && Main.shouldDrawLightSources.GetData<bool>())
													{
														Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), storageContainer.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
														Rendering.CornerBox(new Vector2(vector2.x, (float)Screen.height - vector2.y), num2, num2 / 2f, 2f, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), false);
													}
													else if (storageContainer.ShortPrefabName.Contains("light") && Main.shouldDrawLightSources.GetData<bool>())
													{
														Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), storageContainer.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
														Rendering.CornerBox(new Vector2(vector2.x, (float)Screen.height - vector2.y), num2, num2 / 2f, 2f, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), false);
													}
													else if (storageContainer.ShortPrefabName.Contains("refinery") && Main.shouldDrawRefineries.GetData<bool>())
													{
														Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), storageContainer.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
														Rendering.CornerBox(new Vector2(vector2.x, (float)Screen.height - vector2.y), num2, num2 / 2f, 2f, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), false);
													}
													else if (storageContainer.ShortPrefabName.Contains("locker") && Main.shouldDrawQuarries.GetData<bool>())
													{
														Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), storageContainer.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
														Rendering.CornerBox(new Vector2(vector2.x, (float)Screen.height - vector2.y), num2, num2 / 2f, 2f, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), false);
													}
													else if (storageContainer.ShortPrefabName.Contains("vendingmachine") && Main.shouldDrawVendingMachines.GetData<bool>())
													{
														Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), storageContainer.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
														Rendering.CornerBox(new Vector2(vector2.x, (float)Screen.height - vector2.y), num2, num2 / 2f, 2f, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), false);
													}
													else if (Main.shouldDrawOthers.GetData<bool>())
													{
														int num3 = 0;
														string[] array = new string[]
														{
															"turret",
															"locker",
															"refinery",
															"light",
															"catcher",
															"codelocked",
															"fuel_storage",
															"fuelstorage",
															"campfire",
															"food",
															"recycler",
															"repair",
															"stash",
															"crate",
															"fridge",
															"furnace",
															"trash",
															"barrel",
															"supply_drop",
															"wood",
															"vendingmachine",
															"guntrap"
														};
														foreach (string value in array)
														{
															if (!storageContainer.ShortPrefabName.Contains(value))
															{
																num3++;
															}
														}
														if (num3 == array.Length)
														{
															Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), storageContainer.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
															Rendering.CornerBox(new Vector2(vector2.x, (float)Screen.height - vector2.y), num2, num2 / 2f, 2f, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), false);
														}
													}
												}
												else
												{
													Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), storageContainer.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
													Rendering.CornerBox(new Vector2(vector2.x, (float)Screen.height - vector2.y), num2, num2 / 2f, 2f, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), false);
												}
											}
											else
											{
												Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), storageContainer.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
												Rendering.CornerBox(new Vector2(vector2.x, (float)Screen.height - vector2.y), num2, num2 / 2f, 2f, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), false);
											}
										}
										else
										{
											Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), storageContainer.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
											Rendering.CornerBox(new Vector2(vector2.x, (float)Screen.height - vector2.y), num2, num2 / 2f, 2f, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), false);
										}
									}
									else
									{
										Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), storageContainer.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
										Rendering.CornerBox(new Vector2(vector2.x, (float)Screen.height - vector2.y), num2, num2 / 2f, 2f, new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), false);
									}
								}
								else
								{
									Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), storageContainer.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
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

		// Token: 0x06000278 RID: 632 RVA: 0x0000EB38 File Offset: 0x0000CD38
		private void OnGUI()
		{
			try
			{
				LootESP.DrawStorages();
			}
			catch
			{
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000429F File Offset: 0x0000249F
		static Transform smethod_0(Component component_0)
		{
			return component_0.transform;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x000042A7 File Offset: 0x000024A7
		static Vector3 smethod_1(Transform transform_0)
		{
			return transform_0.position;
		}
	}
}
