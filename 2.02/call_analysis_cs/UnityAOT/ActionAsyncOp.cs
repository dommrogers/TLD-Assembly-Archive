using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using Marketplace;
using UnityPlugin;

namespace UnityAOT;

public class ActionAsyncOp : AsyncOp<ActionAsyncOp>
{
	public delegate void ActionAsyncCallback(AsyncStatus status, ActionAsyncOp op);

	public delegate void OnCallbackException(string message);

	public AsyncStatus Status;

	private OnCallbackException LogException;

	public static GenericActionCallback GenericActionThunk;

	public event ActionAsyncCallback Callback
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

	[CalledBy(Type = typeof(StoreManager), Member = "ShowDetailsAsync")]
	[CalledBy(Type = typeof(StoreManager), Member = "ShowMarketplaceAsync")]
	[CalledBy(Type = typeof(StoreManager), Member = "ShowPurchaseAsync")]
	[CalledBy(Type = typeof(StoreManager), Member = "ShowRedeemCodeAsync")]
	[CalledBy(Type = typeof(StoreManager), Member = "ShowSubscriptionAsync")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public ActionAsyncOp(ActionAsyncCallback callback, OnCallbackException logException)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Complete(uint result, uint status)
	{
	}

	[CalledBy(Type = typeof(StoreManager), Member = "ShowDetailsAsync")]
	[CalledBy(Type = typeof(StoreManager), Member = "ShowMarketplaceAsync")]
	[CalledBy(Type = typeof(StoreManager), Member = "ShowPurchaseAsync")]
	[CalledBy(Type = typeof(StoreManager), Member = "ShowRedeemCodeAsync")]
	[CalledBy(Type = typeof(StoreManager), Member = "ShowSubscriptionAsync")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	public ActionAsyncOp Validate(bool ok)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetMyObject")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	protected static void GenericActionThunkImpl(uint result, uint status, IntPtr userData)
	{
	}
}
