using System;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000059 RID: 89
	public class ResourceESP : BaseMonoBehaviour
	{
		// Token: 0x060003D2 RID: 978 RVA: 0x0001952C File Offset: 0x0001772C
		public static void DrawResources()
		{
			try
			{
				if (Main.shouldDrawResources.GetData<bool>() && Entities.oreandtrees != null)
				{
					foreach (ResourceEntity resourceEntity in Entities.oreandtrees)
					{
						if (ResourceESP.smethod_0(resourceEntity, null))
						{
							Vector3 a = ResourceESP.smethod_2(ResourceESP.smethod_1(resourceEntity));
							Vector3 vector = ResourceESP.smethod_3(MainCamera.mainCamera, ResourceESP.smethod_2(ResourceESP.smethod_1(resourceEntity)));
							Vector3 vector2 = MainCamera.mainCamera.WorldToScreenPoint(a + new Vector3(0f, 1f, 0f));
							if (vector.z > 0f)
							{
								int num = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, resourceEntity.transform.position);
								if ((float)num <= Main.Distance)
								{
									Mathf.Abs(vector.y - vector2.y);
									vector.x += 3f;
									vector.y = (float)Screen.height - (vector.y + 1f);
									Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), resourceEntity.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
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

		// Token: 0x060003D3 RID: 979 RVA: 0x000196C8 File Offset: 0x000178C8
		public static void stash1()
		{
			try
			{
				if (Main.shouldDrawStashes.GetData<bool>() && Entities.stashes != null)
				{
					foreach (StashContainer stashContainer in Entities.stashes)
					{
						if (ResourceESP.smethod_0(stashContainer, null))
						{
							Vector3 a = ResourceESP.smethod_2(ResourceESP.smethod_1(stashContainer));
							Vector3 vector = ResourceESP.smethod_3(MainCamera.mainCamera, ResourceESP.smethod_2(ResourceESP.smethod_1(stashContainer)));
							Vector3 vector2 = MainCamera.mainCamera.WorldToScreenPoint(a + new Vector3(0f, 1f, 0f));
							if (vector.z > 0f)
							{
								int num = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, stashContainer.transform.position);
								if ((float)num <= Main.Distance)
								{
									Mathf.Abs(vector.y - vector2.y);
									vector.x += 3f;
									vector.y = (float)Screen.height - (vector.y + 1f);
									Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), stashContainer.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
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

		// Token: 0x060003D4 RID: 980 RVA: 0x00019864 File Offset: 0x00017A64
		public static void stash()
		{
			try
			{
				if (Main.stash1.GetData<bool>() && Entities.stashes != null)
				{
					foreach (StashContainer stashContainer in Entities.stashes)
					{
						if (ResourceESP.smethod_0(stashContainer, null) && ResourceESP.smethod_4(stashContainer) && !ResourceESP.smethod_5(stashContainer))
						{
							Vector3 a = ResourceESP.smethod_2(ResourceESP.smethod_1(stashContainer));
							Vector3 vector = ResourceESP.smethod_3(MainCamera.mainCamera, ResourceESP.smethod_2(ResourceESP.smethod_1(stashContainer)));
							Vector3 vector2 = MainCamera.mainCamera.WorldToScreenPoint(a + new Vector3(0f, 1f, 0f));
							if (vector.z > 0f)
							{
								int num = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, stashContainer.transform.position);
								if ((float)num <= Main.Distance)
								{
									float num2 = Mathf.Abs(vector.y - vector2.y);
									vector.x += 3f;
									vector.y = (float)Screen.height - (vector.y + 1f);
									Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), stashContainer.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
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

		// Token: 0x060003D5 RID: 981 RVA: 0x00019A64 File Offset: 0x00017C64
		private void OnGUI()
		{
			try
			{
				ResourceESP.DrawResources();
				ResourceESP.stash();
				ResourceESP.stash1();
			}
			catch
			{
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000400D File Offset: 0x0000220D
		static bool smethod_0(UnityEngine.Object object_0, UnityEngine.Object object_1)
		{
			return object_0 != object_1;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000429F File Offset: 0x0000249F
		static Transform smethod_1(Component component_0)
		{
			return component_0.transform;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x000042A7 File Offset: 0x000024A7
		static Vector3 smethod_2(Transform transform_0)
		{
			return transform_0.position;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00004286 File Offset: 0x00002486
		static Vector3 smethod_3(Camera camera_0, Vector3 vector3_0)
		{
			return camera_0.WorldToScreenPoint(vector3_0);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00004BBD File Offset: 0x00002DBD
		static bool smethod_4(StashContainer stashContainer_0)
		{
			return stashContainer_0.IsHidden();
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00004BC5 File Offset: 0x00002DC5
		static bool smethod_5(BaseEntity baseEntity_0)
		{
			return baseEntity_0.IsOpen();
		}
	}
}
