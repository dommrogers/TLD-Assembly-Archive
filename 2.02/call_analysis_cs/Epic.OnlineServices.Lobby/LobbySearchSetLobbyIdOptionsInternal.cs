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
		[CalledBy(Type = typeof(LobbySearchSetLobbyIdOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbySearchSetLobbyIdOptionsInternal), Member = "set_LobbyId")]
	public void Set(LobbySearchSetLobbyIdOptions other)
	{
	}

	[CalledBy(Type = typeof(LobbySearch), Member = "SetLobbyId")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LobbySearchSetLobbyIdOptionsInternal), Member = "set_LobbyId")]
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
