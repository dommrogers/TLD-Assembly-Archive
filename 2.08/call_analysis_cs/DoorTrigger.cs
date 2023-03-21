using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public DoorTrigger()
	{
	}
}
