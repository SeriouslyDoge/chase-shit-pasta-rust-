using System;
using System.Collections;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x0200001E RID: 30
	public class SilentMelee14 : MonoBehaviour
	{
		// Token: 0x0600013B RID: 315 RVA: 0x00004353 File Offset: 0x00002553
		private void Start()
		{
			SilentMelee14.smethod_0(this, this.Updating944());
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00004362 File Offset: 0x00002562
		private IEnumerator Updating944()
		{
			SilentMelee14.<Updating944>d__2 <Updating944>d__ = new SilentMelee14.<Updating944>d__2(0);
			<Updating944>d__.<>4__this = this;
			return <Updating944>d__;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00004312 File Offset: 0x00002512
		static Coroutine smethod_0(MonoBehaviour monoBehaviour_0, IEnumerator ienumerator_0)
		{
			return monoBehaviour_0.StartCoroutine(ienumerator_0);
		}

		// Token: 0x0400008E RID: 142
		public static StorageContainer[] storageContainerArray;
	}
}
