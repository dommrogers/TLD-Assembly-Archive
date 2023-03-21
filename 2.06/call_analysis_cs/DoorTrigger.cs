using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public DoorTrigger()
	{
	}
}
