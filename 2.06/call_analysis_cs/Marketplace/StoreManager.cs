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
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		remove
		{
		}
	}

	[CallsUnknownMethods(Count = 13)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void Create()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	public static GetPODAsyncOp<PrivilegeCheckResult> CheckPrivilegeAsync(int userId, uint privilegeId, bool attemptResolution, string friendlyDisplay, GetPODAsyncOp<PrivilegeCheckResult>.GetPODAsyncCallback callback)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 13)]
	public static GetPODAsyncOp<PrivilegeCheckResult> CheckPrivilegesAsync(int userId, uint[] privilegeIds, bool attemptResolution, string friendlyDisplay, GetPODAsyncOp<PrivilegeCheckResult>.GetPODAsyncCallback callback)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(ActionAsyncOp), Member = ".ctor")]
	[Calls(Type = typeof(ActionAsyncOp), Member = "Validate")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static ActionAsyncOp ShowDetailsAsync(int userId, string productId, ActionAsyncOp.ActionAsyncCallback callback = null)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ActionAsyncOp), Member = ".ctor")]
	[Calls(Type = typeof(ActionAsyncOp), Member = "Validate")]
	[CallsUnknownMethods(Count = 13)]
	public static ActionAsyncOp ShowMarketplaceAsync(int userId, ProductItemTypes inputProductItemType, string inputProductId, ProductItemTypes resultProductItemTypes, ActionAsyncOp.ActionAsyncCallback callback = null)
	{
		return null;
	}

	[Calls(Type = typeof(ActionAsyncOp), Member = "Validate")]
	[CallsUnknownMethods(Count = 13)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionAsyncOp), Member = ".ctor")]
	public static ActionAsyncOp ShowPurchaseAsync(int userId, string offer, ActionAsyncOp.ActionAsyncCallback callback = null)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 13)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ActionAsyncOp), Member = ".ctor")]
	[Calls(Type = typeof(ActionAsyncOp), Member = "Validate")]
	public static ActionAsyncOp ShowRedeemCodeAsync(int userId, string offer, ActionAsyncOp.ActionAsyncCallback callback = null)
	{
		return null;
	}

	[Calls(Type = typeof(ActionAsyncOp), Member = ".ctor")]
	[Calls(Type = typeof(ActionAsyncOp), Member = "Validate")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public static ActionAsyncOp ShowSubscriptionAsync(int userId, string productId, uint privilegeId, ActionAsyncOp.ActionAsyncCallback callback = null)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	public StoreManager()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}

	[UnityAOT.MonoPInvokeCallback(typeof(PrivilegeCheckResultThunkType))]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(UnityPlugin.Log), Member = "LogCallbackException")]
	public static void PrivilegeCheckResultThunk(uint result, uint data, IntPtr userData)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(UnityPlugin.Log), Member = "LogCallbackException")]
	[CallerCount(Count = 0)]
	[UnityAOT.MonoPInvokeCallback(typeof(ObjectResultCallback))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void OnPurchaseThunk(uint result, IntPtr lresult, IntPtr userData)
	{
	}
}
