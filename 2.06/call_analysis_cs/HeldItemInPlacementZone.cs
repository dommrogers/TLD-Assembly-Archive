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
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void MaybeUpdateDroppedItemPosition()
	{
	}

	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[CalledBy(Type = typeof(Action_UnequipItemInHands), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayPlayerTimelineOnInteract), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(Elevator), Member = "EnterPlayer")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MoveItemToTheZone")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "DropItemFromHands")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
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

	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	public bool IsValidItemToPlace(GearItem Item)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "ProcessMovingHeldItemToZone")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "Clone")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "DropLitItemToPlacementZone")]
	private void DropItemFromHands()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "ProcessMovingHeldItemToZone")]
	[CallsUnknownMethods(Count = 11)]
	private void MoveItemToTheZone()
	{
	}

	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MoveItemToTheZone")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "DropItemFromHands")]
	private void ProcessMovingHeldItemToZone()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "RetrievePlacedItemToHands")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	private void ProcessPickingUpPlacedItem()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "ProcessPickingUpPlacedItem")]
	[Calls(Type = typeof(PlayerManager), Member = "SetGravity")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "Clone")]
	[CallsUnknownMethods(Count = 1)]
	private void DuplicateItemBeforeDrop(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void RemoveDuplicatedItem()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public HeldItemInPlacementZone()
	{
	}
}
