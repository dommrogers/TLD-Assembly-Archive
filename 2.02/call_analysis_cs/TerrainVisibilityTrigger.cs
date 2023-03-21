using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TerrainVisibilityTrigger : MonoBehaviour
{
	public List<Terrain> m_DisableTerrains;

	private const int TERRAIN_VISIBILITY_TRIGGER_LAYER = 21;

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(TerrainRenderingManager), Member = "SetTerrainRendering")]
	[CallsUnknownMethods(Count = 6)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(TerrainRenderingManager), Member = "SetTerrainRendering")]
	[CallsUnknownMethods(Count = 6)]
	private void OnTriggerExit(Collider other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public TerrainVisibilityTrigger()
	{
	}
}
