using System;
using UnityEngine;

namespace Assets.Draws.Native
{
	// Token: 0x02000015 RID: 21
	internal class ColorFix
	{
		// Token: 0x060000B9 RID: 185 RVA: 0x00008DE4 File Offset: 0x00006FE4
		public static Color RGBColor(float r, float g, float b)
		{
			if (r > 255f)
			{
				r = 255f;
			}
			if (g > 255f)
			{
				g = 255f;
			}
			if (b > 255f)
			{
				b = 255f;
			}
			r /= 255f;
			g /= 255f;
			b /= 255f;
			return new Color(r, g, b);
		}
	}
}
