using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MB_ExampleMover : MonoBehaviour
{
	public int axis;

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Vector3), Member = "set_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
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
