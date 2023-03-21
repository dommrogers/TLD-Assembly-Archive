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
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void AddSector(BoxSector sector)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void RemoveSector(BoxSector sector)
	{
	}

	[CalledBy(Type = typeof(BoxSector), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(BoxSector), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "AddSector")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BoxSector), Member = "HideObject")]
	[Calls(Type = typeof(BoxSector), Member = "HideStructure")]
	[Calls(Type = typeof(BoxSectorManager), Member = "ForceAllActive")]
	[Calls(Type = typeof(BoxSector), Member = "ShowObject")]
	[Calls(Type = typeof(BoxSector), Member = "ShowStructure")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 47)]
	private void UpdateSectors()
	{
	}

	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[CalledBy(Type = typeof(LightingCapture), Member = "Initialize")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BoxSector), Member = "ShowObject")]
	[Calls(Type = typeof(BoxSector), Member = "ShowStructure")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void ForceAllActive()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoxSector), Member = "HideObject")]
	[Calls(Type = typeof(BoxSector), Member = "HideStructure")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void ForceAllInactive()
	{
	}

	[CalledBy(TypeFullName = "LightingCapture.<CaptureFrame>d__15", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BoxSectorManager), Member = "ForceAllActive")]
	[Calls(Type = typeof(BoxSector), Member = "ShowObject")]
	[Calls(Type = typeof(BoxSector), Member = "ShowStructure")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(BoxSector), Member = "HideObject")]
	[Calls(Type = typeof(BoxSector), Member = "HideStructure")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 26)]
	public void RestoreSectorState()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public BoxSectorManager()
	{
	}
}
