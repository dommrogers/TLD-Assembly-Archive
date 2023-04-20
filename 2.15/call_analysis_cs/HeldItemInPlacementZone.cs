using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class HeldItemInPlacementZone : MonoBehaviour
{
	private enum ItemStatus
	{
		None,
		Placed
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
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void MaybeUpdateDroppedItemPosition()
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "EnterPlayer")]
	[CalledBy(Type = typeof(Phone), Member = "OnPhonePickup")]
	[CalledBy(Type = typeof(PlayPlayerTimelineOnInteract), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[CalledBy(Type = typeof(Action_UnequipItemInHands), Member = "OnExecute")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "ProcessMovingHeldItemToZone")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[CallsUnknownMethods(Count = 1)]
	public void MaybeHandleItemInHands()
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "ExitPlayer")]
	[CalledBy(Type = typeof(Elevator), Member = "OnExitAnimationComplete")]
	[CalledBy(Type = typeof(Phone), Member = "OnPhoneHangup")]
	[CalledBy(Type = typeof(Phone), Member = "OnPhoneHangupComplete")]
	[CalledBy(Type = typeof(PlayPlayerTimelineOnInteract), Member = "RestoreItemInHands")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveComplete")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnCloseValveComplete")]
	[CalledBy(Type = typeof(Action_RetrieveLastItemInHands), Member = "OnExecute")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "ProcessPickingUpPlacedItem")]
	public void MaybeProcessPickingUpPlacedItem()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void MaybeProcessPickingUpPlacedItemImmediate()
	{
	}

	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "SetGravity")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void ProcessPickingUpPlacedItem(bool immediate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public bool IsValid()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsValidItemToPlace(GearItem Item)
	{
		return false;
	}

	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "Clone")]
	[Calls(Type = typeof(PlayerManager), Member = "DropLitItemToPlacementZone")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 11)]
	private void ProcessMovingHeldItemToZone()
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[CallsDeduplicatedMethods(Count = 1)]
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
