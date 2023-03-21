using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ToggleCollider : MonoBehaviour
{
	public bool enableCollider;

	public List<Collider> allColliders;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(ToggleCollider), Member = "RemoveDuplicates")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[CallsUnknownMethods(Count = 13)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(ToggleCollider), Member = "Start")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	private List<Collider> RemoveDuplicates(List<Collider> oldList)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ToggleCollider()
	{
	}
}
