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
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsUnknownMethods(Count = 2)]
	public void SendMissionEvent()
	{
	}

	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
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
