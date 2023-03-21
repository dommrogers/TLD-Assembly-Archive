using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HexSectorManager : MonoBehaviour
{
	[Serializable]
	public struct HexExclusion
	{
		public string m_Sector;

		public List<string> m_ExclusionList;
	}

	[Serializable]
	public struct SystemInfo
	{
		public string m_SystemTerrain;

		public string m_SystemObjects;

		public string m_SystemName;

		public int m_SystemSize;

		public float m_LodDist0;

		public float m_LodDist1;

		public float m_LodDist2;

		public List<HexExclusion> m_ExclusionInfo;
	}

	public enum SectorMode
	{
		LOD,
		Vista,
		Scenes
	}

	public List<HexSector> m_PrimarySectorList;

	public float m_UpdateFrequencySeconds;

	public float m_Lod0;

	public float m_Lod1;

	public float m_Lod2;

	public SectorMode m_SectorMode;

	private float m_ElapsedTimeSeconds;

	private int m_CurSectorIndex;

	private int m_PrvSectorIndex;

	private float m_Lod0Adjusted;

	private float m_Lod1Adjusted;

	private float m_Lod2Adjusted;

	private QualityLodBias m_CachedLodBias;

	private bool m_Initialized;

	[Calls(Type = typeof(HexSectorManager), Member = "UpdateSectors")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(HexSectorManager), Member = "GetClosestSectorIndex")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(HexSectorManager), Member = "RefreshLodDistance")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(HexSectorManager), Member = "RefreshLodDistance")]
	[Calls(Type = typeof(HexSectorManager), Member = "GetClosestSectorIndex")]
	[Calls(Type = typeof(HexSectorManager), Member = "UpdateSectors")]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HexSectorManager), Member = "GetClosestSectorIndex")]
	[Calls(Type = typeof(HexSectorManager), Member = "UpdateSectors")]
	public void ForceUpdate()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(HexSectorManager), Member = "ForceUpdate")]
	[CalledBy(Type = typeof(HexSectorManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(HexSectorManager), Member = "Start")]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	private int GetClosestSectorIndex()
	{
		return default(int);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 39)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(HexSectorManager), Member = "Start")]
	[CalledBy(Type = typeof(HexSectorManager), Member = "Update")]
	[CalledBy(Type = typeof(HexSectorManager), Member = "ForceUpdate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(HexSector), Member = "SetSectorLOD")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(HexSector), Member = "SetOnlyLOD")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(HexSector), Member = "SetScene")]
	[Calls(Type = typeof(HexSector), Member = "SetScene")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(HexSector), Member = "SetScene")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(HexSector), Member = "SetSectorLOD")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void UpdateSectors()
	{
	}

	[CalledBy(Type = typeof(HexSectorManager), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(HexSectorManager), Member = "Start")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	private void RefreshLodDistance()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public HexSectorManager()
	{
	}
}
