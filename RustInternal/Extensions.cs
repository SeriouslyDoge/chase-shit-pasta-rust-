using System;
using System.Reflection;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000043 RID: 67
	public static class Extensions
	{
		// Token: 0x06000291 RID: 657 RVA: 0x000047A4 File Offset: 0x000029A4
		public static void SetPrivateField(this object obj, string name, object value)
		{
			Extensions.smethod_2(Extensions.smethod_1(Extensions.smethod_0(obj), name, BindingFlags.Instance | BindingFlags.NonPublic), obj, value);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00010498 File Offset: 0x0000E698
		public static object GetPrivateValue(Type type, object instance, string name)
		{
			FieldInfo fieldInfo_ = Extensions.smethod_1(type, name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			object result;
			if (!Extensions.smethod_3(fieldInfo_, null))
			{
				result = Extensions.smethod_4(fieldInfo_, instance);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x000047BB File Offset: 0x000029BB
		public static void CallPrivateMethod<T>(this object obj, string name, object[] parameters)
		{
			Extensions.smethod_6(Extensions.smethod_5(typeof(T).TypeHandle).method_0(name, BindingFlags.Instance | BindingFlags.NonPublic), obj, null);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x000047D7 File Offset: 0x000029D7
		public static void InvokePrivateMethod(this object obj, string name, params object[] param)
		{
			Extensions.smethod_6(Extensions.smethod_7(Extensions.smethod_0(obj), name, BindingFlags.Instance | BindingFlags.NonPublic), obj, param);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x000104C8 File Offset: 0x0000E6C8
		public static bool withinViewport(this Vector2 pos)
		{
			return Extensions.smethod_8(MainCamera.mainCamera).Contains(pos);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00003E11 File Offset: 0x00002011
		static Type smethod_0(object object_0)
		{
			return object_0.GetType();
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00003E19 File Offset: 0x00002019
		static FieldInfo smethod_1(Type type_0, string string_0, BindingFlags bindingFlags_0)
		{
			return type_0.GetField(string_0, bindingFlags_0);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00003E2C File Offset: 0x0000202C
		static void smethod_2(FieldInfo fieldInfo_0, object object_0, object object_1)
		{
			fieldInfo_0.SetValue(object_0, object_1);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x000047EF File Offset: 0x000029EF
		static bool smethod_3(FieldInfo fieldInfo_0, FieldInfo fieldInfo_1)
		{
			return fieldInfo_0 == fieldInfo_1;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00003E23 File Offset: 0x00002023
		static object smethod_4(FieldInfo fieldInfo_0, object object_0)
		{
			return fieldInfo_0.GetValue(object_0);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00003E9E File Offset: 0x0000209E
		static Type smethod_5(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x000047F8 File Offset: 0x000029F8
		MethodInfo method_0(string string_0, BindingFlags bindingFlags_0)
		{
			return base.GetMethod(string_0, bindingFlags_0);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00003E40 File Offset: 0x00002040
		static object smethod_6(MethodBase methodBase_0, object object_0, object[] object_1)
		{
			return methodBase_0.Invoke(object_0, object_1);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00003E36 File Offset: 0x00002036
		static MethodInfo smethod_7(Type type_0, string string_0, BindingFlags bindingFlags_0)
		{
			return type_0.GetMethod(string_0, bindingFlags_0);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00004802 File Offset: 0x00002A02
		static Rect smethod_8(Camera camera_0)
		{
			return camera_0.pixelRect;
		}
	}
}
