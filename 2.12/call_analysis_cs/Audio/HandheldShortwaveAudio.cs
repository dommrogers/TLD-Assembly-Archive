using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using InteractiveObjects;
using TLD.Electrostatic;
using UnityEngine;

namespace Audio;

public class HandheldShortwaveAudio : MonoBehaviour
{
	private AK.Wwise.Event m_RangeThresholdEnterAudioEvent;

	private AK.Wwise.Event m_RangeThresholdExitAudioEvent;

	private AK.Wwise.Event m_EquippedInHandAudioEvent;

	private AK.Wwise.Event m_AddedToBackpackAudioEvent;

	private AK.Wwise.Event m_ElectrostaticForceActiveEvent;

	private AK.Wwise.Event m_ElectrostaticForceDeactiveEvent;

	private RTPC m_SignalStrengthRTPC;

	private RTPC m_DistanceRTPC;

	private HandheldShortwaveItem m_Handheldshortwave;

	private bool m_RangeThreshholdEnteredPlayed;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ElectrostaticForce), Member = "add_m_IsActiveChanged")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(HandheldShortwaveItem), Member = "UpdateAudio")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(RTPC), Member = "SetValue")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void UpdateAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnTrackingModeChanged(TrackableItemType trackableMode)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnItemAddedToBackpack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnItemEquippedInHand()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnElectrostaticActivationChanged(bool isActive)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateRangeAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTPC), Member = "SetValue")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateRTPCValues()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ElectrostaticForce), Member = "remove_m_IsActiveChanged")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HandheldShortwaveItem), Member = "remove_m_TrackingModeChanged")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HandheldShortwaveItem), Member = "add_m_TrackingModeChanged")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public HandheldShortwaveAudio()
	{
	}
}
