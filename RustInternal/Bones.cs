using System;
using System.Collections.Generic;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x0200002E RID: 46
	public static class Bones
	{
		// Token: 0x060001DF RID: 479 RVA: 0x0000C710 File Offset: 0x0000A910
		static Bones()
		{
			Bones.boneList[0] = "head";
			Bones.boneList[1] = "neck";
			Bones.boneList[2] = "spine1";
			Bones.boneList[3] = "pelvis";
			Bones.boneList[4] = "l_upperarm";
			Bones.boneList[5] = "l_forearm";
			Bones.boneList[6] = "l_hand";
			Bones.boneList[7] = "r_upperarm";
			Bones.boneList[8] = "r_forearm";
			Bones.boneList[9] = "r_hand";
			Bones.boneList[10] = "l_hip";
			Bones.boneList[11] = "l_knee";
			Bones.boneList[12] = "l_foot";
			Bones.boneList[13] = "r_hip";
			Bones.boneList[14] = "r_knee";
			Bones.boneList[15] = "r_foot";
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000C830 File Offset: 0x0000AA30
		public static Vector3[] GetBonePositions(this BasePlayer player)
		{
			Vector3[] array = new Vector3[Bones.boneList.Count];
			for (int i = 0; i < Bones.boneList.Count; i++)
			{
				array[i] = Bones.smethod_1(Bones.smethod_0(player.playerModel, Bones.boneList[i]));
			}
			return array;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000457A File Offset: 0x0000277A
		static Transform smethod_0(PlayerModel playerModel_0, string string_0)
		{
			return playerModel_0.FindBone(string_0);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x000042A7 File Offset: 0x000024A7
		static Vector3 smethod_1(Transform transform_0)
		{
			return transform_0.position;
		}

		// Token: 0x040000D1 RID: 209
		public static Dictionary<int, string> boneList = new Dictionary<int, string>();
	}
}
