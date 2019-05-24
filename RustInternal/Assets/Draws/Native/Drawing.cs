using System;
using UnityEngine;

namespace Assets.Draws.Native
{
	// Token: 0x02000016 RID: 22
	internal class Drawing
	{
		// Token: 0x060000BB RID: 187 RVA: 0x00004159 File Offset: 0x00002359
		public static void DrawLine(Rect rect)
		{
			Drawing.DrawLine(rect, Drawing.smethod_0(), 1f);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000416B File Offset: 0x0000236B
		public static void DrawLine(Rect rect, Color color)
		{
			Drawing.DrawLine(rect, color, 1f);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00004179 File Offset: 0x00002379
		public static void DrawLine(Rect rect, float width)
		{
			Drawing.DrawLine(rect, Drawing.smethod_0(), width);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00004187 File Offset: 0x00002387
		public static void DrawLine(Rect rect, Color color, float width)
		{
			Drawing.DrawLine(new Vector2(rect.x, rect.y), new Vector2(rect.x + rect.width, rect.y + rect.height), color, width);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000041C6 File Offset: 0x000023C6
		public static void DrawLine(Vector2 pointA, Vector2 pointB)
		{
			Drawing.DrawLine(pointA, pointB, Drawing.smethod_0(), 1f);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000041D9 File Offset: 0x000023D9
		public static void DrawLine(Vector2 pointA, Vector2 pointB, Color color)
		{
			Drawing.DrawLine(pointA, pointB, color, 1f);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000041E8 File Offset: 0x000023E8
		public static void DrawLine(Vector2 pointA, Vector2 pointB, float width)
		{
			Drawing.DrawLine(pointA, pointB, Drawing.smethod_0(), width);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00008E4C File Offset: 0x0000704C
		public static void DrawLine(Vector2 pointA, Vector2 pointB, Color color, float width)
		{
			Matrix4x4 matrix = Drawing.smethod_1();
			if (!Drawing.smethod_2(Drawing.lineTex))
			{
				Drawing.lineTex = Drawing.smethod_3(1, 1);
			}
			Color color2 = Drawing.smethod_4();
			Drawing.smethod_5(color);
			float num = Vector3.Angle(pointB - pointA, Vector2.right);
			if (pointA.y > pointB.y)
			{
				num = -num;
			}
			GUIUtility.ScaleAroundPivot(new Vector2((pointB - pointA).magnitude, width), new Vector2(pointA.x, pointA.y + 0.5f));
			GUIUtility.RotateAroundPivot(num, pointA);
			GUI.DrawTexture(new Rect(pointA.x, pointA.y, 1f, 1f), Drawing.lineTex);
			GUI.matrix = matrix;
			GUI.color = color2;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00008F20 File Offset: 0x00007120
		public static void DrawLineGL(Vector3 Start, Vector3 End, Color color)
		{
			if (!Drawing.smethod_2(Drawing.lineMaterial))
			{
				Drawing.lineMaterial = Drawing.smethod_6("Shader \"Lines/Colored Blended\" {SubShader { Pass {     Blend SrcAlpha OneMinusSrcAlpha     ZWrite Off Cull Off Fog { Mode Off }     ZTest Always    BindChannels {      Bind \"vertex\", vertex Bind \"red\", color }} } }");
				Drawing.smethod_7(Drawing.lineMaterial, HideFlags.HideAndDontSave);
				Drawing.smethod_7(Drawing.smethod_8(Drawing.lineMaterial), HideFlags.HideAndDontSave);
				Drawing.smethod_9(Drawing.lineMaterial, 0);
			}
			Drawing.smethod_10();
			Drawing.smethod_11();
			Drawing.smethod_12(color);
			Drawing.smethod_13(1);
			Drawing.smethod_16(Start.x / (float)Drawing.smethod_14(), Start.y / (float)Drawing.smethod_15(), 0f);
			Drawing.smethod_16(End.x / (float)Drawing.smethod_14(), End.y / (float)Drawing.smethod_15(), 0f);
			Drawing.smethod_17();
			Drawing.smethod_18();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00008FDC File Offset: 0x000071DC
		public static void DrawCircle(Vector2 pos, int rad, Color color, float depth)
		{
			int num = 15;
			float num2 = pos.x + 15f;
			float num3 = pos.y;
			for (int i = 1; i <= 360; i++)
			{
				float x = num2;
				float y = num3;
				num2 = (float)(Drawing.smethod_20((double)num * Drawing.smethod_19((double)i)) + (double)pos.x);
				num3 = (float)(Drawing.smethod_20((double)num * Drawing.smethod_21((double)i)) + (double)pos.y);
				Drawing.DrawLine(new Vector2(x, y), new Vector2(num2, num3), color, depth);
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00009064 File Offset: 0x00007264
		public static void DrawString(Vector2 pos, Color color, Drawing.TextFlags flags, string text, int fontSize)
		{
			bool center = (flags & Drawing.TextFlags.TEXT_FLAG_CENTERED) == Drawing.TextFlags.TEXT_FLAG_CENTERED;
			if ((flags & Drawing.TextFlags.TEXT_FLAG_OUTLINED) == Drawing.TextFlags.TEXT_FLAG_OUTLINED)
			{
				Drawing.DrawStringInternal(pos + new Vector2(1f, 0f), Color.black, text, center, fontSize);
				Drawing.DrawStringInternal(pos + new Vector2(0f, 1f), Color.black, text, center, fontSize);
				Drawing.DrawStringInternal(pos + new Vector2(0f, -1f), Color.black, text, center, fontSize);
			}
			if ((flags & Drawing.TextFlags.TEXT_FLAG_DROPSHADOW) == Drawing.TextFlags.TEXT_FLAG_DROPSHADOW)
			{
				Drawing.DrawStringInternal(pos + new Vector2(1f, 1f), Color.black, text, center, fontSize);
			}
			Drawing.DrawStringInternal(pos, color, text, center, fontSize);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00009120 File Offset: 0x00007320
		public static void DrawString1(Vector2 pos, string text, Color color, bool center = true, int size = 12)
		{
			Drawing.smethod_22(Drawing.Gst, size);
			Drawing.smethod_24(Drawing.smethod_23(Drawing.Gst), color);
			GUIContent guicontent = Drawing.smethod_25(text);
			if (center)
			{
				pos.x -= Drawing.smethod_26(Drawing.Gst, guicontent).x / 2f;
			}
			GUI.Label(new Rect(pos.x, pos.y, 300f, 25f), guicontent, Drawing.Gst);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000919C File Offset: 0x0000739C
		private static void DrawStringInternal(Vector2 pos, Color color, string text, bool center, int fontSize)
		{
			if (Drawing.Gst == null)
			{
				Drawing.Gst = Drawing.smethod_29(Drawing.smethod_28(Drawing.smethod_27()));
			}
			Drawing.smethod_24(Drawing.smethod_23(Drawing.Gst), color);
			Drawing.smethod_22(Drawing.Gst, fontSize);
			if (center)
			{
				pos.x -= Drawing.smethod_26(Drawing.Gst, Drawing.smethod_25(text)).x / 2f;
			}
			GUI.Label(new Rect(pos.x, pos.y, 264f, 20f), text, Drawing.Gst);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00009234 File Offset: 0x00007434
		public static void DrawBox(Vector2 pos, Vector2 size, Color color)
		{
			if (!Drawing.smethod_2(Drawing.figTex))
			{
				Drawing.figTex = Drawing.smethod_3(1, 1);
			}
			if (color != Drawing.lfgColor)
			{
				Drawing.smethod_30(Drawing.figTex, 0, 0, color);
				Drawing.smethod_31(Drawing.figTex);
				Drawing.lfgColor = color;
			}
			GUI.DrawTexture(new Rect(pos.x, pos.y, size.x, size.y), Drawing.figTex);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000092B0 File Offset: 0x000074B0
		public static void DrawBar(Rect pos, float value, float maxValue, Color color)
		{
			Drawing.DrawBox(new Vector2(pos.x, pos.y), new Vector2(pos.width, pos.height), Color.black);
			Drawing.DrawBox(new Vector2(pos.x, pos.y), new Vector2(value * pos.width / maxValue, pos.height), color);
			Drawing.DrawBoxOutlines(new Vector2(pos.x - 1f, pos.y - 1f), new Vector2(pos.width + 2f, pos.height + 1f), 1f, Color.black);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000936C File Offset: 0x0000756C
		public static void DrawBoxOutlines(Vector2 position, Vector2 size, float borderSize, Color color)
		{
			Drawing.DrawBox(new Vector2(position.x + borderSize, position.y), new Vector2(size.x - 2f * borderSize, borderSize), color);
			Drawing.DrawBox(new Vector2(position.x, position.y), new Vector2(borderSize, size.y), color);
			Drawing.DrawBox(new Vector2(position.x + size.x - borderSize, position.y), new Vector2(borderSize, size.y), color);
			Drawing.DrawBox(new Vector2(position.x + borderSize, position.y + size.y - borderSize), new Vector2(size.x - 2f * borderSize, borderSize), color);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000041FF File Offset: 0x000023FF
		static Color smethod_0()
		{
			return GUI.contentColor;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00004206 File Offset: 0x00002406
		static Matrix4x4 smethod_1()
		{
			return GUI.matrix;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000040AF File Offset: 0x000022AF
		static bool smethod_2(UnityEngine.Object object_0)
		{
			return object_0;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000401F File Offset: 0x0000221F
		static Texture2D smethod_3(int int_0, int int_1)
		{
			return new Texture2D(int_0, int_1);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000420D File Offset: 0x0000240D
		static Color smethod_4()
		{
			return GUI.color;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00003FBF File Offset: 0x000021BF
		static void smethod_5(Color color_0)
		{
			GUI.color = color_0;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00003F7B File Offset: 0x0000217B
		static Material smethod_6(string string_0)
		{
			return new Material(string_0);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00003F8C File Offset: 0x0000218C
		static void smethod_7(UnityEngine.Object object_0, HideFlags hideFlags_0)
		{
			object_0.hideFlags = hideFlags_0;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00003F95 File Offset: 0x00002195
		static Shader smethod_8(Material material_0)
		{
			return material_0.shader;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00004039 File Offset: 0x00002239
		static bool smethod_9(Material material_0, int int_0)
		{
			return material_0.SetPass(int_0);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00003FB0 File Offset: 0x000021B0
		static void smethod_10()
		{
			GL.PushMatrix();
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00004214 File Offset: 0x00002414
		static void smethod_11()
		{
			GL.LoadOrtho();
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000404A File Offset: 0x0000224A
		static void smethod_12(Color color_0)
		{
			GL.Color(color_0);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00004042 File Offset: 0x00002242
		static void smethod_13(int int_0)
		{
			GL.Begin(int_0);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000421B File Offset: 0x0000241B
		static int smethod_14()
		{
			return Screen.width;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00004222 File Offset: 0x00002422
		static int smethod_15()
		{
			return Screen.height;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00004052 File Offset: 0x00002252
		static void smethod_16(float float_0, float float_1, float float_2)
		{
			GL.Vertex3(float_0, float_1, float_2);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000405C File Offset: 0x0000225C
		static void smethod_17()
		{
			GL.End();
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00003FD0 File Offset: 0x000021D0
		static void smethod_18()
		{
			GL.PopMatrix();
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00004229 File Offset: 0x00002429
		static double smethod_19(double double_0)
		{
			return Math.Cos(double_0);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00004231 File Offset: 0x00002431
		static double smethod_20(double double_0)
		{
			return Math.Round(double_0);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00004239 File Offset: 0x00002439
		static double smethod_21(double double_0)
		{
			return Math.Sin(double_0);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00003FEA File Offset: 0x000021EA
		static void smethod_22(GUIStyle guistyle_0, int int_0)
		{
			guistyle_0.fontSize = int_0;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00004095 File Offset: 0x00002295
		static GUIStyleState smethod_23(GUIStyle guistyle_0)
		{
			return guistyle_0.normal;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000409D File Offset: 0x0000229D
		static void smethod_24(GUIStyleState guistyleState_0, Color color_0)
		{
			guistyleState_0.textColor = color_0;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00003FFC File Offset: 0x000021FC
		static GUIContent smethod_25(string string_0)
		{
			return new GUIContent(string_0);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00004004 File Offset: 0x00002204
		static Vector2 smethod_26(GUIStyle guistyle_0, GUIContent guicontent_0)
		{
			return guistyle_0.CalcSize(guicontent_0);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00004063 File Offset: 0x00002263
		static GUISkin smethod_27()
		{
			return GUI.skin;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000406A File Offset: 0x0000226A
		static GUIStyle smethod_28(GUISkin guiskin_0)
		{
			return guiskin_0.label;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00004072 File Offset: 0x00002272
		static GUIStyle smethod_29(GUIStyle guistyle_0)
		{
			return new GUIStyle(guistyle_0);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00003FD7 File Offset: 0x000021D7
		static void smethod_30(Texture2D texture2D_0, int int_0, int int_1, Color color_0)
		{
			texture2D_0.SetPixel(int_0, int_1, color_0);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00003FE2 File Offset: 0x000021E2
		static void smethod_31(Texture2D texture2D_0)
		{
			texture2D_0.Apply();
		}

		// Token: 0x04000071 RID: 113
		private static GUIStyle Gst = null;

		// Token: 0x04000072 RID: 114
		private static Color lfgColor;

		// Token: 0x04000073 RID: 115
		private static Material lineMaterial;

		// Token: 0x04000074 RID: 116
		private static Texture2D lineTex;

		// Token: 0x04000075 RID: 117
		private static Texture2D figTex;

		// Token: 0x02000017 RID: 23
		[Flags]
		public enum TextFlags
		{
			// Token: 0x04000077 RID: 119
			TEXT_FLAG_NONE = 0,
			// Token: 0x04000078 RID: 120
			TEXT_FLAG_CENTERED = 1,
			// Token: 0x04000079 RID: 121
			TEXT_FLAG_OUTLINED = 2,
			// Token: 0x0400007A RID: 122
			TEXT_FLAG_DROPSHADOW = 3
		}
	}
}
