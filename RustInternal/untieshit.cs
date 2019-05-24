using System;
using System.Collections;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000064 RID: 100
	public class untieshit : MonoBehaviour
	{
		// Token: 0x06000447 RID: 1095 RVA: 0x00004C90 File Offset: 0x00002E90
		private void Start()
		{
			untieshit.smethod_0(this, this.Updating944());
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00004C9F File Offset: 0x00002E9F
		private IEnumerator Updating944()
		{
			untieshit.<Updating944>d__2 <Updating944>d__ = new untieshit.<Updating944>d__2(0);
			<Updating944>d__.<>4__this = this;
			return <Updating944>d__;
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00004312 File Offset: 0x00002512
		static Coroutine smethod_0(MonoBehaviour monoBehaviour_0, IEnumerator ienumerator_0)
		{
			return monoBehaviour_0.StartCoroutine(ienumerator_0);
		}

		// Token: 0x04000295 RID: 661
		public static StorageContainer[] storageContainerArray;
	}
}
