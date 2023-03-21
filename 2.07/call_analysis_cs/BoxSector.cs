using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BoxSector : MonoBehaviour
{
	[Serializable]
	public struct ObjectDef
	{
		public GameObject m_Object;

		public Renderer m_Renderer;
	}

	public List<ObjectDef> m_GameObjects;

	public List<ObjectDef> m_StructureObjects;

	public List<BoxSector> m_VisibilityList;

	public List<BoxSector> m_StructureVisList;

	public BoxCollider m_LocalCollider;

	public bool m_IsActive;

	private BoxSectorManager m_MyManager;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BoxSector), Member = "GetBoxManager")]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallsUnknownMethods(Count = 4)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BoxSector), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(BoxSector), Member = "OnTriggerEnter")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BoxSector), Member = "Start")]
	private void GetBoxManager()
	{
	}

	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "ForceAllActive")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	public void ShowObject(BoxSectorManager.SectorCullMode cullMode)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "ForceAllInactive")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public void HideObject(BoxSectorManager.SectorCullMode cullMode)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "ForceAllActive")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	public void ShowStructure(BoxSectorManager.SectorCullMode cullMode)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "ForceAllInactive")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	public void HideStructure(BoxSectorManager.SectorCullMode cullMode)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(BoxSector), Member = "GetBoxManager")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Calls(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BoxSector), Member = "GetBoxManager")]
	public void OnTriggerExit(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public BoxSector()
	{
	}
}
