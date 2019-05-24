using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000057 RID: 87
	public class Radar : MonoBehaviour
	{
		// Token: 0x060003C7 RID: 967 RVA: 0x00017C54 File Offset: 0x00015E54
		private void Radarshit()
		{
			try
			{
				if (Main.Radar101.GetData<bool>())
				{
					if (Radar.Radar_Size % 2f != 0f)
					{
						Radar.Radar_Size -= 1f;
					}
					Color color = Color.blue;
					Color color2 = Color.green;
					color = (Color)Main.Esp_Team_Color_Visible.GetSubContent<List<object>>().ElementAtOrDefault(Main.Esp_Team_Color_Visible.GetData<int>());
					color2 = (Color)Main.Esp_Enemy_Color_Visible.GetSubContent<List<object>>().ElementAtOrDefault(Main.Esp_Enemy_Color_Visible.GetData<int>());
					Rendering.BoxRect(new Rect(Radar.Radar_X + Radar.Radar_Size / 2f - 3f, Radar.Radar_Y + Radar.Radar_Size / 2f - 3f, 6f, 6f), Color.magenta);
					foreach (BasePlayer basePlayer in BasePlayer.VisiblePlayerList)
					{
						if (basePlayer.health > 0f && !basePlayer.IsSleeping() && !basePlayer.IsLocalPlayer() && !basePlayer.IsNpc && Main.Radar101.GetData<bool>())
						{
							Vector3 position = LocalPlayer.Entity.transform.position;
							Vector3 position2 = basePlayer.transform.position;
							float num = Vector3.Distance(position, position2);
							float y = position.x - position2.x;
							float x = position.z - position2.z;
							float num2 = Mathf.Atan2(y, x) * 57.29578f - 270f - LocalPlayer.Entity.transform.eulerAngles.y;
							float num3 = num * Mathf.Cos(num2 * 0.0174532924f);
							float num4 = num * Mathf.Sin(num2 * 0.0174532924f);
							num3 = num3 * (Radar.Radar_Size / Radar.Radar_Range) / 2f;
							num4 = num4 * (Radar.Radar_Size / Radar.Radar_Range) / 2f;
							if (num <= Radar.Radar_Range)
							{
								Rendering.BoxRect(new Rect(Radar.Radar_X + Radar.Radar_Size / 2f + num3 - 3f, Radar.Radar_Y + Radar.Radar_Size / 2f + num4 - 3f, 6f, 6f), color);
								Rendering.DrawString1(new Vector2(Radar.Radar_X + Radar.Radar_Size / 2f + num3 - 3f, Radar.Radar_Y + Radar.Radar_Size / 2f + num4 - 3f), string.Format("{0}", basePlayer.displayName), color2, true, 9, FontStyle.Bold, 1);
							}
						}
					}
					if (Main.animalradar.GetData<bool>())
					{
						foreach (BaseNpc baseNpc in BaseNpc.VisibleNpcList)
						{
							Vector3 position3 = LocalPlayer.Entity.transform.position;
							Vector3 position4 = baseNpc.transform.position;
							float num5 = Vector3.Distance(position3, position4);
							float y2 = position3.x - position4.x;
							float x2 = position3.z - position4.z;
							float num6 = Mathf.Atan2(y2, x2) * 57.29578f - 270f - LocalPlayer.Entity.transform.eulerAngles.y;
							float num7 = num5 * Mathf.Cos(num6 * 0.0174532924f);
							float num8 = num5 * Mathf.Sin(num6 * 0.0174532924f);
							num7 = num7 * (Radar.Radar_Size / Radar.Radar_Range) / 2f;
							num8 = num8 * (Radar.Radar_Size / Radar.Radar_Range) / 2f;
							if (num5 <= Radar.Radar_Range)
							{
								Rendering.BoxRect(new Rect(Radar.Radar_X + Radar.Radar_Size / 2f + num7 - 3f, Radar.Radar_Y + Radar.Radar_Size / 2f + num8 - 3f, 6f, 6f), color);
								Rendering.DrawString1(new Vector2(Radar.Radar_X + Radar.Radar_Size / 2f + num7 - 3f, Radar.Radar_Y + Radar.Radar_Size / 2f + num8 - 3f), string.Format("{0}", baseNpc.ShortPrefabName), color2, true, 9, FontStyle.Bold, 1);
							}
						}
					}
					if (Main.RadarStoneOre.GetData<bool>())
					{
						foreach (OreResourceEntity oreResourceEntity in Entities.oretest)
						{
							Vector3 position5 = LocalPlayer.Entity.transform.position;
							Vector3 position6 = oreResourceEntity.transform.position;
							float num9 = Vector3.Distance(position5, position6);
							float y3 = position5.x - position6.x;
							float x3 = position5.z - position6.z;
							float num10 = Mathf.Atan2(y3, x3) * 57.29578f - 270f - LocalPlayer.Entity.transform.eulerAngles.y;
							float num11 = num9 * Mathf.Cos(num10 * 0.0174532924f);
							float num12 = num9 * Mathf.Sin(num10 * 0.0174532924f);
							num11 = num11 * (Radar.Radar_Size / Radar.Radar_Range) / 2f;
							num12 = num12 * (Radar.Radar_Size / Radar.Radar_Range) / 2f;
							if (num9 <= Radar.Radar_Range)
							{
								Rendering.BoxRect(new Rect(Radar.Radar_X + Radar.Radar_Size / 2f + num11 - 3f, Radar.Radar_Y + Radar.Radar_Size / 2f + num12 - 3f, 6f, 6f), Color.white);
								Rendering.DrawString1(new Vector2(Radar.Radar_X + Radar.Radar_Size / 2f + num11 - 3f, Radar.Radar_Y + Radar.Radar_Size / 2f + num12 - 3f), string.Format("{0}", oreResourceEntity.ShortPrefabName), color2, true, 9, FontStyle.Bold, 1);
							}
						}
					}
					if (Main.RadarMetalOre.GetData<bool>())
					{
						foreach (OreResourceEntity oreResourceEntity2 in Entities.oretest1)
						{
							Vector3 position7 = LocalPlayer.Entity.transform.position;
							Vector3 position8 = oreResourceEntity2.transform.position;
							float num13 = Vector3.Distance(position7, position8);
							float y4 = position7.x - position8.x;
							float x4 = position7.z - position8.z;
							float num14 = Mathf.Atan2(y4, x4) * 57.29578f - 270f - LocalPlayer.Entity.transform.eulerAngles.y;
							float num15 = num13 * Mathf.Cos(num14 * 0.0174532924f);
							float num16 = num13 * Mathf.Sin(num14 * 0.0174532924f);
							num15 = num15 * (Radar.Radar_Size / Radar.Radar_Range) / 2f;
							num16 = num16 * (Radar.Radar_Size / Radar.Radar_Range) / 2f;
							if (num13 <= Radar.Radar_Range)
							{
								Rendering.BoxRect(new Rect(Radar.Radar_X + Radar.Radar_Size / 2f + num15 - 3f, Radar.Radar_Y + Radar.Radar_Size / 2f + num16 - 3f, 6f, 6f), Color.gray);
								Rendering.DrawString1(new Vector2(Radar.Radar_X + Radar.Radar_Size / 2f + num15 - 3f, Radar.Radar_Y + Radar.Radar_Size / 2f + num16 - 3f), string.Format("{0}", oreResourceEntity2.ShortPrefabName), color2, true, 9, FontStyle.Bold, 1);
							}
						}
					}
					if (Main.RadarSulfurOre.GetData<bool>())
					{
						foreach (OreResourceEntity oreResourceEntity3 in Entities.oretest2)
						{
							Vector3 position9 = LocalPlayer.Entity.transform.position;
							Vector3 position10 = oreResourceEntity3.transform.position;
							float num17 = Vector3.Distance(position9, position10);
							float y5 = position9.x - position10.x;
							float x5 = position9.z - position10.z;
							float num18 = Mathf.Atan2(y5, x5) * 57.29578f - 270f - LocalPlayer.Entity.transform.eulerAngles.y;
							float num19 = num17 * Mathf.Cos(num18 * 0.0174532924f);
							float num20 = num17 * Mathf.Sin(num18 * 0.0174532924f);
							num19 = num19 * (Radar.Radar_Size / Radar.Radar_Range) / 2f;
							num20 = num20 * (Radar.Radar_Size / Radar.Radar_Range) / 2f;
							if (num17 <= Radar.Radar_Range)
							{
								Rendering.BoxRect(new Rect(Radar.Radar_X + Radar.Radar_Size / 2f + num19 - 3f, Radar.Radar_Y + Radar.Radar_Size / 2f + num20 - 3f, 6f, 6f), Color.yellow);
								Rendering.DrawString1(new Vector2(Radar.Radar_X + Radar.Radar_Size / 2f + num19 - 3f, Radar.Radar_Y + Radar.Radar_Size / 2f + num20 - 3f), string.Format("{0}", oreResourceEntity3.ShortPrefabName), color2, true, 9, FontStyle.Bold, 1);
							}
						}
					}
					if (Main.moveable.GetData<bool>() && Main.Menu.Enabled)
					{
						float num21 = 0.5f;
						if (Input.GetKey(KeyCode.UpArrow))
						{
							Radar.Radar_Y -= num21;
						}
						else if (Input.GetKey(KeyCode.DownArrow))
						{
							Radar.Radar_Y += num21;
						}
						else if (!Input.GetKey(KeyCode.O))
						{
							if (Input.GetKey(KeyCode.P))
							{
								Radar.Radar_X += num21;
							}
						}
						else
						{
							Radar.Radar_X -= num21;
						}
					}
					if (Main.resize.GetData<bool>() && Main.Menu.Enabled)
					{
						float num22 = 0.5f;
						if (!Input.GetKey(KeyCode.X))
						{
							if (Input.GetKey(KeyCode.Y))
							{
								Radar.Radar_Size += num22;
							}
						}
						else
						{
							Radar.Radar_Size -= num22;
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00004B5F File Offset: 0x00002D5F
		private void test()
		{
			if (Main.Radar1011.GetData<bool>())
			{
				Rendering.DrawRadarBackground(new Rect(Radar.Radar_X, Radar.Radar_Y, Radar.Radar_Size, Radar.Radar_Size));
			}
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00018790 File Offset: 0x00016990
		private void OnGUI()
		{
			try
			{
				this.Radarshit();
				this.test();
			}
			catch
			{
			}
		}

		// Token: 0x04000272 RID: 626
		public static float Radar_X = 378.5f;

		// Token: 0x04000273 RID: 627
		public static float Radar_Y = 233f;

		// Token: 0x04000274 RID: 628
		public static float Radar_Size = 250f;

		// Token: 0x04000275 RID: 629
		public static float Radar_Range = 300f;
	}
}
