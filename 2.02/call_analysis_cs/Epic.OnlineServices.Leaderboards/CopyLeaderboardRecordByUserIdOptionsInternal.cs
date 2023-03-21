using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Leaderboards;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct CopyLeaderboardRecordByUserIdOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_UserId;

	public ProductUserId UserId
	{
		[CalledBy(Type = typeof(CopyLeaderboardRecordByUserIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyLeaderboardRecordByUserIdOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyLeaderboardRecordByUserIdOptionsInternal), Member = "set_UserId")]
	public void Set(CopyLeaderboardRecordByUserIdOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CopyLeaderboardRecordByUserIdOptionsInternal), Member = "set_UserId")]
	[CalledBy(Type = typeof(LeaderboardsInterface), Member = "CopyLeaderboardRecordByUserId")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
