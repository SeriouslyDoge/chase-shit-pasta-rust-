using System;
using System.Collections;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000020 RID: 32
	public class SilentMelee15 : MonoBehaviour
	{
		// Token: 0x0600014C RID: 332 RVA: 0x0000438F File Offset: 0x0000258F
		private void Start()
		{
			SilentMelee15.smethod_0(this, this.Updating944());
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000439E File Offset: 0x0000259E
		private IEnumerator Updating944()
		{
			SilentMelee15.<Updating944>d__2 <Updating944>d__ = new SilentMelee15.<Updating944>d__2(0);
			<Updating944>d__.<>4__this = this;
			return <Updating944>d__;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00004312 File Offset: 0x00002512
		static Coroutine smethod_0(MonoBehaviour monoBehaviour_0, IEnumerator ienumerator_0)
		{
			return monoBehaviour_0.StartCoroutine(ienumerator_0);
		}

		// Token: 0x04000095 RID: 149
		public static StorageContainer[] storageContainerArray;
	}
}
