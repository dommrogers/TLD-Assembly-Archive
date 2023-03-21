using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct CopyLobbyDetailsHandleOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LobbyId;

	private IntPtr m_LocalUserId;

	public string LobbyId
	{
		[CalledBy(Type = typeof(CopyLobbyDetailsHandleOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyLobbyDetailsHandleOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	public ProductUserId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyLobbyDetailsHandleOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyLobbyDetailsHandleOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyLobbyDetailsHandleOptionsInternal), Member = "set_LobbyId")]
	[Calls(Type = typeof(CopyLobbyDetailsHandleOptionsInternal), Member = "set_LocalUserId")]
	public void Set(CopyLobbyDetailsHandleOptions other)
	{
	}

	[Calls(Type = typeof(CopyLobbyDetailsHandleOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyLobbyDetailsHandleOptionsInternal), Member = "set_LobbyId")]
	[CalledBy(Type = typeof(LobbyInterface), Member = "CopyLobbyDetailsHandle")]
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
