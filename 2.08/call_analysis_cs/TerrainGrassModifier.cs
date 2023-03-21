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
		[CalledBy(Type = typeof(TerrainGrassModifier), Member = "DrawToMap")]
		public ModifiedRegion(int layer, int x, int y, int[,] cellData)
		{
		}
	}

	private Terrain m_Terrain;

	private List<ModifiedRegion> m_ModifiedRegions;

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TerrainData), Member = "SetDetailLayer")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TerrainGrassModifier), Member = "DrawToMap")]
	public void AddGrass(Vector3 position, float radius, int value, int layerIndex)
	{
	}

	[Calls(Type = typeof(TerrainGrassModifier), Member = "DrawToMap")]
	[CallerCount(Count = 0)]
	public void RemoveGrass(Vector3 position, float radius)
	{
	}

	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "Update")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "OnCancel")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "OnCancel")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(TerrainData), Member = "SetDetailLayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 4)]
	public void UndoLastOperation()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(TerrainData), Member = "GetDetailLayer")]
	[Calls(Type = typeof(ModifiedRegion), Member = ".ctor")]
	[Calls(Type = typeof(TerrainData), Member = "SetDetailLayer")]
	[CalledBy(Type = typeof(TerrainGrassModifier), Member = "AddGrass")]
	[CalledBy(Type = typeof(TerrainGrassModifier), Member = "RemoveGrass")]
	[CallsUnknownMethods(Count = 23)]
	private void DrawToMap(Vector3 position, float radius, int value, int layerIndex = -1)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TerrainGrassModifier()
	{
	}
}
