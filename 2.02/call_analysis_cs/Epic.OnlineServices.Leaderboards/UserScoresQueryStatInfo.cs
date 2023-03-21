using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Leaderboards;

public class UserScoresQueryStatInfo : ISettable
{
	private string _003CStatName_003Ek__BackingField;

	private LeaderboardAggregation _003CAggregation_003Ek__BackingField;

	public string StatName
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CallerCount(Count = 101)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	public LeaderboardAggregation Aggregation
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return default(LeaderboardAggregation);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UserScoresQueryStatInfoInternal), Member = "get_StatName")]
	[CallsUnknownMethods(Count = 2)]
	internal void Set(UserScoresQueryStatInfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UserScoresQueryStatInfoInternal), Member = "get_StatName")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public UserScoresQueryStatInfo()
	{
	}
}
