using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000025 RID: 37
	public class SilentMelee12 : MonoBehaviour
	{
		// Token: 0x0600017B RID: 379 RVA: 0x00004418 File Offset: 0x00002618
		private void Start()
		{
			SilentMelee12.smethod_0(this, this.Updating944());
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00004427 File Offset: 0x00002627
		private IEnumerator Updating944()
		{
			int num;
			do
			{
				try
				{
					if (Main.autopickup.GetData<bool>() && SilentMelee12.<Updating944>d__2.smethod_1(SilentMelee12.<Updating944>d__2.smethod_0(), null))
					{
						foreach (CollectibleEntity codeLock in Entities.hempBushes)
						{
							int lock_distance = (int)Vector3.Distance(SilentMelee12.<Updating944>d__2.smethod_3(SilentMelee12.<Updating944>d__2.smethod_2(SilentMelee12.<Updating944>d__2.smethod_0())), SilentMelee12.<Updating944>d__2.smethod_3(SilentMelee12.<Updating944>d__2.smethod_2(codeLock)));
							if (SilentMelee12.<Updating944>d__2.smethod_1(codeLock, null) && (float)lock_distance <= 6f)
							{
								SilentMelee12.<Updating944>d__2.smethod_4(codeLock, "pickup");
							}
							codeLock = null;
						}
						HashSet<CollectibleEntity>.Enumerator enumerator = default(HashSet<CollectibleEntity>.Enumerator);
					}
				}
				catch
				{
				}
				yield return SilentMelee12.<Updating944>d__2.smethod_5(0.7f);
			}
			while (num == 1);
			yield break;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00004312 File Offset: 0x00002512
		static Coroutine smethod_0(MonoBehaviour monoBehaviour_0, IEnumerator ienumerator_0)
		{
			return monoBehaviour_0.StartCoroutine(ienumerator_0);
		}

		// Token: 0x040000A5 RID: 165
		public static StorageContainer[] storageContainerArray;
	}
}
