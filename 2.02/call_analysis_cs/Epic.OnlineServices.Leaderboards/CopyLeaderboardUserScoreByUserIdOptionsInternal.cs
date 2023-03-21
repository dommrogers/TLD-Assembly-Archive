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
		[CalledBy(Type = typeof(CopyLeaderboardUserScoreByUserIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyLeaderboardUserScoreByUserIdOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string StatName
	{
		[CalledBy(Type = typeof(CopyLeaderboardUserScoreByUserIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyLeaderboardUserScoreByUserIdOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyLeaderboardUserScoreByUserIdOptionsInternal), Member = "set_UserId")]
	[Calls(Type = typeof(CopyLeaderboardUserScoreByUserIdOptionsInternal), Member = "set_StatName")]
	public void Set(CopyLeaderboardUserScoreByUserIdOptions other)
	{
	}

	[CalledBy(Type = typeof(LeaderboardsInterface), Member = "CopyLeaderboardUserScoreByUserId")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CopyLeaderboardUserScoreByUserIdOptionsInternal), Member = "set_UserId")]
	[Calls(Type = typeof(CopyLeaderboardUserScoreByUserIdOptionsInternal), Member = "set_StatName")]
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
