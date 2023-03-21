using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class MissionServicesManagerSaveProxy
{
	public string m_SerializedGlobalBlackboard;

	public List<string> m_SerializedMissions;

	public List<string> m_SerializedConcurrentGraphs;

	public List<string> m_SerializedTimers;

	public string m_VisibleMissionTimer;

	public List<string> m_MissionObjectFilterTags;

	public List<string> m_CustomManagedObjects;

	public List<CustomManagedObjectState> m_CustomManagedObjectStates;

	[CalledBy(Type = typeof(MissionServicesManager), Member = ".cctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public MissionServicesManagerSaveProxy()
	{
	}
}
