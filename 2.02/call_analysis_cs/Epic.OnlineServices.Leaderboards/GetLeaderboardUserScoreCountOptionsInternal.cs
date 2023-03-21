using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Leaderboards;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct GetLeaderboardUserScoreCountOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_StatName;

	public string StatName
	{
		[CalledBy(Type = typeof(GetLeaderboardUserScoreCountOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(GetLeaderboardUserScoreCountOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(GetLeaderboardUserScoreCountOptionsInternal), Member = "set_StatName")]
	[CallerCount(Count = 0)]
	public void Set(GetLeaderboardUserScoreCountOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GetLeaderboardUserScoreCountOptionsInternal), Member = "set_StatName")]
	[CalledBy(Type = typeof(LeaderboardsInterface), Member = "GetLeaderboardUserScoreCount")]
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
