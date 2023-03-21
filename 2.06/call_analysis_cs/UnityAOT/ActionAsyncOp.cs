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
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[CalledBy(Type = typeof(StoreManager), Member = "ShowSubscriptionAsync")]
	[CalledBy(Type = typeof(StoreManager), Member = "ShowRedeemCodeAsync")]
	[CalledBy(Type = typeof(StoreManager), Member = "ShowPurchaseAsync")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(StoreManager), Member = "ShowDetailsAsync")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(StoreManager), Member = "ShowMarketplaceAsync")]
	public ActionAsyncOp(ActionAsyncCallback callback, OnCallbackException logException)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Complete(uint result, uint status)
	{
	}

	[CalledBy(Type = typeof(StoreManager), Member = "ShowSubscriptionAsync")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(StoreManager), Member = "ShowDetailsAsync")]
	[CalledBy(Type = typeof(StoreManager), Member = "ShowMarketplaceAsync")]
	[CalledBy(Type = typeof(StoreManager), Member = "ShowPurchaseAsync")]
	[CalledBy(Type = typeof(StoreManager), Member = "ShowRedeemCodeAsync")]
	public ActionAsyncOp Validate(bool ok)
	{
		return null;
	}

	[MonoPInvokeCallback(typeof(GenericActionCallback))]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[CallsUnknownMethods(Count = 1)]
	protected static void GenericActionThunkImpl(uint result, uint status, IntPtr userData)
	{
	}
}
