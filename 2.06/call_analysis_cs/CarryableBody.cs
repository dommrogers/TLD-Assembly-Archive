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

	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CarryableBody), Member = "GetHoverText")]
	[Calls(Type = typeof(Container), Member = "IsEmpty")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void InitializeInteraction(BaseInteraction baseInteraction)
	{
	}

	[Calls(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void PerformInteraction()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "GetHoverText")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CarryableBody), Member = "InitializeInteraction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NPC), Member = "GetHoverText")]
	public string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 6)]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ShowOnMapItem), Member = "AddToMap")]
	[CallsUnknownMethods(Count = 3)]
	public void Dropped()
	{
	}

	[Calls(Type = typeof(ShowOnMapItem), Member = "RemoveFromMap")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	public void StartingPlacement()
	{
	}

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public void OnPlacedInBed(Bed bed)
	{
	}

	[CallerCount(Count = 0)]
	public void OnRemovedFromBed(Bed bed)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public CarryableBody()
	{
	}
}
