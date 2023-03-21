using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MissionSubobjectiveEntry : MonoBehaviour
{
	public UIWidget m_Widget;

	public UILabel m_ObjectiveDescLabel;

	public UISprite m_ActiveSprite;

	public UISprite m_SuccessSprite;

	public UISprite m_FailSprite;

	public UISprite m_TimerSprite;

	public GameObject m_CountObject;

	public UILabel m_CountLabel;

	public GameObject m_TimerObject;

	public UILabel m_TimerLabel;

	public int m_ObjectiveSpacing;

	public int m_NumSpacesForIndent;

	public float m_AlphaValWhenActive;

	public float m_AlphaValWhenCompleted;

	public Color m_TimerColorNormal;

	public Color m_TimerColorLowTime;

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(MissionUI), Member = "UpdateObjectives")]
	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "SetObjectiveInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "PadLeft")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(string), Member = "PadLeft")]
	[Calls(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateTimerObjectiveUI")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateCounterUI")]
	public void SetObjectiveInfo(StoryMissionObjective objective, MissionSubobjectiveEntry prevEntry)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "SetObjectiveInfo")]
	[CallsUnknownMethods(Count = 1)]
	public float GetHeight()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MissionSubobjectiveEntry()
	{
	}
}
