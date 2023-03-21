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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowCurrentMissionDisplay")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowCurrentMissionDisplay")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(MissionsProgressBar), Member = "Refresh")]
	public void Enable(bool enabled)
	{
	}

	[Calls(Type = typeof(Utils), Member = "GetWeightOneDecimalPlaceWithUnitsString")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Utils), Member = "GetWeightOneDecimalPlaceWithUnitsString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MissionsProgressBar), Member = "Enable")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateCurrentMissionDisplay")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateCurrentMissionDisplay")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetBlackboardVarAsFloat")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(MissionsProgressBar), Member = "FindActiveObjectiveToTrack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetActiveGraphNameFromObjective")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetBlackboardVarAsFloat")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetBlackboardVarAsFloatFullSearch")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetBlackboardVarAsFloatFullSearch")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	public void Refresh(List<StoryMissionObjective> objectives)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(MissionsProgressBar), Member = "Refresh")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static StoryMissionObjective FindActiveObjectiveToTrack(List<StoryMissionObjective> objectives)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public MissionsProgressBar()
	{
	}
}
