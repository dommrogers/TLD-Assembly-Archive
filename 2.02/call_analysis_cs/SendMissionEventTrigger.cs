using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SendMissionEventTrigger : MonoBehaviour
{
	public string m_EventName;

	public bool m_SendEventOnEnterTrigger;

	private bool m_PlayerIsInsideTrigger;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool PlayerIsInsideTrigger()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SendMissionEvent()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void OnTriggerExit(Collider c)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SendMissionEventTrigger()
	{
	}
}
