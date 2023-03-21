using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SendMissionEventObject : MonoBehaviour
{
	public string m_EventName;

	public SendMissionEventTrigger m_TriggerRequiredForEvent;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	public void PerformInteraction()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallerCount(Count = 0)]
	public void SendMissionEvent()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SendMissionEventObject()
	{
	}
}
