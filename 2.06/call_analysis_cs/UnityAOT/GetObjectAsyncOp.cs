using System;
using Cpp2ILInjected.CallAnalysis;
using Marketplace;

namespace UnityAOT;

public class GetObjectAsyncOp<T> : AsyncOp<GetObjectAsyncOp<T>> where T : IWrappedObject, new()
{
	public delegate void GetObjectAsyncCallback(T obj, GetObjectAsyncOp<T> op);

	public T ResultObject;

	public GetObjectAsyncCallback Callback;

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(CatalogServiceManager), Member = "BrowseCatalogAsync")]
	[CalledBy(Type = typeof(CatalogServiceManager), Member = "BrowseCatalogBundlesAsync")]
	[CalledBy(Type = typeof(CatalogServiceManager), Member = "GetCatalogItemDetailsAsync")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "ConsumeInventoryItemAsync")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemAsync")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemsAsync")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemsAsyncEx")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemsForAllUsersAsync")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemsForAllUsersAsyncEx")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	public GetObjectAsyncOp(GetObjectAsyncCallback callback)
	{
		((AsyncOp<>)(object)this)._002Ector();
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(CatalogServiceManager), Member = "GetCatalogItemDetailsListThunk")]
	[CalledBy(Type = typeof(CatalogServiceManager), Member = "GetBrowseCatalogResultThunk")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetConsumeInventoryItemResultThunk")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemThunk")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemsResultThunk")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void Complete(uint result, IntPtr lresults)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GetObjectAsyncOp<T> Validate(bool ok)
	{
		return null;
	}
}
