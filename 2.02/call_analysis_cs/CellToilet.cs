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

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private bool CanDoAnyInteraction()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(CellToilet), Member = "ProcessInteraction")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetCurrentMissionFilterTags")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(CellToilet), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(CellToilet), Member = "GetHoverText")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(CellToilet), Member = "GetHoverText")]
	[CallerCount(Count = 4)]
	private bool ShouldDoInteraction(string interaction)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(CellToilet), Member = "ShouldDoInteraction")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CellToilet), Member = "ShouldDoInteraction")]
	public string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CellToilet), Member = "ShouldDoInteraction")]
	[Calls(Type = typeof(CellToilet), Member = "ShouldDoInteraction")]
	[Calls(Type = typeof(CellToilet), Member = "DoSecondInteraction")]
	[Calls(Type = typeof(CellToilet), Member = "DoFirstInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallsUnknownMethods(Count = 1)]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void SetState(State state)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimeline")]
	[Calls(Type = typeof(CellToilet), Member = "PlayTimeline")]
	[CalledBy(Type = typeof(CellToilet), Member = "ProcessInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallerCount(Count = 1)]
	private void DoFirstInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraBasedHandPositioningMode")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsUnknownMethods(Count = 5)]
	private void OnGottenUp()
	{
	}

	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnWardenWrapUpDone()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(CellToilet), Member = "PlayTimeline")]
	[CalledBy(Type = typeof(CellToilet), Member = "ProcessInteraction")]
	[CallsUnknownMethods(Count = 9)]
	private void DoSecondInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsUnknownMethods(Count = 2)]
	private void OnReturnFromDamDone()
	{
	}

	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(DialogueTree), Member = "add_OnDialogueFinished")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetOnDialogueEndsAction")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DialogueTree), Member = "remove_OnDialogueFinished")]
	[CallsUnknownMethods(Count = 9)]
	private void OnDialogueTreeFinished(DialogueTree obj)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CellToilet), Member = "PlayTimeline")]
	[CallsUnknownMethods(Count = 10)]
	private void OnDialogueEnded()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(CellToilet), Member = "OnDialogueEnded")]
	[CalledBy(Type = typeof(CellToilet), Member = "DoFirstInteraction")]
	[CalledBy(Type = typeof(CellToilet), Member = "DoSecondInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	private void PlayTimeline(TimelinePlayback.TimelineInfo timelineInfo, Action onTimelineComplete)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimeline")]
	[CallsUnknownMethods(Count = 1)]
	private void LoadTimeline(TimelinePlayback.TimelineInfo timelineInfo)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public CellToilet()
	{
	}
}
