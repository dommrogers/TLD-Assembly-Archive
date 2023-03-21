using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public interface MBVersionInterface
{
	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	string version();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	int GetMajorVersion();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	int GetMinorVersion();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	bool GetActive(GameObject go);

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	void SetActive(GameObject go, bool isActive);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void SetActiveRecursively(GameObject go, bool isActive);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	UnityEngine.Object[] FindSceneObjectsOfType(Type t);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	bool IsRunningAndMeshNotReadWriteable(Mesh m);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	Vector2[] GetMeshUV3orUV4(Mesh m, bool get3, MB2_LogLevel LOG_LEVEL);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void MeshClear(Mesh m, bool t);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void MeshAssignUV3(Mesh m, Vector2[] uv3s);

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	void MeshAssignUV4(Mesh m, Vector2[] uv4s);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	Vector4 GetLightmapTilingOffset(Renderer r);

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	Transform[] GetBones(Renderer r);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void OptimizeMesh(Mesh m);

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	int GetBlendShapeFrameCount(Mesh m, int shapeIndex);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	float GetBlendShapeFrameWeight(Mesh m, int shapeIndex, int frameIndex);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void GetBlendShapeFrameVertices(Mesh m, int shapeIndex, int frameIndex, Vector3[] vs, Vector3[] ns, Vector3[] ts);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void ClearBlendShapes(Mesh m);

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	void AddBlendShapeFrame(Mesh m, string nm, float wt, Vector3[] vs, Vector3[] ns, Vector3[] ts);

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	int MaxMeshVertexCount();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void SetMeshIndexFormatAndClearMesh(Mesh m, int numVerts, bool vertices, bool justClearTriangles);
}
