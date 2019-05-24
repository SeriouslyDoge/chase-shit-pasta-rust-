using System;
using System.Reflection;

namespace RustInternal
{
	// Token: 0x02000049 RID: 73
	public static class Helpers
	{
		// Token: 0x060002D1 RID: 721 RVA: 0x00011038 File Offset: 0x0000F238
		private static FieldInfo GetFieldInfo(Type type, string fieldName)
		{
			FieldInfo fieldInfo;
			do
			{
				fieldInfo = Helpers.smethod_0(type, fieldName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				type = Helpers.smethod_1(type);
			}
			while (Helpers.smethod_2(fieldInfo, null) && Helpers.smethod_3(type, null));
			return fieldInfo;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00011078 File Offset: 0x0000F278
		public static object GetFieldValue(this object obj, string fieldName)
		{
			if (obj == null)
			{
				throw Helpers.smethod_4("obj");
			}
			Type type = Helpers.smethod_5(obj);
			FieldInfo fieldInfo = Helpers.GetFieldInfo(type, fieldName);
			if (Helpers.smethod_2(fieldInfo, null))
			{
				throw Helpers.smethod_8("fieldName", Helpers.smethod_7("Couldn't find field {0} in type {1}", fieldName, Helpers.smethod_6(type)));
			}
			return Helpers.smethod_9(fieldInfo, obj);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x000110D4 File Offset: 0x0000F2D4
		public static void SetFieldValue(this object obj, string fieldName, object val)
		{
			if (obj == null)
			{
				throw Helpers.smethod_4("obj");
			}
			Type type = Helpers.smethod_5(obj);
			FieldInfo fieldInfo = Helpers.GetFieldInfo(type, fieldName);
			if (Helpers.smethod_2(fieldInfo, null))
			{
				throw Helpers.smethod_8("fieldName", Helpers.smethod_7("Couldn't find field {0} in type {1}", fieldName, Helpers.smethod_6(type)));
			}
			Helpers.smethod_10(fieldInfo, obj, val);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00003E19 File Offset: 0x00002019
		static FieldInfo smethod_0(Type type_0, string string_0, BindingFlags bindingFlags_0)
		{
			return type_0.GetField(string_0, bindingFlags_0);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000488A File Offset: 0x00002A8A
		static Type smethod_1(Type type_0)
		{
			return type_0.BaseType;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x000047EF File Offset: 0x000029EF
		static bool smethod_2(FieldInfo fieldInfo_0, FieldInfo fieldInfo_1)
		{
			return fieldInfo_0 == fieldInfo_1;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00004892 File Offset: 0x00002A92
		static bool smethod_3(Type type_0, Type type_1)
		{
			return type_0 != type_1;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000489B File Offset: 0x00002A9B
		static ArgumentNullException smethod_4(string string_0)
		{
			return new ArgumentNullException(string_0);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00003E11 File Offset: 0x00002011
		static Type smethod_5(object object_0)
		{
			return object_0.GetType();
		}

		// Token: 0x060002DA RID: 730 RVA: 0x000048A3 File Offset: 0x00002AA3
		static string smethod_6(Type type_0)
		{
			return type_0.FullName;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x000040F2 File Offset: 0x000022F2
		static string smethod_7(string string_0, object object_0, object object_1)
		{
			return string.Format(string_0, object_0, object_1);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000048AB File Offset: 0x00002AAB
		static ArgumentOutOfRangeException smethod_8(string string_0, string string_1)
		{
			return new ArgumentOutOfRangeException(string_0, string_1);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00003E23 File Offset: 0x00002023
		static object smethod_9(FieldInfo fieldInfo_0, object object_0)
		{
			return fieldInfo_0.GetValue(object_0);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00003E2C File Offset: 0x0000202C
		static void smethod_10(FieldInfo fieldInfo_0, object object_0, object object_1)
		{
			fieldInfo_0.SetValue(object_0, object_1);
		}
	}
}
