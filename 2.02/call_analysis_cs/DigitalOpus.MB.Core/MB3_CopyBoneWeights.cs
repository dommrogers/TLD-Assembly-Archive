using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public class MB3_CopyBoneWeights
{
	[Calls(Type = typeof(Mesh), Member = "get_tangents")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Mesh), Member = "set_vertices")]
	[Calls(Type = typeof(Mesh), Member = "set_normals")]
	[CallsUnknownMethods(Count = 73)]
	[Calls(Type = typeof(Mesh), Member = "set_tangents")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Mesh), Member = "get_normals")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Mesh), Member = "get_vertices")]
	[Calls(Type = typeof(Mesh), Member = "get_vertices")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Mesh), Member = "get_vertices")]
	[Calls(Type = typeof(Mesh), Member = "get_normals")]
	[Calls(Type = typeof(Mesh), Member = "get_tangents")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Mesh), Member = "get_uv")]
	public static void CopyBoneWeightsFromSeamMeshToOtherMeshes(float radius, Mesh seamMesh, Mesh[] targetMeshes)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public MB3_CopyBoneWeights()
	{
	}
}
