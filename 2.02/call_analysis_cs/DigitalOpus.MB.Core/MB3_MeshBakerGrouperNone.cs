using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

[Serializable]
public class MB3_MeshBakerGrouperNone : MB3_MeshBakerGrouperCore
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101)]
	public MB3_MeshBakerGrouperNone(GrouperData d)
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public override Dictionary<string, List<Renderer>> FilterIntoGroups(List<GameObject> selection)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public override void DrawGizmos(Bounds sourceObjectBounds)
	{
	}
}
