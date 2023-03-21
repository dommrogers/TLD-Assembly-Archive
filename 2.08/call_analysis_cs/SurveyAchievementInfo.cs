using Cpp2ILInjected.CallAnalysis;

public class SurveyAchievementInfo
{
	public string m_AchievementName;

	public bool m_Completed;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SurveyAchievementInfo()
	{
	}
}
