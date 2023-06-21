using System;
using Cpp2ILInjected.CallAnalysis;
using InteractiveObjects;
using InteractiveObjects.Custom_Interactions;
using TLD.Scenes.ObjectReferences;
using UnityEngine;

public class TrackableItem : MonoBehaviour, ITrackable
{
	public GameObject m_CoveredObjectRoot;

	public GameObject m_UncoveredObjectRoot;

	private TrackableItemData m_SceneObject;

	private TrackableItemInteraction m_ItemInteraction;

	private Collider m_CacheCollider;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SceneObjectReference), Member = "SetOwner")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Component), Member = "TryGetComponent")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrackableItem), Member = "MaybeUpdateCoveredState")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrackableItem), Member = "GetRuntimeState")]
	[Calls(Type = typeof(TrackableItem), Member = "IsUnlocked")]
	public bool CanTrack()
	{
		return false;
	}

	[CalledBy(Type = typeof(TrackableItem), Member = "CanTrack")]
	[CalledBy(Type = typeof(TrackableItemInteraction), Member = "get_CanInteract")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TransmitterManager), Member = "GetTransmitterState")]
	[Calls(Type = typeof(TransmitterRuntimeState), Member = "get_IsActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public bool IsUnlocked()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1219)]
	[CallsUnknownMethods(Count = 1)]
	public Transform GetTransform()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public TrackableItemType GetItemType()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 29)]
	public TrackableItemData GetItemData()
	{
		return null;
	}

	[CalledBy(Type = typeof(TrackableItem), Member = "CanTrack")]
	[CalledBy(Type = typeof(TrackableItem), Member = "GetItemUncovered")]
	[CalledBy(Type = typeof(TrackableItem), Member = "SetItemUncovered")]
	[CalledBy(Type = typeof(TrackableItem), Member = "MaybeUpdateCoveredState")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TrackableItemsManager), Member = "GetTrackableItemSavedData")]
	[CallsUnknownMethods(Count = 1)]
	private TrackableItemSaveData GetRuntimeState()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrackableItem), Member = "GetRuntimeState")]
	private bool GetItemUncovered()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrackableItem), Member = "GetRuntimeState")]
	[Calls(Type = typeof(TrackableItem), Member = "MaybeUpdateCoveredState")]
	[Calls(Type = typeof(MapDetail), Member = "Unlock")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void SetItemUncovered(bool isUncovered)
	{
	}

	[CalledBy(Type = typeof(TrackableItem), Member = "Start")]
	[CalledBy(Type = typeof(TrackableItem), Member = "SetItemUncovered")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TrackableItem), Member = "GetRuntimeState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void MaybeUpdateCoveredState()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SceneObjectReference), Member = "SetOwner")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MapDetail), Member = "Unlock")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void RevealOnMap()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TrackableItem()
	{
	}
}
