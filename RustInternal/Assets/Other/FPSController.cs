using System;
using UnityEngine;

namespace Assets.Other
{
	// Token: 0x02000011 RID: 17
	internal class FPSController
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x000040C1 File Offset: 0x000022C1
		public static void Update()
		{
			FPSController.deltaTime += (FPSController.smethod_0() - FPSController.deltaTime) * 0.1f;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000084C0 File Offset: 0x000066C0
		public static string GetAsString()
		{
			float num = FPSController.deltaTime * 1000f;
			float num2 = 1f / FPSController.deltaTime;
			return FPSController.smethod_1("{1:0.} FPS", num, num2);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000040EB File Offset: 0x000022EB
		static float smethod_0()
		{
			return Time.deltaTime;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000040F2 File Offset: 0x000022F2
		static string smethod_1(string string_0, object object_0, object object_1)
		{
			return string.Format(string_0, object_0, object_1);
		}

		// Token: 0x04000059 RID: 89
		private static float deltaTime = 0f;
	}
}
