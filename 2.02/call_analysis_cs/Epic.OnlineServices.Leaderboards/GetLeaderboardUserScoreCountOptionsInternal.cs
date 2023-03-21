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
		[CalledBy(Type = typeof(GetLeaderboardUserScoreCountOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetLeaderboardUserScoreCountOptionsInternal), Member = "set_StatName")]
	public void Set(GetLeaderboardUserScoreCountOptions other)
	{
	}

	[CalledBy(Type = typeof(LeaderboardsInterface), Member = "GetLeaderboardUserScoreCount")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GetLeaderboardUserScoreCountOptionsInternal), Member = "set_StatName")]
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
