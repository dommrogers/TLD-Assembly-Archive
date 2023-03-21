using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class SurveyRegionInfo
{
	public string m_RegionName;

	public string m_SceneName;

	public string m_numComplete;

	public float m_CompletePercent;

	public bool m_IsUnlocked;

	public List<SurveyAchievementInfo> m_Achievements;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCartographyRegionList")]
	[CallsUnknownMethods(Count = 7)]
	public SurveyRegionInfo()
	{
	}
}
