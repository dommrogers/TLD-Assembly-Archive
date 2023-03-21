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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(UserScoresQueryStatInfo), Member = "Set")]
		[CalledBy(Type = typeof(UserScoresQueryStatInfo), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(UserScoresQueryStatInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(UserScoresQueryStatInfoInternal), Member = "Set")]
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UserScoresQueryStatInfoInternal), Member = "set_StatName")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
