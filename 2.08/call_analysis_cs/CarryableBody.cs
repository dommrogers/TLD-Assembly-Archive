using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using TLD.Serialization;
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
	[CallsDeduplicatedMethods(Count = 4)]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Container), Member = "IsEmpty")]
	[Calls(Type = typeof(CarryableBody), Member = "GetHoverText")]
	public void InitializeInteraction(BaseInteraction baseInteraction)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CallsUnknownMethods(Count = 1)]
	public void PerformInteraction()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "GetHoverText")]
	[CalledBy(Type = typeof(CarryableBody), Member = "InitializeInteraction")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NPC), Member = "GetHoverText")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetHoverText()
	{
		return null;
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ShowOnMapItem), Member = "AddToMap")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Dropped()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ShowOnMapItem), Member = "RemoveFromMap")]
	[CallsUnknownMethods(Count = 3)]
	public void OnPickedUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeRestoreDroppedAnimation()
	{
	}

	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
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
	public CarryableBody()
	{
	}
}
