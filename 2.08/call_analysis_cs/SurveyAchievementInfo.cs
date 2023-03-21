using Cpp2ILInjected.CallAnalysis;

public class SurveyAchievementInfo
{
	public string m_AchievementName;

	public bool m_Completed;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public SurveyAchievementInfo()
	{
	}
}
