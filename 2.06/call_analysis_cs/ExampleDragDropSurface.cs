using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ExampleDragDropSurface : MonoBehaviour
{
	public bool rotatePlacedObject;

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public ExampleDragDropSurface()
	{
	}
}
