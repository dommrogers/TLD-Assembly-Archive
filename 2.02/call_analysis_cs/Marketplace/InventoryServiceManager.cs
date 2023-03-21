using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace Marketplace;

public class InventoryServiceManager
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void Create()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(InventoryServiceManager), Member = "ValidatePlugin")]
	[CallsUnknownMethods(Count = 18)]
	public static GetObjectAsyncOp<ConsumeInventoryItemResult> ConsumeInventoryItemAsync(int userId, InventoryItem item, uint quantityToConsume, string transactionId, GetObjectAsyncOp<ConsumeInventoryItemResult>.GetObjectAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(InventoryServiceManager), Member = "ValidatePlugin")]
	[CallsUnknownMethods(Count = 18)]
	public static GetObjectAsyncOp<InventoryItem> GetInventoryItemAsync(int userId, InventoryItem inventoryItem, GetObjectAsyncOp<InventoryItem>.GetObjectAsyncCallback callback)
	{
		return null;
	}

	[Calls(Type = typeof(InventoryServiceManager), Member = "ValidatePlugin")]
	[CallsUnknownMethods(Count = 17)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public static GetObjectAsyncOp<InventoryItemsResult> GetInventoryItemsAsync(int userId, MediaItemType mediaItemType, GetObjectAsyncOp<InventoryItemsResult>.GetObjectAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(InventoryServiceManager), Member = "ValidatePlugin")]
	[CallsUnknownMethods(Count = 17)]
	public static GetObjectAsyncOp<InventoryItemsResult> GetInventoryItemsAsyncEx(int userId, MediaItemType mediaItemType, InventoryItemState inventoryItemState, InventoryItemAvailability inventoryItemAvailability, string inventoryItemContainerId, uint maxItems, GetObjectAsyncOp<InventoryItemsResult>.GetObjectAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(InventoryServiceManager), Member = "ValidatePlugin")]
	[CallsUnknownMethods(Count = 17)]
	public static GetObjectAsyncOp<InventoryItemsResult> GetInventoryItemsForAllUsersAsync(int userId, MediaItemType mediaItemType, GetObjectAsyncOp<InventoryItemsResult>.GetObjectAsyncCallback callback)
	{
		return null;
	}

	[Calls(Type = typeof(InventoryServiceManager), Member = "ValidatePlugin")]
	[CallsUnknownMethods(Count = 17)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public static GetObjectAsyncOp<InventoryItemsResult> GetInventoryItemsForAllUsersAsyncEx(int userId, MediaItemType mediaItemType, InventoryItemState inventoryItemState, InventoryItemAvailability inventoryItemAvailability, string inventoryItemContainerId, uint maxItems, GetObjectAsyncOp<InventoryItemsResult>.GetObjectAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "ConsumeInventoryItemAsync")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemAsync")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemsAsync")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemsAsyncEx")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemsForAllUsersAsync")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemsForAllUsersAsyncEx")]
	[CallsUnknownMethods(Count = 3)]
	private static void ValidatePlugin()
	{
	}

	[Calls(Type = typeof(UnityPlugin.Log), Member = "LogCallbackException")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[CallerCount(Count = 0)]
	[UnityAOT.MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallsDeduplicatedMethods(Count = 4)]
	public static void GetConsumeInventoryItemResultThunk(uint result, IntPtr lresult, IntPtr userData)
	{
	}

	[UnityAOT.MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(UnityPlugin.Log), Member = "LogCallbackException")]
	public static void GetInventoryItemThunk(uint result, IntPtr lresult, IntPtr userData)
	{
	}

	[Calls(Type = typeof(UnityPlugin.Log), Member = "LogCallbackException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[UnityAOT.MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	public static void GetInventoryItemsResultThunk(uint result, IntPtr lresult, IntPtr userData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public InventoryServiceManager()
	{
	}
}
