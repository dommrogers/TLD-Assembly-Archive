using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct DestroyLobbyOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_LobbyId;

	public ProductUserId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(DestroyLobbyOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(DestroyLobbyOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public string LobbyId
	{
		[CalledBy(Type = typeof(DestroyLobbyOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(DestroyLobbyOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(DestroyLobbyOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(DestroyLobbyOptionsInternal), Member = "set_LobbyId")]
	[CallerCount(Count = 0)]
	public void Set(DestroyLobbyOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DestroyLobbyOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(DestroyLobbyOptionsInternal), Member = "set_LobbyId")]
	[CalledBy(Type = typeof(LobbyInterface), Member = "DestroyLobby")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
