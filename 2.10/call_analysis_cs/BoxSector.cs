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
	[Calls(Type = typeof(BoxSector), Member = "GetBoxManager")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(BoxSector), Member = "Start")]
	[CalledBy(Type = typeof(BoxSector), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(BoxSector), Member = "OnTriggerExit")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void GetBoxManager()
	{
	}

	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "ForceAllActive")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void ShowObject(BoxSectorManager.SectorCullMode cullMode)
	{
	}

	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "ForceAllInactive")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void HideObject(BoxSectorManager.SectorCullMode cullMode)
	{
	}

	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "ForceAllActive")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void ShowStructure(BoxSectorManager.SectorCullMode cullMode)
	{
	}

	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "ForceAllInactive")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void HideStructure(BoxSectorManager.SectorCullMode cullMode)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(BoxSector), Member = "GetBoxManager")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(BoxSector), Member = "GetBoxManager")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void OnTriggerExit(Collider other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BoxSector()
	{
	}
}
