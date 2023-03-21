using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LitItemExtinguisher : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "ExtinguishLitItem")]
	[CallsUnknownMethods(Count = 3)]
	private void OnTriggerEnter(Collider collisionInfo)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Collision), Member = "get_contacts")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "ExtinguishLitItem")]
	[CallsUnknownMethods(Count = 8)]
	public void OnCollisionStay(Collision collisionInfo)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LitItemExtinguisher()
	{
	}
}
