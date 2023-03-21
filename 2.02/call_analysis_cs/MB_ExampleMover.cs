using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MB_ExampleMover : MonoBehaviour
{
	public int axis;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "set_Item")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MB_ExampleMover()
	{
	}
}
