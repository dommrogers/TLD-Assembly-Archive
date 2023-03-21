using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SendMissionEventObject : MonoBehaviour
{
	public string m_EventName;

	public SendMissionEventTrigger m_TriggerRequiredForEvent;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsUnknownMethods(Count = 1)]
	public void PerformInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsUnknownMethods(Count = 1)]
	public void SendMissionEvent()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public SendMissionEventObject()
	{
	}
}
