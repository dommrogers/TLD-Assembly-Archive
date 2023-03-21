using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Leaderboards;

[StructLayout(0, Pack = 8, Size = 8)]
internal struct CopyLeaderboardDefinitionByIndexOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private uint m_LeaderboardIndex;

	public uint LeaderboardIndex
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Set(CopyLeaderboardDefinitionByIndexOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(LeaderboardsInterface), Member = "CopyLeaderboardDefinitionByIndex")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
