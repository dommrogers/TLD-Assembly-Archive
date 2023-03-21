using System;
using Cpp2ILInjected.CallAnalysis;

public class ObjectInTriggerInfo
{
	public bool m_IsPlayer;

	public MissionObjectIdentifier m_MissionObjectIdentifier;

	public MissionTrigger m_TriggerComponent;

	[CalledBy(Type = typeof(MissionTrigger), Member = "OnTriggerExit")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "MissionTriggerRemoved")]
	[CalledBy(Type = typeof(MissionTrigger), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterMissionObject")]
	public ObjectInTriggerInfo(MissionObjectIdentifier moi, MissionTrigger trigger)
	{
	}
}
