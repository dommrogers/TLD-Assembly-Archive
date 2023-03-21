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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AISendMissionEvent()
	{
	}
}
