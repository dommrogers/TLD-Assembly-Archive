using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ToggleCollider : MonoBehaviour
{
	public bool enableCollider;

	public List<Collider> allColliders;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "ToList")]
	[Calls(Type = typeof(ToggleCollider), Member = "RemoveDuplicates")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(ToggleCollider), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "ToList")]
	[Calls(TypeFullName = "System.Linq.Error", Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private List<Collider> RemoveDuplicates(List<Collider> oldList)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public ToggleCollider()
	{
	}
}
