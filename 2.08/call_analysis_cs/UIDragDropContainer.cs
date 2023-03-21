using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIDragDropContainer : MonoBehaviour
{
	public Transform reparentTarget;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void Start()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public UIDragDropContainer()
	{
	}
}
