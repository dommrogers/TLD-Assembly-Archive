using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIDragDropContainer : MonoBehaviour
{
	public Transform reparentTarget;

	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public UIDragDropContainer()
	{
	}
}
