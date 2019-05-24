using System;
using System.IO;

// Token: 0x02000001 RID: 1
internal class <Module>
{
	// Token: 0x06000001 RID: 1 RVA: 0x00004D24 File Offset: 0x00002F24
	internal static byte[] smethod_0(byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream(byte_0);
		<Module>.Class2 @class = new <Module>.Class2();
		byte[] array = new byte[5];
		memoryStream.Read(array, 0, 5);
		@class.method_5(array);
		long num = 0L;
		for (int i = 0; i < 8; i++)
		{
			int num2 = memoryStream.ReadByte();
			num |= (long)((long)((ulong)((byte)num2)) << 8 * i);
		}
		byte[] array2 = new byte[(int)num];
		MemoryStream stream_ = new MemoryStream(array2, true);
		long long_ = memoryStream.Length - 13L;
		@class.method_4(memoryStream, stream_, long_, num);
		return array2;
	}

	// Token: 0x02000002 RID: 2
	internal struct Struct0
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00003C04 File Offset: 0x00001E04
		internal void method_0()
		{
			this.uint_0 = 1024u;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00004DBC File Offset: 0x00002FBC
		internal uint method_1(<Module>.Class1 class1_0)
		{
			uint num = (class1_0.uint_1 >> 11) * this.uint_0;
			if (class1_0.uint_0 < num)
			{
				class1_0.uint_1 = num;
				this.uint_0 += 2048u - this.uint_0 >> 5;
				if (class1_0.uint_1 < 16777216u)
				{
					class1_0.uint_0 = (class1_0.uint_0 << 8 | (uint)((byte)class1_0.stream_0.ReadByte()));
					class1_0.uint_1 <<= 8;
				}
				return 0u;
			}
			class1_0.uint_1 -= num;
			class1_0.uint_0 -= num;
			this.uint_0 -= this.uint_0 >> 5;
			if (class1_0.uint_1 < 16777216u)
			{
				class1_0.uint_0 = (class1_0.uint_0 << 8 | (uint)((byte)class1_0.stream_0.ReadByte()));
				class1_0.uint_1 <<= 8;
			}
			return 1u;
		}

		// Token: 0x04000001 RID: 1
		internal uint uint_0;
	}

	// Token: 0x02000003 RID: 3
	internal struct Struct1
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00003C11 File Offset: 0x00001E11
		internal Struct1(int int_1)
		{
			this.int_0 = int_1;
			this.struct0_0 = new <Module>.Struct0[1 << int_1];
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00004EA8 File Offset: 0x000030A8
		internal void method_0()
		{
			uint num = 1u;
			while ((ulong)num < (ulong)(1L << (this.int_0 & 31)))
			{
				this.struct0_0[(int)((UIntPtr)num)].method_0();
				num += 1u;
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00004EE0 File Offset: 0x000030E0
		internal uint method_1(<Module>.Class1 class1_0)
		{
			uint num = 1u;
			for (int i = this.int_0; i > 0; i--)
			{
				num = (num << 1) + this.struct0_0[(int)((UIntPtr)num)].method_1(class1_0);
			}
			return num - (1u << this.int_0);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00004F28 File Offset: 0x00003128
		internal uint method_2(<Module>.Class1 class1_0)
		{
			uint num = 1u;
			uint num2 = 0u;
			for (int i = 0; i < this.int_0; i++)
			{
				uint num3 = this.struct0_0[(int)((UIntPtr)num)].method_1(class1_0);
				num <<= 1;
				num += num3;
				num2 |= num3 << i;
			}
			return num2;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00004F70 File Offset: 0x00003170
		internal static uint smethod_0(<Module>.Struct0[] struct0_1, uint uint_0, <Module>.Class1 class1_0, int int_1)
		{
			uint num = 1u;
			uint num2 = 0u;
			for (int i = 0; i < int_1; i++)
			{
				uint num3 = struct0_1[(int)((UIntPtr)(uint_0 + num))].method_1(class1_0);
				num <<= 1;
				num += num3;
				num2 |= num3 << i;
			}
			return num2;
		}

		// Token: 0x04000002 RID: 2
		internal readonly <Module>.Struct0[] struct0_0;

		// Token: 0x04000003 RID: 3
		internal readonly int int_0;
	}

	// Token: 0x02000004 RID: 4
	internal class Class1
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00004FB0 File Offset: 0x000031B0
		internal void method_0(Stream stream_1)
		{
			this.stream_0 = stream_1;
			this.uint_0 = 0u;
			this.uint_1 = uint.MaxValue;
			for (int i = 0; i < 5; i++)
			{
				this.uint_0 = (this.uint_0 << 8 | (uint)((byte)this.stream_0.ReadByte()));
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00003C2B File Offset: 0x00001E2B
		internal void method_1()
		{
			this.stream_0 = null;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00003C34 File Offset: 0x00001E34
		internal void method_2()
		{
			while (this.uint_1 < 16777216u)
			{
				this.uint_0 = (this.uint_0 << 8 | (uint)((byte)this.stream_0.ReadByte()));
				this.uint_1 <<= 8;
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00004FFC File Offset: 0x000031FC
		internal uint method_3(int int_0)
		{
			uint num = this.uint_1;
			uint num2 = this.uint_0;
			uint num3 = 0u;
			for (int i = int_0; i > 0; i--)
			{
				num >>= 1;
				uint num4 = num2 - num >> 31;
				num2 -= (num & num4 - 1u);
				num3 = (num3 << 1 | 1u - num4);
				if (num < 16777216u)
				{
					num2 = (num2 << 8 | (uint)((byte)this.stream_0.ReadByte()));
					num <<= 8;
				}
			}
			this.uint_1 = num;
			this.uint_0 = num2;
			return num3;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00003C6F File Offset: 0x00001E6F
		internal Class1()
		{
		}

		// Token: 0x04000004 RID: 4
		internal uint uint_0;

		// Token: 0x04000005 RID: 5
		internal uint uint_1;

		// Token: 0x04000006 RID: 6
		internal Stream stream_0;
	}

	// Token: 0x02000005 RID: 5
	internal class Class2
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00005070 File Offset: 0x00003270
		internal Class2()
		{
			this.uint_0 = uint.MaxValue;
			int num = 0;
			while ((long)num < 4L)
			{
				this.struct1_0[num] = new <Module>.Struct1(6);
				num++;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00005170 File Offset: 0x00003370
		internal void method_0(uint uint_3)
		{
			if (this.uint_0 != uint_3)
			{
				this.uint_0 = uint_3;
				this.uint_1 = Math.Max(this.uint_0, 1u);
				uint uint_4 = Math.Max(this.uint_1, 4096u);
				this.class5_0.method_0(uint_4);
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00003C77 File Offset: 0x00001E77
		internal void method_1(int int_0, int int_1)
		{
			this.class4_0.method_0(int_0, int_1);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000051BC File Offset: 0x000033BC
		internal void method_2(int int_0)
		{
			uint num = 1u << int_0;
			this.class3_0.method_0(num);
			this.class3_1.method_0(num);
			this.uint_2 = num - 1u;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000051F4 File Offset: 0x000033F4
		internal void method_3(Stream stream_0, Stream stream_1)
		{
			this.class1_0.method_0(stream_0);
			this.class5_0.method_1(stream_1, this.bool_0);
			for (uint num = 0u; num < 12u; num += 1u)
			{
				for (uint num2 = 0u; num2 <= this.uint_2; num2 += 1u)
				{
					uint num3 = (num << 4) + num2;
					this.struct0_0[(int)((UIntPtr)num3)].method_0();
					this.struct0_1[(int)((UIntPtr)num3)].method_0();
				}
				this.struct0_2[(int)((UIntPtr)num)].method_0();
				this.struct0_3[(int)((UIntPtr)num)].method_0();
				this.struct0_4[(int)((UIntPtr)num)].method_0();
				this.struct0_5[(int)((UIntPtr)num)].method_0();
			}
			this.class4_0.method_1();
			for (uint num = 0u; num < 4u; num += 1u)
			{
				this.struct1_0[(int)((UIntPtr)num)].method_0();
			}
			for (uint num = 0u; num < 114u; num += 1u)
			{
				this.struct0_6[(int)((UIntPtr)num)].method_0();
			}
			this.class3_0.method_1();
			this.class3_1.method_1();
			this.struct1_1.method_0();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00005320 File Offset: 0x00003520
		internal void method_4(Stream stream_0, Stream stream_1, long long_0, long long_1)
		{
			this.method_3(stream_0, stream_1);
			<Module>.Struct3 @struct = default(<Module>.Struct3);
			@struct.method_0();
			uint num = 0u;
			uint num2 = 0u;
			uint num3 = 0u;
			uint num4 = 0u;
			ulong num5 = 0UL;
			if (0L < long_1)
			{
				this.struct0_0[(int)((UIntPtr)(@struct.uint_0 << 4))].method_1(this.class1_0);
				@struct.method_1();
				byte byte_ = this.class4_0.method_3(this.class1_0, 0u, 0);
				this.class5_0.method_5(byte_);
				num5 += 1UL;
			}
			while (num5 < (ulong)long_1)
			{
				uint num6 = (uint)num5 & this.uint_2;
				if (this.struct0_0[(int)((UIntPtr)((@struct.uint_0 << 4) + num6))].method_1(this.class1_0) == 0u)
				{
					byte byte_2 = this.class5_0.method_6(0u);
					byte byte_3;
					if (!@struct.method_5())
					{
						byte_3 = this.class4_0.method_4(this.class1_0, (uint)num5, byte_2, this.class5_0.method_6(num));
					}
					else
					{
						byte_3 = this.class4_0.method_3(this.class1_0, (uint)num5, byte_2);
					}
					this.class5_0.method_5(byte_3);
					@struct.method_1();
					num5 += 1UL;
				}
				else
				{
					uint num8;
					if (this.struct0_2[(int)((UIntPtr)@struct.uint_0)].method_1(this.class1_0) == 1u)
					{
						if (this.struct0_3[(int)((UIntPtr)@struct.uint_0)].method_1(this.class1_0) == 0u)
						{
							if (this.struct0_1[(int)((UIntPtr)((@struct.uint_0 << 4) + num6))].method_1(this.class1_0) == 0u)
							{
								@struct.method_4();
								this.class5_0.method_5(this.class5_0.method_6(num));
								num5 += 1UL;
								continue;
							}
						}
						else
						{
							uint num7;
							if (this.struct0_4[(int)((UIntPtr)@struct.uint_0)].method_1(this.class1_0) != 0u)
							{
								if (this.struct0_5[(int)((UIntPtr)@struct.uint_0)].method_1(this.class1_0) == 0u)
								{
									num7 = num3;
								}
								else
								{
									num7 = num4;
									num4 = num3;
								}
								num3 = num2;
							}
							else
							{
								num7 = num2;
							}
							num2 = num;
							num = num7;
						}
						num8 = this.class3_1.method_2(this.class1_0, num6) + 2u;
						@struct.method_3();
					}
					else
					{
						num4 = num3;
						num3 = num2;
						num2 = num;
						num8 = 2u + this.class3_0.method_2(this.class1_0, num6);
						@struct.method_2();
						uint num9 = this.struct1_0[(int)((UIntPtr)<Module>.Class2.smethod_0(num8))].method_1(this.class1_0);
						if (num9 < 4u)
						{
							num = num9;
						}
						else
						{
							int num10 = (int)((num9 >> 1) - 1u);
							num = (2u | (num9 & 1u)) << num10;
							if (num9 >= 14u)
							{
								num += this.class1_0.method_3(num10 - 4) << 4;
								num += this.struct1_1.method_2(this.class1_0);
							}
							else
							{
								num += <Module>.Struct1.smethod_0(this.struct0_6, num - num9 - 1u, this.class1_0, num10);
							}
						}
					}
					if (((ulong)num >= num5 || num >= this.uint_1) && num == 4294967295u)
					{
						break;
					}
					this.class5_0.method_4(num, num8);
					num5 += (ulong)num8;
				}
			}
			this.class5_0.method_3();
			this.class5_0.method_2();
			this.class1_0.method_1();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00005694 File Offset: 0x00003894
		internal void method_5(byte[] byte_0)
		{
			int int_ = (int)(byte_0[0] % 9);
			int num = (int)(byte_0[0] / 9);
			int int_2 = num % 5;
			int int_3 = num / 5;
			uint num2 = 0u;
			for (int i = 0; i < 4; i++)
			{
				num2 += (uint)((uint)byte_0[1 + i] << i * 8);
			}
			this.method_0(num2);
			this.method_1(int_2, int_);
			this.method_2(int_3);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003C86 File Offset: 0x00001E86
		internal static uint smethod_0(uint uint_3)
		{
			uint_3 -= 2u;
			if (uint_3 < 4u)
			{
				return uint_3;
			}
			return 3u;
		}

		// Token: 0x04000007 RID: 7
		internal readonly <Module>.Struct0[] struct0_0 = new <Module>.Struct0[192];

		// Token: 0x04000008 RID: 8
		internal readonly <Module>.Struct0[] struct0_1 = new <Module>.Struct0[192];

		// Token: 0x04000009 RID: 9
		internal readonly <Module>.Struct0[] struct0_2 = new <Module>.Struct0[12];

		// Token: 0x0400000A RID: 10
		internal readonly <Module>.Struct0[] struct0_3 = new <Module>.Struct0[12];

		// Token: 0x0400000B RID: 11
		internal readonly <Module>.Struct0[] struct0_4 = new <Module>.Struct0[12];

		// Token: 0x0400000C RID: 12
		internal readonly <Module>.Struct0[] struct0_5 = new <Module>.Struct0[12];

		// Token: 0x0400000D RID: 13
		internal readonly <Module>.Class2.Class3 class3_0 = new <Module>.Class2.Class3();

		// Token: 0x0400000E RID: 14
		internal readonly <Module>.Class2.Class4 class4_0 = new <Module>.Class2.Class4();

		// Token: 0x0400000F RID: 15
		internal readonly <Module>.Class5 class5_0 = new <Module>.Class5();

		// Token: 0x04000010 RID: 16
		internal readonly <Module>.Struct0[] struct0_6 = new <Module>.Struct0[114];

		// Token: 0x04000011 RID: 17
		internal readonly <Module>.Struct1[] struct1_0 = new <Module>.Struct1[4];

		// Token: 0x04000012 RID: 18
		internal readonly <Module>.Class1 class1_0 = new <Module>.Class1();

		// Token: 0x04000013 RID: 19
		internal readonly <Module>.Class2.Class3 class3_1 = new <Module>.Class2.Class3();

		// Token: 0x04000014 RID: 20
		internal bool bool_0;

		// Token: 0x04000015 RID: 21
		internal uint uint_0;

		// Token: 0x04000016 RID: 22
		internal uint uint_1;

		// Token: 0x04000017 RID: 23
		internal <Module>.Struct1 struct1_1 = new <Module>.Struct1(4);

		// Token: 0x04000018 RID: 24
		internal uint uint_2;

		// Token: 0x02000006 RID: 6
		internal class Class3
		{
			// Token: 0x06000016 RID: 22 RVA: 0x000056F4 File Offset: 0x000038F4
			internal void method_0(uint uint_1)
			{
				for (uint num = this.uint_0; num < uint_1; num += 1u)
				{
					this.struct1_0[(int)((UIntPtr)num)] = new <Module>.Struct1(3);
					this.struct1_1[(int)((UIntPtr)num)] = new <Module>.Struct1(3);
				}
				this.uint_0 = uint_1;
			}

			// Token: 0x06000017 RID: 23 RVA: 0x0000574C File Offset: 0x0000394C
			internal void method_1()
			{
				this.struct0_0.method_0();
				for (uint num = 0u; num < this.uint_0; num += 1u)
				{
					this.struct1_0[(int)((UIntPtr)num)].method_0();
					this.struct1_1[(int)((UIntPtr)num)].method_0();
				}
				this.struct0_1.method_0();
				this.struct1_2.method_0();
			}

			// Token: 0x06000018 RID: 24 RVA: 0x000057B0 File Offset: 0x000039B0
			internal uint method_2(<Module>.Class1 class1_0, uint uint_1)
			{
				if (this.struct0_0.method_1(class1_0) == 0u)
				{
					return this.struct1_0[(int)((UIntPtr)uint_1)].method_1(class1_0);
				}
				uint num = 8u;
				if (this.struct0_1.method_1(class1_0) == 0u)
				{
					num += this.struct1_1[(int)((UIntPtr)uint_1)].method_1(class1_0);
				}
				else
				{
					num += 8u;
					num += this.struct1_2.method_1(class1_0);
				}
				return num;
			}

			// Token: 0x06000019 RID: 25 RVA: 0x0000581C File Offset: 0x00003A1C
			internal Class3()
			{
			}

			// Token: 0x04000019 RID: 25
			internal readonly <Module>.Struct1[] struct1_0 = new <Module>.Struct1[16];

			// Token: 0x0400001A RID: 26
			internal readonly <Module>.Struct1[] struct1_1 = new <Module>.Struct1[16];

			// Token: 0x0400001B RID: 27
			internal <Module>.Struct0 struct0_0 = default(<Module>.Struct0);

			// Token: 0x0400001C RID: 28
			internal <Module>.Struct0 struct0_1 = default(<Module>.Struct0);

			// Token: 0x0400001D RID: 29
			internal <Module>.Struct1 struct1_2 = new <Module>.Struct1(8);

			// Token: 0x0400001E RID: 30
			internal uint uint_0;
		}

		// Token: 0x02000007 RID: 7
		internal class Class4
		{
			// Token: 0x0600001A RID: 26 RVA: 0x00005870 File Offset: 0x00003A70
			internal void method_0(int int_2, int int_3)
			{
				if (this.struct2_0 != null && this.int_1 == int_3 && this.int_0 == int_2)
				{
					return;
				}
				this.int_0 = int_2;
				this.uint_0 = (1u << int_2) - 1u;
				this.int_1 = int_3;
				uint num = 1u << this.int_1 + this.int_0;
				this.struct2_0 = new <Module>.Class2.Class4.Struct2[num];
				for (uint num2 = 0u; num2 < num; num2 += 1u)
				{
					this.struct2_0[(int)((UIntPtr)num2)].method_0();
				}
			}

			// Token: 0x0600001B RID: 27 RVA: 0x000058F4 File Offset: 0x00003AF4
			internal void method_1()
			{
				uint num = 1u << this.int_1 + this.int_0;
				for (uint num2 = 0u; num2 < num; num2 += 1u)
				{
					this.struct2_0[(int)((UIntPtr)num2)].method_1();
				}
			}

			// Token: 0x0600001C RID: 28 RVA: 0x00003C94 File Offset: 0x00001E94
			internal uint method_2(uint uint_1, byte byte_0)
			{
				return ((uint_1 & this.uint_0) << this.int_1) + (uint)(byte_0 >> 8 - this.int_1);
			}

			// Token: 0x0600001D RID: 29 RVA: 0x00003CB6 File Offset: 0x00001EB6
			internal byte method_3(<Module>.Class1 class1_0, uint uint_1, byte byte_0)
			{
				return this.struct2_0[(int)((UIntPtr)this.method_2(uint_1, byte_0))].method_2(class1_0);
			}

			// Token: 0x0600001E RID: 30 RVA: 0x00003CD2 File Offset: 0x00001ED2
			internal byte method_4(<Module>.Class1 class1_0, uint uint_1, byte byte_0, byte byte_1)
			{
				return this.struct2_0[(int)((UIntPtr)this.method_2(uint_1, byte_0))].method_3(class1_0, byte_1);
			}

			// Token: 0x0600001F RID: 31 RVA: 0x00003C6F File Offset: 0x00001E6F
			internal Class4()
			{
			}

			// Token: 0x0400001F RID: 31
			internal <Module>.Class2.Class4.Struct2[] struct2_0;

			// Token: 0x04000020 RID: 32
			internal int int_0;

			// Token: 0x04000021 RID: 33
			internal int int_1;

			// Token: 0x04000022 RID: 34
			internal uint uint_0;

			// Token: 0x02000008 RID: 8
			internal struct Struct2
			{
				// Token: 0x06000020 RID: 32 RVA: 0x00003CF0 File Offset: 0x00001EF0
				internal void method_0()
				{
					this.struct0_0 = new <Module>.Struct0[768];
				}

				// Token: 0x06000021 RID: 33 RVA: 0x00005934 File Offset: 0x00003B34
				internal void method_1()
				{
					for (int i = 0; i < 768; i++)
					{
						this.struct0_0[i].method_0();
					}
				}

				// Token: 0x06000022 RID: 34 RVA: 0x00005964 File Offset: 0x00003B64
				internal byte method_2(<Module>.Class1 class1_0)
				{
					uint num = 1u;
					do
					{
						num = (num << 1 | this.struct0_0[(int)((UIntPtr)num)].method_1(class1_0));
					}
					while (num < 256u);
					return (byte)num;
				}

				// Token: 0x06000023 RID: 35 RVA: 0x00005998 File Offset: 0x00003B98
				internal byte method_3(<Module>.Class1 class1_0, byte byte_0)
				{
					uint num = 1u;
					for (;;)
					{
						uint num2 = (uint)(byte_0 >> 7 & 1);
						byte_0 = (byte)(byte_0 << 1);
						uint num3 = this.struct0_0[(int)((UIntPtr)((1u + num2 << 8) + num))].method_1(class1_0);
						num = (num << 1 | num3);
						if (num2 != num3)
						{
							break;
						}
						if (num >= 256u)
						{
							goto IL_5E;
						}
					}
					while (num < 256u)
					{
						num = (num << 1 | this.struct0_0[(int)((UIntPtr)num)].method_1(class1_0));
					}
					IL_5E:
					return (byte)num;
				}

				// Token: 0x04000023 RID: 35
				internal <Module>.Struct0[] struct0_0;
			}
		}
	}

	// Token: 0x02000009 RID: 9
	internal class Class5
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00003D02 File Offset: 0x00001F02
		internal void method_0(uint uint_3)
		{
			if (this.uint_2 != uint_3)
			{
				this.byte_0 = new byte[uint_3];
			}
			this.uint_2 = uint_3;
			this.uint_0 = 0u;
			this.uint_1 = 0u;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003D2F File Offset: 0x00001F2F
		internal void method_1(Stream stream_1, bool bool_0)
		{
			this.method_2();
			this.stream_0 = stream_1;
			if (!bool_0)
			{
				this.uint_1 = 0u;
				this.uint_0 = 0u;
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003D4F File Offset: 0x00001F4F
		internal void method_2()
		{
			this.method_3();
			this.stream_0 = null;
			Buffer.BlockCopy(new byte[this.byte_0.Length], 0, this.byte_0, 0, this.byte_0.Length);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00005A08 File Offset: 0x00003C08
		internal void method_3()
		{
			uint num = this.uint_0 - this.uint_1;
			if (num == 0u)
			{
				return;
			}
			this.stream_0.Write(this.byte_0, (int)this.uint_1, (int)num);
			if (this.uint_0 >= this.uint_2)
			{
				this.uint_0 = 0u;
			}
			this.uint_1 = this.uint_0;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00005A60 File Offset: 0x00003C60
		internal void method_4(uint uint_3, uint uint_4)
		{
			uint num = this.uint_0 - uint_3 - 1u;
			if (num >= this.uint_2)
			{
				num += this.uint_2;
			}
			while (uint_4 > 0u)
			{
				if (num >= this.uint_2)
				{
					num = 0u;
				}
				this.byte_0[(int)((UIntPtr)(this.uint_0++))] = this.byte_0[(int)((UIntPtr)(num++))];
				if (this.uint_0 >= this.uint_2)
				{
					this.method_3();
				}
				uint_4 -= 1u;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00005ADC File Offset: 0x00003CDC
		internal void method_5(byte byte_1)
		{
			this.byte_0[(int)((UIntPtr)(this.uint_0++))] = byte_1;
			if (this.uint_0 >= this.uint_2)
			{
				this.method_3();
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00005B18 File Offset: 0x00003D18
		internal byte method_6(uint uint_3)
		{
			uint num = this.uint_0 - uint_3 - 1u;
			if (num >= this.uint_2)
			{
				num += this.uint_2;
			}
			return this.byte_0[(int)((UIntPtr)num)];
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003C6F File Offset: 0x00001E6F
		internal Class5()
		{
		}

		// Token: 0x04000024 RID: 36
		internal byte[] byte_0;

		// Token: 0x04000025 RID: 37
		internal uint uint_0;

		// Token: 0x04000026 RID: 38
		internal Stream stream_0;

		// Token: 0x04000027 RID: 39
		internal uint uint_1;

		// Token: 0x04000028 RID: 40
		internal uint uint_2;
	}

	// Token: 0x0200000A RID: 10
	internal struct Struct3
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00003D80 File Offset: 0x00001F80
		internal void method_0()
		{
			this.uint_0 = 0u;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003D89 File Offset: 0x00001F89
		internal void method_1()
		{
			if (this.uint_0 < 4u)
			{
				this.uint_0 = 0u;
				return;
			}
			if (this.uint_0 < 10u)
			{
				this.uint_0 -= 3u;
				return;
			}
			this.uint_0 -= 6u;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003DC3 File Offset: 0x00001FC3
		internal void method_2()
		{
			this.uint_0 = ((this.uint_0 < 7u) ? 7u : 10u);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003DD9 File Offset: 0x00001FD9
		internal void method_3()
		{
			this.uint_0 = ((this.uint_0 < 7u) ? 8u : 11u);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003DEF File Offset: 0x00001FEF
		internal void method_4()
		{
			this.uint_0 = ((this.uint_0 < 7u) ? 9u : 11u);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003E06 File Offset: 0x00002006
		internal bool method_5()
		{
			return this.uint_0 < 7u;
		}

		// Token: 0x04000029 RID: 41
		internal uint uint_0;
	}
}
