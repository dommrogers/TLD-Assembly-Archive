using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MissionUI : MonoBehaviour
{
	public Transform m_ObjectiveTransform;

	public UILabel m_MainObjectiveLabel;

	public MissionSubobjectiveEntry[] m_ChecklistEntries;

	public float m_ChallengeChecklistOffsetY;

	public float m_ChallengeChecklistVerticalSpacing;

	public int m_PixelBufferTimer;

	public UISprite m_MainObjectiveSprite;

	private StoryMissionObjective m_ObjectiveToShow;

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateObjectives")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(MissionSubobjectiveEntry), Member = "SetObjectiveInfo")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjective")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjective")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public void UpdateObjectives(string missionObjectiveId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MissionUI()
	{
	}
}
