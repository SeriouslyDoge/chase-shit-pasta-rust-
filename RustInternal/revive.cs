using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x0200005A RID: 90
	public class revive : MonoBehaviour
	{
		// Token: 0x060003DD RID: 989 RVA: 0x00004BCD File Offset: 0x00002DCD
		private void Start()
		{
			revive.smethod_0(this, this.Updating9445());
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00004BDC File Offset: 0x00002DDC
		private IEnumerator Updating9445()
		{
			int num;
			do
			{
				try
				{
					IEnumerator<BasePlayer> enumerator = revive.<Updating9445>d__3.smethod_0().GetEnumerator();
					try
					{
						while (revive.<Updating9445>d__3.smethod_7(enumerator))
						{
							BasePlayer player = enumerator.Current;
							if (Main.instant.GetData<bool>() && revive.<Updating9445>d__3.smethod_1((KeyCode)Main.aimkey4.GetSubContent<List<object>>().ElementAtOrDefault(Main.aimkey4.GetData<int>())) && revive.<Updating9445>d__3.smethod_3(revive.<Updating9445>d__3.smethod_2(), null))
							{
								int lock_distance = (int)Vector3.Distance(revive.<Updating9445>d__3.smethod_5(revive.<Updating9445>d__3.smethod_4(revive.<Updating9445>d__3.smethod_2())), revive.<Updating9445>d__3.smethod_5(revive.<Updating9445>d__3.smethod_4(player)));
								if (revive.<Updating9445>d__3.smethod_3(player, null) && (float)lock_distance <= 6f)
								{
									revive.<Updating9445>d__3.smethod_6(player, "RPC_Assist");
								}
							}
							player = null;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							revive.<Updating9445>d__3.smethod_8(enumerator);
						}
					}
					enumerator = null;
				}
				catch
				{
				}
				yield return revive.<Updating9445>d__3.smethod_9(0.1f);
			}
			while (num == 1);
			yield break;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00004312 File Offset: 0x00002512
		static Coroutine smethod_0(MonoBehaviour monoBehaviour_0, IEnumerator ienumerator_0)
		{
			return monoBehaviour_0.StartCoroutine(ienumerator_0);
		}

		// Token: 0x04000276 RID: 630
		public static StorageContainer[] storageContainerArray;

		// Token: 0x04000277 RID: 631
		public static BasePlayer localplayer;
	}
}
