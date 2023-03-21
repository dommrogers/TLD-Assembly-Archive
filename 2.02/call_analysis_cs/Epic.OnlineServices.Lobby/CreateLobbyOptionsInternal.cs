using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct CreateLobbyOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private uint m_MaxLobbyMembers;

	private LobbyPermissionLevel m_PermissionLevel;

	private int m_PresenceEnabled;

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(CreateLobbyOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CreateLobbyOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public uint MaxLobbyMembers
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public LobbyPermissionLevel PermissionLevel
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool PresenceEnabled
	{
		[CalledBy(Type = typeof(CreateLobbyOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CreateLobbyOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CreateLobbyOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CreateLobbyOptionsInternal), Member = "set_PresenceEnabled")]
	public void Set(CreateLobbyOptions other)
	{
	}

	[CalledBy(Type = typeof(LobbyInterface), Member = "CreateLobby")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CreateLobbyOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CreateLobbyOptionsInternal), Member = "set_PresenceEnabled")]
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
