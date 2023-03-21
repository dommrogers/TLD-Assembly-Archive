using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BoxSectorManager : MonoBehaviour
{
	public enum SectorCullMode
	{
		DisableObject,
		DisableRenderer
	}

	public enum SectorVisMode
	{
		ShowVisListOnEnter,
		HideVisListOnEnter
	}

	public List<BoxSector> m_PrimarySectorList;

	public SectorCullMode m_SectorCullMode;

	public SectorVisMode m_SectorVisMode;

	public bool m_ActivateAllOnExit;

	public bool m_UpdateSectorsOnStart;

	private List<BoxSector> m_CurrentSectors;

	private BoxSector m_CurSector;

	private BoxSector m_LastSector;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CallsUnknownMethods(Count = 7)]
	private void Awake()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void AddSector(BoxSector sector)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void RemoveSector(BoxSector sector)
	{
	}

	[Calls(Type = typeof(BoxSector), Member = "ShowStructure")]
	[Calls(Type = typeof(BoxSector), Member = "ShowObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BoxSector), Member = "HideStructure")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BoxSector), Member = "HideObject")]
	[CalledBy(Type = typeof(BoxSector), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(BoxSector), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BoxSector), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BoxSector), Member = "ShowObject")]
	[Calls(Type = typeof(BoxSector), Member = "ShowStructure")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BoxSector), Member = "HideObject")]
	[Calls(Type = typeof(BoxSector), Member = "HideStructure")]
	[Calls(Type = typeof(BoxSectorManager), Member = "ForceAllActive")]
	[Calls(Type = typeof(BoxSector), Member = "ShowObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BoxSector), Member = "HideObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BoxSector), Member = "ShowStructure")]
	[Calls(Type = typeof(BoxSector), Member = "HideStructure")]
	private void UpdateSectors()
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BoxSector), Member = "ShowObject")]
	[Calls(Type = typeof(BoxSector), Member = "ShowStructure")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[CalledBy(Type = typeof(LightingCapture), Member = "Initialize")]
	[CallsUnknownMethods(Count = 2)]
	public void ForceAllActive()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BoxSector), Member = "HideStructure")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoxSector), Member = "HideObject")]
	public void ForceAllInactive()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(LightingCapture._003CCaptureFrame_003Ed__15), Member = "MoveNext")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BoxSector), Member = "ShowStructure")]
	[Calls(Type = typeof(BoxSector), Member = "ShowObject")]
	[Calls(Type = typeof(BoxSector), Member = "HideStructure")]
	[Calls(Type = typeof(BoxSector), Member = "HideObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BoxSector), Member = "ShowStructure")]
	[Calls(Type = typeof(BoxSector), Member = "ShowObject")]
	[Calls(Type = typeof(BoxSectorManager), Member = "ForceAllActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void RestoreSectorState()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public BoxSectorManager()
	{
	}
}
