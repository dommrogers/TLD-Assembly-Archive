using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace AmazingAssets.TerrainToMesh.Example;

public class ExportDetailMesh : MonoBehaviour
{
	public TerrainData terrainData;

	public int vertexCountHorizontal;

	public int vertexCountVertical;

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(TerrainToMeshDataExtractor), Member = "\u200d\u206e\u202c\u200e\u202d\u200d\u206b\u200b\u206e\u206f\u202d\u200c\u202b\u206d\u202a\u200c\u206a\u206d\u202a\u200f\u202e\u200d\u200c\u206c\u206c\u206c\u206f\u206b\u206a\u200c\u202a\u206c\u206c\u202c\u206f\u206f\u202a\u206a\u206a\u202b\u202e")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Extensions), Member = "TerrainToMesh")]
	[Calls(Type = typeof(Extensions), Member = "TerrainToMesh")]
	[Calls(Type = typeof(Utilities), Member = "GetUnityDefaultShader")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(TerrainToMeshDataExtractor), Member = "ExportMesh")]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ExportDetailMesh()
	{
	}
}
