using System;
using System.Collections;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x0200002C RID: 44
	public class boat : MonoBehaviour
	{
		// Token: 0x060001C7 RID: 455 RVA: 0x0000453E File Offset: 0x0000273E
		private void Start()
		{
			boat.smethod_0(this, this.Updating944());
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000454D File Offset: 0x0000274D
		private IEnumerator Updating944()
		{
			boat.<Updating944>d__2 <Updating944>d__ = new boat.<Updating944>d__2(0);
			<Updating944>d__.<>4__this = this;
			return <Updating944>d__;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000C37C File Offset: 0x0000A57C
		public static void Boatt()
		{
			try
			{
				if (Main.boatesp.GetData<bool>() && Entities.boat != null)
				{
					foreach (MotorRowboat motorRowboat in Entities.boat)
					{
						if (boat.smethod_1(motorRowboat, null))
						{
							Vector3 a = boat.smethod_3(boat.smethod_2(motorRowboat));
							Vector3 vector = boat.smethod_4(MainCamera.mainCamera, boat.smethod_3(boat.smethod_2(motorRowboat)));
							Vector3 vector2 = MainCamera.mainCamera.WorldToScreenPoint(a + new Vector3(0f, 1f, 0f));
							if (vector.z > 0f)
							{
								int num = (int)Vector3.Distance(LocalPlayer.Entity.transform.position, motorRowboat.transform.position);
								if ((float)num <= Main.Distance)
								{
									float num2 = Mathf.Abs(vector.y - vector2.y);
									vector.x += 3f;
									vector.y = (float)Screen.height - (vector.y + 1f);
									Rendering.DrawString1(new Vector2(vector.x, vector.y - 10f), motorRowboat.ShortPrefabName, Color.yellow, true, 10, FontStyle.Bold, 3);
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

		// Token: 0x060001CA RID: 458 RVA: 0x0000C568 File Offset: 0x0000A768
		private void OnGUI()
		{
			try
			{
				boat.Boatt();
			}
			catch
			{
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00004312 File Offset: 0x00002512
		static Coroutine smethod_0(MonoBehaviour monoBehaviour_0, IEnumerator ienumerator_0)
		{
			return monoBehaviour_0.StartCoroutine(ienumerator_0);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000400D File Offset: 0x0000220D
		static bool smethod_1(UnityEngine.Object object_0, UnityEngine.Object object_1)
		{
			return object_0 != object_1;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000429F File Offset: 0x0000249F
		static Transform smethod_2(Component component_0)
		{
			return component_0.transform;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000042A7 File Offset: 0x000024A7
		static Vector3 smethod_3(Transform transform_0)
		{
			return transform_0.position;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00004286 File Offset: 0x00002486
		static Vector3 smethod_4(Camera camera_0, Vector3 vector3_0)
		{
			return camera_0.WorldToScreenPoint(vector3_0);
		}

		// Token: 0x040000CA RID: 202
		public static StorageContainer[] storageContainerArray;
	}
}
