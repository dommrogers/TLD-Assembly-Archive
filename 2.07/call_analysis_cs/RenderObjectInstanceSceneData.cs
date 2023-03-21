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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "GetLodsAndRenderers")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "MaybeGetMeshForInstancedRendering")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 20)]
	public void RegenerateInstanceLists()
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "CreateBatchList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public int GetRenderBatchCount()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public RenderObjectInstanceSceneData()
	{
	}
}
