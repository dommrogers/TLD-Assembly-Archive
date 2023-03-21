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
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void AddSector(BoxSector sector)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void RemoveSector(BoxSector sector)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BoxSector), Member = "HideStructure")]
	[Calls(Type = typeof(BoxSector), Member = "ShowStructure")]
	[CalledBy(Type = typeof(BoxSector), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(BoxSector), Member = "ShowObject")]
	[CalledBy(Type = typeof(BoxSector), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(BoxSector), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(BoxSector), Member = "HideObject")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BoxSector), Member = "ShowStructure")]
	[Calls(Type = typeof(BoxSector), Member = "HideObject")]
	[Calls(Type = typeof(BoxSector), Member = "ShowObject")]
	[Calls(Type = typeof(BoxSector), Member = "ShowStructure")]
	[Calls(Type = typeof(BoxSector), Member = "ShowObject")]
	[Calls(Type = typeof(BoxSectorManager), Member = "ForceAllActive")]
	[Calls(Type = typeof(BoxSector), Member = "HideStructure")]
	[Calls(Type = typeof(BoxSector), Member = "HideObject")]
	[Calls(Type = typeof(BoxSector), Member = "HideStructure")]
	private void UpdateSectors()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(LightingCapture), Member = "Initialize")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BoxSector), Member = "ShowStructure")]
	[Calls(Type = typeof(BoxSector), Member = "ShowObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public void ForceAllActive()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BoxSector), Member = "HideStructure")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoxSector), Member = "HideObject")]
	public void ForceAllInactive()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(LightingCapture._003CCaptureFrame_003Ed__15), Member = "MoveNext")]
	[Calls(Type = typeof(BoxSector), Member = "ShowObject")]
	[Calls(Type = typeof(BoxSector), Member = "HideStructure")]
	[Calls(Type = typeof(BoxSector), Member = "ShowStructure")]
	[Calls(Type = typeof(BoxSector), Member = "ShowStructure")]
	[Calls(Type = typeof(BoxSector), Member = "ShowObject")]
	[Calls(Type = typeof(BoxSectorManager), Member = "ForceAllActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BoxSector), Member = "HideObject")]
	public void RestoreSectorState()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public BoxSectorManager()
	{
	}
}
