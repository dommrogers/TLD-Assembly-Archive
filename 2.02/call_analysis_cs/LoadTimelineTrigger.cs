using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LoadTimelineTrigger : MonoBehaviour
{
	public TimelineRef[] m_Timelines;

	public TLD_TimelineDirector m_TimelineDirector;

	public string m_MissionIdentifierTarget;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(TimelineRef), Member = "Load")]
	[CallsUnknownMethods(Count = 13)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LoadTimelineTrigger()
	{
	}
}
