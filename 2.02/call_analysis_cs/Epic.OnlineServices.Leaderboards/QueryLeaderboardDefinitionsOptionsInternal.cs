using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Leaderboards;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct QueryLeaderboardDefinitionsOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private long m_StartTime;

	private long m_EndTime;

	public DateTimeOffset? StartTime
	{
		[CalledBy(Type = typeof(QueryLeaderboardDefinitionsOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public DateTimeOffset? EndTime
	{
		[CalledBy(Type = typeof(QueryLeaderboardDefinitionsOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(QueryLeaderboardDefinitionsOptionsInternal), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QueryLeaderboardDefinitionsOptionsInternal), Member = "set_StartTime")]
	[Calls(Type = typeof(QueryLeaderboardDefinitionsOptionsInternal), Member = "set_EndTime")]
	public void Set(QueryLeaderboardDefinitionsOptions other)
	{
	}

	[CalledBy(Type = typeof(LeaderboardsInterface), Member = "QueryLeaderboardDefinitions")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QueryLeaderboardDefinitionsOptionsInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void Dispose()
	{
	}
}
