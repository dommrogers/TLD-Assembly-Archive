using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public LookAtPlayer()
	{
	}
}
