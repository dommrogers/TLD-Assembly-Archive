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
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(LeaderboardRecordInternal), Member = "Set")]
		[CalledBy(Type = typeof(LeaderboardRecordInternal), Member = "Set")]
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
			return default(uint);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int Score
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public string UserDisplayName
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(LeaderboardRecord), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(LeaderboardRecordInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(LeaderboardRecordInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(LeaderboardRecordInternal), Member = "set_UserId")]
	[Calls(Type = typeof(LeaderboardRecordInternal), Member = "set_UserDisplayName")]
	[CallerCount(Count = 0)]
	public void Set(LeaderboardRecord other)
	{
	}

	[Calls(Type = typeof(LeaderboardRecordInternal), Member = "set_UserDisplayName")]
	[Calls(Type = typeof(LeaderboardRecordInternal), Member = "set_UserId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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
