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

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[Calls(Type = typeof(EvolveItem), Member = "CanEvolve")]
	[Calls(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EvolveItem), Member = "IsIndoorScene")]
	[Calls(Type = typeof(EvolveItem), Member = "IsInspectingFromHarvest")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(EvolveItem), Member = "ObjectInIndoorTrigger")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(EvolveItem), Member = "CanEvolve")]
	[Calls(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 4)]
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

	[CalledBy(Type = typeof(GearItem), Member = "GetHoverText")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "GetItemInfoString")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	public string GetEvolvedPercentString()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "BuildItemDescription")]
	public string GetTimeToDryStringInventory()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(EvolveItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(EvolveItem), Member = "Update")]
	[Calls(Type = typeof(EvolveItem), Member = "IsInspectingFromHarvest")]
	[Calls(Type = typeof(EvolveItem), Member = "IsIndoorScene")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EvolveItem), Member = "ObjectInIndoorTrigger")]
	private bool CanEvolve()
	{
		return default(bool);
	}

	[Calls(Type = typeof(EvolveItem), Member = "ObjectInIndoorTrigger")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EvolveItem), Member = "IsInspectingFromHarvest")]
	[Calls(Type = typeof(EvolveItem), Member = "IsIndoorScene")]
	[CallsUnknownMethods(Count = 1)]
	private bool CanAutoEvolve()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(EvolveItem), Member = "CanAutoEvolve")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(EvolveItem), Member = "CanEvolve")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CalledBy(Type = typeof(EvolveItem), Member = "Update")]
	private bool IsIndoorScene()
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(EvolveItem), Member = "Update")]
	[CalledBy(Type = typeof(EvolveItem), Member = "CanEvolve")]
	[CalledBy(Type = typeof(EvolveItem), Member = "CanAutoEvolve")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsInspectingFromHarvest()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(EvolveItem), Member = "CanEvolve")]
	[CalledBy(Type = typeof(EvolveItem), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(EvolveItem), Member = "CanAutoEvolve")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 6)]
	private bool ObjectInIndoorTrigger()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 47)]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[CalledBy(Type = typeof(EvolveItem), Member = "Update")]
	[CalledBy(Type = typeof(EvolveItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(Container), Member = "InstantiateGearPrefabInContainer")]
	[CalledBy(Type = typeof(EvolveItem), Member = "Update")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(GearItem), Member = "OverrideOwnership")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(OwnershipManager), Member = "IsUnowned")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 30)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	public void DoEvolution()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public EvolveItem()
	{
	}
}
