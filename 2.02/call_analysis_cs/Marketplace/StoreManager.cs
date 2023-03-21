using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace Marketplace;

public class StoreManager
{
	public delegate void OnProductPurchasedDelegate(ProductPurchasedEventArgs args);

	public delegate void PrivilegeCheckResultThunkType(uint result, uint data, IntPtr userData);

	private static StoreManager gInstance;

	public static event OnProductPurchasedDelegate OnProductPurchased
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StoreManager), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static void Create()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 17)]
	public static GetPODAsyncOp<PrivilegeCheckResult> CheckPrivilegeAsync(int userId, uint privilegeId, bool attemptResolution, string friendlyDisplay, GetPODAsyncOp<PrivilegeCheckResult>.GetPODAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 18)]
	public static GetPODAsyncOp<PrivilegeCheckResult> CheckPrivilegesAsync(int userId, uint[] privilegeIds, bool attemptResolution, string friendlyDisplay, GetPODAsyncOp<PrivilegeCheckResult>.GetPODAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionAsyncOp), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[Calls(Type = typeof(ActionAsyncOp), Member = "Validate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	public static ActionAsyncOp ShowDetailsAsync(int userId, string productId, ActionAsyncOp.ActionAsyncCallback callback = null)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionAsyncOp), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[Calls(Type = typeof(ActionAsyncOp), Member = "Validate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	public static ActionAsyncOp ShowMarketplaceAsync(int userId, ProductItemTypes inputProductItemType, string inputProductId, ProductItemTypes resultProductItemTypes, ActionAsyncOp.ActionAsyncCallback callback = null)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionAsyncOp), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[Calls(Type = typeof(ActionAsyncOp), Member = "Validate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	public static ActionAsyncOp ShowPurchaseAsync(int userId, string offer, ActionAsyncOp.ActionAsyncCallback callback = null)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionAsyncOp), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[Calls(Type = typeof(ActionAsyncOp), Member = "Validate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	public static ActionAsyncOp ShowRedeemCodeAsync(int userId, string offer, ActionAsyncOp.ActionAsyncCallback callback = null)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionAsyncOp), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[Calls(Type = typeof(ActionAsyncOp), Member = "Validate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	public static ActionAsyncOp ShowSubscriptionAsync(int userId, string productId, uint privilegeId, ActionAsyncOp.ActionAsyncCallback callback = null)
	{
		return null;
	}

	[CalledBy(Type = typeof(StoreManager), Member = "Create")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public StoreManager()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetMyObject")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(UnityPlugin.Log), Member = "LogCallbackException")]
	[CallsDeduplicatedMethods(Count = 4)]
	public static void PrivilegeCheckResultThunk(uint result, uint data, IntPtr userData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(UnityPlugin.Log), Member = "LogCallbackException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static void OnPurchaseThunk(uint result, IntPtr lresult, IntPtr userData)
	{
	}
}
