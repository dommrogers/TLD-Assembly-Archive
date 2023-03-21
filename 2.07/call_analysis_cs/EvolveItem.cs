using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class EvolveItem : MonoBehaviour
{
	private PanelReference<Panel_Inventory> m_Inventory;

	public GearItem m_GearItemToBecome;

	public int m_StartEvolvePercent;

	public float m_TimeToEvolveGameDays;

	public bool m_RequireIndoors;

	public bool m_ForceNoAutoEvolve;

	private float m_TimeSpentEvolvingGameHours;

	private GearItem m_GearItem;

	private List<Collider> m_IndoorSpaceTriggerColliders;

	private int m_AutoEvolutionCheckCounter;

	private bool m_DoneAutoEvolutionCheck;

	private static EvolveItemSaveData m_EvolveItemSaveData;

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[Calls(Type = typeof(EvolveItem), Member = "CanEvolve")]
	[Calls(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EvolveItem), Member = "IsIndoorScene")]
	[Calls(Type = typeof(EvolveItem), Member = "IsInspectingFromHarvest")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EvolveItem), Member = "ObjectInIndoorTrigger")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EvolveItem), Member = "CanEvolve")]
	[Calls(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	public float GetEvolveProgressValue()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public void SetEvolveProgressValue(float progressVal)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "GetHoverStateText")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "GetItemInfoString")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Replace")]
	public string GetEvolvedPercentString()
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "BuildItemDescription")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CallsUnknownMethods(Count = 1)]
	public string GetTimeToDryStringInventory()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(EvolveItem), Member = "Update")]
	[CalledBy(Type = typeof(EvolveItem), Member = "Deserialize")]
	[Calls(Type = typeof(EvolveItem), Member = "IsIndoorScene")]
	[Calls(Type = typeof(EvolveItem), Member = "IsInspectingFromHarvest")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(EvolveItem), Member = "ObjectInIndoorTrigger")]
	private bool CanEvolve()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EvolveItem), Member = "IsInspectingFromHarvest")]
	[Calls(Type = typeof(EvolveItem), Member = "IsIndoorScene")]
	[Calls(Type = typeof(EvolveItem), Member = "ObjectInIndoorTrigger")]
	[CallsUnknownMethods(Count = 1)]
	private bool CanAutoEvolve()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(EvolveItem), Member = "CanAutoEvolve")]
	[CalledBy(Type = typeof(EvolveItem), Member = "CanEvolve")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CalledBy(Type = typeof(EvolveItem), Member = "Update")]
	private bool IsIndoorScene()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(EvolveItem), Member = "CanAutoEvolve")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(EvolveItem), Member = "Update")]
	[CalledBy(Type = typeof(EvolveItem), Member = "CanEvolve")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsInspectingFromHarvest()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(EvolveItem), Member = "CanEvolve")]
	[CalledBy(Type = typeof(EvolveItem), Member = "Update")]
	[CalledBy(Type = typeof(EvolveItem), Member = "CanAutoEvolve")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 3)]
	private bool ObjectInIndoorTrigger()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(EvolveItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(EvolveItem), Member = "Update")]
	[CalledBy(Type = typeof(EvolveItem), Member = "Update")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(GearItem), Member = "OverrideOwnership")]
	[Calls(Type = typeof(OwnershipManager), Member = "IsUnowned")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 29)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Container), Member = "InstantiateGearPrefabInContainer")]
	[CallsUnknownMethods(Count = 19)]
	public void DoEvolution()
	{
	}

	[CallerCount(Count = 0)]
	public EvolveItem()
	{
	}
}
