using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Leaderboards;

public class GetLeaderboardDefinitionCountOptions
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public GetLeaderboardDefinitionCountOptions()
	{
	}
}
