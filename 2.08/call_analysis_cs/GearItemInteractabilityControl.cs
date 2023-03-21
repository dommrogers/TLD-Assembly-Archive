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
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(GearItemInteractabilityControl), Member = "TrackGearItem")]
	[CallsUnknownMethods(Count = 10)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
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

	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void SetInteractive(bool interactive)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "OnPrefabSpawnCompleted")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "Start")]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GearItemInteractabilityControl), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 5)]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(GearItemInteractabilityControl), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	public static void DeserializeAll(string text)
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(GearItem), Member = "CreateSaveData")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "SerializeAll")]
	[Calls(Type = typeof(GearSaveList), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	private GearItemInteractabilityControlSaveData Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 15)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(GearManager), Member = "Deserialize")]
	[Calls(Type = typeof(GearItemInteractabilityControl), Member = "TrackGearItem")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "DeserializeAll")]
	private void Deserialize(GearItemInteractabilityControlSaveData saveData)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public GearItemInteractabilityControl()
	{
	}
}
