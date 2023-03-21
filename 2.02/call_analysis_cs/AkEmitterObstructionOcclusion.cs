using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkEmitterObstructionOcclusion : AkObstructionOcclusion
{
	private AkGameObj m_gameObj;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkObstructionOcclusion), Member = "InitIntervalsAndFadeRates")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkRoom), Member = "get_IsSpatialAudioEnabled")]
	[Calls(Type = typeof(AkSpatialAudioListener), Member = "get_TheSpatialAudioListener")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	protected override void UpdateCurrentListenerList()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkRoom), Member = "get_IsSpatialAudioEnabled")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 8)]
	protected override void SetObstructionOcclusion(KeyValuePair<AkAudioListener, ObstructionOcclusionValue> ObsOccPair)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkObstructionOcclusion), Member = ".ctor")]
	public AkEmitterObstructionOcclusion()
	{
	}
}
