using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

internal static class MeshUtilities
{
	private static Dictionary<PrimitiveType, Mesh> s_Primitives;

	private static Dictionary<Type, PrimitiveType> s_ColliderPrimitives;

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	static MeshUtilities()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	internal static Mesh GetColliderMesh(Collider collider)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallsUnknownMethods(Count = 3)]
	internal static Mesh GetPrimitive(PrimitiveType primitiveType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallsUnknownMethods(Count = 3)]
	private static Mesh GetBuiltinMesh(PrimitiveType primitiveType)
	{
		return null;
	}
}
