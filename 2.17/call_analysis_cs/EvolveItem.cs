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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EvolveItem), Member = "IsInspectingFromHarvest")]
	[Calls(Type = typeof(EvolveItem), Member = "IsIndoorScene")]
	[Calls(Type = typeof(EvolveItem), Member = "ObjectInIndoorTrigger")]
	[Calls(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[Calls(Type = typeof(EvolveItem), Member = "CanEvolve")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
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
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(EvolveItem), Member = "CanEvolve")]
	[Calls(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	public float GetEvolveProgressValue()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public void SetEvolveProgressValue(float progressVal)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "GetItemInfoString")]
	[CalledBy(Type = typeof(GearItem), Member = "GetHoverStateText")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 3)]
	public string GetEvolvedPercentString()
	{
		return null;
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "BuildItemDescription")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 1)]
	public string GetTimeToDryStringInventory()
	{
		return null;
	}

	[CalledBy(Type = typeof(EvolveItem), Member = "Update")]
	[CalledBy(Type = typeof(EvolveItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(EvolveItem), Member = "IsInspectingFromHarvest")]
	[Calls(Type = typeof(EvolveItem), Member = "IsIndoorScene")]
	[Calls(Type = typeof(EvolveItem), Member = "ObjectInIndoorTrigger")]
	[CallsUnknownMethods(Count = 1)]
	private bool CanEvolve()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EvolveItem), Member = "IsInspectingFromHarvest")]
	[Calls(Type = typeof(EvolveItem), Member = "IsIndoorScene")]
	[Calls(Type = typeof(EvolveItem), Member = "ObjectInIndoorTrigger")]
	[CallsUnknownMethods(Count = 1)]
	private bool CanAutoEvolve()
	{
		return false;
	}

	[CalledBy(Type = typeof(EvolveItem), Member = "Update")]
	[CalledBy(Type = typeof(EvolveItem), Member = "CanEvolve")]
	[CalledBy(Type = typeof(EvolveItem), Member = "CanAutoEvolve")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsIndoorScene()
	{
		return false;
	}

	[CalledBy(Type = typeof(EvolveItem), Member = "Update")]
	[CalledBy(Type = typeof(EvolveItem), Member = "CanEvolve")]
	[CalledBy(Type = typeof(EvolveItem), Member = "CanAutoEvolve")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsInspectingFromHarvest()
	{
		return false;
	}

	[CalledBy(Type = typeof(EvolveItem), Member = "Update")]
	[CalledBy(Type = typeof(EvolveItem), Member = "CanEvolve")]
	[CalledBy(Type = typeof(EvolveItem), Member = "CanAutoEvolve")]
	[CallerCount(Count = 3)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private bool ObjectInIndoorTrigger()
	{
		return false;
	}

	[CalledBy(Type = typeof(EvolveItem), Member = "Update")]
	[CalledBy(Type = typeof(EvolveItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(Container), Member = "InstantiateGearPrefabInContainer")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(OwnershipManager), Member = "IsUnowned")]
	[Calls(Type = typeof(GearItem), Member = "OverrideOwnership")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 19)]
	public void DoEvolution()
	{
	}

	[CallerCount(Count = 0)]
	public EvolveItem()
	{
	}
}
