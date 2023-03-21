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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(HexSectorManager), Member = "RefreshLodDistance")]
	[Calls(Type = typeof(HexSectorManager), Member = "GetClosestSectorIndex")]
	[Calls(Type = typeof(HexSectorManager), Member = "UpdateSectors")]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(HexSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(HexSectorManager), Member = "GetClosestSectorIndex")]
	[Calls(Type = typeof(HexSectorManager), Member = "RefreshLodDistance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HexSectorManager), Member = "GetClosestSectorIndex")]
	[Calls(Type = typeof(HexSectorManager), Member = "UpdateSectors")]
	public void ForceUpdate()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(HexSectorManager), Member = "ForceUpdate")]
	[CalledBy(Type = typeof(HexSectorManager), Member = "Start")]
	[CalledBy(Type = typeof(HexSectorManager), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private int GetClosestSectorIndex()
	{
		return default(int);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(HexSectorManager), Member = "ForceUpdate")]
	[CalledBy(Type = typeof(HexSectorManager), Member = "Update")]
	[CalledBy(Type = typeof(HexSectorManager), Member = "Start")]
	[Calls(Type = typeof(HexSector), Member = "SetOnlyLOD")]
	[Calls(Type = typeof(HexSector), Member = "SetScene")]
	[Calls(Type = typeof(HexSector), Member = "SetScene")]
	[Calls(Type = typeof(HexSector), Member = "SetScene")]
	[Calls(Type = typeof(HexSector), Member = "SetSectorLOD")]
	[Calls(Type = typeof(HexSector), Member = "SetSectorLOD")]
	[CallerCount(Count = 3)]
	private void UpdateSectors()
	{
	}

	[CalledBy(Type = typeof(HexSectorManager), Member = "Update")]
	[CalledBy(Type = typeof(HexSectorManager), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	private void RefreshLodDistance()
	{
	}

	[CallerCount(Count = 0)]
	public HexSectorManager()
	{
	}
}
