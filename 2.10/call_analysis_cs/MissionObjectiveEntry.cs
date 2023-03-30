using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using TLD.Missions;
using TLD.SaveState;
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

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateTimerObjectiveUI")]
	[Calls(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateCounterUI")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(ActiveMissionManager), Member = "GetObjective")]
	[Calls(Type = typeof(MissionSubobjectiveEntry), Member = "SetObjectiveInfo")]
	[Calls(Type = typeof(MissionSubobjectiveEntry), Member = "GetHeight")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 26)]
	public void SetObjectiveInfo(StoryMissionObjective objective, MissionObjectiveEntry prevEntry, bool skipSubobjectives = false)
	{
	}

	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "SetObjectiveInfo")]
	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "UpdateObjectiveUI")]
	[CalledBy(Type = typeof(MissionSubobjectiveEntry), Member = "SetObjectiveInfo")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionTimerByName")]
	[Calls(Type = typeof(MissionTimer), Member = "get_Time")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsUnknownMethods(Count = 2)]
	private static bool MaybeUpdateTimerObjectiveUI(StoryMissionObjective objective, UILabel timerlabel, Color timerColorLowTime, Color timerColorNormal, UISprite timerSprite)
	{
		return false;
	}

	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "SetObjectiveInfo")]
	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "UpdateObjectiveUI")]
	[CalledBy(Type = typeof(MissionSubobjectiveEntry), Member = "SetObjectiveInfo")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StoryMissionObjective), Member = "TryGetCurrentAndRequired")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringNoOunces")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(Utils), Member = "GetWeightOneDecimalPlaceWithUnitsString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool MaybeUpdateCounterUI(StoryMissionObjective objective, UIWidget widget, float alphaValueWhenCompleted, UILabel countLabel, UISprite countFillSprite, float fillSpriteOffset)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateTimerObjectiveUI")]
	[Calls(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateCounterUI")]
	public static void UpdateObjectiveUI(StoryMissionObjective objective, UILabel timerlabel, UISprite timerSprite, Color timerColorLowTime, Color timerColorNormal, UIWidget widget, float alphaValueWhenCompleted, UILabel countLabel, UISprite countFillSprite, float fillSpriteOffset, ref bool hasTimer, ref bool hasCounter)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MissionObjectiveEntry()
	{
	}
}
