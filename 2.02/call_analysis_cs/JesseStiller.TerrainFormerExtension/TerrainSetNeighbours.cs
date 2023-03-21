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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Terrain), Member = "SetNeighbors")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
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
