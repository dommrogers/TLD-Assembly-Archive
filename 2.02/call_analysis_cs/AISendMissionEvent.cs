using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AISendMissionEvent : MonoBehaviour
{
	public AiMode m_AITriggerState;

	public bool m_IsStoryMission;

	public string m_EventName;

	private BaseAi m_BaseAI;

	private bool m_SentEvent;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Start()
	{
	}

	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AISendMissionEvent()
	{
	}
}
