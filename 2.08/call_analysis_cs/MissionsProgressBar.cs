using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using TLD.SaveState;
using UnityEngine;

[Serializable]
public class MissionsProgressBar
{
	public GameObject m_Panel;

	public UILabel m_CountLabel;

	public UISprite m_BarSprite;

	public float m_FillSpriteOffset;

	[CalledBy(Type = typeof(MissionsProgressBar), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowCurrentMissionDisplay")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void Enable(bool enabled)
	{
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateCurrentMissionDisplay")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(MissionsProgressBar), Member = "FindActiveObjectiveToTrack")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetActiveGraphNameFromObjective")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetBlackboardVarAsFloat")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetBlackboardVarAsFloatFullSearch")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetWeightOneDecimalPlaceWithUnitsString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(MissionsProgressBar), Member = "Enable")]
	[CallsUnknownMethods(Count = 4)]
	public void Refresh(List<StoryMissionObjective> objectives)
	{
	}

	[CalledBy(Type = typeof(MissionsProgressBar), Member = "Refresh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 3)]
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
