using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace Marketplace;

public class CatalogServiceManager
{
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void Create()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetObjectAsyncOp<>), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public static GetObjectAsyncOp<BrowseCatalogResult> BrowseCatalogAsync(int userId, string parentId, MediaItemType parentMediaType, MediaItemType childMediaType, CatalogSortOrder orderBy, uint skipItems, uint maxItems, GetObjectAsyncOp<BrowseCatalogResult>.GetObjectAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetObjectAsyncOp<>), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public static GetObjectAsyncOp<BrowseCatalogResult> BrowseCatalogBundlesAsync(int userId, string parentId, MediaItemType parentMediaType, string productId, BundleRelationshipType relationship, uint skipItems, uint maxItems, GetObjectAsyncOp<BrowseCatalogResult>.GetObjectAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetObjectAsyncOp<>), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[Calls(Type = typeof(CatalogServicePlugin), Member = "CatalogService_GetCatalogItemDetailsAsync")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public static GetObjectAsyncOp<CatalogItemDetailsList> GetCatalogItemDetailsAsync(int userId, string[] productIds, GetObjectAsyncOp<CatalogItemDetailsList>.GetObjectAsyncCallback callback)
	{
		return null;
	}

	[UnityAOT.MonoPInvokeCallback(typeof(ObjectResultCallback))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetMyObject")]
	[Calls(Type = typeof(GetObjectAsyncOp<>), Member = "Complete")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(UnityPlugin.Log), Member = "LogCallbackException")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void GetCatalogItemDetailsListThunk(uint result, IntPtr lresult, IntPtr userData)
	{
	}

	[UnityAOT.MonoPInvokeCallback(typeof(ObjectResultCallback))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetMyObject")]
	[Calls(Type = typeof(GetObjectAsyncOp<>), Member = "Complete")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(UnityPlugin.Log), Member = "LogCallbackException")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void GetBrowseCatalogResultThunk(uint result, IntPtr lresult, IntPtr userData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public CatalogServiceManager()
	{
	}
}
