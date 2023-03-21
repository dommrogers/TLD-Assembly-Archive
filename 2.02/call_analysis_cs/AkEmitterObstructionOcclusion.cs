using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class AkEmitterObstructionOcclusion : AkObstructionOcclusion
{
	private AkGameObj m_gameObj;

	[Calls(Type = typeof(AkObstructionOcclusion), Member = "InitIntervalsAndFadeRates")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AkRoom), Member = "get_IsSpatialAudioEnabled")]
	[Calls(Type = typeof(AkSpatialAudioListener), Member = "get_TheSpatialAudioListener")]
	[CallsUnknownMethods(Count = 9)]
	protected override void UpdateCurrentListenerList()
	{
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkRoom), Member = "get_IsSpatialAudioEnabled")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
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
