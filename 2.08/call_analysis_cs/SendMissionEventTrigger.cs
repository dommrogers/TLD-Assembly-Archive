using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SendMissionEventTrigger : MonoBehaviour
{
	public string m_EventName;

	public bool m_SendEventOnEnterTrigger;

	private bool m_PlayerIsInsideTrigger;

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool PlayerIsInsideTrigger()
	{
		return default(bool);
	}

	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void SendMissionEvent()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnTriggerExit(Collider c)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SendMissionEventTrigger()
	{
	}
}
