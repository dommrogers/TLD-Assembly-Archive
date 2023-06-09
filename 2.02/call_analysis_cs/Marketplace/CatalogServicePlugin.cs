using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace Marketplace;

public class CatalogServicePlugin
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool CatalogService_BrowseCatalogAsync(int userId, string parentId, uint parentMediaType, uint childMediaType, uint orderBy, uint skipItems, uint maxItems, ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool CatalogService_BrowseCatalogBundlesAsync(int userId, string parentId, uint parentMediaType, string productId, uint relationship, uint skipItems, uint maxItems, ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CalledBy(Type = typeof(CatalogServiceManager), Member = "GetCatalogItemDetailsAsync")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool CatalogService_GetCatalogItemDetailsAsync(int userId, [In] string[] productIds, int numProductIds, ObjectResultCallback callback, IntPtr userData);

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public CatalogServicePlugin()
	{
	}
}
