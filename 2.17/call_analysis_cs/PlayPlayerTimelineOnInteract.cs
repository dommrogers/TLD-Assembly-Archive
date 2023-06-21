using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Events;

public class PlayPlayerTimelineOnInteract : MonoBehaviour
{
	private HeldItemInPlacementZone m_HeldItemInPlacementZone;

	private TimelinePlayback.TimelineInfo m_TimelineToPlay;

	private UnityEvent m_OnTimelineBegin;

	private UnityEvent m_OnTimelineInterrupted;

	private UnityEvent m_OnTimelineEnded;

	private GearItem m_EquippedItem;

	private TimelinePlayback.TimelineCallbacks m_Callbacks;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
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
	[CallsUnknownMethods(Count = 4)]
	public void PerformInteraction()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEvent), Member = "Invoke")]
	private void OnTimelineBegin()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEvent), Member = "Invoke")]
	[Calls(Type = typeof(PlayPlayerTimelineOnInteract), Member = "RestoreItemInHands")]
	private void OnTimelineInterrupted()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnTimelineEnded()
	{
	}

	[CalledBy(Type = typeof(PlayPlayerTimelineOnInteract), Member = "OnTimelineInterrupted")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "AutoEquipItemInHandsAfterInteraction")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[CallsUnknownMethods(Count = 2)]
	private void RestoreItemInHands()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public PlayPlayerTimelineOnInteract()
	{
	}
}
