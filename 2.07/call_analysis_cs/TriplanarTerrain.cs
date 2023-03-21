using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TriplanarTerrain : MonoBehaviour
{
	public Shader m_Shader;

	public float m_BlendExponent;

	private Material m_Material;

	private Terrain m_Terrain;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(TriplanarTerrain), Member = "SetTerrainDimensions")]
	[Calls(Type = typeof(TriplanarTerrain), Member = "SetTerrainTextures")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(TriplanarTerrain), Member = "Start")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	private static void SetTerrainDimensions(Terrain t, Material m)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileOffset")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileOffset")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileSize")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileSize")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileOffset")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileSize")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[CalledBy(Type = typeof(TriplanarTerrain), Member = "Start")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileOffset")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileSize")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileOffset")]
	[CallsDeduplicatedMethods(Count = 24)]
	[Calls(Type = typeof(TerrainData), Member = "get_alphamapTextures")]
	[Calls(Type = typeof(Shader), Member = "SetGlobalTexture")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileSize")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileSize")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileOffset")]
	[Calls(Type = typeof(Shader), Member = "SetGlobalVector")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileSize")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileSize")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileOffset")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileOffset")]
	private static void SetTerrainTextures(Terrain t, Material m)
	{
	}

	[CallerCount(Count = 0)]
	public TriplanarTerrain()
	{
	}
}
