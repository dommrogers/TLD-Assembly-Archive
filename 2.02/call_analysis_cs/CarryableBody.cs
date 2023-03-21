using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CarryableBody : MonoBehaviour
{
	public enum PickupIntensity
	{
		Low,
		Medium,
		High
	}

	public GameObject m_FPHGearItemPrefab;

	public LocalizedString m_LocalizedDisplayName;

	public float m_PlacementDistance;

	public AnimationStateRef m_DropAnimation;

	public AnimationStateRef m_DroppedIdleAnimation;

	public AnimationStateRef m_PlacementMeshIdleAnimation;

	public PickupIntensity m_PickupIntensity;

	private ShowOnMapItem m_ShowItemOnMap;

	[NonSerialized]
	public Container m_Container;

	[NonSerialized]
	public NPC m_NPC;

	[NonSerialized]
	public Placeable m_Placeable;

	[NonSerialized]
	public Animator m_Animator;

	[NonSerialized]
	public bool m_ReplacedOriginal;

	[NonSerialized]
	public Bed m_Bed;

	private bool m_HasBeenDropped;

	private bool m_ResumeRequested;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Container), Member = "IsEmpty")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public bool CanInteract()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(NPC), Member = "GetHoverText")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string GetHoverText()
	{
		return null;
	}

	[CalledBy(Type = typeof(Placeable), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ShowOnMapItem), Member = "AddToMap")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void Dropped()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ShowOnMapItem), Member = "RemoveFromMap")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void OnPickedUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeRestoreDroppedAnimation()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void StartingPlacement()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 11)]
	public void OnPlacedInBed(Bed bed)
	{
	}

	[CallerCount(Count = 0)]
	public void OnRemovedFromBed(Bed bed)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public CarryableBody()
	{
	}
}
