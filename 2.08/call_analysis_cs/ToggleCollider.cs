using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ToggleCollider : MonoBehaviour
{
	public bool enableCollider;

	public List<Collider> allColliders;

	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
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
