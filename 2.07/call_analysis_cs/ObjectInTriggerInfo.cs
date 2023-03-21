using System;
using Cpp2ILInjected.CallAnalysis;

public class ObjectInTriggerInfo
{
	public bool m_IsPlayer;

	public MissionObjectIdentifier m_MissionObjectIdentifier;

	public MissionTrigger m_TriggerComponent;

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(MissionTrigger), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(MissionTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "MissionTriggerRemoved")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterMissionObject")]
	public ObjectInTriggerInfo(MissionObjectIdentifier moi, MissionTrigger trigger)
	{
	}
}
