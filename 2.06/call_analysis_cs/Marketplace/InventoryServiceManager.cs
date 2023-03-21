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
	[Calls(Type = typeof(InventoryServiceManager), Member = "ValidatePlugin")]
	[Calls(Type = typeof(GetObjectAsyncOp<>), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public static GetObjectAsyncOp<ConsumeInventoryItemResult> ConsumeInventoryItemAsync(int userId, InventoryItem item, uint quantityToConsume, string transactionId, GetObjectAsyncOp<ConsumeInventoryItemResult>.GetObjectAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InventoryServiceManager), Member = "ValidatePlugin")]
	[Calls(Type = typeof(GetObjectAsyncOp<>), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public static GetObjectAsyncOp<InventoryItem> GetInventoryItemAsync(int userId, InventoryItem inventoryItem, GetObjectAsyncOp<InventoryItem>.GetObjectAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InventoryServiceManager), Member = "ValidatePlugin")]
	[Calls(Type = typeof(GetObjectAsyncOp<>), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public static GetObjectAsyncOp<InventoryItemsResult> GetInventoryItemsAsync(int userId, MediaItemType mediaItemType, GetObjectAsyncOp<InventoryItemsResult>.GetObjectAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InventoryServiceManager), Member = "ValidatePlugin")]
	[Calls(Type = typeof(GetObjectAsyncOp<>), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public static GetObjectAsyncOp<InventoryItemsResult> GetInventoryItemsAsyncEx(int userId, MediaItemType mediaItemType, InventoryItemState inventoryItemState, InventoryItemAvailability inventoryItemAvailability, string inventoryItemContainerId, uint maxItems, GetObjectAsyncOp<InventoryItemsResult>.GetObjectAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InventoryServiceManager), Member = "ValidatePlugin")]
	[Calls(Type = typeof(GetObjectAsyncOp<>), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public static GetObjectAsyncOp<InventoryItemsResult> GetInventoryItemsForAllUsersAsync(int userId, MediaItemType mediaItemType, GetObjectAsyncOp<InventoryItemsResult>.GetObjectAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InventoryServiceManager), Member = "ValidatePlugin")]
	[Calls(Type = typeof(GetObjectAsyncOp<>), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public static GetObjectAsyncOp<InventoryItemsResult> GetInventoryItemsForAllUsersAsyncEx(int userId, MediaItemType mediaItemType, InventoryItemState inventoryItemState, InventoryItemAvailability inventoryItemAvailability, string inventoryItemContainerId, uint maxItems, GetObjectAsyncOp<InventoryItemsResult>.GetObjectAsyncCallback callback)
	{
		return null;
	}

	[CalledBy(Type = typeof(InventoryServiceManager), Member = "ConsumeInventoryItemAsync")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemAsync")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemsAsync")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemsAsyncEx")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemsForAllUsersAsync")]
	[CalledBy(Type = typeof(InventoryServiceManager), Member = "GetInventoryItemsForAllUsersAsyncEx")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private static void ValidatePlugin()
	{
	}

	[UnityAOT.MonoPInvokeCallback(typeof(ObjectResultCallback))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetMyObject")]
	[Calls(Type = typeof(GetObjectAsyncOp<>), Member = "Complete")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(UnityPlugin.Log), Member = "LogCallbackException")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void GetConsumeInventoryItemResultThunk(uint result, IntPtr lresult, IntPtr userData)
	{
	}

	[UnityAOT.MonoPInvokeCallback(typeof(ObjectResultCallback))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetMyObject")]
	[Calls(Type = typeof(GetObjectAsyncOp<>), Member = "Complete")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(UnityPlugin.Log), Member = "LogCallbackException")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void GetInventoryItemThunk(uint result, IntPtr lresult, IntPtr userData)
	{
	}

	[UnityAOT.MonoPInvokeCallback(typeof(ObjectResultCallback))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetMyObject")]
	[Calls(Type = typeof(GetObjectAsyncOp<>), Member = "Complete")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(UnityPlugin.Log), Member = "LogCallbackException")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void GetInventoryItemsResultThunk(uint result, IntPtr lresult, IntPtr userData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public InventoryServiceManager()
	{
	}
}
