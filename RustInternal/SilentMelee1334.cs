using System;
using System.Collections;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000033 RID: 51
	public class SilentMelee1334 : MonoBehaviour
	{
		// Token: 0x060001FA RID: 506 RVA: 0x00004583 File Offset: 0x00002783
		private void Start()
		{
			SilentMelee1334.smethod_0(this, this.Updating944());
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00004592 File Offset: 0x00002792
		private IEnumerator Updating944()
		{
			SilentMelee1334.<Updating944>d__2 <Updating944>d__ = new SilentMelee1334.<Updating944>d__2(0);
			<Updating944>d__.<>4__this = this;
			return <Updating944>d__;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00004312 File Offset: 0x00002512
		static Coroutine smethod_0(MonoBehaviour monoBehaviour_0, IEnumerator ienumerator_0)
		{
			return monoBehaviour_0.StartCoroutine(ienumerator_0);
		}

		// Token: 0x040000DD RID: 221
		public static StorageContainer[] storageContainerArray;
	}
}
