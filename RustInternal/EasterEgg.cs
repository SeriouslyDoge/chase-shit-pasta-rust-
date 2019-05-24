using System;
using System.Collections;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x0200003D RID: 61
	public class EasterEgg : MonoBehaviour
	{
		// Token: 0x06000260 RID: 608 RVA: 0x00004703 File Offset: 0x00002903
		private void Start()
		{
			EasterEgg.smethod_0(this, this.Updating944());
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00004712 File Offset: 0x00002912
		private IEnumerator Updating944()
		{
			EasterEgg.<Updating944>d__2 <Updating944>d__ = new EasterEgg.<Updating944>d__2(0);
			<Updating944>d__.<>4__this = this;
			return <Updating944>d__;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00004312 File Offset: 0x00002512
		static Coroutine smethod_0(MonoBehaviour monoBehaviour_0, IEnumerator ienumerator_0)
		{
			return monoBehaviour_0.StartCoroutine(ienumerator_0);
		}

		// Token: 0x04000100 RID: 256
		public static StorageContainer[] storageContainerArray;
	}
}
