using Cpp2ILInjected.CallAnalysis;
using TLD.SaveState;
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

	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "SetObjectiveInfo")]
	[CalledBy(Type = typeof(MissionUI), Member = "UpdateObjectives")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateTimerObjectiveUI")]
	[Calls(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateCounterUI")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(string), Member = "PadLeft")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 13)]
	public void SetObjectiveInfo(StoryMissionObjective objective, MissionSubobjectiveEntry prevEntry)
	{
	}

	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "SetObjectiveInfo")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[CallsUnknownMethods(Count = 1)]
	public float GetHeight()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MissionSubobjectiveEntry()
	{
	}
}
