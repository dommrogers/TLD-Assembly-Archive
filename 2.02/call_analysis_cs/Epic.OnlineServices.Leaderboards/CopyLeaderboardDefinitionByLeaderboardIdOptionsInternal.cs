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
		[CalledBy(Type = typeof(CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal), Member = "set_LeaderboardId")]
	public void Set(CopyLeaderboardDefinitionByLeaderboardIdOptions other)
	{
	}

	[CalledBy(Type = typeof(LeaderboardsInterface), Member = "CopyLeaderboardDefinitionByLeaderboardId")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal), Member = "set_LeaderboardId")]
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
