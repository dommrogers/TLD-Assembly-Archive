using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Leaderboards;

public class GetLeaderboardRecordCountOptions
{
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public GetLeaderboardRecordCountOptions()
	{
	}
}
