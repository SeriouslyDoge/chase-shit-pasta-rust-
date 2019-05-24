using System;
using System.Collections;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000046 RID: 70
	public class UpdateObjects1 : MonoBehaviour
	{
		// Token: 0x060002B3 RID: 691 RVA: 0x0000484E File Offset: 0x00002A4E
		private void Start()
		{
			UpdateObjects1.smethod_0(this, this.Updating94());
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000485D File Offset: 0x00002A5D
		private IEnumerator Updating94()
		{
			UpdateObjects1.<Updating94>d__1 <Updating94>d__ = new UpdateObjects1.<Updating94>d__1(0);
			<Updating94>d__.<>4__this = this;
			return <Updating94>d__;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00004312 File Offset: 0x00002512
		static Coroutine smethod_0(MonoBehaviour monoBehaviour_0, IEnumerator ienumerator_0)
		{
			return monoBehaviour_0.StartCoroutine(ienumerator_0);
		}
	}
}
