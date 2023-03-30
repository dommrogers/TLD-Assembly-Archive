using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ToggleCollider : MonoBehaviour
{
	public bool enableCollider;

	public List<Collider> allColliders;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(TypeFullName = "System.Linq.Error", Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 14)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.Linq.Error", Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private List<Collider> RemoveDuplicates(List<Collider> oldList)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ToggleCollider()
	{
	}
}
