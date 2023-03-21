using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkRoomPortalObstruction : AkObstructionOcclusion
{
	private AkRoomPortal m_portal;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkObstructionOcclusion), Member = "InitIntervalsAndFadeRates")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSpatialAudioListener), Member = "get_TheSpatialAudioListener")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void UpdateCurrentListenerList()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID")]
	[CallsDeduplicatedMethods(Count = 3)]
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
