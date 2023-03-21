using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

[Serializable]
public class MB3_MeshBakerGrouperPie : MB3_MeshBakerGrouperCore
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101)]
	public MB3_MeshBakerGrouperPie(GrouperData data)
	{
	}

	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public override Dictionary<string, List<Renderer>> FilterIntoGroups(List<GameObject> selection)
	{
		return null;
	}

	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(MB3_MeshBakerGrouperPie), Member = "DrawCircle")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public override void DrawGizmos(Bounds sourceObjectBounds)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CalledBy(Type = typeof(MB3_MeshBakerGrouperPie), Member = "DrawGizmos")]
	[CallsUnknownMethods(Count = 1)]
	public static void DrawCircle(Vector3 axis, Vector3 center, float radius, int subdiv)
	{
	}
}
