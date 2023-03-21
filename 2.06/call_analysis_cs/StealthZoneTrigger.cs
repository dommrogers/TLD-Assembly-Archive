using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class StealthZoneTrigger : MonoBehaviour
{
	public bool m_RequirePlayerCrouch;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
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
	[CallerCount(Count = 12)]
	public StealthZoneTrigger()
	{
	}
}
