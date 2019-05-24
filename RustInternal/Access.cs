using System;
using System.Reflection;

// Token: 0x0200000B RID: 11
internal static class Access
{
	// Token: 0x06000032 RID: 50 RVA: 0x00005B4C File Offset: 0x00003D4C
	internal static T GetPrivateField<T>(this object obj, string name)
	{
		Type type_ = Access.smethod_0(obj);
		FieldInfo fieldInfo_ = Access.smethod_1(type_, name, BindingFlags.Instance | BindingFlags.NonPublic);
		return (T)((object)Access.smethod_2(fieldInfo_, obj));
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00005B78 File Offset: 0x00003D78
	internal static void SetPrivateField(this object obj, string name, object value)
	{
		Type type_ = Access.smethod_0(obj);
		FieldInfo fieldInfo_ = Access.smethod_1(type_, name, BindingFlags.Instance | BindingFlags.NonPublic);
		Access.smethod_3(fieldInfo_, obj, value);
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00005BA0 File Offset: 0x00003DA0
	internal static void CallPrivateMethod(this object obj, string name, params object[] param)
	{
		Type type_ = Access.smethod_0(obj);
		MethodInfo methodBase_ = Access.smethod_4(type_, name, BindingFlags.Instance | BindingFlags.NonPublic);
		Access.smethod_5(methodBase_, obj, param);
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00003E11 File Offset: 0x00002011
	static Type smethod_0(object object_0)
	{
		return object_0.GetType();
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00003E19 File Offset: 0x00002019
	static FieldInfo smethod_1(Type type_0, string string_0, BindingFlags bindingFlags_0)
	{
		return type_0.GetField(string_0, bindingFlags_0);
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00003E23 File Offset: 0x00002023
	static object smethod_2(FieldInfo fieldInfo_0, object object_0)
	{
		return fieldInfo_0.GetValue(object_0);
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00003E2C File Offset: 0x0000202C
	static void smethod_3(FieldInfo fieldInfo_0, object object_0, object object_1)
	{
		fieldInfo_0.SetValue(object_0, object_1);
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00003E36 File Offset: 0x00002036
	static MethodInfo smethod_4(Type type_0, string string_0, BindingFlags bindingFlags_0)
	{
		return type_0.GetMethod(string_0, bindingFlags_0);
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00003E40 File Offset: 0x00002040
	static object smethod_5(MethodBase methodBase_0, object object_0, object[] object_1)
	{
		return methodBase_0.Invoke(object_0, object_1);
	}
}
