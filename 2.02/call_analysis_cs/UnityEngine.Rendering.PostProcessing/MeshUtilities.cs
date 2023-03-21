using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

internal static class MeshUtilities
{
	private static Dictionary<PrimitiveType, Mesh> s_Primitives;

	private static Dictionary<Type, PrimitiveType> s_ColliderPrimitives;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 16)]
	static MeshUtilities()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(MeshUtilities), Member = "GetPrimitive")]
	[CallsUnknownMethods(Count = 5)]
	internal static Mesh GetColliderMesh(Collider collider)
	{
		return null;
	}

	[CalledBy(Type = typeof(MeshUtilities), Member = "GetColliderMesh")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	internal static Mesh GetPrimitive(PrimitiveType primitiveType)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallerCount(Count = 0)]
	private static Mesh GetBuiltinMesh(PrimitiveType primitiveType)
	{
		return null;
	}
}
