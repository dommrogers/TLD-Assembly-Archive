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
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(QueryLeaderboardUserScoresOptionsInternal), Member = "Set")]
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
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(QueryLeaderboardUserScoresOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public DateTimeOffset? EndTime
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(QueryLeaderboardUserScoresOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(QueryLeaderboardUserScoresOptionsInternal), Member = "set_EndTime")]
	[Calls(Type = typeof(QueryLeaderboardUserScoresOptionsInternal), Member = "set_StartTime")]
	[CalledBy(Type = typeof(QueryLeaderboardUserScoresOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(QueryLeaderboardUserScoresOptionsInternal), Member = "set_UserIds")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QueryLeaderboardUserScoresOptionsInternal), Member = "set_StatInfo")]
	public void Set(QueryLeaderboardUserScoresOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(QueryLeaderboardUserScoresOptionsInternal), Member = "Set")]
	[CalledBy(Type = typeof(LeaderboardsInterface), Member = "QueryLeaderboardUserScores")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
