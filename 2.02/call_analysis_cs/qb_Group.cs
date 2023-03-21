using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class qb_Group : MonoBehaviour
{
	public string groupName;

	private bool visible;

	private bool frozen;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void AddObject(GameObject newObject)
	{
	}

	[CallerCount(Count = 0)]
	public void Hide()
	{
	}

	[CallerCount(Count = 0)]
	public void Show()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Freeze()
	{
	}

	[CallerCount(Count = 0)]
	public void UnFreeze()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void CleanUp()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public qb_Group()
	{
	}
}
