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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
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

	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[CallerCount(Count = 0)]
	public void InteractOpenValve(bool isOpen)
	{
	}

	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Update()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SteamPipeValveManager), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 6)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[CalledBy(Type = typeof(SteamPipeValveManager), Member = "DeserializeAll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SteamPipeValve), Member = "MaybeShowFrozenValve")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "PerformInteraction")]
	[CallsUnknownMethods(Count = 1)]
	public void MaybeUpdateFrozenState()
	{
	}

	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnCloseValveComplete")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Update")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HandleInteractionChoice")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Deserialize")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[CallerCount(Count = 12)]
	public void SetPipeOpenState(bool playerInteraction)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private void SetValvePosition()
	{
	}

	[CalledBy(Type = typeof(SteamPipeValve), Member = "MaybeUpdateFrozenState")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "Deserialize")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "Start")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "Update")]
	private void MaybeShowFrozenValve()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ToggleValveInteraction()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnAttachValveComplete")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnValveActivateInteraction")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HandleInteractionChoice")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnOpenValveComplete()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	private void OnCloseValveComplete()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	public SteamPipeValve()
	{
	}
}
