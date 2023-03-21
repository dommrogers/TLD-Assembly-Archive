using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SuppressWeaponAimTrigger : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnTriggerExit(Collider c)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SuppressWeaponAimTrigger()
	{
	}
}
