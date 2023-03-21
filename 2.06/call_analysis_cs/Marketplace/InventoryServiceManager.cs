using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace Marketplace;

public class InventoryServiceManager
{
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void Create()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(InventoryServiceManager), Member = "ValidatePlugin")]
	[CallsUnknownMethods(Count = 13)]
	public static GetObjectAsyncOp<ConsumeInventoryItemResult> ConsumeInventoryItemAsync(int userId, InventoryItem item, uint quantityToConsume, string transactionId, GetObjectAsyncOp<ConsumeInventoryItemResult>.GetObjectAsyncCallback callback)
	{
		return null;
	}

	[Calls(Type = typeof(InventoryServiceManager), Member = "ValidatePlugin")]
	[CallsUnknownMethods(Count = 13)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public static GetObjectAsyncOp<InventoryItem> GetInventoryItemAsync(int userId, InventoryItem inventoryItem, GetObjectAsyncOp<InventoryItem>.GetObjectAsyncCallback callback)
	{
		return null;
	}

	[Calls(Type = typeof(InventoryServiceManager), Member = "ValidatePlugin")]
	[CallsUnknownMethods(Count = 13)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public static GetObjectAsyncOp<InventoryItemsResult> GetInventoryItemsAsync(int userId, MediaItemType mediaItemType, GetObjectAsyncOp<InventoryItemsResult>.GetObjectAsyncCallback callback)
	{
		return null;
	}

	[Calls(Type = typeof(InventoryServiceManager), Member = "ValidatePlugin")]
	[CallsUnknownMethods(Count = 13)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public static GetObjectAsyncOp<InventoryItemsResult> GetInventoryItemsAsyncEx(int userId, MediaItemType mediaItemType, InventoryItemState inventoryItemState, InventoryItemAvailability inventoryItemAvailability, string inventoryItemContainerId, uint maxItems, GetObjectAsyncOp<InventoryItemsResult>.GetObjectAsyncCallback callback)
	{
		return null;
	}

	[Calls(Type = typeof(InventoryServiceManager), Member = "ValidatePlugin")]
	[CallsUnknownMethods(Count = 13)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public static GetObjectAsyncOp<InventoryItemsResult> GetInventoryItemsForAllUsersAsync(int userId, MediaItemType mediaItemType, GetObjectAsyncOp<InventoryItemsResult>.GetObjectAsyncCallback callback)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(InventoryServiceManager), Member = "ValidatePlugin")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public static GetObjectAsyncOp<InventoryItemsResult> GetInventoryItemsForAllUsersAsyncEx(int userId, MediaItemType mediaItemType, InventoryItemState inventoryItemState, InventoryItemAvailability inventoryItemAvailability, string inventoryItemContainerId, uint maxItems, GetObjectAsyncOp<InventoryItemsResult>.GetObjectAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "ConsumeInventoryItemAsync")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemAsync")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemsAsync")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemsAsyncEx")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemsForAllUsersAsync")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemsForAllUsersAsyncEx")]
	[CallsUnknownMethods(Count = 7)]
	private static void ValidatePlugin()
	{
	}

	[Calls(Type = typeof(UnityPlugin.Log), Member = "LogCallbackException")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[UnityAOT.MonoPInvokeCallback(typeof(ObjectResultCallback))]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static void GetConsumeInventoryItemResultThunk(uint result, IntPtr lresult, IntPtr userData)
	{
	}

	[UnityAOT.MonoPInvokeCallback(typeof(ObjectResultCallback))]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(UnityPlugin.Log), Member = "LogCallbackException")]
	public static void GetInventoryItemThunk(uint result, IntPtr lresult, IntPtr userData)
	{
	}

	[Calls(Type = typeof(UnityPlugin.Log), Member = "LogCallbackException")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[UnityAOT.MonoPInvokeCallback(typeof(ObjectResultCallback))]
	public static void GetInventoryItemsResultThunk(uint result, IntPtr lresult, IntPtr userData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public InventoryServiceManager()
	{
	}
}
