using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace Marketplace;

public class InventoryItemsResult : IWrappedObject, IDisposable
{
	private IntPtr m_Self;

	private InventoryItemList m_Items;

	public InventoryItemList Items
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public uint TotalItems
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(uint);
		}
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public InventoryItemsResult(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	public InventoryItemsResult()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetNativePtr(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 98)]
	public IntPtr GetNativePtr()
	{
		return default(IntPtr);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Dispose()
	{
	}
}
