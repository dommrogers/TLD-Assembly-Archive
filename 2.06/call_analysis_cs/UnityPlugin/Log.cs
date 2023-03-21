using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using Marketplace;

namespace UnityPlugin;

internal class Log
{
	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(StoreManager), Member = "OnPurchaseThunk")]
	[CalledBy(Type = typeof(StoreManager), Member = "PrivilegeCheckResultThunk")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemsResultThunk")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemThunk")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetConsumeInventoryItemResultThunk")]
	[CalledBy(Type = typeof(DLCManager), Member = "OnInstalledWithDetailsThunk")]
	[CalledBy(Type = typeof(DLCManager), Member = "OnInstalledThunk")]
	[CalledBy(Type = typeof(CatalogServiceManager), Member = "GetBrowseCatalogResultThunk")]
	[CalledBy(Type = typeof(CatalogServiceManager), Member = "GetCatalogItemDetailsListThunk")]
	[CallerCount(Count = 9)]
	public static extern void LogCallbackException(string message);

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public Log()
	{
	}
}
