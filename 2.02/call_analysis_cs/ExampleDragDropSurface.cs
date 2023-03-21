using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ExampleDragDropSurface : MonoBehaviour
{
	public bool rotatePlacedObject;

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ExampleDragDropSurface()
	{
	}
}
