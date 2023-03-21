using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TerrainVisibilityTrigger : MonoBehaviour
{
	public List<Terrain> m_DisableTerrains;

	private const int TERRAIN_VISIBILITY_TRIGGER_LAYER = 21;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TerrainRenderingManager), Member = "SetTerrainRendering")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TerrainRenderingManager), Member = "SetTerrainRendering")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnTriggerExit(Collider other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TerrainVisibilityTrigger()
	{
	}
}
