using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace AmazingAssets.TerrainToMesh.Example;

public class ExportMeshWithEdgeFall : MonoBehaviour
{
	public TerrainData terrainData;

	public int vertexCountHorizontal;

	public int vertexCountVertical;

	public EdgeFall edgeFall;

	public Texture2D edgeFallTexture;

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(Utilities), Member = "GetMaterailPropMainTex")]
	[Calls(Type = typeof(TerrainToMeshDataExtractor), Member = "ExportMesh")]
	[Calls(Type = typeof(Extensions), Member = "TerrainToMesh")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utilities), Member = "GetUnityDefaultShader")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public ExportMeshWithEdgeFall()
	{
	}
}
