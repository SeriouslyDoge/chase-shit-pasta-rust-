using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x0200005D RID: 93
	public class BoneESP : MonoBehaviour
	{
		// Token: 0x06000401 RID: 1025 RVA: 0x00019F14 File Offset: 0x00018114
		public static void DrawBoneESP()
		{
			if (Main.Skeleton.GetData<bool>() && BoneESP.smethod_1(BoneESP.smethod_0(), null) && BoneESP.smethod_2() != null)
			{
				IEnumerator<BasePlayer> enumerator = BoneESP.smethod_2().GetEnumerator();
				try
				{
					while (BoneESP.smethod_8(enumerator))
					{
						BasePlayer basePlayer = enumerator.Current;
						int num = (int)Vector3.Distance(BoneESP.smethod_4(BoneESP.smethod_3(MainCamera.mainCamera)), BoneESP.smethod_4(BoneESP.smethod_3(basePlayer)));
						if (!BoneESP.smethod_5(basePlayer) || !BoneESP.smethod_1(basePlayer, null) || BoneESP.smethod_6(basePlayer) || !BoneESP.smethod_1(basePlayer.model, null) || !BoneESP.smethod_7(basePlayer))
						{
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						BoneESP.smethod_9(enumerator);
					}
				}
			}
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00019FD8 File Offset: 0x000181D8
		public static Vector3 W2SBone(Model model, string name)
		{
			Vector3 result = Vector3.zero;
			if (BoneESP.smethod_1(model, null))
			{
				if (BoneESP.smethod_10(name, "headCenter"))
				{
					result = MainCamera.mainCamera.WorldToScreenPoint(new Vector3(BoneESP.smethod_4(model.headBone).x, BoneESP.smethod_4(model.eyeBone).y, BoneESP.smethod_4(model.headBone).z));
				}
				else
				{
					result = MainCamera.mainCamera.WorldToScreenPoint(model.FindBone(name).position);
				}
			}
			return result;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x000042CF File Offset: 0x000024CF
		static BasePlayer smethod_0()
		{
			return LocalPlayer.Entity;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000400D File Offset: 0x0000220D
		static bool smethod_1(UnityEngine.Object object_0, UnityEngine.Object object_1)
		{
			return object_0 != object_1;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0000425F File Offset: 0x0000245F
		static BufferList<BasePlayer> smethod_2()
		{
			return BasePlayer.VisiblePlayerList;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0000429F File Offset: 0x0000249F
		static Transform smethod_3(Component component_0)
		{
			return component_0.transform;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x000042A7 File Offset: 0x000024A7
		static Vector3 smethod_4(Transform transform_0)
		{
			return transform_0.position;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00004794 File Offset: 0x00002994
		static bool smethod_5(BaseEntity baseEntity_0)
		{
			return baseEntity_0.IsValid();
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0000426E File Offset: 0x0000246E
		static bool smethod_6(BasePlayer basePlayer_0)
		{
			return basePlayer_0.IsSleeping();
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00004266 File Offset: 0x00002466
		static bool smethod_7(BasePlayer basePlayer_0)
		{
			return basePlayer_0.IsLocalPlayer();
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0000428F File Offset: 0x0000248F
		static bool smethod_8(IEnumerator ienumerator_0)
		{
			return ienumerator_0.MoveNext();
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00004297 File Offset: 0x00002497
		static void smethod_9(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00003E95 File Offset: 0x00002095
		static bool smethod_10(string string_0, string string_1)
		{
			return string_0 == string_1;
		}
	}
}
