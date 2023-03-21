using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HeldItemRestrictionTrigger : MonoBehaviour
{
	public HeldItemRestriction m_Restriction;

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "RestrictHeldItems")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnTriggerExit(Collider c)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public HeldItemRestrictionTrigger()
	{
	}
}
