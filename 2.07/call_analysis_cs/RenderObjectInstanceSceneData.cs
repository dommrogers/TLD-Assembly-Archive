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

	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "MaybeGetMeshForInstancedRendering")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "GetLodsAndRenderers")]
	public void RegenerateInstanceLists()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "CreateBatchList")]
	[CallsUnknownMethods(Count = 5)]
	public int GetRenderBatchCount()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public RenderObjectInstanceSceneData()
	{
	}
}
