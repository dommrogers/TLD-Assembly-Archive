using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	[CallsUnknownMethods(Count = 9)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LookAtPlayer()
	{
	}
}
