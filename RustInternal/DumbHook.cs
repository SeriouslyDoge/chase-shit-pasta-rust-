using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Facepunch.Steamworks;
using ProtoBuf;
using UnityEngine;

// Token: 0x0200000C RID: 12
internal class DumbHook
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x0600003B RID: 59 RVA: 0x00003E4A File Offset: 0x0000204A
	// (set) Token: 0x0600003C RID: 60 RVA: 0x00003E52 File Offset: 0x00002052
	public MethodInfo OriginalMethod { get; private set; }

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x0600003D RID: 61 RVA: 0x00003E5B File Offset: 0x0000205B
	// (set) Token: 0x0600003E RID: 62 RVA: 0x00003E63 File Offset: 0x00002063
	public MethodInfo HookMethod { get; private set; }

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x0600003F RID: 63 RVA: 0x00003E6C File Offset: 0x0000206C
	// (set) Token: 0x06000040 RID: 64 RVA: 0x00003E74 File Offset: 0x00002074
	public MethodInfo OriginalNew { get; private set; }

	// Token: 0x06000041 RID: 65 RVA: 0x00005BC8 File Offset: 0x00003DC8
	public DumbHook()
	{
		this.original = null;
		this.OriginalMethod = (this.HookMethod = null);
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00003E7D File Offset: 0x0000207D
	public DumbHook(MethodInfo orig, MethodInfo hook, MethodInfo orignew)
	{
		this.original = null;
		this.Init(orig, hook, orignew);
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00005BF4 File Offset: 0x00003DF4
	public DumbHook(Type typeOrig, string nameOrig, Type typeHook, string nameHook, Type typeOrigNew, string nameOrigNew, byte[] orig)
	{
		this.original = new byte[orig.Length];
		this.original = orig;
		if (DumbHook.smethod_0(nameOrig, "DoHit"))
		{
			this.Init(DumbHook.smethod_2(typeOrig, nameOrig, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
			{
				DumbHook.smethod_1(typeof(HitTest).TypeHandle),
				DumbHook.smethod_1(typeof(Vector3).TypeHandle),
				DumbHook.smethod_1(typeof(Vector3).TypeHandle)
			}, null), DumbHook.smethod_2(typeHook, nameHook, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
			{
				DumbHook.smethod_1(typeof(HitTest).TypeHandle),
				DumbHook.smethod_1(typeof(Vector3).TypeHandle),
				DumbHook.smethod_1(typeof(Vector3).TypeHandle)
			}, null), DumbHook.smethod_2(typeOrigNew, nameOrigNew, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
			{
				DumbHook.smethod_1(typeof(HitTest).TypeHandle),
				DumbHook.smethod_1(typeof(Vector3).TypeHandle),
				DumbHook.smethod_1(typeof(Vector3).TypeHandle)
			}, null));
		}
		if (DumbHook.smethod_0(nameOrig, "GetMinSpeed"))
		{
			this.Init(DumbHook.smethod_3(typeOrig, nameOrig), DumbHook.smethod_3(typeHook, nameHook), DumbHook.smethod_3(typeOrigNew, nameOrigNew));
		}
		if (DumbHook.smethod_0(nameOrig, "OnRequestUserInformation"))
		{
			this.Init(DumbHook.smethod_3(typeOrig, nameOrig), DumbHook.smethod_3(typeHook, nameHook), DumbHook.smethod_3(typeOrigNew, nameOrigNew));
		}
		if (DumbHook.smethod_0(nameOrig, "OnLand"))
		{
			this.Init(DumbHook.smethod_3(typeOrig, nameOrig), DumbHook.smethod_3(typeHook, nameHook), DumbHook.smethod_3(typeOrigNew, nameOrigNew));
		}
		if (DumbHook.smethod_0(nameOrig, "AddPunch"))
		{
			this.Init(DumbHook.smethod_3(typeOrig, nameOrig), DumbHook.smethod_3(typeHook, nameHook), DumbHook.smethod_3(typeOrigNew, nameOrigNew));
		}
		if (DumbHook.smethod_0(nameOrig, "SendClientTick"))
		{
			this.Init(DumbHook.smethod_3(typeOrig, nameOrig), DumbHook.smethod_3(typeHook, nameHook), DumbHook.smethod_3(typeOrigNew, nameOrigNew));
		}
		if (DumbHook.smethod_0(nameOrig, "GetAimCone"))
		{
			this.Init(DumbHook.smethod_3(typeOrig, nameOrig), DumbHook.smethod_3(typeHook, nameHook), DumbHook.smethod_3(typeOrigNew, nameOrigNew));
		}
		if (DumbHook.smethod_0(nameOrig, "SetTimedAction"))
		{
			this.Init(DumbHook.smethod_3(typeOrig, nameOrig), DumbHook.smethod_3(typeHook, nameHook), DumbHook.smethod_3(typeOrigNew, nameOrigNew));
		}
		if (DumbHook.smethod_0(nameOrig, "GetIndexedSpreadScalar"))
		{
			this.Init(DumbHook.smethod_3(typeOrig, nameOrig), DumbHook.smethod_3(typeHook, nameHook), DumbHook.smethod_3(typeOrigNew, nameOrigNew));
		}
		if (DumbHook.smethod_0(nameOrig, "UpdateMovementPenalty"))
		{
			this.Init(DumbHook.smethod_3(typeOrig, nameOrig), DumbHook.smethod_3(typeHook, nameHook), DumbHook.smethod_3(typeOrigNew, nameOrigNew));
		}
		if (DumbHook.smethod_0(nameOrig, "UpdateClothesIfNeeded"))
		{
			this.Init(DumbHook.smethod_3(typeOrig, nameOrig), DumbHook.smethod_3(typeHook, nameHook), DumbHook.smethod_3(typeOrigNew, nameOrigNew));
		}
		if (DumbHook.smethod_0(nameOrig, "ClientInput"))
		{
			this.Init(DumbHook.smethod_3(typeOrig, nameOrig), DumbHook.smethod_3(typeHook, nameHook), DumbHook.smethod_3(typeOrigNew, nameOrigNew));
		}
		if (DumbHook.smethod_0(nameOrig, "GetSpeed"))
		{
			this.Init(DumbHook.smethod_2(typeOrig, nameOrig, BindingFlags.Instance | BindingFlags.Public, null, new Type[]
			{
				DumbHook.smethod_1(typeof(float).TypeHandle),
				DumbHook.smethod_1(typeof(float).TypeHandle)
			}, null), DumbHook.smethod_2(typeHook, nameHook, BindingFlags.Instance | BindingFlags.Public, null, new Type[]
			{
				DumbHook.smethod_1(typeof(float).TypeHandle),
				DumbHook.smethod_1(typeof(float).TypeHandle)
			}, null), DumbHook.smethod_2(typeOrigNew, nameOrigNew, BindingFlags.Instance | BindingFlags.Public, null, new Type[]
			{
				DumbHook.smethod_1(typeof(float).TypeHandle),
				DumbHook.smethod_1(typeof(float).TypeHandle)
			}, null));
		}
		if (DumbHook.smethod_0(nameOrig, "CanAttack"))
		{
			this.Init(DumbHook.smethod_3(typeOrig, nameOrig), DumbHook.smethod_3(typeHook, nameHook), DumbHook.smethod_3(typeOrigNew, nameOrigNew));
		}
		if (DumbHook.smethod_0(nameOrig, "HasLocalControls"))
		{
			this.Init(DumbHook.smethod_3(typeOrig, nameOrig), DumbHook.smethod_3(typeHook, nameHook), DumbHook.smethod_3(typeOrigNew, nameOrigNew));
		}
		if (DumbHook.smethod_0(nameOrig, "UpdateAmbient"))
		{
			this.Init(DumbHook.smethod_3(typeOrig, nameOrig), DumbHook.smethod_3(typeHook, nameHook), DumbHook.smethod_3(typeOrigNew, nameOrigNew));
		}
		if (DumbHook.smethod_0(nameOrig, "OnAttacked"))
		{
			this.Init(DumbHook.smethod_2(typeOrig, nameOrig, BindingFlags.Instance | BindingFlags.Public, null, new Type[]
			{
				DumbHook.smethod_1(typeof(HitInfo).TypeHandle)
			}, null), DumbHook.smethod_2(typeHook, nameHook, BindingFlags.Instance | BindingFlags.Public, null, new Type[]
			{
				DumbHook.smethod_1(typeof(HitInfo).TypeHandle)
			}, null), DumbHook.smethod_2(typeOrigNew, nameOrigNew, BindingFlags.Instance | BindingFlags.Public, null, new Type[]
			{
				DumbHook.smethod_1(typeof(HitInfo).TypeHandle)
			}, null));
		}
		if (DumbHook.smethod_0(nameOrig, "CreateOrUpdateEntity"))
		{
			this.Init(DumbHook.smethod_2(typeOrig, nameOrig, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
			{
				DumbHook.smethod_1(typeof(Entity).TypeHandle),
				DumbHook.smethod_1(typeof(long).TypeHandle)
			}, null), DumbHook.smethod_2(typeHook, nameHook, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
			{
				DumbHook.smethod_1(typeof(Entity).TypeHandle),
				DumbHook.smethod_1(typeof(long).TypeHandle)
			}, null), DumbHook.smethod_2(typeOrigNew, nameOrigNew, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
			{
				DumbHook.smethod_1(typeof(Entity).TypeHandle),
				DumbHook.smethod_1(typeof(long).TypeHandle)
			}, null));
		}
		if (DumbHook.smethod_0(nameOrig, "UpdatePositionFromNetwork"))
		{
			this.Init(DumbHook.smethod_2(typeOrig, nameOrig, BindingFlags.Instance | BindingFlags.Public, null, new Type[]
			{
				DumbHook.smethod_1(typeof(Vector3).TypeHandle)
			}, null), DumbHook.smethod_2(typeHook, nameHook, BindingFlags.Instance | BindingFlags.Public, null, new Type[]
			{
				DumbHook.smethod_1(typeof(Vector3).TypeHandle)
			}, null), DumbHook.smethod_2(typeOrigNew, nameOrigNew, BindingFlags.Instance | BindingFlags.Public, null, new Type[]
			{
				DumbHook.smethod_1(typeof(Vector3).TypeHandle)
			}, null));
		}
		if (DumbHook.smethod_0(nameOrig, "IsDead"))
		{
			this.Init(DumbHook.smethod_3(typeOrig, nameOrig), DumbHook.smethod_3(typeHook, nameHook), DumbHook.smethod_3(typeOrigNew, nameOrigNew));
		}
		if (DumbHook.smethod_0(nameOrig, "CreateProjectile") && DumbHook.smethod_4(typeOrig, DumbHook.smethod_1(typeof(global::BaseProjectile).TypeHandle)))
		{
			this.Init(DumbHook.smethod_2(typeOrig, nameOrig, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
			{
				DumbHook.smethod_1(typeof(string).TypeHandle),
				DumbHook.smethod_1(typeof(Vector3).TypeHandle),
				DumbHook.smethod_1(typeof(Vector3).TypeHandle),
				DumbHook.smethod_1(typeof(Vector3).TypeHandle)
			}, null), DumbHook.smethod_2(typeHook, nameHook, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
			{
				DumbHook.smethod_1(typeof(string).TypeHandle),
				DumbHook.smethod_1(typeof(Vector3).TypeHandle),
				DumbHook.smethod_1(typeof(Vector3).TypeHandle),
				DumbHook.smethod_1(typeof(Vector3).TypeHandle)
			}, null), DumbHook.smethod_2(typeOrigNew, nameOrigNew, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
			{
				DumbHook.smethod_1(typeof(string).TypeHandle),
				DumbHook.smethod_1(typeof(Vector3).TypeHandle),
				DumbHook.smethod_1(typeof(Vector3).TypeHandle),
				DumbHook.smethod_1(typeof(Vector3).TypeHandle)
			}, null));
		}
		if (DumbHook.smethod_0(nameOrig, "CreateProjectile") && DumbHook.smethod_4(typeOrig, DumbHook.smethod_1(typeof(BaseMelee).TypeHandle)))
		{
			this.Init(DumbHook.smethod_2(typeOrig, nameOrig, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
			{
				DumbHook.smethod_1(typeof(string).TypeHandle),
				DumbHook.smethod_1(typeof(Vector3).TypeHandle),
				DumbHook.smethod_1(typeof(Vector3).TypeHandle),
				DumbHook.smethod_1(typeof(Vector3).TypeHandle)
			}, null), DumbHook.smethod_2(typeHook, nameHook, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
			{
				DumbHook.smethod_1(typeof(string).TypeHandle),
				DumbHook.smethod_1(typeof(Vector3).TypeHandle),
				DumbHook.smethod_1(typeof(Vector3).TypeHandle),
				DumbHook.smethod_1(typeof(Vector3).TypeHandle)
			}, null), DumbHook.smethod_2(typeOrigNew, nameOrigNew, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
			{
				DumbHook.smethod_1(typeof(string).TypeHandle),
				DumbHook.smethod_1(typeof(Vector3).TypeHandle),
				DumbHook.smethod_1(typeof(Vector3).TypeHandle),
				DumbHook.smethod_1(typeof(Vector3).TypeHandle)
			}, null));
		}
		if (DumbHook.smethod_0(nameOrig, "SendProjectileAttack"))
		{
			this.Init(DumbHook.smethod_3(typeOrig, nameOrig), DumbHook.smethod_3(typeHook, nameHook), DumbHook.smethod_3(typeOrigNew, nameOrigNew));
		}
		if (DumbHook.smethod_0(nameOrig, "OnDeploy"))
		{
			this.Init(DumbHook.smethod_3(typeOrig, nameOrig), DumbHook.smethod_3(typeHook, nameHook), DumbHook.smethod_3(typeOrigNew, nameOrigNew));
		}
		if (DumbHook.smethod_0(nameOrig, "UpdateAmbient"))
		{
			this.Init(DumbHook.smethod_3(typeOrig, nameOrig), DumbHook.smethod_3(typeHook, nameHook), DumbHook.smethod_3(typeOrigNew, nameOrigNew));
		}
		if (DumbHook.smethod_0(nameOrig, "get_isAlive"))
		{
			this.Init(DumbHook.smethod_2(typeOrig, nameOrig, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[0], null), DumbHook.smethod_2(typeHook, nameHook, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[0], null), DumbHook.smethod_2(typeOrigNew, nameOrigNew, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[0], null));
		}
		if (DumbHook.smethod_0(nameOrig, "UpdateServer"))
		{
			this.Init(DumbHook.smethod_2(typeOrig, nameOrig, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
			{
				DumbHook.smethod_1(typeof(ServerList.Server).TypeHandle)
			}, null), DumbHook.smethod_2(typeHook, nameHook, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
			{
				DumbHook.smethod_1(typeof(ServerList.Server).TypeHandle)
			}, null), DumbHook.smethod_2(typeOrigNew, nameOrigNew, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
			{
				DumbHook.smethod_1(typeof(ServerList.Server).TypeHandle)
			}, null));
		}
		if (DumbHook.smethod_0(nameOrig, "CanJump"))
		{
			this.Init(DumbHook.smethod_2(typeOrig, nameOrig, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null), DumbHook.smethod_2(typeHook, nameHook, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null), DumbHook.smethod_2(typeOrigNew, nameOrigNew, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null));
		}
		if (DumbHook.smethod_0(nameOrig, "StartAttackCooldown"))
		{
			this.Init(DumbHook.smethod_2(typeOrig, nameOrig, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
			{
				DumbHook.smethod_1(typeof(float).TypeHandle)
			}, null), DumbHook.smethod_2(typeHook, nameHook, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
			{
				DumbHook.smethod_1(typeof(float).TypeHandle)
			}, null), DumbHook.smethod_2(typeOrigNew, nameOrigNew, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
			{
				DumbHook.smethod_1(typeof(float).TypeHandle)
			}, null));
		}
		if (DumbHook.smethod_0(nameOrig, "Update") && DumbHook.smethod_0(nameHook, "EnvSyncUpdate"))
		{
			this.Init(DumbHook.smethod_2(typeOrig, nameOrig, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null), DumbHook.smethod_2(typeHook, nameHook, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null), DumbHook.smethod_2(typeOrigNew, nameOrigNew, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null));
		}
		if (DumbHook.smethod_0(nameOrig, "ServerRPC"))
		{
			this.Init(DumbHook.smethod_2(typeOrig, nameOrig, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
			{
				DumbHook.smethod_1(typeof(string).TypeHandle),
				DumbHook.smethod_1(typeof(object).TypeHandle),
				DumbHook.smethod_1(typeof(object).TypeHandle),
				DumbHook.smethod_1(typeof(object).TypeHandle),
				DumbHook.smethod_1(typeof(object).TypeHandle),
				DumbHook.smethod_1(typeof(object).TypeHandle)
			}, null), DumbHook.smethod_2(typeHook, nameHook, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
			{
				DumbHook.smethod_1(typeof(string).TypeHandle),
				DumbHook.smethod_1(typeof(object).TypeHandle),
				DumbHook.smethod_1(typeof(object).TypeHandle),
				DumbHook.smethod_1(typeof(object).TypeHandle),
				DumbHook.smethod_1(typeof(object).TypeHandle),
				DumbHook.smethod_1(typeof(object).TypeHandle)
			}, null), DumbHook.smethod_2(typeOrigNew, nameOrigNew, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
			{
				DumbHook.smethod_1(typeof(string).TypeHandle),
				DumbHook.smethod_1(typeof(object).TypeHandle),
				DumbHook.smethod_1(typeof(object).TypeHandle),
				DumbHook.smethod_1(typeof(object).TypeHandle),
				DumbHook.smethod_1(typeof(object).TypeHandle),
				DumbHook.smethod_1(typeof(object).TypeHandle)
			}, null));
		}
		if (DumbHook.smethod_0(nameOrig, "OnTextureWasEdited"))
		{
			this.Init(DumbHook.smethod_2(typeOrig, nameOrig, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
			{
				DumbHook.smethod_1(typeof(Texture2D).TypeHandle)
			}, null), DumbHook.smethod_2(typeHook, nameHook, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
			{
				DumbHook.smethod_1(typeof(Texture2D).TypeHandle)
			}, null), DumbHook.smethod_2(typeOrigNew, nameOrigNew, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
			{
				DumbHook.smethod_1(typeof(Texture2D).TypeHandle)
			}, null));
		}
		if (DumbHook.smethod_0(nameOrig, "DrawTexture"))
		{
			this.Init(DumbHook.smethod_2(typeOrig, nameOrig, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
			{
				DumbHook.smethod_1(typeof(Vector2).TypeHandle),
				DumbHook.smethod_1(typeof(float).TypeHandle),
				DumbHook.smethod_1(typeof(float).TypeHandle),
				DumbHook.smethod_1(typeof(Texture2D).TypeHandle),
				DumbHook.smethod_1(typeof(UnityEngine.Color).TypeHandle)
			}, null), DumbHook.smethod_2(typeHook, nameHook, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
			{
				DumbHook.smethod_1(typeof(Vector2).TypeHandle),
				DumbHook.smethod_1(typeof(float).TypeHandle),
				DumbHook.smethod_1(typeof(float).TypeHandle),
				DumbHook.smethod_1(typeof(Texture2D).TypeHandle),
				DumbHook.smethod_1(typeof(UnityEngine.Color).TypeHandle)
			}, null), DumbHook.smethod_2(typeOrigNew, nameOrigNew, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
			{
				DumbHook.smethod_1(typeof(Vector2).TypeHandle),
				DumbHook.smethod_1(typeof(float).TypeHandle),
				DumbHook.smethod_1(typeof(float).TypeHandle),
				DumbHook.smethod_1(typeof(Texture2D).TypeHandle),
				DumbHook.smethod_1(typeof(UnityEngine.Color).TypeHandle)
			}, null));
		}
		if (DumbHook.smethod_0(nameOrig, "CanTalk"))
		{
			this.Init(DumbHook.smethod_2(typeOrig, nameOrig, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null), DumbHook.smethod_2(typeHook, nameHook, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null), DumbHook.smethod_2(typeOrigNew, nameOrigNew, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null));
		}
		if (DumbHook.smethod_0(nameOrig, "ShouldReceiveVoice"))
		{
			this.Init(DumbHook.smethod_2(typeOrig, nameOrig, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null), DumbHook.smethod_2(typeHook, nameHook, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null), DumbHook.smethod_2(typeOrigNew, nameOrigNew, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null));
		}
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00006908 File Offset: 0x00004B08
	public void Init(MethodInfo orig, MethodInfo hook, MethodInfo orignew)
	{
		if (DumbHook.smethod_4(orig, null))
		{
			throw DumbHook.smethod_5("Original method is null");
		}
		if (DumbHook.smethod_4(hook, null))
		{
			throw DumbHook.smethod_5("Hook method is null");
		}
		DumbHook.smethod_7(DumbHook.smethod_6(orig));
		DumbHook.smethod_7(DumbHook.smethod_6(hook));
		DumbHook.smethod_7(DumbHook.smethod_6(orignew));
		this.OriginalMethod = orig;
		this.HookMethod = hook;
		this.OriginalNew = orignew;
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00006974 File Offset: 0x00004B74
	public unsafe void Hook()
	{
		if (!DumbHook.smethod_4(this.OriginalMethod, null) && !DumbHook.smethod_4(this.HookMethod, null))
		{
			IntPtr functionPointer = DumbHook.smethod_6(this.OriginalMethod).GetFunctionPointer();
			IntPtr functionPointer2 = this.HookMethod.MethodHandle.GetFunctionPointer();
			IntPtr functionPointer3 = this.OriginalNew.MethodHandle.GetFunctionPointer();
			uint newProtect;
			DumbHook.Import.VirtualProtect(functionPointer3, (uint)(this.original.Length + 12), 64u, out newProtect);
			byte* ptr = (byte*)((void*)functionPointer3);
			for (int i = 0; i < this.original.Length; i++)
			{
				ptr[i] = this.original[i];
			}
			ptr[this.original.Length] = 72;
			(ptr + this.original.Length)[1] = 184;
			*(IntPtr*)(ptr + this.original.Length + 2) = (IntPtr)(functionPointer.ToInt64() + (long)this.original.Length);
			(ptr + this.original.Length)[10] = byte.MaxValue;
			(ptr + this.original.Length)[11] = 224;
			DumbHook.Import.VirtualProtect(functionPointer3, (uint)(this.original.Length + 12), newProtect, out newProtect);
			DumbHook.Import.VirtualProtect(functionPointer, 12u, 64u, out newProtect);
			byte* ptr2 = (byte*)((void*)functionPointer);
			*ptr2 = 72;
			ptr2[1] = 184;
			*(IntPtr*)(ptr2 + 2) = functionPointer2;
			ptr2[10] = byte.MaxValue;
			ptr2[11] = 224;
			DumbHook.Import.VirtualProtect(functionPointer, 12u, newProtect, out newProtect);
			return;
		}
		throw DumbHook.smethod_5("Hook has to be properly Init'd before use");
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00006B00 File Offset: 0x00004D00
	public unsafe void Unhook()
	{
		IntPtr functionPointer = DumbHook.smethod_6(this.OriginalMethod).GetFunctionPointer();
		this.HookMethod.MethodHandle.GetFunctionPointer();
		this.OriginalNew.MethodHandle.GetFunctionPointer();
		uint newProtect;
		DumbHook.Import.VirtualProtect(functionPointer, 12u, 64u, out newProtect);
		byte* ptr = (byte*)((void*)functionPointer);
		for (int i = 0; i < this.original.Length; i++)
		{
			ptr[i] = this.original[i];
		}
		DumbHook.Import.VirtualProtect(functionPointer, 12u, newProtect, out newProtect);
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00003E95 File Offset: 0x00002095
	static bool smethod_0(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00003E9E File Offset: 0x0000209E
	static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00003EA6 File Offset: 0x000020A6
	static MethodInfo smethod_2(Type type_0, string string_0, BindingFlags bindingFlags_0, Binder binder_0, Type[] type_1, ParameterModifier[] parameterModifier_0)
	{
		return type_0.GetMethod(string_0, bindingFlags_0, binder_0, type_1, parameterModifier_0);
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00003EB5 File Offset: 0x000020B5
	static MethodInfo smethod_3(Type type_0, string string_0)
	{
		return type_0.GetMethod(string_0);
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00003EBE File Offset: 0x000020BE
	static bool smethod_4(object object_0, object object_1)
	{
		return object.Equals(object_0, object_1);
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00003EC7 File Offset: 0x000020C7
	static ArgumentException smethod_5(string string_0)
	{
		return new ArgumentException(string_0);
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00003ECF File Offset: 0x000020CF
	static RuntimeMethodHandle smethod_6(MethodBase methodBase_0)
	{
		return methodBase_0.MethodHandle;
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00003ED7 File Offset: 0x000020D7
	static void smethod_7(RuntimeMethodHandle runtimeMethodHandle_0)
	{
		RuntimeHelpers.PrepareMethod(runtimeMethodHandle_0);
	}

	// Token: 0x0400002A RID: 42
	private byte[] original;

	// Token: 0x0200000D RID: 13
	internal class Import
	{
		// Token: 0x0600004F RID: 79
		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern bool VirtualProtect(IntPtr address, uint size, uint newProtect, out uint oldProtect);

		// Token: 0x06000050 RID: 80
		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern IntPtr VirtualAlloc(uint lpAddress, uint dwSize, DumbHook.Import.AllocationType lAllocationType, DumbHook.Import.MemoryProtection flProtect);

		// Token: 0x0200000E RID: 14
		[Flags]
		public enum AllocationType
		{
			// Token: 0x0400002F RID: 47
			Commit = 4096,
			// Token: 0x04000030 RID: 48
			Reserve = 8192,
			// Token: 0x04000031 RID: 49
			Decommit = 16384,
			// Token: 0x04000032 RID: 50
			Release = 32768,
			// Token: 0x04000033 RID: 51
			Reset = 524288,
			// Token: 0x04000034 RID: 52
			Physical = 4194304,
			// Token: 0x04000035 RID: 53
			TopDown = 1048576,
			// Token: 0x04000036 RID: 54
			WriteWatch = 2097152,
			// Token: 0x04000037 RID: 55
			LargePages = 536870912
		}

		// Token: 0x0200000F RID: 15
		[Flags]
		public enum MemoryProtection : uint
		{
			// Token: 0x04000039 RID: 57
			EXECUTE = 16u,
			// Token: 0x0400003A RID: 58
			EXECUTE_READ = 32u,
			// Token: 0x0400003B RID: 59
			EXECUTE_READWRITE = 64u,
			// Token: 0x0400003C RID: 60
			EXECUTE_WRITECOPY = 128u,
			// Token: 0x0400003D RID: 61
			NOACCESS = 1u,
			// Token: 0x0400003E RID: 62
			READONLY = 2u,
			// Token: 0x0400003F RID: 63
			READWRITE = 4u,
			// Token: 0x04000040 RID: 64
			WRITECOPY = 8u,
			// Token: 0x04000041 RID: 65
			GUARD_Modifierflag = 256u,
			// Token: 0x04000042 RID: 66
			NOCACHE_Modifierflag = 512u,
			// Token: 0x04000043 RID: 67
			WRITECOMBINE_Modifierflag = 1024u
		}
	}
}
