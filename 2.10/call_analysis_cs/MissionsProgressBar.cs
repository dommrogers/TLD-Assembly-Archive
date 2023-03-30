using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionsProgressBar), Member = "Enable")]
	public void Refresh(List<StoryMissionObjective> objectives)
	{
	}

	[CallerCount(Count = 0)]
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
