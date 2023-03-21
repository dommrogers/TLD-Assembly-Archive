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

	private List<BoxSector> m_CurrentSectors;

	private BoxSector m_CurSector;

	private BoxSector m_LastSector;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void AddSector(BoxSector sector)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void RemoveSector(BoxSector sector)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(BoxSector), Member = "OnTriggerExit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(BoxSector), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "AddSector")]
	[CallsUnknownMethods(Count = 47)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BoxSector), Member = "ShowObject")]
	[Calls(Type = typeof(BoxSector), Member = "ShowStructure")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BoxSector), Member = "HideObject")]
	[Calls(Type = typeof(BoxSector), Member = "HideStructure")]
	[Calls(Type = typeof(BoxSectorManager), Member = "ForceAllActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BoxSector), Member = "ShowStructure")]
	[Calls(Type = typeof(BoxSector), Member = "ShowObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BoxSector), Member = "ShowStructure")]
	[Calls(Type = typeof(BoxSector), Member = "HideStructure")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BoxSector), Member = "HideObject")]
	[Calls(Type = typeof(BoxSector), Member = "ShowObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BoxSector), Member = "HideStructure")]
	[Calls(Type = typeof(BoxSector), Member = "HideObject")]
	private void UpdateSectors()
	{
	}

	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(LightingCapture), Member = "Initialize")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BoxSector), Member = "ShowStructure")]
	[Calls(Type = typeof(BoxSector), Member = "ShowObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void ForceAllActive()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BoxSector), Member = "HideObject")]
	[Calls(Type = typeof(BoxSector), Member = "HideStructure")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void ForceAllInactive()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BoxSector), Member = "ShowStructure")]
	[CalledBy(Type = typeof(LightingCapture._003CCaptureFrame_003Ed__15), Member = "MoveNext")]
	[Calls(Type = typeof(BoxSector), Member = "HideStructure")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BoxSectorManager), Member = "ForceAllActive")]
	[Calls(Type = typeof(BoxSector), Member = "ShowObject")]
	[Calls(Type = typeof(BoxSector), Member = "ShowStructure")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BoxSector), Member = "HideObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BoxSector), Member = "ShowObject")]
	public void RestoreSectorState()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public BoxSectorManager()
	{
	}
}
