using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace AmazingAssets.TerrainToMesh.Example;

public class ExportMeshAndBasemapByPositionIndex : MonoBehaviour
{
	public TerrainData terrainData;

	public int vertexCountHorizontal;

	public int vertexCountVertical;

	public int mapsResolution;

	public bool exportHoles;

	private int chunkCountHorizontal;

	private int chunkCountVertical;

	public int positionX;

	public int positionY;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Extensions), Member = "TerrainToMesh")]
	[Calls(Type = typeof(TerrainToMeshDataExtractor), Member = "ExportMesh")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(TerrainToMeshDataExtractor), Member = "ExportBasemapDiffuseTexture")]
	[Calls(TypeFullName = "\u200f\u206f\u206a\u206a\u202a\u200f\u200d\u200e\u202e\u200e\u200e\u206b\u206a\u202b\u206d\u206a\u200e\u202a\u200b\u206f\u200e\u206a\u200c\u202c\u206a\u206b\u206c\u200f\u202c\u206b\u200f\u206a\u206e\u202d\u200c\u202e\u206b\u200d\u206b\u202d\u202e", Member = "\u206f\u206f\u206f\u202e\u202b\u200f\u206b\u200d\u202b\u206e\u202b\u200f\u206a\u206e\u202a\u202e\u206f\u206d\u206c\u202d\u206d\u206e\u202e\u202a\u206e\u200c\u202d\u200f\u200f\u200e\u200e\u206a\u200b\u200c\u206d\u202a\u206d\u200c\u206f\u206c\u202e")]
	[Calls(TypeFullName = "\u200f\u206e\u200f\u202d\u200d\u206a\u206c\u200d\u202d\u200f\u206f\u202c\u202c\u202c\u206b\u206c\u206e\u202c\u206b\u200d\u202b\u200c\u200e\u202a\u206a\u202d\u206e\u206b\u202c\u206f\u206d\u202b\u206d\u206e\u206c\u200f\u200d\u206e\u206e\u200e\u202e.\u206d\u206e\u206e\u200d\u202d\u202b\u202a\u206e\u206c\u206b\u206b\u206c\u200e\u200b\u206d\u202c\u202d\u200b\u200d\u206e\u202e\u202e\u200b\u200c\u206e\u202a\u200c\u206e\u202a\u202d\u202d\u200e\u202b\u202b\u202d\u200c\u206f\u206f\u200e\u202a\u202e", Member = "\u200d\u206b\u202e\u206a\u200e\u202c\u202a\u206f\u202b\u200e\u202c\u206a\u200f\u200f\u206b\u206a\u202b\u202c\u206c\u202e\u200e\u202a\u206c\u200d\u202c\u206a\u202e\u202b\u206d\u200e\u200b\u200b\u202a\u206b\u200f\u200d\u206a\u206d\u202b\u200f\u202e")]
	[Calls(Type = typeof(Utilities), Member = "GetCurrentRenderPipeline")]
	[Calls(Type = typeof(Utilities), Member = "GetUnityDefaultShader")]
	[Calls(Type = typeof(Utilities), Member = "GetMaterailPropMainTex")]
	[Calls(Type = typeof(Utilities), Member = "GetMaterailPropBumpMap")]
	[Calls(Type = typeof(Utilities), Member = "GetMaterailPropMetallicSmoothnessMap")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(ExportMeshAndBasemapByPositionIndex), Member = "InitializeMaterial")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Material), Member = "EnableKeyword")]
	[Calls(Type = typeof(ExportMeshAndBasemapByPositionIndex), Member = "SetupAlphaTest")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(ExportMeshAndBasemapByPositionIndex), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utilities), Member = "GetCurrentRenderPipeline")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void InitializeMaterial(Material material)
	{
	}

	[CalledBy(Type = typeof(ExportMeshAndBasemapByPositionIndex), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utilities), Member = "GetCurrentRenderPipeline")]
	[Calls(Type = typeof(Material), Member = "IsKeywordEnabled")]
	[Calls(Type = typeof(Material), Member = "EnableKeyword")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SetupAlphaTest(Material material)
	{
	}

	[CallerCount(Count = 0)]
	public ExportMeshAndBasemapByPositionIndex()
	{
	}
}
