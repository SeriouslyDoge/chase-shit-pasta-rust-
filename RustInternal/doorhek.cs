using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000036 RID: 54
	public class doorhek : MonoBehaviour
	{
		// Token: 0x06000215 RID: 533 RVA: 0x00004604 File Offset: 0x00002804
		private void Start()
		{
			doorhek.smethod_0(this, this.Updating9441());
			doorhek.smethod_0(this, this.Updating944());
			doorhek.smethod_0(this, this.Updating9414());
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000462D File Offset: 0x0000282D
		private IEnumerator Updating9441()
		{
			int num;
			do
			{
				try
				{
					if (Main.autolock.GetData<bool>() && doorhek.<Updating9441>d__2.smethod_1(doorhek.<Updating9441>d__2.smethod_0(), null))
					{
						foreach (CodeLock codeLock in Entities.door)
						{
							string systemCopyBuffer = doorhek.<Updating9441>d__2.smethod_2();
							int lock_distance = (int)Vector3.Distance(doorhek.<Updating9441>d__2.smethod_4(doorhek.<Updating9441>d__2.smethod_3(doorhek.<Updating9441>d__2.smethod_0())), doorhek.<Updating9441>d__2.smethod_4(doorhek.<Updating9441>d__2.smethod_3(codeLock)));
							if (doorhek.<Updating9441>d__2.smethod_1(codeLock, null) && (float)lock_distance <= 7f && doorhek.<Updating9441>d__2.smethod_5((KeyCode)Main.autounlockcodekey.GetSubContent<List<object>>().ElementAtOrDefault(Main.autounlockcodekey.GetData<int>())))
							{
								codeLock.ServerRPC<string>("UnlockWithCode", systemCopyBuffer);
							}
							systemCopyBuffer = null;
							codeLock = null;
						}
						HashSet<CodeLock>.Enumerator enumerator = default(HashSet<CodeLock>.Enumerator);
					}
				}
				catch
				{
				}
				yield return doorhek.<Updating9441>d__2.smethod_6(0.2f);
			}
			while (num == 1);
			yield break;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000463C File Offset: 0x0000283C
		private IEnumerator Updating944()
		{
			doorhek.<Updating944>d__3 <Updating944>d__ = new doorhek.<Updating944>d__3(0);
			<Updating944>d__.<>4__this = this;
			return <Updating944>d__;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000464B File Offset: 0x0000284B
		private IEnumerator Updating9414()
		{
			int num;
			do
			{
				try
				{
					if (Main.doorheks.GetData<bool>() && doorhek.<Updating9414>d__4.smethod_1(doorhek.<Updating9414>d__4.smethod_0(), null))
					{
						foreach (Door codeLock in Entities.dorhackl)
						{
							int lock_distance = (int)Vector3.Distance(doorhek.<Updating9414>d__4.smethod_3(doorhek.<Updating9414>d__4.smethod_2(doorhek.<Updating9414>d__4.smethod_0())), doorhek.<Updating9414>d__4.smethod_3(doorhek.<Updating9414>d__4.smethod_2(codeLock)));
							if (doorhek.<Updating9414>d__4.smethod_1(codeLock, null) && (float)lock_distance <= 7f && doorhek.<Updating9414>d__4.smethod_4((KeyCode)Main.HOTKEY9.GetSubContent<List<object>>().ElementAtOrDefault(Main.HOTKEY9.GetData<int>())))
							{
								doorhek.<Updating9414>d__4.smethod_5(codeLock, "RPC_KnockDoor");
							}
							codeLock = null;
						}
						HashSet<Door>.Enumerator enumerator = default(HashSet<Door>.Enumerator);
					}
				}
				catch
				{
				}
				yield return doorhek.<Updating9414>d__4.smethod_6(0.09f);
			}
			while (num == 1);
			yield break;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00004312 File Offset: 0x00002512
		static Coroutine smethod_0(MonoBehaviour monoBehaviour_0, IEnumerator ienumerator_0)
		{
			return monoBehaviour_0.StartCoroutine(ienumerator_0);
		}

		// Token: 0x040000E4 RID: 228
		public static StorageContainer[] storageContainerArray;
	}
}
