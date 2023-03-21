using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SendMissionEventObject : MonoBehaviour
{
	public string m_EventName;

	public SendMissionEventTrigger m_TriggerRequiredForEvent;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
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
