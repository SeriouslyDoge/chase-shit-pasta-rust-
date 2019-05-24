using System;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000030 RID: 48
	public class chinook : MonoBehaviour
	{
		// Token: 0x060001E3 RID: 483 RVA: 0x0000C88C File Offset: 0x0000AA8C
		public static void drawchinook()
		{
			try
			{
				if (Main.dropzones.GetData<bool>() && UpdateObjects.Drop != null)
				{
					foreach (CH47DropZone ch47DropZone in UpdateObjects.Drop)
					{
						if (chinook.smethod_0(ch47DropZone, null))
						{
							Vector3 a = chinook.smethod_2(chinook.smethod_1(ch47DropZone));
							Vector3 vector = chinook.smethod_3(MainCamera.mainCamera, chinook.smethod_2(chinook.smethod_1(ch47DropZone)));
							Vector3 vector2 = MainCamera.mainCamera.WorldToScreenPoint(a + new Vector3(0f, 1f, 0f));
							if (vector.z > 0f)
							{
								int num = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, ch47DropZone.transform.position);
								if ((float)num <= Main.Distance)
								{
									float num2 = Mathf.Abs(vector.y - vector2.y);
									vector.x += 3f;
									vector.y = (float)Screen.height - (vector.y + 1f);
									Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), ch47DropZone.name, Color.yellow, true, 10, FontStyle.Bold, 3);
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

		// Token: 0x060001E4 RID: 484 RVA: 0x0000CA50 File Offset: 0x0000AC50
		public static void drawchinook1()
		{
			try
			{
				if (Main.chinook.GetData<bool>() && Entities.ch47 != null)
				{
					foreach (CH47Helicopter ch47Helicopter in Entities.ch47)
					{
						if (chinook.smethod_0(ch47Helicopter, null))
						{
							Vector3 a = chinook.smethod_2(chinook.smethod_1(ch47Helicopter));
							Vector3 vector = chinook.smethod_3(MainCamera.mainCamera, chinook.smethod_2(chinook.smethod_1(ch47Helicopter)));
							Vector3 vector2 = MainCamera.mainCamera.WorldToScreenPoint(a + new Vector3(0f, 1f, 0f));
							if (vector.z > 0f)
							{
								int num = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, ch47Helicopter.transform.position);
								if ((float)num <= Main.Distance)
								{
									Mathf.Abs(vector.y - vector2.y);
									vector.x += 3f;
									vector.y = (float)Screen.height - (vector.y + 1f);
									Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), ch47Helicopter.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
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

		// Token: 0x060001E5 RID: 485 RVA: 0x0000CBEC File Offset: 0x0000ADEC
		private void OnGUI()
		{
			try
			{
				chinook.drawchinook();
				chinook.drawchinook1();
			}
			catch
			{
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000400D File Offset: 0x0000220D
		static bool smethod_0(UnityEngine.Object object_0, UnityEngine.Object object_1)
		{
			return object_0 != object_1;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000429F File Offset: 0x0000249F
		static Transform smethod_1(Component component_0)
		{
			return component_0.transform;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000042A7 File Offset: 0x000024A7
		static Vector3 smethod_2(Transform transform_0)
		{
			return transform_0.position;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00004286 File Offset: 0x00002486
		static Vector3 smethod_3(Camera camera_0, Vector3 vector3_0)
		{
			return camera_0.WorldToScreenPoint(vector3_0);
		}
	}
}
