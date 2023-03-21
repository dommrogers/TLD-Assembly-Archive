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
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AISendMissionEvent()
	{
	}
}
