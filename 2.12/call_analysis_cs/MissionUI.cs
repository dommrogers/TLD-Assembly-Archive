using Cpp2ILInjected.CallAnalysis;
using TLD.Missions;
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

	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateObjectives")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ActiveMissionManager), Member = "GetObjective")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(MissionSubobjectiveEntry), Member = "SetObjectiveInfo")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void UpdateObjectives(string missionObjectiveId)
	{
	}

	[CallerCount(Count = 0)]
	public MissionUI()
	{
	}
}
