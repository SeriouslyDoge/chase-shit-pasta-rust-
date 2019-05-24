using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x02000044 RID: 68
	public class AutoFarm : MonoBehaviour
	{
		// Token: 0x060002A0 RID: 672 RVA: 0x0000480A File Offset: 0x00002A0A
		private void Start()
		{
			AutoFarm.smethod_0(this, this.Updating944());
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00004819 File Offset: 0x00002A19
		private IEnumerator Updating944()
		{
			int num;
			do
			{
				try
				{
					if (Main.autopick.GetData<bool>() && AutoFarm.<Updating944>d__2.smethod_0((KeyCode)Main.HOTKEY3.GetSubContent<List<object>>().ElementAtOrDefault(Main.HOTKEY3.GetData<int>())) && AutoFarm.<Updating944>d__2.smethod_2(AutoFarm.<Updating944>d__2.smethod_1(), null))
					{
						foreach (WorldItem worldItem in Entities.droppedItems)
						{
							int lock_distance = (int)Vector3.Distance(AutoFarm.<Updating944>d__2.smethod_4(AutoFarm.<Updating944>d__2.smethod_3(AutoFarm.<Updating944>d__2.smethod_1())), AutoFarm.<Updating944>d__2.smethod_4(AutoFarm.<Updating944>d__2.smethod_3(worldItem)));
							if (Vector3.Distance(AutoFarm.<Updating944>d__2.smethod_4(AutoFarm.<Updating944>d__2.smethod_3(AutoFarm.<Updating944>d__2.smethod_1())), AutoFarm.<Updating944>d__2.smethod_4(AutoFarm.<Updating944>d__2.smethod_3(worldItem))) < 50f && (float)lock_distance <= 7f)
							{
								AutoFarm.<Updating944>d__2.smethod_5("Picking up...");
								AutoFarm.<Updating944>d__2.smethod_6(worldItem, "Pickup");
							}
							worldItem = null;
						}
						HashSet<WorldItem>.Enumerator enumerator = default(HashSet<WorldItem>.Enumerator);
					}
				}
				catch (Exception ex2)
				{
					Exception ex = ex2;
					AutoFarm.<Updating944>d__2.smethod_5(ex);
				}
				yield return AutoFarm.<Updating944>d__2.smethod_7(0.1f);
			}
			while (num == 1);
			yield break;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00004312 File Offset: 0x00002512
		static Coroutine smethod_0(MonoBehaviour monoBehaviour_0, IEnumerator ienumerator_0)
		{
			return monoBehaviour_0.StartCoroutine(ienumerator_0);
		}

		// Token: 0x0400014F RID: 335
		public static StorageContainer[] storageContainerArray;
	}
}
