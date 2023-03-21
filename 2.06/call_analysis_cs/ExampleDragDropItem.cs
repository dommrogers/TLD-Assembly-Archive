using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ExampleDragDropItem : UIDragDropItem
{
	public GameObject prefab;

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UIDragDropItem), Member = "OnDragDropRelease")]
	[Calls(Type = typeof(NGUITools), Member = "Destroy")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	protected override void OnDragDropRelease(GameObject surface)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ExampleDragDropItem()
	{
	}
}
