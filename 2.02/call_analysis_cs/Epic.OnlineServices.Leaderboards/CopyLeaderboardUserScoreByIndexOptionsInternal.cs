using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Leaderboards;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct CopyLeaderboardUserScoreByIndexOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private uint m_LeaderboardUserScoreIndex;

	private IntPtr m_StatName;

	public uint LeaderboardUserScoreIndex
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string StatName
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(CopyLeaderboardUserScoreByIndexOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyLeaderboardUserScoreByIndexOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyLeaderboardUserScoreByIndexOptionsInternal), Member = "set_StatName")]
	public void Set(CopyLeaderboardUserScoreByIndexOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CopyLeaderboardUserScoreByIndexOptionsInternal), Member = "set_StatName")]
	[CalledBy(Type = typeof(LeaderboardsInterface), Member = "CopyLeaderboardUserScoreByIndex")]
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
