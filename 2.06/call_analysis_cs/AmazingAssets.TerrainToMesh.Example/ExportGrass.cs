using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace AmazingAssets.TerrainToMesh.Example;

public class ExportGrass : MonoBehaviour
{
	public TerrainData terrainData;

	public int vertexCountHorizontal;

	public int vertexCountVertical;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Extensions), Member = "TerrainToMesh")]
	[Calls(Type = typeof(TerrainToMeshDataExtractor), Member = "ExportMesh")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Utilities), Member = "GetUnityDefaultShader")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(TerrainToMeshDataExtractor), Member = "\u200d\u206e\u202c\u200e\u202d\u200d\u206b\u200b\u206e\u206f\u202d\u200c\u202b\u206d\u202a\u200c\u206a\u206d\u202a\u200f\u202e\u200d\u200c\u206c\u206c\u206c\u206f\u206b\u206a\u200c\u202a\u206c\u206c\u202c\u206f\u206f\u202a\u206a\u206a\u202b\u202e")]
	[Calls(Type = typeof(Utilities), Member = "CreateGrassMesh")]
	[Calls(Type = typeof(Utilities), Member = "GetMaterailPropMainTex")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Utilities), Member = "CombineGameObjects")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(ExportGrass), Member = "BakeHealthyAndDryColorsInsideVertexColor")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 68)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(ExportGrass), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mesh), Member = "DefaultDimensionForChannel")]
	[Calls(Type = typeof(Mesh), Member = "set_colors")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void BakeHealthyAndDryColorsInsideVertexColor(Mesh mesh, DetailPrototype detailPrototype)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ExportGrass()
	{
	}
}
