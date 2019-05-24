using System;
using System.Collections;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000027 RID: 39
	public class SilentMelee133 : MonoBehaviour
	{
		// Token: 0x0600018C RID: 396 RVA: 0x00004454 File Offset: 0x00002654
		private void Start()
		{
			SilentMelee133.smethod_0(this, this.Updating944());
			SilentMelee133.smethod_0(this, this.Updating9441());
			SilentMelee133.smethod_0(this, this.Updating9442());
			SilentMelee133.smethod_0(this, this.Updating9443());
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000448A File Offset: 0x0000268A
		private IEnumerator Updating944()
		{
			SilentMelee133.<Updating944>d__3 <Updating944>d__ = new SilentMelee133.<Updating944>d__3(0);
			<Updating944>d__.<>4__this = this;
			return <Updating944>d__;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00004499 File Offset: 0x00002699
		private IEnumerator Updating9441()
		{
			SilentMelee133.<Updating9441>d__4 <Updating9441>d__ = new SilentMelee133.<Updating9441>d__4(0);
			<Updating9441>d__.<>4__this = this;
			return <Updating9441>d__;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000044A8 File Offset: 0x000026A8
		private IEnumerator Updating9442()
		{
			SilentMelee133.<Updating9442>d__5 <Updating9442>d__ = new SilentMelee133.<Updating9442>d__5(0);
			<Updating9442>d__.<>4__this = this;
			return <Updating9442>d__;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000044B7 File Offset: 0x000026B7
		private IEnumerator Updating9443()
		{
			SilentMelee133.<Updating9443>d__6 <Updating9443>d__ = new SilentMelee133.<Updating9443>d__6(0);
			<Updating9443>d__.<>4__this = this;
			return <Updating9443>d__;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00004312 File Offset: 0x00002512
		static Coroutine smethod_0(MonoBehaviour monoBehaviour_0, IEnumerator ienumerator_0)
		{
			return monoBehaviour_0.StartCoroutine(ienumerator_0);
		}

		// Token: 0x040000AC RID: 172
		public static StorageContainer[] storageContainerArray;

		// Token: 0x040000AD RID: 173
		public static BasePlayer localplayer;
	}
}
