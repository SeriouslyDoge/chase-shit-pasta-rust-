using System;
using System.Collections.Generic;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x0200003F RID: 63
	public class FriendManager : MonoBehaviour
	{
		// Token: 0x06000271 RID: 625 RVA: 0x0000473F File Offset: 0x0000293F
		private void Start()
		{
			FriendManager.friendsList = new HashSet<ulong>();
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000DDE8 File Offset: 0x0000BFE8
		public static void AddFriend()
		{
			if (FriendManager.smethod_1(FriendManager.smethod_0(), null))
			{
				BasePlayer target = Aimbot.GetTarget();
				if (FriendManager.smethod_1(target, null))
				{
					if (!FriendManager.friendsList.Contains(target.userID))
					{
						FriendManager.friendsList.Add(target.userID);
					}
					else
					{
						FriendManager.friendsList.Remove(target.userID);
					}
				}
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000474B File Offset: 0x0000294B
		public static bool IsFriend(BasePlayer player)
		{
			return FriendManager.smethod_1(player, null) && FriendManager.friendsList.Contains(player.userID);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x000042CF File Offset: 0x000024CF
		static BasePlayer smethod_0()
		{
			return LocalPlayer.Entity;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000400D File Offset: 0x0000220D
		static bool smethod_1(UnityEngine.Object object_0, UnityEngine.Object object_1)
		{
			return object_0 != object_1;
		}

		// Token: 0x04000107 RID: 263
		public static HashSet<ulong> friendsList;
	}
}
