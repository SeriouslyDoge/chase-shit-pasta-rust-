using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000056 RID: 86
	public class PlayerESP : MonoBehaviour
	{
		// Token: 0x060003BA RID: 954 RVA: 0x00016EB4 File Offset: 0x000150B4
		public static bool IsVisible(Vector3 vector3_0)
		{
			Vector3 a = PlayerESP.smethod_1(PlayerESP.smethod_0(MainCamera.mainCamera)) - vector3_0;
			float magnitude = a.magnitude;
			bool result;
			if (magnitude < Mathf.Epsilon)
			{
				result = true;
			}
			else
			{
				Vector3 vector = a / magnitude;
				Vector3 b = vector * Mathf.Min(magnitude, 0.01f);
				result = LocalPlayer.Entity.IsVisible(new Ray(vector3_0 + b, vector), magnitude);
			}
			return result;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00016F24 File Offset: 0x00015124
		public static void DrawPlayers()
		{
			if (PlayerESP.smethod_3(PlayerESP.smethod_2(), null))
			{
				try
				{
					if (PlayerESP.smethod_4() != null)
					{
						foreach (BasePlayer basePlayer in PlayerESP.smethod_4())
						{
							if (PlayerESP.smethod_3(basePlayer, null) && !PlayerESP.smethod_5(basePlayer) && PlayerESP.smethod_6(basePlayer))
							{
								Vector3 vector = PlayerESP.smethod_1(PlayerESP.smethod_0(basePlayer));
								Vector3 vector2 = PlayerESP.smethod_7(MainCamera.mainCamera, vector);
								Vector3 vector3 = PlayerESP.smethod_7(MainCamera.mainCamera, vector);
								Color color = Color.red;
								color = (Color)Main.Esp_Team_Color.GetSubContent<List<object>>().ElementAtOrDefault(Main.Esp_Team_Color.GetData<int>());
								Color color2 = Color.red;
								color2 = (Color)Main.skeletoncolor.GetSubContent<List<object>>().ElementAtOrDefault(Main.skeletoncolor.GetData<int>());
								Color color3 = Color.red;
								color3 = (Color)Main.friendcolor.GetSubContent<List<object>>().ElementAtOrDefault(Main.friendcolor.GetData<int>());
								if (!PlayerESP.smethod_5(basePlayer) && vector2.z > 0f)
								{
									int num = (int)Vector3.Distance(PlayerESP.smethod_1(PlayerESP.smethod_0(PlayerESP.smethod_2())), vector);
									if ((float)num <= Main.Distanceeee)
									{
										if (Main.shouldDrawSleepers.GetData<bool>() && PlayerESP.smethod_8(basePlayer))
										{
											Vector3 a = PlayerESP.smethod_1(PlayerESP.smethod_0(PlayerESP.smethod_9(basePlayer, "head")));
											Vector3 screenPos = Misc.GetScreenPos(a + new Vector3(0f, 0.3f, 0f));
											float num2 = Mathf.Abs(vector2.y - screenPos.y);
											float width = num2 / 2f;
											vector3.x += 3f;
											vector3.y = (float)Screen.height - (vector3.y + 1f);
											Rendering.DrawString1(new Vector2(vector3.x, vector3.y - -20f), basePlayer.displayName, Color.yellow, true, 10, FontStyle.Bold, 3);
											Rendering.FullBox(new Vector2(screenPos.x, (float)Screen.height - screenPos.y), num2 / 2f, num2, 2f, num, Color.yellow, true, false);
											Rendering.DrawVerticalHealth(new Vector2(screenPos.x, (float)Screen.height - screenPos.y), width, num2, basePlayer.health);
											Vector3[] bonePositions = basePlayer.GetBonePositions();
											Vector2[] array = new Vector2[16];
											for (int i = 0; i < bonePositions.Length; i++)
											{
												Vector2 vector4 = MainCamera.mainCamera.WorldToScreenPoint(bonePositions[i]);
												array[i] = new Vector2(vector4.x, (float)Screen.height - vector4.y);
											}
											Rendering.DrawLine2(array[1], array[2], Color.yellow, 1f);
											Rendering.DrawLine2(array[2], array[3], Color.yellow, 1f);
											Rendering.DrawLine2(array[1], array[4], Color.yellow, 1f);
											Rendering.DrawLine2(array[1], array[7], Color.yellow, 1f);
											Rendering.DrawLine2(array[4], array[5], Color.yellow, 1f);
											Rendering.DrawLine2(array[7], array[8], Color.yellow, 1f);
											Rendering.DrawLine2(array[5], array[6], Color.yellow, 1f);
											Rendering.DrawLine2(array[8], array[9], Color.yellow, 1f);
											Rendering.DrawLine2(array[3], array[10], Color.yellow, 1f);
											Rendering.DrawLine2(array[3], array[13], Color.yellow, 1f);
											Rendering.DrawLine2(array[10], array[11], Color.yellow, 1f);
											Rendering.DrawLine2(array[13], array[14], Color.yellow, 1f);
											Rendering.DrawLine2(array[11], array[12], Color.yellow, 1f);
											Rendering.DrawLine2(array[14], array[15], Color.yellow, 1f);
										}
										if (!basePlayer.IsSleeping())
										{
											Vector3 vector5 = MainCamera.mainCamera.WorldToScreenPoint(vector + new Vector3(0f, 1.7f, 0f));
											Mathf.Abs(vector2.y - vector5.y);
											vector2.x += 3f;
											vector2.y = (float)Screen.height - (vector2.y + 1f);
											Vector3 position = basePlayer.FindBone("head").transform.position;
											if (Main.Esp_VisibilityCheck.GetData<bool>())
											{
												Vector3 position2 = basePlayer.FindBone("head").transform.position;
												if (PlayerESP.IsVisible(position2))
												{
													color = Color.red;
												}
											}
											if (!(position == Vector3.zero))
											{
												Vector3 screenPos2x  = Misc.GetScreenPos(position + new Vector3(0f, 0.3f, 0f));
												float num3 = Mathf.Abs(vector3.y - screenPos2.y);
												float width2 = num3 / 2f;
												Vector3 v = MainCamera.mainCamera.WorldToScreenPoint(vector);
												Vector2 vector6 = v;
												vector6.y = (float)Screen.height - vector6.y;
												if (Main.shouldDrawHealthBar.GetData<bool>() && basePlayer.health > 0f && !basePlayer.IsNpc)
												{
													Rendering.DrawHealth1(vector6, basePlayer.Health(), true);
												}
												if (Main.vert.GetData<bool>() && basePlayer.health > 0f && !basePlayer.IsNpc)
												{
													Rendering.DrawVerticalHealth(new Vector2(screenPos2.x, (float)Screen.height - screenPos2.y), width2, num3, basePlayer.health);
												}
												MainCamera.mainCamera.WorldToScreenPoint(vector + new Vector3(0f, 1.8f, 0f));
												if (Main.shouldDrawPlayers.GetData<bool>() && !basePlayer.IsLocalPlayer() && !basePlayer.IsNpc)
												{
													if (!FriendManager.friendsList.Contains(basePlayer.userID))
													{
														Rendering.DrawString1(new Vector2(vector3.x, (float)Screen.height - vector3.y - -20f), string.Format("{0} [{1}m]", basePlayer.displayName, num), color, true, 10, FontStyle.Bold, 1);
													}
													if (FriendManager.friendsList.Contains(basePlayer.userID))
													{
														Rendering.DrawString1(new Vector2(vector3.x, (float)Screen.height - vector3.y - -20f), string.Format("{0} [{1}m]", basePlayer.displayName, num), color3, true, 10, FontStyle.Bold, 1);
													}
												}
												if (Main.showid.GetData<bool>() && !basePlayer.IsLocalPlayer() && !basePlayer.IsNpc)
												{
													if (!FriendManager.friendsList.Contains(basePlayer.userID))
													{
														Rendering.DrawString1(new Vector2(vector3.x, (float)Screen.height - vector3.y - -35f), string.Format("id: {0}", basePlayer.userID), color, true, 10, FontStyle.Bold, 1);
													}
													if (FriendManager.friendsList.Contains(basePlayer.userID))
													{
														Rendering.DrawString1(new Vector2(vector3.x, (float)Screen.height - vector3.y - -35f), string.Format("id: {0}", basePlayer.userID), color3, true, 10, FontStyle.Bold, 1);
													}
												}
												if (Main.playerbox.GetData<bool>() && !basePlayer.IsLocalPlayer() && !basePlayer.IsNpc)
												{
													if (!FriendManager.friendsList.Contains(basePlayer.userID))
													{
														Rendering.FullBox(new Vector2(screenPos2.x, (float)Screen.height - screenPos2.y), num3 / 2f, num3, 2f, num, color, true, false);
													}
													if (FriendManager.friendsList.Contains(basePlayer.userID))
													{
														Rendering.FullBox(new Vector2(screenPos2.x, (float)Screen.height - screenPos2.y), num3 / 2f, num3, 2f, num, color3, true, false);
													}
												}
												if (Main.shouldDrawEquipedItem.GetData<bool>() && !basePlayer.IsLocalPlayer() && !basePlayer.IsNpc)
												{
													if (!FriendManager.friendsList.Contains(basePlayer.userID))
													{
														Rendering.DrawString1(new Vector2(vector2.x, vector2.y - -50f), (basePlayer.GetHeldEntity() != null) ? basePlayer.GetHeldEntity().GetItem().info.displayName.english : "", color, true, 10, FontStyle.Bold, 3);
													}
													if (FriendManager.friendsList.Contains(basePlayer.userID))
													{
														Rendering.DrawString1(new Vector2(vector2.x, vector2.y - -50f), (basePlayer.GetHeldEntity() != null) ? basePlayer.GetHeldEntity().GetItem().info.displayName.english : "", color3, true, 10, FontStyle.Bold, 3);
													}
												}
												if (Main.Skeleton.GetData<bool>() && !basePlayer.IsNpc)
												{
													Vector3[] bonePositions2 = basePlayer.GetBonePositions();
													Vector2[] array2 = new Vector2[16];
													for (int j = 0; j < bonePositions2.Length; j++)
													{
														Vector2 vector7 = MainCamera.mainCamera.WorldToScreenPoint(bonePositions2[j]);
														array2[j] = new Vector2(vector7.x, (float)Screen.height - vector7.y);
													}
													Rendering.DrawLine2(array2[1], array2[2], color2, 2f);
													Rendering.DrawLine2(array2[2], array2[3], color2, 2f);
													Rendering.DrawLine2(array2[1], array2[4], color2, 1f);
													Rendering.DrawLine2(array2[1], array2[7], color2, 1f);
													Rendering.DrawLine2(array2[4], array2[5], color2, 1f);
													Rendering.DrawLine2(array2[7], array2[8], color2, 1f);
													Rendering.DrawLine2(array2[5], array2[6], color2, 1f);
													Rendering.DrawLine2(array2[8], array2[9], color2, 1f);
													Rendering.DrawLine2(array2[3], array2[10], color2, 1f);
													Rendering.DrawLine2(array2[3], array2[13], color2, 1f);
													Rendering.DrawLine2(array2[10], array2[11], color2, 1f);
													Rendering.DrawLine2(array2[13], array2[14], color2, 1f);
													Rendering.DrawLine2(array2[11], array2[12], color2, 1f);
													Rendering.DrawLine2(array2[14], array2[15], color2, 1f);
												}
												if (Main.npc.GetData<bool>() && basePlayer.health > 0f && basePlayer.IsNpc)
												{
													int num4 = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, vector);
													if ((float)num4 <= Main.scientistdistance)
													{
														Rendering.DrawVerticalHealth(new Vector2(screenPos2.x, (float)Screen.height - screenPos2.y), width2, num3, basePlayer.health);
														Rendering.FullBox(new Vector2(screenPos2.x, (float)Screen.height - screenPos2.y), num3 / 2f, num3, 2f, num4, Color.green, true, false);
														Rendering.DrawString1(new Vector2(vector2.x, vector2.y - -50f), (basePlayer.GetHeldEntity() != null) ? basePlayer.GetHeldEntity().GetItem().info.displayName.english : "Scientist", Color.green, true, 10, FontStyle.Bold, 3);
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				catch (NullReferenceException)
				{
					Debug.Log("Player ESP NullReferenceException!");
				}
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0000429F File Offset: 0x0000249F
		static Transform smethod_0(Component component_0)
		{
			return component_0.transform;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000042A7 File Offset: 0x000024A7
		static Vector3 smethod_1(Transform transform_0)
		{
			return transform_0.position;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x000042CF File Offset: 0x000024CF
		static BasePlayer smethod_2()
		{
			return LocalPlayer.Entity;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0000400D File Offset: 0x0000220D
		static bool smethod_3(UnityEngine.Object object_0, UnityEngine.Object object_1)
		{
			return object_0 != object_1;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000425F File Offset: 0x0000245F
		static BufferList<BasePlayer> smethod_4()
		{
			return BasePlayer.VisiblePlayerList;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00004266 File Offset: 0x00002466
		static bool smethod_5(BasePlayer basePlayer_0)
		{
			return basePlayer_0.IsLocalPlayer();
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00004794 File Offset: 0x00002994
		static bool smethod_6(BaseEntity baseEntity_0)
		{
			return baseEntity_0.IsValid();
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00004286 File Offset: 0x00002486
		static Vector3 smethod_7(Camera camera_0, Vector3 vector3_0)
		{
			return camera_0.WorldToScreenPoint(vector3_0);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000426E File Offset: 0x0000246E
		static bool smethod_8(BasePlayer basePlayer_0)
		{
			return basePlayer_0.IsSleeping();
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00004A20 File Offset: 0x00002C20
		static Transform smethod_9(BaseEntity baseEntity_0, string string_0)
		{
			return baseEntity_0.FindBone(string_0);
		}
	}
}
