using Cpp2ILInjected.CallAnalysis;
using TLD.Scenes.ObjectReferences;
using UnityEngine;

namespace InteractiveObjects;

public class FakeTrackableItem : MonoBehaviour, ITrackable
{
	public float m_EstimateDistanceToRealCache;

	public TrackableItemData m_SceneObject;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SceneObjectReference), Member = "SetOwner")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Awake()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public bool CanTrack()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TransmitterManager), Member = "GetTransmitterState")]
	[Calls(Type = typeof(TransmitterRuntimeState), Member = "get_IsActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public bool IsUnlocked()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1228)]
	[CallsUnknownMethods(Count = 1)]
	public Transform GetTransform()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public TrackableItemType GetItemType()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 27)]
	public TrackableItemData GetItemData()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetEstimatedDistance()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TrackableItemsManager), Member = "GetTrackableItemSavedData")]
	[CallsUnknownMethods(Count = 1)]
	private TrackableItemSaveData GetRuntimeState()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SceneObjectReference), Member = "SetOwner")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FakeTrackableItem()
	{
	}
}
