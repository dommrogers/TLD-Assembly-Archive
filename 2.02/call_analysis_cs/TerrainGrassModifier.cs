using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TerrainGrassModifier : MonoBehaviour
{
	private class ModifiedRegion
	{
		public int m_Id;

		public int m_DetailLayer;

		public int m_X;

		public int m_Y;

		public int[,] m_CellData;

		public static int m_NextId;

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(TerrainGrassModifier), Member = "DrawToMap")]
		public ModifiedRegion(int layer, int x, int y, int[,] cellData)
		{
		}
	}

	private Terrain m_Terrain;

	private List<ModifiedRegion> m_ModifiedRegions;

	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(TerrainData), Member = "SetDetailLayer")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TerrainGrassModifier), Member = "DrawToMap")]
	public void AddGrass(Vector3 position, float radius, int value, int layerIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TerrainGrassModifier), Member = "DrawToMap")]
	public void RemoveGrass(Vector3 position, float radius)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "OnCancel")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "OnCancel")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(TerrainData), Member = "SetDetailLayer")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void UndoLastOperation()
	{
	}

	[Calls(Type = typeof(TerrainData), Member = "GetDetailLayer")]
	[CalledBy(Type = typeof(TerrainGrassModifier), Member = "RemoveGrass")]
	[CallsUnknownMethods(Count = 35)]
	[CalledBy(Type = typeof(TerrainGrassModifier), Member = "AddGrass")]
	[Calls(Type = typeof(TerrainData), Member = "SetDetailLayer")]
	[Calls(Type = typeof(ModifiedRegion), Member = ".ctor")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	private void DrawToMap(Vector3 position, float radius, int value, int layerIndex = -1)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public TerrainGrassModifier()
	{
	}
}
