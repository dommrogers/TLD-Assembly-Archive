using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayPlayerTimelineOnInteract : MonoBehaviour
{
	private TimelinePlayback.TimelineInfo m_TimelineToPlay;

	public Action m_TimelineCompleteCallback;

	public Action m_TimelineInterruptedCallback;

	public LocalizedString m_LocalizedDisplayName;

	public TimelinePlayback m_TimelinePlayback;

	private HeldItemInPlacementZone m_HeldItemInPlacementZone;

	public string m_DisplayName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void OnValidate()
	{
	}

	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallsUnknownMethods(Count = 25)]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnTimelineComplete()
	{
	}

	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnTimelineInterrupted()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	public PlayPlayerTimelineOnInteract()
	{
	}
}
