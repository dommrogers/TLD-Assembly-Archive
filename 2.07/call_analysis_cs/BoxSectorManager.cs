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
	[Calls(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CallsDeduplicatedMethods(Count = 4)]
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

	[CalledBy(Type = typeof(BoxSector), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(BoxSector), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "Awake")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BoxSector), Member = "HideObject")]
	[Calls(Type = typeof(BoxSector), Member = "HideStructure")]
	[Calls(Type = typeof(BoxSectorManager), Member = "ForceAllActive")]
	[Calls(Type = typeof(BoxSector), Member = "ShowObject")]
	[Calls(Type = typeof(BoxSector), Member = "ShowStructure")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 14)]
	private void UpdateSectors()
	{
	}

	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[CalledBy(Type = typeof(LightingCapture), Member = "Initialize")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BoxSector), Member = "ShowObject")]
	[Calls(Type = typeof(BoxSector), Member = "ShowStructure")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void ForceAllActive()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoxSector), Member = "HideObject")]
	[Calls(Type = typeof(BoxSector), Member = "HideStructure")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void ForceAllInactive()
	{
	}

	[CalledBy(TypeFullName = "LightingCapture.<CaptureFrame>d__15", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BoxSectorManager), Member = "ForceAllActive")]
	[Calls(Type = typeof(BoxSector), Member = "ShowObject")]
	[Calls(Type = typeof(BoxSector), Member = "ShowStructure")]
	[Calls(Type = typeof(BoxSector), Member = "HideObject")]
	[Calls(Type = typeof(BoxSector), Member = "HideStructure")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 8)]
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
