using System;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x0200003C RID: 60
	public class WorldItemESP : MonoBehaviour
	{
		// Token: 0x06000256 RID: 598 RVA: 0x0000DA50 File Offset: 0x0000BC50
		public static void DrawWorldItems()
		{
			try
			{
				if (Main.shouldDrawWorldItems.GetData<bool>() && Entities.droppedItems != null)
				{
					foreach (WorldItem worldItem in Entities.droppedItems)
					{
						if (WorldItemESP.smethod_0(worldItem, null))
						{
							Vector3 vector3_ = WorldItemESP.smethod_2(WorldItemESP.smethod_1(worldItem));
							Vector3 vector = WorldItemESP.smethod_3(MainCamera.mainCamera, WorldItemESP.smethod_2(WorldItemESP.smethod_1(worldItem)));
							Vector3 vector2 = WorldItemESP.smethod_3(MainCamera.mainCamera, vector3_);
							Vector3 screenPos = Misc.GetScreenPos(WorldItemESP.smethod_2(WorldItemESP.smethod_1(worldItem)));
							if (vector.z > 0f)
							{
								int num = (int)Vector3.Distance(WorldItemESP.smethod_2(WorldItemESP.smethod_1(WorldItemESP.smethod_4())), WorldItemESP.smethod_2(WorldItemESP.smethod_1(worldItem)));
								if ((float)num <= WorldItemESP.d)
								{
									Mathf.Abs(vector2.y - screenPos.y);
									vector.x += 3f;
									vector.y = (float)WorldItemESP.smethod_5() - (vector.y + 1f);
									Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), worldItem.item.info.displayName.english, Color.white, true, 10, FontStyle.Italic, 3);
									Rendering.DrawString1(new Vector2(vector2.x, (float)Screen.height - vector2.y - 20f), string.Format("[{0}m]", num), Color.white, true, 10, FontStyle.Italic, 3);
									Rendering.DrawString1(new Vector2(vector2.x, (float)Screen.height - vector2.y - 30f), string.Format("[{0}x]", worldItem.item.amount), Color.white, true, 10, FontStyle.Italic, 3);
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

		// Token: 0x06000257 RID: 599 RVA: 0x0000DC80 File Offset: 0x0000BE80
		private void OnGUI()
		{
			try
			{
				WorldItemESP.DrawWorldItems();
			}
			catch
			{
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000400D File Offset: 0x0000220D
		static bool smethod_0(UnityEngine.Object object_0, UnityEngine.Object object_1)
		{
			return object_0 != object_1;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000429F File Offset: 0x0000249F
		static Transform smethod_1(Component component_0)
		{
			return component_0.transform;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000042A7 File Offset: 0x000024A7
		static Vector3 smethod_2(Transform transform_0)
		{
			return transform_0.position;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00004286 File Offset: 0x00002486
		static Vector3 smethod_3(Camera camera_0, Vector3 vector3_0)
		{
			return camera_0.WorldToScreenPoint(vector3_0);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000042CF File Offset: 0x000024CF
		static BasePlayer smethod_4()
		{
			return LocalPlayer.Entity;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00004222 File Offset: 0x00002422
		static int smethod_5()
		{
			return Screen.height;
		}

		// Token: 0x040000FF RID: 255
		public static float d = 100f;
	}
}
