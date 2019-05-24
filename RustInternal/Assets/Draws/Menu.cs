using System;
using System.Collections.Generic;
using System.Linq;
using Assets.Draws.Native;
using Assets.Other;
using UnityEngine;

namespace Assets.Draws
{
	// Token: 0x02000012 RID: 18
	internal class Menu
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x000085BC File Offset: 0x000067BC
		public void Update()
		{
			FPSController.Update();
			if (Menu.smethod_0(KeyCode.End))
			{
				this.Enabled = !this.Enabled;
			}
			if (this.Enabled)
			{
				if (this.SelectedOption == null)
				{
					this.SelectedOption = this.Opts[this.SelectedIndex];
				}
				if (Menu.smethod_0(KeyCode.UpArrow))
				{
					int num = this.SelectedIndex - 1;
					if (this.VisibleOpts.ElementAtOrDefault(num) != null)
					{
						this.SelectedIndex = num;
					}
					else
					{
						this.SelectedIndex = this.VisibleOpts.Count - 1;
					}
					this.SelectedOption = this.VisibleOpts[this.SelectedIndex];
				}
				if (Menu.smethod_0(KeyCode.DownArrow))
				{
					int num2 = this.SelectedIndex + 1;
					if (this.VisibleOpts.ElementAtOrDefault(num2) == null)
					{
						this.SelectedIndex = 0;
					}
					else
					{
						this.SelectedIndex = num2;
					}
					this.SelectedOption = this.VisibleOpts[this.SelectedIndex];
				}
				switch (this.SelectedOption.Type)
				{
				case Menu.Option.OptType.Toggle:
				case Menu.Option.OptType.Category:
					if (Menu.smethod_0(KeyCode.RightArrow) || Menu.smethod_0(KeyCode.LeftArrow))
					{
						this.SelectedOption.Data = !this.SelectedOption.GetData<bool>();
					}
					break;
				case Menu.Option.OptType.Selector:
					if (Menu.smethod_0(KeyCode.RightArrow) || Menu.smethod_0(KeyCode.LeftArrow))
					{
						List<object> subContent = this.SelectedOption.GetSubContent<List<object>>();
						if (Menu.smethod_0(KeyCode.RightArrow))
						{
							int num3 = this.SelectedOption.GetData<int>() + 1;
							if (subContent.ElementAtOrDefault(num3) != null)
							{
								this.SelectedOption.Data = num3;
							}
							else
							{
								this.SelectedOption.Data = 0;
							}
						}
						if (Menu.smethod_0(KeyCode.LeftArrow))
						{
							int num4 = this.SelectedOption.GetData<int>() - 1;
							if (subContent.ElementAtOrDefault(num4) == null)
							{
								this.SelectedOption.Data = subContent.Count - 1;
							}
							else
							{
								this.SelectedOption.Data = num4;
							}
						}
					}
					break;
				case Menu.Option.OptType.Text:
					if (Menu.smethod_0(KeyCode.RightArrow) || Menu.smethod_0(KeyCode.LeftArrow))
					{
						this.SelectedOption.CustomColor = ColorFix.RGBColor(Menu.smethod_1(100f, 255f), Menu.smethod_1(100f, 255f), Menu.smethod_1(100f, 255f));
					}
					break;
				}
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00008854 File Offset: 0x00006A54
		public void OnGUI()
		{
			if (this.Enabled)
			{
				if (!Menu.smethod_2(this.BTexture))
				{
					this.BTexture = Menu.smethod_3(1, 1);
					Menu.smethod_4(this.BTexture, 0, 0, this.BackColor);
					Menu.smethod_5(this.BTexture, TextureWrapMode.Repeat);
					Menu.smethod_6(this.BTexture);
					this.BackStyle = Menu.smethod_7();
					Menu.smethod_9(Menu.smethod_8(this.BackStyle), this.BTexture);
				}
				if (this.NumberOfVisibleElements == 0)
				{
					this.NumberOfVisibleElements = this.Opts.Count;
				}
				this.VisibleOpts.Clear();
				this.BoxRect.width = 200f;
				this.BoxRect.height = 24f + 21f * (float)this.NumberOfVisibleElements;
				GUI.Box(this.BoxRect, GUIContent.none, this.BackStyle);
				GUI.Label(new Rect(this.BoxRect.x + 60f, this.BoxRect.y, this.BoxRect.width, this.BoxRect.height), "BIRKA HOOK PASTA");
				GUI.color = Color.white;
				int num = 0;
				for (int i = 0; i < this.Opts.Count; i++)
				{
					Menu.Option opt = this.Opts[i];
					this.DrawElement(ref num, opt, 1);
					num++;
				}
				this.NumberOfVisibleElements = num;
				GUI.Label(new Rect(new Vector2(this.BoxRect.x + 125f, this.BoxRect.y + 24f + 21f * (float)num + 3.3f), new Vector2(100f, 100f)), FPSController.GetAsString());
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00008A20 File Offset: 0x00006C20
		public void DrawElement(ref int i, Menu.Option opt, int cLevel)
		{
			this.VisibleOpts.Add(opt);
			Rect position = new Rect(this.BoxRect.x + (float)cLevel * 5f, this.BoxRect.y + 24f + 21f * (float)i, 200f, 30f);
			Rect position2 = new Rect(this.BoxRect.x + this.BoxRect.width - 25f, this.BoxRect.y + 24f + 21f * (float)i, 200f, 30f);
			if (this.SelectedOption == opt)
			{
				if (!this.SelectedOption.CustomColor.Equals(Color.black))
				{
					GUI.color = this.SelectedOption.CustomColor;
				}
				else
				{
					GUI.color = this.BaseColor;
				}
			}
			switch (opt.Type)
			{
			case Menu.Option.OptType.Toggle:
				GUI.Label(position, opt.Name);
				if (!opt.GetData<bool>())
				{
					GUI.Label(position2, "No");
				}
				else
				{
					GUI.Label(position2, "Yes");
				}
				break;
			case Menu.Option.OptType.Selector:
			{
				GUI.Label(position, opt.Name);
				object obj = opt.GetSubContent<List<object>>().ElementAtOrDefault(opt.GetData<int>());
				if (obj != null && obj.GetType() == typeof(Color))
				{
					GUI.color = (Color)obj;
				}
				if (obj.GetType() == typeof(KeyCode))
				{
					position2.x -= 50f;
					GUI.Label(position2, "[" + opt.GetSubContent<List<object>>().ElementAtOrDefault(opt.GetData<int>()).ToString() + "]");
				}
				else
				{
					GUI.Label(position2, "[" + opt.GetData<int>().ToString() + "]");
				}
				if (obj != null && obj.GetType() == typeof(Color))
				{
					GUI.color = Color.white;
				}
				break;
			}
			case Menu.Option.OptType.Text:
				GUI.Label(position, opt.Name);
				break;
			case Menu.Option.OptType.Category:
				GUI.Label(position, "> " + opt.Name);
				if (opt.GetData<bool>())
				{
					GUI.Label(position2, "-");
					cLevel++;
					using (List<Menu.Option>.Enumerator enumerator = opt.Items.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Menu.Option opt2 = enumerator.Current;
							i++;
							GUI.color = Color.white;
							this.DrawElement(ref i, opt2, cLevel);
						}
						break;
					}
				}
				GUI.Label(position2, "+");
				break;
			}
			if (this.SelectedOption == opt)
			{
				GUI.color = Color.white;
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000040FC File Offset: 0x000022FC
		static bool smethod_0(KeyCode keyCode_0)
		{
			return Input.GetKeyDown(keyCode_0);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00004104 File Offset: 0x00002304
		static float smethod_1(float float_0, float float_1)
		{
			return UnityEngine.Random.Range(float_0, float_1);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000040AF File Offset: 0x000022AF
		static bool smethod_2(UnityEngine.Object object_0)
		{
			return object_0;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000401F File Offset: 0x0000221F
		static Texture2D smethod_3(int int_0, int int_1)
		{
			return new Texture2D(int_0, int_1);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00003FD7 File Offset: 0x000021D7
		static void smethod_4(Texture2D texture2D_0, int int_0, int int_1, Color color_0)
		{
			texture2D_0.SetPixel(int_0, int_1, color_0);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00004016 File Offset: 0x00002216
		static void smethod_5(Texture texture_0, TextureWrapMode textureWrapMode_0)
		{
			texture_0.wrapMode = textureWrapMode_0;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00003FE2 File Offset: 0x000021E2
		static void smethod_6(Texture2D texture2D_0)
		{
			texture2D_0.Apply();
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000410D File Offset: 0x0000230D
		static GUIStyle smethod_7()
		{
			return new GUIStyle();
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00004095 File Offset: 0x00002295
		static GUIStyleState smethod_8(GUIStyle guistyle_0)
		{
			return guistyle_0.normal;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00004114 File Offset: 0x00002314
		static void smethod_9(GUIStyleState guistyleState_0, Texture2D texture2D_0)
		{
			guistyleState_0.background = texture2D_0;
		}

		// Token: 0x0400005A RID: 90
		public bool Enabled = true;

		// Token: 0x0400005B RID: 91
		public List<Menu.Option> Opts = new List<Menu.Option>();

		// Token: 0x0400005C RID: 92
		private Rect BoxRect = new Rect(10f, 10f, 0f, 0f);

		// Token: 0x0400005D RID: 93
		private Texture2D BTexture;

		// Token: 0x0400005E RID: 94
		private int SelectedIndex = 0;

		// Token: 0x0400005F RID: 95
		public Menu.Option SelectedOption = null;

		// Token: 0x04000060 RID: 96
		private Color BackColor = ColorFix.RGBColor(44f, 44f, 44f);

		// Token: 0x04000061 RID: 97
		private Color BaseColor = ColorFix.RGBColor(255f, 140f, 0f);

		// Token: 0x04000062 RID: 98
		private Color BoxColor = ColorFix.RGBColor(42f, 42f, 42f);

		// Token: 0x04000063 RID: 99
		private int NumberOfVisibleElements = 0;

		// Token: 0x04000064 RID: 100
		private List<Menu.Option> VisibleOpts = new List<Menu.Option>();

		// Token: 0x04000065 RID: 101
		private GUIStyle BackStyle = null;

		// Token: 0x02000013 RID: 19
		internal class Option
		{
			// Token: 0x060000B4 RID: 180 RVA: 0x0000411D File Offset: 0x0000231D
			public Option(string name, Menu.Option.OptType type, object data)
			{
				this.Name = name;
				this.Type = type;
				this.Data = data;
			}

			// Token: 0x060000B5 RID: 181 RVA: 0x00008D14 File Offset: 0x00006F14
			public T GetData<T>()
			{
				T result;
				if (this.Data is T)
				{
					result = (T)((object)this.Data);
				}
				else
				{
					try
					{
						result = (T)((object)Menu.Option.smethod_1(this.Data, Menu.Option.smethod_0(typeof(T).TypeHandle)));
					}
					catch (InvalidCastException)
					{
						result = default(T);
					}
				}
				return result;
			}

			// Token: 0x060000B6 RID: 182 RVA: 0x00008D7C File Offset: 0x00006F7C
			public T GetSubContent<T>()
			{
				if (!(this.SubContent is T))
				{
					try
					{
						return (T)((object)Menu.Option.smethod_1(this.SubContent, Menu.Option.smethod_0(typeof(T).TypeHandle)));
					}
					catch (InvalidCastException)
					{
						return default(T);
					}
				}
				return (T)((object)this.SubContent);
			}

			// Token: 0x060000B7 RID: 183 RVA: 0x00003E9E File Offset: 0x0000209E
			static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0)
			{
				return System.Type.GetTypeFromHandle(runtimeTypeHandle_0);
			}

			// Token: 0x060000B8 RID: 184 RVA: 0x00004150 File Offset: 0x00002350
			static object smethod_1(object object_0, Type type_0)
			{
				return Convert.ChangeType(object_0, type_0);
			}

			// Token: 0x04000066 RID: 102
			public string Name;

			// Token: 0x04000067 RID: 103
			public Menu.Option.OptType Type;

			// Token: 0x04000068 RID: 104
			public object Data;

			// Token: 0x04000069 RID: 105
			public object SubContent;

			// Token: 0x0400006A RID: 106
			public Color CustomColor = Color.black;

			// Token: 0x0400006B RID: 107
			public List<Menu.Option> Items = new List<Menu.Option>();

			// Token: 0x02000014 RID: 20
			public enum OptType
			{
				// Token: 0x0400006D RID: 109
				Toggle,
				// Token: 0x0400006E RID: 110
				Selector,
				// Token: 0x0400006F RID: 111
				Text,
				// Token: 0x04000070 RID: 112
				Category
			}
		}
	}
}
