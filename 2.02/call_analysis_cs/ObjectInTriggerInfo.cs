using Cpp2ILInjected.CallAnalysis;

public class ObjectInTriggerInfo
{
	public bool m_IsPlayer;

	public MissionObjectIdentifier m_MissionObjectIdentifier;

	public MissionTrigger m_TriggerComponent;

	[CalledBy(Type = typeof(MissionTrigger), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(MissionTrigger), Member = "OnTriggerEnter")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "MissionTriggerRemoved")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterMissionObject")]
	public ObjectInTriggerInfo(MissionObjectIdentifier moi, MissionTrigger trigger)
	{
	}
}
