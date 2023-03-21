using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LoadTimelineTrigger : MonoBehaviour
{
	public TimelineRef[] m_Timelines;

	public TLD_TimelineDirector m_TimelineDirector;

	public string m_MissionIdentifierTarget;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(TimelineRef), Member = "Load")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LoadTimelineTrigger()
	{
	}
}
