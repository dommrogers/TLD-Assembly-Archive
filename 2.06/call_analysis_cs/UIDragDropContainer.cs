using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIDragDropContainer : MonoBehaviour
{
	public Transform reparentTarget;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public UIDragDropContainer()
	{
	}
}
