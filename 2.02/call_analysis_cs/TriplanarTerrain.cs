using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TriplanarTerrain : MonoBehaviour
{
	public Shader m_Shader;

	public float m_BlendExponent;

	private Material m_Material;

	private Terrain m_Terrain;

	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(TriplanarTerrain), Member = "SetTerrainDimensions")]
	[Calls(Type = typeof(TriplanarTerrain), Member = "SetTerrainTextures")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(TriplanarTerrain), Member = "Start")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	private static void SetTerrainDimensions(Terrain t, Material m)
	{
	}

	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileOffset")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileSize")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileOffset")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileSize")]
	[CallsUnknownMethods(Count = 50)]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileOffset")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileOffset")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[CalledBy(Type = typeof(TriplanarTerrain), Member = "Start")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileSize")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileSize")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileOffset")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileOffset")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileOffset")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileSize")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileSize")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileOffset")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileSize")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileSize")]
	[Calls(Type = typeof(Shader), Member = "SetGlobalVector")]
	[Calls(Type = typeof(Shader), Member = "SetGlobalTexture")]
	[Calls(Type = typeof(TerrainData), Member = "get_alphamapTextures")]
	[CallsDeduplicatedMethods(Count = 25)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	private static void SetTerrainTextures(Terrain t, Material m)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public TriplanarTerrain()
	{
	}
}
