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

	[Calls(Type = typeof(Utilities), Member = "GetMaterailPropBumpMap")]
	[Calls(Type = typeof(Utilities), Member = "GetMaterailPropMetallicSmoothnessMap")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(ExportMeshAndBasemapByPositionIndex), Member = "InitializeMaterial")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Material), Member = "EnableKeyword")]
	[Calls(Type = typeof(Material), Member = "EnableKeyword")]
	[Calls(Type = typeof(ExportMeshAndBasemapByPositionIndex), Member = "SetupAlphaTest")]
	[Calls(Type = typeof(Utilities), Member = "GetMaterailPropMainTex")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Utilities), Member = "GetUnityDefaultShader")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(_200F_206F_206A_206A_202A_200F_200D_200E_202E_200E_200E_206B_206A_202B_206D_206A_200E_202A_200B_206F_200E_206A_200C_202C_206A_206B_206C_200F_202C_206B_200F_206A_206E_202D_200C_202E_206B_200D_206B_202D_202E), Member = "\u206f\u206f\u206f\u202e\u202b\u200f\u206b\u200d\u202b\u206e\u202b\u200f\u206a\u206e\u202a\u202e\u206f\u206d\u206c\u202d\u206d\u206e\u202e\u202a\u206e\u200c\u202d\u200f\u200f\u200e\u200e\u206a\u200b\u200c\u206d\u202a\u206d\u200c\u206f\u206c\u202e")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Extensions), Member = "TerrainToMesh")]
	[Calls(Type = typeof(TerrainToMeshDataExtractor), Member = "ExportMesh")]
	[Calls(Type = typeof(Extensions), Member = "TerrainToMesh")]
	[Calls(Type = typeof(_200F_206E_200F_202D_200D_206A_206C_200D_202D_200F_206F_202C_202C_202C_206B_206C_206E_202C_206B_200D_202B_200C_200E_202A_206A_202D_206E_206B_202C_206F_206D_202B_206D_206E_206C_200F_200D_206E_206E_200E_202E._206D_206E_206E_200D_202D_202B_202A_206E_206C_206B_206B_206C_200E_200B_206D_202C_202D_200B_200D_206E_202E_202E_200B_200C_206E_202A_200C_206E_202A_202D_202D_200E_202B_202B_202D_200C_206F_206F_200E_202A_202E), Member = "\u200d\u206b\u202e\u206a\u200e\u202c\u202a\u206f\u202b\u200e\u202c\u206a\u200f\u200f\u206b\u206a\u202b\u202c\u206c\u202e\u200e\u202a\u206c\u200d\u202c\u206a\u202e\u202b\u206d\u200e\u200b\u200b\u202a\u206b\u200f\u200d\u206a\u206d\u202b\u200f\u202e")]
	[Calls(Type = typeof(Extensions), Member = "TerrainToMesh")]
	[Calls(Type = typeof(Extensions), Member = "TerrainToMesh")]
	[Calls(Type = typeof(Utilities), Member = "GetCurrentRenderPipeline")]
	[Calls(Type = typeof(TerrainToMeshDataExtractor), Member = "ExportBasemapDiffuseTexture")]
	[Calls(Type = typeof(_200F_206F_206A_206A_202A_200F_200D_200E_202E_200E_200E_206B_206A_202B_206D_206A_200E_202A_200B_206F_200E_206A_200C_202C_206A_206B_206C_200F_202C_206B_200F_206A_206E_202D_200C_202E_206B_200D_206B_202D_202E), Member = "\u206f\u206f\u206f\u202e\u202b\u200f\u206b\u200d\u202b\u206e\u202b\u200f\u206a\u206e\u202a\u202e\u206f\u206d\u206c\u202d\u206d\u206e\u202e\u202a\u206e\u200c\u202d\u200f\u200f\u200e\u200e\u206a\u200b\u200c\u206d\u202a\u206d\u200c\u206f\u206c\u202e")]
	[Calls(Type = typeof(_200F_206E_200F_202D_200D_206A_206C_200D_202D_200F_206F_202C_202C_202C_206B_206C_206E_202C_206B_200D_202B_200C_200E_202A_206A_202D_206E_206B_202C_206F_206D_202B_206D_206E_206C_200F_200D_206E_206E_200E_202E._206D_206E_206E_200D_202D_202B_202A_206E_206C_206B_206B_206C_200E_200B_206D_202C_202D_200B_200D_206E_202E_202E_200B_200C_206E_202A_200C_206E_202A_202D_202D_200E_202B_202B_202D_200C_206F_206F_200E_202A_202E), Member = "\u200d\u206b\u202e\u206a\u200e\u202c\u202a\u206f\u202b\u200e\u202c\u206a\u200f\u200f\u206b\u206a\u202b\u202c\u206c\u202e\u200e\u202a\u206c\u200d\u202c\u206a\u202e\u202b\u206d\u200e\u200b\u200b\u202a\u206b\u200f\u200d\u206a\u206d\u202b\u200f\u202e")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ExportMeshAndBasemapByPositionIndex), Member = "Start")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Utilities), Member = "GetCurrentRenderPipeline")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	private void InitializeMaterial(Material material)
	{
	}

	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ExportMeshAndBasemapByPositionIndex), Member = "Start")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "HasProperty")]
	[Calls(Type = typeof(Material), Member = "EnableKeyword")]
	[Calls(Type = typeof(Material), Member = "IsKeywordEnabled")]
	[Calls(Type = typeof(Utilities), Member = "GetCurrentRenderPipeline")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	private void SetupAlphaTest(Material material)
	{
	}

	[CallerCount(Count = 0)]
	public ExportMeshAndBasemapByPositionIndex()
	{
	}
}
