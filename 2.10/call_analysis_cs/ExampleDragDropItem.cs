using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ExampleDragDropItem : UIDragDropItem
{
	public GameObject prefab;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(NGUITools), Member = "Destroy")]
	[Calls(Type = typeof(UIDragDropItem), Member = "OnDragDropRelease")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 10)]
	protected override void OnDragDropRelease(GameObject surface)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ExampleDragDropItem()
	{
	}
}
