using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ExampleDragDropItem : UIDragDropItem
{
	public GameObject prefab;

	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIDragDropItem), Member = "OnDragDropRelease")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(NGUITools), Member = "Destroy")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	protected override void OnDragDropRelease(GameObject surface)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ExampleDragDropItem()
	{
	}
}
