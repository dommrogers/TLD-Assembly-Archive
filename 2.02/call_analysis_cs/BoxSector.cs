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
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(BoxSector), Member = "GetBoxManager")]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallsUnknownMethods(Count = 5)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BoxSector), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(BoxSector), Member = "OnTriggerEnter")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BoxSector), Member = "Start")]
	private void GetBoxManager()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "ForceAllActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void ShowObject(BoxSectorManager.SectorCullMode cullMode)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "ForceAllInactive")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void HideObject(BoxSectorManager.SectorCullMode cullMode)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "ForceAllActive")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	public void ShowStructure(BoxSectorManager.SectorCullMode cullMode)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "ForceAllInactive")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void HideStructure(BoxSectorManager.SectorCullMode cullMode)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(BoxSector), Member = "GetBoxManager")]
	[CallsUnknownMethods(Count = 7)]
	public void OnTriggerEnter(Collider other)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(BoxSector), Member = "GetBoxManager")]
	[Calls(Type = typeof(BoxSectorManager), Member = "UpdateSectors")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void OnTriggerExit(Collider other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public BoxSector()
	{
	}
}
