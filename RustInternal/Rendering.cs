using System;
using UnityEngine;

// Token: 0x02000010 RID: 16
public class Rendering
{
	// Token: 0x06000052 RID: 82 RVA: 0x00006B90 File Offset: 0x00004D90
	public static Material[] CreateChamMaterial(Color color)
	{
		if (Rendering.smethod_0(Rendering.wallhackMaterial, null))
		{
			Rendering.wallhackMaterial = Rendering.smethod_2(Rendering.smethod_1("Hidden/Internal-Colored"));
			Rendering.smethod_4(Rendering.wallhackMaterial, Rendering.smethod_3("Custom/Chams-WallHack"));
			Rendering.smethod_5(Rendering.wallhackMaterial, HideFlags.HideAndDontSave);
			Rendering.smethod_5(Rendering.smethod_6(Rendering.wallhackMaterial), HideFlags.HideAndDontSave);
			Rendering.smethod_7(Rendering.wallhackMaterial, "_SrcBlend", 5);
			Rendering.smethod_7(Rendering.wallhackMaterial, "_DstBlend", 10);
			Rendering.smethod_8(Rendering.wallhackMaterial, color);
		}
		if (Rendering.ChamMats == null)
		{
			Rendering.ChamMats = new Material[]
			{
				Rendering.wallhackMaterial,
				Rendering.wallhackMaterial,
				Rendering.wallhackMaterial,
				Rendering.wallhackMaterial,
				Rendering.wallhackMaterial,
				Rendering.wallhackMaterial,
				Rendering.wallhackMaterial,
				Rendering.wallhackMaterial,
				Rendering.wallhackMaterial,
				Rendering.wallhackMaterial,
				Rendering.wallhackMaterial,
				Rendering.wallhackMaterial
			};
		}
		return Rendering.ChamMats;
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00006C9C File Offset: 0x00004E9C
	public static void DrawLine(Vector2 pointA, Vector2 pointB, Color color, float width, bool antiAlias)
	{
		float num = pointB.x - pointA.x;
		float num2 = pointB.y - pointA.y;
		float num3 = Mathf.Sqrt(num * num + num2 * num2);
		if (num3 >= 0.001f)
		{
			Texture2D texture_;
			if (antiAlias)
			{
				width *= 3f;
				texture_ = Rendering.aaLineTex;
			}
			else
			{
				texture_ = Rendering.lineTex;
			}
			float num4 = width * num2 / num3;
			float num5 = width * num / num3;
			Matrix4x4 identity = Matrix4x4.identity;
			identity.m00 = num;
			identity.m01 = -num4;
			identity.m03 = pointA.x + 0.5f * num4;
			identity.m10 = num2;
			identity.m11 = num5;
			identity.m13 = pointA.y - 0.5f * num5;
			Rendering.smethod_9();
			Rendering.smethod_10(identity);
			Rendering.smethod_11(color);
			Rendering.smethod_12(Rendering.lineRect, texture_);
			Rendering.smethod_13();
		}
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00006D80 File Offset: 0x00004F80
	public static void DrawLine3(Vector2 pointA, Vector2 pointB, Color color, float width, bool antiAlias)
	{
		float num = pointB.x - pointA.x;
		float num2 = pointB.y - pointA.y;
		float num3 = Mathf.Sqrt(num * num + num2 * num2);
		if (num3 >= 0.001f)
		{
			Texture2D texture_;
			if (antiAlias)
			{
				width *= 3f;
				texture_ = Rendering.aaLineTex;
			}
			else
			{
				texture_ = Rendering.lineTex;
			}
			float num4 = width * num2 / num3;
			float num5 = width * num / num3;
			Matrix4x4 identity = Matrix4x4.identity;
			identity.m00 = num;
			identity.m01 = -num4;
			identity.m03 = pointA.x + 0.5f * num4;
			identity.m10 = num2;
			identity.m11 = num5;
			identity.m13 = pointA.y - 0.5f * num5;
			Rendering.smethod_9();
			Rendering.smethod_10(identity);
			Rendering.smethod_11(color);
			Rendering.smethod_12(Rendering.lineRect, texture_);
			Rendering.smethod_13();
		}
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00006E64 File Offset: 0x00005064
	private static Vector2 CubeBezier(Vector2 s, Vector2 st, Vector2 e, Vector2 et, float t)
	{
		float num = 1f - t;
		return num * num * num * s + 3f * num * num * t * st + 3f * num * t * t * et + t * t * t * e;
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00006ECC File Offset: 0x000050CC
	public static void DrawRadarBackground(Rect rect)
	{
		Color color_ = new Color(0f, 0f, 0f, 0.5f);
		Rendering.smethod_14(Rendering.texture2D_0, 0, 0, color_);
		Rendering.smethod_15(Rendering.texture2D_0);
		Rendering.smethod_11(color_);
		Rendering.smethod_12(rect, Rendering.texture2D_0);
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00006F1C File Offset: 0x0000511C
	public static void DrawString3(Vector2 pos, string text, Color color, bool center = true, int size = 12, bool stroke = true)
	{
		Rendering.smethod_16(Rendering.guistyle_0, size);
		Rendering.smethod_17(Rendering.guistyle_0, FontStyle.Bold);
		GUIContent guicontent = Rendering.smethod_18(text);
		if (center)
		{
			pos.x -= Rendering.smethod_19(Rendering.guistyle_0, guicontent).x / 2f;
		}
		if (stroke)
		{
			Rendering.smethod_11(Color.black);
			GUI.Label(new Rect(pos.x - 1f, pos.y, 300f, 25f), guicontent, Rendering.guistyle_0);
			GUI.Label(new Rect(pos.x + 1f, pos.y, 300f, 25f), guicontent, Rendering.guistyle_0);
			GUI.Label(new Rect(pos.x, pos.y - 1f, 300f, 25f), guicontent, Rendering.guistyle_0);
			GUI.Label(new Rect(pos.x, pos.y + 1f, 300f, 25f), guicontent, Rendering.guistyle_0);
		}
		GUI.color = color;
		GUI.Label(new Rect(pos.x, pos.y, 300f, 25f), guicontent, Rendering.guistyle_0);
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00003EDF File Offset: 0x000020DF
	public static void DrawLine100(Vector2 startPos, Vector2 endPos, Color color, float thickness)
	{
		if (Rendering.smethod_20(Rendering.texture, null))
		{
			Rendering.smethod_14(Rendering.texture, 0, 0, color);
			Rendering.smethod_21(Rendering.texture, TextureWrapMode.Repeat);
			Rendering.smethod_15(Rendering.texture);
		}
		Rendering.DrawLineStretched(startPos, endPos, Rendering.texture, thickness);
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00007058 File Offset: 0x00005258
	public static void FillRGB(Vector2 point, float width, float height, Color color, float alpha)
	{
		Texture2D texture2D = Rendering.smethod_22(1, 1);
		Color color2 = color;
		color2.a = alpha;
		Color[] array = Rendering.smethod_23(texture2D);
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = color2;
		}
		Rendering.smethod_24(texture2D, array);
		Rendering.smethod_15(texture2D);
		GUI.DrawTexture(new Rect(point.x, point.y, width, height), texture2D);
	}

	// Token: 0x0600005A RID: 90 RVA: 0x000070C0 File Offset: 0x000052C0
	public static void DrawLine6(Vector2 pointA, Vector2 pointB, Color color)
	{
		Rendering.smethod_25(Rendering.lineMaterial, 0);
		Rendering.smethod_26(1);
		Rendering.smethod_27(color);
		Rendering.smethod_28(pointA.x, pointA.y, 0f);
		Rendering.smethod_28(pointB.x, pointB.y, 0f);
		Rendering.smethod_29();
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00007118 File Offset: 0x00005318
	public static void DrawTriangle(Vector2 Point, int left, int right, int height, Color color)
	{
		Rendering.DrawLine6(Point, new Vector2(Point.x - (float)left, Point.y + (float)height), color);
		Rendering.DrawLine6(Point, new Vector2(Point.x + (float)right, Point.y + (float)height), color);
		Rendering.DrawLine6(new Vector2(Point.x - (float)left, Point.y + (float)height), new Vector2(Point.x + (float)right, Point.y + (float)height), color);
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00003F1D File Offset: 0x0000211D
	public static void BoxRect(Rect rect, Color color)
	{
		if (color != Rendering.color_0)
		{
			Rendering.smethod_14(Rendering.texture2D_0, 0, 0, color);
			Rendering.smethod_15(Rendering.texture2D_0);
			Rendering.color_0 = color;
		}
		Rendering.smethod_12(rect, Rendering.texture2D_0);
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00003F54 File Offset: 0x00002154
	public static void DrawCircle(Vector2 center, int radius, Color color, float width, int segmentsPerQuarter)
	{
		Rendering.DrawCircle(center, radius, color, width, false, segmentsPerQuarter);
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00007198 File Offset: 0x00005398
	public static void DrawBezierLine(Vector2 start, Vector2 startTangent, Vector2 end, Vector2 endTangent, Color color, float width, bool antiAlias, int segments)
	{
		Vector2 pointA = Rendering.CubeBezier(start, startTangent, end, endTangent, 0f);
		for (int i = 1; i < segments + 1; i++)
		{
			Vector2 vector = Rendering.CubeBezier(start, startTangent, end, endTangent, (float)i / (float)segments);
			Rendering.DrawLine3(pointA, vector, color, width, antiAlias);
			pointA = vector;
		}
	}

	// Token: 0x0600005F RID: 95 RVA: 0x000071E4 File Offset: 0x000053E4
	public static void DrawCircle(Vector2 center, int radius, Color color, float width, bool antiAlias, int segmentsPerQuarter)
	{
		float num = (float)radius / 2f;
		Vector2 vector = new Vector2(center.x, center.y - (float)radius);
		Vector2 endTangent = new Vector2(center.x - num, center.y - (float)radius);
		Vector2 startTangent = new Vector2(center.x + num, center.y - (float)radius);
		Vector2 vector2 = new Vector2(center.x + (float)radius, center.y);
		Vector2 endTangent2 = new Vector2(center.x + (float)radius, center.y - num);
		Vector2 startTangent2 = new Vector2(center.x + (float)radius, center.y + num);
		Vector2 vector3 = new Vector2(center.x, center.y + (float)radius);
		Vector2 startTangent3 = new Vector2(center.x - num, center.y + (float)radius);
		Vector2 endTangent3 = new Vector2(center.x + num, center.y + (float)radius);
		Vector2 vector4 = new Vector2(center.x - (float)radius, center.y);
		Vector2 startTangent4 = new Vector2(center.x - (float)radius, center.y - num);
		Vector2 endTangent4 = new Vector2(center.x - (float)radius, center.y + num);
		Rendering.DrawBezierLine(vector, startTangent, vector2, endTangent2, color, width, antiAlias, segmentsPerQuarter);
		Rendering.DrawBezierLine(vector2, startTangent2, vector3, endTangent3, color, width, antiAlias, segmentsPerQuarter);
		Rendering.DrawBezierLine(vector3, startTangent3, vector4, endTangent4, color, width, antiAlias, segmentsPerQuarter);
		Rendering.DrawBezierLine(vector4, startTangent4, vector, endTangent, color, width, antiAlias, segmentsPerQuarter);
	}

	// Token: 0x06000060 RID: 96 RVA: 0x0000735C File Offset: 0x0000555C
	public static void DrawBar(Rect pos, float value, float maxValue, Color color)
	{
		Rendering.DrawBox1(new Vector2(pos.x, pos.y), new Vector2(pos.width, pos.height), Color.black);
		Rendering.DrawBox1(new Vector2(pos.x, pos.y), new Vector2(value * pos.width / maxValue, pos.height), color);
		Rendering.DrawBoxOutlines(new Vector2(pos.x - 2f, pos.y - 2f), new Vector2(pos.width + 3f, pos.height + 2f), 2f, Color.black);
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00003EDF File Offset: 0x000020DF
	public static void DrawLine2(Vector2 startPos, Vector2 endPos, Color color, float thickness)
	{
		if (Rendering.smethod_20(Rendering.texture, null))
		{
			Rendering.smethod_14(Rendering.texture, 0, 0, color);
			Rendering.smethod_21(Rendering.texture, TextureWrapMode.Repeat);
			Rendering.smethod_15(Rendering.texture);
		}
		Rendering.DrawLineStretched(startPos, endPos, Rendering.texture, thickness);
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00007418 File Offset: 0x00005618
	static Rendering()
	{
		Rendering.outlineColor = new Color(0f, 0f, 0f, 1f);
		Rendering.texture = new Texture2D(1, 1);
		Rendering.style = new GUIStyle(GUI.skin.label)
		{
			fontSize = 12
		};
		Rendering.outlineStyle = new GUIStyle(GUI.skin.label)
		{
			fontSize = 12
		};
		Rendering.tahoma = Font.CreateDynamicFontFromOSFont("Tahoma", 12);
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00007584 File Offset: 0x00005784
	public static void DrawHealth(float x, float y, float health, float maxHealth = 100f, float width = 50f, float height = 5f, float thickness = 1f)
	{
		float num = (width - thickness * 2f) * health / maxHealth;
		if (num < 1f)
		{
			num = 1f;
		}
		Color color = Color.green;
		if (health < maxHealth * 0.6f)
		{
			color = Color.yellow;
		}
		if (health < maxHealth * 0.3f)
		{
			color = Color.red;
		}
		Rendering.RectFilled(x - width / 2f, y - height, width, height, Color.black);
		Rendering.RectFilled(x - width / 2f + thickness, y - height + thickness, num, height - thickness * 2f, color);
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00007620 File Offset: 0x00005820
	public static Vector3 RotateAroundPoint(Vector3 point, Vector3 pivot, Quaternion angle)
	{
		return angle * (point - pivot) + pivot;
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00007644 File Offset: 0x00005844
	public static void RectOutlined(float x, float y, float width, float height, Color color, float thickness = 1f)
	{
		Rendering.RectFilled(x, y, thickness, height, color);
		Rendering.RectFilled(x + width - thickness, y, thickness, height, color);
		Rendering.RectFilled(x + thickness, y, width - thickness * 2f, thickness, color);
		Rendering.RectFilled(x + thickness, y + height - thickness, width - thickness * 2f, thickness, color);
	}

	// Token: 0x06000066 RID: 102 RVA: 0x000076A4 File Offset: 0x000058A4
	public static void CornerBox(Vector2 Head, float Width, float Height, float thickness, Color color, bool outline)
	{
		int num = (int)(Width / 4f);
		int num2 = num;
		if (outline)
		{
			Rendering.RectFilled(Head.x - Width / 2f - 1f, Head.y - 1f, (float)(num + 2), 3f, Color.black);
			Rendering.RectFilled(Head.x - Width / 2f - 1f, Head.y - 1f, 3f, (float)(num2 + 2), Color.black);
			Rendering.RectFilled(Head.x + Width / 2f - (float)num - 1f, Head.y - 1f, (float)(num + 2), 3f, Color.black);
			Rendering.RectFilled(Head.x + Width / 2f - 1f, Head.y - 1f, 3f, (float)(num2 + 2), Color.black);
			Rendering.RectFilled(Head.x - Width / 2f - 1f, Head.y + Height - 4f, (float)(num + 2), 3f, Color.black);
			Rendering.RectFilled(Head.x - Width / 2f - 1f, Head.y + Height - (float)num2 - 4f, 3f, (float)(num2 + 2), Color.black);
			Rendering.RectFilled(Head.x + Width / 2f - (float)num - 1f, Head.y + Height - 4f, (float)(num + 2), 3f, Color.black);
			Rendering.RectFilled(Head.x + Width / 2f - 1f, Head.y + Height - (float)num2 - 4f, 3f, (float)(num2 + 3), Color.black);
		}
		Rendering.RectFilled(Head.x - Width / 2f, Head.y, (float)num, 1f, color);
		Rendering.RectFilled(Head.x - Width / 2f, Head.y, 1f, (float)num2, color);
		Rendering.RectFilled(Head.x + Width / 2f - (float)num, Head.y, (float)num, 1f, color);
		Rendering.RectFilled(Head.x + Width / 2f, Head.y, 1f, (float)num2, color);
		Rendering.RectFilled(Head.x - Width / 2f, Head.y + Height - 3f, (float)num, 1f, color);
		Rendering.RectFilled(Head.x - Width / 2f, Head.y + Height - (float)num2 - 3f, 1f, (float)num2, color);
		Rendering.RectFilled(Head.x + Width / 2f - (float)num, Head.y + Height - 3f, (float)num, 1f, color);
		Rendering.RectFilled(Head.x + Width / 2f, Head.y + Height - (float)num2 - 3f, 1f, (float)(num2 + 1), color);
	}

	// Token: 0x06000067 RID: 103 RVA: 0x000079B0 File Offset: 0x00005BB0
	public static void DrawString1(Vector2 pos, string text, Color color, bool center = true, int size = 12, FontStyle fontStyle = FontStyle.Bold, int depth = 1)
	{
		Rendering.smethod_16(Rendering.style, size);
		Rendering.smethod_34(Rendering.style, true);
		Rendering.smethod_35(Rendering.style, Rendering.tahoma);
		Rendering.smethod_37(Rendering.smethod_36(Rendering.style), color);
		Rendering.smethod_17(Rendering.style, fontStyle);
		Rendering.smethod_16(Rendering.outlineStyle, size);
		Rendering.smethod_34(Rendering.outlineStyle, true);
		Rendering.smethod_35(Rendering.outlineStyle, Rendering.tahoma);
		Rendering.smethod_36(Rendering.outlineStyle).textColor = new Color(0f, 0f, 0f, 1f);
		Rendering.outlineStyle.fontStyle = fontStyle;
		GUIContent content = new GUIContent(text);
		GUIContent content2 = new GUIContent(text);
		if (center)
		{
			pos.x -= Rendering.style.CalcSize(content).x / 2f;
		}
		switch (depth)
		{
		case 0:
			GUI.Label(new Rect(pos.x, pos.y, 300f, 25f), content, Rendering.style);
			break;
		case 1:
			GUI.Label(new Rect(pos.x + 1f, pos.y + 1f, 300f, 25f), content2, Rendering.outlineStyle);
			GUI.Label(new Rect(pos.x, pos.y, 300f, 25f), content, Rendering.style);
			break;
		case 2:
			GUI.Label(new Rect(pos.x + 1f, pos.y + 1f, 300f, 25f), content2, Rendering.outlineStyle);
			GUI.Label(new Rect(pos.x - 1f, pos.y - 1f, 300f, 25f), content2, Rendering.outlineStyle);
			GUI.Label(new Rect(pos.x, pos.y, 300f, 25f), content, Rendering.style);
			break;
		case 3:
			GUI.Label(new Rect(pos.x + 1f, pos.y + 1f, 300f, 25f), content2, Rendering.outlineStyle);
			GUI.Label(new Rect(pos.x - 1f, pos.y - 1f, 300f, 25f), content2, Rendering.outlineStyle);
			GUI.Label(new Rect(pos.x, pos.y - 1f, 300f, 25f), content2, Rendering.outlineStyle);
			GUI.Label(new Rect(pos.x, pos.y + 1f, 300f, 25f), content2, Rendering.outlineStyle);
			GUI.Label(new Rect(pos.x, pos.y, 300f, 25f), content, Rendering.style);
			break;
		}
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00007CA4 File Offset: 0x00005EA4
	public static void DrawHealth11(Vector2 pos, float health, bool center = false)
	{
		if (center)
		{
			pos -= new Vector2(26f, 0f);
		}
		pos += new Vector2(0f, 18f);
		Rendering.BoxRect(new Rect(pos.x, pos.y, 52f, 5f), Color.black);
		pos += new Vector2(1f, 1f);
		Color color = Color.green;
		if (health <= 50f)
		{
			color = Color.yellow;
		}
		if (health <= 25f)
		{
			color = Color.red;
		}
		Rendering.BoxRect(new Rect(pos.x, pos.y, 0.5f * health, 3f), color);
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00007D70 File Offset: 0x00005F70
	public static void DrawVerticalHealth(Vector2 Head, float Width, float Height, float health)
	{
		float num = health / Height / 100f;
		if (num < 1f || num < 0f)
		{
		}
		if (health > 0f)
		{
			Color color = Color.green;
			if (health < 70f)
			{
				color = Color.yellow;
			}
			if (health < 50f)
			{
				color = new Color(1f, 0.7f, 0.16f, 1f);
			}
			if (health < 25f)
			{
				color = Color.red;
			}
			if (health <= 0f)
			{
				color = Color.clear;
			}
			Rendering.DrawString1(new Vector2(Head.x, Head.y - 30f), (int)health + "♥", color, true, 10, FontStyle.Bold, 3);
		}
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00007E3C File Offset: 0x0000603C
	public static void RectFilled(float x, float y, float width, float height, Color color)
	{
		if (color != Rendering.textureColor)
		{
			Rendering.textureColor = color;
			Rendering.smethod_14(Rendering.texture, 0, 0, color);
			Rendering.smethod_15(Rendering.texture);
		}
		GUI.DrawTexture(new Rect(x, y, width, height), Rendering.texture);
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00007E8C File Offset: 0x0000608C
	public static void DrawLineStretched(Vector2 lineStart, Vector2 lineEnd, Texture2D texture, float thickness)
	{
		Vector2 vector = lineEnd - lineStart;
		float num = 57.29578f * Mathf.Atan(vector.y / vector.x);
		if (vector.x < 0f)
		{
			num += 180f;
		}
		if (thickness < 1f)
		{
			thickness = 1f;
		}
		int num2 = (int)Mathf.Ceil(thickness / 2f);
		Rendering.smethod_38(num, lineStart);
		GUI.DrawTexture(new Rect(lineStart.x, lineStart.y - (float)num2, vector.magnitude, thickness), texture);
		GUIUtility.RotateAroundPivot(-num, lineStart);
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00007F24 File Offset: 0x00006124
	public static void DrawBox1(Vector2 pos, Vector2 size, Color color)
	{
		if (!Rendering.smethod_39(Rendering.figTex))
		{
			Rendering.figTex = Rendering.smethod_22(1, 1);
		}
		if (color != Rendering.lfgColor)
		{
			Rendering.smethod_14(Rendering.figTex, 0, 0, color);
			Rendering.smethod_15(Rendering.figTex);
			Rendering.lfgColor = color;
		}
		GUI.DrawTexture(new Rect(pos.x, pos.y, size.x, size.y), Rendering.figTex);
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00007FA0 File Offset: 0x000061A0
	public static void DrawBoxOutlines(Vector2 position, Vector2 size, float borderSize, Color color)
	{
		Rendering.DrawBox1(new Vector2(position.x + borderSize, position.y), new Vector2(size.x - 2f * borderSize, borderSize), color);
		Rendering.DrawBox1(new Vector2(position.x, position.y), new Vector2(borderSize, size.y), color);
		Rendering.DrawBox1(new Vector2(position.x + size.x - borderSize, position.y), new Vector2(borderSize, size.y), color);
		Rendering.DrawBox1(new Vector2(position.x + borderSize, position.y + size.y - borderSize), new Vector2(size.x - 2f * borderSize, borderSize), color);
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00008060 File Offset: 0x00006260
	public static void DrawBox(Vector2 pos, Vector2 size, float thick, Color color, bool ducked = false)
	{
		if (ducked)
		{
			size.y *= 0.611f;
			pos.y -= 1.5f;
		}
		Rendering.BoxRect(new Rect(pos.x, pos.y, size.x, thick), color);
		Rendering.BoxRect(new Rect(pos.x, pos.y, thick, size.y), color);
		Rendering.BoxRect(new Rect(pos.x + size.x, pos.y, thick, size.y), color);
		Rendering.BoxRect(new Rect(pos.x, pos.y + size.y, size.x + thick, thick), color);
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00008120 File Offset: 0x00006320
	public static void FullBox(Vector2 Head, float Width, float Height, float thickness, int distance, Color color, bool outline = false, bool ducked = false)
	{
		if (outline)
		{
			Rendering.RectFilled(Head.x - Width / 2f - 1f, Head.y - 1f, 3f, Height, Color.black);
			Rendering.RectFilled(Head.x + Width / 2f - 1f, Head.y - 1f, 3f, Height, Color.black);
			Rendering.RectFilled(Head.x - Width / 2f - 1f, Head.y - 1f, Width, 3f, Color.black);
			Rendering.RectFilled(Head.x - Width / 2f - 1f, Head.y + Height - 4f, Width, 3f, Color.black);
		}
		Rendering.RectFilled(Head.x - Width / 2f, Head.y, 1f, Height - 2f, color);
		Rendering.RectFilled(Head.x + Width / 2f, Head.y, 1f, Height - 2f, color);
		Rendering.RectFilled(Head.x - Width / 2f, Head.y, Width, 1f, color);
		Rendering.RectFilled(Head.x - Width / 2f, Head.y + Height - 3f, Width, 1f, color);
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00007CA4 File Offset: 0x00005EA4
	public static void DrawHealth1(Vector2 pos, float health, bool center = false)
	{
		if (center)
		{
			pos -= new Vector2(26f, 0f);
		}
		pos += new Vector2(0f, 18f);
		Rendering.BoxRect(new Rect(pos.x, pos.y, 52f, 5f), Color.black);
		pos += new Vector2(1f, 1f);
		Color color = Color.green;
		if (health <= 50f)
		{
			color = Color.yellow;
		}
		if (health <= 25f)
		{
			color = Color.red;
		}
		Rendering.BoxRect(new Rect(pos.x, pos.y, 0.5f * health, 3f), color);
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00008290 File Offset: 0x00006490
	public static void DrawString(Vector2 pos, string text, Color color, bool center = true, int size = 12, bool outline = false, int lines = 1)
	{
		Rendering.smethod_16(Rendering.guistyle_0, size);
		Rendering.smethod_37(Rendering.smethod_36(Rendering.guistyle_0), color);
		GUIContent guicontent_ = Rendering.smethod_18(text);
		if (center)
		{
			pos.x -= Rendering.smethod_19(Rendering.guistyle_0, guicontent_).x / 2f;
		}
		Rect rect = new Rect(pos.x, pos.y, 300f, (float)lines * 25f);
		if (outline)
		{
			Rendering.DrawOutlinedString(rect, text, color);
		}
		else
		{
			Rendering.smethod_40(rect, guicontent_, Rendering.guistyle_0);
		}
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00006F1C File Offset: 0x0000511C
	public static void DrawStringthuglife(Vector2 pos, string text, Color color, bool center = true, int size = 12, bool stroke = true)
	{
		Rendering.smethod_16(Rendering.guistyle_0, size);
		Rendering.smethod_17(Rendering.guistyle_0, FontStyle.Bold);
		GUIContent guicontent = Rendering.smethod_18(text);
		if (center)
		{
			pos.x -= Rendering.smethod_19(Rendering.guistyle_0, guicontent).x / 2f;
		}
		if (stroke)
		{
			Rendering.smethod_11(Color.black);
			GUI.Label(new Rect(pos.x - 1f, pos.y, 300f, 25f), guicontent, Rendering.guistyle_0);
			GUI.Label(new Rect(pos.x + 1f, pos.y, 300f, 25f), guicontent, Rendering.guistyle_0);
			GUI.Label(new Rect(pos.x, pos.y - 1f, 300f, 25f), guicontent, Rendering.guistyle_0);
			GUI.Label(new Rect(pos.x, pos.y + 1f, 300f, 25f), guicontent, Rendering.guistyle_0);
		}
		GUI.color = color;
		GUI.Label(new Rect(pos.x, pos.y, 300f, 25f), guicontent, Rendering.guistyle_0);
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00008324 File Offset: 0x00006524
	public static void DrawWatermark(string text, Color color, int size = 12)
	{
		Rendering.smethod_16(Rendering.guistyle_0, size);
		Rendering.smethod_37(Rendering.smethod_36(Rendering.guistyle_0), color);
		GUIContent content = Rendering.smethod_18(text);
		GUI.Label(new Rect(1f, 1f, 300f, 25f), content, Rendering.guistyle_0);
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00008378 File Offset: 0x00006578
	public static void DrawWatermark2(string text, Color color, int size = 12)
	{
		Rendering.smethod_16(Rendering.guistyle_0, size);
		Rendering.smethod_37(Rendering.smethod_36(Rendering.guistyle_0), color);
		GUIContent content = Rendering.smethod_18(text);
		GUI.Label(new Rect(250f, 250f, 300f, 25f), content, Rendering.guistyle_0);
	}

	// Token: 0x06000075 RID: 117 RVA: 0x000083CC File Offset: 0x000065CC
	public static void DrawOutlinedString(Rect rect, string text, Color color)
	{
		GUIStyle guistyle = Rendering.guistyle_0;
		Rendering.smethod_37(Rendering.smethod_36(Rendering.guistyle_0), Color.black);
		float num = rect.x;
		rect.x = num - 1f;
		GUI.Label(rect, text, Rendering.guistyle_0);
		rect.x += 2f;
		GUI.Label(rect, text, Rendering.guistyle_0);
		num = rect.x;
		rect.x = num - 1f;
		num = rect.y;
		rect.y = num - 1f;
		GUI.Label(rect, text, Rendering.guistyle_0);
		rect.y += 2f;
		GUI.Label(rect, text, Rendering.guistyle_0);
		num = rect.y;
		rect.y = num - 1f;
		Rendering.guistyle_0.normal.textColor = color;
		GUI.Label(rect, text, Rendering.guistyle_0);
		Rendering.guistyle_0 = guistyle;
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00003F62 File Offset: 0x00002162
	static bool smethod_0(UnityEngine.Object object_0, UnityEngine.Object object_1)
	{
		return object_0 == object_1;
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00003F6B File Offset: 0x0000216B
	static Shader smethod_1(string string_0)
	{
		return Shader.Find(string_0);
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00003F73 File Offset: 0x00002173
	static Material smethod_2(Shader shader_0)
	{
		return new Material(shader_0);
	}

	// Token: 0x0600007A RID: 122 RVA: 0x00003F7B File Offset: 0x0000217B
	static Material smethod_3(string string_0)
	{
		return new Material(string_0);
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00003F83 File Offset: 0x00002183
	static void smethod_4(Material material_0, Material material_1)
	{
		material_0.CopyPropertiesFromMaterial(material_1);
	}

	// Token: 0x0600007C RID: 124 RVA: 0x00003F8C File Offset: 0x0000218C
	static void smethod_5(UnityEngine.Object object_0, HideFlags hideFlags_0)
	{
		object_0.hideFlags = hideFlags_0;
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00003F95 File Offset: 0x00002195
	static Shader smethod_6(Material material_0)
	{
		return material_0.shader;
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00003F9D File Offset: 0x0000219D
	static void smethod_7(Material material_0, string string_0, int int_0)
	{
		material_0.SetInt(string_0, int_0);
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00003FA7 File Offset: 0x000021A7
	static void smethod_8(Material material_0, Color color_1)
	{
		material_0.color = color_1;
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00003FB0 File Offset: 0x000021B0
	static void smethod_9()
	{
		GL.PushMatrix();
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00003FB7 File Offset: 0x000021B7
	static void smethod_10(Matrix4x4 matrix4x4_0)
	{
		GL.MultMatrix(matrix4x4_0);
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00003FBF File Offset: 0x000021BF
	static void smethod_11(Color color_1)
	{
		GUI.color = color_1;
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00003FC7 File Offset: 0x000021C7
	static void smethod_12(Rect rect_0, Texture texture_0)
	{
		GUI.DrawTexture(rect_0, texture_0);
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00003FD0 File Offset: 0x000021D0
	static void smethod_13()
	{
		GL.PopMatrix();
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00003FD7 File Offset: 0x000021D7
	static void smethod_14(Texture2D texture2D_1, int int_0, int int_1, Color color_1)
	{
		texture2D_1.SetPixel(int_0, int_1, color_1);
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00003FE2 File Offset: 0x000021E2
	static void smethod_15(Texture2D texture2D_1)
	{
		texture2D_1.Apply();
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00003FEA File Offset: 0x000021EA
	static void smethod_16(GUIStyle guistyle_1, int int_0)
	{
		guistyle_1.fontSize = int_0;
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00003FF3 File Offset: 0x000021F3
	static void smethod_17(GUIStyle guistyle_1, FontStyle fontStyle_0)
	{
		guistyle_1.fontStyle = fontStyle_0;
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00003FFC File Offset: 0x000021FC
	static GUIContent smethod_18(string string_0)
	{
		return new GUIContent(string_0);
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00004004 File Offset: 0x00002204
	static Vector2 smethod_19(GUIStyle guistyle_1, GUIContent guicontent_0)
	{
		return guistyle_1.CalcSize(guicontent_0);
	}

	// Token: 0x0600008B RID: 139 RVA: 0x0000400D File Offset: 0x0000220D
	static bool smethod_20(UnityEngine.Object object_0, UnityEngine.Object object_1)
	{
		return object_0 != object_1;
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00004016 File Offset: 0x00002216
	static void smethod_21(Texture texture_0, TextureWrapMode textureWrapMode_0)
	{
		texture_0.wrapMode = textureWrapMode_0;
	}

	// Token: 0x0600008D RID: 141 RVA: 0x0000401F File Offset: 0x0000221F
	static Texture2D smethod_22(int int_0, int int_1)
	{
		return new Texture2D(int_0, int_1);
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00004028 File Offset: 0x00002228
	static Color[] smethod_23(Texture2D texture2D_1)
	{
		return texture2D_1.GetPixels();
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00004030 File Offset: 0x00002230
	static void smethod_24(Texture2D texture2D_1, Color[] color_1)
	{
		texture2D_1.SetPixels(color_1);
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00004039 File Offset: 0x00002239
	static bool smethod_25(Material material_0, int int_0)
	{
		return material_0.SetPass(int_0);
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00004042 File Offset: 0x00002242
	static void smethod_26(int int_0)
	{
		GL.Begin(int_0);
	}

	// Token: 0x06000092 RID: 146 RVA: 0x0000404A File Offset: 0x0000224A
	static void smethod_27(Color color_1)
	{
		GL.Color(color_1);
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00004052 File Offset: 0x00002252
	static void smethod_28(float float_0, float float_1, float float_2)
	{
		GL.Vertex3(float_0, float_1, float_2);
	}

	// Token: 0x06000094 RID: 148 RVA: 0x0000405C File Offset: 0x0000225C
	static void smethod_29()
	{
		GL.End();
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00004063 File Offset: 0x00002263
	static GUISkin smethod_30()
	{
		return GUI.skin;
	}

	// Token: 0x06000096 RID: 150 RVA: 0x0000406A File Offset: 0x0000226A
	static GUIStyle smethod_31(GUISkin guiskin_0)
	{
		return guiskin_0.label;
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00004072 File Offset: 0x00002272
	static GUIStyle smethod_32(GUIStyle guistyle_1)
	{
		return new GUIStyle(guistyle_1);
	}

	// Token: 0x06000098 RID: 152 RVA: 0x0000407A File Offset: 0x0000227A
	static Font smethod_33(string string_0, int int_0)
	{
		return Font.CreateDynamicFontFromOSFont(string_0, int_0);
	}

	// Token: 0x06000099 RID: 153 RVA: 0x00004083 File Offset: 0x00002283
	static void smethod_34(GUIStyle guistyle_1, bool bool_0)
	{
		guistyle_1.richText = bool_0;
	}

	// Token: 0x0600009A RID: 154 RVA: 0x0000408C File Offset: 0x0000228C
	static void smethod_35(GUIStyle guistyle_1, Font font_0)
	{
		guistyle_1.font = font_0;
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00004095 File Offset: 0x00002295
	static GUIStyleState smethod_36(GUIStyle guistyle_1)
	{
		return guistyle_1.normal;
	}

	// Token: 0x0600009C RID: 156 RVA: 0x0000409D File Offset: 0x0000229D
	static void smethod_37(GUIStyleState guistyleState_0, Color color_1)
	{
		guistyleState_0.textColor = color_1;
	}

	// Token: 0x0600009D RID: 157 RVA: 0x000040A6 File Offset: 0x000022A6
	static void smethod_38(float float_0, Vector2 vector2_0)
	{
		GUIUtility.RotateAroundPivot(float_0, vector2_0);
	}

	// Token: 0x0600009E RID: 158 RVA: 0x000040AF File Offset: 0x000022AF
	static bool smethod_39(UnityEngine.Object object_0)
	{
		return object_0;
	}

	// Token: 0x0600009F RID: 159 RVA: 0x000040B7 File Offset: 0x000022B7
	static void smethod_40(Rect rect_0, GUIContent guicontent_0, GUIStyle guistyle_1)
	{
		GUI.Label(rect_0, guicontent_0, guistyle_1);
	}

	// Token: 0x04000044 RID: 68
	private static Color color_0;

	// Token: 0x04000045 RID: 69
	private static GUIStyle guistyle_0 = Rendering.smethod_32(Rendering.smethod_31(Rendering.smethod_30()));

	// Token: 0x04000046 RID: 70
	private static Texture2D texture2D_0 = Rendering.smethod_22(1, 1);

	// Token: 0x04000047 RID: 71
	private static Texture2D figTex;

	// Token: 0x04000048 RID: 72
	private static Color lfgColor;

	// Token: 0x04000049 RID: 73
	private static Color textureColor;

	// Token: 0x0400004A RID: 74
	public static Font tahoma = Rendering.smethod_33("Tahoma", 12);

	// Token: 0x0400004B RID: 75
	private static Texture2D aaLineTex = null;

	// Token: 0x0400004C RID: 76
	private static Texture2D lineTex = null;

	// Token: 0x0400004D RID: 77
	private static Material blitMaterial = null;

	// Token: 0x0400004E RID: 78
	private static Material blendMaterial = null;

	// Token: 0x0400004F RID: 79
	private static Rect lineRect = new Rect(0f, 0f, 1f, 1f);

	// Token: 0x04000050 RID: 80
	private static Material lineMaterial = null;

	// Token: 0x04000051 RID: 81
	private static Color outlineColor = new Color(0f, 0f, 0f, 1f);

	// Token: 0x04000052 RID: 82
	private static Texture2D texture = new Texture2D(1, 1);

	// Token: 0x04000053 RID: 83
	private static GUIStyle style = new GUIStyle(GUI.skin.label)
	{
		fontSize = 12
	};

	// Token: 0x04000054 RID: 84
	private static GUIStyle outlineStyle = new GUIStyle(GUI.skin.label)
	{
		fontSize = 12
	};

	// Token: 0x04000055 RID: 85
	public static Color32 WallHackColor = new Color32(156, 39, 176, byte.MaxValue);

	// Token: 0x04000056 RID: 86
	public static Texture2D myTexture;

	// Token: 0x04000057 RID: 87
	public static Material[] ChamMats;

	// Token: 0x04000058 RID: 88
	public static Material wallhackMaterial;
}
