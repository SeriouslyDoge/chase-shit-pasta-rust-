using System;
using System.Collections;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x0200001C RID: 28
	public class SilentMelee13 : MonoBehaviour
	{
		// Token: 0x0600012A RID: 298 RVA: 0x000042F4 File Offset: 0x000024F4
		private void Start()
		{
			SilentMelee13.smethod_0(this, this.Updating944());
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00004303 File Offset: 0x00002503
		private IEnumerator Updating944()
		{
			SilentMelee13.<Updating944>d__2 <Updating944>d__ = new SilentMelee13.<Updating944>d__2(0);
			<Updating944>d__.<>4__this = this;
			return <Updating944>d__;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00004312 File Offset: 0x00002512
		static Coroutine smethod_0(MonoBehaviour monoBehaviour_0, IEnumerator ienumerator_0)
		{
			return monoBehaviour_0.StartCoroutine(ienumerator_0);
		}

		// Token: 0x04000087 RID: 135
		public static StorageContainer[] storageContainerArray;
	}
}
