using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LitItemExtinguisher : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	[CallsUnknownMethods(Count = 2)]
	private void OnTriggerEnter(Collider collisionInfo)
	{
	}

	[Calls(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void OnCollisionStay(Collision collisionInfo)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public LitItemExtinguisher()
	{
	}
}
