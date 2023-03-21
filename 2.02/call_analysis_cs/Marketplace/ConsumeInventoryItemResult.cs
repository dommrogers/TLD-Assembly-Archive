using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace Marketplace;

public class ConsumeInventoryItemResult : IWrappedObject, IDisposable
{
	private IntPtr m_Self;

	private Uri m_ConsumableUrl;

	private string m_TransactionId;

	public uint ConsumableBalance
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(uint);
		}
	}

	public Uri ConsumableUrl
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedUri")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public string TransactionId
	{
		[CallsUnknownMethods(Count = 7)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ConsumeInventoryItemResult(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ConsumeInventoryItemResult()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetNativePtr(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 52)]
	public IntPtr GetNativePtr()
	{
		return default(IntPtr);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Dispose()
	{
	}
}
