using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using MissionTypes;
using NodeCanvas.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Action_WhiteoutGearRequirements : ActionTask<GraphOwner>
{
	public BBParameter<List<InventoryItemRequirement>> requiredItemsList;

	public List<string> requiredItemsHeaderList;

	public float numLitersPotableWater;

	public float numLitersKerosene;

	public float daysOfFoodRequired;

	public float caloriesPerDay;

	public string sceneToStockpileItems;

	public string hasItemsEvent;

	public string doesNotHaveItemsEvent;

	public BBParameter<string> stockpiledGearSerialized;

	private Dictionary<string, float> m_StockpiledGearDict;

	private List<string> m_ChecklistValsLastFrame;

	private List<bool> m_ChecklistBoolsLastFrame;

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateMissionInfo")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "GetDictValueIfExists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 147)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "GetDictValueIfExists")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "GetDictValueIfExists")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "GetDictValueIfExists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "GetDictValueIfExists")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "AddGearItemsToDict")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 36)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetGearItemsStoredInSceneByPlayer")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "GetDictValueIfExists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "GetDictValueIfExists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "GetDictValueIfExists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "GetDictValueIfExists")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	protected override void OnUpdate()
	{
	}

	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "AddOrIncrementDictEntry")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "AddOrIncrementDictEntry")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[CallsUnknownMethods(Count = 59)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "AddOrIncrementDictEntry")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "AddOrIncrementDictEntry")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void AddGearItemsToDict(GearItem[] gearItems)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "AddGearItemsToDict")]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "AddGearItemsToDict")]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "AddGearItemsToDict")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "AddGearItemsToDict")]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	private void AddOrIncrementDictEntry(string key, float val)
	{
	}

	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	private float GetDictValueIfExists(string key)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 23)]
	public Action_WhiteoutGearRequirements()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
