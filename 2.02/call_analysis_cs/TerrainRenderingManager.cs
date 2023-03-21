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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Terrain), Member = "get_drawTreesAndFoliage")]
	[Calls(Type = typeof(TerrainRenderingManager), Member = "TerrainCentre")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 27)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(TerrainRenderingManager), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector4), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private Vector4 TerrainCentre(Vector3 worldPos, TerrainData tData)
	{
		return default(Vector4);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JobHandle), Member = "Complete")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 22)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(TerrainVisibilityTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(TerrainVisibilityTrigger), Member = "OnTriggerExit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Terrain), Member = "get_terrainData")]
	[Calls(Type = typeof(Terrain), Member = "set_drawHeightmap")]
	[Calls(Type = typeof(TerrainRenderingManager), Member = "EnableTerrainTrees")]
	[Calls(Type = typeof(Terrain), Member = "set_freeUnusedRenderingResources")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 14)]
	public void SetTerrainRendering(List<Terrain> extTerrainList, bool enableTerrain)
	{
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyTerrainTrees")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_terrain_disabletrees")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Terrain), Member = "set_drawTreesAndFoliage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public static void ForceDisableTerrainTrees(bool forceDisabled)
	{
	}

	[CalledBy(Type = typeof(TerrainRenderingManager), Member = "SetTerrainRendering")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public static void EnableTerrainTrees(Terrain t, bool enabled)
	{
	}

	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Terrain), Member = "get_drawTreesAndFoliage")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public static string GetDebugText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsDisabledTerrainTreesForced()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public TerrainRenderingManager()
	{
	}
}
