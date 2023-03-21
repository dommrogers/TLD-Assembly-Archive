using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace Marketplace;

public class StorePlugin
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool Store_CheckPrivilegeAsync(int userId, uint privilegeId, bool attemptResolution, string friendlyDisplay, StoreManager.PrivilegeCheckResultThunkType callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool Store_CheckPrivilegesAsync(int userId, [In] uint[] privilegeIds, int numPrivilegeIds, bool attemptResolution, string friendlyDisplay, StoreManager.PrivilegeCheckResultThunkType callback, IntPtr userData);

	[PreserveSig]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static extern bool Store_ShowDetailsAsync(int userId, string productId, GenericActionCallback callback, IntPtr userData);

	[PreserveSig]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static extern bool Store_ShowMarketplaceAsync(int userId, ProductItemTypes inputProductItemType, string inputProductId, ProductItemTypes resultProductItemTypes, GenericActionCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool Store_ShowPurchaseAsync(int userId, string offer, GenericActionCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool Store_ShowRedeemCodeAsync(int userId, string offer, GenericActionCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool Store_ShowSubscriptionAsync(int userId, string productId, uint privilegeId, GenericActionCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool Store_RegisterForPurchaseEvents(ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static extern bool Store_UnRegisterForPurchaseEvents();

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public StorePlugin()
	{
	}
}
