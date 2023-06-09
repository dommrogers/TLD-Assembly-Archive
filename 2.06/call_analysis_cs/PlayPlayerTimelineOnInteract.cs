using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayPlayerTimelineOnInteract : MonoBehaviour
{
	private HeldItemInPlacementZone m_HeldItemInPlacementZone;

	private TimelinePlayback.TimelineInfo m_TimelineToPlay;

	private GearItem m_EquippedItem;

	private TimelinePlayback.TimelineCallbacks m_Callbacks;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "AutoUnequipItemInHandsBeforeInteraction")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void PerformInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "AutoEquipItemInHandsAfterInteraction")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[CallsUnknownMethods(Count = 2)]
	private void OnTimelineEnded()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	public PlayPlayerTimelineOnInteract()
	{
	}
}
