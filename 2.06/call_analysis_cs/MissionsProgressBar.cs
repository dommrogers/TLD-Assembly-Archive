using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class MissionsProgressBar
{
	public GameObject m_Panel;

	public UILabel m_CountLabel;

	public UISprite m_BarSprite;

	public float m_FillSpriteOffset;

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(MissionsProgressBar), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowCurrentMissionDisplay")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowCurrentMissionDisplay")]
	[CallsUnknownMethods(Count = 2)]
	public void Enable(bool enabled)
	{
	}

	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Utils), Member = "GetWeightOneDecimalPlaceWithUnitsString")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Utils), Member = "GetWeightOneDecimalPlaceWithUnitsString")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(MissionsProgressBar), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateCurrentMissionDisplay")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateCurrentMissionDisplay")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetBlackboardVarAsFloatFullSearch")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(MissionsProgressBar), Member = "FindActiveObjectiveToTrack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetActiveGraphNameFromObjective")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetBlackboardVarAsFloat")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetBlackboardVarAsFloat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetBlackboardVarAsFloatFullSearch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	public void Refresh(List<StoryMissionObjective> objectives)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(MissionsProgressBar), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public static StoryMissionObjective FindActiveObjectiveToTrack(List<StoryMissionObjective> objectives)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public MissionsProgressBar()
	{
	}
}
