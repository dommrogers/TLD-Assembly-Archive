using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIDragDropContainer : MonoBehaviour
{
	public Transform reparentTarget;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected virtual void Start()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public UIDragDropContainer()
	{
	}
}
