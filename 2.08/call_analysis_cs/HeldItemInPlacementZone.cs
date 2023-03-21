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

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void MaybeUpdateDroppedItemPosition()
	{
	}

	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "DropItemFromHands")]
	[CalledBy(Type = typeof(Action_UnequipItemInHands), Member = "OnExecute")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[CalledBy(Type = typeof(PlayPlayerTimelineOnInteract), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(Phone), Member = "OnPhonePickup")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Elevator), Member = "EnterPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MoveItemToTheZone")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void MaybeHandleItemInHands()
	{
	}

	[CalledBy(Type = typeof(Action_RetrieveLastItemInHands), Member = "OnExecute")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnCloseValveComplete")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveComplete")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[CalledBy(Type = typeof(Phone), Member = "OnPhoneHangupComplete")]
	[CalledBy(Type = typeof(PlayPlayerTimelineOnInteract), Member = "OnTimelineEnded")]
	[CalledBy(Type = typeof(Elevator), Member = "OnExitAnimationComplete")]
	[CalledBy(Type = typeof(Elevator), Member = "ExitPlayer")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "RetrievePlacedItemToHands")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Phone), Member = "OnPhoneHangup")]
	public void MaybeProcessPickingUpPlacedItem()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public bool IsValid()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsValidItemToPlace(GearItem Item)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "DropLitItemToPlacementZone")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "ProcessMovingHeldItemToZone")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(GearItem), Member = "Clone")]
	[Calls(Type = typeof(PlayerManager), Member = "DropLitItemToPlacementZone")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	private void DropItemFromHands()
	{
	}

	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "ProcessMovingHeldItemToZone")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[CallsUnknownMethods(Count = 11)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void MoveItemToTheZone()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "DropItemFromHands")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MoveItemToTheZone")]
	private void ProcessMovingHeldItemToZone()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "RetrievePlacedItemToHands")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	private void ProcessPickingUpPlacedItem()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "SetGravity")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "ProcessPickingUpPlacedItem")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private void RetrievePlacedItemToHands()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "SetGravity")]
	private static void ResetGravity(GameObject go, bool useGravity)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void SetItemStatus(ItemStatus itemStatus)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "Clone")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private void DuplicateItemBeforeDrop(GearItem gi)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[CallsUnknownMethods(Count = 3)]
	private void RemoveDuplicatedItem()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public HeldItemInPlacementZone()
	{
	}
}
