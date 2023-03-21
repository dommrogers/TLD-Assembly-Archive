using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using MissionTypes;
using NodeCanvas.Framework;
using TLD.Serialization;
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "GetDictValueIfExists")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateMissionInfo")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "GetDictValueIfExists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "GetDictValueIfExists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 44)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "GetDictValueIfExists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "GetDictValueIfExists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "AddGearItemsToDict")]
	[Calls(Type = typeof(Utils), Member = "GetGearItemsStoredInSceneByPlayer")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "GetDictValueIfExists")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "GetDictValueIfExists")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "GetDictValueIfExists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "GetDictValueIfExists")]
	protected override void OnUpdate()
	{
	}

	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "AddOrIncrementDictEntry")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "AddOrIncrementDictEntry")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "AddOrIncrementDictEntry")]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "AddOrIncrementDictEntry")]
	[CallsUnknownMethods(Count = 2)]
	private void AddGearItemsToDict(GearItem[] gearItems)
	{
	}

	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "AddGearItemsToDict")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "AddGearItemsToDict")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "AddGearItemsToDict")]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "AddGearItemsToDict")]
	[CallerCount(Count = 4)]
	private void AddOrIncrementDictEntry(string key, float val)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	private float GetDictValueIfExists(string key)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Action_WhiteoutGearRequirements()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
