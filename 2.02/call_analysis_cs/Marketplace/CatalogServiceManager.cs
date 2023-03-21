using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace Marketplace;

public class CatalogServiceManager
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void Create()
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public static GetObjectAsyncOp<BrowseCatalogResult> BrowseCatalogAsync(int userId, string parentId, MediaItemType parentMediaType, MediaItemType childMediaType, CatalogSortOrder orderBy, uint skipItems, uint maxItems, GetObjectAsyncOp<BrowseCatalogResult>.GetObjectAsyncCallback callback)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 17)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public static GetObjectAsyncOp<BrowseCatalogResult> BrowseCatalogBundlesAsync(int userId, string parentId, MediaItemType parentMediaType, string productId, BundleRelationshipType relationship, uint skipItems, uint maxItems, GetObjectAsyncOp<BrowseCatalogResult>.GetObjectAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(CatalogServicePlugin), Member = "CatalogService_GetCatalogItemDetailsAsync")]
	[CallsUnknownMethods(Count = 16)]
	public static GetObjectAsyncOp<CatalogItemDetailsList> GetCatalogItemDetailsAsync(int userId, string[] productIds, GetObjectAsyncOp<CatalogItemDetailsList>.GetObjectAsyncCallback callback)
	{
		return null;
	}

	[UnityAOT.MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(UnityPlugin.Log), Member = "LogCallbackException")]
	public static void GetCatalogItemDetailsListThunk(uint result, IntPtr lresult, IntPtr userData)
	{
	}

	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(UnityPlugin.Log), Member = "LogCallbackException")]
	[CallerCount(Count = 0)]
	[UnityAOT.MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallsDeduplicatedMethods(Count = 4)]
	public static void GetBrowseCatalogResultThunk(uint result, IntPtr lresult, IntPtr userData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public CatalogServiceManager()
	{
	}
}
