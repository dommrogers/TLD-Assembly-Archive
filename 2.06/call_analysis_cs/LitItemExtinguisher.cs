using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LitItemExtinguisher : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnTriggerEnter(Collider collisionInfo)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnCollisionStay(Collision collisionInfo)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public LitItemExtinguisher()
	{
	}
}
