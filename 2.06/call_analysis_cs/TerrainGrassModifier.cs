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
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsUnknownMethods(Count = 9)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(TerrainData), Member = "SetDetailLayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "Update")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(TerrainData), Member = "SetDetailLayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void UndoLastOperation()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ModifiedRegion), Member = ".ctor")]
	[Calls(Type = typeof(TerrainData), Member = "SetDetailLayer")]
	[CalledBy(Type = typeof(TerrainGrassModifier), Member = "AddGrass")]
	[CalledBy(Type = typeof(TerrainGrassModifier), Member = "RemoveGrass")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(TerrainData), Member = "GetDetailLayer")]
	private void DrawToMap(Vector3 position, float radius, int value, int layerIndex = -1)
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public TerrainGrassModifier()
	{
	}
}
