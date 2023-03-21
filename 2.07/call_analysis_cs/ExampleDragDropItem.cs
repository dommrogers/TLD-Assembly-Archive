using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ExampleDragDropItem : UIDragDropItem
{
	public GameObject prefab;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(NGUITools), Member = "Destroy")]
	[Calls(Type = typeof(UIDragDropItem), Member = "OnDragDropRelease")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	protected override void OnDragDropRelease(GameObject surface)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ExampleDragDropItem()
	{
	}
}
