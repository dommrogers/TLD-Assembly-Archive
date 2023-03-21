using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace AmazingAssets.TerrainToMesh.Example;

public class ExportTrees : MonoBehaviour
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
	[Calls(Type = typeof(TerrainToMeshDataExtractor), Member = "\u206a\u206a\u206f\u206a\u206a\u206a\u202e\u206b\u206b\u206e\u202e\u206e\u206c\u202e\u200c\u206b\u206b\u206f\u202c\u202e\u202a\u206e\u206c\u202c\u206c\u206f\u206e\u206c\u206b\u202e\u206f\u206a\u206e\u200e\u202a\u206c\u202d\u200d\u200f\u200f\u202e")]
	[Calls(Type = typeof(TerrainToMeshDataExtractor), Member = "\u200f\u202d\u206a\u206f\u202b\u202d\u206a\u206f\u202c\u200e\u200b\u206a\u202a\u200c\u200d\u206e\u200c\u202b\u206c\u202b\u206c\u202a\u206e\u202a\u206a\u206b\u206e\u206b\u206f\u206e\u206a\u206d\u206a\u202c\u200e\u206d\u206a\u202e\u206a\u206f\u202e")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ExportTrees()
	{
	}
}
