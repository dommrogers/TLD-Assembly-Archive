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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsUnknownMethods(Count = 1)]
	public void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public string GetGuid()
	{
		return null;
	}

	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	public void InteractOpenValve(bool isOpen)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[CalledBy(Type = typeof(SteamPipeValveManager), Member = "DeserializeAll")]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void MaybeUpdateFrozenState()
	{
	}

	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnAttachValveComplete")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnValveActivateInteraction")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Deserialize")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HandleInteractionChoice")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Update")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnCloseValveComplete")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveComplete")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "Deserialize")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "InteractOpenValve")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "Start")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 12)]
	public void SetPipeOpenState(bool playerInteraction)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnValidate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void SetValvePosition()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Update")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "MaybeUpdateFrozenState")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "Deserialize")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "Start")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "Update")]
	private void MaybeShowFrozenValve()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ToggleValveInteraction()
	{
	}

	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnAttachValveComplete")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnValveActivateInteraction")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HandleInteractionChoice")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnOpenValveInteraction(bool isOpening)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 1)]
	private void OnTimelineInterrupted()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnOpenValveComplete()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
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
