using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Leaderboards;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct LeaderboardRecordInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_UserId;

	private uint m_Rank;

	private int m_Score;

	private IntPtr m_UserDisplayName;

	public ProductUserId UserId
	{
		[CalledBy(Type = typeof(LeaderboardRecord), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(LeaderboardRecordInternal), Member = "Set")]
		[CalledBy(Type = typeof(LeaderboardRecordInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public uint Rank
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return 0u;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int Score
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		get
		{
			return 0;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string UserDisplayName
	{
		[CalledBy(Type = typeof(LeaderboardRecord), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(LeaderboardRecordInternal), Member = "Set")]
		[CalledBy(Type = typeof(LeaderboardRecordInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LeaderboardRecordInternal), Member = "set_UserId")]
	[Calls(Type = typeof(LeaderboardRecordInternal), Member = "set_UserDisplayName")]
	public void Set(LeaderboardRecord other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LeaderboardRecordInternal), Member = "set_UserId")]
	[Calls(Type = typeof(LeaderboardRecordInternal), Member = "set_UserDisplayName")]
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
