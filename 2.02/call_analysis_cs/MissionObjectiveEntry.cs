using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MissionObjectiveEntry : MonoBehaviour
{
	public UIWidget m_Widget;

	public UISprite m_CheckboxEntrySprite;

	public UILabel m_ObjectiveDescLabel;

	public Transform m_ObjectiveDescOffset;

	public float m_DescOffestFromCountOrTimer;

	public UISprite m_BGSprite;

	public float m_BGSpriteBaseHeight;

	public UISprite m_ActiveSprite;

	public UISprite m_SuccessSprite;

	public UISprite m_FailSprite;

	public UISprite m_TimerSprite;

	public GameObject m_CountObject;

	public UILabel m_CountLabel;

	public UISprite m_CountFillSprite;

	public float m_FillSpriteOffset;

	public GameObject m_TimerObject;

	public UILabel m_TimerLabel;

	public Transform m_SubobjectivesParent;

	public MissionSubobjectiveEntry[] m_Subobjectives;

	public int m_ObjectiveSpacing;

	public int m_OffsetPerIndent;

	public float m_AlphaValWhenActive;

	public float m_AlphaValWhenCompleted;

	public Color m_TimerColorNormal;

	public Color m_TimerColorLowTime;

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(MissionSubobjectiveEntry), Member = "GetHeight")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(MissionSubobjectiveEntry), Member = "SetObjectiveInfo")]
	[CallsUnknownMethods(Count = 63)]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjective")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateTimerObjectiveUI")]
	[Calls(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateCounterUI")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void SetObjectiveInfo(StoryMissionObjective objective, MissionObjectiveEntry prevEntry, bool skipSubobjectives = false)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(MissionSubobjectiveEntry), Member = "SetObjectiveInfo")]
	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "UpdateObjectiveUI")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(MissionTimer), Member = "get_Time")]
	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "SetObjectiveInfo")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(MissionTimer), Member = "get_Time")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionTimerByName")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private static bool MaybeUpdateTimerObjectiveUI(StoryMissionObjective objective, UILabel timerlabel, Color timerColorLowTime, Color timerColorNormal, UISprite timerSprite)
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "UpdateObjectiveUI")]
	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "SetObjectiveInfo")]
	[CalledBy(Type = typeof(MissionSubobjectiveEntry), Member = "SetObjectiveInfo")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Utils), Member = "GetWeightOneDecimalPlaceWithUnitsString")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringNoOunces")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringNoOunces")]
	[Calls(Type = typeof(StoryMissionObjective), Member = "TryGetCurrentAndRequired")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private static bool MaybeUpdateCounterUI(StoryMissionObjective objective, UIWidget widget, float alphaValueWhenCompleted, UILabel countLabel, UISprite countFillSprite, float fillSpriteOffset)
	{
		return default(bool);
	}

	[Calls(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateCounterUI")]
	[Calls(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateTimerObjectiveUI")]
	[CallerCount(Count = 0)]
	public static void UpdateObjectiveUI(StoryMissionObjective objective, UILabel timerlabel, UISprite timerSprite, Color timerColorLowTime, Color timerColorNormal, UIWidget widget, float alphaValueWhenCompleted, UILabel countLabel, UISprite countFillSprite, float fillSpriteOffset, ref bool hasTimer, ref bool hasCounter)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MissionObjectiveEntry()
	{
	}
}
