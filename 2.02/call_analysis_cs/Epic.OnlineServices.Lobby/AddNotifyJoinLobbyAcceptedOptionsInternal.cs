using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 4)]
internal struct AddNotifyJoinLobbyAcceptedOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void Set(AddNotifyJoinLobbyAcceptedOptions other)
	{
	}

	[CalledBy(Type = typeof(LobbyInterface), Member = "AddNotifyJoinLobbyAccepted")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
