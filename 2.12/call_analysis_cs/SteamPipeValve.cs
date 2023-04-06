using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
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
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public string GetGuid()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	public void InteractOpenValve(bool isOpen)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[CallsUnknownMethods(Count = 1)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SteamPipeValveManager), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[CallsUnknownMethods(Count = 1)]
	public void MaybeUpdateFrozenState()
	{
	}

	[CalledBy(Type = typeof(SteamPipeValve), Member = "Start")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "InteractOpenValve")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "Deserialize")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveComplete")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnCloseValveComplete")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Update")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HandleInteractionChoice")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Deserialize")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnValveActivateInteraction")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnAttachValveComplete")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void SetPipeOpenState(bool playerInteraction)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetValvePosition()
	{
	}

	[CalledBy(Type = typeof(SteamPipeValve), Member = "Start")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "Update")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "Deserialize")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "MaybeUpdateFrozenState")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Update")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "PerformInteraction")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeShowFrozenValve()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ToggleValveInteraction()
	{
	}

	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HandleInteractionChoice")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnValveActivateInteraction")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnAttachValveComplete")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	public void OnOpenValveInteraction(bool isOpening)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnTimelineInterrupted()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnOpenValveComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnCloseValveComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public SteamPipeValve()
	{
	}
}
