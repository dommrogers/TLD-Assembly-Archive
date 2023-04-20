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
	[Calls(Type = typeof(Inventory), Member = "add_m_OnInventoryItemAdded")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(GearItemInteractabilityControl), Member = "TrackGearItem")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(Inventory), Member = "remove_m_OnInventoryItemAdded")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GearItemInteractabilityControl), Member = "TrackGearItem")]
	[CallsUnknownMethods(Count = 2)]
	private void OnPrefabSpawnCompleted(List<GameObject> gameObjects)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[CallsUnknownMethods(Count = 2)]
	public void SetInteractive(bool interactive)
	{
	}

	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "Start")]
	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "OnPrefabSpawnCompleted")]
	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "Deserialize")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void TrackGearItem(GearItem gearItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnInventoryItemAdded(GearItem gearItem)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GearItemInteractabilityControl), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GearItemInteractabilityControl), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 4)]
	public static void DeserializeAll(string text)
	{
	}

	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearSaveList), Member = ".ctor")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(GearItem), Member = "CreateSaveData")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 18)]
	private GearItemInteractabilityControlSaveData Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearManager), Member = "Deserialize")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GearItemInteractabilityControl), Member = "TrackGearItem")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 13)]
	private void Deserialize(GearItemInteractabilityControlSaveData saveData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GearItemInteractabilityControl()
	{
	}
}
