using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ExampleDragDropSurface : MonoBehaviour
{
	public bool rotatePlacedObject;

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ExampleDragDropSurface()
	{
	}
}
