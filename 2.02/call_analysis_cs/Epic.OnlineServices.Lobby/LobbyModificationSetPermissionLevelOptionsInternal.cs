using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 8)]
internal struct LobbyModificationSetPermissionLevelOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private LobbyPermissionLevel m_PermissionLevel;

	public LobbyPermissionLevel PermissionLevel
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Set(LobbyModificationSetPermissionLevelOptions other)
	{
	}

	[CalledBy(Type = typeof(LobbyModification), Member = "SetPermissionLevel")]
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
