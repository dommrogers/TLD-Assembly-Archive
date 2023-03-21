using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Leaderboards;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LeaderboardId;

	public string LeaderboardId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal), Member = "set_LeaderboardId")]
	public void Set(CopyLeaderboardDefinitionByLeaderboardIdOptions other)
	{
	}

	[Calls(Type = typeof(CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal), Member = "set_LeaderboardId")]
	[CalledBy(Type = typeof(LeaderboardsInterface), Member = "CopyLeaderboardDefinitionByLeaderboardId")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
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
