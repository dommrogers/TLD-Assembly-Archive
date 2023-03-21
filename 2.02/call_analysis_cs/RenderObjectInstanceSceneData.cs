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

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(RenderObjectInstanceSceneData), Member = "CountInstancedMeshesInChildren")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	public void RegenerateInstanceLists()
	{
	}

	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[CalledBy(Type = typeof(RenderObjectInstanceSceneData), Member = "CountInstancedMeshesInChildren")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "MaybeGetMeshForInstancedRendering")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	private void CountInstancedMeshesInLODGroup(LODGroup group)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(RenderObjectInstanceSceneData), Member = "CountInstancedMeshesInChildren")]
	[CalledBy(Type = typeof(RenderObjectInstanceSceneData), Member = "RegenerateInstanceLists")]
	[Calls(Type = typeof(RenderObjectInstanceSceneData), Member = "CountInstancedMeshesInLODGroup")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderObjectInstanceSceneData), Member = "CountInstancedMeshesInChildren")]
	private void CountInstancedMeshesInChildren(Transform parent)
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public RenderObjectInstanceSceneData()
	{
	}
}
