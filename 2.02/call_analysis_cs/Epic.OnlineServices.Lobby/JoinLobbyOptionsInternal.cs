using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct JoinLobbyOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LobbyDetailsHandle;

	private IntPtr m_LocalUserId;

	private int m_PresenceEnabled;

	public LobbyDetails LobbyDetailsHandle
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(JoinLobbyOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(JoinLobbyOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public ProductUserId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(JoinLobbyOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(JoinLobbyOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public bool PresenceEnabled
	{
		[CalledBy(Type = typeof(JoinLobbyOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(JoinLobbyOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JoinLobbyOptionsInternal), Member = "set_LobbyDetailsHandle")]
	[Calls(Type = typeof(JoinLobbyOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(JoinLobbyOptionsInternal), Member = "set_PresenceEnabled")]
	public void Set(JoinLobbyOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(JoinLobbyOptionsInternal), Member = "set_LobbyDetailsHandle")]
	[Calls(Type = typeof(JoinLobbyOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(JoinLobbyOptionsInternal), Member = "set_PresenceEnabled")]
	[CalledBy(Type = typeof(LobbyInterface), Member = "JoinLobby")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Dispose()
	{
	}
}
