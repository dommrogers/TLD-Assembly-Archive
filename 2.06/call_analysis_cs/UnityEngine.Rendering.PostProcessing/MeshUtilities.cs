using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

internal static class MeshUtilities
{
	private static Dictionary<PrimitiveType, Mesh> s_Primitives;

	private static Dictionary<Type, PrimitiveType> s_ColliderPrimitives;

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	static MeshUtilities()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	private static Mesh GetBuiltinMesh(PrimitiveType primitiveType)
	{
		return null;
	}
}
