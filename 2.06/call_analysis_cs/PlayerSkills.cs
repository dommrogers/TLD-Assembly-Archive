using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class PlayerSkills : MonoBehaviour
{
	public PlayerSkillsSaveData m_SaveData;

	private HashSet<PlayerSkillType> m_IncreasedSkills;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PlayerSkills), Member = "ShowSkillIncreaseMessages")]
	[CallsUnknownMethods(Count = 1)]
	public float GetSkill(PlayerSkillType playerSkillType)
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void SetSkill(PlayerSkillType playerSkillType, float value)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateSkillAfterCrafting")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSkillAfterRepair")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "CompleteRepair")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "UpdateSkillAfterRepair")]
	[CallsUnknownMethods(Count = 2)]
	public void RollForSkillIncrease(PlayerSkillType playerSkillType, float chance, float increase = 1f)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(PlayerSkills), Member = "GetSkill")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	public void ShowSkillIncreaseMessages()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private string GetIncreaseString(PlayerSkillType playerSkillType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public PlayerSkills()
	{
	}
}
