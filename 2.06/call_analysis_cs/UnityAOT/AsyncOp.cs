using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using Marketplace;

namespace UnityAOT;

[StructLayout(0)]
public class AsyncOp<T> : IDisposable where T : AsyncOp<T>
{
	public uint Result;

	public bool IsComplete;

	public bool Success;

	protected GCHandle m_Handle;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AsyncOp()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void Dispose()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public static IntPtr GetMyHandle(T obj)
	{
		return (IntPtr)0;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(CatalogServiceManager), Member = "GetCatalogItemDetailsListThunk")]
	[CalledBy(Type = typeof(CatalogServiceManager), Member = "GetBrowseCatalogResultThunk")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetConsumeInventoryItemResultThunk")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemThunk")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemsResultThunk")]
	[CalledBy(Type = typeof(StoreManager), Member = "PrivilegeCheckResultThunk")]
	[CalledBy(Type = typeof(GetStringAsyncOp), Member = "GetStringAsyncThunkImpl")]
	[CalledBy(Type = typeof(ActionAsyncOp), Member = "GenericActionThunkImpl")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public static T GetMyObject(IntPtr handlePtr)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 30)]
	[CallsUnknownMethods(Count = 5)]
	public IntPtr GetHandle()
	{
		return (IntPtr)0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void FreeHandle()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected void TriggerOnComplete(uint result)
	{
	}
}
