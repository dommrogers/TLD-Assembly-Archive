using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

[Serializable]
public class MB3_MeshBakerGrouperGrid : MB3_MeshBakerGrouperCore
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101)]
	public MB3_MeshBakerGrouperGrid(GrouperData d)
	{
	}

	[Calls(Type = typeof(Vector3), Member = "ToString")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public override Dictionary<string, List<Renderer>> FilterIntoGroups(List<GameObject> selection)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	public override void DrawGizmos(Bounds sourceObjectBounds)
	{
	}
}
