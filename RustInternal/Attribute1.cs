using System;

namespace RustInternal
{
	// Token: 0x02000018 RID: 24
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	internal sealed class Attribute1 : Attribute
	{
		// Token: 0x060000ED RID: 237 RVA: 0x00004241 File Offset: 0x00002441
		public Attribute1(string string_0, string string_1)
		{
			this.Bind = string_0;
			this.DisplayName = string_1;
		}

		// Token: 0x0400007B RID: 123
		public string Bind;

		// Token: 0x0400007C RID: 124
		public string DisplayName;
	}
}
