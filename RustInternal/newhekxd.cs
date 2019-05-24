using System;
using System.Collections;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x0200005E RID: 94
	public class newhekxd : MonoBehaviour
	{
		// Token: 0x0600040F RID: 1039 RVA: 0x00004C10 File Offset: 0x00002E10
		private void Start()
		{
			newhekxd.smethod_0(this, this.Updating94());
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00004C1F File Offset: 0x00002E1F
		private IEnumerator Updating94()
		{
			newhekxd.<Updating94>d__2 <Updating94>d__ = new newhekxd.<Updating94>d__2(0);
			<Updating94>d__.<>4__this = this;
			return <Updating94>d__;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00004312 File Offset: 0x00002512
		static Coroutine smethod_0(MonoBehaviour monoBehaviour_0, IEnumerator ienumerator_0)
		{
			return monoBehaviour_0.StartCoroutine(ienumerator_0);
		}

		// Token: 0x0400027F RID: 639
		public static StorageContainer[] storageContainerArray;
	}
}
