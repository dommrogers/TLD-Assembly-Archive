using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using Marketplace;

namespace UnityPlugin;

internal class Log
{
	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(CatalogServiceManager), Member = "GetCatalogItemDetailsListThunk")]
	[CalledBy(Type = typeof(CatalogServiceManager), Member = "GetBrowseCatalogResultThunk")]
	[CalledBy(Type = typeof(DLCManager), Member = "OnInstalledThunk")]
	[CalledBy(Type = typeof(DLCManager), Member = "OnInstalledWithDetailsThunk")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetConsumeInventoryItemResultThunk")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemThunk")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemsResultThunk")]
	[CalledBy(Type = typeof(StoreManager), Member = "PrivilegeCheckResultThunk")]
	[CalledBy(Type = typeof(StoreManager), Member = "OnPurchaseThunk")]
	public static extern void LogCallbackException(string message);

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public Log()
	{
	}
}
