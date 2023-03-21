using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace JesseStiller.TerrainFormerExtension;

public class TerrainSetNeighbours : MonoBehaviour
{
	private Terrain leftTerrain;

	private Terrain topTerrain;

	private Terrain rightTerrain;

	private Terrain bottomTerrain;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Terrain), Member = "SetNeighbors")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	public void SetNeighbours(Terrain leftTerrain, Terrain topTerrain, Terrain rightTerrain, Terrain bottomTerrain)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public TerrainSetNeighbours()
	{
	}
}
