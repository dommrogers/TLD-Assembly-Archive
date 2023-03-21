using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.PDID;
using TLD.Serialization;
using UnityEngine;

public class GearItemInteractabilityControl : MonoBehaviour
{
	private bool m_InteractiveOnStart;

	private bool m_InvisibleToRaycasts;

	private Transform m_AttachmentTransform;

	private bool m_CurrentInteractive;

	private List<GearItem> m_TrackedItems;

	private static List<GearItemInteractabilityControl> s_Instances;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(GearItemInteractabilityControl), Member = "TrackGearItem")]
	[CallsUnknownMethods(Count = 17)]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsUnknownMethods(Count = 8)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GearItemInteractabilityControl), Member = "TrackGearItem")]
	[CallsUnknownMethods(Count = 2)]
	private void OnPrefabSpawnCompleted(List<GameObject> gameObjects)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetInteractive(bool interactive)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "Start")]
	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "OnPrefabSpawnCompleted")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void TrackGearItem(GearItem gearItem)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnInventoryItemAdded(GearItem gearItem)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearItemInteractabilityControl), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 13)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(GearItemInteractabilityControl), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	public static void DeserializeAll(string text)
	{
	}

	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "SerializeAll")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(Type = typeof(Transform), Member = "get_localRotation")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(GearItem), Member = "CreateSaveData")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(GearItemInteractabilityControlSaveData), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private GearItemInteractabilityControlSaveData Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(GearItemInteractabilityControl), Member = "TrackGearItem")]
	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "DeserializeAll")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(GearManager), Member = "Deserialize")]
	private void Deserialize(GearItemInteractabilityControlSaveData saveData)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public GearItemInteractabilityControl()
	{
	}
}
