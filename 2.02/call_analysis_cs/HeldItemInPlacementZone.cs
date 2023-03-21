using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class HeldItemInPlacementZone : MonoBehaviour
{
	private enum ItemStatus
	{
		None,
		Dropped,
		Placed,
		PickedUp
	}

	private ItemStatus m_CurrentItemStatus;

	private GearItem m_DroppedItem;

	private GearItem m_ClonedItem;

	public GameObject m_ZoneToPlace;

	public bool m_OnlyStashLitLightSources;

	private bool m_NeedsContinuousPositionUpdate;

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 8)]
	private void MaybeUpdateDroppedItemPosition()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_UnequipItemInHands), Member = "OnExecute")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[CalledBy(Type = typeof(PlayPlayerTimelineOnInteract), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(Phone), Member = "OnPhonePickup")]
	[CalledBy(Type = typeof(Elevator), Member = "EnterPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "DropItemFromHands")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "IsValidItemToPlace")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "IsValid")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MoveItemToTheZone")]
	public void MaybeHandleItemInHands()
	{
	}

	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[CalledBy(Type = typeof(Action_RetrieveLastItemInHands), Member = "OnExecute")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnCloseValveComplete")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveComplete")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[CalledBy(Type = typeof(PlayPlayerTimelineOnInteract), Member = "OnTimelineInterrupted")]
	[CalledBy(Type = typeof(PlayPlayerTimelineOnInteract), Member = "OnTimelineComplete")]
	[CalledBy(Type = typeof(Elevator), Member = "OnExitAnimationComplete")]
	[CalledBy(Type = typeof(Elevator), Member = "ExitPlayer")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "RetrievePlacedItemToHands")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Phone), Member = "OnPhoneHangupComplete")]
	public void MaybeProcessPickingUpPlacedItem()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveComplete")]
	public bool IsValid()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public bool IsValidItemToPlace(GearItem Item)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "ProcessMovingHeldItemToZone")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "DropLitItemToPlacementZone")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "Clone")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	private void DropItemFromHands()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "ProcessMovingHeldItemToZone")]
	[CallsUnknownMethods(Count = 21)]
	private void MoveItemToTheZone()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "DropItemFromHands")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MoveItemToTheZone")]
	private void ProcessMovingHeldItemToZone()
	{
	}

	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "RetrievePlacedItemToHands")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ProcessPickingUpPlacedItem()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "RemoveDuplicatedItem")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "SetGravity")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "ProcessPickingUpPlacedItem")]
	[CallsUnknownMethods(Count = 5)]
	private void RetrievePlacedItemToHands()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "SetGravity")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void ResetGravity(GameObject go, bool useGravity)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void SetItemStatus(ItemStatus itemStatus)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "Clone")]
	[CallsUnknownMethods(Count = 1)]
	private void DuplicateItemBeforeDrop(GearItem gi)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "RetrievePlacedItemToHands")]
	[CallsUnknownMethods(Count = 4)]
	private void RemoveDuplicatedItem()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public HeldItemInPlacementZone()
	{
	}
}
