using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct LobbySearchSetLobbyIdOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LobbyId;

	public string LobbyId
	{
		[CalledBy(Type = typeof(LobbySearchSetLobbyIdOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(LobbySearchSetLobbyIdOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(LobbySearchSetLobbyIdOptionsInternal), Member = "set_LobbyId")]
	[CallerCount(Count = 0)]
	public void Set(LobbySearchSetLobbyIdOptions other)
	{
	}

	[CalledBy(Type = typeof(LobbySearch), Member = "SetLobbyId")]
	[Calls(Type = typeof(LobbySearchSetLobbyIdOptionsInternal), Member = "set_LobbyId")]
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
