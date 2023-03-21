using System;
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

	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public string GetGuid()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[CallsUnknownMethods(Count = 3)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[CallsUnknownMethods(Count = 1)]
	public void MaybeUpdateFrozenState()
	{
	}

	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnCloseValveComplete")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Update")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HandleInteractionChoice")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnAttachValveComplete")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveComplete")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnValveActivateInteraction")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "Deserialize")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "InteractOpenValve")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "Start")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	public void SetPipeOpenState(bool playerInteraction)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void OnValidate()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void SetValvePosition()
	{
	}

	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Update")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "MaybeUpdateFrozenState")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "Deserialize")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "Start")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "Update")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void MaybeShowFrozenValve()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ToggleValveInteraction()
	{
	}

	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnAttachValveComplete")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnValveActivateInteraction")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HandleInteractionChoice")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	public void OnOpenValveInteraction(bool isOpening)
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnTimelineInterrupted()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 1)]
	private void OnOpenValveComplete()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnCloseValveComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public SteamPipeValve()
	{
	}
}
