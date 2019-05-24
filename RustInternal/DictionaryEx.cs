using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace RustInternal
{
	// Token: 0x02000035 RID: 53
	public static class DictionaryEx
	{
		// Token: 0x0600020C RID: 524 RVA: 0x0000D3EC File Offset: 0x0000B5EC
		public static Value Get<Key, Value>(this Dictionary<Key, Value> dictionary, Key key)
		{
			Value result;
			if (!dictionary.TryGetValue(key, out result))
			{
				StackFrame stackFrame_ = DictionaryEx.smethod_0(1, true);
				MethodBase methodBase = DictionaryEx.smethod_1(stackFrame_);
				string string_ = DictionaryEx.smethod_2(methodBase);
				DictionaryEx.smethod_4(DictionaryEx.smethod_3(methodBase)[0]);
				string string_2 = DictionaryEx.smethod_2(DictionaryEx.smethod_5(methodBase));
				throw DictionaryEx.smethod_7(DictionaryEx.smethod_6("[", string_2, "] ", string_), "paramaName");
			}
			return result;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000045BF File Offset: 0x000027BF
		static StackFrame smethod_0(int int_0, bool bool_0)
		{
			return new StackFrame(int_0, bool_0);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x000045C8 File Offset: 0x000027C8
		static MethodBase smethod_1(StackFrame stackFrame_0)
		{
			return stackFrame_0.GetMethod();
		}

		// Token: 0x0600020F RID: 527 RVA: 0x000045D0 File Offset: 0x000027D0
		static string smethod_2(MemberInfo memberInfo_0)
		{
			return memberInfo_0.Name;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000045D8 File Offset: 0x000027D8
		static ParameterInfo[] smethod_3(MethodBase methodBase_0)
		{
			return methodBase_0.GetParameters();
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000045E0 File Offset: 0x000027E0
		static string smethod_4(ParameterInfo parameterInfo_0)
		{
			return parameterInfo_0.Name;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000045E8 File Offset: 0x000027E8
		static Type smethod_5(MemberInfo memberInfo_0)
		{
			return memberInfo_0.DeclaringType;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x000045F0 File Offset: 0x000027F0
		static string smethod_6(string string_0, string string_1, string string_2, string string_3)
		{
			return string_0 + string_1 + string_2 + string_3;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x000045FB File Offset: 0x000027FB
		static ArgumentException smethod_7(string string_0, string string_1)
		{
			return new ArgumentException(string_0, string_1);
		}
	}
}
