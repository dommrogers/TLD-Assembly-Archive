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

		[CalledBy(Type = typeof(TerrainGrassModifier), Member = "DrawToMap")]
		[CallerCount(Count = 1)]
		public ModifiedRegion(int layer, int x, int y, int[,] cellData)
		{
		}
	}

	private Terrain m_Terrain;

	private List<ModifiedRegion> m_ModifiedRegions;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TerrainData), Member = "SetDetailLayer")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
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

	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "Update")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "OnCancel")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TerrainData), Member = "SetDetailLayer")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void UndoLastOperation()
	{
	}

	[CalledBy(Type = typeof(TerrainGrassModifier), Member = "AddGrass")]
	[CalledBy(Type = typeof(TerrainGrassModifier), Member = "RemoveGrass")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TerrainData), Member = "GetDetailLayer")]
	[Calls(Type = typeof(ModifiedRegion), Member = ".ctor")]
	[Calls(Type = typeof(TerrainData), Member = "SetDetailLayer")]
	[CallsDeduplicatedMethods(Count = 12)]
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
