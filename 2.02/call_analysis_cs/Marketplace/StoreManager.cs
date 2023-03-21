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
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[CallsDeduplicatedMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StoreManager), Member = ".ctor")]
	public static void Create()
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public static GetPODAsyncOp<PrivilegeCheckResult> CheckPrivilegeAsync(int userId, uint privilegeId, bool attemptResolution, string friendlyDisplay, GetPODAsyncOp<PrivilegeCheckResult>.GetPODAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 18)]
	public static GetPODAsyncOp<PrivilegeCheckResult> CheckPrivilegesAsync(int userId, uint[] privilegeIds, bool attemptResolution, string friendlyDisplay, GetPODAsyncOp<PrivilegeCheckResult>.GetPODAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ActionAsyncOp), Member = ".ctor")]
	[Calls(Type = typeof(ActionAsyncOp), Member = "Validate")]
	[CallsUnknownMethods(Count = 17)]
	public static ActionAsyncOp ShowDetailsAsync(int userId, string productId, ActionAsyncOp.ActionAsyncCallback callback = null)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(ActionAsyncOp), Member = ".ctor")]
	[Calls(Type = typeof(ActionAsyncOp), Member = "Validate")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static ActionAsyncOp ShowMarketplaceAsync(int userId, ProductItemTypes inputProductItemType, string inputProductId, ProductItemTypes resultProductItemTypes, ActionAsyncOp.ActionAsyncCallback callback = null)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ActionAsyncOp), Member = ".ctor")]
	[Calls(Type = typeof(ActionAsyncOp), Member = "Validate")]
	[CallsUnknownMethods(Count = 17)]
	public static ActionAsyncOp ShowPurchaseAsync(int userId, string offer, ActionAsyncOp.ActionAsyncCallback callback = null)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ActionAsyncOp), Member = ".ctor")]
	[Calls(Type = typeof(ActionAsyncOp), Member = "Validate")]
	[CallsUnknownMethods(Count = 17)]
	public static ActionAsyncOp ShowRedeemCodeAsync(int userId, string offer, ActionAsyncOp.ActionAsyncCallback callback = null)
	{
		return null;
	}

	[Calls(Type = typeof(ActionAsyncOp), Member = "Validate")]
	[Calls(Type = typeof(ActionAsyncOp), Member = ".ctor")]
	[CallsUnknownMethods(Count = 17)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static ActionAsyncOp ShowSubscriptionAsync(int userId, string productId, uint privilegeId, ActionAsyncOp.ActionAsyncCallback callback = null)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(StoreManager), Member = "Create")]
	[CallsUnknownMethods(Count = 9)]
	public StoreManager()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Dispose()
	{
	}

	[UnityAOT.MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(UnityPlugin.Log), Member = "LogCallbackException")]
	public static void PrivilegeCheckResultThunk(uint result, uint data, IntPtr userData)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityPlugin.Log), Member = "LogCallbackException")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[UnityAOT.MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	public static void OnPurchaseThunk(uint result, IntPtr lresult, IntPtr userData)
	{
	}
}
