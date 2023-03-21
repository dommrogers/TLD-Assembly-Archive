using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Leaderboards;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct CopyLeaderboardUserScoreByUserIdOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_UserId;

	private IntPtr m_StatName;

	public ProductUserId UserId
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(CopyLeaderboardUserScoreByUserIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyLeaderboardUserScoreByUserIdOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	public string StatName
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyLeaderboardUserScoreByUserIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyLeaderboardUserScoreByUserIdOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(CopyLeaderboardUserScoreByUserIdOptionsInternal), Member = "set_StatName")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyLeaderboardUserScoreByUserIdOptionsInternal), Member = "set_UserId")]
	public void Set(CopyLeaderboardUserScoreByUserIdOptions other)
	{
	}

	[CalledBy(Type = typeof(LeaderboardsInterface), Member = "CopyLeaderboardUserScoreByUserId")]
	[Calls(Type = typeof(CopyLeaderboardUserScoreByUserIdOptionsInternal), Member = "set_StatName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CopyLeaderboardUserScoreByUserIdOptionsInternal), Member = "set_UserId")]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
