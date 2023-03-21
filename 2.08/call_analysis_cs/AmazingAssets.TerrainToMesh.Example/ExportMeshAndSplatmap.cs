using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace AmazingAssets.TerrainToMesh.Example;

public class ExportMeshAndSplatmap : MonoBehaviour
{
	public TerrainData terrainData;

	public int vertexCountHorizontal;

	public int vertexCountVertical;

	public bool terrainHasHoles;

	public bool createFallbackTextures;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Utilities), Member = "GetMaterailPropBumpMap")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Utilities), Member = "GetMaterailPropMainTex")]
	[Calls(Type = typeof(_200F_206E_200F_202D_200D_206A_206C_200D_202D_200F_206F_202C_202C_202C_206B_206C_206E_202C_206B_200D_202B_200C_200E_202A_206A_202D_206E_206B_202C_206F_206D_202B_206D_206E_206C_200F_200D_206E_206E_200E_202E._206D_206E_206E_200D_202D_202B_202A_206E_206C_206B_206B_206C_200E_200B_206D_202C_202D_200B_200D_206E_202E_202E_200B_200C_206E_202A_200C_206E_202A_202D_202D_200E_202B_202B_202D_200C_206F_206F_200E_202A_202E), Member = "\u202b\u206e\u206c\u200c\u202c\u206d\u200e\u206e\u206f\u200b\u206b\u202b\u200d\u206d\u200b\u206d\u200b\u202c\u206d\u202b\u206c\u202e\u200f\u200b\u202c\u200b\u202d\u202b\u206c\u206d\u200b\u202a\u200c\u202a\u206b\u206c\u206f\u200f\u206c\u202c\u202e")]
	[Calls(Type = typeof(_200F_206E_200F_202D_200D_206A_206C_200D_202D_200F_206F_202C_202C_202C_206B_206C_206E_202C_206B_200D_202B_200C_200E_202A_206A_202D_206E_206B_202C_206F_206D_202B_206D_206E_206C_200F_200D_206E_206E_200E_202E._206D_206E_206E_200D_202D_202B_202A_206E_206C_206B_206B_206C_200E_200B_206D_202C_202D_200B_200D_206E_202E_202E_200B_200C_206E_202A_200C_206E_202A_202D_202D_200E_202B_202B_202D_200C_206F_206F_200E_202A_202E), Member = "\u202c\u206e\u206b\u200f\u200b\u202b\u206f\u202a\u200b\u200e\u200d\u206c\u202a\u206a\u200f\u202e\u206e\u202d\u200e\u200d\u202c\u200f\u206b\u206e\u206f\u202d\u200e\u202e\u200f\u200d\u200d\u206d\u206c\u200b\u206d\u206c\u202c\u202a\u200f\u200e\u202e")]
	[Calls(Type = typeof(_200F_206F_206A_206A_202A_200F_200D_200E_202E_200E_200E_206B_206A_202B_206D_206A_200E_202A_200B_206F_200E_206A_200C_202C_206A_206B_206C_200F_202C_206B_200F_206A_206E_202D_200C_202E_206B_200D_206B_202D_202E), Member = "\u206f\u206f\u206f\u202e\u202b\u200f\u206b\u200d\u202b\u206e\u202b\u200f\u206a\u206e\u202a\u202e\u206f\u206d\u206c\u202d\u206d\u206e\u202e\u202a\u206e\u200c\u202d\u200f\u200f\u200e\u200e\u206a\u200b\u200c\u206d\u202a\u206d\u200c\u206f\u206c\u202e")]
	[Calls(Type = typeof(TerrainToMeshDataExtractor), Member = "ExportBasemapDiffuseTexture")]
	[Calls(Type = typeof(Extensions), Member = "TerrainToMesh")]
	[Calls(Type = typeof(TerrainToMeshDataExtractor), Member = "ExportSplatmapMaterial")]
	[Calls(Type = typeof(Extensions), Member = "TerrainToMesh")]
	[Calls(Type = typeof(TerrainToMeshDataExtractor), Member = "ExportMesh")]
	[Calls(Type = typeof(Extensions), Member = "TerrainToMesh")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Extensions), Member = "TerrainToMesh")]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ExportMeshAndSplatmap()
	{
	}
}
