using System;
using System.Collections;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x0200003A RID: 58
	public class drink : MonoBehaviour
	{
		// Token: 0x06000245 RID: 581 RVA: 0x000046BB File Offset: 0x000028BB
		private void Start()
		{
			drink.smethod_0(this, this.Updating944());
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000046CA File Offset: 0x000028CA
		private IEnumerator Updating944()
		{
			drink.<Updating944>d__1 <Updating944>d__ = new drink.<Updating944>d__1(0);
			<Updating944>d__.<>4__this = this;
			return <Updating944>d__;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00004312 File Offset: 0x00002512
		static Coroutine smethod_0(MonoBehaviour monoBehaviour_0, IEnumerator ienumerator_0)
		{
			return monoBehaviour_0.StartCoroutine(ienumerator_0);
		}
	}
}
