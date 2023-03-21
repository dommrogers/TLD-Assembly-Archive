using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RenderObjectInstanceSceneData : MonoBehaviour
{
	public RenderObjectInstance.Category m_Category;

	public bool m_IgnoreDisabledObjects;

	public List<GameObject> m_ObjectParents;

	public List<string> m_InstancedMeshNames;

	public List<int> m_InstancedMeshCounts;

	public Bounds m_Bounds;

	public int m_NumInstances;

	public static bool s_EnableWarningLogs;

	public List<Mesh> m_UniqueMeshes;

	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "MaybeGetMeshForInstancedRendering")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "GetLodsAndRenderers")]
	public void RegenerateInstanceLists()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "CreateBatchList")]
	[CallsUnknownMethods(Count = 4)]
	public int GetRenderBatchCount()
	{
		return default(int);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 18)]
	[CallerCount(Count = 0)]
	public RenderObjectInstanceSceneData()
	{
	}
}
