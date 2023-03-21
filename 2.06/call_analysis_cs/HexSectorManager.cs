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
	[Calls(Type = typeof(HexSectorManager), Member = "RefreshLodDistance")]
	[Calls(Type = typeof(HexSectorManager), Member = "GetClosestSectorIndex")]
	[Calls(Type = typeof(HexSectorManager), Member = "UpdateSectors")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HexSectorManager), Member = "RefreshLodDistance")]
	[Calls(Type = typeof(HexSectorManager), Member = "GetClosestSectorIndex")]
	[Calls(Type = typeof(HexSectorManager), Member = "UpdateSectors")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(HexSectorManager), Member = "Start")]
	[CalledBy(Type = typeof(HexSectorManager), Member = "Update")]
	[CalledBy(Type = typeof(HexSectorManager), Member = "ForceUpdate")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetCurrentCamera")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private int GetClosestSectorIndex()
	{
		return 0;
	}

	[CalledBy(Type = typeof(HexSectorManager), Member = "Start")]
	[CalledBy(Type = typeof(HexSectorManager), Member = "Update")]
	[CalledBy(Type = typeof(HexSectorManager), Member = "ForceUpdate")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HexSector), Member = "SetSectorLOD")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(HexSector), Member = "SetScene")]
	[Calls(Type = typeof(HexSector), Member = "SetOnlyLOD")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateSectors()
	{
	}

	[CalledBy(Type = typeof(HexSectorManager), Member = "Start")]
	[CalledBy(Type = typeof(HexSectorManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshLodDistance()
	{
	}

	[CallerCount(Count = 0)]
	public HexSectorManager()
	{
	}
}
