using System;
using Facepunch.Steamworks;
using UnityEngine;

namespace RustInternal
{
	// Token: 0x0200004A RID: 74
	public static class Class0
	{
		// Token: 0x060002DF RID: 735 RVA: 0x00011130 File Offset: 0x0000F330
		public static void smethod_0()
		{
			Class0.smethod_2(Class0.smethod_1()).OnIncomingConnection = null;
			Class0.smethod_2(Class0.smethod_1()).OnConnectionFailed = null;
			Class0.smethod_2(Class0.smethod_1()).OnP2PData = null;
			Class0.fuckyou = Class0.smethod_4(string.Empty, new Type[]
			{
				Class0.smethod_3(typeof(Main).TypeHandle),
				Class0.smethod_3(typeof(AnimalESP).TypeHandle),
				Class0.smethod_3(typeof(Corpse).TypeHandle),
				Class0.smethod_3(typeof(CupboardESP).TypeHandle),
				Class0.smethod_3(typeof(HelicopterESP).TypeHandle),
				Class0.smethod_3(typeof(boat).TypeHandle),
				Class0.smethod_3(typeof(Entities).TypeHandle),
				Class0.smethod_3(typeof(SilentMelee).TypeHandle),
				Class0.smethod_3(typeof(FriendManager).TypeHandle),
				Class0.smethod_3(typeof(untieshit).TypeHandle),
				Class0.smethod_3(typeof(SilentCat).TypeHandle),
				Class0.smethod_3(typeof(chinook).TypeHandle),
				Class0.smethod_3(typeof(AutoFarm).TypeHandle),
				Class0.smethod_3(typeof(SilentMelee12).TypeHandle),
				Class0.smethod_3(typeof(SilentMelee13).TypeHandle),
				Class0.smethod_3(typeof(SilentMelee14).TypeHandle),
				Class0.smethod_3(typeof(Aimbot).TypeHandle),
				Class0.smethod_3(typeof(SilentMelee0).TypeHandle),
				Class0.smethod_3(typeof(SilentMelee15).TypeHandle),
				Class0.smethod_3(typeof(SilentMelee16).TypeHandle),
				Class0.smethod_3(typeof(storagehacks).TypeHandle),
				Class0.smethod_3(typeof(drink).TypeHandle),
				Class0.smethod_3(typeof(SilentCat11).TypeHandle),
				Class0.smethod_3(typeof(SilentCat1111).TypeHandle),
				Class0.smethod_3(typeof(SilentMelee1334).TypeHandle),
				Class0.smethod_3(typeof(SilentMelee133).TypeHandle),
				Class0.smethod_3(typeof(newhekxd).TypeHandle),
				Class0.smethod_3(typeof(revive).TypeHandle),
				Class0.smethod_3(typeof(LootESP).TypeHandle),
				Class0.smethod_3(typeof(SilentMelee131).TypeHandle),
				Class0.smethod_3(typeof(Radar).TypeHandle),
				Class0.smethod_3(typeof(Traps).TypeHandle),
				Class0.smethod_3(typeof(Misc).TypeHandle),
				Class0.smethod_3(typeof(EasterEgg).TypeHandle),
				Class0.smethod_3(typeof(randomshit).TypeHandle),
				Class0.smethod_3(typeof(PlayerESP).TypeHandle),
				Class0.smethod_3(typeof(UpdateObjects1).TypeHandle),
				Class0.smethod_3(typeof(doorhek).TypeHandle),
				Class0.smethod_3(typeof(ResourceESP).TypeHandle),
				Class0.smethod_3(typeof(WorldItemESP).TypeHandle),
				Class0.smethod_3(typeof(UpdateObjects).TypeHandle)
			});
			Class0.smethod_5(Class0.fuckyou);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x000048B4 File Offset: 0x00002AB4
		static Facepunch.Steamworks.Client smethod_1()
		{
			return global::Client.Steam;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x000048BB File Offset: 0x00002ABB
		static Networking smethod_2(BaseSteamworks baseSteamworks_0)
		{
			return baseSteamworks_0.Networking;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00003E9E File Offset: 0x0000209E
		static Type smethod_3(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x000048C3 File Offset: 0x00002AC3
		static GameObject smethod_4(string string_0, Type[] type_0)
		{
			return new GameObject(string_0, type_0);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x000048CC File Offset: 0x00002ACC
		static void smethod_5(UnityEngine.Object object_0)
		{
			UnityEngine.Object.DontDestroyOnLoad(object_0);
		}

		// Token: 0x04000162 RID: 354
		private static GameObject fuckyou;
	}
}
