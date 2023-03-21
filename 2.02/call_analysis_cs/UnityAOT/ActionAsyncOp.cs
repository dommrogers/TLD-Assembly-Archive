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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(StoreManager), Member = "ShowSubscriptionAsync")]
	[CalledBy(Type = typeof(StoreManager), Member = "ShowRedeemCodeAsync")]
	[CalledBy(Type = typeof(StoreManager), Member = "ShowPurchaseAsync")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(StoreManager), Member = "ShowDetailsAsync")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(StoreManager), Member = "ShowMarketplaceAsync")]
	public ActionAsyncOp(ActionAsyncCallback callback, OnCallbackException logException)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Complete(uint result, uint status)
	{
	}

	[CalledBy(Type = typeof(StoreManager), Member = "ShowRedeemCodeAsync")]
	[CalledBy(Type = typeof(StoreManager), Member = "ShowSubscriptionAsync")]
	[CalledBy(Type = typeof(StoreManager), Member = "ShowPurchaseAsync")]
	[CalledBy(Type = typeof(StoreManager), Member = "ShowMarketplaceAsync")]
	[CalledBy(Type = typeof(StoreManager), Member = "ShowDetailsAsync")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	public ActionAsyncOp Validate(bool ok)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	protected static void GenericActionThunkImpl(uint result, uint status, IntPtr userData)
	{
	}
}
