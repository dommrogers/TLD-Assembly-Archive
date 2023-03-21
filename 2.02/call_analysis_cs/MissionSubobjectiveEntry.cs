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

	[Calls(Type = typeof(string), Member = "PadHelper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "SetObjectiveInfo")]
	[CalledBy(Type = typeof(MissionUI), Member = "UpdateObjectives")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "PadHelper")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateTimerObjectiveUI")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateCounterUI")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public MissionSubobjectiveEntry()
	{
	}
}
