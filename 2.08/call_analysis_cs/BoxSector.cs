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

	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[Calls(Type = typeof(BoxSector), Member = "GetBoxManager")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void Start()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BoxSector), Member = "Start")]
	[CalledBy(Type = typeof(BoxSector), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(BoxSector), Member = "OnTriggerExit")]
	[CallsUnknownMethods(Count = 2)]
	private void GetBoxManager()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "ForceAllActive")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	public void ShowObject(BoxSectorManager.SectorCullMode cullMode)
	{
	}

	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "ForceAllInactive")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
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

	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "ForceAllInactive")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	public void HideStructure(BoxSectorManager.SectorCullMode cullMode)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(BoxSector), Member = "GetBoxManager")]
	[CallsUnknownMethods(Count = 4)]
	public void OnTriggerEnter(Collider other)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(BoxSector), Member = "GetBoxManager")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public void OnTriggerExit(Collider other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BoxSector()
	{
	}
}
