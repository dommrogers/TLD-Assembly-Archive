using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkRoomPortalObstruction : AkObstructionOcclusion
{
	private AkRoomPortal m_portal;

	[Calls(Type = typeof(AkObstructionOcclusion), Member = "InitIntervalsAndFadeRates")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(AkSpatialAudioListener), Member = "get_TheSpatialAudioListener")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void UpdateCurrentListenerList()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID")]
	[CallsUnknownMethods(Count = 4)]
	protected override void SetObstructionOcclusion(KeyValuePair<AkAudioListener, ObstructionOcclusionValue> ObsOccPair)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkObstructionOcclusion), Member = ".ctor")]
	public AkRoomPortalObstruction()
	{
	}
}
