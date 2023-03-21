using System;
using Cpp2ILInjected.CallAnalysis;

public class ObjectInTriggerInfo
{
	public bool m_IsPlayer;

	public MissionObjectIdentifier m_MissionObjectIdentifier;

	public MissionTrigger m_TriggerComponent;

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterMissionObject")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "MissionTriggerRemoved")]
	[CalledBy(Type = typeof(MissionTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(MissionTrigger), Member = "OnTriggerExit")]
	[CallsUnknownMethods(Count = 1)]
	public ObjectInTriggerInfo(MissionObjectIdentifier moi, MissionTrigger trigger)
	{
	}
}
