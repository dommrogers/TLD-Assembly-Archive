using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SuppressWeaponAimTrigger : MonoBehaviour
{
	[CallerCount(Count = 0)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	private void OnTriggerExit(Collider c)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SuppressWeaponAimTrigger()
	{
	}
}
