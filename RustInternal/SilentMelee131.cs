using System;
using System.Collections;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000061 RID: 97
	public class SilentMelee131 : MonoBehaviour
	{
		// Token: 0x06000430 RID: 1072 RVA: 0x00004C54 File Offset: 0x00002E54
		private void Start()
		{
			SilentMelee131.smethod_0(this, this.Updating944());
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00004C63 File Offset: 0x00002E63
		private IEnumerator Updating944()
		{
			SilentMelee131.<Updating944>d__2 <Updating944>d__ = new SilentMelee131.<Updating944>d__2(0);
			<Updating944>d__.<>4__this = this;
			return <Updating944>d__;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00004312 File Offset: 0x00002512
		static Coroutine smethod_0(MonoBehaviour monoBehaviour_0, IEnumerator ienumerator_0)
		{
			return monoBehaviour_0.StartCoroutine(ienumerator_0);
		}

		// Token: 0x0400028E RID: 654
		public static StorageContainer[] storageContainerArray;
	}
}
