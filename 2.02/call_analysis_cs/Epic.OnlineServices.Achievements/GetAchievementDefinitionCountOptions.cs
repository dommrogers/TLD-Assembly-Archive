using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

public class GetAchievementDefinitionCountOptions
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public GetAchievementDefinitionCountOptions()
	{
	}
}
