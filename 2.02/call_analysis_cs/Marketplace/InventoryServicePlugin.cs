using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace Marketplace;

public class InventoryServicePlugin
{
	[PreserveSig]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static extern bool InventoryService_ConsumeInventoryItemAsync(int userId, IntPtr item, uint quantityToConsume, string transactionId, ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern bool InventoryService_GetInventoryItemAsync(int userId, IntPtr inventoryItem, ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool InventoryService_GetInventoryItemsAsync(int userId, MediaItemType mediaItemType, ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool InventoryService_GetInventoryItemsAsyncEx(int userId, MediaItemType mediaItemType, InventoryItemState inventoryItemState, InventoryItemAvailability inventoryItemAvailability, string inventoryItemContainerId, uint maxItems, ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool InventoryService_GetInventoryItemsForAllUsersAsync(int userId, MediaItemType mediaItemType, ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool InventoryService_GetInventoryItemsForAllUsersAsyncEx(int userId, MediaItemType mediaItemType, InventoryItemState inventoryItemState, InventoryItemAvailability inventoryItemAvailability, string inventoryItemContainerId, uint maxItems, ObjectResultCallback callback, IntPtr userData);

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public InventoryServicePlugin()
	{
	}
}
