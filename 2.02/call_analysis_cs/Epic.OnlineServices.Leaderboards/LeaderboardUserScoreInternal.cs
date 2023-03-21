using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Leaderboards;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct LeaderboardUserScoreInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_UserId;

	private int m_Score;

	public ProductUserId UserId
	{
		[CalledBy(Type = typeof(LeaderboardUserScore), Member = "Set")]
		[CalledBy(Type = typeof(LeaderboardUserScore), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 2)]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(LeaderboardUserScoreInternal), Member = "Set")]
		[CalledBy(Type = typeof(LeaderboardUserScoreInternal), Member = "Set")]
		set
		{
		}
	}

	public int Score
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return default(int);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LeaderboardUserScoreInternal), Member = "set_UserId")]
	public void Set(LeaderboardUserScore other)
	{
	}

	[Calls(Type = typeof(LeaderboardUserScoreInternal), Member = "set_UserId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
