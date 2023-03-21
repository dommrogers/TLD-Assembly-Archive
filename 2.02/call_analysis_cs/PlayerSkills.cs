using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayerSkills : MonoBehaviour
{
	public PlayerSkillsSaveData m_SaveData;

	private HashSet<PlayerSkillType> m_IncreasedSkills;

	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(PlayerSkills), Member = "ShowSkillIncreaseMessages")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public float GetSkill(PlayerSkillType playerSkillType)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void SetSkill(PlayerSkillType playerSkillType, float value)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_Repair), Member = "UpdateSkillAfterRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSkillAfterSharpen")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSkillAfterClean")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "CompleteRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSkillAfterRepair")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateSkillAfterCrafting")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanSuccessful")]
	public void RollForSkillIncrease(PlayerSkillType playerSkillType, float chance, float increase = 1f)
	{
	}

	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(PlayerSkills), Member = "GetSkill")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	public void ShowSkillIncreaseMessages()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private string GetIncreaseString(PlayerSkillType playerSkillType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 8)]
	public PlayerSkills()
	{
	}
}
