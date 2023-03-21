using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TriplanarTerrain : MonoBehaviour
{
	public Shader m_Shader;

	public float m_BlendExponent;

	private Material m_Material;

	private Terrain m_Terrain;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(TriplanarTerrain), Member = "SetTerrainDimensions")]
	[Calls(Type = typeof(TriplanarTerrain), Member = "SetTerrainTextures")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(TriplanarTerrain), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private static void SetTerrainDimensions(Terrain t, Material m)
	{
	}

	[CalledBy(Type = typeof(TriplanarTerrain), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TerrainData), Member = "get_alphamapTextures")]
	[Calls(Type = typeof(Shader), Member = "SetGlobalTexture")]
	[Calls(Type = typeof(Shader), Member = "SetGlobalVector")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileSize")]
	[Calls(Type = typeof(TerrainLayer), Member = "get_tileOffset")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 26)]
	private static void SetTerrainTextures(Terrain t, Material m)
	{
	}

	[CallerCount(Count = 0)]
	public TriplanarTerrain()
	{
	}
}
