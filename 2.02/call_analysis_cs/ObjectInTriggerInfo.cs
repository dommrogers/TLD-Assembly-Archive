using Cpp2ILInjected.CallAnalysis;

public class ObjectInTriggerInfo
{
	public bool m_IsPlayer;

	public MissionObjectIdentifier m_MissionObjectIdentifier;

	public MissionTrigger m_TriggerComponent;

	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterMissionObject")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "MissionTriggerRemoved")]
	[CalledBy(Type = typeof(MissionTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(MissionTrigger), Member = "OnTriggerExit")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ObjectInTriggerInfo(MissionObjectIdentifier moi, MissionTrigger trigger)
	{
	}
}
