using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EvolveItem : MonoBehaviour
{
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
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 17)]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(EvolveItem), Member = "CanEvolve")]
	[Calls(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
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
	[CalledBy(Type = typeof(GearItem), Member = "GetHoverText")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string GetEvolvedPercentString()
	{
		return null;
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "BuildItemDescription")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public string GetTimeToDryStringInventory()
	{
		return null;
	}

	[CalledBy(Type = typeof(EvolveItem), Member = "Update")]
	[CalledBy(Type = typeof(EvolveItem), Member = "Deserialize")]
	[CallerCount(Count = 2)]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private bool IsIndoorScene()
	{
		return false;
	}

	[CalledBy(Type = typeof(EvolveItem), Member = "Update")]
	[CalledBy(Type = typeof(EvolveItem), Member = "CanEvolve")]
	[CalledBy(Type = typeof(EvolveItem), Member = "CanAutoEvolve")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsInspectingFromHarvest()
	{
		return false;
	}

	[CalledBy(Type = typeof(EvolveItem), Member = "Update")]
	[CalledBy(Type = typeof(EvolveItem), Member = "CanEvolve")]
	[CalledBy(Type = typeof(EvolveItem), Member = "CanAutoEvolve")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private bool ObjectInIndoorTrigger()
	{
		return false;
	}

	[CalledBy(Type = typeof(EvolveItem), Member = "Update")]
	[CalledBy(Type = typeof(EvolveItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(Container), Member = "InstantiateGearPrefabInContainer")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(OwnershipManager), Member = "IsUnowned")]
	[Calls(Type = typeof(GearItem), Member = "OverrideOwnership")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[CallsDeduplicatedMethods(Count = 25)]
	[CallsUnknownMethods(Count = 47)]
	public void DoEvolution()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public EvolveItem()
	{
	}
}
