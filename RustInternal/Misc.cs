using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using ProtoBuf;
using UnityEngine;
using UnityEngine.Rendering;

namespace RustInternal
{
	// Token: 0x0200004E RID: 78
	public class Misc : MonoBehaviour
	{
		// Token: 0x06000316 RID: 790 RVA: 0x00013C3C File Offset: 0x00011E3C
		public static void striked()
		{
			if (Main.admin.GetData<bool>())
			{
				foreach (FlintStrikeWeapon flintStrikeWeapon in Entities.strike)
				{
					Misc.smethod_1(Misc.smethod_0().Belt);
					if (Misc.smethod_2(flintStrikeWeapon, null))
					{
						flintStrikeWeapon.successFraction = 99999f;
						flintStrikeWeapon.repeatDelay = 0f;
						flintStrikeWeapon.automatic = true;
						flintStrikeWeapon.deployDelay = 0f;
					}
				}
			}
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00013CD8 File Offset: 0x00011ED8
		public static void big()
		{
			foreach (global::BasePlayer basePlayer in Misc.smethod_3())
			{
				if (Misc.smethod_2(basePlayer, null))
				{
					Misc.smethod_4(basePlayer, "penis").localScale = new Vector3(0f, 20f, 0f);
				}
			}
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00013D4C File Offset: 0x00011F4C
		private void jackhammershit()
		{
			if (Main.jackhammerhack.GetData<bool>())
			{
				foreach (Jackhammer jackhammer in Entities.hammertime)
				{
					if (Misc.smethod_2(jackhammer, null))
					{
						jackhammer.attackRadius = 3f;
						jackhammer.effectiveRange = 5f;
						jackhammer.isAutomatic = true;
						jackhammer.maxDistance = 5f;
						jackhammer.repeatDelay = 0.1f;
					}
				}
			}
		}

		// Token: 0x06000319 RID: 793 RVA: 0x000049B2 File Offset: 0x00002BB2
		public void SetTimedAction(float time, Action action)
		{
			action();
			this.SetTimedActionTrampoline(time, action);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00013DE0 File Offset: 0x00011FE0
		public float SetTimedActionTrampoline(float time, Action action)
		{
			return 0f;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x000049C3 File Offset: 0x00002BC3
		public void OnLand(float fVelocity)
		{
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000432A File Offset: 0x0000252A
		public void OnLandTrampoline(float fVelocity)
		{
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00013DE0 File Offset: 0x00011FE0
		public static float GetAimCone()
		{
			return 0f;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00013DE0 File Offset: 0x00011FE0
		public static float GetAimConeTrampoline()
		{
			return 0f;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000432A File Offset: 0x0000252A
		public static void AddPunch(Vector3 amount, float duration)
		{
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000432A File Offset: 0x0000252A
		public static void AddPunchTrampoline(Vector3 amount, float duration)
		{
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00013DF4 File Offset: 0x00011FF4
		public void SendProjectileAttack(PlayerProjectileAttack attack)
		{
			if (Main.silentaimbotheli.GetData<bool>() && !Main.silentaimbotdick.GetData<bool>() && !Main.silentaimbot.GetData<bool>() && !Main.killscientist.GetData<bool>() && !Main.killafterdead.GetData<bool>())
			{
				foreach (BaseHelicopter baseHelicopter in Entities.heli1)
				{
					if (Misc.smethod_5(baseHelicopter) <= 5000f || !Misc.smethod_2(baseHelicopter, null))
					{
						attack.hitDistance = -1337f;
						attack.playerAttack.attack.hitID = baseHelicopter.net.ID;
						attack.playerAttack.attack.hitBone = 2699525250u;
						attack.playerAttack.attack.hitPartID = 2306822461u;
						attack.playerAttack.attack.hitPositionLocal = new Vector3(0.9f, -0.4f, 0.1f);
						attack.playerAttack.attack.hitNormalLocal = new Vector3(0.9f, -0.4f, 0.1f);
						LocalPlayer.Entity.ServerRPC<PlayerProjectileAttack>("OnProjectileAttack", attack);
					}
					else
					{
						attack.hitDistance = -1337f;
						attack.playerAttack.attack.hitID = baseHelicopter.net.ID;
						attack.playerAttack.attack.hitBone = 224139191u;
						attack.playerAttack.attack.hitPartID = 2306822461u;
						attack.playerAttack.attack.hitPositionLocal = new Vector3(0.9f, -0.4f, 0.1f);
						attack.playerAttack.attack.hitNormalLocal = new Vector3(0.9f, -0.4f, 0.1f);
						LocalPlayer.Entity.ServerRPC<PlayerProjectileAttack>("OnProjectileAttack", attack);
					}
				}
			}
			if (Main.silentaimbot.GetData<bool>() && !Main.silentaimbotdick.GetData<bool>() && !Main.silentaimbotheli.GetData<bool>() && !Main.killafterdead.GetData<bool>() && !Main.killscientist.GetData<bool>())
			{
				foreach (global::BasePlayer basePlayer in global::BasePlayer.VisiblePlayerList)
				{
					float num = 150f;
					Vector3 vector = MainCamera.mainCamera.WorldToScreenPoint(basePlayer.model.headBone.transform.position);
					float num2 = Mathf.Abs(Vector2.Distance(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), new Vector2(vector.x, (float)Screen.height - vector.y)));
					if (basePlayer != null && !basePlayer.IsLocalPlayer() && !basePlayer.IsNpc && num2 <= Aimbot.aimbotFov && num2 < num && !basePlayer.IsDead() && !FriendManager.friendsList.Contains(basePlayer.userID))
					{
						attack.hitDistance = -1337f;
						attack.playerAttack.attack.hitID = basePlayer.net.ID;
						attack.playerAttack.attack.hitBone = 698017942u;
						attack.playerAttack.attack.hitPartID = 2173623152u;
						attack.playerAttack.attack.hitPositionLocal = new Vector3(-0.1f, -0.1f, 0f);
						attack.playerAttack.attack.hitNormalLocal = new Vector3(0f, -1f, 0f);
						LocalPlayer.Entity.ServerRPC<PlayerProjectileAttack>("OnProjectileAttack", attack);
					}
				}
			}
			if (Main.silentaimbotdick.GetData<bool>() && !Main.silentaimbot.GetData<bool>() && !Main.silentaimbotheli.GetData<bool>() && !Main.killafterdead.GetData<bool>() && !Main.killscientist.GetData<bool>())
			{
				foreach (global::BasePlayer basePlayer2 in global::BasePlayer.VisiblePlayerList)
				{
					float num3 = 150f;
					Vector3 vector2 = MainCamera.mainCamera.WorldToScreenPoint(basePlayer2.model.headBone.transform.position);
					float num4 = Mathf.Abs(Vector2.Distance(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), new Vector2(vector2.x, (float)Screen.height - vector2.y)));
					if (basePlayer2 != null && !basePlayer2.IsLocalPlayer() && !basePlayer2.IsNpc && num4 <= Aimbot.aimbotFov && num4 < num3 && !basePlayer2.IsDead() && !FriendManager.friendsList.Contains(basePlayer2.userID))
					{
						attack.hitDistance = -1337f;
						attack.playerAttack.attack.hitID = basePlayer2.net.ID;
						attack.playerAttack.attack.hitBone = 612182976u;
						attack.playerAttack.attack.hitPartID = 2173623152u;
						attack.playerAttack.attack.hitPositionLocal = new Vector3(-0.1f, -0.1f, 0f);
						attack.playerAttack.attack.hitNormalLocal = new Vector3(0f, -1f, 0f);
						LocalPlayer.Entity.ServerRPC<PlayerProjectileAttack>("OnProjectileAttack", attack);
					}
				}
			}
			if (Main.killscientist.GetData<bool>() && !Main.silentaimbotdick.GetData<bool>() && !Main.silentaimbotheli.GetData<bool>() && !Main.killafterdead.GetData<bool>() && !Main.silentaimbot.GetData<bool>())
			{
				foreach (global::BasePlayer basePlayer3 in global::BasePlayer.VisiblePlayerList)
				{
					float num5 = 150f;
					Vector3 vector3 = MainCamera.mainCamera.WorldToScreenPoint(basePlayer3.model.headBone.transform.position);
					float num6 = Mathf.Abs(Vector2.Distance(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), new Vector2(vector3.x, (float)Screen.height - vector3.y)));
					if (basePlayer3 != null && !basePlayer3.IsLocalPlayer() && basePlayer3.IsNpc && num6 <= Aimbot.aimbotFov && num6 < num5 && !basePlayer3.IsDead())
					{
						attack.hitDistance = -1337f;
						attack.playerAttack.attack.hitID = basePlayer3.net.ID;
						attack.playerAttack.attack.hitBone = 698017942u;
						attack.playerAttack.attack.hitPartID = 2173623152u;
						attack.playerAttack.attack.hitPositionLocal = new Vector3(-0.1f, -0.1f, 0f);
						attack.playerAttack.attack.hitNormalLocal = new Vector3(0f, -1f, 0f);
						LocalPlayer.Entity.ServerRPC<PlayerProjectileAttack>("OnProjectileAttack", attack);
					}
				}
			}
			if (Main.killafterdead.GetData<bool>() && !Main.silentaimbotdick.GetData<bool>() && !Main.silentaimbot.GetData<bool>() && !Main.silentaimbotheli.GetData<bool>() && !Main.killscientist.GetData<bool>())
			{
				foreach (global::BasePlayer basePlayer4 in global::BasePlayer.VisiblePlayerList)
				{
					float num7 = 150f;
					Vector3 vector4 = MainCamera.mainCamera.WorldToScreenPoint(basePlayer4.model.headBone.transform.position);
					float num8 = Mathf.Abs(Vector2.Distance(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), new Vector2(vector4.x, (float)Screen.height - vector4.y)));
					if (basePlayer4 != null && !basePlayer4.IsLocalPlayer() && !basePlayer4.IsNpc && num8 <= Aimbot.aimbotFov && num8 < num7 && !FriendManager.friendsList.Contains(basePlayer4.userID))
					{
						attack.hitDistance = -1337f;
						attack.playerAttack.attack.hitID = basePlayer4.net.ID;
						attack.playerAttack.attack.hitBone = 698017942u;
						attack.playerAttack.attack.hitPartID = 2173623152u;
						attack.playerAttack.attack.hitPositionLocal = new Vector3(-0.1f, -0.1f, 0f);
						attack.playerAttack.attack.hitNormalLocal = new Vector3(0f, -1f, 0f);
						LocalPlayer.Entity.ServerRPC<PlayerProjectileAttack>("OnProjectileAttack", attack);
					}
				}
			}
			if (!Main.silentaimbot.GetData<bool>() && !Main.silentaimbotdick.GetData<bool>() && !Main.silentaimbotheli.GetData<bool>() && !Main.killafterdead.GetData<bool>() && !Main.killscientist.GetData<bool>())
			{
				LocalPlayer.Entity.ServerRPC<PlayerProjectileAttack>("OnProjectileAttack", attack);
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x000147F4 File Offset: 0x000129F4
		public float GetIndexedSpreadScalar(int shotIndex, int maxShots)
		{
			if (shotIndex == 0)
			{
				Misc.smethod_6(0f, 0f);
			}
			return 0f;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00013DE0 File Offset: 0x00011FE0
		public float GetIndexedSpreadScalarTrampoline(int shotIndex, int maxShots)
		{
			return 0f;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000432A File Offset: 0x0000252A
		public void SendProjectileAttackTrampoline(PlayerProjectileAttack attack)
		{
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00014820 File Offset: 0x00012A20
		private Projectile CreateProjectileTrampoline(string prefabPath, Vector3 pos, Vector3 foward, Vector3 velocity)
		{
			return Misc.smethod_7();
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00014834 File Offset: 0x00012A34
		private Projectile CreateProjectile(string prefabPath, Vector3 pos, Vector3 forward, Vector3 velocity)
		{
			GameObject gameObject = Misc.smethod_8(GameManager.client, prefabPath, pos, Quaternion.LookRotation(forward), true);
			Projectile result;
			if (!Misc.smethod_9(gameObject, null))
			{
				Misc.smethod_10();
				Projectile component = gameObject.GetComponent<Projectile>();
				component.ricochetChance = 999f;
				if (Main.noclip.GetData<bool>())
				{
					component.thickness = 100f;
				}
				Projectile.Modifier @default = Projectile.Modifier.Default;
				Misc.smethod_11(component, velocity);
				component.modifier = @default;
				result = component;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x000049CC File Offset: 0x00002BCC
		public bool HasLocalControls()
		{
			return Misc.smethod_12(Misc.localplayer);
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000049CC File Offset: 0x00002BCC
		public bool HasLocalControlsTrampoline()
		{
			return Misc.smethod_12(Misc.localplayer);
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000329 RID: 809 RVA: 0x000148AC File Offset: 0x00012AAC
		// (set) Token: 0x0600032A RID: 810 RVA: 0x000148C8 File Offset: 0x00012AC8
		public static float Single_0
		{
			get
			{
				return Misc.color_0.a;
			}
			set
			{
				float num = Mathf.Clamp01(value);
				Misc.color_0 = new Color(num, num, num, num);
			}
		}

		// Token: 0x0600032B RID: 811 RVA: 0x000049D8 File Offset: 0x00002BD8
		public void UpdateAmbient()
		{
			Misc.smethod_13(AmbientMode.Trilight);
			Misc.smethod_14(Misc.color_0);
			Misc.smethod_15(1f);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000432A File Offset: 0x0000252A
		public void UpdateAmbientTrampoline()
		{
		}

		// Token: 0x0600032D RID: 813 RVA: 0x000148EC File Offset: 0x00012AEC
		private void Start()
		{
			Misc.smethod_16(this, this.MiscFuncs());
			Misc.smethod_16(this, this.Removals());
			byte[] array = new byte[12];
			Misc.smethod_17(array, fieldof(<PrivateImplementationDetails>.struct4_0).FieldHandle);
			byte[] orig = array;
			this.jump = new DumbHook(Misc.smethod_18(typeof(PlayerWalkMovement).TypeHandle), "CanJump", Misc.smethod_18(typeof(Misc).TypeHandle), "CanJump", Misc.smethod_18(typeof(Misc).TypeHandle), "CanJumpTrampoline", orig);
			byte[] array2 = new byte[12];
			Misc.smethod_17(array2, fieldof(<PrivateImplementationDetails>.struct4_0).FieldHandle);
			byte[] orig2 = array2;
			this.canAttack = new DumbHook(Misc.smethod_18(typeof(global::BasePlayer).TypeHandle), "CanAttack", Misc.smethod_18(typeof(Misc).TypeHandle), "CanAttack", Misc.smethod_18(typeof(Misc).TypeHandle), "CanAttackTrampoline", orig2);
			byte[] array3 = new byte[12];
			Misc.smethod_17(array3, fieldof(<PrivateImplementationDetails>.struct4_0).FieldHandle);
			byte[] orig3 = array3;
			this.instantloot = new DumbHook(Misc.smethod_18(typeof(ItemIcon).TypeHandle), "SetTimedAction", Misc.smethod_18(typeof(Misc).TypeHandle), "SetTimedAction", Misc.smethod_18(typeof(Misc).TypeHandle), "SetTimedActionTrampoline", orig3);
			byte[] array4 = new byte[16];
			Misc.smethod_17(array4, fieldof(<PrivateImplementationDetails>.struct5_0).FieldHandle);
			byte[] orig4 = array4;
			this.hahyea = new DumbHook(Misc.smethod_18(typeof(CompoundBowWeapon).TypeHandle), "UpdateMovementPenalty", Misc.smethod_18(typeof(Misc).TypeHandle), "UpdateMovementPenalty", Misc.smethod_18(typeof(Misc).TypeHandle), "UpdateMovementPenaltyTrampoline", orig4);
			byte[] array5 = new byte[12];
			Misc.smethod_17(array5, fieldof(<PrivateImplementationDetails>.struct4_0).FieldHandle);
			byte[] orig5 = array5;
			this.nofall = new DumbHook(Misc.smethod_18(typeof(global::BasePlayer).TypeHandle), "OnLand", Misc.smethod_18(typeof(Misc).TypeHandle), "OnLand", Misc.smethod_18(typeof(Misc).TypeHandle), "OnLandTrampoline", orig5);
			byte[] array6 = new byte[12];
			Misc.smethod_17(array6, fieldof(<PrivateImplementationDetails>.struct4_0).FieldHandle);
			byte[] orig6 = array6;
			this.aimcone = new DumbHook(Misc.smethod_18(typeof(global::BaseProjectile).TypeHandle), "GetAimCone", Misc.smethod_18(typeof(Misc).TypeHandle), "GetAimCone", Misc.smethod_18(typeof(Misc).TypeHandle), "GetAimConeTrampoline", orig6);
			byte[] array7 = new byte[12];
			Misc.smethod_17(array7, fieldof(<PrivateImplementationDetails>.struct4_0).FieldHandle);
			byte[] orig7 = array7;
			this.testing = new DumbHook(Misc.smethod_18(typeof(global::HeldEntity).TypeHandle), "AddPunch", Misc.smethod_18(typeof(Misc).TypeHandle), "AddPunch", Misc.smethod_18(typeof(Misc).TypeHandle), "AddPunchTrampoline", orig7);
			this.testing.Hook();
			byte[] array8 = new byte[12];
			Misc.smethod_17(array8, fieldof(<PrivateImplementationDetails>.struct4_0).FieldHandle);
			byte[] orig8 = array8;
			this.nasdas = new DumbHook(Misc.smethod_18(typeof(global::BasePlayer).TypeHandle), "GetSpeed", Misc.smethod_18(typeof(Misc).TypeHandle), "GetSpeed", Misc.smethod_18(typeof(Misc).TypeHandle), "GetSpeedTrampoline", orig8);
			byte[] array9 = new byte[12];
			Misc.smethod_17(array9, fieldof(<PrivateImplementationDetails>.struct4_0).FieldHandle);
			byte[] orig9 = array9;
			this.projshit = new DumbHook(Misc.smethod_18(typeof(global::BaseProjectile).TypeHandle), "CreateProjectile", Misc.smethod_18(typeof(Misc).TypeHandle), "CreateProjectile", Misc.smethod_18(typeof(Misc).TypeHandle), "CreateProjectileTrampoline", orig9);
			this.projshit.Hook();
			byte[] array10 = new byte[12];
			Misc.smethod_17(array10, fieldof(<PrivateImplementationDetails>.struct4_0).FieldHandle);
			byte[] orig10 = array10;
			this.proj = new DumbHook(Misc.smethod_18(typeof(global::BasePlayer).TypeHandle), "SendProjectileAttack", Misc.smethod_18(typeof(Misc).TypeHandle), "SendProjectileAttack", Misc.smethod_18(typeof(Misc).TypeHandle), "SendProjectileAttackTrampoline", orig10);
			this.proj.Hook();
			byte[] array11 = new byte[12];
			Misc.smethod_17(array11, fieldof(<PrivateImplementationDetails>.struct4_0).FieldHandle);
			byte[] orig11 = array11;
			this.shotgunspread1 = new DumbHook(Misc.smethod_18(typeof(ItemModProjectile).TypeHandle), "GetIndexedSpreadScalar", Misc.smethod_18(typeof(Misc).TypeHandle), "GetIndexedSpreadScalar", Misc.smethod_18(typeof(Misc).TypeHandle), "GetIndexedSpreadScalarTrampoline", orig11);
			byte[] array12 = new byte[12];
			Misc.smethod_17(array12, fieldof(<PrivateImplementationDetails>.struct4_0).FieldHandle);
			byte[] orig12 = array12;
			this.seeinv = new DumbHook(Misc.smethod_18(typeof(global::BasePlayer).TypeHandle), "HasLocalControls", Misc.smethod_18(typeof(Misc).TypeHandle), "HasLocalControls", Misc.smethod_18(typeof(Misc).TypeHandle), "HasLocalControlsTrampoline", orig12);
			byte[] array13 = new byte[12];
			Misc.smethod_17(array13, fieldof(<PrivateImplementationDetails>.struct4_0).FieldHandle);
			byte[] orig13 = array13;
			this.resetter = new DumbHook(Misc.smethod_18(typeof(TOD_Sky).TypeHandle), "UpdateAmbient", Misc.smethod_18(typeof(Misc).TypeHandle), "UpdateAmbient", Misc.smethod_18(typeof(Misc).TypeHandle), "UpdateAmbientTrampoline", orig13);
			if (Misc.smethod_9(Misc.mTex, null))
			{
				Misc.mTex = Misc.smethod_19(1, 1);
				byte[] array14 = new byte[2147];
				Misc.smethod_17(array14, fieldof(<PrivateImplementationDetails>.A1DEA31C2227707B8E4B1D372782FD88E052FFFF).FieldHandle);
				byte[] byte_ = array14;
				Misc.smethod_20(Misc.mTex, byte_);
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x000049F4 File Offset: 0x00002BF4
		public bool StartAttackCooldown()
		{
			return true;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00014D60 File Offset: 0x00012F60
		private void removeblack()
		{
			IEnumerator<global::BasePlayer> enumerator = Misc.smethod_3().GetEnumerator();
			try
			{
				while (Misc.smethod_23(enumerator))
				{
					global::BasePlayer basePlayer = enumerator.Current;
					foreach (global::Item item in basePlayer.inventory.containerWear.itemList)
					{
						if (item != null)
						{
							bool flag = false;
							bool flag2 = false;
							ItemModWearable component = item.info.GetComponent<ItemModWearable>();
							if (Main.aimarmour.GetData<bool>())
							{
								component.blocksAiming = false;
							}
							if (Main.removeblack.GetData<bool>())
							{
								if (component.occlusionType == UIBlackoutOverlay.blackoutType.HELMETSLIT && component.occlusionType == UIBlackoutOverlay.blackoutType.SNORKELGOGGLE)
								{
									flag = false;
								}
								UIBlackoutOverlay uiblackoutOverlay = Misc.smethod_21(UIBlackoutOverlay.blackoutType.HELMETSLIT);
								if (Misc.smethod_12(uiblackoutOverlay))
								{
									Misc.smethod_22(uiblackoutOverlay, (float)((!flag) ? 0 : 1));
								}
								UIBlackoutOverlay uiblackoutOverlay2 = Misc.smethod_21(UIBlackoutOverlay.blackoutType.SNORKELGOGGLE);
								if (Misc.smethod_12(uiblackoutOverlay2))
								{
									Misc.smethod_22(uiblackoutOverlay2, (float)((!flag2) ? 0 : 1));
									WaterOverlay.goggles = flag2;
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
					Misc.smethod_24(enumerator);
				}
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00014E98 File Offset: 0x00013098
		public static Vector3 ClampAngles(Vector3 angles)
		{
			if (angles.x > 89f)
			{
				angles.x -= 360f;
			}
			else if (angles.x < -89f)
			{
				angles.x += 360f;
			}
			if (angles.y > 180f)
			{
				angles.y -= 360f;
			}
			else if (angles.y < -180f)
			{
				angles.y += 360f;
			}
			angles.z = 0f;
			return angles;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x000049F7 File Offset: 0x00002BF7
		private IEnumerator MiscFuncs()
		{
			bool multiJump_Hooked = false;
			bool hookedshit = false;
			bool darkness = false;
			bool noaimcone = false;
			bool speed = false;
			bool localcontrol = false;
			bool ermfall = false;
			bool shotgunspread = false;
			global::BasePlayer.PlayerFlags fuckinshit = (global::BasePlayer.PlayerFlags)0;
			bool instantloot = false;
			float oldshit = 0f;
			float oldswimshit = 0f;
			int num;
			do
			{
				try
				{
					bool attackAnywhere_Hooked = false;
					if (Misc.<MiscFuncs>d__52.smethod_0(Misc.localplayer, null))
					{
						if (Main.jump.GetData<bool>())
						{
							if (!multiJump_Hooked)
							{
								this.jump.Hook();
								multiJump_Hooked = true;
							}
						}
						else if (multiJump_Hooked)
						{
							this.jump.Unhook();
							multiJump_Hooked = false;
						}
						if (!Main.NoFallDamage.GetData<bool>())
						{
							if (ermfall)
							{
								this.nofall.Unhook();
								ermfall = false;
							}
						}
						else if (!ermfall)
						{
							this.nofall.Hook();
							ermfall = true;
						}
						if (!Main.cavedarkenss.GetData<bool>())
						{
							if (darkness)
							{
								this.resetter.Unhook();
								darkness = false;
							}
						}
						else if (!darkness)
						{
							this.resetter.Hook();
							darkness = true;
						}
						if (!Main.speedhek.GetData<bool>())
						{
							if (speed)
							{
								this.nasdas.Unhook();
								speed = false;
							}
						}
						else if (!speed)
						{
							this.nasdas.Hook();
							speed = true;
						}
						if (!Main.shotgunnospread.GetData<bool>())
						{
							if (shotgunspread)
							{
								this.shotgunspread1.Unhook();
								shotgunspread = false;
							}
						}
						else if (!shotgunspread)
						{
							this.shotgunspread1.Hook();
							shotgunspread = true;
						}
						if (!Main.localcontrol.GetData<bool>())
						{
							if (localcontrol)
							{
								this.seeinv.Unhook();
								localcontrol = false;
							}
						}
						else if (!localcontrol)
						{
							this.seeinv.Hook();
							localcontrol = true;
						}
						if (Main.nospreadhvhxd.GetData<bool>())
						{
							if (!noaimcone)
							{
								this.aimcone.Hook();
								noaimcone = true;
							}
						}
						else if (noaimcone)
						{
							this.aimcone.Unhook();
							noaimcone = false;
						}
						if (Main.instantloot.GetData<bool>())
						{
							if (!instantloot)
							{
								this.instantloot.Hook();
								instantloot = true;
							}
						}
						else if (instantloot)
						{
							this.instantloot.Unhook();
							instantloot = false;
						}
						if (Main.laddermovement.GetData<bool>() && Misc.localplayer.modelState != null)
						{
							Misc.<MiscFuncs>d__52.smethod_1(Misc.localplayer.modelState, true);
						}
						if (Main.swim.GetData<bool>() && Misc.localplayer.modelState != null)
						{
							Misc.localplayer.modelState.waterLevel = 99999f;
						}
						if (!Main.admin1.GetData<bool>())
						{
							if (Misc.localplayer.playerFlags == (global::BasePlayer.PlayerFlags)0 && fuckinshit > (global::BasePlayer.PlayerFlags)0)
							{
								Misc.localplayer.playerFlags = fuckinshit;
							}
						}
						else if (Misc.localplayer.playerFlags != global::BasePlayer.PlayerFlags.ThirdPersonViewmode)
						{
							fuckinshit = Misc.localplayer.playerFlags;
							Misc.localplayer.playerFlags = global::BasePlayer.PlayerFlags.ThirdPersonViewmode;
						}
						if (!Main.gravity.GetData<bool>())
						{
							if (oldshit != 0f)
							{
								Misc.localplayer.movement.GetComponent<PlayerWalkMovement>().gravityMultiplier = oldshit;
							}
						}
						else
						{
							if (oldshit == 0f)
							{
								oldshit = Misc.localplayer.movement.GetComponent<PlayerWalkMovement>().gravityMultiplier;
							}
							Misc.localplayer.movement.GetComponent<PlayerWalkMovement>().gravityMultiplier = oldshit / 2f;
						}
						if (Main.nosink.GetData<bool>())
						{
							if (oldswimshit == 0f)
							{
								oldswimshit = Misc.localplayer.movement.GetComponent<PlayerWalkMovement>().gravityMultiplierSwimming;
							}
							Misc.localplayer.movement.GetComponent<PlayerWalkMovement>().gravityMultiplierSwimming = oldswimshit / 1f;
						}
						else if (oldswimshit != 0f)
						{
							Misc.localplayer.movement.GetComponent<PlayerWalkMovement>().gravityMultiplierSwimming = oldswimshit;
						}
						if (!Main.noloss.GetData<bool>())
						{
							if (hookedshit)
							{
								this.hahyea.Unhook();
								hookedshit = false;
							}
						}
						else if (!hookedshit)
						{
							this.hahyea.Hook();
							hookedshit = true;
						}
						if (!Main.shoot.GetData<bool>())
						{
							if (attackAnywhere_Hooked)
							{
								this.canAttack.Unhook();
								attackAnywhere_Hooked = false;
							}
						}
						else if (!attackAnywhere_Hooked)
						{
							this.canAttack.Hook();
							attackAnywhere_Hooked = true;
						}
					}
				}
				catch (Exception)
				{
				}
				yield return Misc.<MiscFuncs>d__52.smethod_2(0.01f);
			}
			while (num == 1);
			yield break;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00014F34 File Offset: 0x00013134
		public float GetSpeed(float running, float ducking)
		{
			return 50f;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00013DE0 File Offset: 0x00011FE0
		public float GetSpeedTrampoline(float running, float ducking)
		{
			return 0f;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000432A File Offset: 0x0000252A
		public void UpdateMovementPenaltyTrampoline(float delta)
		{
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00014F48 File Offset: 0x00013148
		public void UpdateMovementPenalty(float delta)
		{
			foreach (CompoundBowWeapon compoundBowWeapon in Entities.whatever)
			{
				foreach (BowWeapon baseNetworkable_ in Entities.bow)
				{
					global::HeldEntity heldEntity_ = Misc.smethod_25(Misc.smethod_0());
					global::BasePlayer basePlayer = Misc.smethod_26(heldEntity_);
					if (Misc.smethod_27(baseNetworkable_))
					{
						if (Misc.smethod_9(basePlayer, null) || Misc.smethod_9(basePlayer.movement, null))
						{
							return;
						}
						bool flag = Misc.smethod_28(basePlayer.movement) > 20f;
					}
				}
			}
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00004A06 File Offset: 0x00002C06
		public bool CanAttackTrampoline()
		{
			return false;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x000049F4 File Offset: 0x00002BF4
		public bool CanAttack()
		{
			return true;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00015024 File Offset: 0x00013224
		public static void LogToConsole(string message)
		{
			Misc.smethod_18(typeof(ConsoleUI).TypeHandle).method_0("Log", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, SingletonComponent<ConsoleUI>.Instance, new object[]
			{
				message
			});
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0001505C File Offset: 0x0001325C
		public static global::BasePlayer GetTarget()
		{
			global::BasePlayer result = null;
			Vector2 vector = new Vector2((float)Misc.smethod_29() / 2f, (float)Misc.smethod_30() / 2f);
			float num = 1000f;
			foreach (global::BasePlayer basePlayer in Misc.smethod_3())
			{
				if (!Misc.smethod_9(basePlayer, null) && !Misc.smethod_31(basePlayer) && !Misc.smethod_32(basePlayer) && Misc.smethod_5(basePlayer) > 0f && !Misc.smethod_33(basePlayer) && !Misc.smethod_34(basePlayer))
				{
					Vector3 vector2 = Misc.smethod_37(MainCamera.mainCamera, Misc.smethod_36(Misc.smethod_35(basePlayer)));
					new Vector2(vector2.x, (float)Misc.smethod_30() - vector2.y);
					float num2 = Mathf.Abs(Vector2.Distance(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), new Vector2(vector2.x, (float)Screen.height - vector2.y)));
					if (num2 <= Misc.aimbotFov && num2 < num && basePlayer.IsAlive())
					{
						num = num2;
						result = basePlayer;
					}
				}
			}
			return result;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x000151B0 File Offset: 0x000133B0
		public static Vector3 GetScreenPos(Vector3 position)
		{
			return Misc.smethod_37(MainCamera.mainCamera, position);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x000151CC File Offset: 0x000133CC
		public static void FastGathering()
		{
			foreach (AttackEntity attackEntity in UpdateObjects.attackEntityArray)
			{
				if (Misc.smethod_2(attackEntity, null))
				{
					if (!Misc.originalRepeatDelay.ContainsKey(Misc.smethod_38(attackEntity)))
					{
						Misc.originalRepeatDelay.Add(Misc.smethod_38(attackEntity), attackEntity.repeatDelay);
					}
					if (Main.FastGathering.GetData<bool>())
					{
						attackEntity.repeatDelay = Misc.originalRepeatDelay[Misc.smethod_38(attackEntity)] / 2.5f;
					}
					else
					{
						attackEntity.repeatDelay = Misc.originalRepeatDelay[Misc.smethod_38(attackEntity)];
					}
				}
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00015268 File Offset: 0x00013468
		public static void DrawCircle(Vector2 Point, float radius, Color color)
		{
			double num = 3.1415926535;
			for (double num2 = 0.0; num2 < 360.0; num2 += 1.0)
			{
				double num3 = num2;
				double num4 = (double)radius * Misc.smethod_39(num3 * num / 180.0);
				double num5 = (double)radius * Misc.smethod_40(num3 * num / 180.0);
				Rendering.DrawLine100(new Vector2(Point.x + Misc.smethod_41(num4), Point.y + Misc.smethod_41(num5)), new Vector2(Point.x + 1f + Convert.ToSingle(num4), Point.y + 1f + Convert.ToSingle(num5)), color, 2f);
			}
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00015334 File Offset: 0x00013534
		private void OnGUI()
		{
			Misc.bow();
			if (Main.fovforaimbot.GetData<bool>())
			{
				Misc.DrawCircle(new Vector2((float)Misc.smethod_29() / 2f, (float)Misc.smethod_30() / 2f), Aimbot.aimbotFov, Color.red);
			}
			if (Misc.localplayer == null)
			{
				foreach (global::BasePlayer basePlayer in global::BasePlayer.VisiblePlayerList)
				{
					if (basePlayer.IsLocalPlayer())
					{
						Misc.localplayer = basePlayer;
					}
				}
			}
			try
			{
				float hour = TOD_Sky.Instance.Cycle.Hour;
				if ((hour <= 10f || hour >= 19f) && Main.shouldAlwaysBeDaytime.GetData<bool>())
				{
					TOD_Sky.Instance.Cycle.Hour = 14f;
				}
				if (Main.shouldAlwaysBeDaytime.GetData<bool>())
				{
					TOD_Sky.Instance.Cycle.Hour = 14f;
				}
			}
			catch (NullReferenceException)
			{
			}
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00015448 File Offset: 0x00013648
		public static void bow()
		{
			foreach (BowWeapon bowWeapon in Entities.bow)
			{
				if (Misc.smethod_2(bowWeapon, null) && Main.bowhack.GetData<bool>())
				{
					bowWeapon.aiming = true;
					bowWeapon.aimCone = 0f;
					Misc.smethod_42(Misc.nig, bowWeapon, true);
				}
			}
		}

		// Token: 0x0600033F RID: 831 RVA: 0x000154CC File Offset: 0x000136CC
		public static void DebugCamera()
		{
			if (!Misc.smethod_9(Misc.smethod_0(), null))
			{
				if (Misc.smethod_9(SingletonComponent<CameraMan>.Instance, null))
				{
					Misc.smethod_8(GameManager.client, "assets/bundled/prefabs/system/debug/debug_camera.prefab", default(Vector3), default(Quaternion), true);
				}
				else
				{
					Misc.smethod_44(SingletonComponent<CameraMan>.Instance, !Misc.smethod_43(SingletonComponent<CameraMan>.Instance));
				}
				Misc.smethod_45(Misc.smethod_0());
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0001553C File Offset: 0x0001373C
		public static void meleehek()
		{
			foreach (BaseMelee baseMelee in Entities.tool)
			{
				if (Misc.smethod_2(baseMelee, null) && Misc.smethod_2(baseMelee.worldModelAnimator, null))
				{
					baseMelee.effectiveRange = 3f;
					baseMelee.attackRadius = 3f;
					baseMelee.maxDistance = 3f;
					baseMelee.attackRadius = 3f;
					baseMelee.attackLengthMin = 3f;
					baseMelee.attackLengthMax = 3f;
					baseMelee.deployDelay = 0f;
				}
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x000049F4 File Offset: 0x00002BF4
		private bool CanJump()
		{
			return true;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x000049F4 File Offset: 0x00002BF4
		private bool CanJumpTrampoline()
		{
			return true;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x000155F0 File Offset: 0x000137F0
		private void Update()
		{
			if (Misc.smethod_46(KeyCode.LeftShift) && Misc.smethod_47(KeyCode.B))
			{
				FriendManager.AddFriend();
			}
			if (Main.jackhammerhack.GetData<bool>())
			{
				this.jackhammershit();
			}
			if (Main.removeblack.GetData<bool>())
			{
				this.removeblack();
			}
			if (Main.bows.GetData<bool>())
			{
				Misc.big();
			}
			if (Main.meleerange.GetData<bool>())
			{
				Misc.meleehek();
			}
			if (Misc.smethod_46(KeyCode.LeftShift) && Misc.smethod_47(KeyCode.C))
			{
				Misc.DebugCamera();
			}
			if (Main.admin.GetData<bool>())
			{
				Misc.striked();
			}
			if (float.IsNaN(Misc.originalTimeScale))
			{
				Misc.originalTimeScale = Misc.smethod_48();
			}
			if (Main.ClimbHack.GetData<bool>())
			{
				try
				{
					FieldInfo fieldInfo_ = Misc.smethod_49(Misc.smethod_18(typeof(PlayerWalkMovement).TypeHandle), "groundAngleNew", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField);
					Misc.smethod_42(fieldInfo_, Misc.localplayer.movement, 0f);
				}
				catch (NullReferenceException)
				{
				}
			}
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00004A09 File Offset: 0x00002C09
		private IEnumerator Removals()
		{
			Dictionary<int, Misc.RemovalInfo> removalDict = new Dictionary<int, Misc.RemovalInfo>();
			int num;
			do
			{
				if (Misc.<Removals>d__75.smethod_0(Misc.localplayer, null) && Misc.<Removals>d__75.smethod_2(Misc.<Removals>d__75.smethod_1(Misc.localplayer)))
				{
					global::BaseProjectile bp = Misc.<Removals>d__75.smethod_1(Misc.localplayer).GetComponent<global::BaseProjectile>();
					FlintStrikeWeapon bp2 = Misc.<Removals>d__75.smethod_1(Misc.localplayer).GetComponent<FlintStrikeWeapon>();
					global::Item activeItem = Misc.<Removals>d__75.smethod_4(Misc.<Removals>d__75.smethod_3().Belt);
					if (Misc.<Removals>d__75.smethod_0(bp, null) && !Misc.<Removals>d__75.smethod_2(bp2))
					{
						int itemID = Misc.<Removals>d__75.smethod_5(Misc.<Removals>d__75.smethod_1(Misc.localplayer)).itemid;
						if (Misc.<Removals>d__75.smethod_6(KeyCode.L))
						{
							Misc.<Removals>d__75.smethod_7(bp.worldModelAnimator, "reload");
						}
						if (!Main.shouldNoRecoil.GetData<bool>())
						{
							if (bp.recoil.recoilPitchMax == 0f)
							{
								bp.recoil.recoilPitchMax = removalDict[itemID].recoilPitchMax;
								bp.recoil.recoilPitchMin = removalDict[itemID].recoilPitchMin;
								bp.recoil.recoilYawMax = removalDict[itemID].recoilYawMax;
								bp.recoil.recoilYawMin = removalDict[itemID].recoilYawMin;
								bp.recoil.movementPenalty = removalDict[itemID].movementPenalty;
							}
						}
						else if (bp.recoil.recoilPitchMax != 0f)
						{
							if (removalDict.ContainsKey(itemID))
							{
								if (bp.recoil.recoilPitchMax != 0f)
								{
									Misc.RemovalInfo updateinfo = removalDict[itemID];
									updateinfo.recoilPitchMax = bp.recoil.recoilPitchMax;
									updateinfo.recoilPitchMin = bp.recoil.recoilPitchMin;
									updateinfo.recoilYawMax = bp.recoil.recoilYawMax;
									updateinfo.recoilYawMin = bp.recoil.recoilYawMin;
									updateinfo.movementPenalty = bp.recoil.movementPenalty;
									removalDict[itemID] = updateinfo;
								}
							}
							else
							{
								removalDict.Add(itemID, new Misc.RemovalInfo
								{
									recoilPitchMax = bp.recoil.recoilPitchMax,
									recoilPitchMin = bp.recoil.recoilPitchMin,
									recoilYawMax = bp.recoil.recoilYawMax,
									recoilYawMin = bp.recoil.recoilYawMin,
									movementPenalty = bp.recoil.movementPenalty
								});
							}
							bp.recoil.recoilPitchMax = 0f;
							bp.recoil.recoilPitchMin = 0f;
							bp.recoil.recoilYawMax = 0f;
							bp.recoil.recoilYawMin = 0f;
							bp.recoil.movementPenalty = 0f;
						}
						if (!Main.shouldNoSway.GetData<bool>())
						{
							if (bp.aimSway == 0f)
							{
								bp.aimSway = removalDict[itemID].aimSway;
								bp.aimSwaySpeed = removalDict[itemID].aimSwaySpeed;
							}
						}
						else if (bp.aimSway != 0f)
						{
							if (!removalDict.ContainsKey(itemID))
							{
								removalDict.Add(itemID, new Misc.RemovalInfo
								{
									aimSway = bp.aimSway,
									aimSwaySpeed = bp.aimSwaySpeed
								});
							}
							else if (bp.aimSway != 0f)
							{
								Misc.RemovalInfo updateinfo2 = removalDict[itemID];
								updateinfo2.aimSway = bp.aimSway;
								updateinfo2.aimSwaySpeed = bp.aimSwaySpeed;
								removalDict[itemID] = updateinfo2;
							}
							bp.aimSway = 0f;
							bp.aimSwaySpeed = 0f;
						}
						if (Main.testing.GetData<bool>() && bp.projectileVelocityScale != 0f)
						{
							if (!removalDict.ContainsKey(itemID))
							{
								removalDict.Add(itemID, new Misc.RemovalInfo
								{
									projectileVelocityScale = bp.projectileVelocityScale
								});
							}
							else if (bp.projectileVelocityScale != 0f)
							{
								Misc.RemovalInfo updateinfo3 = removalDict[itemID];
								updateinfo3.projectileVelocityScale = bp.projectileVelocityScale;
								removalDict[itemID] = updateinfo3;
							}
							if (Misc.<Removals>d__75.smethod_8(activeItem.info.shortname, "pistol.nailgun"))
							{
								bp.projectileVelocityScale = 0.4f;
							}
							if (Misc.<Removals>d__75.smethod_8(activeItem.info.shortname, "crossbow"))
							{
								bp.projectileVelocityScale = 0.5f;
							}
							if (Misc.<Removals>d__75.smethod_8(activeItem.info.shortname, "bow"))
							{
								bp.projectileVelocityScale = 0.3f;
							}
							if (Misc.<Removals>d__75.smethod_8(activeItem.info.shortname, "pistol.") && !Misc.<Removals>d__75.smethod_8(activeItem.info.shortname, "pistol.nailgun"))
							{
								bp.projectileVelocityScale = 0.2f;
							}
							if (Misc.<Removals>d__75.smethod_8(activeItem.info.shortname, "lmg."))
							{
								bp.projectileVelocityScale = 0.2f;
							}
							if (Misc.<Removals>d__75.smethod_8(activeItem.info.shortname, "rifle"))
							{
								bp.projectileVelocityScale = 0.15f;
							}
							if (Misc.<Removals>d__75.smethod_8(activeItem.info.shortname, "shotgun"))
							{
								bp.projectileVelocityScale = 0.2f;
							}
							if (Misc.<Removals>d__75.smethod_8(activeItem.info.shortname, "smg."))
							{
								bp.projectileVelocityScale = 0.2f;
							}
						}
						if (Main.fasty.GetData<bool>() && bp.projectileVelocityScale != 0f)
						{
							if (!removalDict.ContainsKey(itemID))
							{
								removalDict.Add(itemID, new Misc.RemovalInfo
								{
									projectileVelocityScale = bp.projectileVelocityScale
								});
							}
							else if (bp.projectileVelocityScale != 0f)
							{
								Misc.RemovalInfo updateinfo4 = removalDict[itemID];
								updateinfo4.projectileVelocityScale = bp.projectileVelocityScale;
								removalDict[itemID] = updateinfo4;
							}
							if (Misc.<Removals>d__75.smethod_8(activeItem.info.shortname, "pistol.nailgun"))
							{
								bp.projectileVelocityScale = 1.2f;
							}
							if (Misc.<Removals>d__75.smethod_8(activeItem.info.shortname, "crossbow"))
							{
								bp.projectileVelocityScale = 1.2f;
							}
							if (Misc.<Removals>d__75.smethod_8(activeItem.info.shortname, "bow"))
							{
								bp.projectileVelocityScale = 1.2f;
							}
							if (Misc.<Removals>d__75.smethod_8(activeItem.info.shortname, "pistol.") && !Misc.<Removals>d__75.smethod_8(activeItem.info.shortname, "pistol.nailgun"))
							{
								bp.projectileVelocityScale = 1.2f;
							}
							if (Misc.<Removals>d__75.smethod_8(activeItem.info.shortname, "lmg."))
							{
								bp.projectileVelocityScale = 1.2f;
							}
							if (Misc.<Removals>d__75.smethod_8(activeItem.info.shortname, "rifle") && !Misc.<Removals>d__75.smethod_8(activeItem.info.shortname, "rifle.l96"))
							{
								bp.projectileVelocityScale = 1.2f;
							}
							if (Misc.<Removals>d__75.smethod_8(activeItem.info.shortname, "rifle.l96"))
							{
								bp.projectileVelocityScale = 4.4f;
							}
							if (Misc.<Removals>d__75.smethod_8(activeItem.info.shortname, "shotgun"))
							{
								bp.projectileVelocityScale = 1.1f;
							}
							if (Misc.<Removals>d__75.smethod_8(activeItem.info.shortname, "smg."))
							{
								bp.projectileVelocityScale = 1.2f;
							}
						}
						if (!Main.ForceAutomatic.GetData<bool>())
						{
							bp.automatic = removalDict[itemID].automatic;
						}
						else
						{
							if (!removalDict.ContainsKey(itemID))
							{
								removalDict.Add(itemID, new Misc.RemovalInfo
								{
									automatic = bp.automatic
								});
							}
							else
							{
								Misc.RemovalInfo updateinfo5 = removalDict[itemID];
								updateinfo5.automatic = bp.automatic;
								removalDict[itemID] = updateinfo5;
							}
							bp.automatic = true;
						}
					}
					bp = null;
					bp2 = null;
					activeItem = null;
				}
				yield return Misc.<Removals>d__75.smethod_9(0.2f);
			}
			while (num == 1);
			yield break;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x000042CF File Offset: 0x000024CF
		static global::BasePlayer smethod_0()
		{
			return LocalPlayer.Entity;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00004A18 File Offset: 0x00002C18
		static global::Item smethod_1(PlayerBelt playerBelt_0)
		{
			return playerBelt_0.GetActiveItem();
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000400D File Offset: 0x0000220D
		static bool smethod_2(UnityEngine.Object object_0, UnityEngine.Object object_1)
		{
			return object_0 != object_1;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000425F File Offset: 0x0000245F
		static BufferList<global::BasePlayer> smethod_3()
		{
			return global::BasePlayer.VisiblePlayerList;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00004A20 File Offset: 0x00002C20
		static Transform smethod_4(global::BaseEntity baseEntity_0, string string_0)
		{
			return baseEntity_0.FindBone(string_0);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00004276 File Offset: 0x00002476
		static float smethod_5(BaseCombatEntity baseCombatEntity_0)
		{
			return baseCombatEntity_0.health;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00004104 File Offset: 0x00002304
		static float smethod_6(float float_0, float float_1)
		{
			return UnityEngine.Random.Range(float_0, float_1);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00004A29 File Offset: 0x00002C29
		static Projectile smethod_7()
		{
			return new Projectile();
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00004962 File Offset: 0x00002B62
		static GameObject smethod_8(GameManager gameManager_0, string string_0, Vector3 vector3_0, Quaternion quaternion_0, bool bool_0)
		{
			return gameManager_0.CreatePrefab(string_0, vector3_0, quaternion_0, bool_0);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00003F62 File Offset: 0x00002162
		static bool smethod_9(UnityEngine.Object object_0, UnityEngine.Object object_1)
		{
			return object_0 == object_1;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00004A30 File Offset: 0x00002C30
		static HitInfo smethod_10()
		{
			return new HitInfo();
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00004A37 File Offset: 0x00002C37
		static void smethod_11(Projectile projectile_0, Vector3 vector3_0)
		{
			projectile_0.InitializeVelocity(vector3_0);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x000040AF File Offset: 0x000022AF
		static bool smethod_12(UnityEngine.Object object_0)
		{
			return object_0;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00004A40 File Offset: 0x00002C40
		static void smethod_13(AmbientMode ambientMode_0)
		{
			RenderSettings.ambientMode = ambientMode_0;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00004A48 File Offset: 0x00002C48
		static void smethod_14(Color color_1)
		{
			RenderSettings.ambientLight = color_1;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00004A50 File Offset: 0x00002C50
		static void smethod_15(float float_0)
		{
			RenderSettings.ambientIntensity = float_0;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00004312 File Offset: 0x00002512
		static Coroutine smethod_16(MonoBehaviour monoBehaviour_0, IEnumerator ienumerator_0)
		{
			return monoBehaviour_0.StartCoroutine(ienumerator_0);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000498B File Offset: 0x00002B8B
		static void smethod_17(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00003E9E File Offset: 0x0000209E
		static Type smethod_18(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000401F File Offset: 0x0000221F
		static Texture2D smethod_19(int int_0, int int_1)
		{
			return new Texture2D(int_0, int_1);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00004A58 File Offset: 0x00002C58
		static bool smethod_20(Texture2D texture2D_0, byte[] byte_0)
		{
			return texture2D_0.LoadImage(byte_0);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00004A61 File Offset: 0x00002C61
		static UIBlackoutOverlay smethod_21(UIBlackoutOverlay.blackoutType blackoutType_0)
		{
			return UIBlackoutOverlay.Get(blackoutType_0);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00004A69 File Offset: 0x00002C69
		static void smethod_22(UIBlackoutOverlay uiblackoutOverlay_0, float float_0)
		{
			uiblackoutOverlay_0.SetAlpha(float_0);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000428F File Offset: 0x0000248F
		static bool smethod_23(IEnumerator ienumerator_0)
		{
			return ienumerator_0.MoveNext();
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00004297 File Offset: 0x00002497
		static void smethod_24(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		// Token: 0x06000360 RID: 864 RVA: 0x000042E5 File Offset: 0x000024E5
		static global::HeldEntity smethod_25(global::BasePlayer basePlayer_0)
		{
			return basePlayer_0.GetHeldEntity();
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00004A72 File Offset: 0x00002C72
		static global::BasePlayer smethod_26(global::HeldEntity heldEntity_0)
		{
			return heldEntity_0.GetOwnerPlayer();
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00004A7A File Offset: 0x00002C7A
		static bool smethod_27(global::BaseNetworkable baseNetworkable_0)
		{
			return baseNetworkable_0.isClient;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00004A82 File Offset: 0x00002C82
		static float smethod_28(BaseMovement baseMovement_0)
		{
			return baseMovement_0.CurrentMoveSpeed();
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00004A8A File Offset: 0x00002C8A
		object method_0(string string_0, BindingFlags bindingFlags_0, Binder binder_0, object object_0, object[] object_1)
		{
			return base.InvokeMember(string_0, bindingFlags_0, binder_0, object_0, object_1);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000421B File Offset: 0x0000241B
		static int smethod_29()
		{
			return Screen.width;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00004222 File Offset: 0x00002422
		static int smethod_30()
		{
			return Screen.height;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00004266 File Offset: 0x00002466
		static bool smethod_31(global::BasePlayer basePlayer_0)
		{
			return basePlayer_0.IsLocalPlayer();
		}

		// Token: 0x06000368 RID: 872 RVA: 0x000042AF File Offset: 0x000024AF
		static bool smethod_32(global::BasePlayer basePlayer_0)
		{
			return basePlayer_0.IsWounded();
		}

		// Token: 0x06000369 RID: 873 RVA: 0x000042C7 File Offset: 0x000024C7
		static bool smethod_33(BaseCombatEntity baseCombatEntity_0)
		{
			return baseCombatEntity_0.IsDead();
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000426E File Offset: 0x0000246E
		static bool smethod_34(global::BasePlayer basePlayer_0)
		{
			return basePlayer_0.IsSleeping();
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000429F File Offset: 0x0000249F
		static Transform smethod_35(Component component_0)
		{
			return component_0.transform;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x000042A7 File Offset: 0x000024A7
		static Vector3 smethod_36(Transform transform_0)
		{
			return transform_0.position;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00004286 File Offset: 0x00002486
		static Vector3 smethod_37(Camera camera_0, Vector3 vector3_0)
		{
			return camera_0.WorldToScreenPoint(vector3_0);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00004407 File Offset: 0x00002607
		static string smethod_38(global::BaseNetworkable baseNetworkable_0)
		{
			return baseNetworkable_0.ShortPrefabName;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00004229 File Offset: 0x00002429
		static double smethod_39(double double_0)
		{
			return Math.Cos(double_0);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00004239 File Offset: 0x00002439
		static double smethod_40(double double_0)
		{
			return Math.Sin(double_0);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00004A99 File Offset: 0x00002C99
		static float smethod_41(double double_0)
		{
			return Convert.ToSingle(double_0);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00003E2C File Offset: 0x0000202C
		static void smethod_42(FieldInfo fieldInfo_0, object object_0, object object_1)
		{
			fieldInfo_0.SetValue(object_0, object_1);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00004AA1 File Offset: 0x00002CA1
		static bool smethod_43(Behaviour behaviour_0)
		{
			return behaviour_0.enabled;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00004AA9 File Offset: 0x00002CA9
		static void smethod_44(Behaviour behaviour_0, bool bool_0)
		{
			behaviour_0.enabled = bool_0;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00004AB2 File Offset: 0x00002CB2
		static void smethod_45(global::BasePlayer basePlayer_0)
		{
			basePlayer_0.OnViewModeChanged();
		}

		// Token: 0x06000376 RID: 886 RVA: 0x000042D6 File Offset: 0x000024D6
		static bool smethod_46(KeyCode keyCode_0)
		{
			return Input.GetKey(keyCode_0);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x000040FC File Offset: 0x000022FC
		static bool smethod_47(KeyCode keyCode_0)
		{
			return Input.GetKeyDown(keyCode_0);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00004ABA File Offset: 0x00002CBA
		static float smethod_48()
		{
			return Time.timeScale;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00003E19 File Offset: 0x00002019
		static FieldInfo smethod_49(Type type_0, string string_0, BindingFlags bindingFlags_0)
		{
			return type_0.GetField(string_0, bindingFlags_0);
		}

		// Token: 0x04000224 RID: 548
		public static Dictionary<string, float> originalRepeatDelay = new Dictionary<string, float>();

		// Token: 0x04000225 RID: 549
		public static float originalTimeScale = float.NaN;

		// Token: 0x04000226 RID: 550
		public static FieldInfo groundAngle = null;

		// Token: 0x04000227 RID: 551
		public static FieldInfo groundAngleNew = null;

		// Token: 0x04000228 RID: 552
		public static float aimbotFov = 175f;

		// Token: 0x04000229 RID: 553
		public static global::BasePlayer localplayer;

		// Token: 0x0400022A RID: 554
		private static Color color_0 = new Color(0.4f, 0.4f, 0.4f, 0.4f);

		// Token: 0x0400022B RID: 555
		private DumbHook canAttack;

		// Token: 0x0400022C RID: 556
		private DumbHook jump;

		// Token: 0x0400022D RID: 557
		private DumbHook instantloot;

		// Token: 0x0400022E RID: 558
		private DumbHook hahyea;

		// Token: 0x0400022F RID: 559
		private DumbHook nofall;

		// Token: 0x04000230 RID: 560
		private DumbHook aimcone;

		// Token: 0x04000231 RID: 561
		private DumbHook testing;

		// Token: 0x04000232 RID: 562
		private DumbHook nasdas;

		// Token: 0x04000233 RID: 563
		private DumbHook projshit;

		// Token: 0x04000234 RID: 564
		private DumbHook proj;

		// Token: 0x04000235 RID: 565
		private DumbHook shotgunspread1;

		// Token: 0x04000236 RID: 566
		private DumbHook ClientInpu;

		// Token: 0x04000237 RID: 567
		private DumbHook seeinv;

		// Token: 0x04000238 RID: 568
		private DumbHook resetter;

		// Token: 0x04000239 RID: 569
		public PlayerModel.MountPoses mountPose;

		// Token: 0x0400023A RID: 570
		public static PlayerWalkMovement walking;

		// Token: 0x0400023B RID: 571
		private static FieldInfo nig = typeof(BowWeapon).GetField("attackReady", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x0400023C RID: 572
		public static PlayerWalkMovement movement;

		// Token: 0x0400023D RID: 573
		public static Texture2D mTex;

		// Token: 0x0200004F RID: 79
		public class BuildingRotation
		{
			// Token: 0x0600037A RID: 890 RVA: 0x0001576C File Offset: 0x0001396C
			public static void RotateLeft()
			{
				if (Misc.BuildingRotation.smethod_0(KeyCode.LeftArrow))
				{
					foreach (Planner planner in Entities.niggers)
					{
						if (Misc.BuildingRotation.smethod_1(planner, null) && Misc.BuildingRotation.smethod_2(planner))
						{
							Misc.BuildingRotation.plannerRotation.y = Misc.BuildingRotation.plannerRotation.y + 1f;
							planner.SetPrivateField("rotationOffset", Misc.BuildingRotation.plannerRotation);
						}
					}
				}
			}

			// Token: 0x0600037B RID: 891 RVA: 0x00015808 File Offset: 0x00013A08
			public static void RotateRight()
			{
				if (Misc.BuildingRotation.smethod_0(KeyCode.RightArrow))
				{
					foreach (Planner planner in Entities.niggers)
					{
						if (Misc.BuildingRotation.smethod_1(planner, null) && Misc.BuildingRotation.smethod_2(planner))
						{
							Misc.BuildingRotation.plannerRotation.y = Misc.BuildingRotation.plannerRotation.y - 1f;
							planner.SetPrivateField("rotationOffset", Misc.BuildingRotation.plannerRotation);
						}
					}
				}
			}

			// Token: 0x0600037C RID: 892 RVA: 0x000158A4 File Offset: 0x00013AA4
			public static void RotateUp()
			{
				if (Misc.BuildingRotation.smethod_0(KeyCode.UpArrow))
				{
					foreach (Planner planner in Entities.niggers)
					{
						if (Misc.BuildingRotation.smethod_1(planner, null) && Misc.BuildingRotation.smethod_2(planner))
						{
							Misc.BuildingRotation.plannerRotation.z = Misc.BuildingRotation.plannerRotation.z + 1f;
							planner.SetPrivateField("rotationOffset", Misc.BuildingRotation.plannerRotation);
						}
					}
				}
			}

			// Token: 0x0600037D RID: 893 RVA: 0x00015940 File Offset: 0x00013B40
			public static void RotateDown()
			{
				if (Misc.BuildingRotation.smethod_0(KeyCode.DownArrow))
				{
					foreach (Planner planner in Entities.niggers)
					{
						if (Misc.BuildingRotation.smethod_1(planner, null) && Misc.BuildingRotation.smethod_2(planner))
						{
							Misc.BuildingRotation.plannerRotation.z = Misc.BuildingRotation.plannerRotation.z - 1f;
							planner.SetPrivateField("rotationOffset", Misc.BuildingRotation.plannerRotation);
						}
					}
				}
			}

			// Token: 0x06000380 RID: 896 RVA: 0x000042D6 File Offset: 0x000024D6
			static bool smethod_0(KeyCode keyCode_0)
			{
				return Input.GetKey(keyCode_0);
			}

			// Token: 0x06000381 RID: 897 RVA: 0x0000400D File Offset: 0x0000220D
			static bool smethod_1(UnityEngine.Object object_0, UnityEngine.Object object_1)
			{
				return object_0 != object_1;
			}

			// Token: 0x06000382 RID: 898 RVA: 0x00004794 File Offset: 0x00002994
			static bool smethod_2(global::BaseEntity baseEntity_0)
			{
				return baseEntity_0.IsValid();
			}

			// Token: 0x0400023E RID: 574
			public static Vector3 plannerRotation = Vector3.zero;
		}

		// Token: 0x02000050 RID: 80
		public struct RemovalInfo
		{
			// Token: 0x0400023F RID: 575
			public float recoilPitchMax;

			// Token: 0x04000240 RID: 576
			public float recoilPitchMin;

			// Token: 0x04000241 RID: 577
			public float recoilYawMax;

			// Token: 0x04000242 RID: 578
			public float recoilYawMin;

			// Token: 0x04000243 RID: 579
			public float movementPenalty;

			// Token: 0x04000244 RID: 580
			public float aimSway;

			// Token: 0x04000245 RID: 581
			public float aimSwaySpeed;

			// Token: 0x04000246 RID: 582
			public float projectileVelocityScale;

			// Token: 0x04000247 RID: 583
			public bool automatic;
		}
	}
}
