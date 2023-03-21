using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Leaderboards;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct UserScoresQueryStatInfoInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_StatName;

	private LeaderboardAggregation m_Aggregation;

	public string StatName
	{
		[CalledBy(Type = typeof(UserScoresQueryStatInfo), Member = "Set")]
		[CalledBy(Type = typeof(UserScoresQueryStatInfo), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(UserScoresQueryStatInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(UserScoresQueryStatInfoInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public LeaderboardAggregation Aggregation
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return default(LeaderboardAggregation);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserScoresQueryStatInfoInternal), Member = "set_StatName")]
	public void Set(UserScoresQueryStatInfo other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserScoresQueryStatInfoInternal), Member = "set_StatName")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
