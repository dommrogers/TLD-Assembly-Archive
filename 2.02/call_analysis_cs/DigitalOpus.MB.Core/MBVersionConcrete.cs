using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public class MBVersionConcrete : MBVersionInterface
{
	private Vector2 _HALF_UV;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string version()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "ParseInt32")]
	[CalledBy(Type = typeof(MB3_TextureBaker._003CCreateAtlasesCoroutine_003Ed__94), Member = "MoveNext")]
	[CalledBy(Type = typeof(MB3_TextureBaker._003CCreateAtlasesCoroutine_003Ed__94), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 8)]
	public int GetMajorVersion()
	{
		return default(int);
	}

	[Calls(Type = typeof(System.Number), Member = "ParseInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	public int GetMinorVersion()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool GetActive(GameObject go)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void SetActive(GameObject go, bool isActive)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetActiveRecursively(GameObject go, bool isActive)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public UnityEngine.Object[] FindSceneObjectsOfType(Type t)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void OptimizeMesh(Mesh m)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public bool IsRunningAndMeshNotReadWriteable(Mesh m)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[Calls(Type = typeof(Mesh), Member = "get_uv")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 6)]
	public Vector2[] GetMeshUV1s(Mesh m, MB2_LogLevel LOG_LEVEL)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[Calls(Type = typeof(Mesh), Member = "get_uv3")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "get_uv4")]
	public Vector2[] GetMeshUV3orUV4(Mesh m, bool get3, MB2_LogLevel LOG_LEVEL)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void MeshClear(Mesh m, bool t)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void MeshAssignUV3(Mesh m, Vector2[] uv3s)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "set_uv4")]
	[CallsUnknownMethods(Count = 1)]
	public void MeshAssignUV4(Mesh m, Vector2[] uv4s)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Vector4 GetLightmapTilingOffset(Renderer r)
	{
		return default(Vector4);
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public Transform[] GetBones(Renderer r)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public int GetBlendShapeFrameCount(Mesh m, int shapeIndex)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetBlendShapeFrameWeight(Mesh m, int shapeIndex, int frameIndex)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void GetBlendShapeFrameVertices(Mesh m, int shapeIndex, int frameIndex, Vector3[] vs, Vector3[] ns, Vector3[] ts)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void ClearBlendShapes(Mesh m)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void AddBlendShapeFrame(Mesh m, string nm, float wt, Vector3[] vs, Vector3[] ns, Vector3[] ts)
	{
	}

	[CallerCount(Count = 0)]
	public int MaxMeshVertexCount()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MBVersion), Member = "MeshClear")]
	[Calls(Type = typeof(Mesh), Member = "set_indexFormat")]
	[Calls(Type = typeof(MBVersion), Member = "MeshClear")]
	[Calls(Type = typeof(Mesh), Member = "set_indexFormat")]
	[Calls(Type = typeof(MBVersion), Member = "MeshClear")]
	[Calls(Type = typeof(MBVersion), Member = "MeshClear")]
	[CallsUnknownMethods(Count = 3)]
	public void SetMeshIndexFormatAndClearMesh(Mesh m, int numVerts, bool vertices, bool justClearTriangles)
	{
	}

	[CallerCount(Count = 0)]
	public MBVersionConcrete()
	{
	}
}
