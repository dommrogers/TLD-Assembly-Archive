using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Terrain), Member = "get_drawTreesAndFoliage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 17)]
	private void Start()
	{
	}

	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
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

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(TerrainVisibilityTrigger), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(TerrainVisibilityTrigger), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(Terrain), Member = "set_keepUnusedRenderingResources")]
	[Calls(Type = typeof(TerrainRenderingManager), Member = "EnableTerrainTrees")]
	[Calls(Type = typeof(Terrain), Member = "set_drawHeightmap")]
	[Calls(Type = typeof(Terrain), Member = "set_drawHeightmap")]
	[Calls(Type = typeof(Terrain), Member = "set_keepUnusedRenderingResources")]
	[Calls(Type = typeof(TerrainRenderingManager), Member = "EnableTerrainTrees")]
	[Calls(Type = typeof(Terrain), Member = "get_terrainData")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Terrain), Member = "get_terrainData")]
	public void SetTerrainRendering(List<Terrain> extTerrainList, bool enableTerrain)
	{
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyTerrainTrees")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_terrain_disabletrees")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_terrain_disabletrees")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyTerrainTrees")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Terrain), Member = "set_drawTreesAndFoliage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Terrain), Member = "set_drawTreesAndFoliage")]
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
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Terrain), Member = "get_drawTreesAndFoliage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	public static string GetDebugText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static bool IsDisabledTerrainTreesForced()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public TerrainRenderingManager()
	{
	}
}
