using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SteamPipeValve : MonoBehaviour
{
	public SteamPipe m_SteamPipe;

	public LocalizedString m_LocalizedDisplayName;

	public LocalizedString m_FrozenLocalizedName;

	public LocalizedString m_OpenLocalizedName;

	public LocalizedString m_ClosedLocalizedName;

	public float m_UnfrozenFlowValue;

	public bool m_IsFrozen;

	public float m_ValveOpenPercent;

	public float m_ValveClosedPercent;

	public bool m_IsOpen;

	public GameObject m_FrozenValve;

	public GameObject m_UnfrozenValve;

	public Animator m_ValveAnimator;

	private TimelinePlayback.TimelineInfo m_TimelineToPlayOpen;

	private TimelinePlayback.TimelineInfo m_TimelineToPlayClose;

	public Action m_TimelineOpenCompleteCallback;

	public Action m_TimelineOpenInterruptedCallback;

	public Action m_TimelineCloseCompleteCallback;

	public Action m_TimelineCloseInterruptedCallback;

	private TimelinePlayback m_TimelinePlayback;

	public int m_AnimParameter_OpenState;

	private string m_Guid;

	private HeldItemInPlacementZone m_HeldItemInPlacementZone;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[CallsUnknownMethods(Count = 1)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public string GetGuid()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[CallsUnknownMethods(Count = 3)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	public string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	public void InteractOpenValve(bool isOpen)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[CallsUnknownMethods(Count = 1)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(SteamPipeValveManager), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 8)]
	public string Serialize()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SteamPipeValveManager), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ProcessInteraction")]
	[CallsUnknownMethods(Count = 1)]
	public void MaybeUpdateFrozenState()
	{
	}

	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnValveActivateInteraction")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Deserialize")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HandleInteractionChoice")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Update")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnCloseValveComplete")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveComplete")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "Start")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "InteractOpenValve")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnAttachValveComplete")]
	[Calls(Type = typeof(SteamPipe), Member = "MaybePlayOpenCloseAudio")]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 4)]
	public void SetPipeOpenState(bool playerInteraction)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private void SetValvePosition()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Update")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "MaybeUpdateFrozenState")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "Update")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "Deserialize")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "Start")]
	private void MaybeShowFrozenValve()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ToggleValveInteraction()
	{
	}

	[CallsUnknownMethods(Count = 59)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnAttachValveComplete")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnValveActivateInteraction")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HandleInteractionChoice")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "IsValid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	public void OnOpenValveInteraction(bool isOpening)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 2)]
	private void OnTimelineInterrupted()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "IsValid")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	private void OnOpenValveComplete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 2)]
	private void OnCloseValveComplete()
	{
	}

	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public SteamPipeValve()
	{
	}
}
