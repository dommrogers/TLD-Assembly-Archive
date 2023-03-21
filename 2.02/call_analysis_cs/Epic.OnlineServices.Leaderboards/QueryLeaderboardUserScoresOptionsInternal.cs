using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Leaderboards;

[StructLayout(0, Pack = 8, Size = 56)]
internal struct QueryLeaderboardUserScoresOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_UserIds;

	private uint m_UserIdsCount;

	private IntPtr m_StatInfo;

	private uint m_StatInfoCount;

	private long m_StartTime;

	private long m_EndTime;

	public ProductUserId[] UserIds
	{
		[CalledBy(Type = typeof(QueryLeaderboardUserScoresOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public UserScoresQueryStatInfo[] StatInfo
	{
		[CalledBy(Type = typeof(QueryLeaderboardUserScoresOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		set
		{
		}
	}

	public DateTimeOffset? StartTime
	{
		[CalledBy(Type = typeof(QueryLeaderboardUserScoresOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public DateTimeOffset? EndTime
	{
		[CalledBy(Type = typeof(QueryLeaderboardUserScoresOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(QueryLeaderboardUserScoresOptionsInternal), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QueryLeaderboardUserScoresOptionsInternal), Member = "set_UserIds")]
	[Calls(Type = typeof(QueryLeaderboardUserScoresOptionsInternal), Member = "set_StatInfo")]
	[Calls(Type = typeof(QueryLeaderboardUserScoresOptionsInternal), Member = "set_StartTime")]
	[Calls(Type = typeof(QueryLeaderboardUserScoresOptionsInternal), Member = "set_EndTime")]
	public void Set(QueryLeaderboardUserScoresOptions other)
	{
	}

	[CalledBy(Type = typeof(LeaderboardsInterface), Member = "QueryLeaderboardUserScores")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QueryLeaderboardUserScoresOptionsInternal), Member = "Set")]
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
