using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000019 RID: 25
	public class Aimbot : MonoBehaviour
	{
		// Token: 0x060000EE RID: 238 RVA: 0x0000942C File Offset: 0x0000762C
		public static Vector3 GetPosTargetPlayer()
		{
			Vector3 result = Vector3.zero;
			Vector2 a = new Vector2((float)(Aimbot.smethod_0() / 2), (float)(Aimbot.smethod_1() / 2));
			float num = 999f;
			IEnumerator<BasePlayer> enumerator = Aimbot.smethod_2().GetEnumerator();
			try
			{
				while (Aimbot.smethod_9(enumerator))
				{
					BasePlayer basePlayer = enumerator.Current;
					if (!Aimbot.smethod_3(basePlayer, null) && !Aimbot.smethod_4(basePlayer) && !Aimbot.smethod_5(basePlayer) && Aimbot.smethod_6(basePlayer) > 0f)
					{
						Vector3 bonePosition = Aimbot.GetBonePosition(Aimbot.smethod_7(basePlayer), "headCenter");
						if (!(bonePosition == Vector3.zero))
						{
							Vector3 vector = Aimbot.smethod_8(MainCamera.mainCamera, bonePosition);
							if (vector.z > 0f)
							{
								Vector2 b = new Vector2(vector.x, (float)Aimbot.smethod_1() - vector.y);
								float num2 = Mathf.Abs(Vector2.Distance(a, b));
								if (num2 <= Aimbot.aimbotFov && num2 <= num)
								{
									result = bonePosition;
									num = num2;
								}
							}
						}
					}
				}
			}
			finally
			{
				if (enumerator != null)
				{
					Aimbot.smethod_10(enumerator);
				}
			}
			return result;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000955C File Offset: 0x0000775C
		public static void DoAimbotHeli()
		{
			Vector3 heliVector = Aimbot.GetHeliVector();
			if (heliVector != Vector3.zero)
			{
				Vector3 a = heliVector;
				Quaternion quaternion = Quaternion.LookRotation(a - Aimbot.smethod_12(Aimbot.smethod_11(MainCamera.mainCamera)), Vector3.right);
				float num = quaternion.eulerAngles.x;
				float num2 = quaternion.eulerAngles.y;
				float z = quaternion.eulerAngles.z;
				while (num >= 180f)
				{
					num -= 360f;
				}
				while (num <= -180f)
				{
					num += 360f;
				}
				if (num <= 89f)
				{
					if (num < -89f)
					{
						num = -89f;
					}
				}
				else
				{
					num = 89f;
				}
				while (num2 >= 360f)
				{
					num2 -= 360f;
				}
				while (num2 <= -360f)
				{
					num2 += 360f;
				}
				LocalPlayer.Entity.input.SetViewVars(new Vector3(num, num2, 0f));
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000966C File Offset: 0x0000786C
		public static void DoAimbotWithVisCheck()
		{
			Vector3 enemyVector = Aimbot.GetEnemyVector();
			if (enemyVector != Vector3.zero)
			{
				Vector3 a = enemyVector;
				Quaternion quaternion = Quaternion.LookRotation(a - Aimbot.smethod_12(Aimbot.smethod_11(MainCamera.mainCamera)), Vector3.right);
				float num = quaternion.eulerAngles.x;
				float num2 = quaternion.eulerAngles.y;
				float z = quaternion.eulerAngles.z;
				while (num >= 180f)
				{
					num -= 360f;
				}
				while (num <= -180f)
				{
					num += 360f;
				}
				if (num > 89f)
				{
					num = 89f;
				}
				else if (num < -89f)
				{
					num = -89f;
				}
				while (num2 >= 360f)
				{
					num2 -= 360f;
				}
				while (num2 <= -360f)
				{
					num2 += 360f;
				}
				LocalPlayer.Entity.input.SetViewVars(new Vector3(num, num2, 0f));
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00009774 File Offset: 0x00007974
		public static void DoAimbotWihoutVisCheck()
		{
			Vector3 enemyVector = Aimbot.GetEnemyVector1();
			if (enemyVector != Vector3.zero)
			{
				Vector3 a = enemyVector;
				Quaternion quaternion = Quaternion.LookRotation(a - Aimbot.smethod_12(Aimbot.smethod_11(MainCamera.mainCamera)), Vector3.right);
				float num = quaternion.eulerAngles.x;
				float num2 = quaternion.eulerAngles.y;
				float z = quaternion.eulerAngles.z;
				while (num >= 180f)
				{
					num -= 360f;
				}
				while (num <= -180f)
				{
					num += 360f;
				}
				if (num > 89f)
				{
					num = 89f;
				}
				else if (num < -89f)
				{
					num = -89f;
				}
				while (num2 >= 360f)
				{
					num2 -= 360f;
				}
				while (num2 <= -360f)
				{
					num2 += 75f;
				}
				LocalPlayer.Entity.input.SetViewVars(new Vector3(num, num2, 0f));
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000987C File Offset: 0x00007A7C
		public static Vector3 GetEnemyVector()
		{
			Vector3 vector = Vector3.zero;
			Vector2 vector2 = new Vector2((float)(Aimbot.smethod_0() / 2), (float)(Aimbot.smethod_1() / 2));
			float num = 250f;
			foreach (BasePlayer basePlayer in Aimbot.smethod_2())
			{
				if (Main.VisCheck.GetData<bool>() && (Aimbot.smethod_13(basePlayer, null) && Aimbot.smethod_6(basePlayer) > 0f && (!Aimbot.smethod_5(basePlayer) && !Aimbot.smethod_4(basePlayer)) && !Aimbot.smethod_14(basePlayer)))
				{
					Vector3 vector3 = Aimbot.GetBonePosition(Aimbot.smethod_7(basePlayer), "headCenter") + new Vector3(0f, 0.04f, 0.04f);
					if (Main.body.GetData<bool>() && !basePlayer.IsNpc)
					{
						vector3 = basePlayer.model.rootBone.transform.position;
					}
					if (vector3 != Vector3.zero && Aimbot.IsVisible(vector3))
					{
						Vector3 vector4 = MainCamera.mainCamera.WorldToScreenPoint(vector3);
						Vector2 vector5 = new Vector2(vector4.x, (float)Screen.height - vector4.y);
						Vector3 vector6 = MainCamera.mainCamera.WorldToScreenPoint(Aimbot.GetBonePosition(basePlayer.GetModel(), "headCenter") + new Vector3(0f, 0.04f, 0.04f));
						float num2 = Mathf.Abs(Vector2.Distance(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), new Vector2(vector6.x, (float)Screen.height - vector6.y)));
						if (num2 <= Aimbot.aimbotFov && num2 < num && basePlayer.IsAlive() && !FriendManager.friendsList.Contains(basePlayer.userID))
						{
							vector = vector3;
							Item activeItem = LocalPlayer.Entity.Belt.GetActiveItem();
							if (activeItem != null && (activeItem.info.shortname.Contains("bow") || activeItem.info.shortname.Contains("smg.") || activeItem.info.shortname.Contains("pistol.") || activeItem.info.shortname.Contains("lmg.") || activeItem.info.shortname.Contains("rifle")) && (Main.BulletDropPrediction.GetData<bool>() || Main.VelocityPrediction.GetData<bool>()))
							{
								float num3 = 250f;
								string shortname = activeItem.info.shortname;
								uint num4 = <PrivateImplementationDetails>.ComputeStringHash(shortname);
								if (num4 > 1954369282u)
								{
									if (num4 > 2718065392u)
									{
										if (num4 <= 3536118064u)
										{
											if (num4 != 2902096337u)
											{
												if (num4 == 3536118064u)
												{
													if (shortname == "smg.mp5")
													{
														num3 = 240f;
													}
												}
											}
											else if (shortname == "crossbow")
											{
												num3 = 75f;
											}
										}
										else if (num4 != 3623282768u)
										{
											if (num4 != 3883689649u)
											{
												if (num4 == 4095222077u && shortname == "rifle.ak")
												{
													num3 = 375f;
												}
											}
											else if (shortname == "pistol.semiauto")
											{
												num3 = 300f;
											}
										}
										else if (shortname == "rifle.semiauto")
										{
											num3 = 375f;
										}
									}
									else if (num4 <= 2395673910u)
									{
										if (num4 != 2104069632u)
										{
											if (num4 == 2395673910u && shortname == "smg.2")
											{
												num3 = 240f;
											}
										}
										else if (shortname == "rifle.lr300")
										{
											num3 = 375f;
										}
									}
									else if (num4 != 2611184920u)
									{
										if (num4 == 2718065392u)
										{
											if (shortname == "rifle.m39")
											{
												num3 = 375f;
											}
										}
									}
									else if (shortname == "rifle.l96")
									{
										num3 = 700.25f;
									}
								}
								else if (num4 > 1181887591u)
								{
									if (num4 <= 1444866224u)
									{
										if (num4 != 1243766686u)
										{
											if (num4 == 1444866224u)
											{
												if (shortname == "smg.thompson")
												{
													num3 = 300f;
												}
											}
										}
										else if (shortname == "pistol.nailgun")
										{
											num3 = 61f;
										}
									}
									else if (num4 == 1650800279u)
									{
										if (shortname == "pistol.revolver")
										{
											num3 = 275f;
										}
									}
									else if (num4 == 1954369282u && shortname == "pistol.python")
									{
										num3 = 300f;
									}
								}
								else if (num4 <= 429205216u)
								{
									if (num4 != 36942094u)
									{
										if (num4 == 429205216u && shortname == "pistol.m92")
										{
											num3 = 300f;
										}
									}
									else if (shortname == "rifle.bolt")
									{
										num3 = 656.25f;
									}
								}
								else if (num4 == 575405862u)
								{
									if (shortname == "bow.hunting")
									{
										num3 = 60f;
									}
								}
								else if (num4 == 1181887591u && shortname == "lmg.m249")
								{
									num3 = 400f;
								}
								if (Misc.localplayer.GetHeldEntity().GetComponent<BaseProjectile>().IsSilenced())
								{
									num3 *= 0.745f;
								}
								if (Main.VelocityPrediction.GetData<bool>())
								{
									float num5 = Vector3.Distance(LocalPlayer.Entity.transform.position, vector3) / num3;
									Vector3 vector7 = (Vector3)Aimbot.fieldInfo_1.GetValue(basePlayer.playerModel);
									vector.x += vector7.x * num5;
									vector.y += vector7.y * num5;
									vector.z += vector7.z * num5;
								}
								if (Main.BulletDropPrediction.GetData<bool>())
								{
									vector.y += Aimbot.BulletDrop(LocalPlayer.Entity.transform.position, vector3, num3);
								}
							}
							num = num2;
						}
					}
				}
			}
			return vector;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00009F0C File Offset: 0x0000810C
		public static Vector3 GetEnemyVector1()
		{
			Vector3 vector = Vector3.zero;
			Vector2 vector2 = new Vector2((float)(Aimbot.smethod_0() / 2), (float)(Aimbot.smethod_1() / 2));
			float num = 250f;
			foreach (BasePlayer basePlayer in Aimbot.smethod_2())
			{
				if (Main.shouldEnableAimbot.GetData<bool>() && (Aimbot.smethod_13(basePlayer, null) && Aimbot.smethod_6(basePlayer) > 0f && (!Aimbot.smethod_5(basePlayer) && !Aimbot.smethod_4(basePlayer)) && !Aimbot.smethod_14(basePlayer)))
				{
					Vector3 vector3 = Aimbot.GetBonePosition(Aimbot.smethod_7(basePlayer), "headCenter") + new Vector3(0f, 0.04f, 0.04f);
					if (Main.body.GetData<bool>() && !basePlayer.IsNpc)
					{
						vector3 = basePlayer.model.rootBone.transform.position;
					}
					if (vector3 != Vector3.zero)
					{
						Vector3 vector4 = MainCamera.mainCamera.WorldToScreenPoint(vector3);
						Vector3 vector5 = MainCamera.mainCamera.WorldToScreenPoint(Aimbot.GetBonePosition(basePlayer.GetModel(), "headCenter") + new Vector3(0f, 0.04f, 0.04f));
						Vector2 vector6 = new Vector2(vector4.x, (float)Screen.height - vector4.y);
						float num2 = Mathf.Abs(Vector2.Distance(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), new Vector2(vector5.x, (float)Screen.height - vector5.y)));
						if (num2 <= Aimbot.aimbotFov && num2 < num && basePlayer.IsAlive() && !FriendManager.friendsList.Contains(basePlayer.userID))
						{
							vector = vector3;
							Item activeItem = LocalPlayer.Entity.Belt.GetActiveItem();
							if (activeItem != null && (activeItem.info.shortname.Contains("bow") || activeItem.info.shortname.Contains("smg.") || activeItem.info.shortname.Contains("pistol.") || activeItem.info.shortname.Contains("lmg.") || activeItem.info.shortname.Contains("rifle")) && (Main.BulletDropPrediction.GetData<bool>() || Main.VelocityPrediction.GetData<bool>()))
							{
								float num3 = 250f;
								string shortname = activeItem.info.shortname;
								uint num4 = <PrivateImplementationDetails>.ComputeStringHash(shortname);
								if (num4 <= 1954369282u)
								{
									if (num4 > 1181887591u)
									{
										if (num4 <= 1444866224u)
										{
											if (num4 == 1243766686u)
											{
												if (shortname == "pistol.nailgun")
												{
													num3 = 61f;
												}
											}
											else if (num4 == 1444866224u)
											{
												if (shortname == "smg.thompson")
												{
													num3 = 300f;
												}
											}
										}
										else if (num4 != 1650800279u)
										{
											if (num4 == 1954369282u)
											{
												if (shortname == "pistol.python")
												{
													num3 = 300f;
												}
											}
										}
										else if (shortname == "pistol.revolver")
										{
											num3 = 275f;
										}
									}
									else if (num4 > 429205216u)
									{
										if (num4 != 575405862u)
										{
											if (num4 == 1181887591u)
											{
												if (shortname == "lmg.m249")
												{
													num3 = 400f;
												}
											}
										}
										else if (shortname == "bow.hunting")
										{
											num3 = 60f;
										}
									}
									else if (num4 != 36942094u)
									{
										if (num4 == 429205216u)
										{
											if (shortname == "pistol.m92")
											{
												num3 = 300f;
											}
										}
									}
									else if (shortname == "rifle.bolt")
									{
										num3 = 656.25f;
									}
								}
								else if (num4 > 2718065392u)
								{
									if (num4 <= 3536118064u)
									{
										if (num4 == 2902096337u)
										{
											if (shortname == "crossbow")
											{
												num3 = 75f;
											}
										}
										else if (num4 == 3536118064u)
										{
											if (shortname == "smg.mp5")
											{
												num3 = 240f;
											}
										}
									}
									else if (num4 != 3623282768u)
									{
										if (num4 == 3883689649u)
										{
											if (shortname == "pistol.semiauto")
											{
												num3 = 300f;
											}
										}
										else if (num4 == 4095222077u)
										{
											if (shortname == "rifle.ak")
											{
												num3 = 375f;
											}
										}
									}
									else if (shortname == "rifle.semiauto")
									{
										num3 = 375f;
									}
								}
								else if (num4 > 2395673910u)
								{
									if (num4 != 2611184920u)
									{
										if (num4 == 2718065392u)
										{
											if (shortname == "rifle.m39")
											{
												num3 = 373f;
											}
										}
									}
									else if (shortname == "rifle.l96")
									{
										num3 = 700.25f;
									}
								}
								else if (num4 != 2104069632u)
								{
									if (num4 == 2395673910u && shortname == "smg.2")
									{
										num3 = 240f;
									}
								}
								else if (shortname == "rifle.lr300")
								{
									num3 = 375f;
								}
								if (Misc.localplayer.GetHeldEntity().GetComponent<BaseProjectile>().IsSilenced())
								{
									num3 *= 0.745f;
								}
								if (Main.VelocityPrediction.GetData<bool>())
								{
									Aimbot.currentTime = Time.time;
									if (Aimbot.lastTime != 0f && Aimbot.currentTime != Aimbot.lastTime)
									{
										float d = Aimbot.currentTime - Aimbot.lastTime;
										Vector3 a = vector - Aimbot.targetLastPosition;
										Aimbot.targetVelocity = a / d;
									}
									if (Aimbot.targetVelocity == Vector3.zero)
									{
										Aimbot.targetVelocity = Aimbot.lastVelocity;
									}
									else
									{
										Aimbot.lastVelocity = Aimbot.targetVelocity;
									}
									Aimbot.lastTime = Aimbot.currentTime;
									Aimbot.targetLastPosition = vector;
									float num5 = Vector3.Distance(LocalPlayer.Entity.transform.position, vector3) / num3;
									Vector3 vector7 = (Vector3)basePlayer.playerModel.GetFieldValue("velocity");
									vector.x += vector7.x * num5;
									vector.y += vector7.y * num5;
									vector.z += vector7.z * num5;
								}
								if (Main.BulletDropPrediction.GetData<bool>())
								{
									vector.y += Aimbot.BulletDrop(LocalPlayer.Entity.transform.position, vector3, num3);
								}
							}
							num = num2;
						}
					}
				}
			}
			return vector;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000A624 File Offset: 0x00008824
		public static Vector3 GetHeliVector()
		{
			Vector3 vector = Vector3.zero;
			Vector2 vector2 = new Vector2((float)(Aimbot.smethod_0() / 2), (float)(Aimbot.smethod_1() / 2));
			float num = 4999f;
			foreach (BaseHelicopter baseHelicopter in Entities.heli1)
			{
				if (Aimbot.smethod_13(baseHelicopter, null) && Aimbot.smethod_6(baseHelicopter) > 0f && !Aimbot.smethod_15(baseHelicopter))
				{
					Vector3 vector3 = Aimbot.smethod_12(Aimbot.smethod_16(baseHelicopter.mainRotor)) + new Vector3(0f, 0.5f, 0f);
					if (vector3 != Vector3.zero)
					{
						Vector3 vector4 = MainCamera.mainCamera.WorldToScreenPoint(vector3);
						Vector3 vector5 = MainCamera.mainCamera.WorldToScreenPoint(baseHelicopter.mainRotor.transform.position + new Vector3(0f, 0.5f, 0f));
						Vector2 vector6 = new Vector2(vector4.x, (float)Screen.height - vector4.y);
						float num2 = Mathf.Abs(Vector2.Distance(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), new Vector2(vector5.x, (float)Screen.height - vector5.y)));
						if (num2 <= Aimbot.aimbotFov && num2 < num && baseHelicopter.IsAlive())
						{
							vector = vector3;
							Item activeItem = LocalPlayer.Entity.Belt.GetActiveItem();
							if (activeItem != null && (activeItem.info.shortname.Contains("bow") || activeItem.info.shortname.Contains("smg.") || activeItem.info.shortname.Contains("pistol.") || activeItem.info.shortname.Contains("lmg.") || activeItem.info.shortname.Contains("rifle")))
							{
								float num3 = 250f;
								string shortname = activeItem.info.shortname;
								uint num4 = <PrivateImplementationDetails>.ComputeStringHash(shortname);
								if (num4 > 1954369282u)
								{
									if (num4 > 2718065392u)
									{
										if (num4 > 3536118064u)
										{
											if (num4 != 3623282768u)
											{
												if (num4 != 3883689649u)
												{
													if (num4 == 4095222077u && shortname == "rifle.ak")
													{
														num3 = 375f;
													}
												}
												else if (shortname == "pistol.semiauto")
												{
													num3 = 300f;
												}
											}
											else if (shortname == "rifle.semiauto")
											{
												num3 = 375f;
											}
										}
										else if (num4 != 2902096337u)
										{
											if (num4 == 3536118064u)
											{
												if (shortname == "smg.mp5")
												{
													num3 = 240f;
												}
											}
										}
										else if (shortname == "crossbow")
										{
											num3 = 75f;
										}
									}
									else if (num4 > 2395673910u)
									{
										if (num4 == 2611184920u)
										{
											if (shortname == "rifle.l96")
											{
												num3 = 700.25f;
											}
										}
										else if (num4 == 2718065392u)
										{
											if (shortname == "rifle.m39")
											{
												num3 = 373f;
											}
										}
									}
									else if (num4 == 2104069632u)
									{
										if (shortname == "rifle.lr300")
										{
											num3 = 375f;
										}
									}
									else if (num4 == 2395673910u && shortname == "smg.2")
									{
										num3 = 240f;
									}
								}
								else if (num4 > 1181887591u)
								{
									if (num4 <= 1444866224u)
									{
										if (num4 == 1243766686u)
										{
											if (shortname == "pistol.nailgun")
											{
												num3 = 61f;
											}
										}
										else if (num4 == 1444866224u && shortname == "smg.thompson")
										{
											num3 = 300f;
										}
									}
									else if (num4 != 1650800279u)
									{
										if (num4 == 1954369282u)
										{
											if (shortname == "pistol.python")
											{
												num3 = 300f;
											}
										}
									}
									else if (shortname == "pistol.revolver")
									{
										num3 = 275f;
									}
								}
								else if (num4 > 429205216u)
								{
									if (num4 == 575405862u)
									{
										if (shortname == "bow.hunting")
										{
											num3 = 60f;
										}
									}
									else if (num4 == 1181887591u)
									{
										if (shortname == "lmg.m249")
										{
											num3 = 400f;
										}
									}
								}
								else if (num4 == 36942094u)
								{
									if (shortname == "rifle.bolt")
									{
										num3 = 656.25f;
									}
								}
								else if (num4 == 429205216u && shortname == "pistol.m92")
								{
									num3 = 300f;
								}
								if (Misc.localplayer.GetHeldEntity().GetComponent<BaseProjectile>().IsSilenced())
								{
									num3 *= 0.745f;
								}
								vector.y += Aimbot.BulletDrop(LocalPlayer.Entity.transform.position, vector3, num3);
							}
							num = num2;
						}
					}
				}
			}
			return vector;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000AB98 File Offset: 0x00008D98
		public static BaseHelicopter GetTargetHeli()
		{
			BaseHelicopter result = null;
			Vector2 vector = new Vector2((float)Aimbot.smethod_0() / 2f, (float)Aimbot.smethod_1() / 2f);
			float num = 1000f;
			foreach (BaseHelicopter baseHelicopter in Entities.heli1)
			{
				if (!Aimbot.smethod_3(baseHelicopter, null) && Aimbot.smethod_6(baseHelicopter) > 0f)
				{
					Vector3 vector2 = Aimbot.smethod_8(MainCamera.mainCamera, Aimbot.smethod_12(Aimbot.smethod_16(baseHelicopter.mainRotor)));
					Vector2 vector3 = new Vector2(vector2.x, (float)Aimbot.smethod_1() - vector2.y);
					float num2 = Mathf.Abs(Vector2.Distance(new Vector2((float)(Aimbot.smethod_0() / 2), (float)(Aimbot.smethod_1() / 2)), new Vector2(vector2.x, (float)Screen.height - vector2.y)));
					if (num2 <= Aimbot.aimbotFov && num2 < num && baseHelicopter.IsAlive())
					{
						num = num2;
						result = baseHelicopter;
					}
				}
			}
			return result;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000ACCC File Offset: 0x00008ECC
		public static bool IsVisible(Vector3 vector3_0)
		{
			Vector3 a = Aimbot.smethod_12(Aimbot.smethod_11(MainCamera.mainCamera)) - vector3_0;
			float magnitude = a.magnitude;
			bool result;
			if (magnitude >= Mathf.Epsilon)
			{
				Vector3 vector = a / magnitude;
				Vector3 b = vector * Mathf.Min(magnitude, 0.01f);
				result = LocalPlayer.Entity.IsVisible(new Ray(vector3_0 + b, vector), magnitude);
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000AD3C File Offset: 0x00008F3C
		public static Vector3 GetBonePositionHeli(BaseHelicopter playerModel, string boneName)
		{
			Vector3 zero = Vector3.zero;
			Vector3 result;
			if (!Aimbot.smethod_3(playerModel, null))
			{
				if (!Aimbot.smethod_17(boneName, "mainRotor"))
				{
					result = playerModel.FindBone(boneName).position;
				}
				else
				{
					result = new Vector3(Aimbot.smethod_12(Aimbot.smethod_16(playerModel.mainRotor)).x, Aimbot.smethod_12(Aimbot.smethod_16(playerModel.mainRotor)).y);
				}
			}
			else
			{
				result = zero;
			}
			return result;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000ADAC File Offset: 0x00008FAC
		public static Vector3 GetBonePosition(Model playerModel, string boneName)
		{
			Vector3 zero = Vector3.zero;
			Vector3 result;
			if (Aimbot.smethod_3(playerModel, null))
			{
				result = zero;
			}
			else if (Aimbot.smethod_17(boneName, "headCenter"))
			{
				result = new Vector3(Aimbot.smethod_12(playerModel.headBone).x, Aimbot.smethod_12(playerModel.eyeBone).y, Aimbot.smethod_12(playerModel.headBone).z);
			}
			else
			{
				result = playerModel.FindBone(boneName).position;
			}
			return result;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000AE20 File Offset: 0x00009020
		public static BuildingPrivlidge GetTargetTC()
		{
			BuildingPrivlidge result = null;
			Vector2 vector = new Vector2((float)Aimbot.smethod_0() / 2f, (float)Aimbot.smethod_1() / 2f);
			float num = 1000f;
			foreach (BuildingPrivlidge buildingPrivlidge in Entities.tcshit)
			{
				if (!Aimbot.smethod_3(buildingPrivlidge, null) && Aimbot.smethod_6(buildingPrivlidge) > 0f && !Aimbot.smethod_18(buildingPrivlidge))
				{
					Vector3 vector2 = Aimbot.smethod_8(MainCamera.mainCamera, Aimbot.smethod_12(Aimbot.smethod_11(buildingPrivlidge)));
					new Vector2(vector2.x, (float)Aimbot.smethod_1() - vector2.y);
					float num2 = Mathf.Abs(Vector2.Distance(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), new Vector2(vector2.x, (float)Screen.height - vector2.y)));
					if (num2 <= Aimbot.aimbotFov && num2 < num && buildingPrivlidge.IsAlive())
					{
						num = num2;
						result = buildingPrivlidge;
					}
				}
			}
			return result;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000AF5C File Offset: 0x0000915C
		public static BasePlayer GetTarget()
		{
			BasePlayer result = null;
			Vector2 vector = new Vector2((float)Aimbot.smethod_0() / 2f, (float)Aimbot.smethod_1() / 2f);
			float num = 1000f;
			foreach (BasePlayer basePlayer in Aimbot.smethod_2())
			{
				if (!Aimbot.smethod_3(basePlayer, null) && !Aimbot.smethod_4(basePlayer) && Aimbot.smethod_6(basePlayer) > 0f && !Aimbot.smethod_18(basePlayer))
				{
					Vector3 vector2 = Aimbot.smethod_8(MainCamera.mainCamera, Aimbot.smethod_12(Aimbot.smethod_11(basePlayer)));
					new Vector2(vector2.x, (float)Aimbot.smethod_1() - vector2.y);
					float num2 = Mathf.Abs(Vector2.Distance(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), new Vector2(vector2.x, (float)Screen.height - vector2.y)));
					if (num2 <= Aimbot.aimbotFov && num2 < num && basePlayer.IsAlive())
					{
						num = num2;
						result = basePlayer;
					}
				}
			}
			return result;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000B09C File Offset: 0x0000929C
		public static float BulletDrop(Vector3 v1, Vector3 v2, float BulletSpeed)
		{
			float num = Vector3.Distance(v1, v2);
			float result;
			if ((double)num < 0.001)
			{
				result = 0f;
			}
			else
			{
				float num2 = num / BulletSpeed;
				result = (float)((double)4.905f * (double)num2 * (double)num2);
			}
			return result;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000B0DC File Offset: 0x000092DC
		private void OnGUI()
		{
			if (Main.VisCheck.GetData<bool>() && Aimbot.smethod_13(Aimbot.smethod_19(), null) && Aimbot.smethod_20((KeyCode)Main.aimkeyvisible.GetSubContent<List<object>>().ElementAtOrDefault(Main.aimkeyvisible.GetData<int>())))
			{
				Aimbot.DoAimbotWithVisCheck();
			}
			if (Main.shouldEnableAimbot.GetData<bool>() && Aimbot.smethod_13(Aimbot.smethod_19(), null) && Aimbot.smethod_20((KeyCode)Main.Aim_Key.GetSubContent<List<object>>().ElementAtOrDefault(Main.Aim_Key.GetData<int>())))
			{
				Aimbot.DoAimbotWihoutVisCheck();
			}
			if (Main.heliaim.GetData<bool>() && Aimbot.smethod_13(Aimbot.smethod_19(), null) && Aimbot.smethod_20(KeyCode.X))
			{
				Aimbot.DoAimbotHeli();
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000421B File Offset: 0x0000241B
		static int smethod_0()
		{
			return Screen.width;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00004222 File Offset: 0x00002422
		static int smethod_1()
		{
			return Screen.height;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000425F File Offset: 0x0000245F
		static BufferList<BasePlayer> smethod_2()
		{
			return BasePlayer.VisiblePlayerList;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00003F62 File Offset: 0x00002162
		static bool smethod_3(UnityEngine.Object object_0, UnityEngine.Object object_1)
		{
			return object_0 == object_1;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00004266 File Offset: 0x00002466
		static bool smethod_4(BasePlayer basePlayer_0)
		{
			return basePlayer_0.IsLocalPlayer();
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000426E File Offset: 0x0000246E
		static bool smethod_5(BasePlayer basePlayer_0)
		{
			return basePlayer_0.IsSleeping();
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00004276 File Offset: 0x00002476
		static float smethod_6(BaseCombatEntity baseCombatEntity_0)
		{
			return baseCombatEntity_0.health;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000427E File Offset: 0x0000247E
		static Model smethod_7(BaseEntity baseEntity_0)
		{
			return baseEntity_0.GetModel();
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00004286 File Offset: 0x00002486
		static Vector3 smethod_8(Camera camera_0, Vector3 vector3_0)
		{
			return camera_0.WorldToScreenPoint(vector3_0);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000428F File Offset: 0x0000248F
		static bool smethod_9(IEnumerator ienumerator_0)
		{
			return ienumerator_0.MoveNext();
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00004297 File Offset: 0x00002497
		static void smethod_10(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000429F File Offset: 0x0000249F
		static Transform smethod_11(Component component_0)
		{
			return component_0.transform;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000042A7 File Offset: 0x000024A7
		static Vector3 smethod_12(Transform transform_0)
		{
			return transform_0.position;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000400D File Offset: 0x0000220D
		static bool smethod_13(UnityEngine.Object object_0, UnityEngine.Object object_1)
		{
			return object_0 != object_1;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000042AF File Offset: 0x000024AF
		static bool smethod_14(BasePlayer basePlayer_0)
		{
			return basePlayer_0.IsWounded();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000042B7 File Offset: 0x000024B7
		static bool smethod_15(BaseNetworkable baseNetworkable_0)
		{
			return baseNetworkable_0.IsDestroyed;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000042BF File Offset: 0x000024BF
		static Transform smethod_16(GameObject gameObject_0)
		{
			return gameObject_0.transform;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00003E95 File Offset: 0x00002095
		static bool smethod_17(string string_0, string string_1)
		{
			return string_0 == string_1;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000042C7 File Offset: 0x000024C7
		static bool smethod_18(BaseCombatEntity baseCombatEntity_0)
		{
			return baseCombatEntity_0.IsDead();
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000042CF File Offset: 0x000024CF
		static BasePlayer smethod_19()
		{
			return LocalPlayer.Entity;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000042D6 File Offset: 0x000024D6
		static bool smethod_20(KeyCode keyCode_0)
		{
			return Input.GetKey(keyCode_0);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00003E9E File Offset: 0x0000209E
		static Type smethod_21(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00003E19 File Offset: 0x00002019
		static FieldInfo smethod_22(Type type_0, string string_0, BindingFlags bindingFlags_0)
		{
			return type_0.GetField(string_0, bindingFlags_0);
		}

		// Token: 0x0400007D RID: 125
		public static float aimbotFov = 150f;

		// Token: 0x0400007E RID: 126
		public static int Aim_Fov;

		// Token: 0x0400007F RID: 127
		public static int FovRadius;

		// Token: 0x04000080 RID: 128
		private static FieldInfo fieldInfo_1 = Aimbot.smethod_22(Aimbot.smethod_21(typeof(PlayerModel).TypeHandle), "velocity", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x04000081 RID: 129
		public static Vector3 targetLastPosition = Vector3.zero;

		// Token: 0x04000082 RID: 130
		public static Vector3 targetVelocity = Vector3.zero;

		// Token: 0x04000083 RID: 131
		public static Vector3 lastVelocity = Vector3.zero;

		// Token: 0x04000084 RID: 132
		public static float currentTime = 0f;

		// Token: 0x04000085 RID: 133
		public static float lastTime = 0f;
	}
}
