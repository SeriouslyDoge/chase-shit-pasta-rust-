using System;
using System.Collections;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000053 RID: 83
	public class storagehacks : MonoBehaviour
	{
		// Token: 0x0600039E RID: 926 RVA: 0x00004B23 File Offset: 0x00002D23
		private void Start()
		{
			storagehacks.smethod_0(this, this.Updating9444());
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00004B32 File Offset: 0x00002D32
		private IEnumerator Updating9444()
		{
			storagehacks.<Updating9444>d__2 <Updating9444>d__ = new storagehacks.<Updating9444>d__2(0);
			<Updating9444>d__.<>4__this = this;
			return <Updating9444>d__;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00004312 File Offset: 0x00002512
		static Coroutine smethod_0(MonoBehaviour monoBehaviour_0, IEnumerator ienumerator_0)
		{
			return monoBehaviour_0.StartCoroutine(ienumerator_0);
		}

		// Token: 0x0400026A RID: 618
		public static StorageContainer[] storageContainerArray;
	}
}
