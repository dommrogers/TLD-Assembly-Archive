using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HeldItemRestrictionTrigger : MonoBehaviour
{
	public HeldItemRestriction m_Restriction;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "RestrictHeldItems")]
	[CallsUnknownMethods(Count = 4)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void OnTriggerExit(Collider c)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public HeldItemRestrictionTrigger()
	{
	}
}
