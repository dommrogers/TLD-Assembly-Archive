using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ExampleDragDropSurface : MonoBehaviour
{
	public bool rotatePlacedObject;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ExampleDragDropSurface()
	{
	}
}
