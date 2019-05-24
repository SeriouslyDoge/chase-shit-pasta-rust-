using System;
using System.Collections;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000022 RID: 34
	public class SilentMelee16 : MonoBehaviour
	{
		// Token: 0x0600015D RID: 349 RVA: 0x000043CB File Offset: 0x000025CB
		private void Start()
		{
			SilentMelee16.smethod_0(this, this.Updating944());
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000043DA File Offset: 0x000025DA
		private IEnumerator Updating944()
		{
			SilentMelee16.<Updating944>d__2 <Updating944>d__ = new SilentMelee16.<Updating944>d__2(0);
			<Updating944>d__.<>4__this = this;
			return <Updating944>d__;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00004312 File Offset: 0x00002512
		static Coroutine smethod_0(MonoBehaviour monoBehaviour_0, IEnumerator ienumerator_0)
		{
			return monoBehaviour_0.StartCoroutine(ienumerator_0);
		}

		// Token: 0x0400009C RID: 156
		public static StorageContainer[] storageContainerArray;
	}
}
