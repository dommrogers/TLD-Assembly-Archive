using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Leaderboards;

public class GetLeaderboardUserScoreCountOptions
{
	private string _003CStatName_003Ek__BackingField;

	public string StatName
	{
		[CallerCount(Count = 52)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public GetLeaderboardUserScoreCountOptions()
	{
	}
}
