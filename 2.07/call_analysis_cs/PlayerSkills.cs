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
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetSkill(PlayerSkillType playerSkillType, float value)
	{
	}

	[CalledBy(Type = typeof(Panel_Milling), Member = "CompleteRepair")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "UpdateSkillAfterRepair")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateSkillAfterRepair")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateSkillAfterCrafting")]
	public void RollForSkillIncrease(PlayerSkillType playerSkillType, float chance, float increase = 1f)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerSkills), Member = "GetSkill")]
	public void ShowSkillIncreaseMessages()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private string GetIncreaseString(PlayerSkillType playerSkillType)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public PlayerSkills()
	{
	}
}
