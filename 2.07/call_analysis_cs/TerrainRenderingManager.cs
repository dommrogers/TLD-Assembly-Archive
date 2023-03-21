using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

public class TerrainRenderingManager : MonoBehaviour
{
	private struct TerrainDistanceJob : IJob
	{
		public NativeArray<float4> _terPosArr;

		public float4 _camPos;

		public NativeArray<float> _terSqrDistArr;

		[CallerCount(Count = 0)]
		public void Execute()
		{
		}
	}

	private PanelReference<Panel_Loading> m_Loading;

	public List<Terrain> m_TerrainList;

	public List<Terrain> m_DistanceCheckList;

	public float m_SmallDetailDistance;

	public int m_MinimumJobNumber;

	public static bool s_DebugTerrain;

	private float m_DistSqr;

	private NativeArray<float4> m_DistCheckTerrainPosArr;

	private NativeArray<float> m_DistCheckComputedDistanceArr;

	private Dictionary<Terrain, int> m_TerrainVisibilityDict;

	private Dictionary<Terrain, bool> m_TerrainTreeEnabled;

	private static bool s_TerrainTreeForceDisabled;

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Terrain), Member = "get_drawTreesAndFoliage")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private Vector4 TerrainCentre(Vector3 worldPos, TerrainData tData)
	{
		return default(Vector4);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(JobHandle), Member = "Complete")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Terrain), Member = "set_drawHeightmap")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(Terrain), Member = "get_terrainData")]
	[Calls(Type = typeof(Terrain), Member = "set_drawHeightmap")]
	[Calls(Type = typeof(TerrainRenderingManager), Member = "EnableTerrainTrees")]
	[Calls(Type = typeof(Terrain), Member = "set_keepUnusedRenderingResources")]
	[Calls(Type = typeof(Terrain), Member = "get_terrainData")]
	[Calls(Type = typeof(TerrainRenderingManager), Member = "EnableTerrainTrees")]
	[Calls(Type = typeof(Terrain), Member = "set_keepUnusedRenderingResources")]
	[CalledBy(Type = typeof(TerrainVisibilityTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(TerrainVisibilityTrigger), Member = "OnTriggerExit")]
	[CallsUnknownMethods(Count = 15)]
	public void SetTerrainRendering(List<Terrain> extTerrainList, bool enableTerrain)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_terrain_disabletrees")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyTerrainTrees")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_terrain_disabletrees")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyTerrainTrees")]
	[Calls(Type = typeof(Terrain), Member = "set_drawTreesAndFoliage")]
	[Calls(Type = typeof(Terrain), Member = "set_drawTreesAndFoliage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	public static void ForceDisableTerrainTrees(bool forceDisabled)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(TerrainRenderingManager), Member = "SetTerrainRendering")]
	[CalledBy(Type = typeof(TerrainRenderingManager), Member = "SetTerrainRendering")]
	[CallsUnknownMethods(Count = 3)]
	public static void EnableTerrainTrees(Terrain t, bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Terrain), Member = "get_drawTreesAndFoliage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format")]
	public static string GetDebugText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static bool IsDisabledTerrainTreesForced()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public TerrainRenderingManager()
	{
	}
}
