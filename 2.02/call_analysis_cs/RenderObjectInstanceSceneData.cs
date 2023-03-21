using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RenderObjectInstanceSceneData : MonoBehaviour
{
	public RenderObjectInstance.Category m_Category;

	public List<GameObject> m_ObjectParents;

	public List<string> m_InstancedMeshNames;

	public List<int> m_InstancedMeshCounts;

	public Bounds m_Bounds;

	public int m_NumInstances;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(RenderObjectInstanceSceneData), Member = "CountInstancedMeshesInChildren")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void RegenerateInstanceLists()
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstanceSceneData), Member = "CountInstancedMeshesInChildren")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "MaybeGetMeshForInstancedRendering")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 22)]
	private void CountInstancedMeshesInLODGroup(LODGroup group)
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstanceSceneData), Member = "RegenerateInstanceLists")]
	[CalledBy(Type = typeof(RenderObjectInstanceSceneData), Member = "CountInstancedMeshesInChildren")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderObjectInstanceSceneData), Member = "CountInstancedMeshesInLODGroup")]
	[Calls(Type = typeof(RenderObjectInstanceSceneData), Member = "CountInstancedMeshesInChildren")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	private void CountInstancedMeshesInChildren(Transform parent)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	public RenderObjectInstanceSceneData()
	{
	}
}
