using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.DialogueTrees;
using UnityEngine;

public class CellToilet : MonoBehaviour
{
	private enum State
	{
		WaitingForPlayer,
		WaitingForDialogue,
		Idle,
		Finished
	}

	public LocalizedString m_LocalizedHoverText;

	private TimelinePlayback m_TimelinePlayback;

	private TimelinePlayback.TimelineInfo m_GetUpTimeline;

	private TimelinePlayback.TimelineInfo m_WardenWrapUpTimeline;

	private TimelinePlayback.TimelineInfo m_ReturnFromDamTimeline;

	private string m_FirstWardenInteraction;

	private string m_SecondWardenInteraction;

	private Vector3 m_ExitPosition;

	private Quaternion m_ExitRotation;

	private Vector3 m_ExitCameraPosition;

	private State m_State;

	private PlayerAnimation m_PlayerAnimation;

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private bool CanDoAnyInteraction()
	{
		return false;
	}

	[CalledBy(Type = typeof(CellToilet), Member = "GetHoverText")]
	[CalledBy(Type = typeof(CellToilet), Member = "ProcessInteraction")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetCurrentMissionFilterTags")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool ShouldDoInteraction(string interaction)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CellToilet), Member = "ShouldDoInteraction")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string GetHoverText()
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CellToilet), Member = "ShouldDoInteraction")]
	[Calls(Type = typeof(CellToilet), Member = "DoSecondInteraction")]
	[Calls(Type = typeof(CellToilet), Member = "DoFirstInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool ProcessInteraction()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void SetState(State state)
	{
	}

	[CalledBy(Type = typeof(CellToilet), Member = "ProcessInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(CellToilet), Member = "PlayTimeline")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimeline")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private void DoFirstInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraBasedHandPositioningMode")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void OnGottenUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnWardenWrapUpDone()
	{
	}

	[CalledBy(Type = typeof(CellToilet), Member = "ProcessInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(CellToilet), Member = "PlayTimeline")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void DoSecondInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnReturnFromDamDone()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(DialogueTree), Member = "add_OnDialogueFinished")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetOnDialogueEndsAction")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 32)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueTree), Member = "remove_OnDialogueFinished")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void OnDialogueTreeFinished(DialogueTree obj)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CellToilet), Member = "PlayTimeline")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void OnDialogueEnded()
	{
	}

	[CalledBy(Type = typeof(CellToilet), Member = "DoFirstInteraction")]
	[CalledBy(Type = typeof(CellToilet), Member = "DoSecondInteraction")]
	[CalledBy(Type = typeof(CellToilet), Member = "OnDialogueEnded")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private void PlayTimeline(TimelinePlayback.TimelineInfo timelineInfo, Action onTimelineComplete)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimeline")]
	[CallsUnknownMethods(Count = 1)]
	private void LoadTimeline(TimelinePlayback.TimelineInfo timelineInfo)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public CellToilet()
	{
	}
}
