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

	[Calls(Type = typeof(GearItemInteractabilityControl), Member = "TrackGearItem")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsUnknownMethods(Count = 4)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearItemInteractabilityControl), Member = "TrackGearItem")]
	[CallsUnknownMethods(Count = 3)]
	private void OnPrefabSpawnCompleted(List<GameObject> gameObjects)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[CallsUnknownMethods(Count = 3)]
	public void SetInteractive(bool interactive)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "Start")]
	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "OnPrefabSpawnCompleted")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	private void TrackGearItem(GearItem gearItem)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnInventoryItemAdded(GearItem gearItem)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItemInteractabilityControl), Member = "Serialize")]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItemInteractabilityControl), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	public static void DeserializeAll(string text)
	{
	}

	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(GearItem), Member = "CreateSaveData")]
	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "SerializeAll")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(GearSaveList), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	private GearItemInteractabilityControlSaveData Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "DeserializeAll")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(GearManager), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItemInteractabilityControl), Member = "TrackGearItem")]
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
