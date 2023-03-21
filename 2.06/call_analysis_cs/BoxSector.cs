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
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "ForceAllActive")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	public void ShowObject(BoxSectorManager.SectorCullMode cullMode)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "ForceAllInactive")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void HideObject(BoxSectorManager.SectorCullMode cullMode)
	{
	}

	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "ForceAllActive")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 6)]
	public void ShowStructure(BoxSectorManager.SectorCullMode cullMode)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "ForceAllInactive")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public void HideStructure(BoxSectorManager.SectorCullMode cullMode)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(BoxSector), Member = "GetBoxManager")]
	[CallsUnknownMethods(Count = 4)]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Calls(Type = typeof(BoxSector), Member = "GetBoxManager")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void OnTriggerExit(Collider other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public BoxSector()
	{
	}
}
