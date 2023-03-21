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

	[CallsUnknownMethods(Count = 13)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public static GetObjectAsyncOp<BrowseCatalogResult> BrowseCatalogAsync(int userId, string parentId, MediaItemType parentMediaType, MediaItemType childMediaType, CatalogSortOrder orderBy, uint skipItems, uint maxItems, GetObjectAsyncOp<BrowseCatalogResult>.GetObjectAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	public static GetObjectAsyncOp<BrowseCatalogResult> BrowseCatalogBundlesAsync(int userId, string parentId, MediaItemType parentMediaType, string productId, BundleRelationshipType relationship, uint skipItems, uint maxItems, GetObjectAsyncOp<BrowseCatalogResult>.GetObjectAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(CatalogServicePlugin), Member = "CatalogService_GetCatalogItemDetailsAsync")]
	[CallsUnknownMethods(Count = 11)]
	public static GetObjectAsyncOp<CatalogItemDetailsList> GetCatalogItemDetailsAsync(int userId, string[] productIds, GetObjectAsyncOp<CatalogItemDetailsList>.GetObjectAsyncCallback callback)
	{
		return null;
	}

	[Calls(Type = typeof(UnityPlugin.Log), Member = "LogCallbackException")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[UnityAOT.MonoPInvokeCallback(typeof(ObjectResultCallback))]
	public static void GetCatalogItemDetailsListThunk(uint result, IntPtr lresult, IntPtr userData)
	{
	}

	[UnityAOT.MonoPInvokeCallback(typeof(ObjectResultCallback))]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(UnityPlugin.Log), Member = "LogCallbackException")]
	public static void GetBrowseCatalogResultThunk(uint result, IntPtr lresult, IntPtr userData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public CatalogServiceManager()
	{
	}
}
