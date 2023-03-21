using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using MissionTypes;
using NodeCanvas.Framework;
using TLD.SaveState;
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Utils), Member = "GetGearItemsStoredInSceneByPlayer")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "AddGearItemsToDict")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "GetDictValueIfExists")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(float), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(float), Member = "ToString")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateMissionInfo")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(float), Member = "Parse")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 56)]
	protected override void OnUpdate()
	{
	}

	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Action_WhiteoutGearRequirements), Member = "AddOrIncrementDictEntry")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[CallsUnknownMethods(Count = 2)]
	private void AddGearItemsToDict(GearItem[] gearItems)
	{
	}

	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "AddGearItemsToDict")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void AddOrIncrementDictEntry(string key, float val)
	{
	}

	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private float GetDictValueIfExists(string key)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	public Action_WhiteoutGearRequirements()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
