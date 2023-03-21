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

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCartographyRegionList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public SurveyRegionInfo()
	{
	}
}
