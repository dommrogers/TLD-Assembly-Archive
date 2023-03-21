using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIDragDropContainer : MonoBehaviour
{
	public Transform reparentTarget;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UIDragDropContainer()
	{
	}
}
