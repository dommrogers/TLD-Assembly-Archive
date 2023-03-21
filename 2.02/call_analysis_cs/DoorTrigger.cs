using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private void Update()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public DoorTrigger()
	{
	}
}
