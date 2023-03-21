using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MB_ExampleMover : MonoBehaviour
{
	public int axis;

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Vector3), Member = "set_Item")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MB_ExampleMover()
	{
	}
}
