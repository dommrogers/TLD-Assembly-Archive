using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Leaderboards;

[StructLayout(0, Pack = 8, Size = 8)]
internal struct CopyLeaderboardRecordByIndexOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private uint m_LeaderboardRecordIndex;

	public uint LeaderboardRecordIndex
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Set(CopyLeaderboardRecordByIndexOptions other)
	{
	}

	[CalledBy(Type = typeof(LeaderboardsInterface), Member = "CopyLeaderboardRecordByIndex")]
	[CallerCount(Count = 1)]
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
