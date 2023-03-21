using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LitItemExtinguisher : MonoBehaviour
{
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	[CallsUnknownMethods(Count = 2)]
	private void OnTriggerEnter(Collider collisionInfo)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	[CallsUnknownMethods(Count = 4)]
	private void OnCollisionStay(Collision collisionInfo)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LitItemExtinguisher()
	{
	}
}
