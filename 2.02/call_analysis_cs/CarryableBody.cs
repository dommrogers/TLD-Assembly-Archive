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
	[CallsDeduplicatedMethods(Count = 5)]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Container), Member = "IsEmpty")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[CallsUnknownMethods(Count = 3)]
	public bool CanInteract()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[Calls(Type = typeof(NPC), Member = "GetHoverText")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	public string GetHoverText()
	{
		return null;
	}

	[CalledBy(Type = typeof(Placeable), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsUnknownMethods(Count = 3)]
	public void Update()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ShowOnMapItem), Member = "AddToMap")]
	[CallsUnknownMethods(Count = 4)]
	public void Dropped()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ShowOnMapItem), Member = "RemoveFromMap")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnPickedUp()
	{
	}

	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void MaybeRestoreDroppedAnimation()
	{
	}

	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void StartingPlacement()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 8)]
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
