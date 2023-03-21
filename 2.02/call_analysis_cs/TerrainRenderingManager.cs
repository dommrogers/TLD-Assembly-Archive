using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
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
		[CallsDeduplicatedMethods(Count = 1)]
		public void Execute()
		{
		}
	}

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

	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(TerrainRenderingManager), Member = "TerrainCentre")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Terrain), Member = "get_drawTreesAndFoliage")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Vector4), Member = "get_zero")]
	[CalledBy(Type = typeof(TerrainRenderingManager), Member = "Start")]
	[CallsUnknownMethods(Count = 4)]
	private Vector4 TerrainCentre(Vector3 worldPos, TerrainData tData)
	{
		return default(Vector4);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(JobHandle), Member = "Complete")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(TerrainRenderingManager), Member = "EnableTerrainTrees")]
	[CalledBy(Type = typeof(TerrainVisibilityTrigger), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(TerrainVisibilityTrigger), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(Terrain), Member = "set_freeUnusedRenderingResources")]
	[Calls(Type = typeof(Terrain), Member = "set_drawHeightmap")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Terrain), Member = "set_freeUnusedRenderingResources")]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(Terrain), Member = "get_terrainData")]
	[Calls(Type = typeof(Terrain), Member = "get_terrainData")]
	[Calls(Type = typeof(TerrainRenderingManager), Member = "EnableTerrainTrees")]
	[Calls(Type = typeof(Terrain), Member = "set_drawHeightmap")]
	public void SetTerrainRendering(List<Terrain> extTerrainList, bool enableTerrain)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_terrain_disabletrees")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyTerrainTrees")]
	[Calls(Type = typeof(Terrain), Member = "set_drawTreesAndFoliage")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_terrain_disabletrees")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Terrain), Member = "set_drawTreesAndFoliage")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyTerrainTrees")]
	public static void ForceDisableTerrainTrees(bool forceDisabled)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(TerrainRenderingManager), Member = "SetTerrainRendering")]
	[CalledBy(Type = typeof(TerrainRenderingManager), Member = "SetTerrainRendering")]
	[CallsUnknownMethods(Count = 7)]
	public static void EnableTerrainTrees(Terrain t, bool enabled)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Terrain), Member = "get_drawTreesAndFoliage")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	public static string GetDebugText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsDisabledTerrainTreesForced()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 8)]
	public TerrainRenderingManager()
	{
	}
}
